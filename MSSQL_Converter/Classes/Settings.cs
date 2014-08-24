/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 02:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MSSQL_Converter.Classes
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		public Settings(){
					
		}
		
			
			private bool m_ConverTables;
			private bool m_ConvertViews;
			private bool m_ConvertTriggers;
			private bool m_ConvertStoredProcedures;
			private bool m_ConvertFunctions;
			
			[Category("SQL Objects")]
			[Description("Convert SQL Server Tables to PosgreSQL")]
			[DisplayName("Convert Tables")]
			public bool ConvertTables { 
				get {return m_ConverTables;} 
				set {m_ConverTables=value;} 
			}
			
			[Category("SQL Objects")]
			[Description("Convert SQL Server Views to PosgreSQL")]
			[DisplayName("Convert Views")]
			public bool ConvertViews { 
				get {return m_ConvertViews;} 
				set {m_ConvertViews=value;} 
			}
			
			[Category("SQL Objects")]
			[Description("Convert SQL Server Triggers to PosgreSQL")]
			[DisplayName("Convert Triggers")]
			public bool ConvertTriggers { 
				get {return m_ConvertTriggers;} 
				set {m_ConvertTriggers=value;} 
			}
			
			[Category("SQL Objects")]
			[Description("Convert SQL Server Stored Procedures to PosgreSQL")]
			[DisplayName("Convert Stored Procedures")]
			public bool ConvertStoredProcedures { 
				get {return m_ConvertStoredProcedures;} 
				set {m_ConvertStoredProcedures=value;} 
			}
			
			[Category("SQL Objects")]
			[Description("Convert SQL Server Functions to PosgreSQL")]
			[DisplayName("Convert Functions")]
			public bool ConvertFunctions { 
				get {return m_ConvertFunctions;} 
				set {m_ConvertFunctions=value;} 
			}
			
	}
}
