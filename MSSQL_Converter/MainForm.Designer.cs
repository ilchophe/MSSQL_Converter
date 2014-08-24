/*
 * Created by SharpDevelop.
 * User: Mario
 * Date: 24-08-14
 * Time: 01:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MSSQL_Converter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Objects Found");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.SettingspropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.PgPorttextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PgPasstextBox = new System.Windows.Forms.TextBox();
			this.PgUsertextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.PgDatabasetextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.PgServertextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Connectbutton = new System.Windows.Forms.Button();
			this.SQLAuthgroupBox = new System.Windows.Forms.GroupBox();
			this.SQLPasstextBox = new System.Windows.Forms.TextBox();
			this.SQLUsertextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SQLAuthcheckBox = new System.Windows.Forms.CheckBox();
			this.SQLDatabasetextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SQLServertextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.MappingsdataGridView = new System.Windows.Forms.DataGridView();
			this.SQLObjtabPage = new System.Windows.Forms.TabPage();
			this.SQLObjectstreeView = new System.Windows.Forms.TreeView();
			this.MainimageList = new System.Windows.Forms.ImageList(this.components);
			this.MainstatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MaintoolStrip = new System.Windows.Forms.ToolStrip();
			this.ConverttoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SaveMaptoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SQLAuthgroupBox.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MappingsdataGridView)).BeginInit();
			this.SQLObjtabPage.SuspendLayout();
			this.MainstatusStrip.SuspendLayout();
			this.MaintoolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PowderBlue;
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(929, 86);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 118);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(929, 416);
			this.panel2.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.SQLObjtabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(929, 416);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.SettingspropertyGrid);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(921, 390);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Configuration";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// SettingspropertyGrid
			// 
			this.SettingspropertyGrid.Location = new System.Drawing.Point(589, 29);
			this.SettingspropertyGrid.Name = "SettingspropertyGrid";
			this.SettingspropertyGrid.Size = new System.Drawing.Size(324, 244);
			this.SettingspropertyGrid.TabIndex = 12;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.PgPorttextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.PgDatabasetextBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.PgServertextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(305, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 250);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PostgreSQL Server";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 155);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(87, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Login credentials";
			// 
			// PgPorttextBox
			// 
			this.PgPorttextBox.Location = new System.Drawing.Point(12, 129);
			this.PgPorttextBox.Name = "PgPorttextBox";
			this.PgPorttextBox.Size = new System.Drawing.Size(71, 20);
			this.PgPorttextBox.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Port";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PgPasstextBox);
			this.groupBox3.Controls.Add(this.PgUsertextBox);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(12, 169);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(234, 69);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			// 
			// PgPasstextBox
			// 
			this.PgPasstextBox.Location = new System.Drawing.Point(68, 36);
			this.PgPasstextBox.Name = "PgPasstextBox";
			this.PgPasstextBox.PasswordChar = '*';
			this.PgPasstextBox.Size = new System.Drawing.Size(160, 20);
			this.PgPasstextBox.TabIndex = 4;
			// 
			// PgUsertextBox
			// 
			this.PgUsertextBox.Location = new System.Drawing.Point(68, 13);
			this.PgUsertextBox.Name = "PgUsertextBox";
			this.PgUsertextBox.Size = new System.Drawing.Size(160, 20);
			this.PgUsertextBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Password";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Username";
			// 
			// PgDatabasetextBox
			// 
			this.PgDatabasetextBox.Location = new System.Drawing.Point(12, 88);
			this.PgDatabasetextBox.Name = "PgDatabasetextBox";
			this.PgDatabasetextBox.Size = new System.Drawing.Size(244, 20);
			this.PgDatabasetextBox.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Database";
			// 
			// PgServertextBox
			// 
			this.PgServertextBox.Location = new System.Drawing.Point(12, 45);
			this.PgServertextBox.Name = "PgServertextBox";
			this.PgServertextBox.Size = new System.Drawing.Size(244, 20);
			this.PgServertextBox.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(140, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "PostgreSQL server name/IP";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Connectbutton);
			this.groupBox1.Controls.Add(this.SQLAuthgroupBox);
			this.groupBox1.Controls.Add(this.SQLAuthcheckBox);
			this.groupBox1.Controls.Add(this.SQLDatabasetextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.SQLServertextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 250);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MS SQL Server";
			// 
			// Connectbutton
			// 
			this.Connectbutton.Location = new System.Drawing.Point(12, 215);
			this.Connectbutton.Name = "Connectbutton";
			this.Connectbutton.Size = new System.Drawing.Size(244, 23);
			this.Connectbutton.TabIndex = 6;
			this.Connectbutton.Text = "Connect & Retrieve SQL Objects";
			this.Connectbutton.UseVisualStyleBackColor = true;
			this.Connectbutton.Click += new System.EventHandler(this.ConnectbuttonClick);
			// 
			// SQLAuthgroupBox
			// 
			this.SQLAuthgroupBox.Controls.Add(this.SQLPasstextBox);
			this.SQLAuthgroupBox.Controls.Add(this.SQLUsertextBox);
			this.SQLAuthgroupBox.Controls.Add(this.label4);
			this.SQLAuthgroupBox.Controls.Add(this.label3);
			this.SQLAuthgroupBox.Enabled = false;
			this.SQLAuthgroupBox.Location = new System.Drawing.Point(22, 133);
			this.SQLAuthgroupBox.Name = "SQLAuthgroupBox";
			this.SQLAuthgroupBox.Size = new System.Drawing.Size(234, 69);
			this.SQLAuthgroupBox.TabIndex = 5;
			this.SQLAuthgroupBox.TabStop = false;
			// 
			// SQLPasstextBox
			// 
			this.SQLPasstextBox.Location = new System.Drawing.Point(68, 36);
			this.SQLPasstextBox.Name = "SQLPasstextBox";
			this.SQLPasstextBox.PasswordChar = '*';
			this.SQLPasstextBox.Size = new System.Drawing.Size(160, 20);
			this.SQLPasstextBox.TabIndex = 4;
			// 
			// SQLUsertextBox
			// 
			this.SQLUsertextBox.Location = new System.Drawing.Point(68, 13);
			this.SQLUsertextBox.Name = "SQLUsertextBox";
			this.SQLUsertextBox.Size = new System.Drawing.Size(160, 20);
			this.SQLUsertextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Username";
			// 
			// SQLAuthcheckBox
			// 
			this.SQLAuthcheckBox.Location = new System.Drawing.Point(12, 112);
			this.SQLAuthcheckBox.Name = "SQLAuthcheckBox";
			this.SQLAuthcheckBox.Size = new System.Drawing.Size(244, 24);
			this.SQLAuthcheckBox.TabIndex = 4;
			this.SQLAuthcheckBox.Text = "Use SQL Authentiation";
			this.SQLAuthcheckBox.UseVisualStyleBackColor = true;
			// 
			// SQLDatabasetextBox
			// 
			this.SQLDatabasetextBox.Location = new System.Drawing.Point(12, 85);
			this.SQLDatabasetextBox.Name = "SQLDatabasetextBox";
			this.SQLDatabasetextBox.Size = new System.Drawing.Size(244, 20);
			this.SQLDatabasetextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Database";
			// 
			// SQLServertextBox
			// 
			this.SQLServertextBox.Location = new System.Drawing.Point(12, 42);
			this.SQLServertextBox.Name = "SQLServertextBox";
			this.SQLServertextBox.Size = new System.Drawing.Size(244, 20);
			this.SQLServertextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "SQL Server Instance";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.MappingsdataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(921, 390);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Mappings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MappingsdataGridView
			// 
			this.MappingsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MappingsdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MappingsdataGridView.Location = new System.Drawing.Point(3, 3);
			this.MappingsdataGridView.Name = "MappingsdataGridView";
			this.MappingsdataGridView.Size = new System.Drawing.Size(915, 384);
			this.MappingsdataGridView.TabIndex = 0;
			// 
			// SQLObjtabPage
			// 
			this.SQLObjtabPage.Controls.Add(this.SQLObjectstreeView);
			this.SQLObjtabPage.Location = new System.Drawing.Point(4, 22);
			this.SQLObjtabPage.Name = "SQLObjtabPage";
			this.SQLObjtabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SQLObjtabPage.Size = new System.Drawing.Size(921, 390);
			this.SQLObjtabPage.TabIndex = 2;
			this.SQLObjtabPage.Text = "Select SQL Objects";
			this.SQLObjtabPage.UseVisualStyleBackColor = true;
			// 
			// SQLObjectstreeView
			// 
			this.SQLObjectstreeView.CheckBoxes = true;
			this.SQLObjectstreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SQLObjectstreeView.ImageIndex = 0;
			this.SQLObjectstreeView.ImageList = this.MainimageList;
			this.SQLObjectstreeView.Location = new System.Drawing.Point(3, 3);
			this.SQLObjectstreeView.Name = "SQLObjectstreeView";
			treeNode1.Name = "RootNode";
			treeNode1.Text = "Objects Found";
			this.SQLObjectstreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode1});
			this.SQLObjectstreeView.SelectedImageIndex = 0;
			this.SQLObjectstreeView.Size = new System.Drawing.Size(915, 384);
			this.SQLObjectstreeView.TabIndex = 0;
			this.SQLObjectstreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SQLObjectstreeViewAfterSelect);
			// 
			// MainimageList
			// 
			this.MainimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainimageList.ImageStream")));
			this.MainimageList.TransparentColor = System.Drawing.Color.Transparent;
			this.MainimageList.Images.SetKeyName(0, "1408922491_database_table.png");
			this.MainimageList.Images.SetKeyName(1, "1408922620_table.png");
			this.MainimageList.Images.SetKeyName(2, "1408930179_show_table_row.png");
			// 
			// MainstatusStrip
			// 
			this.MainstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.StatetoolStripStatusLabel});
			this.MainstatusStrip.Location = new System.Drawing.Point(0, 534);
			this.MainstatusStrip.Name = "MainstatusStrip";
			this.MainstatusStrip.Size = new System.Drawing.Size(929, 22);
			this.MainstatusStrip.TabIndex = 12;
			this.MainstatusStrip.Text = "statusStrip1";
			// 
			// StatetoolStripStatusLabel
			// 
			this.StatetoolStripStatusLabel.Name = "StatetoolStripStatusLabel";
			this.StatetoolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.StatetoolStripStatusLabel.Text = "Ready";
			// 
			// MaintoolStrip
			// 
			this.MaintoolStrip.AutoSize = false;
			this.MaintoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ConverttoolStripButton,
									this.toolStripSeparator1,
									this.SaveMaptoolStripButton,
									this.toolStripSeparator2,
									this.ClosetoolStripButton});
			this.MaintoolStrip.Location = new System.Drawing.Point(0, 86);
			this.MaintoolStrip.Name = "MaintoolStrip";
			this.MaintoolStrip.Size = new System.Drawing.Size(929, 32);
			this.MaintoolStrip.TabIndex = 13;
			this.MaintoolStrip.Text = "toolStrip1";
			// 
			// ConverttoolStripButton
			// 
			this.ConverttoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ConverttoolStripButton.Image")));
			this.ConverttoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ConverttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ConverttoolStripButton.Name = "ConverttoolStripButton";
			this.ConverttoolStripButton.Size = new System.Drawing.Size(120, 29);
			this.ConverttoolStripButton.Text = "C&onvert Database";
			this.ConverttoolStripButton.ToolTipText = "C&onvert";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
			// 
			// SaveMaptoolStripButton
			// 
			this.SaveMaptoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveMaptoolStripButton.Image")));
			this.SaveMaptoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveMaptoolStripButton.Name = "SaveMaptoolStripButton";
			this.SaveMaptoolStripButton.Size = new System.Drawing.Size(102, 29);
			this.SaveMaptoolStripButton.Text = "&Save Mapping";
			this.SaveMaptoolStripButton.Click += new System.EventHandler(this.SaveMaptoolStripButtonClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
			// 
			// ClosetoolStripButton
			// 
			this.ClosetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ClosetoolStripButton.Image")));
			this.ClosetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ClosetoolStripButton.Name = "ClosetoolStripButton";
			this.ClosetoolStripButton.Size = new System.Drawing.Size(56, 29);
			this.ClosetoolStripButton.Text = "&Close";
			this.ClosetoolStripButton.Click += new System.EventHandler(this.ClosetoolStripButtonClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 86);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(262, 37);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(335, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "Convert Micrsoft SQL Server Databse Objects and data to PostgrSQL";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 556);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.MaintoolStrip);
			this.Controls.Add(this.MainstatusStrip);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MSSQL_Converter";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.SQLAuthgroupBox.ResumeLayout(false);
			this.SQLAuthgroupBox.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MappingsdataGridView)).EndInit();
			this.SQLObjtabPage.ResumeLayout(false);
			this.MainstatusStrip.ResumeLayout(false);
			this.MainstatusStrip.PerformLayout();
			this.MaintoolStrip.ResumeLayout(false);
			this.MaintoolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TreeView SQLObjectstreeView;
		private System.Windows.Forms.ImageList MainimageList;
		private System.Windows.Forms.Button Connectbutton;
		private System.Windows.Forms.TabPage SQLObjtabPage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton SaveMaptoolStripButton;
		private System.Windows.Forms.DataGridView MappingsdataGridView;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ConverttoolStripButton;
		private System.Windows.Forms.ToolStrip MaintoolStrip;
		private System.Windows.Forms.ToolStripStatusLabel StatetoolStripStatusLabel;
		private System.Windows.Forms.StatusStrip MainstatusStrip;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PropertyGrid SettingspropertyGrid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox PgServertextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox PgDatabasetextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PgUsertextBox;
		private System.Windows.Forms.TextBox PgPasstextBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox PgPorttextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox SQLAuthcheckBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox SQLUsertextBox;
		private System.Windows.Forms.TextBox SQLPasstextBox;
		private System.Windows.Forms.GroupBox SQLAuthgroupBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SQLServertextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SQLDatabasetextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
