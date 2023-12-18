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
	/// <summary>Entity class which represents the entity 'SpecialOffer'.<br/><br/></summary>
	[Serializable]
	public partial class SpecialOfferEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<SpecialOfferProductEntity> _specialOfferProducts;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SpecialOfferEntityStaticMetaData _staticMetaData = new SpecialOfferEntityStaticMetaData();
		private static SpecialOfferRelations _relationsFactory = new SpecialOfferRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SpecialOfferEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SpecialOfferEntityStaticMetaData()
			{
				SetEntityCoreInfo("SpecialOfferEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.SpecialOfferEntity, typeof(SpecialOfferEntity), typeof(SpecialOfferEntityFactory), false);
				AddNavigatorMetaData<SpecialOfferEntity, EntityCollection<SpecialOfferProductEntity>>("SpecialOfferProducts", a => a._specialOfferProducts, (a, b) => a._specialOfferProducts = b, a => a.SpecialOfferProducts, () => new SpecialOfferRelations().SpecialOfferProductEntityUsingSpecialOfferId, typeof(SpecialOfferProductEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SpecialOfferProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SpecialOfferEntity()
		{
		}

		/// <summary> CTor</summary>
		public SpecialOfferEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SpecialOfferEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SpecialOfferEntity</param>
		public SpecialOfferEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		public SpecialOfferEntity(System.Int32 specialOfferId) : this(specialOfferId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferEntity</param>
		public SpecialOfferEntity(System.Int32 specialOfferId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.SpecialOfferId = specialOfferId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SpecialOfferEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SpecialOfferProduct' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferProducts() { return CreateRelationInfoForNavigator("SpecialOfferProducts"); }
		
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
		/// <param name="validator">The validator object for this SpecialOfferEntity</param>
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
		public static SpecialOfferRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferProducts { get { return _staticMetaData.GetPrefetchPathElement("SpecialOfferProducts", CommonEntityBase.CreateEntityCollection<SpecialOfferProductEntity>()); } }

		/// <summary>The Category property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Category".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Category
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Category, true); }
			set { SetValue((int)SpecialOfferFieldIndex.Category, value); }
		}

		/// <summary>The Description property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Description".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Description, true); }
			set { SetValue((int)SpecialOfferFieldIndex.Description, value); }
		}

		/// <summary>The DiscountPct property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."DiscountPct".<br/>Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal DiscountPct
		{
			get { return (System.Decimal)GetValue((int)SpecialOfferFieldIndex.DiscountPct, true); }
			set { SetValue((int)SpecialOfferFieldIndex.DiscountPct, value); }
		}

		/// <summary>The EndDate property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."EndDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.EndDate, true); }
			set { SetValue((int)SpecialOfferFieldIndex.EndDate, value); }
		}

		/// <summary>The MaxQty property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."MaxQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MaxQty
		{
			get { return (Nullable<System.Int32>)GetValue((int)SpecialOfferFieldIndex.MaxQty, false); }
			set { SetValue((int)SpecialOfferFieldIndex.MaxQty, value); }
		}

		/// <summary>The MinQty property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."MinQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MinQty
		{
			get { return (System.Int32)GetValue((int)SpecialOfferFieldIndex.MinQty, true); }
			set { SetValue((int)SpecialOfferFieldIndex.MinQty, value); }
		}

		/// <summary>The ModifiedDate property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.ModifiedDate, true); }
			set { SetValue((int)SpecialOfferFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Rowguid property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SpecialOfferFieldIndex.Rowguid, true); }
			set { SetValue((int)SpecialOfferFieldIndex.Rowguid, value); }
		}

		/// <summary>The SpecialOfferId property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."SpecialOfferID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferFieldIndex.SpecialOfferId, true); }
			set { SetValue((int)SpecialOfferFieldIndex.SpecialOfferId, value); }
		}

		/// <summary>The StartDate property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."StartDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.StartDate, true); }
			set { SetValue((int)SpecialOfferFieldIndex.StartDate, value); }
		}

		/// <summary>The Type property of the Entity SpecialOffer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Type".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Type
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Type, true); }
			set { SetValue((int)SpecialOfferFieldIndex.Type, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'SpecialOfferProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SpecialOfferProductEntity))]
		public virtual EntityCollection<SpecialOfferProductEntity> SpecialOfferProducts { get { return GetOrCreateEntityCollection<SpecialOfferProductEntity, SpecialOfferProductEntityFactory>("SpecialOffer", true, false, ref _specialOfferProducts); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum SpecialOfferFieldIndex
	{
		///<summary>Category. </summary>
		Category,
		///<summary>Description. </summary>
		Description,
		///<summary>DiscountPct. </summary>
		DiscountPct,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>MaxQty. </summary>
		MaxQty,
		///<summary>MinQty. </summary>
		MinQty,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SpecialOffer. </summary>
	public partial class SpecialOfferRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SpecialOfferEntity and SpecialOfferProductEntity over the 1:n relation they have, using the relation between the fields: SpecialOffer.SpecialOfferId - SpecialOfferProduct.SpecialOfferId</summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingSpecialOfferId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SpecialOfferProducts", true, new[] { SpecialOfferFields.SpecialOfferId, SpecialOfferProductFields.SpecialOfferId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSpecialOfferRelations
	{
		internal static readonly IEntityRelation SpecialOfferProductEntityUsingSpecialOfferIdStatic = new SpecialOfferRelations().SpecialOfferProductEntityUsingSpecialOfferId;

		/// <summary>CTor</summary>
		static StaticSpecialOfferRelations() { }
	}
}
