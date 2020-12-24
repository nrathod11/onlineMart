
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
	public abstract class _tblInquiry : SqlClientEntity
	{
		public _tblInquiry()
		{
			this.QuerySource = "tblInquiry";
			this.MappingName = "tblInquiry";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblInquiryLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppInquiryID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppInquiryID, AppInquiryID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblInquiryLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppInquiryID
			{
				get
				{
					return new SqlParameter("@AppInquiryID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppName
			{
				get
				{
					return new SqlParameter("@AppName", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter AppEmail
			{
				get
				{
					return new SqlParameter("@AppEmail", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter AppMobile
			{
				get
				{
					return new SqlParameter("@AppMobile", SqlDbType.VarChar, 20);
				}
			}
			
			public static SqlParameter AppMessage
			{
				get
				{
					return new SqlParameter("@AppMessage", SqlDbType.VarChar, 2147483647);
				}
			}
			
			public static SqlParameter AppProductDetailID
			{
				get
				{
					return new SqlParameter("@AppProductDetailID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppInquiryID = "appInquiryID";
            public const string AppName = "appName";
            public const string AppEmail = "appEmail";
            public const string AppMobile = "appMobile";
            public const string AppMessage = "appMessage";
            public const string AppProductDetailID = "appProductDetailID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppInquiryID] = _tblInquiry.PropertyNames.AppInquiryID;
					ht[AppName] = _tblInquiry.PropertyNames.AppName;
					ht[AppEmail] = _tblInquiry.PropertyNames.AppEmail;
					ht[AppMobile] = _tblInquiry.PropertyNames.AppMobile;
					ht[AppMessage] = _tblInquiry.PropertyNames.AppMessage;
					ht[AppProductDetailID] = _tblInquiry.PropertyNames.AppProductDetailID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppInquiryID = "AppInquiryID";
            public const string AppName = "AppName";
            public const string AppEmail = "AppEmail";
            public const string AppMobile = "AppMobile";
            public const string AppMessage = "AppMessage";
            public const string AppProductDetailID = "AppProductDetailID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppInquiryID] = _tblInquiry.ColumnNames.AppInquiryID;
					ht[AppName] = _tblInquiry.ColumnNames.AppName;
					ht[AppEmail] = _tblInquiry.ColumnNames.AppEmail;
					ht[AppMobile] = _tblInquiry.ColumnNames.AppMobile;
					ht[AppMessage] = _tblInquiry.ColumnNames.AppMessage;
					ht[AppProductDetailID] = _tblInquiry.ColumnNames.AppProductDetailID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppInquiryID = "s_AppInquiryID";
            public const string AppName = "s_AppName";
            public const string AppEmail = "s_AppEmail";
            public const string AppMobile = "s_AppMobile";
            public const string AppMessage = "s_AppMessage";
            public const string AppProductDetailID = "s_AppProductDetailID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppInquiryID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppInquiryID);
			}
			set
	        {
				base.Setint(ColumnNames.AppInquiryID, value);
			}
		}

		public virtual string AppName
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppName);
			}
			set
	        {
				base.Setstring(ColumnNames.AppName, value);
			}
		}

		public virtual string AppEmail
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppEmail);
			}
			set
	        {
				base.Setstring(ColumnNames.AppEmail, value);
			}
		}

		public virtual string AppMobile
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppMobile);
			}
			set
	        {
				base.Setstring(ColumnNames.AppMobile, value);
			}
		}

		public virtual string AppMessage
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppMessage);
			}
			set
	        {
				base.Setstring(ColumnNames.AppMessage, value);
			}
		}

		public virtual int AppProductDetailID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppProductDetailID);
			}
			set
	        {
				base.Setint(ColumnNames.AppProductDetailID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppInquiryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppInquiryID) ? string.Empty : base.GetintAsString(ColumnNames.AppInquiryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppInquiryID);
				else
					this.AppInquiryID = base.SetintAsString(ColumnNames.AppInquiryID, value);
			}
		}

		public virtual string s_AppName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppName) ? string.Empty : base.GetstringAsString(ColumnNames.AppName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppName);
				else
					this.AppName = base.SetstringAsString(ColumnNames.AppName, value);
			}
		}

		public virtual string s_AppEmail
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppEmail) ? string.Empty : base.GetstringAsString(ColumnNames.AppEmail);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppEmail);
				else
					this.AppEmail = base.SetstringAsString(ColumnNames.AppEmail, value);
			}
		}

		public virtual string s_AppMobile
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppMobile) ? string.Empty : base.GetstringAsString(ColumnNames.AppMobile);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppMobile);
				else
					this.AppMobile = base.SetstringAsString(ColumnNames.AppMobile, value);
			}
		}

		public virtual string s_AppMessage
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppMessage) ? string.Empty : base.GetstringAsString(ColumnNames.AppMessage);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppMessage);
				else
					this.AppMessage = base.SetstringAsString(ColumnNames.AppMessage, value);
			}
		}

		public virtual string s_AppProductDetailID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppProductDetailID) ? string.Empty : base.GetintAsString(ColumnNames.AppProductDetailID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppProductDetailID);
				else
					this.AppProductDetailID = base.SetintAsString(ColumnNames.AppProductDetailID, value);
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
				
				
				public WhereParameter AppInquiryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppInquiryID, Parameters.AppInquiryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppName, Parameters.AppName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppEmail
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppEmail, Parameters.AppEmail);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppMobile
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppMobile, Parameters.AppMobile);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppMessage
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppMessage, Parameters.AppMessage);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppProductDetailID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppProductDetailID, Parameters.AppProductDetailID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppInquiryID
		    {
				get
		        {
					if(_AppInquiryID_W == null)
	        	    {
						_AppInquiryID_W = TearOff.AppInquiryID;
					}
					return _AppInquiryID_W;
				}
			}

			public WhereParameter AppName
		    {
				get
		        {
					if(_AppName_W == null)
	        	    {
						_AppName_W = TearOff.AppName;
					}
					return _AppName_W;
				}
			}

			public WhereParameter AppEmail
		    {
				get
		        {
					if(_AppEmail_W == null)
	        	    {
						_AppEmail_W = TearOff.AppEmail;
					}
					return _AppEmail_W;
				}
			}

			public WhereParameter AppMobile
		    {
				get
		        {
					if(_AppMobile_W == null)
	        	    {
						_AppMobile_W = TearOff.AppMobile;
					}
					return _AppMobile_W;
				}
			}

			public WhereParameter AppMessage
		    {
				get
		        {
					if(_AppMessage_W == null)
	        	    {
						_AppMessage_W = TearOff.AppMessage;
					}
					return _AppMessage_W;
				}
			}

			public WhereParameter AppProductDetailID
		    {
				get
		        {
					if(_AppProductDetailID_W == null)
	        	    {
						_AppProductDetailID_W = TearOff.AppProductDetailID;
					}
					return _AppProductDetailID_W;
				}
			}

			private WhereParameter _AppInquiryID_W = null;
			private WhereParameter _AppName_W = null;
			private WhereParameter _AppEmail_W = null;
			private WhereParameter _AppMobile_W = null;
			private WhereParameter _AppMessage_W = null;
			private WhereParameter _AppProductDetailID_W = null;

			public void WhereClauseReset()
			{
				_AppInquiryID_W = null;
				_AppName_W = null;
				_AppEmail_W = null;
				_AppMobile_W = null;
				_AppMessage_W = null;
				_AppProductDetailID_W = null;

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
				
				
				public AggregateParameter AppInquiryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppInquiryID, Parameters.AppInquiryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppName, Parameters.AppName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppEmail
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppEmail, Parameters.AppEmail);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppMobile
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppMobile, Parameters.AppMobile);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppMessage
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppMessage, Parameters.AppMessage);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppProductDetailID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppProductDetailID, Parameters.AppProductDetailID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppInquiryID
		    {
				get
		        {
					if(_AppInquiryID_W == null)
	        	    {
						_AppInquiryID_W = TearOff.AppInquiryID;
					}
					return _AppInquiryID_W;
				}
			}

			public AggregateParameter AppName
		    {
				get
		        {
					if(_AppName_W == null)
	        	    {
						_AppName_W = TearOff.AppName;
					}
					return _AppName_W;
				}
			}

			public AggregateParameter AppEmail
		    {
				get
		        {
					if(_AppEmail_W == null)
	        	    {
						_AppEmail_W = TearOff.AppEmail;
					}
					return _AppEmail_W;
				}
			}

			public AggregateParameter AppMobile
		    {
				get
		        {
					if(_AppMobile_W == null)
	        	    {
						_AppMobile_W = TearOff.AppMobile;
					}
					return _AppMobile_W;
				}
			}

			public AggregateParameter AppMessage
		    {
				get
		        {
					if(_AppMessage_W == null)
	        	    {
						_AppMessage_W = TearOff.AppMessage;
					}
					return _AppMessage_W;
				}
			}

			public AggregateParameter AppProductDetailID
		    {
				get
		        {
					if(_AppProductDetailID_W == null)
	        	    {
						_AppProductDetailID_W = TearOff.AppProductDetailID;
					}
					return _AppProductDetailID_W;
				}
			}

			private AggregateParameter _AppInquiryID_W = null;
			private AggregateParameter _AppName_W = null;
			private AggregateParameter _AppEmail_W = null;
			private AggregateParameter _AppMobile_W = null;
			private AggregateParameter _AppMessage_W = null;
			private AggregateParameter _AppProductDetailID_W = null;

			public void AggregateClauseReset()
			{
				_AppInquiryID_W = null;
				_AppName_W = null;
				_AppEmail_W = null;
				_AppMobile_W = null;
				_AppMessage_W = null;
				_AppProductDetailID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblInquiryInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppInquiryID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblInquiryUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblInquiryDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppInquiryID);
			p.SourceColumn = ColumnNames.AppInquiryID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppInquiryID);
			p.SourceColumn = ColumnNames.AppInquiryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppName);
			p.SourceColumn = ColumnNames.AppName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppEmail);
			p.SourceColumn = ColumnNames.AppEmail;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppMobile);
			p.SourceColumn = ColumnNames.AppMobile;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppMessage);
			p.SourceColumn = ColumnNames.AppMessage;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppProductDetailID);
			p.SourceColumn = ColumnNames.AppProductDetailID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
