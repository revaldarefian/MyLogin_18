﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyLogin_18
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyPractice")]
	public partial class LinkQ1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTB_M_PRODUCT(TB_M_PRODUCT instance);
    partial void UpdateTB_M_PRODUCT(TB_M_PRODUCT instance);
    partial void DeleteTB_M_PRODUCT(TB_M_PRODUCT instance);
    partial void InsertTB_M_USER(TB_M_USER instance);
    partial void UpdateTB_M_USER(TB_M_USER instance);
    partial void DeleteTB_M_USER(TB_M_USER instance);
    #endregion
		
		public LinkQ1DataContext() : 
				base(global::MyLogin_18.Properties.Settings.Default.MyPracticeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinkQ1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinkQ1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinkQ1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinkQ1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TB_M_PRODUCT> TB_M_PRODUCTs
		{
			get
			{
				return this.GetTable<TB_M_PRODUCT>();
			}
		}
		
		public System.Data.Linq.Table<TB_M_USER> TB_M_USERs
		{
			get
			{
				return this.GetTable<TB_M_USER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_M_PRODUCT")]
	public partial class TB_M_PRODUCT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _itemName;
		
		private string _deisgn;
		
		private string _color;
		
		private System.Nullable<System.DateTime> _expiredDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnitemNameChanging(string value);
    partial void OnitemNameChanged();
    partial void OndeisgnChanging(string value);
    partial void OndeisgnChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    partial void OnexpiredDateChanging(System.Nullable<System.DateTime> value);
    partial void OnexpiredDateChanged();
    #endregion
		
		public TB_M_PRODUCT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string itemName
		{
			get
			{
				return this._itemName;
			}
			set
			{
				if ((this._itemName != value))
				{
					this.OnitemNameChanging(value);
					this.SendPropertyChanging();
					this._itemName = value;
					this.SendPropertyChanged("itemName");
					this.OnitemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deisgn", DbType="NVarChar(20)")]
		public string deisgn
		{
			get
			{
				return this._deisgn;
			}
			set
			{
				if ((this._deisgn != value))
				{
					this.OndeisgnChanging(value);
					this.SendPropertyChanging();
					this._deisgn = value;
					this.SendPropertyChanged("deisgn");
					this.OndeisgnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NVarChar(20)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expiredDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> expiredDate
		{
			get
			{
				return this._expiredDate;
			}
			set
			{
				if ((this._expiredDate != value))
				{
					this.OnexpiredDateChanging(value);
					this.SendPropertyChanging();
					this._expiredDate = value;
					this.SendPropertyChanged("expiredDate");
					this.OnexpiredDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_M_USER")]
	public partial class TB_M_USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _username;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public TB_M_USER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
