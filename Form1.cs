using Microsoft.Reporting.WinForms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
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

namespace CIS_129_Final
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCharts();
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
            WindowColorCodeDisplay.Text = $"rgb(" +
                    $"{WindowRedMaterialSlider.Value}," +
                    $"{WindowGreenMaterialSlider.Value}," +
                    $"{WindowBlueMaterialSlider.Value})";

            WindowColorPreviewPanel.BackColor = Color.FromArgb(
                255,
                WindowRedMaterialSlider.Value,
                WindowGreenMaterialSlider.Value,
                WindowBlueMaterialSlider.Value
            );

            MenueColorCodeDisplay.Text = $"rgb(" +
                    $"{MenueRedMaterialSlider.Value}," +
                    $"{MenueGreenMaterialSlider.Value}," +
                    $"{MenueBlueMaterialSlider.Value})";

            MenueColorPreviewPanel.BackColor = Color.FromArgb(
                255,
                MenueRedMaterialSlider.Value,
                MenueGreenMaterialSlider.Value,
                MenueBlueMaterialSlider.Value
            );
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

        private void SetWindowColor(Color color)
        {
            HomePageTab.BackColor = color;
            AppartmentsPage.BackColor = color;
            HousesPage.BackColor = color;
            ReportPage.BackColor = color;
            SettingsPage.BackColor = color;
            ReportViewer.BackColor = color;
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

        private void SetMenueColor(Color color)
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

        private void ColorConfermButton_Click(object sender, EventArgs e)
        {
            SetWindowColor(WindowColorPreviewPanel.BackColor);
        }

        private void MenueColorConfermButton_Click(object sender, EventArgs e)
        {
            SetMenueColor(MenueColorPreviewPanel.BackColor);
        }
    }
}
