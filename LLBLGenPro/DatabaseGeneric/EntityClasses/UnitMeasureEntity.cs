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
	/// <summary>Entity class which represents the entity 'UnitMeasure'.<br/><br/></summary>
	[Serializable]
	public partial class UnitMeasureEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials;
		private EntityCollection<ProductEntity> _products;
		private EntityCollection<ProductEntity> _products_;
		private EntityCollection<ProductVendorEntity> _productVendors;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static UnitMeasureEntityStaticMetaData _staticMetaData = new UnitMeasureEntityStaticMetaData();
		private static UnitMeasureRelations _relationsFactory = new UnitMeasureRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name Products_</summary>
			public static readonly string Products_ = "Products_";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UnitMeasureEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UnitMeasureEntityStaticMetaData()
			{
				SetEntityCoreInfo("UnitMeasureEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.UnitMeasureEntity, typeof(UnitMeasureEntity), typeof(UnitMeasureEntityFactory), false);
				AddNavigatorMetaData<UnitMeasureEntity, EntityCollection<BillOfMaterialEntity>>("BillOfMaterials", a => a._billOfMaterials, (a, b) => a._billOfMaterials = b, a => a.BillOfMaterials, () => new UnitMeasureRelations().BillOfMaterialEntityUsingUnitMeasureCode, typeof(BillOfMaterialEntity), (int)AdventureWorks.Dal.Adapter.EntityType.BillOfMaterialEntity);
				AddNavigatorMetaData<UnitMeasureEntity, EntityCollection<ProductEntity>>("Products", a => a._products, (a, b) => a._products = b, a => a.Products, () => new UnitMeasureRelations().ProductEntityUsingSizeUnitMeasureCode, typeof(ProductEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductEntity);
				AddNavigatorMetaData<UnitMeasureEntity, EntityCollection<ProductEntity>>("Products_", a => a._products_, (a, b) => a._products_ = b, a => a.Products_, () => new UnitMeasureRelations().ProductEntityUsingWeightUnitMeasureCode, typeof(ProductEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductEntity);
				AddNavigatorMetaData<UnitMeasureEntity, EntityCollection<ProductVendorEntity>>("ProductVendors", a => a._productVendors, (a, b) => a._productVendors = b, a => a.ProductVendors, () => new UnitMeasureRelations().ProductVendorEntityUsingUnitMeasureCode, typeof(ProductVendorEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductVendorEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static UnitMeasureEntity()
		{
		}

		/// <summary> CTor</summary>
		public UnitMeasureEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UnitMeasureEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		public UnitMeasureEntity(System.String unitMeasureCode) : this(unitMeasureCode, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntity(System.String unitMeasureCode, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.UnitMeasureCode = unitMeasureCode;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UnitMeasureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials() { return CreateRelationInfoForNavigator("BillOfMaterials"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts() { return CreateRelationInfoForNavigator("Products"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts_() { return CreateRelationInfoForNavigator("Products_"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors() { return CreateRelationInfoForNavigator("ProductVendors"); }
		
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
		/// <param name="validator">The validator object for this UnitMeasureEntity</param>
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
		public static UnitMeasureRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillOfMaterials { get { return _staticMetaData.GetPrefetchPathElement("BillOfMaterials", CommonEntityBase.CreateEntityCollection<BillOfMaterialEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts { get { return _staticMetaData.GetPrefetchPathElement("Products", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts_ { get { return _staticMetaData.GetPrefetchPathElement("Products_", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors { get { return _staticMetaData.GetPrefetchPathElement("ProductVendors", CommonEntityBase.CreateEntityCollection<ProductVendorEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)UnitMeasureFieldIndex.ModifiedDate, true); }
			set { SetValue((int)UnitMeasureFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.Name, true); }
			set { SetValue((int)UnitMeasureFieldIndex.Name, value); }
		}

		/// <summary>The UnitMeasureCode property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."UnitMeasureCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, true); }
			set { SetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials { get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("UnitMeasure", true, false, ref _billOfMaterials); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products { get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasure", true, false, ref _products); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products_ { get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasure_", true, false, ref _products_); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors { get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("UnitMeasure", true, false, ref _productVendors); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum UnitMeasureFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: UnitMeasure. </summary>
	public partial class UnitMeasureRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields: UnitMeasure.UnitMeasureCode - BillOfMaterial.UnitMeasureCode</summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingUnitMeasureCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BillOfMaterials", true, new[] { UnitMeasureFields.UnitMeasureCode, BillOfMaterialFields.UnitMeasureCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields: UnitMeasure.UnitMeasureCode - Product.SizeUnitMeasureCode</summary>
		public virtual IEntityRelation ProductEntityUsingSizeUnitMeasureCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Products", true, new[] { UnitMeasureFields.UnitMeasureCode, ProductFields.SizeUnitMeasureCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields: UnitMeasure.UnitMeasureCode - Product.WeightUnitMeasureCode</summary>
		public virtual IEntityRelation ProductEntityUsingWeightUnitMeasureCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Products_", true, new[] { UnitMeasureFields.UnitMeasureCode, ProductFields.WeightUnitMeasureCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields: UnitMeasure.UnitMeasureCode - ProductVendor.UnitMeasureCode</summary>
		public virtual IEntityRelation ProductVendorEntityUsingUnitMeasureCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductVendors", true, new[] { UnitMeasureFields.UnitMeasureCode, ProductVendorFields.UnitMeasureCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUnitMeasureRelations
	{
		internal static readonly IEntityRelation BillOfMaterialEntityUsingUnitMeasureCodeStatic = new UnitMeasureRelations().BillOfMaterialEntityUsingUnitMeasureCode;
		internal static readonly IEntityRelation ProductEntityUsingSizeUnitMeasureCodeStatic = new UnitMeasureRelations().ProductEntityUsingSizeUnitMeasureCode;
		internal static readonly IEntityRelation ProductEntityUsingWeightUnitMeasureCodeStatic = new UnitMeasureRelations().ProductEntityUsingWeightUnitMeasureCode;
		internal static readonly IEntityRelation ProductVendorEntityUsingUnitMeasureCodeStatic = new UnitMeasureRelations().ProductVendorEntityUsingUnitMeasureCode;

		/// <summary>CTor</summary>
		static StaticUnitMeasureRelations() { }
	}
}
