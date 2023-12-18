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
	/// <summary>Entity class which represents the entity 'Address'.<br/><br/></summary>
	[Serializable]
	public partial class AddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<BusinessEntityAddressEntity> _businessEntityAddresses;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders_;
		private StateProvinceEntity _stateProvince;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AddressEntityStaticMetaData _staticMetaData = new AddressEntityStaticMetaData();
		private static AddressRelations _relationsFactory = new AddressRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
			/// <summary>Member name BusinessEntityAddresses</summary>
			public static readonly string BusinessEntityAddresses = "BusinessEntityAddresses";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesOrderHeaders_</summary>
			public static readonly string SalesOrderHeaders_ = "SalesOrderHeaders_";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AddressEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AddressEntityStaticMetaData()
			{
				SetEntityCoreInfo("AddressEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.AddressEntity, typeof(AddressEntity), typeof(AddressEntityFactory), false);
				AddNavigatorMetaData<AddressEntity, EntityCollection<BusinessEntityAddressEntity>>("BusinessEntityAddresses", a => a._businessEntityAddresses, (a, b) => a._businessEntityAddresses = b, a => a.BusinessEntityAddresses, () => new AddressRelations().BusinessEntityAddressEntityUsingAddressId, typeof(BusinessEntityAddressEntity), (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityAddressEntity);
				AddNavigatorMetaData<AddressEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders", a => a._salesOrderHeaders, (a, b) => a._salesOrderHeaders = b, a => a.SalesOrderHeaders, () => new AddressRelations().SalesOrderHeaderEntityUsingBillToAddressId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<AddressEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders_", a => a._salesOrderHeaders_, (a, b) => a._salesOrderHeaders_ = b, a => a.SalesOrderHeaders_, () => new AddressRelations().SalesOrderHeaderEntityUsingShipToAddressId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<AddressEntity, StateProvinceEntity>("StateProvince", "Addresses", (a, b) => a._stateProvince = b, a => a._stateProvince, (a, b) => a.StateProvince = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIdStatic, ()=>new AddressRelations().StateProvinceEntityUsingStateProvinceId, null, new int[] { (int)AddressFieldIndex.StateProvinceId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.StateProvinceEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static AddressEntity()
		{
		}

		/// <summary> CTor</summary>
		public AddressEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AddressEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntity(System.Int32 addressId) : this(addressId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(System.Int32 addressId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.AddressId = addressId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityAddresses() { return CreateRelationInfoForNavigator("BusinessEntityAddresses"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders() { return CreateRelationInfoForNavigator("SalesOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders_() { return CreateRelationInfoForNavigator("SalesOrderHeaders_"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvince() { return CreateRelationInfoForNavigator("StateProvince"); }
		
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
		/// <param name="validator">The validator object for this AddressEntity</param>
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
		public static AddressRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityAddresses { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntityAddresses", CommonEntityBase.CreateEntityCollection<BusinessEntityAddressEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders_ { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders_", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvince { get { return _staticMetaData.GetPrefetchPathElement("StateProvince", CommonEntityBase.CreateEntityCollection<StateProvinceEntity>()); } }

		/// <summary>The AddressId property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.AddressId, true); }
			set { SetValue((int)AddressFieldIndex.AddressId, value); }
		}

		/// <summary>The AddressLine1 property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine1".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine1, true); }
			set { SetValue((int)AddressFieldIndex.AddressLine1, value); }
		}

		/// <summary>The AddressLine2 property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine2".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine2, true); }
			set { SetValue((int)AddressFieldIndex.AddressLine2, value); }
		}

		/// <summary>The City property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."City".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set { SetValue((int)AddressFieldIndex.City, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressFieldIndex.ModifiedDate, true); }
			set { SetValue((int)AddressFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The PostalCode property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."PostalCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.PostalCode, true); }
			set { SetValue((int)AddressFieldIndex.PostalCode, value); }
		}

		/// <summary>The Rowguid property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressFieldIndex.Rowguid, true); }
			set { SetValue((int)AddressFieldIndex.Rowguid, value); }
		}

		/// <summary>The StateProvinceId property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."StateProvinceID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.StateProvinceId, true); }
			set { SetValue((int)AddressFieldIndex.StateProvinceId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'BusinessEntityAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityAddressEntity))]
		public virtual EntityCollection<BusinessEntityAddressEntity> BusinessEntityAddresses { get { return GetOrCreateEntityCollection<BusinessEntityAddressEntity, BusinessEntityAddressEntityFactory>("Address", true, false, ref _businessEntityAddresses); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("Address", true, false, ref _salesOrderHeaders); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders_ { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("Address_", true, false, ref _salesOrderHeaders_); } }

		/// <summary>Gets / sets related entity of type 'StateProvinceEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StateProvinceEntity StateProvince
		{
			get { return _stateProvince; }
			set { SetSingleRelatedEntityNavigator(value, "StateProvince"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum AddressFieldIndex
	{
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Address. </summary>
	public partial class AddressRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between AddressEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields: Address.AddressId - BusinessEntityAddress.AddressId</summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingAddressId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BusinessEntityAddresses", true, new[] { AddressFields.AddressId, BusinessEntityAddressFields.AddressId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: Address.AddressId - SalesOrderHeader.BillToAddressId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingBillToAddressId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders", true, new[] { AddressFields.AddressId, SalesOrderHeaderFields.BillToAddressId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: Address.AddressId - SalesOrderHeader.ShipToAddressId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipToAddressId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders_", true, new[] { AddressFields.AddressId, SalesOrderHeaderFields.ShipToAddressId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields: Address.StateProvinceId - StateProvince.StateProvinceId</summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "StateProvince", false, new[] { StateProvinceFields.StateProvinceId, AddressFields.StateProvinceId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAddressRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingAddressIdStatic = new AddressRelations().BusinessEntityAddressEntityUsingAddressId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingBillToAddressIdStatic = new AddressRelations().SalesOrderHeaderEntityUsingBillToAddressId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingShipToAddressIdStatic = new AddressRelations().SalesOrderHeaderEntityUsingShipToAddressId;
		internal static readonly IEntityRelation StateProvinceEntityUsingStateProvinceIdStatic = new AddressRelations().StateProvinceEntityUsingStateProvinceId;

		/// <summary>CTor</summary>
		static StaticAddressRelations() { }
	}
}
