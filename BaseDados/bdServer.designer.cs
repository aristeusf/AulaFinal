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

namespace BaseDados
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AulaDotNet")]
	public partial class bdServerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertEstado(Estado instance);
    partial void UpdateEstado(Estado instance);
    partial void DeleteEstado(Estado instance);
    #endregion
		
		public bdServerDataContext() : 
				base(global::BaseDados.Properties.Settings.Default.AulaDotNetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public bdServerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bdServerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bdServerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bdServerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Estado> Estados
		{
			get
			{
				return this.GetTable<Estado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clientes")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _CNPJ;
		
		private string _Nome;
		
		private string _Logradouro;
		
		private string _Cidade;
		
		private string _cep;
		
		private string _Bairro;
		
		private string _Pais;
		
		private string _UF;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnCNPJChanging(string value);
    partial void OnCNPJChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnLogradouroChanging(string value);
    partial void OnLogradouroChanged();
    partial void OnCidadeChanging(string value);
    partial void OnCidadeChanged();
    partial void OncepChanging(string value);
    partial void OncepChanged();
    partial void OnBairroChanging(string value);
    partial void OnBairroChanged();
    partial void OnPaisChanging(string value);
    partial void OnPaisChanged();
    partial void OnUFChanging(string value);
    partial void OnUFChanged();
    #endregion
		
		public Cliente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNPJ", DbType="VarChar(20)")]
		public string CNPJ
		{
			get
			{
				return this._CNPJ;
			}
			set
			{
				if ((this._CNPJ != value))
				{
					this.OnCNPJChanging(value);
					this.SendPropertyChanging();
					this._CNPJ = value;
					this.SendPropertyChanged("CNPJ");
					this.OnCNPJChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(150)")]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logradouro", DbType="VarChar(200)")]
		public string Logradouro
		{
			get
			{
				return this._Logradouro;
			}
			set
			{
				if ((this._Logradouro != value))
				{
					this.OnLogradouroChanging(value);
					this.SendPropertyChanging();
					this._Logradouro = value;
					this.SendPropertyChanged("Logradouro");
					this.OnLogradouroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cidade", DbType="VarChar(50)")]
		public string Cidade
		{
			get
			{
				return this._Cidade;
			}
			set
			{
				if ((this._Cidade != value))
				{
					this.OnCidadeChanging(value);
					this.SendPropertyChanging();
					this._Cidade = value;
					this.SendPropertyChanged("Cidade");
					this.OnCidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cep", DbType="VarChar(10)")]
		public string cep
		{
			get
			{
				return this._cep;
			}
			set
			{
				if ((this._cep != value))
				{
					this.OncepChanging(value);
					this.SendPropertyChanging();
					this._cep = value;
					this.SendPropertyChanged("cep");
					this.OncepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bairro", DbType="VarChar(100)")]
		public string Bairro
		{
			get
			{
				return this._Bairro;
			}
			set
			{
				if ((this._Bairro != value))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._Bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pais", DbType="VarChar(50)")]
		public string Pais
		{
			get
			{
				return this._Pais;
			}
			set
			{
				if ((this._Pais != value))
				{
					this.OnPaisChanging(value);
					this.SendPropertyChanging();
					this._Pais = value;
					this.SendPropertyChanged("Pais");
					this.OnPaisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UF", DbType="VarChar(2)")]
		public string UF
		{
			get
			{
				return this._UF;
			}
			set
			{
				if ((this._UF != value))
				{
					this.OnUFChanging(value);
					this.SendPropertyChanging();
					this._UF = value;
					this.SendPropertyChanged("UF");
					this.OnUFChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Estados")]
	public partial class Estado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _id;
		
		private string _UF;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(decimal value);
    partial void OnidChanged();
    partial void OnUFChanging(string value);
    partial void OnUFChanged();
    #endregion
		
		public Estado()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UF", DbType="VarChar(2)")]
		public string UF
		{
			get
			{
				return this._UF;
			}
			set
			{
				if ((this._UF != value))
				{
					this.OnUFChanging(value);
					this.SendPropertyChanging();
					this._UF = value;
					this.SendPropertyChanged("UF");
					this.OnUFChanged();
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
