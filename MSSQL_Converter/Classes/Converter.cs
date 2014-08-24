/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 04:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MSSQL_Converter;
using System.Data;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of Converter.
	/// </summary>
	public class Converter
	{
		
		private baseSQLServer m_FromServer=null;
		private baseSQLServer m_ToServer=null;
		private Settings m_ConversionSettings;
		

		
		public Converter(baseSQLServer FromServer,baseSQLServer ToServer,Settings ConversionSettings)
		{
			m_FromServer=FromServer;
			m_ToServer = ToServer;
			m_ConversionSettings = ConversionSettings;
		}
		
		public bool Convert(){
			bool result = false;
			
			try {
				
				if(m_ConversionSettings.ConvertTables){
				 	ConvertTables();
				}
				
				result = true;
			} catch (Exception) {
				
				throw;
			}
			
			return result;
		}
		
		
		void ConvertTables(){
			
			//get tables from SQL server
			
			

		}
		

		
		
		
	}
}
