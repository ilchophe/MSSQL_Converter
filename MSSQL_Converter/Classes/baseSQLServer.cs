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

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of baseSQLServer.
	/// </summary>
	public class baseSQLServer
	{
		public baseSQLServer()
		{
		}
		
		public string ServerName { get; set; }
		public string Database { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public Utility.SQLServerType ServerType{ get; set; }
		
		
		
	}
}
