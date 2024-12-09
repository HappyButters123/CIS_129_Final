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
            this.appartmentDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CIS_129_Final.DataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportPanelTopBanner = new System.Windows.Forms.Panel();
            this.ReportButtonSettings = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ReportLablaTitle = new System.Windows.Forms.Label();
            this.ReportPanelSideBanner = new System.Windows.Forms.Panel();
            this.ReportButtonReportPage = new System.Windows.Forms.Button();
            this.ReportButtonHousesPage = new System.Windows.Forms.Button();
            this.ReportButtonAppartmentsPage = new System.Windows.Forms.Button();
            this.ReportButtonHomePage = new System.Windows.Forms.Button();
            this.HousesPage = new System.Windows.Forms.TabPage();
            this.HousesPanel = new System.Windows.Forms.Panel();
            this.HousesPanelTopBanner = new System.Windows.Forms.Panel();
            this.HousesButtonsSettingsPage = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.HousesLableTitle = new System.Windows.Forms.Label();
            this.HousesPanelSideBanner = new System.Windows.Forms.Panel();
            this.HousesButtonsReportPage = new System.Windows.Forms.Button();
            this.HousesButtonsHousesPage = new System.Windows.Forms.Button();
            this.HousesButtonsAppartmentsPage = new System.Windows.Forms.Button();
            this.HousesButtonsHomePage = new System.Windows.Forms.Button();
            this.AppartmentsPage = new System.Windows.Forms.TabPage();
            this.AppartmentsPanel = new System.Windows.Forms.Panel();
            this.AppartmentsPanelTopBanner = new System.Windows.Forms.Panel();
            this.AppartmentsButtonsSettingsPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AppartmentsLableTitle = new System.Windows.Forms.Label();
            this.AppartmentsPanelSideBanner = new System.Windows.Forms.Panel();
            this.AppartmentsButtonsReportPage = new System.Windows.Forms.Button();
            this.AppartmentsButtonsHousesPage = new System.Windows.Forms.Button();
            this.AppartmentsButtonsAppartmentsPage = new System.Windows.Forms.Button();
            this.AppartmentsButtonsHomePage = new System.Windows.Forms.Button();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.HomePagePanel2 = new System.Windows.Forms.Panel();
            this.HomePageTitlePanel = new System.Windows.Forms.Panel();
            this.HomePageSettingsButton = new System.Windows.Forms.Button();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.HomePageTitleLabel = new System.Windows.Forms.Label();
            this.HomePageButtonPanel = new System.Windows.Forms.Panel();
            this.HomePageButtonReport = new System.Windows.Forms.Button();
            this.HomePageButtonHouses = new System.Windows.Forms.Button();
            this.HomePageButtonAppartments = new System.Windows.Forms.Button();
            this.HomePageButtonHome = new System.Windows.Forms.Button();
            this.MainWindowMaterialTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsPanelTopBanner = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsLabelTitle = new System.Windows.Forms.Label();
            this.SettingsPanelSideBanner = new System.Windows.Forms.Panel();
            this.SettingsButtonReportPage = new System.Windows.Forms.Button();
            this.SettingsButtonHousesPage = new System.Windows.Forms.Button();
            this.SettingsButtonAppartmentsPage = new System.Windows.Forms.Button();
            this.SettingsButtonHomePage = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView4 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.ReportPanelTopBanner.SuspendLayout();
            this.ReportPanelSideBanner.SuspendLayout();
            this.HousesPage.SuspendLayout();
            this.HousesPanelTopBanner.SuspendLayout();
            this.HousesPanelSideBanner.SuspendLayout();
            this.AppartmentsPage.SuspendLayout();
            this.AppartmentsPanel.SuspendLayout();
            this.AppartmentsPanelTopBanner.SuspendLayout();
            this.AppartmentsPanelSideBanner.SuspendLayout();
            this.HomePageTab.SuspendLayout();
            this.HomePageTitlePanel.SuspendLayout();
            this.HomePageButtonPanel.SuspendLayout();
            this.MainWindowMaterialTabControler.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SettingsPanelTopBanner.SuspendLayout();
            this.SettingsPanelSideBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // appartmentDatabaseDataSetBindingSource
            // 
            this.appartmentDatabaseDataSetBindingSource.DataMember = "Table1";
            this.appartmentDatabaseDataSetBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet1";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReportViewer);
            this.tabPage3.Controls.Add(this.ReportPanelTopBanner);
            this.tabPage3.Controls.Add(this.ReportPanelSideBanner);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 631);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReportViewer
            // 
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "CIS_129_Final.FullReport.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(159, 160);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(1077, 475);
            this.ReportViewer.TabIndex = 3;
            // 
            // ReportPanelTopBanner
            // 
            this.ReportPanelTopBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportPanelTopBanner.Controls.Add(this.ReportButtonSettings);
            this.ReportPanelTopBanner.Controls.Add(this.panel11);
            this.ReportPanelTopBanner.Controls.Add(this.ReportLablaTitle);
            this.ReportPanelTopBanner.Location = new System.Drawing.Point(153, 0);
            this.ReportPanelTopBanner.Name = "ReportPanelTopBanner";
            this.ReportPanelTopBanner.Size = new System.Drawing.Size(1079, 154);
            this.ReportPanelTopBanner.TabIndex = 1;
            // 
            // ReportButtonSettings
            // 
            this.ReportButtonSettings.Location = new System.Drawing.Point(933, 10);
            this.ReportButtonSettings.Name = "ReportButtonSettings";
            this.ReportButtonSettings.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonSettings.TabIndex = 4;
            this.ReportButtonSettings.Text = "Settings";
            this.ReportButtonSettings.UseVisualStyleBackColor = true;
            this.ReportButtonSettings.Click += new System.EventHandler(this.GoToSettiongs);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(3, 156);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(653, 294);
            this.panel11.TabIndex = 3;
            // 
            // ReportLablaTitle
            // 
            this.ReportLablaTitle.AutoSize = true;
            this.ReportLablaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLablaTitle.Location = new System.Drawing.Point(1, 10);
            this.ReportLablaTitle.Name = "ReportLablaTitle";
            this.ReportLablaTitle.Size = new System.Drawing.Size(418, 135);
            this.ReportLablaTitle.TabIndex = 0;
            this.ReportLablaTitle.Text = "Report";
            // 
            // ReportPanelSideBanner
            // 
            this.ReportPanelSideBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportPanelSideBanner.Controls.Add(this.ReportButtonReportPage);
            this.ReportPanelSideBanner.Controls.Add(this.ReportButtonHousesPage);
            this.ReportPanelSideBanner.Controls.Add(this.ReportButtonAppartmentsPage);
            this.ReportPanelSideBanner.Controls.Add(this.ReportButtonHomePage);
            this.ReportPanelSideBanner.Location = new System.Drawing.Point(3, 0);
            this.ReportPanelSideBanner.Name = "ReportPanelSideBanner";
            this.ReportPanelSideBanner.Size = new System.Drawing.Size(150, 635);
            this.ReportPanelSideBanner.TabIndex = 0;
            // 
            // ReportButtonReportPage
            // 
            this.ReportButtonReportPage.Location = new System.Drawing.Point(5, 481);
            this.ReportButtonReportPage.Name = "ReportButtonReportPage";
            this.ReportButtonReportPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonReportPage.TabIndex = 3;
            this.ReportButtonReportPage.Text = "Report";
            this.ReportButtonReportPage.UseVisualStyleBackColor = true;
            this.ReportButtonReportPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // ReportButtonHousesPage
            // 
            this.ReportButtonHousesPage.Location = new System.Drawing.Point(5, 327);
            this.ReportButtonHousesPage.Name = "ReportButtonHousesPage";
            this.ReportButtonHousesPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonHousesPage.TabIndex = 2;
            this.ReportButtonHousesPage.Text = "Houses";
            this.ReportButtonHousesPage.UseVisualStyleBackColor = true;
            this.ReportButtonHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // ReportButtonAppartmentsPage
            // 
            this.ReportButtonAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.ReportButtonAppartmentsPage.Name = "ReportButtonAppartmentsPage";
            this.ReportButtonAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonAppartmentsPage.TabIndex = 1;
            this.ReportButtonAppartmentsPage.Text = "Appartments";
            this.ReportButtonAppartmentsPage.UseVisualStyleBackColor = true;
            this.ReportButtonAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // ReportButtonHomePage
            // 
            this.ReportButtonHomePage.Location = new System.Drawing.Point(5, 10);
            this.ReportButtonHomePage.Name = "ReportButtonHomePage";
            this.ReportButtonHomePage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonHomePage.TabIndex = 0;
            this.ReportButtonHomePage.Text = "Home";
            this.ReportButtonHomePage.UseVisualStyleBackColor = true;
            this.ReportButtonHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // HousesPage
            // 
            this.HousesPage.Controls.Add(this.HousesPanel);
            this.HousesPage.Controls.Add(this.HousesPanelTopBanner);
            this.HousesPage.Controls.Add(this.HousesPanelSideBanner);
            this.HousesPage.Location = new System.Drawing.Point(4, 22);
            this.HousesPage.Name = "HousesPage";
            this.HousesPage.Padding = new System.Windows.Forms.Padding(3);
            this.HousesPage.Size = new System.Drawing.Size(1232, 631);
            this.HousesPage.TabIndex = 9;
            this.HousesPage.Text = "Houses";
            this.HousesPage.UseVisualStyleBackColor = true;
            // 
            // HousesPanel
            // 
            this.HousesPanel.Location = new System.Drawing.Point(159, 160);
            this.HousesPanel.Name = "HousesPanel";
            this.HousesPanel.Size = new System.Drawing.Size(1067, 471);
            this.HousesPanel.TabIndex = 3;
            // 
            // HousesPanelTopBanner
            // 
            this.HousesPanelTopBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesPanelTopBanner.Controls.Add(this.HousesButtonsSettingsPage);
            this.HousesPanelTopBanner.Controls.Add(this.panel7);
            this.HousesPanelTopBanner.Controls.Add(this.HousesLableTitle);
            this.HousesPanelTopBanner.Location = new System.Drawing.Point(153, 0);
            this.HousesPanelTopBanner.Name = "HousesPanelTopBanner";
            this.HousesPanelTopBanner.Size = new System.Drawing.Size(1079, 154);
            this.HousesPanelTopBanner.TabIndex = 1;
            // 
            // HousesButtonsSettingsPage
            // 
            this.HousesButtonsSettingsPage.Location = new System.Drawing.Point(933, 10);
            this.HousesButtonsSettingsPage.Name = "HousesButtonsSettingsPage";
            this.HousesButtonsSettingsPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsSettingsPage.TabIndex = 4;
            this.HousesButtonsSettingsPage.Text = "Settings";
            this.HousesButtonsSettingsPage.UseVisualStyleBackColor = true;
            this.HousesButtonsSettingsPage.Click += new System.EventHandler(this.GoToSettiongs);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 156);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(653, 294);
            this.panel7.TabIndex = 3;
            // 
            // HousesLableTitle
            // 
            this.HousesLableTitle.AutoSize = true;
            this.HousesLableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousesLableTitle.Location = new System.Drawing.Point(1, 10);
            this.HousesLableTitle.Name = "HousesLableTitle";
            this.HousesLableTitle.Size = new System.Drawing.Size(465, 135);
            this.HousesLableTitle.TabIndex = 0;
            this.HousesLableTitle.Text = "Houses";
            // 
            // HousesPanelSideBanner
            // 
            this.HousesPanelSideBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesPanelSideBanner.Controls.Add(this.HousesButtonsReportPage);
            this.HousesPanelSideBanner.Controls.Add(this.HousesButtonsHousesPage);
            this.HousesPanelSideBanner.Controls.Add(this.HousesButtonsAppartmentsPage);
            this.HousesPanelSideBanner.Controls.Add(this.HousesButtonsHomePage);
            this.HousesPanelSideBanner.Location = new System.Drawing.Point(3, 0);
            this.HousesPanelSideBanner.Name = "HousesPanelSideBanner";
            this.HousesPanelSideBanner.Size = new System.Drawing.Size(150, 635);
            this.HousesPanelSideBanner.TabIndex = 0;
            // 
            // HousesButtonsReportPage
            // 
            this.HousesButtonsReportPage.Location = new System.Drawing.Point(5, 481);
            this.HousesButtonsReportPage.Name = "HousesButtonsReportPage";
            this.HousesButtonsReportPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsReportPage.TabIndex = 3;
            this.HousesButtonsReportPage.Text = "Report";
            this.HousesButtonsReportPage.UseVisualStyleBackColor = true;
            this.HousesButtonsReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // HousesButtonsHousesPage
            // 
            this.HousesButtonsHousesPage.Location = new System.Drawing.Point(5, 327);
            this.HousesButtonsHousesPage.Name = "HousesButtonsHousesPage";
            this.HousesButtonsHousesPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsHousesPage.TabIndex = 2;
            this.HousesButtonsHousesPage.Text = "Houses";
            this.HousesButtonsHousesPage.UseVisualStyleBackColor = true;
            this.HousesButtonsHousesPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // HousesButtonsAppartmentsPage
            // 
            this.HousesButtonsAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.HousesButtonsAppartmentsPage.Name = "HousesButtonsAppartmentsPage";
            this.HousesButtonsAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsAppartmentsPage.TabIndex = 1;
            this.HousesButtonsAppartmentsPage.Text = "Appartments";
            this.HousesButtonsAppartmentsPage.UseVisualStyleBackColor = true;
            this.HousesButtonsAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HousesButtonsHomePage
            // 
            this.HousesButtonsHomePage.Location = new System.Drawing.Point(5, 10);
            this.HousesButtonsHomePage.Name = "HousesButtonsHomePage";
            this.HousesButtonsHomePage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsHomePage.TabIndex = 0;
            this.HousesButtonsHomePage.Text = "Home";
            this.HousesButtonsHomePage.UseVisualStyleBackColor = true;
            this.HousesButtonsHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // AppartmentsPage
            // 
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanel);
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanelTopBanner);
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanelSideBanner);
            this.AppartmentsPage.Location = new System.Drawing.Point(4, 22);
            this.AppartmentsPage.Name = "AppartmentsPage";
            this.AppartmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppartmentsPage.Size = new System.Drawing.Size(1232, 631);
            this.AppartmentsPage.TabIndex = 8;
            this.AppartmentsPage.Text = "Appartments";
            this.AppartmentsPage.UseVisualStyleBackColor = true;
            // 
            // AppartmentsPanel
            // 
            this.AppartmentsPanel.AutoScroll = true;
            this.AppartmentsPanel.AutoSize = true;
            this.AppartmentsPanel.Controls.Add(this.plotView3);
            this.AppartmentsPanel.Controls.Add(this.plotView2);
            this.AppartmentsPanel.Controls.Add(this.plotView4);
            this.AppartmentsPanel.Controls.Add(this.plotView1);
            this.AppartmentsPanel.Location = new System.Drawing.Point(159, 160);
            this.AppartmentsPanel.Name = "AppartmentsPanel";
            this.AppartmentsPanel.Size = new System.Drawing.Size(1067, 471);
            this.AppartmentsPanel.TabIndex = 3;
            // 
            // AppartmentsPanelTopBanner
            // 
            this.AppartmentsPanelTopBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsPanelTopBanner.Controls.Add(this.AppartmentsButtonsSettingsPage);
            this.AppartmentsPanelTopBanner.Controls.Add(this.panel3);
            this.AppartmentsPanelTopBanner.Controls.Add(this.AppartmentsLableTitle);
            this.AppartmentsPanelTopBanner.Location = new System.Drawing.Point(153, 0);
            this.AppartmentsPanelTopBanner.Name = "AppartmentsPanelTopBanner";
            this.AppartmentsPanelTopBanner.Size = new System.Drawing.Size(1079, 154);
            this.AppartmentsPanelTopBanner.TabIndex = 1;
            // 
            // AppartmentsButtonsSettingsPage
            // 
            this.AppartmentsButtonsSettingsPage.Location = new System.Drawing.Point(933, 10);
            this.AppartmentsButtonsSettingsPage.Name = "AppartmentsButtonsSettingsPage";
            this.AppartmentsButtonsSettingsPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsSettingsPage.TabIndex = 4;
            this.AppartmentsButtonsSettingsPage.Text = "Settings";
            this.AppartmentsButtonsSettingsPage.UseVisualStyleBackColor = true;
            this.AppartmentsButtonsSettingsPage.Click += new System.EventHandler(this.GoToSettiongs);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 294);
            this.panel3.TabIndex = 3;
            // 
            // AppartmentsLableTitle
            // 
            this.AppartmentsLableTitle.AutoSize = true;
            this.AppartmentsLableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppartmentsLableTitle.Location = new System.Drawing.Point(1, 10);
            this.AppartmentsLableTitle.Name = "AppartmentsLableTitle";
            this.AppartmentsLableTitle.Size = new System.Drawing.Size(738, 135);
            this.AppartmentsLableTitle.TabIndex = 0;
            this.AppartmentsLableTitle.Text = "Appartments";
            // 
            // AppartmentsPanelSideBanner
            // 
            this.AppartmentsPanelSideBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsPanelSideBanner.Controls.Add(this.AppartmentsButtonsReportPage);
            this.AppartmentsPanelSideBanner.Controls.Add(this.AppartmentsButtonsHousesPage);
            this.AppartmentsPanelSideBanner.Controls.Add(this.AppartmentsButtonsAppartmentsPage);
            this.AppartmentsPanelSideBanner.Controls.Add(this.AppartmentsButtonsHomePage);
            this.AppartmentsPanelSideBanner.Location = new System.Drawing.Point(3, 0);
            this.AppartmentsPanelSideBanner.Name = "AppartmentsPanelSideBanner";
            this.AppartmentsPanelSideBanner.Size = new System.Drawing.Size(150, 635);
            this.AppartmentsPanelSideBanner.TabIndex = 0;
            // 
            // AppartmentsButtonsReportPage
            // 
            this.AppartmentsButtonsReportPage.Location = new System.Drawing.Point(5, 481);
            this.AppartmentsButtonsReportPage.Name = "AppartmentsButtonsReportPage";
            this.AppartmentsButtonsReportPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsReportPage.TabIndex = 3;
            this.AppartmentsButtonsReportPage.Text = "Report";
            this.AppartmentsButtonsReportPage.UseVisualStyleBackColor = true;
            this.AppartmentsButtonsReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // AppartmentsButtonsHousesPage
            // 
            this.AppartmentsButtonsHousesPage.Location = new System.Drawing.Point(5, 327);
            this.AppartmentsButtonsHousesPage.Name = "AppartmentsButtonsHousesPage";
            this.AppartmentsButtonsHousesPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsHousesPage.TabIndex = 2;
            this.AppartmentsButtonsHousesPage.Text = "Houses";
            this.AppartmentsButtonsHousesPage.UseVisualStyleBackColor = true;
            this.AppartmentsButtonsHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // AppartmentsButtonsAppartmentsPage
            // 
            this.AppartmentsButtonsAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.AppartmentsButtonsAppartmentsPage.Name = "AppartmentsButtonsAppartmentsPage";
            this.AppartmentsButtonsAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsAppartmentsPage.TabIndex = 1;
            this.AppartmentsButtonsAppartmentsPage.Text = "Appartments";
            this.AppartmentsButtonsAppartmentsPage.UseVisualStyleBackColor = true;
            this.AppartmentsButtonsAppartmentsPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // AppartmentsButtonsHomePage
            // 
            this.AppartmentsButtonsHomePage.Location = new System.Drawing.Point(5, 10);
            this.AppartmentsButtonsHomePage.Name = "AppartmentsButtonsHomePage";
            this.AppartmentsButtonsHomePage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsHomePage.TabIndex = 0;
            this.AppartmentsButtonsHomePage.Text = "Home";
            this.AppartmentsButtonsHomePage.UseVisualStyleBackColor = true;
            this.AppartmentsButtonsHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // HomePageTab
            // 
            this.HomePageTab.Controls.Add(this.HomePagePanel2);
            this.HomePageTab.Controls.Add(this.HomePageTitlePanel);
            this.HomePageTab.Controls.Add(this.HomePageButtonPanel);
            this.HomePageTab.Location = new System.Drawing.Point(4, 22);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomePageTab.Size = new System.Drawing.Size(1232, 631);
            this.HomePageTab.TabIndex = 4;
            this.HomePageTab.Text = "StartMenue";
            this.HomePageTab.UseVisualStyleBackColor = true;
            // 
            // HomePagePanel2
            // 
            this.HomePagePanel2.Location = new System.Drawing.Point(159, 160);
            this.HomePagePanel2.Name = "HomePagePanel2";
            this.HomePagePanel2.Size = new System.Drawing.Size(1067, 471);
            this.HomePagePanel2.TabIndex = 3;
            // 
            // HomePageTitlePanel
            // 
            this.HomePageTitlePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageTitlePanel.Controls.Add(this.HomePageSettingsButton);
            this.HomePageTitlePanel.Controls.Add(this.HomePagePanel);
            this.HomePageTitlePanel.Controls.Add(this.HomePageTitleLabel);
            this.HomePageTitlePanel.Location = new System.Drawing.Point(153, 0);
            this.HomePageTitlePanel.Name = "HomePageTitlePanel";
            this.HomePageTitlePanel.Size = new System.Drawing.Size(1079, 154);
            this.HomePageTitlePanel.TabIndex = 1;
            // 
            // HomePageSettingsButton
            // 
            this.HomePageSettingsButton.Location = new System.Drawing.Point(933, 10);
            this.HomePageSettingsButton.Name = "HomePageSettingsButton";
            this.HomePageSettingsButton.Size = new System.Drawing.Size(140, 140);
            this.HomePageSettingsButton.TabIndex = 4;
            this.HomePageSettingsButton.Text = "Settings";
            this.HomePageSettingsButton.UseVisualStyleBackColor = true;
            this.HomePageSettingsButton.Click += new System.EventHandler(this.GoToSettiongs);
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Location = new System.Drawing.Point(3, 156);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(653, 294);
            this.HomePagePanel.TabIndex = 3;
            // 
            // HomePageTitleLabel
            // 
            this.HomePageTitleLabel.AutoSize = true;
            this.HomePageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageTitleLabel.Location = new System.Drawing.Point(1, 10);
            this.HomePageTitleLabel.Name = "HomePageTitleLabel";
            this.HomePageTitleLabel.Size = new System.Drawing.Size(691, 135);
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
            this.HomePageButtonPanel.Size = new System.Drawing.Size(150, 635);
            this.HomePageButtonPanel.TabIndex = 0;
            // 
            // HomePageButtonReport
            // 
            this.HomePageButtonReport.Location = new System.Drawing.Point(5, 481);
            this.HomePageButtonReport.Name = "HomePageButtonReport";
            this.HomePageButtonReport.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonReport.TabIndex = 3;
            this.HomePageButtonReport.Text = "Report";
            this.HomePageButtonReport.UseVisualStyleBackColor = true;
            this.HomePageButtonReport.Click += new System.EventHandler(this.GoToReport);
            // 
            // HomePageButtonHouses
            // 
            this.HomePageButtonHouses.Location = new System.Drawing.Point(5, 327);
            this.HomePageButtonHouses.Name = "HomePageButtonHouses";
            this.HomePageButtonHouses.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonHouses.TabIndex = 2;
            this.HomePageButtonHouses.Text = "Houses";
            this.HomePageButtonHouses.UseVisualStyleBackColor = true;
            this.HomePageButtonHouses.Click += new System.EventHandler(this.GoToHouses);
            // 
            // HomePageButtonAppartments
            // 
            this.HomePageButtonAppartments.Location = new System.Drawing.Point(5, 164);
            this.HomePageButtonAppartments.Name = "HomePageButtonAppartments";
            this.HomePageButtonAppartments.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonAppartments.TabIndex = 1;
            this.HomePageButtonAppartments.Text = "Appartments";
            this.HomePageButtonAppartments.UseVisualStyleBackColor = true;
            this.HomePageButtonAppartments.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HomePageButtonHome
            // 
            this.HomePageButtonHome.Location = new System.Drawing.Point(5, 10);
            this.HomePageButtonHome.Name = "HomePageButtonHome";
            this.HomePageButtonHome.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonHome.TabIndex = 0;
            this.HomePageButtonHome.Text = "Home";
            this.HomePageButtonHome.UseVisualStyleBackColor = true;
            this.HomePageButtonHome.Click += new System.EventHandler(this.GoToNothing);
            // 
            // MainWindowMaterialTabControler
            // 
            this.MainWindowMaterialTabControler.Controls.Add(this.HomePageTab);
            this.MainWindowMaterialTabControler.Controls.Add(this.AppartmentsPage);
            this.MainWindowMaterialTabControler.Controls.Add(this.HousesPage);
            this.MainWindowMaterialTabControler.Controls.Add(this.tabPage3);
            this.MainWindowMaterialTabControler.Controls.Add(this.SettingsPage);
            this.MainWindowMaterialTabControler.Depth = 0;
            this.MainWindowMaterialTabControler.Location = new System.Drawing.Point(12, 12);
            this.MainWindowMaterialTabControler.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainWindowMaterialTabControler.Multiline = true;
            this.MainWindowMaterialTabControler.Name = "MainWindowMaterialTabControler";
            this.MainWindowMaterialTabControler.SelectedIndex = 0;
            this.MainWindowMaterialTabControler.Size = new System.Drawing.Size(1240, 657);
            this.MainWindowMaterialTabControler.TabIndex = 2;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.SettingsPanel);
            this.SettingsPage.Controls.Add(this.SettingsPanelTopBanner);
            this.SettingsPage.Controls.Add(this.SettingsPanelSideBanner);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(1232, 631);
            this.SettingsPage.TabIndex = 11;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Location = new System.Drawing.Point(156, 159);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1067, 471);
            this.SettingsPanel.TabIndex = 4;
            // 
            // SettingsPanelTopBanner
            // 
            this.SettingsPanelTopBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.SettingsPanelTopBanner.Controls.Add(this.panel2);
            this.SettingsPanelTopBanner.Controls.Add(this.SettingsLabelTitle);
            this.SettingsPanelTopBanner.Location = new System.Drawing.Point(153, 0);
            this.SettingsPanelTopBanner.Name = "SettingsPanelTopBanner";
            this.SettingsPanelTopBanner.Size = new System.Drawing.Size(1079, 154);
            this.SettingsPanelTopBanner.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 294);
            this.panel2.TabIndex = 3;
            // 
            // SettingsLabelTitle
            // 
            this.SettingsLabelTitle.AutoSize = true;
            this.SettingsLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabelTitle.Location = new System.Drawing.Point(1, 10);
            this.SettingsLabelTitle.Name = "SettingsLabelTitle";
            this.SettingsLabelTitle.Size = new System.Drawing.Size(491, 135);
            this.SettingsLabelTitle.TabIndex = 0;
            this.SettingsLabelTitle.Text = "Settings";
            // 
            // SettingsPanelSideBanner
            // 
            this.SettingsPanelSideBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.SettingsPanelSideBanner.Controls.Add(this.SettingsButtonReportPage);
            this.SettingsPanelSideBanner.Controls.Add(this.SettingsButtonHousesPage);
            this.SettingsPanelSideBanner.Controls.Add(this.SettingsButtonAppartmentsPage);
            this.SettingsPanelSideBanner.Controls.Add(this.SettingsButtonHomePage);
            this.SettingsPanelSideBanner.Location = new System.Drawing.Point(3, 0);
            this.SettingsPanelSideBanner.Name = "SettingsPanelSideBanner";
            this.SettingsPanelSideBanner.Size = new System.Drawing.Size(150, 635);
            this.SettingsPanelSideBanner.TabIndex = 0;
            // 
            // SettingsButtonReportPage
            // 
            this.SettingsButtonReportPage.Location = new System.Drawing.Point(5, 481);
            this.SettingsButtonReportPage.Name = "SettingsButtonReportPage";
            this.SettingsButtonReportPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonReportPage.TabIndex = 3;
            this.SettingsButtonReportPage.Text = "Report";
            this.SettingsButtonReportPage.UseVisualStyleBackColor = true;
            this.SettingsButtonReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // SettingsButtonHousesPage
            // 
            this.SettingsButtonHousesPage.Location = new System.Drawing.Point(5, 327);
            this.SettingsButtonHousesPage.Name = "SettingsButtonHousesPage";
            this.SettingsButtonHousesPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonHousesPage.TabIndex = 2;
            this.SettingsButtonHousesPage.Text = "Houses";
            this.SettingsButtonHousesPage.UseVisualStyleBackColor = true;
            this.SettingsButtonHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // SettingsButtonAppartmentsPage
            // 
            this.SettingsButtonAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.SettingsButtonAppartmentsPage.Name = "SettingsButtonAppartmentsPage";
            this.SettingsButtonAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonAppartmentsPage.TabIndex = 1;
            this.SettingsButtonAppartmentsPage.Text = "Appartments";
            this.SettingsButtonAppartmentsPage.UseVisualStyleBackColor = true;
            this.SettingsButtonAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // SettingsButtonHomePage
            // 
            this.SettingsButtonHomePage.Location = new System.Drawing.Point(5, 10);
            this.SettingsButtonHomePage.Name = "SettingsButtonHomePage";
            this.SettingsButtonHomePage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonHomePage.TabIndex = 0;
            this.SettingsButtonHomePage.Text = "Home";
            this.SettingsButtonHomePage.UseVisualStyleBackColor = true;
            this.SettingsButtonHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plotView1.Location = new System.Drawing.Point(447, 4);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(617, 255);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "MainPlotView";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView4
            // 
            this.plotView4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plotView4.Location = new System.Drawing.Point(864, 265);
            this.plotView4.Name = "plotView4";
            this.plotView4.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView4.Size = new System.Drawing.Size(200, 200);
            this.plotView4.TabIndex = 3;
            this.plotView4.Text = "PieThreePlotView";
            this.plotView4.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView4.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView4.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plotView2.Location = new System.Drawing.Point(656, 265);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(200, 200);
            this.plotView2.TabIndex = 4;
            this.plotView2.Text = "PieTwoPlotView";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView3
            // 
            this.plotView3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plotView3.Location = new System.Drawing.Point(447, 265);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(200, 200);
            this.plotView3.TabIndex = 5;
            this.plotView3.Text = "PieOnePlotView";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainWindowMaterialTabControler);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ReportPanelTopBanner.ResumeLayout(false);
            this.ReportPanelTopBanner.PerformLayout();
            this.ReportPanelSideBanner.ResumeLayout(false);
            this.HousesPage.ResumeLayout(false);
            this.HousesPanelTopBanner.ResumeLayout(false);
            this.HousesPanelTopBanner.PerformLayout();
            this.HousesPanelSideBanner.ResumeLayout(false);
            this.AppartmentsPage.ResumeLayout(false);
            this.AppartmentsPage.PerformLayout();
            this.AppartmentsPanel.ResumeLayout(false);
            this.AppartmentsPanelTopBanner.ResumeLayout(false);
            this.AppartmentsPanelTopBanner.PerformLayout();
            this.AppartmentsPanelSideBanner.ResumeLayout(false);
            this.HomePageTab.ResumeLayout(false);
            this.HomePageTitlePanel.ResumeLayout(false);
            this.HomePageTitlePanel.PerformLayout();
            this.HomePageButtonPanel.ResumeLayout(false);
            this.MainWindowMaterialTabControler.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPanelTopBanner.ResumeLayout(false);
            this.SettingsPanelTopBanner.PerformLayout();
            this.SettingsPanelSideBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.BindingSource appartmentDatabaseDataSetBindingSource;
        private DataSet1 dataSet;
        private TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private Panel ReportPanelTopBanner;
        private Button ReportButtonSettings;
        private Panel panel11;
        private Label ReportLablaTitle;
        private Panel ReportPanelSideBanner;
        private Button ReportButtonReportPage;
        private Button ReportButtonHousesPage;
        private Button ReportButtonAppartmentsPage;
        private Button ReportButtonHomePage;
        private TabPage HousesPage;
        private Panel HousesPanel;
        private Panel HousesPanelTopBanner;
        private Button HousesButtonsSettingsPage;
        private Panel panel7;
        private Label HousesLableTitle;
        private Panel HousesPanelSideBanner;
        private Button HousesButtonsReportPage;
        private Button HousesButtonsHousesPage;
        private Button HousesButtonsAppartmentsPage;
        private Button HousesButtonsHomePage;
        private TabPage AppartmentsPage;
        private Panel AppartmentsPanel;
        private Panel AppartmentsPanelTopBanner;
        private Button AppartmentsButtonsSettingsPage;
        private Panel panel3;
        private Label AppartmentsLableTitle;
        private Panel AppartmentsPanelSideBanner;
        private Button AppartmentsButtonsReportPage;
        private Button AppartmentsButtonsHousesPage;
        private Button AppartmentsButtonsAppartmentsPage;
        private Button AppartmentsButtonsHomePage;
        private TabPage HomePageTab;
        private Panel HomePagePanel2;
        private Panel HomePageTitlePanel;
        private Button HomePageSettingsButton;
        private Panel HomePagePanel;
        private Label HomePageTitleLabel;
        private Panel HomePageButtonPanel;
        private Button HomePageButtonReport;
        private Button HomePageButtonHouses;
        private Button HomePageButtonAppartments;
        private Button HomePageButtonHome;
        private MaterialSkin.Controls.MaterialTabControl MainWindowMaterialTabControler;
        private TabPage SettingsPage;
        private Panel SettingsPanelTopBanner;
        private Panel panel2;
        private Label SettingsLabelTitle;
        private Panel SettingsPanelSideBanner;
        private Button SettingsButtonReportPage;
        private Button SettingsButtonHousesPage;
        private Button SettingsButtonAppartmentsPage;
        private Button SettingsButtonHomePage;
        private Panel SettingsPanel;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView4;
    }
}

