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

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Implementation of the RetrievalQuery class. 
	/// </summary>
	[Serializable]
	public class RetrievalQuery : Query, IRetrievalQuery
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="commandToUse">Command to use</param>
		public RetrievalQuery(IDbCommand commandToUse):base(commandToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionToUse">Connection object to use</param>
		/// <param name="commandToUse">Command to use</param>
		public RetrievalQuery(IDbConnection connectionToUse, IDbCommand commandToUse)
			:base(connectionToUse, commandToUse)
		{
		}


		/// <summary>
		/// Executes the query contained by the IQuery instance. The connection has to be opened before calling Execute().
		/// </summary>
		/// <param name="behavior">The behavior setting to pass to the ExecuteReader method.</param>
		/// <returns>An open, ready to use IDataReader instance</returns>
		/// <exception cref="System.InvalidOperationException">When there is no command object inside the query object, 
		/// or no connection object inside the query object or the connection is closed.</exception>
		public IDataReader Execute(CommandBehavior behavior)
		{
			if(base.Command==null)
			{
				throw new InvalidOperationException("No Command present. Nothing to execute.");
			}

			if(base.Connection==null)
			{
				throw new InvalidOperationException("No Connection present. Cannot execute command.");
			}

			if(base.Connection.State != ConnectionState.Open)
			{
				throw new InvalidOperationException("The Connection is not in the prefered condition 'Open'. Cannot execute command.");
			}

			// execute the query
			try
			{
				return base.Command.ExecuteReader(behavior);
			}
			catch(Exception ex)
			{
				// throw a catchable exception with detailed query information.
				throw new ORMQueryExecutionException(
					String.Format("An exception was caught during the execution of a retrieval query: {0}. Check InnerException, QueryExecuted and Parameters of this exception to examine the cause of this exception.", ex.Message), 
					base.ToString(), base.Parameters, ex);
			}
		}
	}
}