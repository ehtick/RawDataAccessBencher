/////////////////////////////////////////////////////////////
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Base class for DAO classes which are generated.
	/// </summary>
	public abstract class DaoBase : IDao
	{
		#region Class Member Declarations
			private ITypeDefaultValue _typeDefaultValueSupplier;
		#endregion
		
		/// <summary>
		/// CTor
		/// </summary>
		public DaoBase()
		{
			_typeDefaultValueSupplier = null;
		}

		
		/// <summary>
		/// Executes the passed in action query and, if not null, runs it inside the passed in transaction.
		/// </summary>
		/// <param name="queryToExecute">ActionQuery to execute.</param>
		/// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
		/// <returns>execution result, which is the amount of rows affected (if applicable)</returns>
		public virtual int ExecuteActionQuery(IActionQuery queryToExecute, ITransaction containingTransaction)
		{
			WireTransaction(queryToExecute, containingTransaction);
			return queryToExecute.Execute();
		}


		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 row.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
		/// <param name="fieldsToFill">The IEntityFields object to store the fetched data in</param>
		public virtual void ExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, IEntityFields fieldsToFill)
		{
			WireTransaction(queryToExecute, containingTransaction);

			bool isConnectionOpenedExternal=(containingTransaction!=null);
			if(isConnectionOpenedExternal)
			{
				isConnectionOpenedExternal=(containingTransaction.ConnectionToUse.State==ConnectionState.Open);
			}
			IDataReader dataSource = null;
			try
			{
				if(!isConnectionOpenedExternal)
				{
					queryToExecute.Connection.Open();
				}

				dataSource = queryToExecute.Execute(CommandBehavior.SingleRow);
				FetchOneRow(dataSource, fieldsToFill);
			}
			// all exceptions are fatal.
			finally
			{
				if(dataSource!=null)
				{
					if(!dataSource.IsClosed)
					{
						dataSource.Close();
					}
					dataSource.Dispose();
				}
				if(!isConnectionOpenedExternal)
				{
					queryToExecute.Connection.Close();
				}
			}
		}


		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 row.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
		/// <param name="entityFactory">the factory object which can produce the entities this method has to fill.</param>
		/// <param name="collectionToFill">Collection to fill with the retrieved rows.</param>
		/// <param name="allowDuplicates">Flag to signal if duplicates in the datastream should be loaded into the collection (true) or not (false)</param>
		/// <param name="validatorToUse">Validator object to use when creating a new entity. Can be null.</param>
		public virtual void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, 
					IEntityFactory entityFactory, IEntityCollection collectionToFill, bool allowDuplicates, IValidator validatorToUse)
		{
			WireTransaction(queryToExecute, containingTransaction);

			// construct hashtable for filtering out duplicates. Each hashtable entry is at first a section of
			// empty cells. When a hashcode is found in the set of hashes, add an entry, if not existend to this
			// hashtable. When the hashcode already is added to this hashtable, the entity of the new hashcode is
			// compared to all the entities with the same hashcode in the list related to the hashcode in this table.
			// when an equal object is found, it's a real duplicate, otherwise the entity is added to the list and the
			// collection.
			Hashtable objectHashtable = new Hashtable();
			Hashtable objectHashes = new Hashtable();
			IDataReader dataSource = null;
			EntityCollectionBase collection = (EntityCollectionBase)collectionToFill;		// pre-cast collection.

			bool isConnectionOpenedExternal=(containingTransaction!=null);
			if(isConnectionOpenedExternal)
			{
				isConnectionOpenedExternal=(containingTransaction.ConnectionToUse.State==ConnectionState.Open);
			}

			// first add the existing objects to the hashtables, if they're not new
			for (int i = 0; i < collection.Count; i++)
			{
				IEntity currentEntity = (IEntity)collection.Items[i];
				if(currentEntity.IsNew)
				{
					continue;
				}
				CheckForDuplicate(currentEntity, ref objectHashtable, ref objectHashes);
			}

			try
			{
				if(!isConnectionOpenedExternal)
				{
					queryToExecute.Connection.Open();
				}

				dataSource = queryToExecute.Execute(CommandBehavior.Default);
				if(dataSource==null)
				{
					// nothing to read from
					return;
				}

				if(dataSource.IsClosed)
				{
					// can't read
					return;
				}
				// for each row fetched, create a new entity and fill it with the row
				int[] fieldIndexToOrdinal = null; 
				while(dataSource.Read())
				{
					IEntity entityToAdd = entityFactory.Create();
					if(containingTransaction!=null)
					{
						containingTransaction.Add((EntityBase)entityToAdd);
					}
					if(fieldIndexToOrdinal==null)
					{
						fieldIndexToOrdinal = new int[entityToAdd.Fields.Count];
						for (int i = 0; i < fieldIndexToOrdinal.Length; i++)
						{
							fieldIndexToOrdinal[i]=-1;
						}
					}
					if(validatorToUse!=null)
					{
						entityToAdd.Validator = validatorToUse;
					}
					ReadRowIntoFields(dataSource, entityToAdd.Fields, ref fieldIndexToOrdinal);

					// set state.
					entityToAdd.Fields.State = EntityState.Fetched;
					// it should be set to false, because the entity is read from the database
					entityToAdd.IsNew=false;	

					if(allowDuplicates)
					{
						// add it to the collection.
						collection.FastAdd(entityToAdd);
					}
					else
					{
						// test if we already have read this entity in the resultset or if it's already present in the collection. If not, read it.
						if(CheckForDuplicate(entityToAdd, ref objectHashtable, ref objectHashes))
						{
							// add it to the collection.
							collection.FastAdd(entityToAdd);
						}
					}
				}
			}
			// all exceptions are fatal.
			finally
			{
				if(dataSource!=null)
				{
					if(!dataSource.IsClosed)
					{
						dataSource.Close();
					}
					dataSource.Dispose();
				}
				if(!isConnectionOpenedExternal)
				{
					queryToExecute.Connection.Close();
				}
			}
		}


		/// <summary>
		/// Executes the passed in retrieval query and returns the results as a datatable using the passed in data-adapter. 
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param>
		/// <returns>DataTable with the rows requested</returns>
		public virtual DataTable ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse)
		{
			DataTable toReturn = new DataTable();
			// wire up connection, command with adapter
			((IDbDataAdapter)dataAdapterToUse).SelectCommand = queryToExecute.Command;
			dataAdapterToUse.Fill(toReturn);
			return toReturn;
		}


		/// <summary>
		/// Executes the passed in retrieval query and returns the results in thedatatable specified using the passed in data-adapter. 
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param>
		/// <param name="tableToFill">DataTable to fill</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, DataTable tableToFill)
		{
			// wire up connection, command with adapter
			((IDbDataAdapter)dataAdapterToUse).SelectCommand = queryToExecute.Command;
			dataAdapterToUse.Fill(tableToFill);
			return true;
		}


		/// <summary>
		/// Wires the passed in transaction to the command object of the passed in query. If no transaction is passed in, nothing is wired.
		/// </summary>
		/// <param name="queryToWire">Query to wire up with the passed in transaction</param>
		/// <param name="activeTransaction">transaction to wire to the query</param>
		public virtual void WireTransaction(IQuery queryToWire, ITransaction activeTransaction)
		{
			if(activeTransaction==null)
			{
				// nothing to wire
				return;
			}

			queryToWire.Command.Transaction = activeTransaction.PhysicalTransaction;
		}


		/// <summary>
		/// Checks if the passed in entity is present in the hashtables passed in. If so
		/// </summary>
		/// <param name="entityToAdd">Entity which has to be tested if there was already a duplicate in the hashtables.</param>
		/// <param name="objectHashtable">See remarks</param>
		/// <param name="objectHashes">See remarks</param>
		/// <returns>true if there is no duplicate for hte passed in entity seen yet. False otherwise</returns>
		/// <remarks>construct hashtable for filtering out duplicates. Each hashtable entry is at first a section of
		/// empty cells. When a hashcode is found in the set of hashes, add an entry, if not existend to this
		/// hashtable. When the hashcode already is added to this hashtable, the entity of the new hashcode is
		/// compared to all the entities with the same hashcode in the list related to the hashcode in this table.
		/// when an equal object is found, it's a real duplicate, otherwise the entity is added to the list and the
		/// collection.</remarks>
		private bool CheckForDuplicate(IEntity entityToAdd, ref Hashtable objectHashtable, ref Hashtable objectHashes)
		{
			int entityHash = entityToAdd.GetHashCode();
			bool noDuplicateSeen=false;
			if(!objectHashes.ContainsKey(entityHash))
			{
				// no, so add it to the collection and its hash to the hashlist.
				objectHashes.Add(entityHash, null);
				// add new hash bucket to hashtable
				ArrayList newBucket = new ArrayList();
				newBucket.Add(entityToAdd);
				objectHashtable.Add(entityHash, newBucket);
				// flag that no duplicate has been seen.
				noDuplicateSeen=true;
			}
			else
			{
				// hashcode exists. Bucket is there.
				// Check if the entity is equal to any of the entities in the list related to this hashcode.
				ArrayList bucket = (ArrayList)objectHashtable[entityHash];
				bool equalFound=false;
				for (int i = 0; i < bucket.Count; i++)
				{
					EntityBase currentEntity=(EntityBase)bucket[i];
					equalFound = currentEntity.Equals(entityToAdd);
					if(equalFound)
					{
						// duplicate
						break;
					}
				}

				if(!equalFound)
				{
					// not found, no duplicate
					noDuplicateSeen=true;
					bucket.Add(entityToAdd);
				}
			}

			return noDuplicateSeen;
		}


		/// <summary>
		/// Fetches one row from the open data-reader and places that row into the passed in object rowDestination. rowDestination
		/// should match the format of the rows read by DataSource. Will only read the current row.
		/// </summary>
		/// <param name="dataSource">The open datareader used to fetch the data</param>
		/// <param name="rowDestination">The IEntityFields implementing object where the data should be stored.</param>
		private void FetchOneRow(IDataReader dataSource, IEntityFields rowDestination)
		{
			if(dataSource==null)
			{
				// nothing to read from
				return;
			}

			if(dataSource.IsClosed)
			{
				// can't read
				return;
			}

			// read 1 row. First advance to first byte
			if(dataSource.Read())
			{
				// sets current value directly, bypassing NewValue. If the resultset doesn't contain the requested column, the underlying persistent
				// storage has been changed compared to the generated code and the code should be re-generated. A column mismatch will result in an exception.
				int[] fieldIndexToOrdinal = new int[rowDestination.Count];
				for (int i = 0; i < fieldIndexToOrdinal.Length; i++)
				{
					fieldIndexToOrdinal[i]=-1;
				}
				ReadRowIntoFields(dataSource, rowDestination, ref fieldIndexToOrdinal);

				// set state to fetched
				rowDestination.State = EntityState.Fetched;
			}
		}


		/// <summary>
		/// Fetches one row from the open data-reader and places that row into the passed in object rowDestination. rowDestination
		/// should match the format of the rows read by DataSource. Will only read the current row. The datareader is assumed to be initialized, which means, the 
		/// datareader is actually holding a row. (i.e. 'Read()' is called)
		/// </summary>
		/// <param name="dataSource">The open datareader used to fetch the data</param>
		/// <param name="rowDestination">The IEntityFields implementing object where the data should be stored.</param>
		/// <param name="fieldIndexToOrdinal">Array with ordinal positions per field index. Use the field index to index into this array to retrieve its ordinal.
		/// Is constructed at runtime, the first time this method is called. Speeds up multi-row retrieval queries.</param>
		private void ReadRowIntoFields(IDataReader dataSource, IEntityFields rowDestination, ref int[] fieldIndexToOrdinal)
		{
			// sets current value directly, bypassing NewValue. If the resultset doesn't contain the requested column, the underlying persistent
			// storage has been changed compared to the generated code and the code should be re-generated. A column mismatch will result in an exception.
			int columnOrdinal = 0;
			for(int i=0;i<rowDestination.Count;i++)
			{
				if(fieldIndexToOrdinal[i]==-1)
				{
					// not initialized yet, set ordinal
					// prepare for aliases. 
					try
					{
						if(rowDestination[i].SourceColumnName!=rowDestination[i].Name)
						{
							// field is aliased in query, use field name
							columnOrdinal = dataSource.GetOrdinal(rowDestination[i].Name);
						}
						else
						{
							// use sourcecolumn
							columnOrdinal = dataSource.GetOrdinal(rowDestination[i].SourceColumnName);
						}
					}
					catch
					{
						// name not found. 
						columnOrdinal=i;
					}

					fieldIndexToOrdinal[i]=columnOrdinal;
				}
				else
				{
					columnOrdinal = fieldIndexToOrdinal[i];
				}
				object valueInField = dataSource[columnOrdinal];
#if MONO
				bool isColumnValueDBNull = dataSource.IsDBNull(columnOrdinal);
#else
				bool isColumnValueDBNull = (dataSource[columnOrdinal] == System.DBNull.Value);
#endif
				rowDestination[i].IsNull = isColumnValueDBNull;
				if(isColumnValueDBNull)
				{
					// Store default value for null for type
					rowDestination[i].ForcedCurrentValueWrite(_typeDefaultValueSupplier.DefaultValue(rowDestination[i].DataType));
				}
				else
				{
					// simply store the value
					rowDestination[i].ForcedCurrentValueWrite(valueInField);
				}
			}
		}


		#region Class Property Declarations
		/// <summary>
		/// Class which will supply the default value for a specified .NET type. Necessary for rowfetchers when a NULL field is found.
		/// </summary>
		public virtual ITypeDefaultValue TypeDefaultValueSupplier
		{
			get { return _typeDefaultValueSupplier; }
			set { _typeDefaultValueSupplier = value; }
		}
		#endregion
		
	}
}