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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_129_Final
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Random random = new Random(0);

            TEMP_AppartmentsPowerConsumption APT = new TEMP_AppartmentsPowerConsumption();

            InitializeComponent();

            dataSet = APT.TEMP_AppartmentsPowerConsumptionDataToDataSet(dataSet);

            InsertDataToReportViewer(this.ReportViewer, dataSet.Table1);

            this.plotView1.Model = APT.AppartmentsPowerConsumptionLineGraph(dataSet);
            this.plotView2.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 1);
            this.plotView3.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 2);
            this.plotView4.Model = APT.AppartmentsPowerConsumptionPieGraph(dataSet, 3);
        }

        //Home Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToHomePage(object sender, EventArgs e)
        {
            this.MainWindowMaterialTabControler.SelectTab(0);
        }
        //Home Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Appartments Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToAppartmentsPage(object sender, EventArgs e)
        {
            this.MainWindowMaterialTabControler.SelectTab(1);
        }
        //Appartments Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Houses Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToHouses(object sender, EventArgs e)
        {
            this.MainWindowMaterialTabControler.SelectTab(2);
        }
        //Houses Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Report Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToReport(object sender, EventArgs e)
        {
            this.MainWindowMaterialTabControler.SelectTab(3);
        }
        //Report Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //Settings Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToSettiongs(object sender, EventArgs e)
        {
            this.MainWindowMaterialTabControler.SelectTab(4);
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
            Microsoft.Reporting.WinForms.ReportDataSource DataSourceInto = new Microsoft.Reporting.WinForms.ReportDataSource();

            DataSourceInto.Name = REPORTVIEWER.LocalReport.GetDataSourceNames()[0];
            DataSourceInto.Value = DATA;

            REPORTVIEWER.LocalReport.DataSources.Add(DataSourceInto);

            REPORTVIEWER.RefreshReport();
        }
        //this function places data into the report viewer, it is temporary unless never fully made.
    }
}
