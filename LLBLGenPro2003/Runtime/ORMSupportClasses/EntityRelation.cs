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
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Generic implementation of the IEntityRelation interface, which is used for relations between IEntity* instances.
	/// </summary>
	[Serializable]
	public class EntityRelation : IEntityRelation
	{
		#region Class Member Declarations
			private ArrayList				_primaryKeyFields, _foreignKeyFields;
			private ArrayList				_pkFieldsPersistenceInfo, _fkFieldsPersistenceInfo;
			private RelationType			_typeOfRelation;
			private bool					_fieldsContainPersistenceInfo;
			private IPredicateExpression	_customFilter;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public EntityRelation()
		{
			InitClass();
			_typeOfRelation = RelationType.OneToMany;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="typeOfRelation">The type of relation this instance represents</param>
		public EntityRelation(RelationType typeOfRelation)
		{
			InitClass();
			_typeOfRelation = typeOfRelation;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="primaryKeyField">The IEntityField instance which represents the primary key in the relation</param>
		/// <param name="foreignKeyField">The IEntityField instance which represents the foreign key in the relation</param>
		/// <param name="typeOfRelation">The type of relation this instance represents</param>
		/// <remarks>Selfservicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When the passed in PrimaryKeyField or ForeignKeyField are null</exception>
		public EntityRelation(IEntityField primaryKeyField, IEntityField foreignKeyField, RelationType typeOfRelation)
		{
			InitClass();
			_primaryKeyFields.Add(primaryKeyField);
			_foreignKeyFields.Add(foreignKeyField);
			_pkFieldsPersistenceInfo.Add(null);		// SelfServing situation, add null, so using this object in other template sets will fail.
			_fkFieldsPersistenceInfo.Add(null);		// SelfServing situation, add null, so using this object in other template sets will fail.
			_typeOfRelation = typeOfRelation;
		}


		/// <summary>
		/// Adds a new pair of EntityField instances to the relation. Primary Key fields and Foreign Key Fields have to be added
		/// in pairs. Used by SelfServicing template set.
		/// </summary>
		/// <param name="primaryKeyField">The IEntityField instance which represents a field in the primary key in the relation</param>
		/// <param name="foreignKeyField">The IEntityField instance which represents the corresponding field in the foreign key in the relation</param>
		public void AddEntityFieldPair(IEntityField primaryKeyField, IEntityField foreignKeyField)
		{
			_primaryKeyFields.Add(primaryKeyField);
			_foreignKeyFields.Add(foreignKeyField);
			_pkFieldsPersistenceInfo.Add(null);		// SelfServing situation, add null, so using this object in other template sets will fail.
			_fkFieldsPersistenceInfo.Add(null);		// SelfServing situation, add null, so using this object in other template sets will fail.
		}


		/// <summary>
		/// Adds a new pair of EntityField2 instances to the relation. Primary Key fields and Foreign Key Fields have to be added
		/// in pairs. Used by Adapter template set. Persistence info is set later by the Adapter object.
		/// </summary>
		/// <param name="primaryKeyField">The IEntityField2 instance which represents a field in the primary key in the relation</param>
		/// <param name="foreignKeyField">The IEntityField2 instance which represents the corresponding field in the foreign key in the relation</param>
		public void AddEntityFieldPair(IEntityField2 primaryKeyField, IEntityField2 foreignKeyField)
		{
			_primaryKeyFields.Add(primaryKeyField);
			_foreignKeyFields.Add(foreignKeyField);
			_fieldsContainPersistenceInfo = false;
		}


		/// <summary>
		/// Initializes the class' member variables.
		/// </summary>
		private void InitClass()
		{
			_primaryKeyFields = new ArrayList();
			_foreignKeyFields = new ArrayList();
			_pkFieldsPersistenceInfo = new ArrayList();
			_fkFieldsPersistenceInfo = new ArrayList();
			_fieldsContainPersistenceInfo = true;
			_customFilter = null;
		}


		/// <summary>
		/// Gets the IFieldPersistenceInfo data for the PK field at index specified.
		/// </summary>
		/// <param name="index">index of the field in the list of PK fields.</param>
		/// <returns>IFieldPersistenceInfo object</returns>
		public IFieldPersistenceInfo GetPKFieldPersistenceInfo(int index)
		{
			if(_fieldsContainPersistenceInfo)
			{
				return (IFieldPersistenceInfo)_primaryKeyFields[index];
			}
			else
			{
				return (IFieldPersistenceInfo)_pkFieldsPersistenceInfo[index];
			}
		}


		/// <summary>
		/// Returns in an arraylist all IEntityFieldCore objects for the PK fields in this entityrelation
		/// </summary>
		/// <returns>ArrayList with the requested objects</returns>
		public ArrayList GetAllPKEntityFieldCoreObjects()
		{
			return _primaryKeyFields;
		}


		/// <summary>
		/// Returns in an arraylist all IEntityFieldCore objects for the FK fields in this entityrelation
		/// </summary>
		/// <returns>ArrayList with the requested objects</returns>
		public ArrayList GetAllFKEntityFieldCoreObjects()
		{
			return _foreignKeyFields;
		}


		/// <summary>
		/// Returns in an arraylist all IFieldPersistenceInfo objects for the FK fields in this entityrelation
		/// </summary>
		/// <returns>ArrayList with the requested objects</returns>
		public ArrayList GetAllFKFieldPersistenceInfoObjects()
		{
			ArrayList toReturn = new ArrayList(_foreignKeyFields.Count);

			if(_fieldsContainPersistenceInfo)
			{
				for (int i = 0; i < _foreignKeyFields.Count; i++)
				{
					toReturn.Add((IFieldPersistenceInfo)_foreignKeyFields[i]);
				}
			}
			else
			{
				for (int i = 0; i < _fkFieldsPersistenceInfo.Count; i++)
				{
					toReturn.Add((IFieldPersistenceInfo)_fkFieldsPersistenceInfo[i]);
				}
			}

			return toReturn;
		}


		/// <summary>
		/// Returns in an arraylist all IFieldPersistenceInfo objects for the PK fields in this entityrelation
		/// </summary>
		/// <returns>ArrayList with the requested objects</returns>
		public ArrayList GetAllPKFieldPersistenceInfoObjects()
		{
			ArrayList toReturn = new ArrayList(_primaryKeyFields.Count);

			if(_fieldsContainPersistenceInfo)
			{
				for (int i = 0; i < _primaryKeyFields.Count; i++)
				{
					toReturn.Add((IFieldPersistenceInfo)_primaryKeyFields[i]);
				}
			}
			else
			{
				for (int i = 0; i < _pkFieldsPersistenceInfo.Count; i++)
				{
					toReturn.Add((IFieldPersistenceInfo)_pkFieldsPersistenceInfo[i]);
				}
			}

			return toReturn;
		}


		/// <summary>
		/// Gets the IFieldPersistenceInfo data for the FK field at index specified.
		/// </summary>
		/// <param name="index">index of the field in the list of FK fields.</param>
		/// <returns>IFieldPersistenceInfo object</returns>
		public IFieldPersistenceInfo GetFKFieldPersistenceInfo(int index)
		{
			if(_fieldsContainPersistenceInfo)
			{
				return (IFieldPersistenceInfo)_foreignKeyFields[index];
			}
			else
			{
				return (IFieldPersistenceInfo)_fkFieldsPersistenceInfo[index];
			}
		}


		/// <summary>
		/// Gets the IEntityFieldCode information about the PK field at index specified
		/// </summary>
		/// <param name="index">index of field in the list of PK fields</param>
		/// <returns>IEntityFieldCode object</returns>
		public IEntityFieldCore GetPKEntityFieldCore(int index)
		{
			return (IEntityFieldCore)_primaryKeyFields[index];
		}


		/// <summary>
		/// Gets the IEntityFieldCode information about the FK field at index specified
		/// </summary>
		/// <param name="index">index of field in the list of FK fields</param>
		/// <returns>IEntityFieldCode object</returns>
		public IEntityFieldCore GetFKEntityFieldCore(int index)
		{
			return (IEntityFieldCore)_foreignKeyFields[index];
		}


		/// <summary>
		/// Sets the IFieldPersistenceInfo data for the PK field at index specified.
		/// </summary>
		/// <param name="index">index of the field in the list of PK fields.</param>
		/// <param name="persistenceInfo">The persistence info for the entity field at position index.</param>
		/// <remarks>Used by DataAccessAdapter objects.</remarks>
		public void SetPKFieldPersistenceInfo(int index, IFieldPersistenceInfo persistenceInfo)
		{
			_pkFieldsPersistenceInfo.Insert(index, persistenceInfo);
		}


		/// <summary>
		/// Sets the IFieldPersistenceInfo data for the FK field at index specified.
		/// </summary>
		/// <param name="index">index of the field in the list of FK fields.</param>
		/// <param name="persistenceInfo">The persistence info for the entity field at position index.</param>
		/// <remarks>Used by DataAccessAdapter objects.</remarks>
		public void SetFKFieldPersistenceInfo(int index, IFieldPersistenceInfo persistenceInfo)
		{
			_fkFieldsPersistenceInfo.Insert(index, persistenceInfo);
		}


		/// <summary>
		/// Determines if this relation is a weak relation (true) or not (false). 1:m is always weak by definition. 1:1
		/// relations are weak when relation is seen from PK entity, otherwise always strong (when seen from FK entity).
		/// This can't be determined here, so 1:1 relations are always reported 'weak'. 
		/// </summary>
		/// <returns>true when this relation is weak, false otherwise. Returns false by default.</returns>
		/// <remarks>Sees 1:1 not as a strong relation per se. Earlier versions did so.</remarks>
		private bool DetermineIfIsWeak()
		{
			bool relationIsWeak = false;

			switch(_typeOfRelation)
			{
				case RelationType.ManyToOne:
					// weak if the FK field is nullable. 
					relationIsWeak = false;
					if(_foreignKeyFields.Count<=0)
					{
						// no fields set, return false;
						relationIsWeak = false;
					}

					for(int j=0;j<_foreignKeyFields.Count;j++)
					{
						if(GetFKFieldPersistenceInfo(j).SourceColumnIsNullable)
						{
							// can be nulled, weak relation
							relationIsWeak=true;
							break;
						}
					}
					break;
				case RelationType.OneToMany:
					// always weak
					relationIsWeak = true;
					break;
				case RelationType.OneToOne:
					// always weak. Will change in user.
					relationIsWeak = true;
					break;
				default:
					// default behaviour. 
					relationIsWeak = false;
					break;
			}

			return relationIsWeak;
		}


		#region Class Property Declarations
		/// <summary>
		/// The relation type the IEntityRelation instance represents.
		/// </summary>
		public RelationType TypeOfRelation 
		{ 
			get { return _typeOfRelation;}
			set { _typeOfRelation = value;}
		}

		/// <summary>
		/// Flag to signal if this relation is a 'weak' relation or not. Weak relations are optional relations, which means when A and B have a 
		/// weak relation, not all instances of A have to have a related instance of B.
		/// </summary>
		public bool IsWeak 
		{
			get { return DetermineIfIsWeak(); }
		}

		/// <summary>
		/// Returns the amount of fields in the EntityRelation object.
		/// </summary>
		public int AmountFields 
		{	
			get { return _primaryKeyFields.Count;}
		}


		/// <summary>
		/// Custom filter for JOIN clauses which are added with AND to the ON clause resulting from this EntityRelation. By adding a
		/// predicate expression with fieldcomparevalue predicate objects for example, you can add extra filtering inside the JOIN.
		/// </summary>
		public IPredicateExpression CustomFilter
		{
			get
			{
				return _customFilter;
			}
			set
			{
				_customFilter = value;
			}
		}
		#endregion
		
	}
}