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
	/// <summary>Entity class which represents the entity 'PhoneNumberType'.<br/><br/></summary>
	[Serializable]
	public partial class PhoneNumberTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<PersonPhoneEntity> _personPhones;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static PhoneNumberTypeEntityStaticMetaData _staticMetaData = new PhoneNumberTypeEntityStaticMetaData();
		private static PhoneNumberTypeRelations _relationsFactory = new PhoneNumberTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PersonPhones</summary>
			public static readonly string PersonPhones = "PersonPhones";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PhoneNumberTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PhoneNumberTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("PhoneNumberTypeEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.PhoneNumberTypeEntity, typeof(PhoneNumberTypeEntity), typeof(PhoneNumberTypeEntityFactory), false);
				AddNavigatorMetaData<PhoneNumberTypeEntity, EntityCollection<PersonPhoneEntity>>("PersonPhones", a => a._personPhones, (a, b) => a._personPhones = b, a => a.PersonPhones, () => new PhoneNumberTypeRelations().PersonPhoneEntityUsingPhoneNumberTypeId, typeof(PersonPhoneEntity), (int)AdventureWorks.Dal.Adapter.EntityType.PersonPhoneEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PhoneNumberTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public PhoneNumberTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PhoneNumberTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PhoneNumberTypeEntity</param>
		public PhoneNumberTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="phoneNumberTypeId">PK value for PhoneNumberType which data should be fetched into this PhoneNumberType object</param>
		public PhoneNumberTypeEntity(System.Int32 phoneNumberTypeId) : this(phoneNumberTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="phoneNumberTypeId">PK value for PhoneNumberType which data should be fetched into this PhoneNumberType object</param>
		/// <param name="validator">The custom validator object for this PhoneNumberTypeEntity</param>
		public PhoneNumberTypeEntity(System.Int32 phoneNumberTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.PhoneNumberTypeId = phoneNumberTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PhoneNumberTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PersonPhone' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPersonPhones() { return CreateRelationInfoForNavigator("PersonPhones"); }
		
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
		/// <param name="validator">The validator object for this PhoneNumberTypeEntity</param>
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
		public static PhoneNumberTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PersonPhone' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPersonPhones { get { return _staticMetaData.GetPrefetchPathElement("PersonPhones", CommonEntityBase.CreateEntityCollection<PersonPhoneEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PhoneNumberTypeFieldIndex.ModifiedDate, true); }
			set { SetValue((int)PhoneNumberTypeFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)PhoneNumberTypeFieldIndex.Name, true); }
			set { SetValue((int)PhoneNumberTypeFieldIndex.Name, value); }
		}

		/// <summary>The PhoneNumberTypeId property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."PhoneNumberTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PhoneNumberTypeId
		{
			get { return (System.Int32)GetValue((int)PhoneNumberTypeFieldIndex.PhoneNumberTypeId, true); }
			set { SetValue((int)PhoneNumberTypeFieldIndex.PhoneNumberTypeId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'PersonPhoneEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PersonPhoneEntity))]
		public virtual EntityCollection<PersonPhoneEntity> PersonPhones { get { return GetOrCreateEntityCollection<PersonPhoneEntity, PersonPhoneEntityFactory>("PhoneNumberType", true, false, ref _personPhones); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum PhoneNumberTypeFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>PhoneNumberTypeId. </summary>
		PhoneNumberTypeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PhoneNumberType. </summary>
	public partial class PhoneNumberTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between PhoneNumberTypeEntity and PersonPhoneEntity over the 1:n relation they have, using the relation between the fields: PhoneNumberType.PhoneNumberTypeId - PersonPhone.PhoneNumberTypeId</summary>
		public virtual IEntityRelation PersonPhoneEntityUsingPhoneNumberTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PersonPhones", true, new[] { PhoneNumberTypeFields.PhoneNumberTypeId, PersonPhoneFields.PhoneNumberTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPhoneNumberTypeRelations
	{
		internal static readonly IEntityRelation PersonPhoneEntityUsingPhoneNumberTypeIdStatic = new PhoneNumberTypeRelations().PersonPhoneEntityUsingPhoneNumberTypeId;

		/// <summary>CTor</summary>
		static StaticPhoneNumberTypeRelations() { }
	}
}
