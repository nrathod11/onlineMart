
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
	public abstract class _tblCouponCodeProduct : SqlClientEntity
	{
		public _tblCouponCodeProduct()
		{
			this.QuerySource = "tblCouponCodeProduct";
			this.MappingName = "tblCouponCodeProduct";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblCouponCodeProductLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AppCouponCodeProductID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AppCouponCodeProductID, AppCouponCodeProductID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_tblCouponCodeProductLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AppCouponCodeProductID
			{
				get
				{
					return new SqlParameter("@AppCouponCodeProductID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppCouponCodeID
			{
				get
				{
					return new SqlParameter("@AppCouponCodeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AppReferenceID
			{
				get
				{
					return new SqlParameter("@AppReferenceID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AppCouponCodeProductID = "appCouponCodeProductID";
            public const string AppCouponCodeID = "appCouponCodeID";
            public const string AppReferenceID = "appReferenceID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppCouponCodeProductID] = _tblCouponCodeProduct.PropertyNames.AppCouponCodeProductID;
					ht[AppCouponCodeID] = _tblCouponCodeProduct.PropertyNames.AppCouponCodeID;
					ht[AppReferenceID] = _tblCouponCodeProduct.PropertyNames.AppReferenceID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AppCouponCodeProductID = "AppCouponCodeProductID";
            public const string AppCouponCodeID = "AppCouponCodeID";
            public const string AppReferenceID = "AppReferenceID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AppCouponCodeProductID] = _tblCouponCodeProduct.ColumnNames.AppCouponCodeProductID;
					ht[AppCouponCodeID] = _tblCouponCodeProduct.ColumnNames.AppCouponCodeID;
					ht[AppReferenceID] = _tblCouponCodeProduct.ColumnNames.AppReferenceID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AppCouponCodeProductID = "s_AppCouponCodeProductID";
            public const string AppCouponCodeID = "s_AppCouponCodeID";
            public const string AppReferenceID = "s_AppReferenceID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AppCouponCodeProductID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppCouponCodeProductID);
			}
			set
	        {
				base.Setint(ColumnNames.AppCouponCodeProductID, value);
			}
		}

		public virtual int AppCouponCodeID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppCouponCodeID);
			}
			set
	        {
				base.Setint(ColumnNames.AppCouponCodeID, value);
			}
		}

		public virtual int AppReferenceID
	    {
			get
	        {
				return base.Getint(ColumnNames.AppReferenceID);
			}
			set
	        {
				base.Setint(ColumnNames.AppReferenceID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AppCouponCodeProductID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCouponCodeProductID) ? string.Empty : base.GetintAsString(ColumnNames.AppCouponCodeProductID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCouponCodeProductID);
				else
					this.AppCouponCodeProductID = base.SetintAsString(ColumnNames.AppCouponCodeProductID, value);
			}
		}

		public virtual string s_AppCouponCodeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppCouponCodeID) ? string.Empty : base.GetintAsString(ColumnNames.AppCouponCodeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppCouponCodeID);
				else
					this.AppCouponCodeID = base.SetintAsString(ColumnNames.AppCouponCodeID, value);
			}
		}

		public virtual string s_AppReferenceID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AppReferenceID) ? string.Empty : base.GetintAsString(ColumnNames.AppReferenceID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AppReferenceID);
				else
					this.AppReferenceID = base.SetintAsString(ColumnNames.AppReferenceID, value);
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
				
				
				public WhereParameter AppCouponCodeProductID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCouponCodeProductID, Parameters.AppCouponCodeProductID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppCouponCodeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppCouponCodeID, Parameters.AppCouponCodeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AppReferenceID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AppReferenceID, Parameters.AppReferenceID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AppCouponCodeProductID
		    {
				get
		        {
					if(_AppCouponCodeProductID_W == null)
	        	    {
						_AppCouponCodeProductID_W = TearOff.AppCouponCodeProductID;
					}
					return _AppCouponCodeProductID_W;
				}
			}

			public WhereParameter AppCouponCodeID
		    {
				get
		        {
					if(_AppCouponCodeID_W == null)
	        	    {
						_AppCouponCodeID_W = TearOff.AppCouponCodeID;
					}
					return _AppCouponCodeID_W;
				}
			}

			public WhereParameter AppReferenceID
		    {
				get
		        {
					if(_AppReferenceID_W == null)
	        	    {
						_AppReferenceID_W = TearOff.AppReferenceID;
					}
					return _AppReferenceID_W;
				}
			}

			private WhereParameter _AppCouponCodeProductID_W = null;
			private WhereParameter _AppCouponCodeID_W = null;
			private WhereParameter _AppReferenceID_W = null;

			public void WhereClauseReset()
			{
				_AppCouponCodeProductID_W = null;
				_AppCouponCodeID_W = null;
				_AppReferenceID_W = null;

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
				
				
				public AggregateParameter AppCouponCodeProductID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCouponCodeProductID, Parameters.AppCouponCodeProductID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppCouponCodeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppCouponCodeID, Parameters.AppCouponCodeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AppReferenceID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AppReferenceID, Parameters.AppReferenceID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AppCouponCodeProductID
		    {
				get
		        {
					if(_AppCouponCodeProductID_W == null)
	        	    {
						_AppCouponCodeProductID_W = TearOff.AppCouponCodeProductID;
					}
					return _AppCouponCodeProductID_W;
				}
			}

			public AggregateParameter AppCouponCodeID
		    {
				get
		        {
					if(_AppCouponCodeID_W == null)
	        	    {
						_AppCouponCodeID_W = TearOff.AppCouponCodeID;
					}
					return _AppCouponCodeID_W;
				}
			}

			public AggregateParameter AppReferenceID
		    {
				get
		        {
					if(_AppReferenceID_W == null)
	        	    {
						_AppReferenceID_W = TearOff.AppReferenceID;
					}
					return _AppReferenceID_W;
				}
			}

			private AggregateParameter _AppCouponCodeProductID_W = null;
			private AggregateParameter _AppCouponCodeID_W = null;
			private AggregateParameter _AppReferenceID_W = null;

			public void AggregateClauseReset()
			{
				_AppCouponCodeProductID_W = null;
				_AppCouponCodeID_W = null;
				_AppReferenceID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblCouponCodeProductInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AppCouponCodeProductID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblCouponCodeProductUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_tblCouponCodeProductDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AppCouponCodeProductID);
			p.SourceColumn = ColumnNames.AppCouponCodeProductID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AppCouponCodeProductID);
			p.SourceColumn = ColumnNames.AppCouponCodeProductID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppCouponCodeID);
			p.SourceColumn = ColumnNames.AppCouponCodeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AppReferenceID);
			p.SourceColumn = ColumnNames.AppReferenceID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
