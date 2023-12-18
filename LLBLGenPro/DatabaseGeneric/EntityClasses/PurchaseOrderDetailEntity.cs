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
	/// <summary>Entity class which represents the entity 'PurchaseOrderDetail'.<br/><br/></summary>
	[Serializable]
	public partial class PurchaseOrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private ProductEntity _product;
		private PurchaseOrderHeaderEntity _purchaseOrderHeader;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static PurchaseOrderDetailEntityStaticMetaData _staticMetaData = new PurchaseOrderDetailEntityStaticMetaData();
		private static PurchaseOrderDetailRelations _relationsFactory = new PurchaseOrderDetailRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name PurchaseOrderHeader</summary>
			public static readonly string PurchaseOrderHeader = "PurchaseOrderHeader";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PurchaseOrderDetailEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PurchaseOrderDetailEntityStaticMetaData()
			{
				SetEntityCoreInfo("PurchaseOrderDetailEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderDetailEntity, typeof(PurchaseOrderDetailEntity), typeof(PurchaseOrderDetailEntityFactory), false);
				AddNavigatorMetaData<PurchaseOrderDetailEntity, ProductEntity>("Product", "PurchaseOrderDetails", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticPurchaseOrderDetailRelations.ProductEntityUsingProductIdStatic, ()=>new PurchaseOrderDetailRelations().ProductEntityUsingProductId, null, new int[] { (int)PurchaseOrderDetailFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ProductEntity);
				AddNavigatorMetaData<PurchaseOrderDetailEntity, PurchaseOrderHeaderEntity>("PurchaseOrderHeader", "PurchaseOrderDetails", (a, b) => a._purchaseOrderHeader = b, a => a._purchaseOrderHeader, (a, b) => a.PurchaseOrderHeader = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticPurchaseOrderDetailRelations.PurchaseOrderHeaderEntityUsingPurchaseOrderIdStatic, ()=>new PurchaseOrderDetailRelations().PurchaseOrderHeaderEntityUsingPurchaseOrderId, null, new int[] { (int)PurchaseOrderDetailFieldIndex.PurchaseOrderId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderHeaderEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PurchaseOrderDetailEntity()
		{
		}

		/// <summary> CTor</summary>
		public PurchaseOrderDetailEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PurchaseOrderDetailEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		public PurchaseOrderDetailEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="purchaseOrderDetailId">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderId">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderDetailId, System.Int32 purchaseOrderId) : this(purchaseOrderDetailId, purchaseOrderId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="purchaseOrderDetailId">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderId">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderDetailId, System.Int32 purchaseOrderId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.PurchaseOrderDetailId = purchaseOrderDetailId;
			this.PurchaseOrderId = purchaseOrderId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeader() { return CreateRelationInfoForNavigator("PurchaseOrderHeader"); }
		
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
		/// <param name="validator">The validator object for this PurchaseOrderDetailEntity</param>
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
		public static PurchaseOrderDetailRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeader { get { return _staticMetaData.GetPrefetchPathElement("PurchaseOrderHeader", CommonEntityBase.CreateEntityCollection<PurchaseOrderHeaderEntity>()); } }

		/// <summary>The DueDate property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."DueDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.DueDate, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.DueDate, value); }
		}

		/// <summary>The LineTotal property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."LineTotal".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.LineTotal, true); }

		}

		/// <summary>The ModifiedDate property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The OrderQty property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."OrderQty".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQty
		{
			get { return (System.Int16)GetValue((int)PurchaseOrderDetailFieldIndex.OrderQty, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.OrderQty, value); }
		}

		/// <summary>The ProductId property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.ProductId, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.ProductId, value); }
		}

		/// <summary>The PurchaseOrderDetailId property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderDetailID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderDetailId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailId, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailId, value); }
		}

		/// <summary>The PurchaseOrderId property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PurchaseOrderId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderId, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderId, value); }
		}

		/// <summary>The ReceivedQty property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ReceivedQty".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ReceivedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty, value); }
		}

		/// <summary>The RejectedQty property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."RejectedQty".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal RejectedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.RejectedQty, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.RejectedQty, value); }
		}

		/// <summary>The StockedQty property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."StockedQty".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StockedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.StockedQty, true); }

		}

		/// <summary>The UnitPrice property of the Entity PurchaseOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."UnitPrice".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, true); }
			set { SetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, value); }
		}

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		/// <summary>Gets / sets related entity of type 'PurchaseOrderHeaderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PurchaseOrderHeaderEntity PurchaseOrderHeader
		{
			get { return _purchaseOrderHeader; }
			set { SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeader"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum PurchaseOrderDetailFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>PurchaseOrderDetailId. </summary>
		PurchaseOrderDetailId,
		///<summary>PurchaseOrderId. </summary>
		PurchaseOrderId,
		///<summary>ReceivedQty. </summary>
		ReceivedQty,
		///<summary>RejectedQty. </summary>
		RejectedQty,
		///<summary>StockedQty. </summary>
		StockedQty,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PurchaseOrderDetail. </summary>
	public partial class PurchaseOrderDetailRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: PurchaseOrderDetail.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, PurchaseOrderDetailFields.ProductId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and PurchaseOrderHeaderEntity over the m:1 relation they have, using the relation between the fields: PurchaseOrderDetail.PurchaseOrderId - PurchaseOrderHeader.PurchaseOrderId</summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "PurchaseOrderHeader", false, new[] { PurchaseOrderHeaderFields.PurchaseOrderId, PurchaseOrderDetailFields.PurchaseOrderId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPurchaseOrderDetailRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new PurchaseOrderDetailRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderIdStatic = new PurchaseOrderDetailRelations().PurchaseOrderHeaderEntityUsingPurchaseOrderId;

		/// <summary>CTor</summary>
		static StaticPurchaseOrderDetailRelations() { }
	}
}
