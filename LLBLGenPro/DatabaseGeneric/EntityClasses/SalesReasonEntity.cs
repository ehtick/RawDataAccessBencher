﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SalesReason'.<br/><br/></summary>
	[Serializable]
	public partial class SalesReasonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<SalesOrderHeaderSalesReasonEntity> _salesOrderHeaderSalesReasons;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SalesReasonEntityStaticMetaData _staticMetaData = new SalesReasonEntityStaticMetaData();
		private static SalesReasonRelations _relationsFactory = new SalesReasonRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeaderSalesReasons</summary>
			public static readonly string SalesOrderHeaderSalesReasons = "SalesOrderHeaderSalesReasons";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SalesReasonEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SalesReasonEntityStaticMetaData()
			{
				SetEntityCoreInfo("SalesReasonEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.SalesReasonEntity, typeof(SalesReasonEntity), typeof(SalesReasonEntityFactory), false);
				AddNavigatorMetaData<SalesReasonEntity, EntityCollection<SalesOrderHeaderSalesReasonEntity>>("SalesOrderHeaderSalesReasons", a => a._salesOrderHeaderSalesReasons, (a, b) => a._salesOrderHeaderSalesReasons = b, a => a.SalesOrderHeaderSalesReasons, () => new SalesReasonRelations().SalesOrderHeaderSalesReasonEntityUsingSalesReasonId, typeof(SalesOrderHeaderSalesReasonEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderSalesReasonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SalesReasonEntity()
		{
		}

		/// <summary> CTor</summary>
		public SalesReasonEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesReasonEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesReasonEntity</param>
		public SalesReasonEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="salesReasonId">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		public SalesReasonEntity(System.Int32 salesReasonId) : this(salesReasonId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="salesReasonId">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesReasonEntity</param>
		public SalesReasonEntity(System.Int32 salesReasonId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.SalesReasonId = salesReasonId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesReasonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeaderSalesReason' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaderSalesReasons() { return CreateRelationInfoForNavigator("SalesOrderHeaderSalesReasons"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesReasonEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static SalesReasonRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeaderSalesReason' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaderSalesReasons { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaderSalesReasons", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderSalesReasonEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity SalesReason<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesReasonFieldIndex.ModifiedDate, true); }
			set { SetValue((int)SalesReasonFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity SalesReason<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesReasonFieldIndex.Name, true); }
			set { SetValue((int)SalesReasonFieldIndex.Name, value); }
		}

		/// <summary>The ReasonType property of the Entity SalesReason<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."ReasonType".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ReasonType
		{
			get { return (System.String)GetValue((int)SalesReasonFieldIndex.ReasonType, true); }
			set { SetValue((int)SalesReasonFieldIndex.ReasonType, value); }
		}

		/// <summary>The SalesReasonId property of the Entity SalesReason<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."SalesReasonID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesReasonId
		{
			get { return (System.Int32)GetValue((int)SalesReasonFieldIndex.SalesReasonId, true); }
			set { SetValue((int)SalesReasonFieldIndex.SalesReasonId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderSalesReasonEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderSalesReasonEntity))]
		public virtual EntityCollection<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReasons { get { return GetOrCreateEntityCollection<SalesOrderHeaderSalesReasonEntity, SalesOrderHeaderSalesReasonEntityFactory>("SalesReason", true, false, ref _salesOrderHeaderSalesReasons); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum SalesReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ReasonType. </summary>
		ReasonType,
		///<summary>SalesReasonId. </summary>
		SalesReasonId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesReason. </summary>
	public partial class SalesReasonRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SalesReasonEntity and SalesOrderHeaderSalesReasonEntity over the 1:n relation they have, using the relation between the fields: SalesReason.SalesReasonId - SalesOrderHeaderSalesReason.SalesReasonId</summary>
		public virtual IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesReasonId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaderSalesReasons", true, new[] { SalesReasonFields.SalesReasonId, SalesOrderHeaderSalesReasonFields.SalesReasonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesReasonRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesReasonIdStatic = new SalesReasonRelations().SalesOrderHeaderSalesReasonEntityUsingSalesReasonId;

		/// <summary>CTor</summary>
		static StaticSalesReasonRelations() { }
	}
}
