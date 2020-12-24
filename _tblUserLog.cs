
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
	public abstract class _tblUserLog : SqlClientEntity
	{
		public _tblUserLog()
		{
			this.QuerySource = "tblUserLog";
			this.MappingName = "tblUserLog";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblUserLogLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppUserLogID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppUserLogID, AppUserLogID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblUserLogLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppUserLogID
			{
				get
				{
					return new SqlParameter("@AppUserLogID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppUserID
			{
				get
				{
					return new SqlParameter("@AppUserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppLogInDate
			{
				get
				{
					return new SqlParameter("@AppLogInDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter AppLogOutDate
			{
				get
				{
					return new SqlParameter("@AppLogOutDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter AppIPAddress
			{
				get
				{
					return new SqlParameter("@AppIPAddress", SqlDbType.VarChar, 30);
				}
			}
			
			public static SqlParameter AppIsSuccess
			{
				get
				{
					return new SqlParameter("@AppIsSuccess", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppUserLogID = "appUserLogID";
            public const string AppUserID = "appUserID";
            public const string AppLogInDate = "appLogInDate";
            public const string AppLogOutDate = "appLogOutDate";
            public const string AppIPAddress = "appIPAddress";
            public const string AppIsSuccess = "appIsSuccess";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppUserLogID] = _tblUserLog.PropertyNames.AppUserLogID;
					ht[AppUserID] = _tblUserLog.PropertyNames.AppUserID;
					ht[AppLogInDate] = _tblUserLog.PropertyNames.AppLogInDate;
					ht[AppLogOutDate] = _tblUserLog.PropertyNames.AppLogOutDate;
					ht[AppIPAddress] = _tblUserLog.PropertyNames.AppIPAddress;
					ht[AppIsSuccess] = _tblUserLog.PropertyNames.AppIsSuccess;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppUserLogID = "AppUserLogID";
            public const string AppUserID = "AppUserID";
            public const string AppLogInDate = "AppLogInDate";
            public const string AppLogOutDate = "AppLogOutDate";
            public const string AppIPAddress = "AppIPAddress";
            public const string AppIsSuccess = "AppIsSuccess";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppUserLogID] = _tblUserLog.ColumnNames.AppUserLogID;
					ht[AppUserID] = _tblUserLog.ColumnNames.AppUserID;
					ht[AppLogInDate] = _tblUserLog.ColumnNames.AppLogInDate;
					ht[AppLogOutDate] = _tblUserLog.ColumnNames.AppLogOutDate;
					ht[AppIPAddress] = _tblUserLog.ColumnNames.AppIPAddress;
					ht[AppIsSuccess] = _tblUserLog.ColumnNames.AppIsSuccess;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppUserLogID = "s_AppUserLogID";
            public const string AppUserID = "s_AppUserID";
            public const string AppLogInDate = "s_AppLogInDate";
            public const string AppLogOutDate = "s_AppLogOutDate";
            public const string AppIPAddress = "s_AppIPAddress";
            public const string AppIsSuccess = "s_AppIsSuccess";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppUserLogID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppUserLogID);
			}
			set
	        {
				base.Setint(ColumnNames.AppUserLogID, value);
			}
		}

		public virtual int AppUserID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppUserID);
			}
			set
	        {
				base.Setint(ColumnNames.AppUserID, value);
			}
		}

		public virtual DateTime AppLogInDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.AppLogInDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.AppLogInDate, value);
			}
		}

		public virtual DateTime AppLogOutDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.AppLogOutDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.AppLogOutDate, value);
			}
		}

		public virtual string AppIPAddress
	    {
			get
	        {
				return base.Getstring(ColumnNames.AppIPAddress);
			}
			set
	        {
				base.Setstring(ColumnNames.AppIPAddress, value);
			}
		}

		public virtual bool AppIsSuccess
	    {
			get
	        {
				return base.Getbool(ColumnNames.AppIsSuccess);
			}
			set
	        {
				base.Setbool(ColumnNames.AppIsSuccess, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppUserLogID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppUserLogID) ? string.Empty : base.GetintAsString(ColumnNames.AppUserLogID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppUserLogID);
				else
					this.AppUserLogID = base.SetintAsString(ColumnNames.AppUserLogID, value);
			}
		}

		public virtual string s_AppUserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppUserID) ? string.Empty : base.GetintAsString(ColumnNames.AppUserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppUserID);
				else
					this.AppUserID = base.SetintAsString(ColumnNames.AppUserID, value);
			}
		}

		public virtual string s_AppLogInDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppLogInDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.AppLogInDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppLogInDate);
				else
					this.AppLogInDate = base.SetDateTimeAsString(ColumnNames.AppLogInDate, value);
			}
		}

		public virtual string s_AppLogOutDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppLogOutDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.AppLogOutDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppLogOutDate);
				else
					this.AppLogOutDate = base.SetDateTimeAsString(ColumnNames.AppLogOutDate, value);
			}
		}

		public virtual string s_AppIPAddress
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIPAddress) ? string.Empty : base.GetstringAsString(ColumnNames.AppIPAddress);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIPAddress);
				else
					this.AppIPAddress = base.SetstringAsString(ColumnNames.AppIPAddress, value);
			}
		}

		public virtual string s_AppIsSuccess
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppIsSuccess) ? string.Empty : base.GetboolAsString(ColumnNames.AppIsSuccess);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppIsSuccess);
				else
					this.AppIsSuccess = base.SetboolAsString(ColumnNames.AppIsSuccess, value);
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
				
				
				public WhereParameter AppUserLogID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppUserLogID, Parameters.AppUserLogID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppUserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppUserID, Parameters.AppUserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppLogInDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppLogInDate, Parameters.AppLogInDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppLogOutDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppLogOutDate, Parameters.AppLogOutDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIPAddress
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIPAddress, Parameters.AppIPAddress);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppIsSuccess
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppIsSuccess, Parameters.AppIsSuccess);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppUserLogID
		    {
				get
		        {
					if(_AppUserLogID_W == null)
	        	    {
						_AppUserLogID_W = TearOff.AppUserLogID;
					}
					return _AppUserLogID_W;
				}
			}

			public WhereParameter AppUserID
		    {
				get
		        {
					if(_AppUserID_W == null)
	        	    {
						_AppUserID_W = TearOff.AppUserID;
					}
					return _AppUserID_W;
				}
			}

			public WhereParameter AppLogInDate
		    {
				get
		        {
					if(_AppLogInDate_W == null)
	        	    {
						_AppLogInDate_W = TearOff.AppLogInDate;
					}
					return _AppLogInDate_W;
				}
			}

			public WhereParameter AppLogOutDate
		    {
				get
		        {
					if(_AppLogOutDate_W == null)
	        	    {
						_AppLogOutDate_W = TearOff.AppLogOutDate;
					}
					return _AppLogOutDate_W;
				}
			}

			public WhereParameter AppIPAddress
		    {
				get
		        {
					if(_AppIPAddress_W == null)
	        	    {
						_AppIPAddress_W = TearOff.AppIPAddress;
					}
					return _AppIPAddress_W;
				}
			}

			public WhereParameter AppIsSuccess
		    {
				get
		        {
					if(_AppIsSuccess_W == null)
	        	    {
						_AppIsSuccess_W = TearOff.AppIsSuccess;
					}
					return _AppIsSuccess_W;
				}
			}

			private WhereParameter _AppUserLogID_W = null;
			private WhereParameter _AppUserID_W = null;
			private WhereParameter _AppLogInDate_W = null;
			private WhereParameter _AppLogOutDate_W = null;
			private WhereParameter _AppIPAddress_W = null;
			private WhereParameter _AppIsSuccess_W = null;

			public void WhereClauseReset()
			{
				_AppUserLogID_W = null;
				_AppUserID_W = null;
				_AppLogInDate_W = null;
				_AppLogOutDate_W = null;
				_AppIPAddress_W = null;
				_AppIsSuccess_W = null;

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
				
				
				public AggregateParameter AppUserLogID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppUserLogID, Parameters.AppUserLogID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppUserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppUserID, Parameters.AppUserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppLogInDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppLogInDate, Parameters.AppLogInDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppLogOutDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppLogOutDate, Parameters.AppLogOutDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIPAddress
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIPAddress, Parameters.AppIPAddress);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppIsSuccess
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppIsSuccess, Parameters.AppIsSuccess);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppUserLogID
		    {
				get
		        {
					if(_AppUserLogID_W == null)
	        	    {
						_AppUserLogID_W = TearOff.AppUserLogID;
					}
					return _AppUserLogID_W;
				}
			}

			public AggregateParameter AppUserID
		    {
				get
		        {
					if(_AppUserID_W == null)
	        	    {
						_AppUserID_W = TearOff.AppUserID;
					}
					return _AppUserID_W;
				}
			}

			public AggregateParameter AppLogInDate
		    {
				get
		        {
					if(_AppLogInDate_W == null)
	        	    {
						_AppLogInDate_W = TearOff.AppLogInDate;
					}
					return _AppLogInDate_W;
				}
			}

			public AggregateParameter AppLogOutDate
		    {
				get
		        {
					if(_AppLogOutDate_W == null)
	        	    {
						_AppLogOutDate_W = TearOff.AppLogOutDate;
					}
					return _AppLogOutDate_W;
				}
			}

			public AggregateParameter AppIPAddress
		    {
				get
		        {
					if(_AppIPAddress_W == null)
	        	    {
						_AppIPAddress_W = TearOff.AppIPAddress;
					}
					return _AppIPAddress_W;
				}
			}

			public AggregateParameter AppIsSuccess
		    {
				get
		        {
					if(_AppIsSuccess_W == null)
	        	    {
						_AppIsSuccess_W = TearOff.AppIsSuccess;
					}
					return _AppIsSuccess_W;
				}
			}

			private AggregateParameter _AppUserLogID_W = null;
			private AggregateParameter _AppUserID_W = null;
			private AggregateParameter _AppLogInDate_W = null;
			private AggregateParameter _AppLogOutDate_W = null;
			private AggregateParameter _AppIPAddress_W = null;
			private AggregateParameter _AppIsSuccess_W = null;

			public void AggregateClauseReset()
			{
				_AppUserLogID_W = null;
				_AppUserID_W = null;
				_AppLogInDate_W = null;
				_AppLogOutDate_W = null;
				_AppIPAddress_W = null;
				_AppIsSuccess_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblUserLogInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppUserLogID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblUserLogUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblUserLogDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppUserLogID);
			p.SourceColumn = ColumnNames.AppUserLogID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppUserLogID);
			p.SourceColumn = ColumnNames.AppUserLogID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppUserID);
			p.SourceColumn = ColumnNames.AppUserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppLogInDate);
			p.SourceColumn = ColumnNames.AppLogInDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppLogOutDate);
			p.SourceColumn = ColumnNames.AppLogOutDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIPAddress);
			p.SourceColumn = ColumnNames.AppIPAddress;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppIsSuccess);
			p.SourceColumn = ColumnNames.AppIsSuccess;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
