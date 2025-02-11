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

namespace LanguageDetect.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="yb_masterlist")]
	public partial class ProcessLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmasterlist(masterlist instance);
    partial void Updatemasterlist(masterlist instance);
    partial void Deletemasterlist(masterlist instance);
    #endregion
		
		public ProcessLinqDataContext() : 
				base(global::LanguageDetect.Properties.Settings.Default.yb_masterlistConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProcessLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProcessLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProcessLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProcessLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<masterlist> masterlists
		{
			get
			{
				return this.GetTable<masterlist>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.masterlist")]
	public partial class masterlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _TITLE;
		
		private string _ARTIST;
		
		private string _ALBUM;
		
		private string _LABEL;
		
		private string _ISRC;
		
		private string _COMP_ID;
		
		private string _COMP_TITLE;
		
		private string _COMP_ISWC;
		
		private string _COMP_WRITERS;
		
		private string _COMP_CUSTOM_ID;
		
		private string _QUANTILE;
		
		private int _Indent;
		
		private bool _LangVi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnTITLEChanging(string value);
    partial void OnTITLEChanged();
    partial void OnARTISTChanging(string value);
    partial void OnARTISTChanged();
    partial void OnALBUMChanging(string value);
    partial void OnALBUMChanged();
    partial void OnLABELChanging(string value);
    partial void OnLABELChanged();
    partial void OnISRCChanging(string value);
    partial void OnISRCChanged();
    partial void OnCOMP_IDChanging(string value);
    partial void OnCOMP_IDChanged();
    partial void OnCOMP_TITLEChanging(string value);
    partial void OnCOMP_TITLEChanged();
    partial void OnCOMP_ISWCChanging(string value);
    partial void OnCOMP_ISWCChanged();
    partial void OnCOMP_WRITERSChanging(string value);
    partial void OnCOMP_WRITERSChanged();
    partial void OnCOMP_CUSTOM_IDChanging(string value);
    partial void OnCOMP_CUSTOM_IDChanged();
    partial void OnQUANTILEChanging(string value);
    partial void OnQUANTILEChanged();
    partial void OnIndentChanging(int value);
    partial void OnIndentChanged();
    partial void OnLangViChanging(bool value);
    partial void OnLangViChanged();
    #endregion
		
		public masterlist()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITLE", DbType="NVarChar(MAX)")]
		public string TITLE
		{
			get
			{
				return this._TITLE;
			}
			set
			{
				if ((this._TITLE != value))
				{
					this.OnTITLEChanging(value);
					this.SendPropertyChanging();
					this._TITLE = value;
					this.SendPropertyChanged("TITLE");
					this.OnTITLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ARTIST", DbType="NVarChar(MAX)")]
		public string ARTIST
		{
			get
			{
				return this._ARTIST;
			}
			set
			{
				if ((this._ARTIST != value))
				{
					this.OnARTISTChanging(value);
					this.SendPropertyChanging();
					this._ARTIST = value;
					this.SendPropertyChanged("ARTIST");
					this.OnARTISTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALBUM", DbType="NVarChar(MAX)")]
		public string ALBUM
		{
			get
			{
				return this._ALBUM;
			}
			set
			{
				if ((this._ALBUM != value))
				{
					this.OnALBUMChanging(value);
					this.SendPropertyChanging();
					this._ALBUM = value;
					this.SendPropertyChanged("ALBUM");
					this.OnALBUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LABEL", DbType="NVarChar(MAX)")]
		public string LABEL
		{
			get
			{
				return this._LABEL;
			}
			set
			{
				if ((this._LABEL != value))
				{
					this.OnLABELChanging(value);
					this.SendPropertyChanging();
					this._LABEL = value;
					this.SendPropertyChanged("LABEL");
					this.OnLABELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISRC", DbType="NVarChar(MAX)")]
		public string ISRC
		{
			get
			{
				return this._ISRC;
			}
			set
			{
				if ((this._ISRC != value))
				{
					this.OnISRCChanging(value);
					this.SendPropertyChanging();
					this._ISRC = value;
					this.SendPropertyChanged("ISRC");
					this.OnISRCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMP_ID", DbType="NVarChar(MAX)")]
		public string COMP_ID
		{
			get
			{
				return this._COMP_ID;
			}
			set
			{
				if ((this._COMP_ID != value))
				{
					this.OnCOMP_IDChanging(value);
					this.SendPropertyChanging();
					this._COMP_ID = value;
					this.SendPropertyChanged("COMP_ID");
					this.OnCOMP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMP_TITLE", DbType="NVarChar(MAX)")]
		public string COMP_TITLE
		{
			get
			{
				return this._COMP_TITLE;
			}
			set
			{
				if ((this._COMP_TITLE != value))
				{
					this.OnCOMP_TITLEChanging(value);
					this.SendPropertyChanging();
					this._COMP_TITLE = value;
					this.SendPropertyChanged("COMP_TITLE");
					this.OnCOMP_TITLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMP_ISWC", DbType="NVarChar(MAX)")]
		public string COMP_ISWC
		{
			get
			{
				return this._COMP_ISWC;
			}
			set
			{
				if ((this._COMP_ISWC != value))
				{
					this.OnCOMP_ISWCChanging(value);
					this.SendPropertyChanging();
					this._COMP_ISWC = value;
					this.SendPropertyChanged("COMP_ISWC");
					this.OnCOMP_ISWCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMP_WRITERS", DbType="NVarChar(MAX)")]
		public string COMP_WRITERS
		{
			get
			{
				return this._COMP_WRITERS;
			}
			set
			{
				if ((this._COMP_WRITERS != value))
				{
					this.OnCOMP_WRITERSChanging(value);
					this.SendPropertyChanging();
					this._COMP_WRITERS = value;
					this.SendPropertyChanged("COMP_WRITERS");
					this.OnCOMP_WRITERSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMP_CUSTOM_ID", DbType="NVarChar(MAX)")]
		public string COMP_CUSTOM_ID
		{
			get
			{
				return this._COMP_CUSTOM_ID;
			}
			set
			{
				if ((this._COMP_CUSTOM_ID != value))
				{
					this.OnCOMP_CUSTOM_IDChanging(value);
					this.SendPropertyChanging();
					this._COMP_CUSTOM_ID = value;
					this.SendPropertyChanged("COMP_CUSTOM_ID");
					this.OnCOMP_CUSTOM_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUANTILE", DbType="NVarChar(500)")]
		public string QUANTILE
		{
			get
			{
				return this._QUANTILE;
			}
			set
			{
				if ((this._QUANTILE != value))
				{
					this.OnQUANTILEChanging(value);
					this.SendPropertyChanging();
					this._QUANTILE = value;
					this.SendPropertyChanged("QUANTILE");
					this.OnQUANTILEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indent", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Indent
		{
			get
			{
				return this._Indent;
			}
			set
			{
				if ((this._Indent != value))
				{
					this.OnIndentChanging(value);
					this.SendPropertyChanging();
					this._Indent = value;
					this.SendPropertyChanged("Indent");
					this.OnIndentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LangVi", DbType="Bit NOT NULL")]
		public bool LangVi
		{
			get
			{
				return this._LangVi;
			}
			set
			{
				if ((this._LangVi != value))
				{
					this.OnLangViChanging(value);
					this.SendPropertyChanging();
					this._LangVi = value;
					this.SendPropertyChanged("LangVi");
					this.OnLangViChanged();
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
