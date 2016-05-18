﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicator.Models.DataBase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBDuplicator")]
	public partial class DBDuplicatorDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertcaConfigurations(caConfigurations instance);
    partial void UpdatecaConfigurations(caConfigurations instance);
    partial void DeletecaConfigurations(caConfigurations instance);
    partial void InsertreUsersDuplicators(reUsersDuplicators instance);
    partial void UpdatereUsersDuplicators(reUsersDuplicators instance);
    partial void DeletereUsersDuplicators(reUsersDuplicators instance);
    partial void InsertmaDuplicator(maDuplicator instance);
    partial void UpdatemaDuplicator(maDuplicator instance);
    partial void DeletemaDuplicator(maDuplicator instance);
    partial void InsertcaUsers(caUsers instance);
    partial void UpdatecaUsers(caUsers instance);
    partial void DeletecaUsers(caUsers instance);
    #endregion
		
		public DBDuplicatorDataContext() : 
				base(global::Duplicator.Properties.Settings.Default.DBDuplicatorConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDuplicatorDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDuplicatorDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDuplicatorDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDuplicatorDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<caConfigurations> caConfigurations
		{
			get
			{
				return this.GetTable<caConfigurations>();
			}
		}
		
		public System.Data.Linq.Table<reUsersDuplicators> reUsersDuplicators
		{
			get
			{
				return this.GetTable<reUsersDuplicators>();
			}
		}
		
		public System.Data.Linq.Table<maDuplicator> maDuplicator
		{
			get
			{
				return this.GetTable<maDuplicator>();
			}
		}
		
		public System.Data.Linq.Table<caUsers> caUsers
		{
			get
			{
				return this.GetTable<caUsers>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDuplicatesActivesByIdUser")]
		public ISingleResult<spDuplicatesActivesByIdUserResult> spDuplicatesActivesByIdUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idUser)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idUser);
			return ((ISingleResult<spDuplicatesActivesByIdUserResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.caConfigurations")]
	public partial class caConfigurations : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _tag;
		
		private string _description;
		
		private string _value;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntagChanging(string value);
    partial void OntagChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnvalueChanging(string value);
    partial void OnvalueChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    #endregion
		
		public caConfigurations()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tag", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if ((this._tag != value))
				{
					this.OntagChanging(value);
					this.SendPropertyChanging();
					this._tag = value;
					this.SendPropertyChanged("tag");
					this.OntagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fIns", DbType="DateTime NOT NULL", IsDbGenerated=true)]
		public System.DateTime fIns
		{
			get
			{
				return this._fIns;
			}
			set
			{
				if ((this._fIns != value))
				{
					this.OnfInsChanging(value);
					this.SendPropertyChanging();
					this._fIns = value;
					this.SendPropertyChanged("fIns");
					this.OnfInsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fAct", DbType="DateTime")]
		public System.Nullable<System.DateTime> fAct
		{
			get
			{
				return this._fAct;
			}
			set
			{
				if ((this._fAct != value))
				{
					this.OnfActChanging(value);
					this.SendPropertyChanging();
					this._fAct = value;
					this.SendPropertyChanged("fAct");
					this.OnfActChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reUsersDuplicators")]
	public partial class reUsersDuplicators : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _idUser;
		
		private int _idMaDuplicator;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private bool _active;
		
		private EntityRef<maDuplicator> _maDuplicator;
		
		private EntityRef<caUsers> _caUsers;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidUserChanging(int value);
    partial void OnidUserChanged();
    partial void OnidMaDuplicatorChanging(int value);
    partial void OnidMaDuplicatorChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    #endregion
		
		public reUsersDuplicators()
		{
			this._maDuplicator = default(EntityRef<maDuplicator>);
			this._caUsers = default(EntityRef<caUsers>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUser", DbType="Int NOT NULL")]
		public int idUser
		{
			get
			{
				return this._idUser;
			}
			set
			{
				if ((this._idUser != value))
				{
					if (this._caUsers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUserChanging(value);
					this.SendPropertyChanging();
					this._idUser = value;
					this.SendPropertyChanged("idUser");
					this.OnidUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMaDuplicator", DbType="Int NOT NULL")]
		public int idMaDuplicator
		{
			get
			{
				return this._idMaDuplicator;
			}
			set
			{
				if ((this._idMaDuplicator != value))
				{
					if (this._maDuplicator.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidMaDuplicatorChanging(value);
					this.SendPropertyChanging();
					this._idMaDuplicator = value;
					this.SendPropertyChanged("idMaDuplicator");
					this.OnidMaDuplicatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fIns", DbType="DateTime NOT NULL", IsDbGenerated=true)]
		public System.DateTime fIns
		{
			get
			{
				return this._fIns;
			}
			set
			{
				if ((this._fIns != value))
				{
					this.OnfInsChanging(value);
					this.SendPropertyChanging();
					this._fIns = value;
					this.SendPropertyChanged("fIns");
					this.OnfInsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fAct", DbType="DateTime")]
		public System.Nullable<System.DateTime> fAct
		{
			get
			{
				return this._fAct;
			}
			set
			{
				if ((this._fAct != value))
				{
					this.OnfActChanging(value);
					this.SendPropertyChanging();
					this._fAct = value;
					this.SendPropertyChanged("fAct");
					this.OnfActChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="maDuplicator_reUsersDuplicators", Storage="_maDuplicator", ThisKey="idMaDuplicator", OtherKey="id", IsForeignKey=true)]
		public maDuplicator maDuplicator
		{
			get
			{
				return this._maDuplicator.Entity;
			}
			set
			{
				maDuplicator previousValue = this._maDuplicator.Entity;
				if (((previousValue != value) 
							|| (this._maDuplicator.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._maDuplicator.Entity = null;
						previousValue.reUsersDuplicators.Remove(this);
					}
					this._maDuplicator.Entity = value;
					if ((value != null))
					{
						value.reUsersDuplicators.Add(this);
						this._idMaDuplicator = value.id;
					}
					else
					{
						this._idMaDuplicator = default(int);
					}
					this.SendPropertyChanged("maDuplicator");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caUsers_reUsersDuplicators", Storage="_caUsers", ThisKey="idUser", OtherKey="id", IsForeignKey=true)]
		public caUsers caUsers
		{
			get
			{
				return this._caUsers.Entity;
			}
			set
			{
				caUsers previousValue = this._caUsers.Entity;
				if (((previousValue != value) 
							|| (this._caUsers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._caUsers.Entity = null;
						previousValue.reUsersDuplicators.Remove(this);
					}
					this._caUsers.Entity = value;
					if ((value != null))
					{
						value.reUsersDuplicators.Add(this);
						this._idUser = value.id;
					}
					else
					{
						this._idUser = default(int);
					}
					this.SendPropertyChanged("caUsers");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.maDuplicator")]
	public partial class maDuplicator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _number;
		
		private string _carrier;
		
		private string _country;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private bool _active;
		
		private EntitySet<reUsersDuplicators> _reUsersDuplicators;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OncarrierChanging(string value);
    partial void OncarrierChanged();
    partial void OncountryChanging(string value);
    partial void OncountryChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    #endregion
		
		public maDuplicator()
		{
			this._reUsersDuplicators = new EntitySet<reUsersDuplicators>(new Action<reUsersDuplicators>(this.attach_reUsersDuplicators), new Action<reUsersDuplicators>(this.detach_reUsersDuplicators));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carrier", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string carrier
		{
			get
			{
				return this._carrier;
			}
			set
			{
				if ((this._carrier != value))
				{
					this.OncarrierChanging(value);
					this.SendPropertyChanging();
					this._carrier = value;
					this.SendPropertyChanged("carrier");
					this.OncarrierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string country
		{
			get
			{
				return this._country;
			}
			set
			{
				if ((this._country != value))
				{
					this.OncountryChanging(value);
					this.SendPropertyChanging();
					this._country = value;
					this.SendPropertyChanged("country");
					this.OncountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fIns", DbType="DateTime NOT NULL", IsDbGenerated=true)]
		public System.DateTime fIns
		{
			get
			{
				return this._fIns;
			}
			set
			{
				if ((this._fIns != value))
				{
					this.OnfInsChanging(value);
					this.SendPropertyChanging();
					this._fIns = value;
					this.SendPropertyChanged("fIns");
					this.OnfInsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fAct", DbType="DateTime")]
		public System.Nullable<System.DateTime> fAct
		{
			get
			{
				return this._fAct;
			}
			set
			{
				if ((this._fAct != value))
				{
					this.OnfActChanging(value);
					this.SendPropertyChanging();
					this._fAct = value;
					this.SendPropertyChanged("fAct");
					this.OnfActChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="maDuplicator_reUsersDuplicators", Storage="_reUsersDuplicators", ThisKey="id", OtherKey="idMaDuplicator")]
		public EntitySet<reUsersDuplicators> reUsersDuplicators
		{
			get
			{
				return this._reUsersDuplicators;
			}
			set
			{
				this._reUsersDuplicators.Assign(value);
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
		
		private void attach_reUsersDuplicators(reUsersDuplicators entity)
		{
			this.SendPropertyChanging();
			entity.maDuplicator = this;
		}
		
		private void detach_reUsersDuplicators(reUsersDuplicators entity)
		{
			this.SendPropertyChanging();
			entity.maDuplicator = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.caUsers")]
	public partial class caUsers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _user;
		
		private string _password;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private bool _active;
		
		private bool _isAdmin;
		
		private System.Nullable<int> _objectivesNumber;
		
		private EntitySet<reUsersDuplicators> _reUsersDuplicators;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnuserChanging(string value);
    partial void OnuserChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    partial void OnisAdminChanging(bool value);
    partial void OnisAdminChanged();
    partial void OnobjectivesNumberChanging(System.Nullable<int> value);
    partial void OnobjectivesNumberChanged();
    #endregion
		
		public caUsers()
		{
			this._reUsersDuplicators = new EntitySet<reUsersDuplicators>(new Action<reUsersDuplicators>(this.attach_reUsersDuplicators), new Action<reUsersDuplicators>(this.detach_reUsersDuplicators));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[user]", Storage="_user", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string user
		{
			get
			{
				return this._user;
			}
			set
			{
				if ((this._user != value))
				{
					this.OnuserChanging(value);
					this.SendPropertyChanging();
					this._user = value;
					this.SendPropertyChanged("user");
					this.OnuserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fIns", DbType="DateTime NOT NULL", IsDbGenerated=true)]
		public System.DateTime fIns
		{
			get
			{
				return this._fIns;
			}
			set
			{
				if ((this._fIns != value))
				{
					this.OnfInsChanging(value);
					this.SendPropertyChanging();
					this._fIns = value;
					this.SendPropertyChanged("fIns");
					this.OnfInsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fAct", DbType="DateTime")]
		public System.Nullable<System.DateTime> fAct
		{
			get
			{
				return this._fAct;
			}
			set
			{
				if ((this._fAct != value))
				{
					this.OnfActChanging(value);
					this.SendPropertyChanging();
					this._fAct = value;
					this.SendPropertyChanged("fAct");
					this.OnfActChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit NOT NULL")]
		public bool isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectivesNumber", DbType="Int")]
		public System.Nullable<int> objectivesNumber
		{
			get
			{
				return this._objectivesNumber;
			}
			set
			{
				if ((this._objectivesNumber != value))
				{
					this.OnobjectivesNumberChanging(value);
					this.SendPropertyChanging();
					this._objectivesNumber = value;
					this.SendPropertyChanged("objectivesNumber");
					this.OnobjectivesNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caUsers_reUsersDuplicators", Storage="_reUsersDuplicators", ThisKey="id", OtherKey="idUser")]
		public EntitySet<reUsersDuplicators> reUsersDuplicators
		{
			get
			{
				return this._reUsersDuplicators;
			}
			set
			{
				this._reUsersDuplicators.Assign(value);
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
		
		private void attach_reUsersDuplicators(reUsersDuplicators entity)
		{
			this.SendPropertyChanging();
			entity.caUsers = this;
		}
		
		private void detach_reUsersDuplicators(reUsersDuplicators entity)
		{
			this.SendPropertyChanging();
			entity.caUsers = null;
		}
	}
	
	public partial class spDuplicatesActivesByIdUserResult
	{
		
		private System.Nullable<int> _DuplicatesNumber;
		
		public spDuplicatesActivesByIdUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuplicatesNumber", DbType="Int")]
		public System.Nullable<int> DuplicatesNumber
		{
			get
			{
				return this._DuplicatesNumber;
			}
			set
			{
				if ((this._DuplicatesNumber != value))
				{
					this._DuplicatesNumber = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
