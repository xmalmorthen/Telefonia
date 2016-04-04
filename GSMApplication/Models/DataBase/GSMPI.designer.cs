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

namespace GSMApplication.Models.DataBase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GSMPI")]
	public partial class GSMPIDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertcaCommands(caCommands instance);
    partial void UpdatecaCommands(caCommands instance);
    partial void DeletecaCommands(caCommands instance);
    partial void InsertreCommandsParameters(reCommandsParameters instance);
    partial void UpdatereCommandsParameters(reCommandsParameters instance);
    partial void DeletereCommandsParameters(reCommandsParameters instance);
    partial void InsertcaParameters(caParameters instance);
    partial void UpdatecaParameters(caParameters instance);
    partial void DeletecaParameters(caParameters instance);
    #endregion
		
		public GSMPIDataContext() : 
				base(global::GSMApplication.Properties.Settings.Default.GSMPIConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GSMPIDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GSMPIDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GSMPIDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GSMPIDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<caCommands> caCommands
		{
			get
			{
				return this.GetTable<caCommands>();
			}
		}
		
		public System.Data.Linq.Table<reCommandsParameters> reCommandsParameters
		{
			get
			{
				return this.GetTable<reCommandsParameters>();
			}
		}
		
		public System.Data.Linq.Table<caParameters> caParameters
		{
			get
			{
				return this.GetTable<caParameters>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.caCommands")]
	public partial class caCommands : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _command;
		
		private string _description;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private EntitySet<reCommandsParameters> _reCommandsParameters;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncommandChanging(string value);
    partial void OncommandChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    #endregion
		
		public caCommands()
		{
			this._reCommandsParameters = new EntitySet<reCommandsParameters>(new Action<reCommandsParameters>(this.attach_reCommandsParameters), new Action<reCommandsParameters>(this.detach_reCommandsParameters));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_command", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string command
		{
			get
			{
				return this._command;
			}
			set
			{
				if ((this._command != value))
				{
					this.OncommandChanging(value);
					this.SendPropertyChanging();
					this._command = value;
					this.SendPropertyChanged("command");
					this.OncommandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caCommands_reCommandsParameters", Storage="_reCommandsParameters", ThisKey="id", OtherKey="idCommand")]
		public EntitySet<reCommandsParameters> reCommandsParameters
		{
			get
			{
				return this._reCommandsParameters;
			}
			set
			{
				this._reCommandsParameters.Assign(value);
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
		
		private void attach_reCommandsParameters(reCommandsParameters entity)
		{
			this.SendPropertyChanging();
			entity.caCommands = this;
		}
		
		private void detach_reCommandsParameters(reCommandsParameters entity)
		{
			this.SendPropertyChanging();
			entity.caCommands = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reCommandsParameters")]
	public partial class reCommandsParameters : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _tag;
		
		private int _idCommand;
		
		private int _idParameter;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private EntityRef<caCommands> _caCommands;
		
		private EntityRef<caParameters> _caParameters;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntagChanging(string value);
    partial void OntagChanged();
    partial void OnidCommandChanging(int value);
    partial void OnidCommandChanged();
    partial void OnidParameterChanging(int value);
    partial void OnidParameterChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    #endregion
		
		public reCommandsParameters()
		{
			this._caCommands = default(EntityRef<caCommands>);
			this._caParameters = default(EntityRef<caParameters>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tag", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCommand", DbType="Int NOT NULL")]
		public int idCommand
		{
			get
			{
				return this._idCommand;
			}
			set
			{
				if ((this._idCommand != value))
				{
					if (this._caCommands.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCommandChanging(value);
					this.SendPropertyChanging();
					this._idCommand = value;
					this.SendPropertyChanged("idCommand");
					this.OnidCommandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idParameter", DbType="Int NOT NULL")]
		public int idParameter
		{
			get
			{
				return this._idParameter;
			}
			set
			{
				if ((this._idParameter != value))
				{
					if (this._caParameters.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidParameterChanging(value);
					this.SendPropertyChanging();
					this._idParameter = value;
					this.SendPropertyChanged("idParameter");
					this.OnidParameterChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caCommands_reCommandsParameters", Storage="_caCommands", ThisKey="idCommand", OtherKey="id", IsForeignKey=true)]
		public caCommands caCommands
		{
			get
			{
				return this._caCommands.Entity;
			}
			set
			{
				caCommands previousValue = this._caCommands.Entity;
				if (((previousValue != value) 
							|| (this._caCommands.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._caCommands.Entity = null;
						previousValue.reCommandsParameters.Remove(this);
					}
					this._caCommands.Entity = value;
					if ((value != null))
					{
						value.reCommandsParameters.Add(this);
						this._idCommand = value.id;
					}
					else
					{
						this._idCommand = default(int);
					}
					this.SendPropertyChanged("caCommands");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caParameters_reCommandsParameters", Storage="_caParameters", ThisKey="idParameter", OtherKey="id", IsForeignKey=true)]
		public caParameters caParameters
		{
			get
			{
				return this._caParameters.Entity;
			}
			set
			{
				caParameters previousValue = this._caParameters.Entity;
				if (((previousValue != value) 
							|| (this._caParameters.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._caParameters.Entity = null;
						previousValue.reCommandsParameters.Remove(this);
					}
					this._caParameters.Entity = value;
					if ((value != null))
					{
						value.reCommandsParameters.Add(this);
						this._idParameter = value.id;
					}
					else
					{
						this._idParameter = default(int);
					}
					this.SendPropertyChanged("caParameters");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.caParameters")]
	public partial class caParameters : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _parameter;
		
		private string _description;
		
		private System.DateTime _fIns;
		
		private System.Nullable<System.DateTime> _fAct;
		
		private EntitySet<reCommandsParameters> _reCommandsParameters;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnparameterChanging(string value);
    partial void OnparameterChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnfInsChanging(System.DateTime value);
    partial void OnfInsChanged();
    partial void OnfActChanging(System.Nullable<System.DateTime> value);
    partial void OnfActChanged();
    #endregion
		
		public caParameters()
		{
			this._reCommandsParameters = new EntitySet<reCommandsParameters>(new Action<reCommandsParameters>(this.attach_reCommandsParameters), new Action<reCommandsParameters>(this.detach_reCommandsParameters));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parameter", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				if ((this._parameter != value))
				{
					this.OnparameterChanging(value);
					this.SendPropertyChanging();
					this._parameter = value;
					this.SendPropertyChanged("parameter");
					this.OnparameterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="caParameters_reCommandsParameters", Storage="_reCommandsParameters", ThisKey="id", OtherKey="idParameter")]
		public EntitySet<reCommandsParameters> reCommandsParameters
		{
			get
			{
				return this._reCommandsParameters;
			}
			set
			{
				this._reCommandsParameters.Assign(value);
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
		
		private void attach_reCommandsParameters(reCommandsParameters entity)
		{
			this.SendPropertyChanging();
			entity.caParameters = this;
		}
		
		private void detach_reCommandsParameters(reCommandsParameters entity)
		{
			this.SendPropertyChanging();
			entity.caParameters = null;
		}
	}
}
#pragma warning restore 1591
