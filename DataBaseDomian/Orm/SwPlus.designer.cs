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
    partial void InsertBendTable(BendTable instance);
    partial void UpdateBendTable(BendTable instance);
    partial void DeleteBendTable(BendTable instance);
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
		
		public System.Data.Linq.Table<BendTable> BendTables
		{
			get
			{
				return this.GetTable<BendTable>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DXFCheck")]
		public int DXFCheck([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDPDM", DbType="Int")] System.Nullable<int> iDPDM, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Configuration", DbType="NVarChar(255)")] string configuration, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Version", DbType="Int")] System.Nullable<int> version)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDPDM, configuration, version);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AirVents_AddPartOfPanel_test")]
		public int AirVents_AddPartOfPanel_test([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PanelTypeID", DbType="Int")] System.Nullable<int> panelTypeID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ElementType", DbType="Int")] System.Nullable<int> elementType, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Width", DbType="Int")] System.Nullable<int> width, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Height", DbType="Int")] System.Nullable<int> height, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PartThick", DbType="Int")] System.Nullable<int> partThick, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PartMat", DbType="Int")] System.Nullable<int> partMat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PartMatThick", DbType="Decimal(3,1)")] System.Nullable<decimal> partMatThick, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mirror", DbType="Bit")] System.Nullable<bool> mirror, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StickyTape", DbType="Bit")] System.Nullable<bool> stickyTape, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Step", DbType="NVarChar(255)")] string step, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StepInsertion", DbType="NVarChar(255)")] string stepInsertion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Reinforcing", DbType="Bit")] System.Nullable<bool> reinforcing, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AirHole", DbType="NVarChar(255)")] string airHole, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PARTID", DbType="Int")] ref System.Nullable<int> pARTID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), panelTypeID, elementType, width, height, partThick, partMat, partMatThick, mirror, stickyTape, step, stepInsertion, reinforcing, airHole, pARTID);
			pARTID = ((System.Nullable<int>)(result.GetParameterValue(13)));
			return ((int)(result.ReturnValue));
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Materials.BendTable")]
	public partial class BendTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BendID;
		
		private decimal _Thickness;
		
		private decimal _K_Factor;
		
		private decimal _BendRadius;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBendIDChanging(int value);
    partial void OnBendIDChanged();
    partial void OnThicknessChanging(decimal value);
    partial void OnThicknessChanged();
    partial void OnK_FactorChanging(decimal value);
    partial void OnK_FactorChanged();
    partial void OnBendRadiusChanging(decimal value);
    partial void OnBendRadiusChanged();
    #endregion
		
		public BendTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BendID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BendID
		{
			get
			{
				return this._BendID;
			}
			set
			{
				if ((this._BendID != value))
				{
					this.OnBendIDChanging(value);
					this.SendPropertyChanging();
					this._BendID = value;
					this.SendPropertyChanged("BendID");
					this.OnBendIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thickness", DbType="Decimal(2,1) NOT NULL")]
		public decimal Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				if ((this._Thickness != value))
				{
					this.OnThicknessChanging(value);
					this.SendPropertyChanging();
					this._Thickness = value;
					this.SendPropertyChanged("Thickness");
					this.OnThicknessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[K-Factor]", Storage="_K_Factor", DbType="Decimal(5,3) NOT NULL")]
		public decimal K_Factor
		{
			get
			{
				return this._K_Factor;
			}
			set
			{
				if ((this._K_Factor != value))
				{
					this.OnK_FactorChanging(value);
					this.SendPropertyChanging();
					this._K_Factor = value;
					this.SendPropertyChanged("K_Factor");
					this.OnK_FactorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BendRadius", DbType="Decimal(4,2) NOT NULL")]
		public decimal BendRadius
		{
			get
			{
				return this._BendRadius;
			}
			set
			{
				if ((this._BendRadius != value))
				{
					this.OnBendRadiusChanging(value);
					this.SendPropertyChanging();
					this._BendRadius = value;
					this.SendPropertyChanged("BendRadius");
					this.OnBendRadiusChanged();
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
