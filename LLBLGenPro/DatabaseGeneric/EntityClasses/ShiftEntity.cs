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
	/// <summary>Entity class which represents the entity 'Shift'.<br/><br/></summary>
	[Serializable]
	public partial class ShiftEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<EmployeeDepartmentHistoryEntity> _employeeDepartmentHistories;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ShiftEntityStaticMetaData _staticMetaData = new ShiftEntityStaticMetaData();
		private static ShiftRelations _relationsFactory = new ShiftRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name EmployeeDepartmentHistories</summary>
			public static readonly string EmployeeDepartmentHistories = "EmployeeDepartmentHistories";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ShiftEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ShiftEntityStaticMetaData()
			{
				SetEntityCoreInfo("ShiftEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ShiftEntity, typeof(ShiftEntity), typeof(ShiftEntityFactory), false);
				AddNavigatorMetaData<ShiftEntity, EntityCollection<EmployeeDepartmentHistoryEntity>>("EmployeeDepartmentHistories", a => a._employeeDepartmentHistories, (a, b) => a._employeeDepartmentHistories = b, a => a.EmployeeDepartmentHistories, () => new ShiftRelations().EmployeeDepartmentHistoryEntityUsingShiftId, typeof(EmployeeDepartmentHistoryEntity), (int)AdventureWorks.Dal.Adapter.EntityType.EmployeeDepartmentHistoryEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ShiftEntity()
		{
		}

		/// <summary> CTor</summary>
		public ShiftEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ShiftEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ShiftEntity</param>
		public ShiftEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="shiftId">PK value for Shift which data should be fetched into this Shift object</param>
		public ShiftEntity(System.Byte shiftId) : this(shiftId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="shiftId">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="validator">The custom validator object for this ShiftEntity</param>
		public ShiftEntity(System.Byte shiftId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ShiftId = shiftId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShiftEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeeDepartmentHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeDepartmentHistories() { return CreateRelationInfoForNavigator("EmployeeDepartmentHistories"); }
		
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
		/// <param name="validator">The validator object for this ShiftEntity</param>
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
		public static ShiftRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeDepartmentHistories { get { return _staticMetaData.GetPrefetchPathElement("EmployeeDepartmentHistories", CommonEntityBase.CreateEntityCollection<EmployeeDepartmentHistoryEntity>()); } }

		/// <summary>The EndTime property of the Entity Shift<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."EndTime".<br/>Table field type characteristics (type, precision, scale, length): Time, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.TimeSpan EndTime
		{
			get { return (System.TimeSpan)GetValue((int)ShiftFieldIndex.EndTime, true); }
			set { SetValue((int)ShiftFieldIndex.EndTime, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Shift<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ShiftFieldIndex.ModifiedDate, true); }
			set { SetValue((int)ShiftFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity Shift<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ShiftFieldIndex.Name, true); }
			set { SetValue((int)ShiftFieldIndex.Name, value); }
		}

		/// <summary>The ShiftId property of the Entity Shift<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."ShiftID".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Byte ShiftId
		{
			get { return (System.Byte)GetValue((int)ShiftFieldIndex.ShiftId, true); }
			set { SetValue((int)ShiftFieldIndex.ShiftId, value); }
		}

		/// <summary>The StartTime property of the Entity Shift<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."StartTime".<br/>Table field type characteristics (type, precision, scale, length): Time, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.TimeSpan StartTime
		{
			get { return (System.TimeSpan)GetValue((int)ShiftFieldIndex.StartTime, true); }
			set { SetValue((int)ShiftFieldIndex.StartTime, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'EmployeeDepartmentHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeDepartmentHistoryEntity))]
		public virtual EntityCollection<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistories { get { return GetOrCreateEntityCollection<EmployeeDepartmentHistoryEntity, EmployeeDepartmentHistoryEntityFactory>("Shift", true, false, ref _employeeDepartmentHistories); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ShiftFieldIndex
	{
		///<summary>EndTime. </summary>
		EndTime,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ShiftId. </summary>
		ShiftId,
		///<summary>StartTime. </summary>
		StartTime,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Shift. </summary>
	public partial class ShiftRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ShiftEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields: Shift.ShiftId - EmployeeDepartmentHistory.ShiftId</summary>
		public virtual IEntityRelation EmployeeDepartmentHistoryEntityUsingShiftId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "EmployeeDepartmentHistories", true, new[] { ShiftFields.ShiftId, EmployeeDepartmentHistoryFields.ShiftId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticShiftRelations
	{
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingShiftIdStatic = new ShiftRelations().EmployeeDepartmentHistoryEntityUsingShiftId;

		/// <summary>CTor</summary>
		static StaticShiftRelations() { }
	}
}
