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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.appartmentDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CIS_129_Final.DataSet1();
            this.ReportPage = new System.Windows.Forms.TabPage();
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
            this.PieOnePlotView = new OxyPlot.WindowsForms.PlotView();
            this.PieTwoPlotView = new OxyPlot.WindowsForms.PlotView();
            this.PieThreePlotView = new OxyPlot.WindowsForms.PlotView();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
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
            this.SettingsExplaneTextBox = new System.Windows.Forms.TextBox();
            this.SettingsIconPanel = new System.Windows.Forms.Panel();
            this.ReportIconPanel = new System.Windows.Forms.Panel();
            this.HousesIconPanel = new System.Windows.Forms.Panel();
            this.AppartmentsIconPanel = new System.Windows.Forms.Panel();
            this.ReportsExplaneTextBox = new System.Windows.Forms.TextBox();
            this.HousesExplaneTextBox = new System.Windows.Forms.TextBox();
            this.AppartmentsExplaneTextBox = new System.Windows.Forms.TextBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.HomePagePanelTopBanner = new System.Windows.Forms.Panel();
            this.HomePageSettingsButton = new System.Windows.Forms.Button();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.HomePageTitleLabel = new System.Windows.Forms.Label();
            this.HomePagePanelSideBanner = new System.Windows.Forms.Panel();
            this.HomePageButtonReport = new System.Windows.Forms.Button();
            this.HomePageButtonHouses = new System.Windows.Forms.Button();
            this.HomePageButtonAppartments = new System.Windows.Forms.Button();
            this.HomePageButtonHome = new System.Windows.Forms.Button();
            this.MainWindowMaterialTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.MenueColorInfoLabel = new System.Windows.Forms.Label();
            this.MenueColorConfermButton = new System.Windows.Forms.Button();
            this.MenueColorCodeDisplay = new System.Windows.Forms.Label();
            this.MenueBlueMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.MenueGreenMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.MenueRedMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.MenueColorPreviewPanel = new System.Windows.Forms.Panel();
            this.WindowColorInfoLabel = new System.Windows.Forms.Label();
            this.WindowColorConfermButton = new System.Windows.Forms.Button();
            this.WindowColorCodeDisplay = new System.Windows.Forms.Label();
            this.WindowBlueMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.WindowGreenMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.WindowRedMaterialSlider = new MaterialSkin.Controls.MaterialSlider();
            this.WindowColorPreviewPanel = new System.Windows.Forms.Panel();
            this.SettingsPanelTopBanner = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsLabelTitle = new System.Windows.Forms.Label();
            this.SettingsPanelSideBanner = new System.Windows.Forms.Panel();
            this.SettingsButtonReportPage = new System.Windows.Forms.Button();
            this.SettingsButtonHousesPage = new System.Windows.Forms.Button();
            this.SettingsButtonAppartmentsPage = new System.Windows.Forms.Button();
            this.SettingsButtonHomePage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.ReportPage.SuspendLayout();
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
            this.HomePagePanel2.SuspendLayout();
            this.HomePagePanelTopBanner.SuspendLayout();
            this.HomePagePanelSideBanner.SuspendLayout();
            this.MainWindowMaterialTabControler.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
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
            // ReportPage
            // 
            this.ReportPage.BackColor = System.Drawing.Color.Silver;
            this.ReportPage.Controls.Add(this.ReportViewer);
            this.ReportPage.Controls.Add(this.ReportPanelTopBanner);
            this.ReportPage.Controls.Add(this.ReportPanelSideBanner);
            this.ReportPage.Location = new System.Drawing.Point(4, 22);
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportPage.Size = new System.Drawing.Size(1232, 631);
            this.ReportPage.TabIndex = 10;
            this.ReportPage.Text = "Report";
            // 
            // ReportViewer
            // 
            this.ReportViewer.BackColor = System.Drawing.Color.Silver;
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
            this.ReportButtonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReportButtonSettings.BackgroundImage")));
            this.ReportButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButtonSettings.Location = new System.Drawing.Point(933, 10);
            this.ReportButtonSettings.Name = "ReportButtonSettings";
            this.ReportButtonSettings.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonSettings.TabIndex = 4;
            this.ReportButtonSettings.UseVisualStyleBackColor = false;
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
            this.ReportButtonReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.ReportButtonReportPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButtonReportPage.Location = new System.Drawing.Point(5, 481);
            this.ReportButtonReportPage.Name = "ReportButtonReportPage";
            this.ReportButtonReportPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonReportPage.TabIndex = 3;
            this.ReportButtonReportPage.UseVisualStyleBackColor = false;
            this.ReportButtonReportPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // ReportButtonHousesPage
            // 
            this.ReportButtonHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.ReportButtonHousesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButtonHousesPage.Location = new System.Drawing.Point(5, 327);
            this.ReportButtonHousesPage.Name = "ReportButtonHousesPage";
            this.ReportButtonHousesPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonHousesPage.TabIndex = 2;
            this.ReportButtonHousesPage.UseVisualStyleBackColor = false;
            this.ReportButtonHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // ReportButtonAppartmentsPage
            // 
            this.ReportButtonAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.ReportButtonAppartmentsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButtonAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.ReportButtonAppartmentsPage.Name = "ReportButtonAppartmentsPage";
            this.ReportButtonAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonAppartmentsPage.TabIndex = 1;
            this.ReportButtonAppartmentsPage.UseVisualStyleBackColor = false;
            this.ReportButtonAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // ReportButtonHomePage
            // 
            this.ReportButtonHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            this.ReportButtonHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButtonHomePage.Location = new System.Drawing.Point(5, 10);
            this.ReportButtonHomePage.Name = "ReportButtonHomePage";
            this.ReportButtonHomePage.Size = new System.Drawing.Size(140, 140);
            this.ReportButtonHomePage.TabIndex = 0;
            this.ReportButtonHomePage.UseVisualStyleBackColor = false;
            this.ReportButtonHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // HousesPage
            // 
            this.HousesPage.BackColor = System.Drawing.Color.Silver;
            this.HousesPage.Controls.Add(this.HousesPanel);
            this.HousesPage.Controls.Add(this.HousesPanelTopBanner);
            this.HousesPage.Controls.Add(this.HousesPanelSideBanner);
            this.HousesPage.Location = new System.Drawing.Point(4, 22);
            this.HousesPage.Name = "HousesPage";
            this.HousesPage.Padding = new System.Windows.Forms.Padding(3);
            this.HousesPage.Size = new System.Drawing.Size(1232, 631);
            this.HousesPage.TabIndex = 9;
            this.HousesPage.Text = "Houses";
            // 
            // HousesPanel
            // 
            this.HousesPanel.Location = new System.Drawing.Point(159, 160);
            this.HousesPanel.Name = "HousesPanel";
            this.HousesPanel.Size = new System.Drawing.Size(1070, 471);
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
            this.HousesButtonsSettingsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HousesButtonsSettingsPage.BackgroundImage")));
            this.HousesButtonsSettingsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesButtonsSettingsPage.Location = new System.Drawing.Point(933, 10);
            this.HousesButtonsSettingsPage.Name = "HousesButtonsSettingsPage";
            this.HousesButtonsSettingsPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsSettingsPage.TabIndex = 4;
            this.HousesButtonsSettingsPage.UseVisualStyleBackColor = false;
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
            this.HousesButtonsReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.HousesButtonsReportPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesButtonsReportPage.Location = new System.Drawing.Point(5, 481);
            this.HousesButtonsReportPage.Name = "HousesButtonsReportPage";
            this.HousesButtonsReportPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsReportPage.TabIndex = 3;
            this.HousesButtonsReportPage.UseVisualStyleBackColor = false;
            this.HousesButtonsReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // HousesButtonsHousesPage
            // 
            this.HousesButtonsHousesPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesButtonsHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.HousesButtonsHousesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesButtonsHousesPage.Location = new System.Drawing.Point(5, 327);
            this.HousesButtonsHousesPage.Name = "HousesButtonsHousesPage";
            this.HousesButtonsHousesPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsHousesPage.TabIndex = 2;
            this.HousesButtonsHousesPage.UseVisualStyleBackColor = false;
            this.HousesButtonsHousesPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // HousesButtonsAppartmentsPage
            // 
            this.HousesButtonsAppartmentsPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesButtonsAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.HousesButtonsAppartmentsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesButtonsAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.HousesButtonsAppartmentsPage.Name = "HousesButtonsAppartmentsPage";
            this.HousesButtonsAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsAppartmentsPage.TabIndex = 1;
            this.HousesButtonsAppartmentsPage.UseVisualStyleBackColor = false;
            this.HousesButtonsAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HousesButtonsHomePage
            // 
            this.HousesButtonsHomePage.BackColor = System.Drawing.Color.RoyalBlue;
            this.HousesButtonsHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            this.HousesButtonsHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesButtonsHomePage.Location = new System.Drawing.Point(5, 10);
            this.HousesButtonsHomePage.Name = "HousesButtonsHomePage";
            this.HousesButtonsHomePage.Size = new System.Drawing.Size(140, 140);
            this.HousesButtonsHomePage.TabIndex = 0;
            this.HousesButtonsHomePage.UseVisualStyleBackColor = false;
            this.HousesButtonsHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // AppartmentsPage
            // 
            this.AppartmentsPage.BackColor = System.Drawing.Color.Silver;
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanel);
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanelTopBanner);
            this.AppartmentsPage.Controls.Add(this.AppartmentsPanelSideBanner);
            this.AppartmentsPage.Location = new System.Drawing.Point(4, 22);
            this.AppartmentsPage.Name = "AppartmentsPage";
            this.AppartmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppartmentsPage.Size = new System.Drawing.Size(1232, 631);
            this.AppartmentsPage.TabIndex = 8;
            this.AppartmentsPage.Text = "Appartments";
            // 
            // AppartmentsPanel
            // 
            this.AppartmentsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppartmentsPanel.AutoScrollMargin = new System.Drawing.Size(10, 245);
            this.AppartmentsPanel.AutoSize = true;
            this.AppartmentsPanel.BackColor = System.Drawing.Color.Transparent;
            this.AppartmentsPanel.Controls.Add(this.PieOnePlotView);
            this.AppartmentsPanel.Controls.Add(this.PieTwoPlotView);
            this.AppartmentsPanel.Controls.Add(this.PieThreePlotView);
            this.AppartmentsPanel.Controls.Add(this.plotView1);
            this.AppartmentsPanel.Location = new System.Drawing.Point(156, 160);
            this.AppartmentsPanel.Name = "AppartmentsPanel";
            this.AppartmentsPanel.Size = new System.Drawing.Size(1070, 461);
            this.AppartmentsPanel.TabIndex = 3;
            // 
            // PieOnePlotView
            // 
            this.PieOnePlotView.BackColor = System.Drawing.Color.DarkGray;
            this.PieOnePlotView.Location = new System.Drawing.Point(3, 4);
            this.PieOnePlotView.Name = "PieOnePlotView";
            this.PieOnePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PieOnePlotView.Size = new System.Drawing.Size(300, 248);
            this.PieOnePlotView.TabIndex = 5;
            this.PieOnePlotView.Text = "PieOnePlotView";
            this.PieOnePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PieOnePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PieOnePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // PieTwoPlotView
            // 
            this.PieTwoPlotView.BackColor = System.Drawing.Color.DarkGray;
            this.PieTwoPlotView.Location = new System.Drawing.Point(395, 4);
            this.PieTwoPlotView.Name = "PieTwoPlotView";
            this.PieTwoPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PieTwoPlotView.Size = new System.Drawing.Size(300, 248);
            this.PieTwoPlotView.TabIndex = 4;
            this.PieTwoPlotView.Text = "PieTwoPlotView";
            this.PieTwoPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PieTwoPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PieTwoPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // PieThreePlotView
            // 
            this.PieThreePlotView.BackColor = System.Drawing.Color.DarkGray;
            this.PieThreePlotView.Location = new System.Drawing.Point(767, 0);
            this.PieThreePlotView.Name = "PieThreePlotView";
            this.PieThreePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PieThreePlotView.Size = new System.Drawing.Size(300, 248);
            this.PieThreePlotView.TabIndex = 3;
            this.PieThreePlotView.Text = "PieThreePlotView";
            this.PieThreePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PieThreePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PieThreePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.DarkGray;
            this.plotView1.Location = new System.Drawing.Point(3, 257);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1064, 200);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "MainPlotView";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
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
            this.AppartmentsButtonsSettingsPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsButtonsSettingsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppartmentsButtonsSettingsPage.BackgroundImage")));
            this.AppartmentsButtonsSettingsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsButtonsSettingsPage.Location = new System.Drawing.Point(933, 10);
            this.AppartmentsButtonsSettingsPage.Name = "AppartmentsButtonsSettingsPage";
            this.AppartmentsButtonsSettingsPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsSettingsPage.TabIndex = 4;
            this.AppartmentsButtonsSettingsPage.UseVisualStyleBackColor = false;
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
            this.AppartmentsButtonsReportPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsButtonsReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.AppartmentsButtonsReportPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsButtonsReportPage.Location = new System.Drawing.Point(5, 481);
            this.AppartmentsButtonsReportPage.Name = "AppartmentsButtonsReportPage";
            this.AppartmentsButtonsReportPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsReportPage.TabIndex = 3;
            this.AppartmentsButtonsReportPage.UseVisualStyleBackColor = false;
            this.AppartmentsButtonsReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // AppartmentsButtonsHousesPage
            // 
            this.AppartmentsButtonsHousesPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsButtonsHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.AppartmentsButtonsHousesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsButtonsHousesPage.Location = new System.Drawing.Point(5, 327);
            this.AppartmentsButtonsHousesPage.Name = "AppartmentsButtonsHousesPage";
            this.AppartmentsButtonsHousesPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsHousesPage.TabIndex = 2;
            this.AppartmentsButtonsHousesPage.UseVisualStyleBackColor = false;
            this.AppartmentsButtonsHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // AppartmentsButtonsAppartmentsPage
            // 
            this.AppartmentsButtonsAppartmentsPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsButtonsAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.AppartmentsButtonsAppartmentsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsButtonsAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.AppartmentsButtonsAppartmentsPage.Name = "AppartmentsButtonsAppartmentsPage";
            this.AppartmentsButtonsAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsAppartmentsPage.TabIndex = 1;
            this.AppartmentsButtonsAppartmentsPage.UseVisualStyleBackColor = false;
            this.AppartmentsButtonsAppartmentsPage.Click += new System.EventHandler(this.GoToNothing);
            // 
            // AppartmentsButtonsHomePage
            // 
            this.AppartmentsButtonsHomePage.BackColor = System.Drawing.Color.RoyalBlue;
            this.AppartmentsButtonsHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            this.AppartmentsButtonsHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsButtonsHomePage.Location = new System.Drawing.Point(5, 10);
            this.AppartmentsButtonsHomePage.Name = "AppartmentsButtonsHomePage";
            this.AppartmentsButtonsHomePage.Size = new System.Drawing.Size(140, 140);
            this.AppartmentsButtonsHomePage.TabIndex = 0;
            this.AppartmentsButtonsHomePage.UseVisualStyleBackColor = false;
            this.AppartmentsButtonsHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // HomePageTab
            // 
            this.HomePageTab.BackColor = System.Drawing.Color.Silver;
            this.HomePageTab.Controls.Add(this.HomePagePanel2);
            this.HomePageTab.Controls.Add(this.HomePagePanelTopBanner);
            this.HomePageTab.Controls.Add(this.HomePagePanelSideBanner);
            this.HomePageTab.Location = new System.Drawing.Point(4, 22);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomePageTab.Size = new System.Drawing.Size(1232, 631);
            this.HomePageTab.TabIndex = 4;
            this.HomePageTab.Text = "StartMenue";
            // 
            // HomePagePanel2
            // 
            this.HomePagePanel2.Controls.Add(this.SettingsExplaneTextBox);
            this.HomePagePanel2.Controls.Add(this.SettingsIconPanel);
            this.HomePagePanel2.Controls.Add(this.ReportIconPanel);
            this.HomePagePanel2.Controls.Add(this.HousesIconPanel);
            this.HomePagePanel2.Controls.Add(this.AppartmentsIconPanel);
            this.HomePagePanel2.Controls.Add(this.ReportsExplaneTextBox);
            this.HomePagePanel2.Controls.Add(this.HousesExplaneTextBox);
            this.HomePagePanel2.Controls.Add(this.AppartmentsExplaneTextBox);
            this.HomePagePanel2.Controls.Add(this.IntroLabel);
            this.HomePagePanel2.Location = new System.Drawing.Point(159, 160);
            this.HomePagePanel2.Name = "HomePagePanel2";
            this.HomePagePanel2.Size = new System.Drawing.Size(1035, 471);
            this.HomePagePanel2.TabIndex = 3;
            // 
            // SettingsExplaneTextBox
            // 
            this.SettingsExplaneTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SettingsExplaneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsExplaneTextBox.Location = new System.Drawing.Point(127, 361);
            this.SettingsExplaneTextBox.Multiline = true;
            this.SettingsExplaneTextBox.Name = "SettingsExplaneTextBox";
            this.SettingsExplaneTextBox.Size = new System.Drawing.Size(877, 100);
            this.SettingsExplaneTextBox.TabIndex = 8;
            this.SettingsExplaneTextBox.Text = "The Settings page, marked by this Gear icon, is where you can go to customize the" +
    " colors of this application for your viewing pleasure.";
            // 
            // SettingsIconPanel
            // 
            this.SettingsIconPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsIconPanel.BackgroundImage")));
            this.SettingsIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsIconPanel.Location = new System.Drawing.Point(21, 361);
            this.SettingsIconPanel.Name = "SettingsIconPanel";
            this.SettingsIconPanel.Size = new System.Drawing.Size(100, 100);
            this.SettingsIconPanel.TabIndex = 7;
            // 
            // ReportIconPanel
            // 
            this.ReportIconPanel.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.ReportIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportIconPanel.Location = new System.Drawing.Point(21, 256);
            this.ReportIconPanel.Name = "ReportIconPanel";
            this.ReportIconPanel.Size = new System.Drawing.Size(100, 100);
            this.ReportIconPanel.TabIndex = 6;
            // 
            // HousesIconPanel
            // 
            this.HousesIconPanel.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.HousesIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HousesIconPanel.Location = new System.Drawing.Point(21, 150);
            this.HousesIconPanel.Name = "HousesIconPanel";
            this.HousesIconPanel.Size = new System.Drawing.Size(100, 100);
            this.HousesIconPanel.TabIndex = 5;
            // 
            // AppartmentsIconPanel
            // 
            this.AppartmentsIconPanel.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.AppartmentsIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppartmentsIconPanel.Location = new System.Drawing.Point(21, 44);
            this.AppartmentsIconPanel.Name = "AppartmentsIconPanel";
            this.AppartmentsIconPanel.Size = new System.Drawing.Size(100, 100);
            this.AppartmentsIconPanel.TabIndex = 4;
            // 
            // ReportsExplaneTextBox
            // 
            this.ReportsExplaneTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ReportsExplaneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsExplaneTextBox.Location = new System.Drawing.Point(127, 256);
            this.ReportsExplaneTextBox.Multiline = true;
            this.ReportsExplaneTextBox.Name = "ReportsExplaneTextBox";
            this.ReportsExplaneTextBox.Size = new System.Drawing.Size(877, 100);
            this.ReportsExplaneTextBox.TabIndex = 3;
            this.ReportsExplaneTextBox.Text = "The Report page, marked by this % file icon, Is where you can get a full report b" +
    "ased on the data in this program.";
            // 
            // HousesExplaneTextBox
            // 
            this.HousesExplaneTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HousesExplaneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousesExplaneTextBox.Location = new System.Drawing.Point(127, 150);
            this.HousesExplaneTextBox.Multiline = true;
            this.HousesExplaneTextBox.Name = "HousesExplaneTextBox";
            this.HousesExplaneTextBox.Size = new System.Drawing.Size(877, 100);
            this.HousesExplaneTextBox.TabIndex = 2;
            this.HousesExplaneTextBox.Text = "The Houses page, marked by this house icon, will show data specific to Houses.";
            // 
            // AppartmentsExplaneTextBox
            // 
            this.AppartmentsExplaneTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AppartmentsExplaneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppartmentsExplaneTextBox.Location = new System.Drawing.Point(127, 44);
            this.AppartmentsExplaneTextBox.Multiline = true;
            this.AppartmentsExplaneTextBox.Name = "AppartmentsExplaneTextBox";
            this.AppartmentsExplaneTextBox.Size = new System.Drawing.Size(877, 100);
            this.AppartmentsExplaneTextBox.TabIndex = 1;
            this.AppartmentsExplaneTextBox.Text = "The Appartments page, marked by this multi storey building icon, will show data s" +
    "pecific to apartments.";
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroLabel.Location = new System.Drawing.Point(15, 4);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(883, 31);
            this.IntroLabel.TabIndex = 0;
            this.IntroLabel.Text = "This aplication keeps track of [Insert city name here] power consumption";
            // 
            // HomePagePanelTopBanner
            // 
            this.HomePagePanelTopBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePagePanelTopBanner.Controls.Add(this.HomePageSettingsButton);
            this.HomePagePanelTopBanner.Controls.Add(this.HomePagePanel);
            this.HomePagePanelTopBanner.Controls.Add(this.HomePageTitleLabel);
            this.HomePagePanelTopBanner.Location = new System.Drawing.Point(153, 0);
            this.HomePagePanelTopBanner.Name = "HomePagePanelTopBanner";
            this.HomePagePanelTopBanner.Size = new System.Drawing.Size(1079, 154);
            this.HomePagePanelTopBanner.TabIndex = 1;
            // 
            // HomePageSettingsButton
            // 
            this.HomePageSettingsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePageSettingsButton.BackgroundImage")));
            this.HomePageSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePageSettingsButton.Location = new System.Drawing.Point(933, 10);
            this.HomePageSettingsButton.Name = "HomePageSettingsButton";
            this.HomePageSettingsButton.Size = new System.Drawing.Size(140, 140);
            this.HomePageSettingsButton.TabIndex = 4;
            this.HomePageSettingsButton.UseVisualStyleBackColor = false;
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
            // HomePagePanelSideBanner
            // 
            this.HomePagePanelSideBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePagePanelSideBanner.Controls.Add(this.HomePageButtonReport);
            this.HomePagePanelSideBanner.Controls.Add(this.HomePageButtonHouses);
            this.HomePagePanelSideBanner.Controls.Add(this.HomePageButtonAppartments);
            this.HomePagePanelSideBanner.Controls.Add(this.HomePageButtonHome);
            this.HomePagePanelSideBanner.Location = new System.Drawing.Point(3, 0);
            this.HomePagePanelSideBanner.Name = "HomePagePanelSideBanner";
            this.HomePagePanelSideBanner.Size = new System.Drawing.Size(150, 635);
            this.HomePagePanelSideBanner.TabIndex = 0;
            // 
            // HomePageButtonReport
            // 
            this.HomePageButtonReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageButtonReport.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.HomePageButtonReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePageButtonReport.Location = new System.Drawing.Point(5, 481);
            this.HomePageButtonReport.Name = "HomePageButtonReport";
            this.HomePageButtonReport.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonReport.TabIndex = 3;
            this.HomePageButtonReport.UseVisualStyleBackColor = false;
            this.HomePageButtonReport.Click += new System.EventHandler(this.GoToReport);
            // 
            // HomePageButtonHouses
            // 
            this.HomePageButtonHouses.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageButtonHouses.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.HomePageButtonHouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePageButtonHouses.Location = new System.Drawing.Point(5, 327);
            this.HomePageButtonHouses.Name = "HomePageButtonHouses";
            this.HomePageButtonHouses.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonHouses.TabIndex = 2;
            this.HomePageButtonHouses.UseVisualStyleBackColor = false;
            this.HomePageButtonHouses.Click += new System.EventHandler(this.GoToHouses);
            // 
            // HomePageButtonAppartments
            // 
            this.HomePageButtonAppartments.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageButtonAppartments.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.HomePageButtonAppartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePageButtonAppartments.Location = new System.Drawing.Point(5, 164);
            this.HomePageButtonAppartments.Name = "HomePageButtonAppartments";
            this.HomePageButtonAppartments.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonAppartments.TabIndex = 1;
            this.HomePageButtonAppartments.UseVisualStyleBackColor = false;
            this.HomePageButtonAppartments.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // HomePageButtonHome
            // 
            this.HomePageButtonHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePageButtonHome.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            this.HomePageButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePageButtonHome.Location = new System.Drawing.Point(5, 10);
            this.HomePageButtonHome.Name = "HomePageButtonHome";
            this.HomePageButtonHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HomePageButtonHome.Size = new System.Drawing.Size(140, 140);
            this.HomePageButtonHome.TabIndex = 0;
            this.HomePageButtonHome.UseVisualStyleBackColor = false;
            this.HomePageButtonHome.Click += new System.EventHandler(this.GoToNothing);
            // 
            // MainWindowMaterialTabControler
            // 
            this.MainWindowMaterialTabControler.Controls.Add(this.HomePageTab);
            this.MainWindowMaterialTabControler.Controls.Add(this.AppartmentsPage);
            this.MainWindowMaterialTabControler.Controls.Add(this.HousesPage);
            this.MainWindowMaterialTabControler.Controls.Add(this.ReportPage);
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
            this.SettingsPage.BackColor = System.Drawing.Color.Silver;
            this.SettingsPage.Controls.Add(this.SettingsPanel);
            this.SettingsPage.Controls.Add(this.SettingsPanelTopBanner);
            this.SettingsPage.Controls.Add(this.SettingsPanelSideBanner);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(1232, 631);
            this.SettingsPage.TabIndex = 11;
            this.SettingsPage.Text = "Settings";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.MenueColorInfoLabel);
            this.SettingsPanel.Controls.Add(this.MenueColorConfermButton);
            this.SettingsPanel.Controls.Add(this.MenueColorCodeDisplay);
            this.SettingsPanel.Controls.Add(this.MenueBlueMaterialSlider);
            this.SettingsPanel.Controls.Add(this.MenueGreenMaterialSlider);
            this.SettingsPanel.Controls.Add(this.MenueRedMaterialSlider);
            this.SettingsPanel.Controls.Add(this.MenueColorPreviewPanel);
            this.SettingsPanel.Controls.Add(this.WindowColorInfoLabel);
            this.SettingsPanel.Controls.Add(this.WindowColorConfermButton);
            this.SettingsPanel.Controls.Add(this.WindowColorCodeDisplay);
            this.SettingsPanel.Controls.Add(this.WindowBlueMaterialSlider);
            this.SettingsPanel.Controls.Add(this.WindowGreenMaterialSlider);
            this.SettingsPanel.Controls.Add(this.WindowRedMaterialSlider);
            this.SettingsPanel.Controls.Add(this.WindowColorPreviewPanel);
            this.SettingsPanel.Location = new System.Drawing.Point(156, 159);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1073, 471);
            this.SettingsPanel.TabIndex = 4;
            // 
            // MenueColorInfoLabel
            // 
            this.MenueColorInfoLabel.AutoSize = true;
            this.MenueColorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenueColorInfoLabel.Location = new System.Drawing.Point(486, 5);
            this.MenueColorInfoLabel.Name = "MenueColorInfoLabel";
            this.MenueColorInfoLabel.Size = new System.Drawing.Size(427, 31);
            this.MenueColorInfoLabel.TabIndex = 15;
            this.MenueColorInfoLabel.Text = "Menue Background Color Selector";
            // 
            // MenueColorConfermButton
            // 
            this.MenueColorConfermButton.BackColor = System.Drawing.Color.Transparent;
            this.MenueColorConfermButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenueColorConfermButton.Location = new System.Drawing.Point(492, 205);
            this.MenueColorConfermButton.Name = "MenueColorConfermButton";
            this.MenueColorConfermButton.Size = new System.Drawing.Size(398, 90);
            this.MenueColorConfermButton.TabIndex = 14;
            this.MenueColorConfermButton.Text = "Conferm Selection";
            this.MenueColorConfermButton.UseVisualStyleBackColor = false;
            this.MenueColorConfermButton.Click += new System.EventHandler(this.MenueColorConfermButton_Click);
            // 
            // MenueColorCodeDisplay
            // 
            this.MenueColorCodeDisplay.AutoSize = true;
            this.MenueColorCodeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenueColorCodeDisplay.Location = new System.Drawing.Point(640, 57);
            this.MenueColorCodeDisplay.Name = "MenueColorCodeDisplay";
            this.MenueColorCodeDisplay.Size = new System.Drawing.Size(177, 31);
            this.MenueColorCodeDisplay.TabIndex = 13;
            this.MenueColorCodeDisplay.Text = "rgb{50,50,50}";
            // 
            // MenueBlueMaterialSlider
            // 
            this.MenueBlueMaterialSlider.Depth = 0;
            this.MenueBlueMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenueBlueMaterialSlider.Location = new System.Drawing.Point(640, 159);
            this.MenueBlueMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenueBlueMaterialSlider.Name = "MenueBlueMaterialSlider";
            this.MenueBlueMaterialSlider.RangeMax = 255;
            this.MenueBlueMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.MenueBlueMaterialSlider.TabIndex = 12;
            this.MenueBlueMaterialSlider.Text = "B";
            // 
            // MenueGreenMaterialSlider
            // 
            this.MenueGreenMaterialSlider.Depth = 0;
            this.MenueGreenMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenueGreenMaterialSlider.Location = new System.Drawing.Point(640, 127);
            this.MenueGreenMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenueGreenMaterialSlider.Name = "MenueGreenMaterialSlider";
            this.MenueGreenMaterialSlider.RangeMax = 255;
            this.MenueGreenMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.MenueGreenMaterialSlider.TabIndex = 11;
            this.MenueGreenMaterialSlider.Text = "G";
            // 
            // MenueRedMaterialSlider
            // 
            this.MenueRedMaterialSlider.Depth = 0;
            this.MenueRedMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenueRedMaterialSlider.Location = new System.Drawing.Point(640, 91);
            this.MenueRedMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenueRedMaterialSlider.Name = "MenueRedMaterialSlider";
            this.MenueRedMaterialSlider.RangeMax = 255;
            this.MenueRedMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.MenueRedMaterialSlider.TabIndex = 10;
            this.MenueRedMaterialSlider.Text = "R";
            // 
            // MenueColorPreviewPanel
            // 
            this.MenueColorPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenueColorPreviewPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenueColorPreviewPanel.Location = new System.Drawing.Point(492, 57);
            this.MenueColorPreviewPanel.Name = "MenueColorPreviewPanel";
            this.MenueColorPreviewPanel.Size = new System.Drawing.Size(142, 142);
            this.MenueColorPreviewPanel.TabIndex = 9;
            // 
            // WindowColorInfoLabel
            // 
            this.WindowColorInfoLabel.AutoSize = true;
            this.WindowColorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowColorInfoLabel.Location = new System.Drawing.Point(15, 5);
            this.WindowColorInfoLabel.Name = "WindowColorInfoLabel";
            this.WindowColorInfoLabel.Size = new System.Drawing.Size(441, 31);
            this.WindowColorInfoLabel.TabIndex = 8;
            this.WindowColorInfoLabel.Text = "Window Background Color Selector";
            // 
            // WindowColorConfermButton
            // 
            this.WindowColorConfermButton.BackColor = System.Drawing.Color.Transparent;
            this.WindowColorConfermButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowColorConfermButton.Location = new System.Drawing.Point(21, 205);
            this.WindowColorConfermButton.Name = "WindowColorConfermButton";
            this.WindowColorConfermButton.Size = new System.Drawing.Size(398, 90);
            this.WindowColorConfermButton.TabIndex = 7;
            this.WindowColorConfermButton.Text = "Conferm Selection";
            this.WindowColorConfermButton.UseVisualStyleBackColor = false;
            this.WindowColorConfermButton.Click += new System.EventHandler(this.ColorConfermButton_Click);
            // 
            // WindowColorCodeDisplay
            // 
            this.WindowColorCodeDisplay.AutoSize = true;
            this.WindowColorCodeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowColorCodeDisplay.Location = new System.Drawing.Point(169, 57);
            this.WindowColorCodeDisplay.Name = "WindowColorCodeDisplay";
            this.WindowColorCodeDisplay.Size = new System.Drawing.Size(177, 31);
            this.WindowColorCodeDisplay.TabIndex = 6;
            this.WindowColorCodeDisplay.Text = "rgb{50,50,50}";
            // 
            // WindowBlueMaterialSlider
            // 
            this.WindowBlueMaterialSlider.Depth = 0;
            this.WindowBlueMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WindowBlueMaterialSlider.Location = new System.Drawing.Point(169, 159);
            this.WindowBlueMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.WindowBlueMaterialSlider.Name = "WindowBlueMaterialSlider";
            this.WindowBlueMaterialSlider.RangeMax = 255;
            this.WindowBlueMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.WindowBlueMaterialSlider.TabIndex = 5;
            this.WindowBlueMaterialSlider.Text = "B";
            // 
            // WindowGreenMaterialSlider
            // 
            this.WindowGreenMaterialSlider.Depth = 0;
            this.WindowGreenMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WindowGreenMaterialSlider.Location = new System.Drawing.Point(169, 127);
            this.WindowGreenMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.WindowGreenMaterialSlider.Name = "WindowGreenMaterialSlider";
            this.WindowGreenMaterialSlider.RangeMax = 255;
            this.WindowGreenMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.WindowGreenMaterialSlider.TabIndex = 4;
            this.WindowGreenMaterialSlider.Text = "G";
            // 
            // WindowRedMaterialSlider
            // 
            this.WindowRedMaterialSlider.Depth = 0;
            this.WindowRedMaterialSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WindowRedMaterialSlider.Location = new System.Drawing.Point(169, 91);
            this.WindowRedMaterialSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.WindowRedMaterialSlider.Name = "WindowRedMaterialSlider";
            this.WindowRedMaterialSlider.RangeMax = 255;
            this.WindowRedMaterialSlider.Size = new System.Drawing.Size(250, 40);
            this.WindowRedMaterialSlider.TabIndex = 3;
            this.WindowRedMaterialSlider.Text = "R";
            // 
            // WindowColorPreviewPanel
            // 
            this.WindowColorPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WindowColorPreviewPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowColorPreviewPanel.Location = new System.Drawing.Point(21, 57);
            this.WindowColorPreviewPanel.Name = "WindowColorPreviewPanel";
            this.WindowColorPreviewPanel.Size = new System.Drawing.Size(142, 142);
            this.WindowColorPreviewPanel.TabIndex = 2;
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
            this.SettingsButtonReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            this.SettingsButtonReportPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonReportPage.Location = new System.Drawing.Point(5, 481);
            this.SettingsButtonReportPage.Name = "SettingsButtonReportPage";
            this.SettingsButtonReportPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonReportPage.TabIndex = 3;
            this.SettingsButtonReportPage.UseVisualStyleBackColor = false;
            this.SettingsButtonReportPage.Click += new System.EventHandler(this.GoToReport);
            // 
            // SettingsButtonHousesPage
            // 
            this.SettingsButtonHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            this.SettingsButtonHousesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonHousesPage.Location = new System.Drawing.Point(5, 327);
            this.SettingsButtonHousesPage.Name = "SettingsButtonHousesPage";
            this.SettingsButtonHousesPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonHousesPage.TabIndex = 2;
            this.SettingsButtonHousesPage.UseVisualStyleBackColor = false;
            this.SettingsButtonHousesPage.Click += new System.EventHandler(this.GoToHouses);
            // 
            // SettingsButtonAppartmentsPage
            // 
            this.SettingsButtonAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            this.SettingsButtonAppartmentsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonAppartmentsPage.Location = new System.Drawing.Point(5, 164);
            this.SettingsButtonAppartmentsPage.Name = "SettingsButtonAppartmentsPage";
            this.SettingsButtonAppartmentsPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SettingsButtonAppartmentsPage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonAppartmentsPage.TabIndex = 1;
            this.SettingsButtonAppartmentsPage.UseVisualStyleBackColor = false;
            this.SettingsButtonAppartmentsPage.Click += new System.EventHandler(this.GoToAppartmentsPage);
            // 
            // SettingsButtonHomePage
            // 
            this.SettingsButtonHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            this.SettingsButtonHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonHomePage.Location = new System.Drawing.Point(5, 10);
            this.SettingsButtonHomePage.Name = "SettingsButtonHomePage";
            this.SettingsButtonHomePage.Size = new System.Drawing.Size(140, 140);
            this.SettingsButtonHomePage.TabIndex = 0;
            this.SettingsButtonHomePage.UseVisualStyleBackColor = false;
            this.SettingsButtonHomePage.Click += new System.EventHandler(this.GoToHomePage);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainWindowMaterialTabControler);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ReportPage.ResumeLayout(false);
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
            this.HomePagePanel2.ResumeLayout(false);
            this.HomePagePanel2.PerformLayout();
            this.HomePagePanelTopBanner.ResumeLayout(false);
            this.HomePagePanelTopBanner.PerformLayout();
            this.HomePagePanelSideBanner.ResumeLayout(false);
            this.MainWindowMaterialTabControler.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.SettingsPanelTopBanner.ResumeLayout(false);
            this.SettingsPanelTopBanner.PerformLayout();
            this.SettingsPanelSideBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.BindingSource appartmentDatabaseDataSetBindingSource;
        private DataSet1 dataSet;
        private TabPage ReportPage;
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
        private Panel HomePagePanelTopBanner;
        private Button HomePageSettingsButton;
        private Panel HomePagePanel;
        private Label HomePageTitleLabel;
        private Panel HomePagePanelSideBanner;
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
        private OxyPlot.WindowsForms.PlotView PieOnePlotView;
        private OxyPlot.WindowsForms.PlotView PieTwoPlotView;
        private OxyPlot.WindowsForms.PlotView PieThreePlotView;
        private Label IntroLabel;
        private TextBox ReportsExplaneTextBox;
        private TextBox HousesExplaneTextBox;
        private TextBox AppartmentsExplaneTextBox;
        private Panel ReportIconPanel;
        private Panel HousesIconPanel;
        private Panel AppartmentsIconPanel;
        private TextBox SettingsExplaneTextBox;
        private Panel SettingsIconPanel;
        private MaterialSkin.Controls.MaterialSlider WindowBlueMaterialSlider;
        private MaterialSkin.Controls.MaterialSlider WindowGreenMaterialSlider;
        private MaterialSkin.Controls.MaterialSlider WindowRedMaterialSlider;
        private Panel WindowColorPreviewPanel;
        private Label WindowColorCodeDisplay;
        private Timer timer1;
        private Button WindowColorConfermButton;
        private Label MenueColorInfoLabel;
        private Button MenueColorConfermButton;
        private Label MenueColorCodeDisplay;
        private MaterialSkin.Controls.MaterialSlider MenueBlueMaterialSlider;
        private MaterialSkin.Controls.MaterialSlider MenueGreenMaterialSlider;
        private MaterialSkin.Controls.MaterialSlider MenueRedMaterialSlider;
        private Panel MenueColorPreviewPanel;
        private Label WindowColorInfoLabel;

        //Button
        /*
        SettingsButtonReportPage;
        SettingsButtonHousesPage;
        SettingsButtonAppartmentsPage;
        SettingsButtonHomePage;
        
        HomePageButtonReport;
        HomePageButtonHouses;
        HomePageButtonAppartments;
        HomePageButtonHome;
        HomePageSettingsButton;

        ReportButtonReportPage;
        ReportButtonHousesPage;
        ReportButtonAppartmentsPage;
        ReportButtonHomePage;
        ReportButtonSettings;

        HousesButtonsReportPage;
        HousesButtonsHousesPage;
        HousesButtonsAppartmentsPage;
        HousesButtonsHomePage;
        HousesButtonsSettingsPage;

        AppartmentsButtonsReportPage;
        AppartmentsButtonsHousesPage;
        AppartmentsButtonsAppartmentsPage;
        AppartmentsButtonsHomePage;
        AppartmentsButtonsSettingsPage;
        */
    }
}

