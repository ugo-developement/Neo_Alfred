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

namespace Neo_Alfred.DataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="benDover")]
	public partial class Data_AllTablesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InserttheORDER(theORDER instance);
    partial void UpdatetheORDER(theORDER instance);
    partial void DeletetheORDER(theORDER instance);
    #endregion
		
		public Data_AllTablesDataContext() : 
				base(global::Neo_Alfred.Properties.Settings.Default.benDoverConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Data_AllTablesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_AllTablesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_AllTablesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_AllTablesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<theORDER> theORDERs
		{
			get
			{
				return this.GetTable<theORDER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CustID;
		
		private string _CustName;
		
		private string _CustStatus;
		
		private System.Nullable<System.DateTime> _JoinDate;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private EntitySet<theORDER> _theORDERs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustIDChanging(string value);
    partial void OnCustIDChanged();
    partial void OnCustNameChanging(string value);
    partial void OnCustNameChanged();
    partial void OnCustStatusChanging(string value);
    partial void OnCustStatusChanged();
    partial void OnJoinDateChanging(System.Nullable<System.DateTime> value);
    partial void OnJoinDateChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    #endregion
		
		public Customer()
		{
			this._theORDERs = new EntitySet<theORDER>(new Action<theORDER>(this.attach_theORDERs), new Action<theORDER>(this.detach_theORDERs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustName", DbType="VarChar(40)")]
		public string CustName
		{
			get
			{
				return this._CustName;
			}
			set
			{
				if ((this._CustName != value))
				{
					this.OnCustNameChanging(value);
					this.SendPropertyChanging();
					this._CustName = value;
					this.SendPropertyChanged("CustName");
					this.OnCustNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustStatus", DbType="VarChar(12)")]
		public string CustStatus
		{
			get
			{
				return this._CustStatus;
			}
			set
			{
				if ((this._CustStatus != value))
				{
					this.OnCustStatusChanging(value);
					this.SendPropertyChanging();
					this._CustStatus = value;
					this.SendPropertyChanged("CustStatus");
					this.OnCustStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JoinDate", DbType="Date")]
		public System.Nullable<System.DateTime> JoinDate
		{
			get
			{
				return this._JoinDate;
			}
			set
			{
				if ((this._JoinDate != value))
				{
					this.OnJoinDateChanging(value);
					this.SendPropertyChanging();
					this._JoinDate = value;
					this.SendPropertyChanged("JoinDate");
					this.OnJoinDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_theORDER", Storage="_theORDERs", ThisKey="CustID", OtherKey="CustID")]
		public EntitySet<theORDER> theORDERs
		{
			get
			{
				return this._theORDERs;
			}
			set
			{
				this._theORDERs.Assign(value);
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
		
		private void attach_theORDERs(theORDER entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_theORDERs(theORDER entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.theORDER")]
	public partial class theORDER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OrderID;
		
		private System.Nullable<decimal> _invoiceNo;
		
		private System.DateTime _oTimeStamp;
		
		private string _oStatus;
		
		private string _PayInfo;
		
		private System.Nullable<decimal> _Subtotal;
		
		private decimal _Total;
		
		private decimal _BasketSize;
		
		private string _CustID;
		
		private decimal _OrderListID;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(string value);
    partial void OnOrderIDChanged();
    partial void OninvoiceNoChanging(System.Nullable<decimal> value);
    partial void OninvoiceNoChanged();
    partial void OnoTimeStampChanging(System.DateTime value);
    partial void OnoTimeStampChanged();
    partial void OnoStatusChanging(string value);
    partial void OnoStatusChanged();
    partial void OnPayInfoChanging(string value);
    partial void OnPayInfoChanged();
    partial void OnSubtotalChanging(System.Nullable<decimal> value);
    partial void OnSubtotalChanged();
    partial void OnTotalChanging(decimal value);
    partial void OnTotalChanged();
    partial void OnBasketSizeChanging(decimal value);
    partial void OnBasketSizeChanged();
    partial void OnCustIDChanging(string value);
    partial void OnCustIDChanged();
    partial void OnOrderListIDChanging(decimal value);
    partial void OnOrderListIDChanged();
    #endregion
		
		public theORDER()
		{
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceNo", DbType="Decimal(5,0)")]
		public System.Nullable<decimal> invoiceNo
		{
			get
			{
				return this._invoiceNo;
			}
			set
			{
				if ((this._invoiceNo != value))
				{
					this.OninvoiceNoChanging(value);
					this.SendPropertyChanging();
					this._invoiceNo = value;
					this.SendPropertyChanged("invoiceNo");
					this.OninvoiceNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oTimeStamp", DbType="DateTime NOT NULL")]
		public System.DateTime oTimeStamp
		{
			get
			{
				return this._oTimeStamp;
			}
			set
			{
				if ((this._oTimeStamp != value))
				{
					this.OnoTimeStampChanging(value);
					this.SendPropertyChanging();
					this._oTimeStamp = value;
					this.SendPropertyChanged("oTimeStamp");
					this.OnoTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oStatus", DbType="VarChar(15)")]
		public string oStatus
		{
			get
			{
				return this._oStatus;
			}
			set
			{
				if ((this._oStatus != value))
				{
					this.OnoStatusChanging(value);
					this.SendPropertyChanging();
					this._oStatus = value;
					this.SendPropertyChanged("oStatus");
					this.OnoStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayInfo", DbType="VarChar(20)")]
		public string PayInfo
		{
			get
			{
				return this._PayInfo;
			}
			set
			{
				if ((this._PayInfo != value))
				{
					this.OnPayInfoChanging(value);
					this.SendPropertyChanging();
					this._PayInfo = value;
					this.SendPropertyChanged("PayInfo");
					this.OnPayInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subtotal", DbType="Decimal(8,0)")]
		public System.Nullable<decimal> Subtotal
		{
			get
			{
				return this._Subtotal;
			}
			set
			{
				if ((this._Subtotal != value))
				{
					this.OnSubtotalChanging(value);
					this.SendPropertyChanging();
					this._Subtotal = value;
					this.SendPropertyChanged("Subtotal");
					this.OnSubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(8,0) NOT NULL")]
		public decimal Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BasketSize", DbType="Decimal(5,0) NOT NULL")]
		public decimal BasketSize
		{
			get
			{
				return this._BasketSize;
			}
			set
			{
				if ((this._BasketSize != value))
				{
					this.OnBasketSizeChanging(value);
					this.SendPropertyChanging();
					this._BasketSize = value;
					this.SendPropertyChanged("BasketSize");
					this.OnBasketSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderListID", DbType="Decimal(6,0) NOT NULL")]
		public decimal OrderListID
		{
			get
			{
				return this._OrderListID;
			}
			set
			{
				if ((this._OrderListID != value))
				{
					this.OnOrderListIDChanging(value);
					this.SendPropertyChanging();
					this._OrderListID = value;
					this.SendPropertyChanged("OrderListID");
					this.OnOrderListIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_theORDER", Storage="_Customer", ThisKey="CustID", OtherKey="CustID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.theORDERs.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.theORDERs.Add(this);
						this._CustID = value.CustID;
					}
					else
					{
						this._CustID = default(string);
					}
					this.SendPropertyChanged("Customer");
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
