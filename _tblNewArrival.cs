
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
	public abstract class _tblNewArrival : SqlClientEntity
	{
		public _tblNewArrival()
		{
			this.QuerySource = "tblNewArrival";
			this.MappingName = "tblNewArrival";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblNewArrivalLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppNewArrivalID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppNewArrivalID, AppNewArrivalID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblNewArrivalLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppNewArrivalID
			{
				get
				{
					return new SqlParameter("@AppNewArrivalID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppProductID
			{
				get
				{
					return new SqlParameter("@AppProductID", SqlDbType.Int, 0);
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
            public const string AppNewArrivalID = "appNewArrivalID";
            public const string AppProductID = "appProductID";
            public const string AppIsActive = "appIsActive";
            public const string AppDisplayOrder = "appDisplayOrder";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppNewArrivalID] = _tblNewArrival.PropertyNames.AppNewArrivalID;
					ht[AppProductID] = _tblNewArrival.PropertyNames.AppProductID;
					ht[AppIsActive] = _tblNewArrival.PropertyNames.AppIsActive;
					ht[AppDisplayOrder] = _tblNewArrival.PropertyNames.AppDisplayOrder;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppNewArrivalID = "AppNewArrivalID";
            public const string AppProductID = "AppProductID";
            public const string AppIsActive = "AppIsActive";
            public const string AppDisplayOrder = "AppDisplayOrder";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppNewArrivalID] = _tblNewArrival.ColumnNames.AppNewArrivalID;
					ht[AppProductID] = _tblNewArrival.ColumnNames.AppProductID;
					ht[AppIsActive] = _tblNewArrival.ColumnNames.AppIsActive;
					ht[AppDisplayOrder] = _tblNewArrival.ColumnNames.AppDisplayOrder;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppNewArrivalID = "s_AppNewArrivalID";
            public const string AppProductID = "s_AppProductID";
            public const string AppIsActive = "s_AppIsActive";
            public const string AppDisplayOrder = "s_AppDisplayOrder";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppNewArrivalID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppNewArrivalID);
			}
			set
	        {
				base.Setint(ColumnNames.AppNewArrivalID, value);
			}
		}

		public virtual int AppProductID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppProductID);
			}
			set
	        {
				base.Setint(ColumnNames.AppProductID, value);
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
	
		public virtual string s_AppNewArrivalID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppNewArrivalID) ? string.Empty : base.GetintAsString(ColumnNames.AppNewArrivalID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppNewArrivalID);
				else
					this.AppNewArrivalID = base.SetintAsString(ColumnNames.AppNewArrivalID, value);
			}
		}

		public virtual string s_AppProductID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppProductID) ? string.Empty : base.GetintAsString(ColumnNames.AppProductID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppProductID);
				else
					this.AppProductID = base.SetintAsString(ColumnNames.AppProductID, value);
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
				
				
				public WhereParameter AppNewArrivalID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppNewArrivalID, Parameters.AppNewArrivalID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppProductID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppProductID, Parameters.AppProductID);
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
		
			public WhereParameter AppNewArrivalID
		    {
				get
		        {
					if(_AppNewArrivalID_W == null)
	        	    {
						_AppNewArrivalID_W = TearOff.AppNewArrivalID;
					}
					return _AppNewArrivalID_W;
				}
			}

			public WhereParameter AppProductID
		    {
				get
		        {
					if(_AppProductID_W == null)
	        	    {
						_AppProductID_W = TearOff.AppProductID;
					}
					return _AppProductID_W;
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

			private WhereParameter _AppNewArrivalID_W = null;
			private WhereParameter _AppProductID_W = null;
			private WhereParameter _AppIsActive_W = null;
			private WhereParameter _AppDisplayOrder_W = null;

			public void WhereClauseReset()
			{
				_AppNewArrivalID_W = null;
				_AppProductID_W = null;
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
				
				
				public AggregateParameter AppNewArrivalID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppNewArrivalID, Parameters.AppNewArrivalID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppProductID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppProductID, Parameters.AppProductID);
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
		
			public AggregateParameter AppNewArrivalID
		    {
				get
		        {
					if(_AppNewArrivalID_W == null)
	        	    {
						_AppNewArrivalID_W = TearOff.AppNewArrivalID;
					}
					return _AppNewArrivalID_W;
				}
			}

			public AggregateParameter AppProductID
		    {
				get
		        {
					if(_AppProductID_W == null)
	        	    {
						_AppProductID_W = TearOff.AppProductID;
					}
					return _AppProductID_W;
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

			private AggregateParameter _AppNewArrivalID_W = null;
			private AggregateParameter _AppProductID_W = null;
			private AggregateParameter _AppIsActive_W = null;
			private AggregateParameter _AppDisplayOrder_W = null;

			public void AggregateClauseReset()
			{
				_AppNewArrivalID_W = null;
				_AppProductID_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblNewArrivalInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppNewArrivalID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblNewArrivalUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblNewArrivalDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppNewArrivalID);
			p.SourceColumn = ColumnNames.AppNewArrivalID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppNewArrivalID);
			p.SourceColumn = ColumnNames.AppNewArrivalID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppProductID);
			p.SourceColumn = ColumnNames.AppProductID;
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
