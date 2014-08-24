/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 02:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of Utility.
	/// </summary>
	public static class Utility
	{
		
		
		public static Settings ConversionSettings =	new Settings();
		public const string _MAPPINGDT_NAME="typesmap";
		public const string _MAPPINGDS_NAME="mapDS";
		public const string _MAPPING_FILENAME="typesmap.xml";
		
		
		public enum SQLServerType  {
			MSSQL,MySQL,PostgreSQL,Firebird
		};
		
		
		
	}
}
