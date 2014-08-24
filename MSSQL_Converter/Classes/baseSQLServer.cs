/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 03:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MSSQL_Converter;
using System.Data;
using System.Data.SqlClient;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of baseSQLServer.
	/// </summary>
	public abstract class baseSQLServer
	{
		public baseSQLServer()
		{
		}
		
		public string ServerName { get; set; }
		public string Database { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public Utility.SQLServerType ServerType{ get; set; }
		
		public abstract string GetConnectionString();
		public abstract bool ExecuteNonQuery(string QueryString);
		public abstract DataTable ExecuteQuery(string QueryString);
		
	}
}
