using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_129_Final
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();

        }

        //Home Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToHomePage(object sender, EventArgs e) {
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
        


        //NULL Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void GoToNothing(object sender, EventArgs e)
        {
            //this exists for the buttons that send you to the page you are on
            //having them basicly reload the page you are looking at sounds dumb
            //this is to not do that.
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            this.ReportViewer.RefreshReport();
            this.ReportViewer.RefreshReport();
        }
        //NULL Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
}
