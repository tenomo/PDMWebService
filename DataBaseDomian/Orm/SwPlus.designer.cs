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

namespace DataBaseDomian.Orm
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SWPlusDB")]
	public partial class SwPlusDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public SwPlusDataContext() : 
				base(global::DataBaseDomian.Properties.Settings.Default.SWPlusDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SwPlusDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SwPlusDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SwPlusDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SwPlusDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Part> View_Parts
		{
			get
			{
				return this.GetTable<View_Part>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Parts")]
	public partial class View_Part
	{
		
		private System.Nullable<int> _Bend;
		
		private System.Nullable<decimal> _PaintX;
		
		private System.Nullable<decimal> _PaintY;
		
		private System.Nullable<decimal> _PaintZ;
		
		private System.Nullable<decimal> _SurfaceArea;
		
		private System.Nullable<decimal> _Thickness;
		
		private int _Version;
		
		private System.Nullable<decimal> _WorkpieceX;
		
		private System.Nullable<decimal> _WorkpieceY;
		
		private System.Nullable<int> _IDPDM;
		
		private string _ConfigurationName;
		
		private string _DXF;
		
		public View_Part()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bend", DbType="Int")]
		public System.Nullable<int> Bend
		{
			get
			{
				return this._Bend;
			}
			set
			{
				if ((this._Bend != value))
				{
					this._Bend = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintX", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> PaintX
		{
			get
			{
				return this._PaintX;
			}
			set
			{
				if ((this._PaintX != value))
				{
					this._PaintX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintY", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> PaintY
		{
			get
			{
				return this._PaintY;
			}
			set
			{
				if ((this._PaintY != value))
				{
					this._PaintY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintZ", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> PaintZ
		{
			get
			{
				return this._PaintZ;
			}
			set
			{
				if ((this._PaintZ != value))
				{
					this._PaintZ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurfaceArea", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> SurfaceArea
		{
			get
			{
				return this._SurfaceArea;
			}
			set
			{
				if ((this._SurfaceArea != value))
				{
					this._SurfaceArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thickness", DbType="Decimal(3,1)")]
		public System.Nullable<decimal> Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				if ((this._Thickness != value))
				{
					this._Thickness = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Version", DbType="Int NOT NULL")]
		public int Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this._Version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkpieceX", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> WorkpieceX
		{
			get
			{
				return this._WorkpieceX;
			}
			set
			{
				if ((this._WorkpieceX != value))
				{
					this._WorkpieceX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkpieceY", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> WorkpieceY
		{
			get
			{
				return this._WorkpieceY;
			}
			set
			{
				if ((this._WorkpieceY != value))
				{
					this._WorkpieceY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPDM", DbType="Int")]
		public System.Nullable<int> IDPDM
		{
			get
			{
				return this._IDPDM;
			}
			set
			{
				if ((this._IDPDM != value))
				{
					this._IDPDM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfigurationName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string ConfigurationName
		{
			get
			{
				return this._ConfigurationName;
			}
			set
			{
				if ((this._ConfigurationName != value))
				{
					this._ConfigurationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DXF", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string DXF
		{
			get
			{
				return this._DXF;
			}
			set
			{
				if ((this._DXF != value))
				{
					this._DXF = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
