﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'EmployeeDepartmentHistory', mapped on table 'AdventureWorks.HumanResources.EmployeeDepartmentHistory'.</summary>
	[Table(Name="[HumanResources].[EmployeeDepartmentHistory]")]
	public partial class EmployeeDepartmentHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_businessEntityId;
		private System.Int16	_departmentId;
		private Nullable<System.DateTime>	_endDate;
		private System.DateTime	_modifiedDate;
		private System.Byte	_shiftId;
		private System.DateTime	_startDate;
		private EntityRef <Department> _department;
		private EntityRef <Employee> _employee;
		private EntityRef <Shift> _shift;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnBusinessEntityIdChanging(System.Int32 value);
		partial void OnBusinessEntityIdChanged();
		partial void OnDepartmentIdChanging(System.Int16 value);
		partial void OnDepartmentIdChanged();
		partial void OnEndDateChanging(Nullable<System.DateTime> value);
		partial void OnEndDateChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnShiftIdChanging(System.Byte value);
		partial void OnShiftIdChanged();
		partial void OnStartDateChanging(System.DateTime value);
		partial void OnStartDateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="EmployeeDepartmentHistory"/> class.</summary>
		public EmployeeDepartmentHistory()
		{
			_department = default(EntityRef<Department>);
			_employee = default(EntityRef<Employee>);
			_shift = default(EntityRef<Shift>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the BusinessEntityId field. Mapped on target field 'BusinessEntityID'. </summary>
		[Column(Name="BusinessEntityID", Storage="_businessEntityId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 BusinessEntityId
		{
			get	{ return _businessEntityId; }
			set
			{
				if((_businessEntityId != value))
				{
					if(_employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnBusinessEntityIdChanging(value);
					SendPropertyChanging("BusinessEntityId");
					_businessEntityId = value;
					SendPropertyChanged("BusinessEntityId");
					OnBusinessEntityIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the DepartmentId field. Mapped on target field 'DepartmentID'. </summary>
		[Column(Name="DepartmentID", Storage="_departmentId", CanBeNull=false, DbType="smallint NOT NULL", IsPrimaryKey=true)]
		public System.Int16 DepartmentId
		{
			get	{ return _departmentId; }
			set
			{
				if((_departmentId != value))
				{
					if(_department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnDepartmentIdChanging(value);
					SendPropertyChanging("DepartmentId");
					_departmentId = value;
					SendPropertyChanged("DepartmentId");
					OnDepartmentIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the EndDate field. Mapped on target field 'EndDate'. </summary>
		[Column(Name="EndDate", Storage="_endDate", DbType="date NULL")]
		public Nullable<System.DateTime> EndDate
		{
			get	{ return _endDate; }
			set
			{
				if((_endDate != value))
				{
					OnEndDateChanging(value);
					SendPropertyChanging("EndDate");
					_endDate = value;
					SendPropertyChanged("EndDate");
					OnEndDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShiftId field. Mapped on target field 'ShiftID'. </summary>
		[Column(Name="ShiftID", Storage="_shiftId", CanBeNull=false, DbType="tinyint NOT NULL", IsPrimaryKey=true)]
		public System.Byte ShiftId
		{
			get	{ return _shiftId; }
			set
			{
				if((_shiftId != value))
				{
					if(_shift.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnShiftIdChanging(value);
					SendPropertyChanging("ShiftId");
					_shiftId = value;
					SendPropertyChanged("ShiftId");
					OnShiftIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the StartDate field. Mapped on target field 'StartDate'. </summary>
		[Column(Name="StartDate", Storage="_startDate", CanBeNull=false, DbType="date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime StartDate
		{
			get	{ return _startDate; }
			set
			{
				if((_startDate != value))
				{
					OnStartDateChanging(value);
					SendPropertyChanging("StartDate");
					_startDate = value;
					SendPropertyChanged("StartDate");
					OnStartDateChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Department - Department.EmployeeDepartmentHistories (m:1)'</summary>
		[Association(Name="EmployeeDepartmentHistory_Department80b9743b51654c6b973acf049e8d5735", Storage="_department", ThisKey="DepartmentId", IsForeignKey=true)] 
		public Department Department
		{
			get { return _department.Entity; }
			set
			{
				Department previousValue = _department.Entity;
				if((previousValue != value) || (_department.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Department");
					if(previousValue != null)
					{
						_department.Entity = null;
						previousValue.EmployeeDepartmentHistories.Remove(this);
					}
					_department.Entity = value;
					if(value == null)
					{
						_departmentId = default(System.Int16);
					}
					else
					{
						value.EmployeeDepartmentHistories.Add(this);
						_departmentId = value.DepartmentId;
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Employee - Employee.EmployeeDepartmentHistories (m:1)'</summary>
		[Association(Name="EmployeeDepartmentHistory_Employeedc3758d181924a4aa72e67f8f5994ab8", Storage="_employee", ThisKey="BusinessEntityId", IsForeignKey=true)] 
		public Employee Employee
		{
			get { return _employee.Entity; }
			set
			{
				Employee previousValue = _employee.Entity;
				if((previousValue != value) || (_employee.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Employee");
					if(previousValue != null)
					{
						_employee.Entity = null;
						previousValue.EmployeeDepartmentHistories.Remove(this);
					}
					_employee.Entity = value;
					if(value == null)
					{
						_businessEntityId = default(System.Int32);
					}
					else
					{
						value.EmployeeDepartmentHistories.Add(this);
						_businessEntityId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Shift - Shift.EmployeeDepartmentHistories (m:1)'</summary>
		[Association(Name="EmployeeDepartmentHistory_Shift69689a92082d4e5fa4ee9c25fbffa5af", Storage="_shift", ThisKey="ShiftId", IsForeignKey=true)] 
		public Shift Shift
		{
			get { return _shift.Entity; }
			set
			{
				Shift previousValue = _shift.Entity;
				if((previousValue != value) || (_shift.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Shift");
					if(previousValue != null)
					{
						_shift.Entity = null;
						previousValue.EmployeeDepartmentHistories.Remove(this);
					}
					_shift.Entity = value;
					if(value == null)
					{
						_shiftId = default(System.Byte);
					}
					else
					{
						value.EmployeeDepartmentHistories.Add(this);
						_shiftId = value.ShiftId;
					}
					this.SendPropertyChanged("Shift");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649