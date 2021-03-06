
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace BusinessLayer
{
	public abstract class _tblPinCode : SqlClientEntity
	{
		public _tblPinCode()
		{
			this.QuerySource = "tblPinCode";
			this.MappingName = "tblPinCode";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblPinCodeLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppPinCodeID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppPinCodeID, AppPinCodeID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblPinCodeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppPinCodeID
			{
				get
				{
					return new SqlParameter("@AppPinCodeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppPinCode
			{
				get
				{
					return new SqlParameter("@AppPinCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppIsActive
			{
				get
				{
					return new SqlParameter("@AppIsActive", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppCityID
			{
				get
				{
					return new SqlParameter("@AppCityID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppControlingStation
			{
				get
				{
					return new SqlParameter("@AppControlingStation", SqlDbType.VarChar, 10);
				}
			}
			
			public static SqlParameter AppLocationCode
			{
				get
				{
					return new SqlParameter("@AppLocationCode", SqlDbType.VarChar, 10);
				}
			}
			
			public static SqlParameter AppArea
			{
				get
				{
					return new SqlParameter("@AppArea", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter AppZone
			{
				get
				{
					return new SqlParameter("@AppZone", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter AppRegion
			{
				get
				{
					return new SqlParameter("@AppRegion", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter AppEXP
			{
				get
				{
					return new SqlParameter("@AppEXP", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppTopay
			{
				get
				{
					return new SqlParameter("@AppTopay", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppCOD
			{
				get
				{
					return new SqlParameter("@AppCOD", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppPinCodeID = "appPinCodeID";
            public const string AppPinCode = "appPinCode";
            public const string AppIsActive = "appIsActive";
            public const string AppCityID = "appCityID";
            public const string AppControlingStation = "appControlingStation";
            public const string AppLocationCode = "appLocationCode";
            public const string AppArea = "appArea";
            public const string AppZone = "appZone";
            public const string AppRegion = "appRegion";
            public const string AppEXP = "appEXP";
            public const string AppTopay = "appTopay";
            public const string AppCOD = "appCOD";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppPinCodeID] = _tblPinCode.PropertyNames.AppPinCodeID;
					ht[AppPinCode] = _tblPinCode.PropertyNames.AppPinCode;
					ht[AppIsActive] = _tblPinCode.PropertyNames.AppIsActive;
					ht[AppCityID] = _tblPinCode.PropertyNames.AppCityID;
					ht[AppControlingStation] = _tblPinCode.PropertyNames.AppControlingStation;
					ht[AppLocationCode] = _tblPinCode.PropertyNames.AppLocationCode;
					ht[AppArea] = _tblPinCode.PropertyNames.AppArea;
					ht[AppZone] = _tblPinCode.PropertyNames.AppZone;
					ht[AppRegion] = _tblPinCode.PropertyNames.AppRegion;
					ht[AppEXP] = _tblPinCode.PropertyNames.AppEXP;
					ht[AppTopay] = _tblPinCode.PropertyNames.AppTopay;
					ht[AppCOD] = _tblPinCode.PropertyNames.AppCOD;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppPinCodeID = "AppPinCodeID";
            public const string AppPinCode = "AppPinCode";
            public const string AppIsActive = "AppIsActive";
            public const string AppCityID = "AppCityID";
            public const string AppControlingStation = "AppControlingStation";
            public const string AppLocationCode = "AppLocationCode";
            public const string AppArea = "AppArea";
            public const string AppZone = "AppZone";
            public const string AppRegion = "AppRegion";
            public const string AppEXP = "AppEXP";
            public const string AppTopay = "AppTopay";
            public const string AppCOD = "AppCOD";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppPinCodeID] = _tblPinCode.ColumnNames.AppPinCodeID;
					ht[AppPinCode] = _tblPinCode.ColumnNames.AppPinCode;
					ht[AppIsActive] = _tblPinCode.ColumnNames.AppIsActive;
					ht[AppCityID] = _tblPinCode.ColumnNames.AppCityID;
					ht[AppControlingStation] = _tblPinCode.ColumnNames.AppControlingStation;
					ht[AppLocationCode] = _tblPinCode.ColumnNames.AppLocationCode;
					ht[AppArea] = _tblPinCode.ColumnNames.AppArea;
					ht[AppZone] = _tblPinCode.ColumnNames.AppZone;
					ht[AppRegion] = _tblPinCode.ColumnNames.AppRegion;
					ht[AppEXP] = _tblPinCode.ColumnNames.AppEXP;
					ht[AppTopay] = _tblPinCode.ColumnNames.AppTopay;
					ht[AppCOD] = _tblPinCode.ColumnNames.AppCOD;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppPinCodeID = "s_AppPinCodeID";
            public const string AppPinCode = "s_AppPinCode";
            public const string AppIsActive = "s_AppIsActive";
            public const string AppCityID = "s_AppCityID";
            public const string AppControlingStation = "s_AppControlingStation";
            public const string AppLocationCode = "s_AppLocationCode";
            public const string AppArea = "s_AppArea";
            public const string AppZone = "s_AppZone";
            public const string AppRegion = "s_AppRegion";
            public const string AppEXP = "s_AppEXP";
            public const string AppTopay = "s_AppTopay";
            public const string AppCOD = "s_AppCOD";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppPinCodeID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppPinCodeID);
			}
			set
	        {
				base.Setint(ColumnNames.AppPinCodeID, value);
			}
		}

		public virtual int AppPinCode
	    {
			get
	        {
				return base.Getint(ColumnNames.AppPinCode);
			}
			set
	        {
				base.Setint(ColumnNames.AppPinCode, value);
			}
		}

		public virtual bool AppIsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsActive, value);
			}
		}

		public virtual int AppCityID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppCityID);
			}
			set
	        {
				base.Setint(ColumnNames.AppCityID, value);
			}
		}

		public virtual string AppControlingStation
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppControlingStation);
			}
			set
	        {
				base.Setstring(ColumnNames.AppControlingStation, value);
			}
		}

		public virtual string AppLocationCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppLocationCode);
			}
			set
	        {
				base.Setstring(ColumnNames.AppLocationCode, value);
			}
		}

		public virtual string AppArea
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppArea);
			}
			set
	        {
				base.Setstring(ColumnNames.AppArea, value);
			}
		}

		public virtual string AppZone
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppZone);
			}
			set
	        {
				base.Setstring(ColumnNames.AppZone, value);
			}
		}

		public virtual string AppRegion
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppRegion);
			}
			set
	        {
				base.Setstring(ColumnNames.AppRegion, value);
			}
		}

		public virtual bool AppEXP
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppEXP);
			}
			set
	        {
				base.Setbool(ColumnNames.AppEXP, value);
			}
		}

		public virtual bool AppTopay
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppTopay);
			}
			set
	        {
				base.Setbool(ColumnNames.AppTopay, value);
			}
		}

		public virtual bool AppCOD
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppCOD);
			}
			set
	        {
				base.Setbool(ColumnNames.AppCOD, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppPinCodeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppPinCodeID) ? string.Empty : base.GetintAsString(ColumnNames.AppPinCodeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppPinCodeID);
				else
					this.AppPinCodeID = base.SetintAsString(ColumnNames.AppPinCodeID, value);
			}
		}

		public virtual string s_AppPinCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppPinCode) ? string.Empty : base.GetintAsString(ColumnNames.AppPinCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppPinCode);
				else
					this.AppPinCode = base.SetintAsString(ColumnNames.AppPinCode, value);
			}
		}

		public virtual string s_AppIsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsActive) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsActive);
				else
					this.AppIsActive = base.SetboolAsString(ColumnNames.AppIsActive, value);
			}
		}

		public virtual string s_AppCityID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCityID) ? string.Empty : base.GetintAsString(ColumnNames.AppCityID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCityID);
				else
					this.AppCityID = base.SetintAsString(ColumnNames.AppCityID, value);
			}
		}

		public virtual string s_AppControlingStation
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppControlingStation) ? string.Empty : base.GetstringAsString(ColumnNames.AppControlingStation);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppControlingStation);
				else
					this.AppControlingStation = base.SetstringAsString(ColumnNames.AppControlingStation, value);
			}
		}

		public virtual string s_AppLocationCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppLocationCode) ? string.Empty : base.GetstringAsString(ColumnNames.AppLocationCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppLocationCode);
				else
					this.AppLocationCode = base.SetstringAsString(ColumnNames.AppLocationCode, value);
			}
		}

		public virtual string s_AppArea
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppArea) ? string.Empty : base.GetstringAsString(ColumnNames.AppArea);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppArea);
				else
					this.AppArea = base.SetstringAsString(ColumnNames.AppArea, value);
			}
		}

		public virtual string s_AppZone
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppZone) ? string.Empty : base.GetstringAsString(ColumnNames.AppZone);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppZone);
				else
					this.AppZone = base.SetstringAsString(ColumnNames.AppZone, value);
			}
		}

		public virtual string s_AppRegion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppRegion) ? string.Empty : base.GetstringAsString(ColumnNames.AppRegion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppRegion);
				else
					this.AppRegion = base.SetstringAsString(ColumnNames.AppRegion, value);
			}
		}

		public virtual string s_AppEXP
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppEXP) ? string.Empty : base.GetboolAsString(ColumnNames.AppEXP);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppEXP);
				else
					this.AppEXP = base.SetboolAsString(ColumnNames.AppEXP, value);
			}
		}

		public virtual string s_AppTopay
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppTopay) ? string.Empty : base.GetboolAsString(ColumnNames.AppTopay);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppTopay);
				else
					this.AppTopay = base.SetboolAsString(ColumnNames.AppTopay, value);
			}
		}

		public virtual string s_AppCOD
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCOD) ? string.Empty : base.GetboolAsString(ColumnNames.AppCOD);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCOD);
				else
					this.AppCOD = base.SetboolAsString(ColumnNames.AppCOD, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter AppPinCodeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppPinCodeID, Parameters.AppPinCodeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppPinCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppPinCode, Parameters.AppPinCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsActive, Parameters.AppIsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCityID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCityID, Parameters.AppCityID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppControlingStation
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppControlingStation, Parameters.AppControlingStation);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppLocationCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppLocationCode, Parameters.AppLocationCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppArea
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppArea, Parameters.AppArea);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppZone
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppZone, Parameters.AppZone);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppRegion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppRegion, Parameters.AppRegion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppEXP
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppEXP, Parameters.AppEXP);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppTopay
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppTopay, Parameters.AppTopay);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCOD
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCOD, Parameters.AppCOD);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppPinCodeID
		    {
				get
		        {
					if(_AppPinCodeID_W == null)
	        	    {
						_AppPinCodeID_W = TearOff.AppPinCodeID;
					}
					return _AppPinCodeID_W;
				}
			}

			public WhereParameter AppPinCode
		    {
				get
		        {
					if(_AppPinCode_W == null)
	        	    {
						_AppPinCode_W = TearOff.AppPinCode;
					}
					return _AppPinCode_W;
				}
			}

			public WhereParameter AppIsActive
		    {
				get
		        {
					if(_AppIsActive_W == null)
	        	    {
						_AppIsActive_W = TearOff.AppIsActive;
					}
					return _AppIsActive_W;
				}
			}

			public WhereParameter AppCityID
		    {
				get
		        {
					if(_AppCityID_W == null)
	        	    {
						_AppCityID_W = TearOff.AppCityID;
					}
					return _AppCityID_W;
				}
			}

			public WhereParameter AppControlingStation
		    {
				get
		        {
					if(_AppControlingStation_W == null)
	        	    {
						_AppControlingStation_W = TearOff.AppControlingStation;
					}
					return _AppControlingStation_W;
				}
			}

			public WhereParameter AppLocationCode
		    {
				get
		        {
					if(_AppLocationCode_W == null)
	        	    {
						_AppLocationCode_W = TearOff.AppLocationCode;
					}
					return _AppLocationCode_W;
				}
			}

			public WhereParameter AppArea
		    {
				get
		        {
					if(_AppArea_W == null)
	        	    {
						_AppArea_W = TearOff.AppArea;
					}
					return _AppArea_W;
				}
			}

			public WhereParameter AppZone
		    {
				get
		        {
					if(_AppZone_W == null)
	        	    {
						_AppZone_W = TearOff.AppZone;
					}
					return _AppZone_W;
				}
			}

			public WhereParameter AppRegion
		    {
				get
		        {
					if(_AppRegion_W == null)
	        	    {
						_AppRegion_W = TearOff.AppRegion;
					}
					return _AppRegion_W;
				}
			}

			public WhereParameter AppEXP
		    {
				get
		        {
					if(_AppEXP_W == null)
	        	    {
						_AppEXP_W = TearOff.AppEXP;
					}
					return _AppEXP_W;
				}
			}

			public WhereParameter AppTopay
		    {
				get
		        {
					if(_AppTopay_W == null)
	        	    {
						_AppTopay_W = TearOff.AppTopay;
					}
					return _AppTopay_W;
				}
			}

			public WhereParameter AppCOD
		    {
				get
		        {
					if(_AppCOD_W == null)
	        	    {
						_AppCOD_W = TearOff.AppCOD;
					}
					return _AppCOD_W;
				}
			}

			private WhereParameter _AppPinCodeID_W = null;
			private WhereParameter _AppPinCode_W = null;
			private WhereParameter _AppIsActive_W = null;
			private WhereParameter _AppCityID_W = null;
			private WhereParameter _AppControlingStation_W = null;
			private WhereParameter _AppLocationCode_W = null;
			private WhereParameter _AppArea_W = null;
			private WhereParameter _AppZone_W = null;
			private WhereParameter _AppRegion_W = null;
			private WhereParameter _AppEXP_W = null;
			private WhereParameter _AppTopay_W = null;
			private WhereParameter _AppCOD_W = null;

			public void WhereClauseReset()
			{
				_AppPinCodeID_W = null;
				_AppPinCode_W = null;
				_AppIsActive_W = null;
				_AppCityID_W = null;
				_AppControlingStation_W = null;
				_AppLocationCode_W = null;
				_AppArea_W = null;
				_AppZone_W = null;
				_AppRegion_W = null;
				_AppEXP_W = null;
				_AppTopay_W = null;
				_AppCOD_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter AppPinCodeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppPinCodeID, Parameters.AppPinCodeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppPinCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppPinCode, Parameters.AppPinCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsActive, Parameters.AppIsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCityID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCityID, Parameters.AppCityID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppControlingStation
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppControlingStation, Parameters.AppControlingStation);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppLocationCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppLocationCode, Parameters.AppLocationCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppArea
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppArea, Parameters.AppArea);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppZone
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppZone, Parameters.AppZone);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppRegion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppRegion, Parameters.AppRegion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppEXP
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppEXP, Parameters.AppEXP);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppTopay
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppTopay, Parameters.AppTopay);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCOD
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCOD, Parameters.AppCOD);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppPinCodeID
		    {
				get
		        {
					if(_AppPinCodeID_W == null)
	        	    {
						_AppPinCodeID_W = TearOff.AppPinCodeID;
					}
					return _AppPinCodeID_W;
				}
			}

			public AggregateParameter AppPinCode
		    {
				get
		        {
					if(_AppPinCode_W == null)
	        	    {
						_AppPinCode_W = TearOff.AppPinCode;
					}
					return _AppPinCode_W;
				}
			}

			public AggregateParameter AppIsActive
		    {
				get
		        {
					if(_AppIsActive_W == null)
	        	    {
						_AppIsActive_W = TearOff.AppIsActive;
					}
					return _AppIsActive_W;
				}
			}

			public AggregateParameter AppCityID
		    {
				get
		        {
					if(_AppCityID_W == null)
	        	    {
						_AppCityID_W = TearOff.AppCityID;
					}
					return _AppCityID_W;
				}
			}

			public AggregateParameter AppControlingStation
		    {
				get
		        {
					if(_AppControlingStation_W == null)
	        	    {
						_AppControlingStation_W = TearOff.AppControlingStation;
					}
					return _AppControlingStation_W;
				}
			}

			public AggregateParameter AppLocationCode
		    {
				get
		        {
					if(_AppLocationCode_W == null)
	        	    {
						_AppLocationCode_W = TearOff.AppLocationCode;
					}
					return _AppLocationCode_W;
				}
			}

			public AggregateParameter AppArea
		    {
				get
		        {
					if(_AppArea_W == null)
	        	    {
						_AppArea_W = TearOff.AppArea;
					}
					return _AppArea_W;
				}
			}

			public AggregateParameter AppZone
		    {
				get
		        {
					if(_AppZone_W == null)
	        	    {
						_AppZone_W = TearOff.AppZone;
					}
					return _AppZone_W;
				}
			}

			public AggregateParameter AppRegion
		    {
				get
		        {
					if(_AppRegion_W == null)
	        	    {
						_AppRegion_W = TearOff.AppRegion;
					}
					return _AppRegion_W;
				}
			}

			public AggregateParameter AppEXP
		    {
				get
		        {
					if(_AppEXP_W == null)
	        	    {
						_AppEXP_W = TearOff.AppEXP;
					}
					return _AppEXP_W;
				}
			}

			public AggregateParameter AppTopay
		    {
				get
		        {
					if(_AppTopay_W == null)
	        	    {
						_AppTopay_W = TearOff.AppTopay;
					}
					return _AppTopay_W;
				}
			}

			public AggregateParameter AppCOD
		    {
				get
		        {
					if(_AppCOD_W == null)
	        	    {
						_AppCOD_W = TearOff.AppCOD;
					}
					return _AppCOD_W;
				}
			}

			private AggregateParameter _AppPinCodeID_W = null;
			private AggregateParameter _AppPinCode_W = null;
			private AggregateParameter _AppIsActive_W = null;
			private AggregateParameter _AppCityID_W = null;
			private AggregateParameter _AppControlingStation_W = null;
			private AggregateParameter _AppLocationCode_W = null;
			private AggregateParameter _AppArea_W = null;
			private AggregateParameter _AppZone_W = null;
			private AggregateParameter _AppRegion_W = null;
			private AggregateParameter _AppEXP_W = null;
			private AggregateParameter _AppTopay_W = null;
			private AggregateParameter _AppCOD_W = null;

			public void AggregateClauseReset()
			{
				_AppPinCodeID_W = null;
				_AppPinCode_W = null;
				_AppIsActive_W = null;
				_AppCityID_W = null;
				_AppControlingStation_W = null;
				_AppLocationCode_W = null;
				_AppArea_W = null;
				_AppZone_W = null;
				_AppRegion_W = null;
				_AppEXP_W = null;
				_AppTopay_W = null;
				_AppCOD_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPinCodeInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppPinCodeID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPinCodeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPinCodeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppPinCodeID);
			p.SourceColumn = ColumnNames.AppPinCodeID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppPinCodeID);
			p.SourceColumn = ColumnNames.AppPinCodeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppPinCode);
			p.SourceColumn = ColumnNames.AppPinCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsActive);
			p.SourceColumn = ColumnNames.AppIsActive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCityID);
			p.SourceColumn = ColumnNames.AppCityID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppControlingStation);
			p.SourceColumn = ColumnNames.AppControlingStation;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppLocationCode);
			p.SourceColumn = ColumnNames.AppLocationCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppArea);
			p.SourceColumn = ColumnNames.AppArea;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppZone);
			p.SourceColumn = ColumnNames.AppZone;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppRegion);
			p.SourceColumn = ColumnNames.AppRegion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppEXP);
			p.SourceColumn = ColumnNames.AppEXP;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppTopay);
			p.SourceColumn = ColumnNames.AppTopay;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCOD);
			p.SourceColumn = ColumnNames.AppCOD;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
