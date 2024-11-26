using System;
using System.Windows.Forms;

namespace CIS_129_Final
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainWindowMaterialTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.HomePageTitlePanel = new System.Windows.Forms.Panel();
            this.HomePageTitleLabel = new System.Windows.Forms.Label();
            this.HomePageButtonPanel = new System.Windows.Forms.Panel();
            this.HomePageButtonReport = new System.Windows.Forms.Button();
            this.HomePageButtonHouses = new System.Windows.Forms.Button();
            this.HomePageButtonAppartments = new System.Windows.Forms.Button();
            this.HomePageButtonHome = new System.Windows.Forms.Button();
            this.AppartmentsPageTab = new System.Windows.Forms.TabPage();
            this.AppartmentsPagePanel = new System.Windows.Forms.Panel();
            this.AppartmentsPageTitlePanel = new System.Windows.Forms.Panel();
            this.AppartmentsPageTitleLabel = new System.Windows.Forms.Label();
            this.AppartmentsPageButtonPanel = new System.Windows.Forms.Panel();
            this.AppartmentsPageButtonReport = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonHouses = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonAppartments = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonHome = new System.Windows.Forms.Button();
            this.HousesPageTab = new System.Windows.Forms.TabPage();
            this.HousesPagePanel = new System.Windows.Forms.Panel();
            this.HousesPageTitlePanel = new System.Windows.Forms.Panel();
            this.HousesPageTitleLabel = new System.Windows.Forms.Label();
            this.HousesPageButtonPanel = new System.Windows.Forms.Panel();
            this.HousesPageButtonReport = new System.Windows.Forms.Button();
            this.HousesPageButtonHouses = new System.Windows.Forms.Button();
            this.HousesPageButtonAppartments = new System.Windows.Forms.Button();
            this.HousesPageButtonHome = new System.Windows.Forms.Button();
            this.ReportPageTab = new System.Windows.Forms.TabPage();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportPageTitlePanel = new System.Windows.Forms.Panel();
            this.ReportPageTitleLabel = new System.Windows.Forms.Label();
            this.ReportPageButtonPanel = new System.Windows.Forms.Panel();
            this.ReportPageButtonReport = new System.Windows.Forms.Button();
            this.ReportPageButtonHouses = new System.Windows.Forms.Button();
            this.ReportPageButtonAppartments = new System.Windows.Forms.Button();
            this.ReportPageButtonHome = new System.Windows.Forms.Button();
            this.appartmentDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CIS_129_Final.DataSet1();
            this.MainWindowMaterialTabControler.SuspendLayout();
            this.HomePageTab.SuspendLayout();
            this.HomePageTitlePanel.SuspendLayout();
            this.HomePageButtonPanel.SuspendLayout();
            this.AppartmentsPageTab.SuspendLayout();
            this.AppartmentsPageTitlePanel.SuspendLayout();
            this.AppartmentsPageButtonPanel.SuspendLayout();
            this.HousesPageTab.SuspendLayout();
            this.HousesPageTitlePanel.SuspendLayout();
            this.HousesPageButtonPanel.SuspendLayout();
            this.ReportPageTab.SuspendLayout();
            this.ReportPageTitlePanel.SuspendLayout();
            this.ReportPageButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindowMaterialTabControler
            // 
            this.MainWindowMaterialTabControler.Controls.Add(this.HomePageTab);
            this.MainWindowMaterialTabControler.Controls.Add(this.AppartmentsPageTab);
            this.MainWindowMaterialTabControler.Controls.Add(this.HousesPageTab);
            this.MainWindowMaterialTabControler.Controls.Add(this.ReportPageTab);
            this.MainWindowMaterialTabControler.Depth = 0;
            this.MainWindowMaterialTabControler.Location = new System.Drawing.Point(1, 12);
            this.MainWindowMaterialTabControler.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainWindowMaterialTabControler.Multiline = true;
            this.MainWindowMaterialTabControler.Name = "MainWindowMaterialTabControler";
            this.MainWindowMaterialTabControler.SelectedIndex = 0;
            this.MainWindowMaterialTabControler.Size = new System.Drawing.Size(780, 426);
            this.MainWindowMaterialTabControler.TabIndex = 2;
            // 
            // HomePageTab
            // 
            this.HomePageTab.Controls.Add(this.HomePagePanel);
            this.HomePageTab.Controls.Add(this.HomePageTitlePanel);
            this.HomePageTab.Controls.Add(this.HomePageButtonPanel);
            this.HomePageTab.Location = new System.Drawing.Point(4, 22);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomePageTab.Size = new System.Drawing.Size(772, 400);
            this.HomePageTab.TabIndex = 4;
            this.HomePageTab.Text = "StartMenue";
            this.HomePageTab.UseVisualStyleBackColor = true;
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Location = new System.Drawing.Point(109, 104);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(653, 294);
            this.HomePagePanel.TabIndex = 3;
            // 
            // HomePageTitlePanel
            // 
            this.HomePageTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageTitlePanel.Controls.Add(this.HomePageTitleLabel);
            this.HomePageTitlePanel.Location = new System.Drawing.Point(103, 0);
            this.HomePageTitlePanel.Name = "HomePageTitlePanel";
            this.HomePageTitlePanel.Size = new System.Drawing.Size(665, 100);
            this.HomePageTitlePanel.TabIndex = 1;
            // 
            // HomePageTitleLabel
            // 
            this.HomePageTitleLabel.AutoSize = true;
            this.HomePageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.HomePageTitleLabel.Name = "HomePageTitleLabel";
            this.HomePageTitleLabel.Size = new System.Drawing.Size(458, 91);
            this.HomePageTitleLabel.TabIndex = 0;
            this.HomePageTitleLabel.Text = "Home Page";
            // 
            // HomePageButtonPanel
            // 
            this.HomePageButtonPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageButtonPanel.Controls.Add(this.HomePageButtonReport);
            this.HomePageButtonPanel.Controls.Add(this.HomePageButtonHouses);
            this.HomePageButtonPanel.Controls.Add(this.HomePageButtonAppartments);
            this.HomePageButtonPanel.Controls.Add(this.HomePageButtonHome);
            this.HomePageButtonPanel.Location = new System.Drawing.Point(3, 0);
            this.HomePageButtonPanel.Name = "HomePageButtonPanel";
            this.HomePageButtonPanel.Size = new System.Drawing.Size(100, 400);
            this.HomePageButtonPanel.TabIndex = 0;
            // 
            // HomePageButtonReport
            // 
            this.HomePageButtonReport.Location = new System.Drawing.Point(5, 300);
            this.HomePageButtonReport.Name = "HomePageButtonReport";
            this.HomePageButtonReport.Size = new System.Drawing.Size(90, 90);
            this.HomePageButtonReport.TabIndex = 3;
            this.HomePageButtonReport.Text = "Report";
            this.HomePageButtonReport.UseVisualStyleBackColor = true;
            this.HomePageButtonReport.Click += new System.EventHandler(this.GoToReport);
            // 
            // HomePageButtonHouses
            // 
            this.HomePageButtonHouses.Location = new System.Drawing.Point(5, 202);
            this.HomePageButtonHouses.Name = "HomePageButtonHouses";
            this.HomePageButtonHouses.Size = new System.Drawing.Size(90, 90);
            this.HomePageButtonHouses.TabIndex = 2;
            this.HomePageButtonHouses.Text = "Houses";
            this.HomePageButtonHouses.UseVisualStyleBackColor = true;
            this.HomePageButtonHouses.Click += new System.EventHandler(this.GoToHouses);
            // 
            // HomePageButtonAppartments
            // 
            this.HomePageButtonAppartments.Location = new System.Drawing.Point(5, 104);
            this.HomePageButtonAppartments.Name = "HomePageButtonAppartments";
            this.HomePageButtonAppartments.Size = new System.Drawing.Size(90, 90);
            this.HomePageButtonAppartments.TabIndex = 1;
            this.HomePageButtonAppartments.Text = "Appartments";
            this.HomePageButtonAppartments.UseVisualStyleBackColor = true;
            this.HomePageButtonAppartments.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HomePageButtonHome
            // 
            this.HomePageButtonHome.Location = new System.Drawing.Point(5, 5);
            this.HomePageButtonHome.Name = "HomePageButtonHome";
            this.HomePageButtonHome.Size = new System.Drawing.Size(90, 90);
            this.HomePageButtonHome.TabIndex = 0;
            this.HomePageButtonHome.Text = "Home";
            this.HomePageButtonHome.UseVisualStyleBackColor = true;
            this.HomePageButtonHome.Click += new System.EventHandler(this.GoToNothing);
            // 
            // AppartmentsPageTab
            // 
            this.AppartmentsPageTab.Controls.Add(this.AppartmentsPagePanel);
            this.AppartmentsPageTab.Controls.Add(this.AppartmentsPageTitlePanel);
            this.AppartmentsPageTab.Controls.Add(this.AppartmentsPageButtonPanel);
            this.AppartmentsPageTab.Location = new System.Drawing.Point(4, 22);
            this.AppartmentsPageTab.Name = "AppartmentsPageTab";
            this.AppartmentsPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppartmentsPageTab.Size = new System.Drawing.Size(772, 400);
            this.AppartmentsPageTab.TabIndex = 5;
            this.AppartmentsPageTab.Text = "Appartments";
            this.AppartmentsPageTab.UseVisualStyleBackColor = true;
            // 
            // AppartmentsPagePanel
            // 
            this.AppartmentsPagePanel.Location = new System.Drawing.Point(109, 106);
            this.AppartmentsPagePanel.Name = "AppartmentsPagePanel";
            this.AppartmentsPagePanel.Size = new System.Drawing.Size(653, 294);
            this.AppartmentsPagePanel.TabIndex = 2;
            // 
            // AppartmentsPageTitlePanel
            // 
            this.AppartmentsPageTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsPageTitlePanel.Controls.Add(this.AppartmentsPageTitleLabel);
            this.AppartmentsPageTitlePanel.Location = new System.Drawing.Point(103, 0);
            this.AppartmentsPageTitlePanel.Name = "AppartmentsPageTitlePanel";
            this.AppartmentsPageTitlePanel.Size = new System.Drawing.Size(665, 100);
            this.AppartmentsPageTitlePanel.TabIndex = 1;
            // 
            // AppartmentsPageTitleLabel
            // 
            this.AppartmentsPageTitleLabel.AutoSize = true;
            this.AppartmentsPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppartmentsPageTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.AppartmentsPageTitleLabel.Name = "AppartmentsPageTitleLabel";
            this.AppartmentsPageTitleLabel.Size = new System.Drawing.Size(490, 91);
            this.AppartmentsPageTitleLabel.TabIndex = 0;
            this.AppartmentsPageTitleLabel.Text = "Appartments";
            // 
            // AppartmentsPageButtonPanel
            // 
            this.AppartmentsPageButtonPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsPageButtonPanel.Controls.Add(this.AppartmentsPageButtonReport);
            this.AppartmentsPageButtonPanel.Controls.Add(this.AppartmentsPageButtonHouses);
            this.AppartmentsPageButtonPanel.Controls.Add(this.AppartmentsPageButtonAppartments);
            this.AppartmentsPageButtonPanel.Controls.Add(this.AppartmentsPageButtonHome);
            this.AppartmentsPageButtonPanel.Location = new System.Drawing.Point(3, 0);
            this.AppartmentsPageButtonPanel.Name = "AppartmentsPageButtonPanel";
            this.AppartmentsPageButtonPanel.Size = new System.Drawing.Size(100, 400);
            this.AppartmentsPageButtonPanel.TabIndex = 0;
            // 
            // AppartmentsPageButtonReport
            // 
            this.AppartmentsPageButtonReport.Location = new System.Drawing.Point(5, 300);
            this.AppartmentsPageButtonReport.Name = "AppartmentsPageButtonReport";
            this.AppartmentsPageButtonReport.Size = new System.Drawing.Size(90, 90);
            this.AppartmentsPageButtonReport.TabIndex = 3;
            this.AppartmentsPageButtonReport.Text = "Report";
            this.AppartmentsPageButtonReport.UseVisualStyleBackColor = true;
            this.AppartmentsPageButtonReport.Click += new System.EventHandler(this.GoToReport);
            // 
            // AppartmentsPageButtonHouses
            // 
            this.AppartmentsPageButtonHouses.Location = new System.Drawing.Point(5, 202);
            this.AppartmentsPageButtonHouses.Name = "AppartmentsPageButtonHouses";
            this.AppartmentsPageButtonHouses.Size = new System.Drawing.Size(90, 90);
            this.AppartmentsPageButtonHouses.TabIndex = 2;
            this.AppartmentsPageButtonHouses.Text = "Houses";
            this.AppartmentsPageButtonHouses.UseVisualStyleBackColor = true;
            this.AppartmentsPageButtonHouses.Click += new System.EventHandler(this.GoToHouses);
            // 
            // AppartmentsPageButtonAppartments
            // 
            this.AppartmentsPageButtonAppartments.Location = new System.Drawing.Point(5, 104);
            this.AppartmentsPageButtonAppartments.Name = "AppartmentsPageButtonAppartments";
            this.AppartmentsPageButtonAppartments.Size = new System.Drawing.Size(90, 90);
            this.AppartmentsPageButtonAppartments.TabIndex = 1;
            this.AppartmentsPageButtonAppartments.Text = "Appartments";
            this.AppartmentsPageButtonAppartments.UseVisualStyleBackColor = true;
            this.AppartmentsPageButtonAppartments.Click += new System.EventHandler(this.GoToNothing);
            // 
            // AppartmentsPageButtonHome
            // 
            this.AppartmentsPageButtonHome.Location = new System.Drawing.Point(5, 5);
            this.AppartmentsPageButtonHome.Name = "AppartmentsPageButtonHome";
            this.AppartmentsPageButtonHome.Size = new System.Drawing.Size(90, 90);
            this.AppartmentsPageButtonHome.TabIndex = 0;
            this.AppartmentsPageButtonHome.Text = "Home";
            this.AppartmentsPageButtonHome.UseVisualStyleBackColor = true;
            this.AppartmentsPageButtonHome.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // HousesPageTab
            // 
            this.HousesPageTab.Controls.Add(this.HousesPagePanel);
            this.HousesPageTab.Controls.Add(this.HousesPageTitlePanel);
            this.HousesPageTab.Controls.Add(this.HousesPageButtonPanel);
            this.HousesPageTab.Location = new System.Drawing.Point(4, 22);
            this.HousesPageTab.Name = "HousesPageTab";
            this.HousesPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HousesPageTab.Size = new System.Drawing.Size(772, 400);
            this.HousesPageTab.TabIndex = 6;
            this.HousesPageTab.Text = "Houses";
            this.HousesPageTab.UseVisualStyleBackColor = true;
            // 
            // HousesPagePanel
            // 
            this.HousesPagePanel.Location = new System.Drawing.Point(109, 106);
            this.HousesPagePanel.Name = "HousesPagePanel";
            this.HousesPagePanel.Size = new System.Drawing.Size(653, 294);
            this.HousesPagePanel.TabIndex = 2;
            // 
            // HousesPageTitlePanel
            // 
            this.HousesPageTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesPageTitlePanel.Controls.Add(this.HousesPageTitleLabel);
            this.HousesPageTitlePanel.Location = new System.Drawing.Point(103, 0);
            this.HousesPageTitlePanel.Name = "HousesPageTitlePanel";
            this.HousesPageTitlePanel.Size = new System.Drawing.Size(665, 100);
            this.HousesPageTitlePanel.TabIndex = 1;
            // 
            // HousesPageTitleLabel
            // 
            this.HousesPageTitleLabel.AutoSize = true;
            this.HousesPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousesPageTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.HousesPageTitleLabel.Name = "HousesPageTitleLabel";
            this.HousesPageTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HousesPageTitleLabel.Size = new System.Drawing.Size(309, 91);
            this.HousesPageTitleLabel.TabIndex = 0;
            this.HousesPageTitleLabel.Text = "Houses";
            // 
            // HousesPageButtonPanel
            // 
            this.HousesPageButtonPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesPageButtonPanel.Controls.Add(this.HousesPageButtonReport);
            this.HousesPageButtonPanel.Controls.Add(this.HousesPageButtonHouses);
            this.HousesPageButtonPanel.Controls.Add(this.HousesPageButtonAppartments);
            this.HousesPageButtonPanel.Controls.Add(this.HousesPageButtonHome);
            this.HousesPageButtonPanel.Location = new System.Drawing.Point(3, 0);
            this.HousesPageButtonPanel.Name = "HousesPageButtonPanel";
            this.HousesPageButtonPanel.Size = new System.Drawing.Size(100, 400);
            this.HousesPageButtonPanel.TabIndex = 0;
            // 
            // HousesPageButtonReport
            // 
            this.HousesPageButtonReport.Location = new System.Drawing.Point(5, 300);
            this.HousesPageButtonReport.Name = "HousesPageButtonReport";
            this.HousesPageButtonReport.Size = new System.Drawing.Size(90, 90);
            this.HousesPageButtonReport.TabIndex = 3;
            this.HousesPageButtonReport.Text = "Report";
            this.HousesPageButtonReport.UseVisualStyleBackColor = true;
            this.HousesPageButtonReport.Click += new System.EventHandler(this.GoToReport);
            // 
            // HousesPageButtonHouses
            // 
            this.HousesPageButtonHouses.Location = new System.Drawing.Point(5, 202);
            this.HousesPageButtonHouses.Name = "HousesPageButtonHouses";
            this.HousesPageButtonHouses.Size = new System.Drawing.Size(90, 90);
            this.HousesPageButtonHouses.TabIndex = 2;
            this.HousesPageButtonHouses.Text = "Houses";
            this.HousesPageButtonHouses.UseVisualStyleBackColor = true;
            this.HousesPageButtonHouses.Click += new System.EventHandler(this.GoToNothing);
            // 
            // HousesPageButtonAppartments
            // 
            this.HousesPageButtonAppartments.Location = new System.Drawing.Point(5, 104);
            this.HousesPageButtonAppartments.Name = "HousesPageButtonAppartments";
            this.HousesPageButtonAppartments.Size = new System.Drawing.Size(90, 90);
            this.HousesPageButtonAppartments.TabIndex = 1;
            this.HousesPageButtonAppartments.Text = "Appartments";
            this.HousesPageButtonAppartments.UseVisualStyleBackColor = true;
            this.HousesPageButtonAppartments.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HousesPageButtonHome
            // 
            this.HousesPageButtonHome.Location = new System.Drawing.Point(5, 5);
            this.HousesPageButtonHome.Name = "HousesPageButtonHome";
            this.HousesPageButtonHome.Size = new System.Drawing.Size(90, 90);
            this.HousesPageButtonHome.TabIndex = 0;
            this.HousesPageButtonHome.Text = "Home";
            this.HousesPageButtonHome.UseVisualStyleBackColor = true;
            this.HousesPageButtonHome.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // ReportPageTab
            // 
            this.ReportPageTab.Controls.Add(this.ReportViewer);
            this.ReportPageTab.Controls.Add(this.ReportPageTitlePanel);
            this.ReportPageTab.Controls.Add(this.ReportPageButtonPanel);
            this.ReportPageTab.Location = new System.Drawing.Point(4, 22);
            this.ReportPageTab.Name = "ReportPageTab";
            this.ReportPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportPageTab.Size = new System.Drawing.Size(772, 400);
            this.ReportPageTab.TabIndex = 7;
            this.ReportPageTab.Text = "Report";
            this.ReportPageTab.UseVisualStyleBackColor = true;
            // 
            // ReportViewer
            // 
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "CIS_129_Final.FullReport.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(103, 101);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(665, 299);
            this.ReportViewer.TabIndex = 2;
            // 
            // ReportPageTitlePanel
            // 
            this.ReportPageTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportPageTitlePanel.Controls.Add(this.ReportPageTitleLabel);
            this.ReportPageTitlePanel.Location = new System.Drawing.Point(103, 0);
            this.ReportPageTitlePanel.Name = "ReportPageTitlePanel";
            this.ReportPageTitlePanel.Size = new System.Drawing.Size(665, 100);
            this.ReportPageTitlePanel.TabIndex = 1;
            // 
            // ReportPageTitleLabel
            // 
            this.ReportPageTitleLabel.AutoSize = true;
            this.ReportPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPageTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.ReportPageTitleLabel.Name = "ReportPageTitleLabel";
            this.ReportPageTitleLabel.Size = new System.Drawing.Size(278, 91);
            this.ReportPageTitleLabel.TabIndex = 0;
            this.ReportPageTitleLabel.Text = "Report";
            // 
            // ReportPageButtonPanel
            // 
            this.ReportPageButtonPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportPageButtonPanel.Controls.Add(this.ReportPageButtonReport);
            this.ReportPageButtonPanel.Controls.Add(this.ReportPageButtonHouses);
            this.ReportPageButtonPanel.Controls.Add(this.ReportPageButtonAppartments);
            this.ReportPageButtonPanel.Controls.Add(this.ReportPageButtonHome);
            this.ReportPageButtonPanel.Location = new System.Drawing.Point(3, 0);
            this.ReportPageButtonPanel.Name = "ReportPageButtonPanel";
            this.ReportPageButtonPanel.Size = new System.Drawing.Size(100, 400);
            this.ReportPageButtonPanel.TabIndex = 0;
            // 
            // ReportPageButtonReport
            // 
            this.ReportPageButtonReport.Location = new System.Drawing.Point(5, 300);
            this.ReportPageButtonReport.Name = "ReportPageButtonReport";
            this.ReportPageButtonReport.Size = new System.Drawing.Size(90, 90);
            this.ReportPageButtonReport.TabIndex = 3;
            this.ReportPageButtonReport.Text = "Report";
            this.ReportPageButtonReport.UseVisualStyleBackColor = true;
            this.ReportPageButtonReport.Click += new System.EventHandler(this.GoToNothing);
            // 
            // ReportPageButtonHouses
            // 
            this.ReportPageButtonHouses.Location = new System.Drawing.Point(5, 202);
            this.ReportPageButtonHouses.Name = "ReportPageButtonHouses";
            this.ReportPageButtonHouses.Size = new System.Drawing.Size(90, 90);
            this.ReportPageButtonHouses.TabIndex = 2;
            this.ReportPageButtonHouses.Text = "Houses";
            this.ReportPageButtonHouses.UseVisualStyleBackColor = true;
            this.ReportPageButtonHouses.Click += new System.EventHandler(this.GoToHouses);
            // 
            // ReportPageButtonAppartments
            // 
            this.ReportPageButtonAppartments.Location = new System.Drawing.Point(5, 104);
            this.ReportPageButtonAppartments.Name = "ReportPageButtonAppartments";
            this.ReportPageButtonAppartments.Size = new System.Drawing.Size(90, 90);
            this.ReportPageButtonAppartments.TabIndex = 1;
            this.ReportPageButtonAppartments.Text = "Appartments";
            this.ReportPageButtonAppartments.UseVisualStyleBackColor = true;
            this.ReportPageButtonAppartments.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // ReportPageButtonHome
            // 
            this.ReportPageButtonHome.Location = new System.Drawing.Point(5, 5);
            this.ReportPageButtonHome.Name = "ReportPageButtonHome";
            this.ReportPageButtonHome.Size = new System.Drawing.Size(90, 90);
            this.ReportPageButtonHome.TabIndex = 0;
            this.ReportPageButtonHome.Text = "Home";
            this.ReportPageButtonHome.UseVisualStyleBackColor = true;
            this.ReportPageButtonHome.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // appartmentDatabaseDataSetBindingSource
            // 
            this.appartmentDatabaseDataSetBindingSource.DataMember = "Table";
            this.appartmentDatabaseDataSetBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet1";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.MainWindowMaterialTabControler);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindowMaterialTabControler.ResumeLayout(false);
            this.HomePageTab.ResumeLayout(false);
            this.HomePageTitlePanel.ResumeLayout(false);
            this.HomePageTitlePanel.PerformLayout();
            this.HomePageButtonPanel.ResumeLayout(false);
            this.AppartmentsPageTab.ResumeLayout(false);
            this.AppartmentsPageTitlePanel.ResumeLayout(false);
            this.AppartmentsPageTitlePanel.PerformLayout();
            this.AppartmentsPageButtonPanel.ResumeLayout(false);
            this.HousesPageTab.ResumeLayout(false);
            this.HousesPageTitlePanel.ResumeLayout(false);
            this.HousesPageTitlePanel.PerformLayout();
            this.HousesPageButtonPanel.ResumeLayout(false);
            this.ReportPageTab.ResumeLayout(false);
            this.ReportPageTitlePanel.ResumeLayout(false);
            this.ReportPageTitlePanel.PerformLayout();
            this.ReportPageButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl MainWindowMaterialTabControler;
        private TabPage HomePageTab;
        private Panel HomePageTitlePanel;
        private Label HomePageTitleLabel;
        private Panel HomePageButtonPanel;
        private Button HomePageButtonReport;
        private Button HomePageButtonHouses;
        private Button HomePageButtonAppartments;
        private Button HomePageButtonHome;
        private TabPage AppartmentsPageTab;
        private Panel AppartmentsPagePanel;
        private Panel AppartmentsPageTitlePanel;
        private Label AppartmentsPageTitleLabel;
        private Panel AppartmentsPageButtonPanel;
        private TabPage HousesPageTab;
        private Panel HousesPagePanel;
        private Panel HousesPageTitlePanel;
        private Label HousesPageTitleLabel;
        private Panel HousesPageButtonPanel;
        private Button HousesPageButtonReport;
        private Button HousesPageButtonHouses;
        private Button HousesPageButtonAppartments;
        private Button HousesPageButtonHome;
        private TabPage ReportPageTab;
        private Panel ReportPageTitlePanel;
        private Label ReportPageTitleLabel;
        private Panel ReportPageButtonPanel;
        private Button ReportPageButtonReport;
        private Button ReportPageButtonHouses;
        private Button ReportPageButtonAppartments;
        private Button ReportPageButtonHome;
        private Button AppartmentsPageButtonReport;
        private Button AppartmentsPageButtonHouses;
        private Button AppartmentsPageButtonAppartments;
        private Button AppartmentsPageButtonHome;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        
        private System.Windows.Forms.BindingSource appartmentDatabaseDataSetBindingSource;
        private DataSet1 dataSet;
        private Panel HomePagePanel;
    }
}

