﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace taskMVC
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="taskDB")]
	public partial class taskdbmlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttaskTbl(taskTbl instance);
    partial void UpdatetaskTbl(taskTbl instance);
    partial void DeletetaskTbl(taskTbl instance);
    #endregion
		
		public taskdbmlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["taskDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public taskdbmlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public taskdbmlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public taskdbmlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public taskdbmlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<taskTbl> taskTbls
		{
			get
			{
				return this.GetTable<taskTbl>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.taskTbl")]
	public partial class taskTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _title;
		
		private string _dscrption;
		
		private string _dueDate;
		
		private System.Nullable<long> _requiredHours;
		
		private string _prority;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndscrptionChanging(string value);
    partial void OndscrptionChanged();
    partial void OndueDateChanging(string value);
    partial void OndueDateChanged();
    partial void OnrequiredHoursChanging(System.Nullable<long> value);
    partial void OnrequiredHoursChanged();
    partial void OnprorityChanging(string value);
    partial void OnprorityChanged();
    #endregion
		
		public taskTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(40)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dscrption", DbType="VarChar(250)")]
		public string dscrption
		{
			get
			{
				return this._dscrption;
			}
			set
			{
				if ((this._dscrption != value))
				{
					this.OndscrptionChanging(value);
					this.SendPropertyChanging();
					this._dscrption = value;
					this.SendPropertyChanged("dscrption");
					this.OndscrptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dueDate", DbType="VarChar(40)")]
		public string dueDate
		{
			get
			{
				return this._dueDate;
			}
			set
			{
				if ((this._dueDate != value))
				{
					this.OndueDateChanging(value);
					this.SendPropertyChanging();
					this._dueDate = value;
					this.SendPropertyChanged("dueDate");
					this.OndueDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_requiredHours", DbType="BigInt")]
		public System.Nullable<long> requiredHours
		{
			get
			{
				return this._requiredHours;
			}
			set
			{
				if ((this._requiredHours != value))
				{
					this.OnrequiredHoursChanging(value);
					this.SendPropertyChanging();
					this._requiredHours = value;
					this.SendPropertyChanged("requiredHours");
					this.OnrequiredHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prority", DbType="VarChar(20)")]
		public string prority
		{
			get
			{
				return this._prority;
			}
			set
			{
				if ((this._prority != value))
				{
					this.OnprorityChanging(value);
					this.SendPropertyChanging();
					this._prority = value;
					this.SendPropertyChanged("prority");
					this.OnprorityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
