/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 03:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MSSQL_Converter;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of MSSQL.
	/// </summary>
	public class MSSQL:baseSQLServer
		
	{
		public MSSQL()
		{
		}
		
		private bool m_sqlAuth=false;
		public bool SQLAuth { get{return m_sqlAuth;} set{m_sqlAuth=value;} }
		
	}
}
