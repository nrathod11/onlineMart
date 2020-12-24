
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
	public abstract class _tblExclusive : SqlClientEntity
	{
		public _tblExclusive()
		{
			this.QuerySource = "tblExclusive";
			this.MappingName = "tblExclusive";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblExclusiveLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppExclusiveID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppExclusiveID, AppExclusiveID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblExclusiveLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppExclusiveID
			{
				get
				{
					return new SqlParameter("@AppExclusiveID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppCategoryID
			{
				get
				{
					return new SqlParameter("@AppCategoryID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppTitle
			{
				get
				{
					return new SqlParameter("@AppTitle", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter AppImage
			{
				get
				{
					return new SqlParameter("@AppImage", SqlDbType.VarChar, 250);
				}
			}
			
			public static SqlParameter AppLink
			{
				get
				{
					return new SqlParameter("@AppLink", SqlDbType.VarChar, 1000);
				}
			}
			
			public static SqlParameter AppIsActive
			{
				get
				{
					return new SqlParameter("@AppIsActive", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter AppDisplayOrder
			{
				get
				{
					return new SqlParameter("@AppDisplayOrder", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppExclusiveID = "appExclusiveID";
            public const string AppCategoryID = "appCategoryID";
            public const string AppTitle = "appTitle";
            public const string AppImage = "appImage";
            public const string AppLink = "appLink";
            public const string AppIsActive = "appIsActive";
            public const string AppDisplayOrder = "appDisplayOrder";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppExclusiveID] = _tblExclusive.PropertyNames.AppExclusiveID;
					ht[AppCategoryID] = _tblExclusive.PropertyNames.AppCategoryID;
					ht[AppTitle] = _tblExclusive.PropertyNames.AppTitle;
					ht[AppImage] = _tblExclusive.PropertyNames.AppImage;
					ht[AppLink] = _tblExclusive.PropertyNames.AppLink;
					ht[AppIsActive] = _tblExclusive.PropertyNames.AppIsActive;
					ht[AppDisplayOrder] = _tblExclusive.PropertyNames.AppDisplayOrder;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppExclusiveID = "AppExclusiveID";
            public const string AppCategoryID = "AppCategoryID";
            public const string AppTitle = "AppTitle";
            public const string AppImage = "AppImage";
            public const string AppLink = "AppLink";
            public const string AppIsActive = "AppIsActive";
            public const string AppDisplayOrder = "AppDisplayOrder";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppExclusiveID] = _tblExclusive.ColumnNames.AppExclusiveID;
					ht[AppCategoryID] = _tblExclusive.ColumnNames.AppCategoryID;
					ht[AppTitle] = _tblExclusive.ColumnNames.AppTitle;
					ht[AppImage] = _tblExclusive.ColumnNames.AppImage;
					ht[AppLink] = _tblExclusive.ColumnNames.AppLink;
					ht[AppIsActive] = _tblExclusive.ColumnNames.AppIsActive;
					ht[AppDisplayOrder] = _tblExclusive.ColumnNames.AppDisplayOrder;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppExclusiveID = "s_AppExclusiveID";
            public const string AppCategoryID = "s_AppCategoryID";
            public const string AppTitle = "s_AppTitle";
            public const string AppImage = "s_AppImage";
            public const string AppLink = "s_AppLink";
            public const string AppIsActive = "s_AppIsActive";
            public const string AppDisplayOrder = "s_AppDisplayOrder";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppExclusiveID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppExclusiveID);
			}
			set
	        {
				base.Setint(ColumnNames.AppExclusiveID, value);
			}
		}

		public virtual int AppCategoryID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppCategoryID);
			}
			set
	        {
				base.Setint(ColumnNames.AppCategoryID, value);
			}
		}

		public virtual string AppTitle
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppTitle);
			}
			set
	        {
				base.Setstring(ColumnNames.AppTitle, value);
			}
		}

		public virtual string AppImage
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppImage);
			}
			set
	        {
				base.Setstring(ColumnNames.AppImage, value);
			}
		}

		public virtual string AppLink
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppLink);
			}
			set
	        {
				base.Setstring(ColumnNames.AppLink, value);
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

		public virtual int AppDisplayOrder
	    {
			get
	        {
				return base.Getint(ColumnNames.AppDisplayOrder);
			}
			set
	        {
				base.Setint(ColumnNames.AppDisplayOrder, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppExclusiveID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppExclusiveID) ? string.Empty : base.GetintAsString(ColumnNames.AppExclusiveID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppExclusiveID);
				else
					this.AppExclusiveID = base.SetintAsString(ColumnNames.AppExclusiveID, value);
			}
		}

		public virtual string s_AppCategoryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCategoryID) ? string.Empty : base.GetintAsString(ColumnNames.AppCategoryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCategoryID);
				else
					this.AppCategoryID = base.SetintAsString(ColumnNames.AppCategoryID, value);
			}
		}

		public virtual string s_AppTitle
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppTitle) ? string.Empty : base.GetstringAsString(ColumnNames.AppTitle);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppTitle);
				else
					this.AppTitle = base.SetstringAsString(ColumnNames.AppTitle, value);
			}
		}

		public virtual string s_AppImage
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppImage) ? string.Empty : base.GetstringAsString(ColumnNames.AppImage);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppImage);
				else
					this.AppImage = base.SetstringAsString(ColumnNames.AppImage, value);
			}
		}

		public virtual string s_AppLink
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppLink) ? string.Empty : base.GetstringAsString(ColumnNames.AppLink);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppLink);
				else
					this.AppLink = base.SetstringAsString(ColumnNames.AppLink, value);
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

		public virtual string s_AppDisplayOrder
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppDisplayOrder) ? string.Empty : base.GetintAsString(ColumnNames.AppDisplayOrder);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppDisplayOrder);
				else
					this.AppDisplayOrder = base.SetintAsString(ColumnNames.AppDisplayOrder, value);
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
				
				
				public WhereParameter AppExclusiveID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppExclusiveID, Parameters.AppExclusiveID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCategoryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCategoryID, Parameters.AppCategoryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppTitle
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppTitle, Parameters.AppTitle);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppImage
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppImage, Parameters.AppImage);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppLink
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppLink, Parameters.AppLink);
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

				public WhereParameter AppDisplayOrder
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppDisplayOrder, Parameters.AppDisplayOrder);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppExclusiveID
		    {
				get
		        {
					if(_AppExclusiveID_W == null)
	        	    {
						_AppExclusiveID_W = TearOff.AppExclusiveID;
					}
					return _AppExclusiveID_W;
				}
			}

			public WhereParameter AppCategoryID
		    {
				get
		        {
					if(_AppCategoryID_W == null)
	        	    {
						_AppCategoryID_W = TearOff.AppCategoryID;
					}
					return _AppCategoryID_W;
				}
			}

			public WhereParameter AppTitle
		    {
				get
		        {
					if(_AppTitle_W == null)
	        	    {
						_AppTitle_W = TearOff.AppTitle;
					}
					return _AppTitle_W;
				}
			}

			public WhereParameter AppImage
		    {
				get
		        {
					if(_AppImage_W == null)
	        	    {
						_AppImage_W = TearOff.AppImage;
					}
					return _AppImage_W;
				}
			}

			public WhereParameter AppLink
		    {
				get
		        {
					if(_AppLink_W == null)
	        	    {
						_AppLink_W = TearOff.AppLink;
					}
					return _AppLink_W;
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

			public WhereParameter AppDisplayOrder
		    {
				get
		        {
					if(_AppDisplayOrder_W == null)
	        	    {
						_AppDisplayOrder_W = TearOff.AppDisplayOrder;
					}
					return _AppDisplayOrder_W;
				}
			}

			private WhereParameter _AppExclusiveID_W = null;
			private WhereParameter _AppCategoryID_W = null;
			private WhereParameter _AppTitle_W = null;
			private WhereParameter _AppImage_W = null;
			private WhereParameter _AppLink_W = null;
			private WhereParameter _AppIsActive_W = null;
			private WhereParameter _AppDisplayOrder_W = null;

			public void WhereClauseReset()
			{
				_AppExclusiveID_W = null;
				_AppCategoryID_W = null;
				_AppTitle_W = null;
				_AppImage_W = null;
				_AppLink_W = null;
				_AppIsActive_W = null;
				_AppDisplayOrder_W = null;

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
				
				
				public AggregateParameter AppExclusiveID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppExclusiveID, Parameters.AppExclusiveID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCategoryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCategoryID, Parameters.AppCategoryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppTitle
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppTitle, Parameters.AppTitle);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppImage
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppImage, Parameters.AppImage);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppLink
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppLink, Parameters.AppLink);
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

				public AggregateParameter AppDisplayOrder
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppDisplayOrder, Parameters.AppDisplayOrder);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppExclusiveID
		    {
				get
		        {
					if(_AppExclusiveID_W == null)
	        	    {
						_AppExclusiveID_W = TearOff.AppExclusiveID;
					}
					return _AppExclusiveID_W;
				}
			}

			public AggregateParameter AppCategoryID
		    {
				get
		        {
					if(_AppCategoryID_W == null)
	        	    {
						_AppCategoryID_W = TearOff.AppCategoryID;
					}
					return _AppCategoryID_W;
				}
			}

			public AggregateParameter AppTitle
		    {
				get
		        {
					if(_AppTitle_W == null)
	        	    {
						_AppTitle_W = TearOff.AppTitle;
					}
					return _AppTitle_W;
				}
			}

			public AggregateParameter AppImage
		    {
				get
		        {
					if(_AppImage_W == null)
	        	    {
						_AppImage_W = TearOff.AppImage;
					}
					return _AppImage_W;
				}
			}

			public AggregateParameter AppLink
		    {
				get
		        {
					if(_AppLink_W == null)
	        	    {
						_AppLink_W = TearOff.AppLink;
					}
					return _AppLink_W;
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

			public AggregateParameter AppDisplayOrder
		    {
				get
		        {
					if(_AppDisplayOrder_W == null)
	        	    {
						_AppDisplayOrder_W = TearOff.AppDisplayOrder;
					}
					return _AppDisplayOrder_W;
				}
			}

			private AggregateParameter _AppExclusiveID_W = null;
			private AggregateParameter _AppCategoryID_W = null;
			private AggregateParameter _AppTitle_W = null;
			private AggregateParameter _AppImage_W = null;
			private AggregateParameter _AppLink_W = null;
			private AggregateParameter _AppIsActive_W = null;
			private AggregateParameter _AppDisplayOrder_W = null;

			public void AggregateClauseReset()
			{
				_AppExclusiveID_W = null;
				_AppCategoryID_W = null;
				_AppTitle_W = null;
				_AppImage_W = null;
				_AppLink_W = null;
				_AppIsActive_W = null;
				_AppDisplayOrder_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblExclusiveInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppExclusiveID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblExclusiveUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblExclusiveDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppExclusiveID);
			p.SourceColumn = ColumnNames.AppExclusiveID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppExclusiveID);
			p.SourceColumn = ColumnNames.AppExclusiveID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCategoryID);
			p.SourceColumn = ColumnNames.AppCategoryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppTitle);
			p.SourceColumn = ColumnNames.AppTitle;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppImage);
			p.SourceColumn = ColumnNames.AppImage;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppLink);
			p.SourceColumn = ColumnNames.AppLink;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsActive);
			p.SourceColumn = ColumnNames.AppIsActive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppDisplayOrder);
			p.SourceColumn = ColumnNames.AppDisplayOrder;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}