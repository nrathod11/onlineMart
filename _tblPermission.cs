
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
	public abstract class _tblPermission : SqlClientEntity
	{
		public _tblPermission()
		{
			this.QuerySource = "tblPermission";
			this.MappingName = "tblPermission";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblPermissionLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppPermissionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppPermissionID, AppPermissionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblPermissionLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppPermissionID
			{
				get
				{
					return new SqlParameter("@AppPermissionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppTabID
			{
				get
				{
					return new SqlParameter("@AppTabID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppRoleID
			{
				get
				{
					return new SqlParameter("@AppRoleID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppIsAdd
			{
				get
				{
					return new SqlParameter("@AppIsAdd", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppIsEdit
			{
				get
				{
					return new SqlParameter("@AppIsEdit", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppIsView
			{
				get
				{
					return new SqlParameter("@AppIsView", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppIsDelete
			{
				get
				{
					return new SqlParameter("@AppIsDelete", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppCreatedDate
			{
				get
				{
					return new SqlParameter("@AppCreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter AppCreatedBy
			{
				get
				{
					return new SqlParameter("@AppCreatedBy", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppPermissionID = "appPermissionID";
            public const string AppTabID = "appTabID";
            public const string AppRoleID = "appRoleID";
            public const string AppIsAdd = "appIsAdd";
            public const string AppIsEdit = "appIsEdit";
            public const string AppIsView = "appIsView";
            public const string AppIsDelete = "appIsDelete";
            public const string AppCreatedDate = "appCreatedDate";
            public const string AppCreatedBy = "appCreatedBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppPermissionID] = _tblPermission.PropertyNames.AppPermissionID;
					ht[AppTabID] = _tblPermission.PropertyNames.AppTabID;
					ht[AppRoleID] = _tblPermission.PropertyNames.AppRoleID;
					ht[AppIsAdd] = _tblPermission.PropertyNames.AppIsAdd;
					ht[AppIsEdit] = _tblPermission.PropertyNames.AppIsEdit;
					ht[AppIsView] = _tblPermission.PropertyNames.AppIsView;
					ht[AppIsDelete] = _tblPermission.PropertyNames.AppIsDelete;
					ht[AppCreatedDate] = _tblPermission.PropertyNames.AppCreatedDate;
					ht[AppCreatedBy] = _tblPermission.PropertyNames.AppCreatedBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppPermissionID = "AppPermissionID";
            public const string AppTabID = "AppTabID";
            public const string AppRoleID = "AppRoleID";
            public const string AppIsAdd = "AppIsAdd";
            public const string AppIsEdit = "AppIsEdit";
            public const string AppIsView = "AppIsView";
            public const string AppIsDelete = "AppIsDelete";
            public const string AppCreatedDate = "AppCreatedDate";
            public const string AppCreatedBy = "AppCreatedBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppPermissionID] = _tblPermission.ColumnNames.AppPermissionID;
					ht[AppTabID] = _tblPermission.ColumnNames.AppTabID;
					ht[AppRoleID] = _tblPermission.ColumnNames.AppRoleID;
					ht[AppIsAdd] = _tblPermission.ColumnNames.AppIsAdd;
					ht[AppIsEdit] = _tblPermission.ColumnNames.AppIsEdit;
					ht[AppIsView] = _tblPermission.ColumnNames.AppIsView;
					ht[AppIsDelete] = _tblPermission.ColumnNames.AppIsDelete;
					ht[AppCreatedDate] = _tblPermission.ColumnNames.AppCreatedDate;
					ht[AppCreatedBy] = _tblPermission.ColumnNames.AppCreatedBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppPermissionID = "s_AppPermissionID";
            public const string AppTabID = "s_AppTabID";
            public const string AppRoleID = "s_AppRoleID";
            public const string AppIsAdd = "s_AppIsAdd";
            public const string AppIsEdit = "s_AppIsEdit";
            public const string AppIsView = "s_AppIsView";
            public const string AppIsDelete = "s_AppIsDelete";
            public const string AppCreatedDate = "s_AppCreatedDate";
            public const string AppCreatedBy = "s_AppCreatedBy";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppPermissionID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppPermissionID);
			}
			set
	        {
				base.Setint(ColumnNames.AppPermissionID, value);
			}
		}

		public virtual int AppTabID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppTabID);
			}
			set
	        {
				base.Setint(ColumnNames.AppTabID, value);
			}
		}

		public virtual int AppRoleID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppRoleID);
			}
			set
	        {
				base.Setint(ColumnNames.AppRoleID, value);
			}
		}

		public virtual bool AppIsAdd
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsAdd);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsAdd, value);
			}
		}

		public virtual bool AppIsEdit
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsEdit);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsEdit, value);
			}
		}

		public virtual bool AppIsView
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsView);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsView, value);
			}
		}

		public virtual bool AppIsDelete
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsDelete);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsDelete, value);
			}
		}

		public virtual DateTime AppCreatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.AppCreatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.AppCreatedDate, value);
			}
		}

		public virtual int AppCreatedBy
	    {
			get
	        {
				return base.Getint(ColumnNames.AppCreatedBy);
			}
			set
	        {
				base.Setint(ColumnNames.AppCreatedBy, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppPermissionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppPermissionID) ? string.Empty : base.GetintAsString(ColumnNames.AppPermissionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppPermissionID);
				else
					this.AppPermissionID = base.SetintAsString(ColumnNames.AppPermissionID, value);
			}
		}

		public virtual string s_AppTabID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppTabID) ? string.Empty : base.GetintAsString(ColumnNames.AppTabID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppTabID);
				else
					this.AppTabID = base.SetintAsString(ColumnNames.AppTabID, value);
			}
		}

		public virtual string s_AppRoleID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppRoleID) ? string.Empty : base.GetintAsString(ColumnNames.AppRoleID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppRoleID);
				else
					this.AppRoleID = base.SetintAsString(ColumnNames.AppRoleID, value);
			}
		}

		public virtual string s_AppIsAdd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsAdd) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsAdd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsAdd);
				else
					this.AppIsAdd = base.SetboolAsString(ColumnNames.AppIsAdd, value);
			}
		}

		public virtual string s_AppIsEdit
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsEdit) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsEdit);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsEdit);
				else
					this.AppIsEdit = base.SetboolAsString(ColumnNames.AppIsEdit, value);
			}
		}

		public virtual string s_AppIsView
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsView) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsView);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsView);
				else
					this.AppIsView = base.SetboolAsString(ColumnNames.AppIsView, value);
			}
		}

		public virtual string s_AppIsDelete
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsDelete) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsDelete);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsDelete);
				else
					this.AppIsDelete = base.SetboolAsString(ColumnNames.AppIsDelete, value);
			}
		}

		public virtual string s_AppCreatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCreatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.AppCreatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCreatedDate);
				else
					this.AppCreatedDate = base.SetDateTimeAsString(ColumnNames.AppCreatedDate, value);
			}
		}

		public virtual string s_AppCreatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCreatedBy) ? string.Empty : base.GetintAsString(ColumnNames.AppCreatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCreatedBy);
				else
					this.AppCreatedBy = base.SetintAsString(ColumnNames.AppCreatedBy, value);
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
				
				
				public WhereParameter AppPermissionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppPermissionID, Parameters.AppPermissionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppTabID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppTabID, Parameters.AppTabID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppRoleID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppRoleID, Parameters.AppRoleID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsAdd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsAdd, Parameters.AppIsAdd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsEdit
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsEdit, Parameters.AppIsEdit);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsView
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsView, Parameters.AppIsView);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsDelete
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsDelete, Parameters.AppIsDelete);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCreatedDate, Parameters.AppCreatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCreatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCreatedBy, Parameters.AppCreatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppPermissionID
		    {
				get
		        {
					if(_AppPermissionID_W == null)
	        	    {
						_AppPermissionID_W = TearOff.AppPermissionID;
					}
					return _AppPermissionID_W;
				}
			}

			public WhereParameter AppTabID
		    {
				get
		        {
					if(_AppTabID_W == null)
	        	    {
						_AppTabID_W = TearOff.AppTabID;
					}
					return _AppTabID_W;
				}
			}

			public WhereParameter AppRoleID
		    {
				get
		        {
					if(_AppRoleID_W == null)
	        	    {
						_AppRoleID_W = TearOff.AppRoleID;
					}
					return _AppRoleID_W;
				}
			}

			public WhereParameter AppIsAdd
		    {
				get
		        {
					if(_AppIsAdd_W == null)
	        	    {
						_AppIsAdd_W = TearOff.AppIsAdd;
					}
					return _AppIsAdd_W;
				}
			}

			public WhereParameter AppIsEdit
		    {
				get
		        {
					if(_AppIsEdit_W == null)
	        	    {
						_AppIsEdit_W = TearOff.AppIsEdit;
					}
					return _AppIsEdit_W;
				}
			}

			public WhereParameter AppIsView
		    {
				get
		        {
					if(_AppIsView_W == null)
	        	    {
						_AppIsView_W = TearOff.AppIsView;
					}
					return _AppIsView_W;
				}
			}

			public WhereParameter AppIsDelete
		    {
				get
		        {
					if(_AppIsDelete_W == null)
	        	    {
						_AppIsDelete_W = TearOff.AppIsDelete;
					}
					return _AppIsDelete_W;
				}
			}

			public WhereParameter AppCreatedDate
		    {
				get
		        {
					if(_AppCreatedDate_W == null)
	        	    {
						_AppCreatedDate_W = TearOff.AppCreatedDate;
					}
					return _AppCreatedDate_W;
				}
			}

			public WhereParameter AppCreatedBy
		    {
				get
		        {
					if(_AppCreatedBy_W == null)
	        	    {
						_AppCreatedBy_W = TearOff.AppCreatedBy;
					}
					return _AppCreatedBy_W;
				}
			}

			private WhereParameter _AppPermissionID_W = null;
			private WhereParameter _AppTabID_W = null;
			private WhereParameter _AppRoleID_W = null;
			private WhereParameter _AppIsAdd_W = null;
			private WhereParameter _AppIsEdit_W = null;
			private WhereParameter _AppIsView_W = null;
			private WhereParameter _AppIsDelete_W = null;
			private WhereParameter _AppCreatedDate_W = null;
			private WhereParameter _AppCreatedBy_W = null;

			public void WhereClauseReset()
			{
				_AppPermissionID_W = null;
				_AppTabID_W = null;
				_AppRoleID_W = null;
				_AppIsAdd_W = null;
				_AppIsEdit_W = null;
				_AppIsView_W = null;
				_AppIsDelete_W = null;
				_AppCreatedDate_W = null;
				_AppCreatedBy_W = null;

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
				
				
				public AggregateParameter AppPermissionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppPermissionID, Parameters.AppPermissionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppTabID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppTabID, Parameters.AppTabID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppRoleID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppRoleID, Parameters.AppRoleID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsAdd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsAdd, Parameters.AppIsAdd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsEdit
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsEdit, Parameters.AppIsEdit);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsView
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsView, Parameters.AppIsView);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsDelete
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsDelete, Parameters.AppIsDelete);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCreatedDate, Parameters.AppCreatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCreatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCreatedBy, Parameters.AppCreatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppPermissionID
		    {
				get
		        {
					if(_AppPermissionID_W == null)
	        	    {
						_AppPermissionID_W = TearOff.AppPermissionID;
					}
					return _AppPermissionID_W;
				}
			}

			public AggregateParameter AppTabID
		    {
				get
		        {
					if(_AppTabID_W == null)
	        	    {
						_AppTabID_W = TearOff.AppTabID;
					}
					return _AppTabID_W;
				}
			}

			public AggregateParameter AppRoleID
		    {
				get
		        {
					if(_AppRoleID_W == null)
	        	    {
						_AppRoleID_W = TearOff.AppRoleID;
					}
					return _AppRoleID_W;
				}
			}

			public AggregateParameter AppIsAdd
		    {
				get
		        {
					if(_AppIsAdd_W == null)
	        	    {
						_AppIsAdd_W = TearOff.AppIsAdd;
					}
					return _AppIsAdd_W;
				}
			}

			public AggregateParameter AppIsEdit
		    {
				get
		        {
					if(_AppIsEdit_W == null)
	        	    {
						_AppIsEdit_W = TearOff.AppIsEdit;
					}
					return _AppIsEdit_W;
				}
			}

			public AggregateParameter AppIsView
		    {
				get
		        {
					if(_AppIsView_W == null)
	        	    {
						_AppIsView_W = TearOff.AppIsView;
					}
					return _AppIsView_W;
				}
			}

			public AggregateParameter AppIsDelete
		    {
				get
		        {
					if(_AppIsDelete_W == null)
	        	    {
						_AppIsDelete_W = TearOff.AppIsDelete;
					}
					return _AppIsDelete_W;
				}
			}

			public AggregateParameter AppCreatedDate
		    {
				get
		        {
					if(_AppCreatedDate_W == null)
	        	    {
						_AppCreatedDate_W = TearOff.AppCreatedDate;
					}
					return _AppCreatedDate_W;
				}
			}

			public AggregateParameter AppCreatedBy
		    {
				get
		        {
					if(_AppCreatedBy_W == null)
	        	    {
						_AppCreatedBy_W = TearOff.AppCreatedBy;
					}
					return _AppCreatedBy_W;
				}
			}

			private AggregateParameter _AppPermissionID_W = null;
			private AggregateParameter _AppTabID_W = null;
			private AggregateParameter _AppRoleID_W = null;
			private AggregateParameter _AppIsAdd_W = null;
			private AggregateParameter _AppIsEdit_W = null;
			private AggregateParameter _AppIsView_W = null;
			private AggregateParameter _AppIsDelete_W = null;
			private AggregateParameter _AppCreatedDate_W = null;
			private AggregateParameter _AppCreatedBy_W = null;

			public void AggregateClauseReset()
			{
				_AppPermissionID_W = null;
				_AppTabID_W = null;
				_AppRoleID_W = null;
				_AppIsAdd_W = null;
				_AppIsEdit_W = null;
				_AppIsView_W = null;
				_AppIsDelete_W = null;
				_AppCreatedDate_W = null;
				_AppCreatedBy_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPermissionInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppPermissionID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPermissionUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblPermissionDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppPermissionID);
			p.SourceColumn = ColumnNames.AppPermissionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppPermissionID);
			p.SourceColumn = ColumnNames.AppPermissionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppTabID);
			p.SourceColumn = ColumnNames.AppTabID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppRoleID);
			p.SourceColumn = ColumnNames.AppRoleID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsAdd);
			p.SourceColumn = ColumnNames.AppIsAdd;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsEdit);
			p.SourceColumn = ColumnNames.AppIsEdit;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsView);
			p.SourceColumn = ColumnNames.AppIsView;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsDelete);
			p.SourceColumn = ColumnNames.AppIsDelete;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCreatedDate);
			p.SourceColumn = ColumnNames.AppCreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCreatedBy);
			p.SourceColumn = ColumnNames.AppCreatedBy;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
