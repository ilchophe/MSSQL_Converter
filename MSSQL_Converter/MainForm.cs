/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 01:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MSSQL_Converter;
using MSSQL_Converter.Classes;
using System.Data;
using System.Data.SqlClient;

namespace MSSQL_Converter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private	MSSQL g_SQLServer = null;
		private	PostgreSQL g_PgSQL = null;
		private	Settings g_settings = null;
		private static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
		private static string mappFile = appPath + @"\Mappings\typesmap.xml";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void SQLAuthcheckBoxCheckedChanged(object sender, EventArgs e)
		{
			SQLAuthgroupBox.Enabled = SQLAuthcheckBox.Checked;
				
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			SettingspropertyGrid.SelectedObject=Utility.ConversionSettings;
			LoadMappings();
		}
		
		
		void ClosetoolStripButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ConverttoolStripButtonClick(object sender, EventArgs e)
		{
			bool result = RunConvert();
		}
		
		
		bool RunConvert(){
			
			bool result = false;
			
			try {
					g_SQLServer = GetMSSQL();
					g_PgSQL	 = GetPgSQL();
					g_settings = (Settings)SettingspropertyGrid.SelectedObject;
			
					Converter converter = new MSSQL_Converter.Classes.Converter(g_SQLServer,g_PgSQL,g_settings);
					
										
					result = true;
					
			} catch (Exception) {
				
				throw;
			}
				
			
		
			
			return result;
			
		}
		
		MSSQL GetMSSQL(){
			
			MSSQL result = null;
			
			result = new MSSQL();
			
			result.ServerName = SQLServertextBox.Text;
			result.Database = SQLDatabasetextBox.Text;
			result.SQLAuth = SQLAuthcheckBox.Checked;
			result.Username = SQLUsertextBox.Text;
			result.Password = SQLPasstextBox.Text;
			
			return result;
			
		}
		
		PostgreSQL GetPgSQL(){
			
			PostgreSQL result = null;
			
			result.ServerName = PgServertextBox.Text;
			result.Database = PgDatabasetextBox.Text;
			result.Username = PgUsertextBox.Text;
			result.Password  =PgPasstextBox.Text;
			result.Port = int.Parse( PgPorttextBox.Text);
			
			return result;
			
		}
		
		void LoadMappings(){
			
			System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(mappFile));
			
			if(!dir.Exists){
				dir.Create();
			}
			
			if(!System.IO.File.Exists(mappFile)){
				DataTable mapDT = new DataTable("typesmap");
				
				DataColumn MsSQLCol = new DataColumn("MSSQLTypes");
				MsSQLCol.Caption = "MSSQL Type";
				MsSQLCol.DataType = typeof(string);
				MsSQLCol.MaxLength = 350;
				
				DataColumn PgSQLCol = new DataColumn("PgSQLTypes");
				PgSQLCol.Caption = "PostgreSQL Type";
				PgSQLCol.DataType = typeof(string);
				PgSQLCol.MaxLength = 350;
				
				mapDT.Columns.AddRange(new DataColumn[] {MsSQLCol,PgSQLCol});
				
				DataRow row1 = mapDT.NewRow();
				row1.SetField(0,@"int");
				row1.SetField(1,@"int");
				mapDT.Rows.Add(row1);
				
				DataRow row2 = mapDT.NewRow();
				row2.SetField(0,@"bit");
				row2.SetField(1,@"boolean");
				mapDT.Rows.Add(row2);
				
				DataRow row3 = mapDT.NewRow();
				row3.SetField(0,@"varchar(max)");
				row3.SetField(1,@"text");
				mapDT.Rows.Add(row3);
				
								
				mapDT.AcceptChanges();
				
				MappingsdataGridView.DataSource = mapDT;
			
				MappingsdataGridView.Columns[0].Width=200;
				MappingsdataGridView.Columns[1].Width=200;
				
				                       
			}else{
				//load into dataTable from xml file
				DataTable dt = new DataTable();
				dt.ReadXml(mappFile);
				
				MappingsdataGridView.DataSource = dt;
				
			}
		}
		
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)MappingsdataGridView.DataSource;
			dt.WriteXml(mappFile,false);
			
			toolStripStatusLabel1.Text=@"Mapping Saved.";
		}
	}
}
