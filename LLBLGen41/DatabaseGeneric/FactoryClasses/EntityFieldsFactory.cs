﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.FactoryClasses
{
	/// <summary>Generates IEntityFields2 instances for different kind of Entities.</summary>
	public static partial class EntityFieldsFactory
	{
		private static readonly Dictionary<AdventureWorks.Dal.Adapter.v41.EntityType, string> _entityTypeNamesCache = new Dictionary<AdventureWorks.Dal.Adapter.v41.EntityType, string>();

		/// <summary>static ctor which initializes the static entity type cache.</summary>
		static EntityFieldsFactory()
		{
			foreach(AdventureWorks.Dal.Adapter.v41.EntityType value in Enum.GetValues(typeof(AdventureWorks.Dal.Adapter.v41.EntityType)))
			{
				_entityTypeNamesCache.Add(value, Enum.GetName(typeof(AdventureWorks.Dal.Adapter.v41.EntityType), value));
			}
		}	

		/// <summary>General factory entrance method which will return an EntityFields2 object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields2 CreateEntityFieldsObject(AdventureWorks.Dal.Adapter.v41.EntityType relatedEntityType)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFields(InheritanceInfoProviderSingleton.GetInstance(), _entityTypeNamesCache[relatedEntityType]);
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFieldsArray(entityName);
		}

		/// <summary>General factory entrance method which will return a TypedView EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedTypedViewType">The type of typed view the fields are for</param>
		/// <returns>The IEntityFields2 instance requested</returns>
		public static IEntityFields2 CreateTypedViewEntityFieldsObject(TypedViewType relatedTypedViewType)
		{
			IEntityFields2 fieldsToReturn=null;
			switch(relatedTypedViewType)
			{
				case TypedViewType.SohTypedView:
					fieldsToReturn = CreateSohTypedViewEntityFields();
					break;
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SohEntity.</summary>
		private static IEntityFields2 CreateSohTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)SohFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SohTypedView"));
			for(int i=0;i<(int)SohFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SohFieldIndex)i);
			}
			return fieldsToReturn;
		}

		#region Included Code

		#endregion
	}
}