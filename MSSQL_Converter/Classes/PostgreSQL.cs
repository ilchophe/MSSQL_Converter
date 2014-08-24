/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 03:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MSSQL_Converter;
using Npgsql;
using System.Data;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of PostgreSQL.
	/// </summary>
	public class PostgreSQL:baseSQLServer
	{
		public PostgreSQL()
		{
		}
		
		private int m_Port=5432;
		public int Port { get{return m_Port;} set{m_Port=value;} }
		
		public override string GetConnectionString() {
			NpgsqlConnectionStringBuilder con = new NpgsqlConnectionStringBuilder();
			
			con.Host = this.ServerName;
			con.Database = this.Database;
			con.IntegratedSecurity=false;
			con.UserName=this.Username;
			con.Password=this.Password;
			con.Port = this.Port;
			
			return con.ConnectionString;
		}
		
		public override bool ExecuteNonQuery(string SQLQuery){
			
			bool result = false;
			
			if(string.IsNullOrEmpty(SQLQuery)) { return result; }
			
			NpgsqlConnection con = new NpgsqlConnection(GetConnectionString());
			NpgsqlCommand cmd= new NpgsqlCommand(SQLQuery,con);
			
			try {
				
				con.Open();
				cmd.ExecuteNonQuery();
				
				result = true;
					
			} catch (Exception ex) {
				throw new Exception(ex.Message);
				
			}finally{
				if (con != null && con.State== ConnectionState.Open) {con.Close();}
			}
			
			
			return result;
		}
		
		
		public override DataTable ExecuteQuery(string SQLQuery){
			
			DataTable result = new DataTable();
			NpgsqlConnection con = new NpgsqlConnection(GetConnectionString());
			NpgsqlDataAdapter cmd= new  NpgsqlDataAdapter(SQLQuery,con);
			
			try {
				
				con.Open();
				cmd.Fill(result);
				
						
			} catch (Exception ex) {
				throw new Exception(ex.Message);
				
			}finally{
				if (con != null && con.State== ConnectionState.Open) {con.Close();}
			}
			
			
			return result;
			
		}
		
	}
}
