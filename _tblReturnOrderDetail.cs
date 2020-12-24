
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
	public abstract class _tblReturnOrderDetail : SqlClientEntity
	{
		public _tblReturnOrderDetail()
		{
			this.QuerySource = "tblReturnOrderDetail";
			this.MappingName = "tblReturnOrderDetail";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblReturnOrderDetailLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppReturnOrderDetailID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppReturnOrderDetailID, AppReturnOrderDetailID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblReturnOrderDetailLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppReturnOrderDetailID
			{
				get
				{
					return new SqlParameter("@AppReturnOrderDetailID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppSubOrderID
			{
				get
				{
					return new SqlParameter("@AppSubOrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppReturnOrderID
			{
				get
				{
					return new SqlParameter("@AppReturnOrderID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppReturnOrderDetailID = "appReturnOrderDetailID";
            public const string AppSubOrderID = "appSubOrderID";
            public const string AppReturnOrderID = "appReturnOrderID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppReturnOrderDetailID] = _tblReturnOrderDetail.PropertyNames.AppReturnOrderDetailID;
					ht[AppSubOrderID] = _tblReturnOrderDetail.PropertyNames.AppSubOrderID;
					ht[AppReturnOrderID] = _tblReturnOrderDetail.PropertyNames.AppReturnOrderID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppReturnOrderDetailID = "AppReturnOrderDetailID";
            public const string AppSubOrderID = "AppSubOrderID";
            public const string AppReturnOrderID = "AppReturnOrderID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppReturnOrderDetailID] = _tblReturnOrderDetail.ColumnNames.AppReturnOrderDetailID;
					ht[AppSubOrderID] = _tblReturnOrderDetail.ColumnNames.AppSubOrderID;
					ht[AppReturnOrderID] = _tblReturnOrderDetail.ColumnNames.AppReturnOrderID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppReturnOrderDetailID = "s_AppReturnOrderDetailID";
            public const string AppSubOrderID = "s_AppSubOrderID";
            public const string AppReturnOrderID = "s_AppReturnOrderID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppReturnOrderDetailID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppReturnOrderDetailID);
			}
			set
	        {
				base.Setint(ColumnNames.AppReturnOrderDetailID, value);
			}
		}

		public virtual int AppSubOrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppSubOrderID);
			}
			set
	        {
				base.Setint(ColumnNames.AppSubOrderID, value);
			}
		}

		public virtual int AppReturnOrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppReturnOrderID);
			}
			set
	        {
				base.Setint(ColumnNames.AppReturnOrderID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppReturnOrderDetailID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppReturnOrderDetailID) ? string.Empty : base.GetintAsString(ColumnNames.AppReturnOrderDetailID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppReturnOrderDetailID);
				else
					this.AppReturnOrderDetailID = base.SetintAsString(ColumnNames.AppReturnOrderDetailID, value);
			}
		}

		public virtual string s_AppSubOrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppSubOrderID) ? string.Empty : base.GetintAsString(ColumnNames.AppSubOrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppSubOrderID);
				else
					this.AppSubOrderID = base.SetintAsString(ColumnNames.AppSubOrderID, value);
			}
		}

		public virtual string s_AppReturnOrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppReturnOrderID) ? string.Empty : base.GetintAsString(ColumnNames.AppReturnOrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppReturnOrderID);
				else
					this.AppReturnOrderID = base.SetintAsString(ColumnNames.AppReturnOrderID, value);
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
				
				
				public WhereParameter AppReturnOrderDetailID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppReturnOrderDetailID, Parameters.AppReturnOrderDetailID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppSubOrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppSubOrderID, Parameters.AppSubOrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppReturnOrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppReturnOrderID, Parameters.AppReturnOrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppReturnOrderDetailID
		    {
				get
		        {
					if(_AppReturnOrderDetailID_W == null)
	        	    {
						_AppReturnOrderDetailID_W = TearOff.AppReturnOrderDetailID;
					}
					return _AppReturnOrderDetailID_W;
				}
			}

			public WhereParameter AppSubOrderID
		    {
				get
		        {
					if(_AppSubOrderID_W == null)
	        	    {
						_AppSubOrderID_W = TearOff.AppSubOrderID;
					}
					return _AppSubOrderID_W;
				}
			}

			public WhereParameter AppReturnOrderID
		    {
				get
		        {
					if(_AppReturnOrderID_W == null)
	        	    {
						_AppReturnOrderID_W = TearOff.AppReturnOrderID;
					}
					return _AppReturnOrderID_W;
				}
			}

			private WhereParameter _AppReturnOrderDetailID_W = null;
			private WhereParameter _AppSubOrderID_W = null;
			private WhereParameter _AppReturnOrderID_W = null;

			public void WhereClauseReset()
			{
				_AppReturnOrderDetailID_W = null;
				_AppSubOrderID_W = null;
				_AppReturnOrderID_W = null;

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
				
				
				public AggregateParameter AppReturnOrderDetailID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppReturnOrderDetailID, Parameters.AppReturnOrderDetailID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppSubOrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppSubOrderID, Parameters.AppSubOrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppReturnOrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppReturnOrderID, Parameters.AppReturnOrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppReturnOrderDetailID
		    {
				get
		        {
					if(_AppReturnOrderDetailID_W == null)
	        	    {
						_AppReturnOrderDetailID_W = TearOff.AppReturnOrderDetailID;
					}
					return _AppReturnOrderDetailID_W;
				}
			}

			public AggregateParameter AppSubOrderID
		    {
				get
		        {
					if(_AppSubOrderID_W == null)
	        	    {
						_AppSubOrderID_W = TearOff.AppSubOrderID;
					}
					return _AppSubOrderID_W;
				}
			}

			public AggregateParameter AppReturnOrderID
		    {
				get
		        {
					if(_AppReturnOrderID_W == null)
	        	    {
						_AppReturnOrderID_W = TearOff.AppReturnOrderID;
					}
					return _AppReturnOrderID_W;
				}
			}

			private AggregateParameter _AppReturnOrderDetailID_W = null;
			private AggregateParameter _AppSubOrderID_W = null;
			private AggregateParameter _AppReturnOrderID_W = null;

			public void AggregateClauseReset()
			{
				_AppReturnOrderDetailID_W = null;
				_AppSubOrderID_W = null;
				_AppReturnOrderID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblReturnOrderDetailInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppReturnOrderDetailID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblReturnOrderDetailUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblReturnOrderDetailDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppReturnOrderDetailID);
			p.SourceColumn = ColumnNames.AppReturnOrderDetailID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppReturnOrderDetailID);
			p.SourceColumn = ColumnNames.AppReturnOrderDetailID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppSubOrderID);
			p.SourceColumn = ColumnNames.AppSubOrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppReturnOrderID);
			p.SourceColumn = ColumnNames.AppReturnOrderID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}