using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using WindowsFormsApplication1;
namespace GoldenStarApplication
{
    public partial class FormEtat : Form
    {
        public FormEtat()
        {
            InitializeComponent();
        }

        private void FormRapport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

          //  this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }



        public void chargemenentRapporteAvecLeParametreDate(string connexion, string req, string[] n, DateTime[] d, string Nomtable, string CheminRap)
        {





            //SqlDataAdapter da;

            //DataSet DataSet1 = new DataSet();
            ////  est une base de donn�es en memoir
            //da = new SqlDataAdapter("DataSet1", con);
            //da.SelectCommand = cmd;
            //da.Fill(DataSet1, Nomtable);
            //// on charge la base de donn�es en memoir par les donn�es de la base de donn�es phusique(HDD)
            //if ((con.State.ToString() == "Open"))
            //{
            //    cmd.Dispose();
            //    da.Dispose();
            //    con.Close();
            //}
            //  DataTable FactureTable;
            // ClassRequette classeReq = new ClassRequette();
            // classeReq.chargementAvecLesParametreDate(req, connexion, Nomtable, n, d);
            // FactureTable = classeReq.dt;

            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSet1.Tables[Nomtable]));
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", FactureTable));
            //  
            // this.reportViewer1.LocalReport.ReportPath = CheminRap;
            //  reportViewer1.RefreshReport();
            //  Dim fo As New ImprimerRapport
            // fo.lancer(CheminRap, "DataSet1", DataSet1.Tables(Nomtable))
        }


        public void chargemenentRapporteAveVDataSet(string connexion, string req, string[] n, string Nomtable, string CheminRap, string dtset)
        {
            DataTable FactureTable;
            ClassRequette classeReq = new ClassRequette();
            classeReq.chargementAvecLesParametre(req, connexion, Nomtable, n);
            FactureTable = classeReq.dt;


            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dtset, FactureTable));
            //  
            this.reportViewer1.LocalReport.ReportPath = CheminRap;
            reportViewer1.RefreshReport();







        }

        public void chargemenentRapporteAveVDataSetPro(DataTable FactureTable, string CheminRap, string dtset)
        {
            // DataTable FactureTable;
            //  classeReq.chargementAvecLesParametre(req, connexion, Nomtable, n);
            // FactureTable = classeReq.dt;


            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dtset, FactureTable));
            //  
            this.reportViewer1.LocalReport.ReportPath = CheminRap;
            reportViewer1.RefreshReport();







        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
