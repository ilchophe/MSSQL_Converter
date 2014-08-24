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
		private static string mappFile = appPath + @"\Mappings\" + Utility._MAPPING_FILENAME;
		private string MSSQL_SCHEMA = "dbo";
		
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
					
				InitCapturedSettings();
										
					result = true;
					
			} catch (Exception) {
				
				throw;
			}
				
			
		
			
			return result;
			
		}
		
		
		void InitCapturedSettings() {
			
			g_SQLServer = GetMSSQL();
			g_PgSQL	 = GetPgSQL();
			g_settings = (Settings)SettingspropertyGrid.SelectedObject;
			
			Converter converter = new MSSQL_Converter.Classes.Converter(g_SQLServer,g_PgSQL,g_settings);
		}
		
		
		MSSQL GetMSSQL(){
			
			MSSQL result = null;
			
			result = new MSSQL();
			
			result.ServerName = string.IsNullOrEmpty(SQLServertextBox.Text) ? result.ServerName:SQLServertextBox.Text;
			result.Database = string.IsNullOrEmpty(SQLDatabasetextBox.Text) ? result.Database:SQLDatabasetextBox.Text;
			result.SQLAuth = SQLAuthcheckBox.Checked;
			result.Username = string.IsNullOrEmpty(SQLUsertextBox.Text) ? result.Username:SQLUsertextBox.Text;
			result.Password = string.IsNullOrEmpty(SQLPasstextBox.Text) ? result.Password:SQLPasstextBox.Text;
			
			return result;
			
		}
		
		PostgreSQL GetPgSQL(){
			
			PostgreSQL result = new PostgreSQL();
			
			result.ServerName = string.IsNullOrEmpty(PgServertextBox.Text) ? result.ServerName:PgServertextBox.Text;
			result.Database = string.IsNullOrEmpty(PgDatabasetextBox.Text) ? result.Database:PgDatabasetextBox.Text;
			result.Username = string.IsNullOrEmpty(PgUsertextBox.Text) ? result.Username:PgUsertextBox.Text;
			result.Password = string.IsNullOrEmpty(PgPasstextBox.Text) ? result.Password:PgPasstextBox.Text;
			result.Port = string.IsNullOrEmpty(PgPorttextBox.Text) ? result.Port:int.Parse( PgPorttextBox.Text);
			
			return result;
			
		}
		
		void LoadMappings(){
			
			System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(mappFile));
			
			if(!dir.Exists){
				dir.Create();
			}
			
			if(!System.IO.File.Exists(mappFile)){
				
				DataSet mapDS = new DataSet(Utility._MAPPINGDS_NAME);
				DataTable mapDT = new DataTable(Utility._MAPPINGDT_NAME);
				
				mapDS.Tables.Add(mapDT);
				
				DataColumn MsSQLCol = new DataColumn("MSSQLTypes");
				MsSQLCol.Caption = "MSSQL Type";
				MsSQLCol.DataType = typeof(string);
				MsSQLCol.MaxLength = 350;
				
				DataColumn PgSQLCol = new DataColumn("PgSQLTypes");
				PgSQLCol.Caption = "PostgreSQL Type";
				PgSQLCol.DataType = typeof(string);
				PgSQLCol.MaxLength = 350;
				
				mapDT.Columns.AddRange(new DataColumn[] {MsSQLCol,PgSQLCol});
				
				AddDataTypesDefaults(mapDT);
				
								
				mapDT.AcceptChanges();
				
				SetMappingGrid(mapDT);
				
				                       
			} else {
				//load into dataTable from xml file
				DataSet ds = new DataSet(Utility._MAPPINGDS_NAME);
				ds.ReadXml(mappFile,XmlReadMode.InferSchema);
				
				SetMappingGrid(ds.Tables[Utility._MAPPINGDT_NAME]);
		
				
			}
		}
		
		void AddDataTypesDefaults(DataTable mapDatatable) {
				
				CreateDefultRow(mapDatatable,@"indentity",@"serial");
				CreateDefultRow(mapDatatable,@"smallint",@"smallint");
				CreateDefultRow(mapDatatable,@"int",@"int");
				CreateDefultRow(mapDatatable,@"bigint",@"bigint");
				CreateDefultRow(mapDatatable,@"decimal",@"decimal");
				CreateDefultRow(mapDatatable,@"numeric",@"numeric");
				CreateDefultRow(mapDatatable,@"float",@"float");
				CreateDefultRow(mapDatatable,@"real",@"real");
				CreateDefultRow(mapDatatable,@"double precision",@"double precision");
				CreateDefultRow(mapDatatable,@"datetime",@"timestamp");
				CreateDefultRow(mapDatatable,@"bit",@"boolean");
				CreateDefultRow(mapDatatable,@"varbinary(max)",@"bytea");
				CreateDefultRow(mapDatatable,@"image",@"bytea");
				CreateDefultRow(mapDatatable,@"money",@"money");
				CreateDefultRow(mapDatatable,@"nvarchar(max)",@"text");
				CreateDefultRow(mapDatatable,@"varchar(max)",@"text");
				CreateDefultRow(mapDatatable,@"text",@"text");
				CreateDefultRow(mapDatatable,@"ntext",@"text");
				CreateDefultRow(mapDatatable,@"nvarchar",@"varchar");
				CreateDefultRow(mapDatatable,@"varchar",@"varchar");
				CreateDefultRow(mapDatatable,@"nchar",@"char");
				CreateDefultRow(mapDatatable,@"char",@"char");
				CreateDefultRow(mapDatatable,@"uniqueidentifier",@"UUID");
				
		}
		
		void CreateDefultRow(DataTable mapDatatable,string SQLTypeName,string PgSQLTypeName ) {
				
				DataRow newRow = mapDatatable.NewRow();
				newRow.SetField(0,SQLTypeName);
				newRow.SetField(1,PgSQLTypeName);
				mapDatatable.Rows.Add(newRow);
		}
		
		
		void SaveMaptoolStripButtonClick(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)MappingsdataGridView.DataSource;
			DataSet ds = dt.DataSet;
			
			ds.WriteXml(mappFile,XmlWriteMode.IgnoreSchema);
			
			StatetoolStripStatusLabel.Text=@"Mapping Saved.";
		}
		
		void SetMappingGrid(DataTable mappingTable){
			
				MappingsdataGridView.DataSource = mappingTable;
				MappingsdataGridView.Columns[0].Width=200;
				MappingsdataGridView.Columns[1].Width=200;
		}
		
		
		void ConnectbuttonClick(object sender, EventArgs e)
		{
			
			InitCapturedSettings();
			FetchSQLObjects();
		}
		
		
		void FetchSQLObjects() {
			
			string FetchTableQry = @"SELECT TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME, TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES " +
									"WHERE TABLE_TYPE = N'BASE TABLE' AND TABLE_CATALOG = '" + g_SQLServer.Database + "'" +
									" AND TABLE_SCHEMA = N'" + MSSQL_SCHEMA + @"' ORDER BY TABLE_NAME";
			
			
			DataTable tableList = g_SQLServer.ExecuteQuery(FetchTableQry);
			
			foreach(DataRow rw in tableList.Rows){
				
				string tableName = rw["TABLE_NAME"].ToString();
				
				TreeNode li = new TreeNode(tableName,0,0); //new ListViewItem(tableName,0,new ListViewGroup("Table","Table"));
				
				SQLObjectstreeView.Nodes[0].Nodes.Add(li);
				
				
				string FetchColInfo = "SELECT TABLE_CATALOG,TABLE_SCHEMA, TABLE_NAME, COLUMN_NAME,ORDINAL_POSITION, " + 
									  "COLUMN_DEFAULT, IS_NULLABLE, DATA_TYPE,CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE FROM INFORMATION_SCHEMA.COLUMNS " +
									  "WHERE TABLE_NAME=N'" + tableName + "' AND TABLE_CATALOG = N'" + g_SQLServer.Database + "' AND TABLE_SCHEMA =N'" + MSSQL_SCHEMA + "' ORDER BY ORDINAL_POSITION ";
				
				DataTable TableColumns = g_SQLServer.ExecuteQuery(FetchColInfo);
				
				TreeNode colName=null;
									
				foreach(DataRow colRow in TableColumns.Rows) {
					
					colName = new TreeNode(colRow["COLUMN_NAME"].ToString(),1,1);
					TreeNode colDefault = new TreeNode(colRow["COLUMN_DEFAULT"].ToString(),2,2);
					TreeNode colNullable = new TreeNode(colRow["IS_NULLABLE"].ToString(),2,2);
					TreeNode colDataType = new TreeNode(colRow["DATA_TYPE"].ToString(),2,2);
					TreeNode colCharMaxlength = new TreeNode(colRow["CHARACTER_MAXIMUM_LENGTH"].ToString(),2,2);
					TreeNode colNumPrec = new TreeNode(colRow["NUMERIC_PRECISION"].ToString(),2,2);
					TreeNode colNumScale = new TreeNode(colRow["NUMERIC_SCALE"].ToString(),2,2);
					
					colName.Nodes.AddRange(new TreeNode[] {colDefault,colNullable,colDataType,colCharMaxlength,colNumPrec,colNumScale});
					
				}
				
				if(colName != null) {	li.Nodes.Add(colName); }
				
			}
			                                               
			
		}
		
		
		
		
		
		void SQLObjectstreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
			
		}
	}
}
