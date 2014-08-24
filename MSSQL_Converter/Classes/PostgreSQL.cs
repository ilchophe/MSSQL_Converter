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
		
	}
}
