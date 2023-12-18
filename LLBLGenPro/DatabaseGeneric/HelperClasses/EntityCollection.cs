﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.HelperClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>EntityCollection implementation which is used for backwards compatibility and for design time databinding.</summary>
	[Serializable]
	public partial class EntityCollection : EntityCollectionNonGeneric
	{
		/// <summary>CTor</summary>
		public EntityCollection() : base() { }

		/// <summary>CTor</summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.</param>
		public EntityCollection(IEntityFactory2 entityFactoryToUse) : base(entityFactoryToUse) { }

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityCollection(SerializationInfo info, StreamingContext context) : base(info, context) { }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}

	/// <summary>Generic entity collection class which replaces the original generated, non strongly typed EntityCollection variant.</summary>
	[Serializable]
	public partial class EntityCollection<TEntity> : EntityCollectionBase2<TEntity>
		where TEntity : EntityBase2, IEntity2
	{
		/// <summary>CTor which determines the factory to use from the generic type argument, unless TEntity is an abstract entity.</summary>
		public EntityCollection() : base((IEntityFactory2)null)	{ }

		/// <summary>CTor</summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.</param>
		public EntityCollection(IEntityFactory2 entityFactoryToUse) : base(entityFactoryToUse) { }

		/// <summary>CTor</summary>
		/// <param name="initialContents">initial contents for this collection</param>
		public EntityCollection(IEnumerable<TEntity> initialContents ) : base(initialContents) { }

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityCollection(SerializationInfo info, StreamingContext context) : base(info, context)	{ }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCodeGeneric
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}
