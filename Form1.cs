using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CIS_129_Final
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCharts();
            InitializeColorChoices();
            ButtonIconsFix();
        }

        private void ButtonIconsFix()
        {
            //Home Page Icon
            HomePageButtonHome.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            AppartmentsButtonsHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            HousesButtonsHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            ReportButtonHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;
            SettingsButtonHomePage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Home;

            //Appartments Page Icon
            HomePageButtonAppartments.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            AppartmentsButtonsAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            HousesButtonsAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            ReportButtonAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;
            SettingsButtonAppartmentsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Appartment;

            //Houses Page Icon
            HomePageButtonHouses.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            AppartmentsButtonsHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            HousesButtonsHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            ReportButtonHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;
            SettingsButtonHousesPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_House;

            //Reports Page Icon
            HomePageButtonReport.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            AppartmentsButtonsReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            HousesButtonsReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            ReportButtonReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;
            SettingsButtonReportPage.BackgroundImage = global::CIS_129_Final.Properties.Resources.Report_Icon;

            //Settings Page Icon
            HomePageSettingsButton.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Settings;
            AppartmentsButtonsSettingsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Settings;
            HousesButtonsSettingsPage.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Settings;
            ReportButtonSettings.BackgroundImage = global::CIS_129_Final.Properties.Resources._300X_Settings;
        }

        private void InitializeColorChoices() {
            List<String> Strings = new List<String>()
            {
                "Standard",
                "Light",
                "Dark",
                "High Contrast",
            };

            ColorTheamComboBox.DataSource = Strings;
        }

        private void InitializeCharts()
        {
            TEMP_AppartmentsPowerConsumption APT = new TEMP_AppartmentsPowerConsumption();

            dataSet = APT.TEMP_AppartmentsPowerConsumptionDataToDataSet(dataSet);

            InsertDataToReportViewer(ReportViewer, dataSet.Table1);

            plotView1.BackColor = ReportPage.BackColor;
            PieTwoPlotView.BackColor = ReportPage.BackColor;
            PieOnePlotView.BackColor = ReportPage.BackColor;
            PieThreePlotView.BackColor = ReportPage.BackColor;

            plotView1.Model = APT.AppartmentsPowerConsumptionColumnGraph(dataSet);
            PieTwoPlotView.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 1);
            PieOnePlotView.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 2);
            PieThreePlotView.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 3);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Window Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WindowColorCodeDisplay.Text = $"rgb(" +
                    $"{WindowRedMaterialSlider.Value}," +
                    $"{WindowGreenMaterialSlider.Value}," +
                    $"{WindowBlueMaterialSlider.Value})";

            WindowColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(
                255,
                WindowRedMaterialSlider.Value,
                WindowGreenMaterialSlider.Value,
                WindowBlueMaterialSlider.Value
            );
            //Window Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //Menu Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            MenueColorCodeDisplay.Text = $"rgb(" +
                    $"{MenueRedMaterialSlider.Value}," +
                    $"{MenueGreenMaterialSlider.Value}," +
                    $"{MenueBlueMaterialSlider.Value})";

            MenueColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(
                255,
                MenueRedMaterialSlider.Value,
                MenueGreenMaterialSlider.Value,
                MenueBlueMaterialSlider.Value
            );
            //Menu Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //Window Text Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WindowTextColorCodeDisplay.Text = $"rgb(" +
                    $"{WindowTextRedMaterialSlider.Value}," +
                    $"{WindowTextGreenMaterialSlider.Value}," +
                    $"{WindowTextBlueMaterialSlider.Value})";

            WindowTextColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(
                255,
                WindowTextRedMaterialSlider.Value,
                WindowTextGreenMaterialSlider.Value,
                WindowTextBlueMaterialSlider.Value
            );
            //Window Text Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //Menu Text Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            MenueTextColorCodeDisplay.Text = $"rgb(" +
                    $"{MenueTextRedMaterialSlider.Value}," +
                    $"{MenueTextGreenMaterialSlider.Value}," +
                    $"{MenueTextBlueMaterialSlider.Value})";

            MenueTextColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(
                255,
                MenueTextRedMaterialSlider.Value,
                MenueTextGreenMaterialSlider.Value,
                MenueTextBlueMaterialSlider.Value
            );
            //Menu Text Color~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }

        //Home Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToHomePage(object sender, EventArgs e)
        {
            MainWindowMaterialTabControler.SelectTab(0);
        }
        //Home Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Appartments Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToAppartmentsPage(object sender, EventArgs e)
        {
            MainWindowMaterialTabControler.SelectTab(1);
        }
        //Appartments Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Houses Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToHouses(object sender, EventArgs e)
        {
            MainWindowMaterialTabControler.SelectTab(2);
        }
        //Houses Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Report Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToReport(object sender, EventArgs e)
        {
            MainWindowMaterialTabControler.SelectTab(3);
        }
        //Report Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Settings Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToSettiongs(object sender, EventArgs e)
        {
            MainWindowMaterialTabControler.SelectTab(4);
        }
        //Settings Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //NULL Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToNothing(object sender, EventArgs e)
        {
            //this exists for the buttons that send you to the page you are on
            //having them basicly reload the page you are looking at sounds dumb
            //this is to not do that.
        }
        //NULL Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        //this function places data into the report viewer, it is temporary unless never fully made.
        void InsertDataToReportViewer(ReportViewer REPORTVIEWER, DataTable DATA)
        {
            Microsoft.Reporting.WinForms.ReportDataSource DataSourceInto = new Microsoft.Reporting.WinForms.ReportDataSource
            {
                Name = REPORTVIEWER.LocalReport.GetDataSourceNames()[0],
                Value = DATA
            };

            REPORTVIEWER.LocalReport.DataSources.Add(DataSourceInto);

            REPORTVIEWER.RefreshReport();
        }
        //this function places data into the report viewer, it is temporary unless never fully made.

        private void SetWindowColor(System.Drawing.Color color)
        {
            HomePageTab.BackColor = color;
            AppartmentsPage.BackColor = color;
            HousesPage.BackColor = color;
            ReportPage.BackColor = color;
            SettingsPage.BackColor = color;
            BackColor = color;

            plotView1.BackColor = color;
            PieTwoPlotView.BackColor = color;
            PieOnePlotView.BackColor = color;
            PieThreePlotView.BackColor = color;

            AppartmentsExplaneTextBox.BackColor = color;
            HousesExplaneTextBox.BackColor = color;
            ReportsExplaneTextBox.BackColor = color;
            SettingsExplaneTextBox.BackColor = color;
        }
        
        private void SetWindowTextColor(System.Drawing.Color color)
        {
            OxyColor Oxycolor = OxyColor.FromArgb(color.A, color.R, color.G, color.B);

            HomePageTab.ForeColor = color;
            AppartmentsPage.ForeColor = color;
            HousesPage.ForeColor = color;
            ReportPage.ForeColor = color;
            SettingsPage.ForeColor = color;
            ForeColor = color;

            AppartmentsExplaneTextBox.ForeColor = color;
            HousesExplaneTextBox.ForeColor = color;
            ReportsExplaneTextBox.ForeColor = color;
            SettingsExplaneTextBox.ForeColor = color;

            AppartmentsIconPanel.ForeColor = color;
            HousesIconPanel.ForeColor = color;
            ReportIconPanel.ForeColor = color;
            SettingsIconPanel.ForeColor = color;

            plotView1.Model.TextColor = Oxycolor;
            PieTwoPlotView.Model.TextColor = Oxycolor;
            PieOnePlotView.Model.TextColor = Oxycolor;
            PieThreePlotView.Model.TextColor = Oxycolor;
        }

        private void SetMenueColor(System.Drawing.Color color)
        {
            HomePagePanelTopBanner.BackColor = color;
            HomePagePanelSideBanner.BackColor = color;

            AppartmentsPanelTopBanner.BackColor = color;
            AppartmentsPanelSideBanner.BackColor = color;

            HousesPanelTopBanner.BackColor = color;
            HousesPanelSideBanner.BackColor = color;

            ReportPanelTopBanner.BackColor = color;
            ReportPanelSideBanner.BackColor = color;

            SettingsPanelTopBanner.BackColor = color;
            SettingsPanelSideBanner.BackColor = color;

            List<Button> MainPageButtons = new List<Button>()
            {
                //Settings Page Buttons
                SettingsButtonReportPage,
                SettingsButtonHousesPage,
                SettingsButtonAppartmentsPage,
                SettingsButtonHomePage,
                //Home Page Buttons
                HomePageButtonReport,
                HomePageButtonHouses,
                HomePageButtonAppartments,
                HomePageButtonHome,
                HomePageSettingsButton,
                //Report Page Buttons
                ReportButtonReportPage,
                ReportButtonHousesPage,
                ReportButtonAppartmentsPage,
                ReportButtonHomePage,
                ReportButtonSettings,
                //Houses Page Buttons
                HousesButtonsReportPage,
                HousesButtonsHousesPage,
                HousesButtonsAppartmentsPage,
                HousesButtonsHomePage,
                HousesButtonsSettingsPage,
                //Appartment Page Buttons
                AppartmentsButtonsReportPage,
                AppartmentsButtonsHousesPage,
                AppartmentsButtonsAppartmentsPage,
                AppartmentsButtonsHomePage,
                AppartmentsButtonsSettingsPage
            };

            for (int i = 0; i < MainPageButtons.Count; i++)
            {
                MainPageButtons[i].BackColor = color;
            }
        }
        
        private void SetMenueTextColor(System.Drawing.Color color)
        {
            HomePagePanelTopBanner.ForeColor = color;
            HomePagePanelSideBanner.ForeColor = color;

            AppartmentsPanelTopBanner.ForeColor = color;
            AppartmentsPanelSideBanner.ForeColor = color;

            HousesPanelTopBanner.ForeColor = color;
            HousesPanelSideBanner.ForeColor = color;

            ReportPanelTopBanner.ForeColor = color;
            ReportPanelSideBanner.ForeColor = color;

            SettingsPanelTopBanner.ForeColor = color;
            SettingsPanelSideBanner.ForeColor = color;
        }

        private void ColorConfermButton_Click(object sender, EventArgs e)
        {
            SetWindowColor(WindowColorPreviewPanel.BackColor);
            SetWindowTextColor(WindowTextColorPreviewPanel.BackColor);
        }

        private void MenueColorConfermButton_Click(object sender, EventArgs e)
        {
            SetMenueColor(MenueColorPreviewPanel.BackColor);
            SetMenueTextColor(MenueTextColorPreviewPanel.BackColor);
        }

        private void ColorModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReportViewer.RefreshReport();
        }

        private void ConfermTheamButton_Click(object sender, EventArgs e)
        {
            switch (ColorTheamComboBox.SelectedValue.ToString())
            {
                case "Light":
                    Console.WriteLine("Light");
                    break;
                case "Dark":
                    Console.WriteLine("Dark");
                    break;
                case "High Contrast":
                    //Window Colors
                    SetWindowColor(System.Drawing.Color.Black);
                    SetMenueColor(System.Drawing.Color.FromArgb(255, 26, 235, 255));
                    //Text Colors
                    SetWindowTextColor(System.Drawing.Color.White);
                    SetMenueTextColor(System.Drawing.Color.White);
                    Console.WriteLine("High Contrast");
                    break;
                default:
                    //Window Colors
                    SetWindowColor(System.Drawing.Color.Silver);
                    SetMenueColor(System.Drawing.Color.RoyalBlue);
                    //Text Colors
                    SetWindowTextColor(System.Drawing.Color.Black);
                    SetMenueTextColor(System.Drawing.Color.Black);
                    Console.WriteLine("Standard");
                    break;
            }
        }
    }
}
