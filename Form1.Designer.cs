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
            this.MainWindowMaterialTabControler = new MaterialSkin.Controls.MaterialTabControl();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.HomePageButtonReport = new System.Windows.Forms.Button();
            this.HomePageButtonHouses = new System.Windows.Forms.Button();
            this.HomePageButtonAppartments = new System.Windows.Forms.Button();
            this.HomePageButtonHome = new System.Windows.Forms.Button();
            this.AppartmentsPageTab = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.AppartmentsPageButtonReport = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonHouses = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonAppartments = new System.Windows.Forms.Button();
            this.AppartmentsPageButtonHome = new System.Windows.Forms.Button();
            this.HousesPageTab = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.HousesPageButtonReport = new System.Windows.Forms.Button();
            this.HousesPageButtonHouses = new System.Windows.Forms.Button();
            this.HousesPageButtonAppartments = new System.Windows.Forms.Button();
            this.HousesPageButtonHome = new System.Windows.Forms.Button();
            this.ReportPageTab = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.ReportPageButtonReport = new System.Windows.Forms.Button();
            this.ReportPageButtonHouses = new System.Windows.Forms.Button();
            this.ReportPageButtonAppartments = new System.Windows.Forms.Button();
            this.ReportPageButtonHome = new System.Windows.Forms.Button();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MainWindowMaterialTabControler.SuspendLayout();
            this.HomePageTab.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.AppartmentsPageTab.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.HousesPageTab.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.ReportPageTab.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
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
            this.HomePageTab.Controls.Add(this.panel13);
            this.HomePageTab.Controls.Add(this.panel14);
            this.HomePageTab.Controls.Add(this.panel15);
            this.HomePageTab.Location = new System.Drawing.Point(4, 22);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomePageTab.Size = new System.Drawing.Size(772, 400);
            this.HomePageTab.TabIndex = 4;
            this.HomePageTab.Text = "StartMenue";
            this.HomePageTab.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(109, 106);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(653, 294);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel14.Controls.Add(this.label5);
            this.panel14.Location = new System.Drawing.Point(103, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(665, 100);
            this.panel14.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 91);
            this.label5.TabIndex = 0;
            this.label5.Text = "Home Page";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel15.Controls.Add(this.HomePageButtonReport);
            this.panel15.Controls.Add(this.HomePageButtonHouses);
            this.panel15.Controls.Add(this.HomePageButtonAppartments);
            this.panel15.Controls.Add(this.HomePageButtonHome);
            this.panel15.Location = new System.Drawing.Point(3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(100, 400);
            this.panel15.TabIndex = 0;
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
            this.AppartmentsPageTab.Controls.Add(this.panel16);
            this.AppartmentsPageTab.Controls.Add(this.panel17);
            this.AppartmentsPageTab.Controls.Add(this.panel18);
            this.AppartmentsPageTab.Location = new System.Drawing.Point(4, 22);
            this.AppartmentsPageTab.Name = "AppartmentsPageTab";
            this.AppartmentsPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppartmentsPageTab.Size = new System.Drawing.Size(772, 400);
            this.AppartmentsPageTab.TabIndex = 5;
            this.AppartmentsPageTab.Text = "Appartments";
            this.AppartmentsPageTab.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(109, 106);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(653, 294);
            this.panel16.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel17.Controls.Add(this.label6);
            this.panel17.Location = new System.Drawing.Point(103, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(665, 100);
            this.panel17.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 91);
            this.label6.TabIndex = 0;
            this.label6.Text = "Appartments";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel18.Controls.Add(this.AppartmentsPageButtonReport);
            this.panel18.Controls.Add(this.AppartmentsPageButtonHouses);
            this.panel18.Controls.Add(this.AppartmentsPageButtonAppartments);
            this.panel18.Controls.Add(this.AppartmentsPageButtonHome);
            this.panel18.Location = new System.Drawing.Point(3, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(100, 400);
            this.panel18.TabIndex = 0;
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
            this.HousesPageTab.Controls.Add(this.panel19);
            this.HousesPageTab.Controls.Add(this.panel20);
            this.HousesPageTab.Controls.Add(this.panel21);
            this.HousesPageTab.Location = new System.Drawing.Point(4, 22);
            this.HousesPageTab.Name = "HousesPageTab";
            this.HousesPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.HousesPageTab.Size = new System.Drawing.Size(772, 400);
            this.HousesPageTab.TabIndex = 6;
            this.HousesPageTab.Text = "Houses";
            this.HousesPageTab.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Location = new System.Drawing.Point(109, 106);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(653, 294);
            this.panel19.TabIndex = 2;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel20.Controls.Add(this.label7);
            this.panel20.Location = new System.Drawing.Point(103, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(665, 100);
            this.panel20.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(309, 91);
            this.label7.TabIndex = 0;
            this.label7.Text = "Houses";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel21.Controls.Add(this.HousesPageButtonReport);
            this.panel21.Controls.Add(this.HousesPageButtonHouses);
            this.panel21.Controls.Add(this.HousesPageButtonAppartments);
            this.panel21.Controls.Add(this.HousesPageButtonHome);
            this.panel21.Location = new System.Drawing.Point(3, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(100, 400);
            this.panel21.TabIndex = 0;
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
            this.ReportPageTab.Controls.Add(this.panel23);
            this.ReportPageTab.Controls.Add(this.panel24);
            this.ReportPageTab.Location = new System.Drawing.Point(4, 22);
            this.ReportPageTab.Name = "ReportPageTab";
            this.ReportPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportPageTab.Size = new System.Drawing.Size(772, 400);
            this.ReportPageTab.TabIndex = 7;
            this.ReportPageTab.Text = "Report";
            this.ReportPageTab.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel23.Controls.Add(this.label8);
            this.panel23.Location = new System.Drawing.Point(103, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(665, 100);
            this.panel23.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 91);
            this.label8.TabIndex = 0;
            this.label8.Text = "Report";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel24.Controls.Add(this.ReportPageButtonReport);
            this.panel24.Controls.Add(this.ReportPageButtonHouses);
            this.panel24.Controls.Add(this.ReportPageButtonAppartments);
            this.panel24.Controls.Add(this.ReportPageButtonHome);
            this.panel24.Location = new System.Drawing.Point(3, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(100, 400);
            this.panel24.TabIndex = 0;
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
            // ReportViewer
            // 
            this.ReportViewer.Location = new System.Drawing.Point(103, 100);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(665, 300);
            this.ReportViewer.TabIndex = 2;
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
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.AppartmentsPageTab.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.HousesPageTab.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.ReportPageTab.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl MainWindowMaterialTabControler;
        private TabPage HomePageTab;
        private Panel panel13;
        private Panel panel14;
        private Label label5;
        private Panel panel15;
        private Button HomePageButtonReport;
        private Button HomePageButtonHouses;
        private Button HomePageButtonAppartments;
        private Button HomePageButtonHome;
        private TabPage AppartmentsPageTab;
        private Panel panel16;
        private Panel panel17;
        private Label label6;
        private Panel panel18;
        private TabPage HousesPageTab;
        private Panel panel19;
        private Panel panel20;
        private Label label7;
        private Panel panel21;
        private Button HousesPageButtonReport;
        private Button HousesPageButtonHouses;
        private Button HousesPageButtonAppartments;
        private Button HousesPageButtonHome;
        private TabPage ReportPageTab;
        private Panel panel23;
        private Label label8;
        private Panel panel24;
        private Button ReportPageButtonReport;
        private Button ReportPageButtonHouses;
        private Button ReportPageButtonAppartments;
        private Button ReportPageButtonHome;
        private Button AppartmentsPageButtonReport;
        private Button AppartmentsPageButtonHouses;
        private Button AppartmentsPageButtonAppartments;
        private Button AppartmentsPageButtonHome;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
    }
}

