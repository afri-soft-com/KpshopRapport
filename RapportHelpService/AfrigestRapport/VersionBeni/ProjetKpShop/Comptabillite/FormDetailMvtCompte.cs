using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKpbatiment.ClasseCadreGroupe;
using LibraryKpbatiment.Balance;
using WindowsFormsApplication1;

using System.Data.SqlClient;


namespace GoldenStarApplication.Comptabillite
{
    public partial class FormDetailMvtCompte : Form
    {
        public FormDetailMvtCompte()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public DateTime Date1, Date2;
        public string Compte;
        private void FormDetailMvtCompte_Load(object sender, EventArgs e)
        {

            chargmentDetailMvtCompte();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            affichageRapport();

           // int numCompte = int.Parse(Compte);
           // IEnumerable<ReleveModel> detalitListe = new List<ReleveModel>();
           // DetailBalanceDataAccesLayer dal = new DetailBalanceDataAccesLayer();
           // detalitListe = dal.ReleveCompte(numCompte, Date1, Date2);
           // //dGMouvementdeCmpte.DataSource = detalitListe;

            // string chiminRap = @"Rapport\Kpbatiment\RapportReleve.rdlc";
            // FormEtat fo = new FormEtat();
            //// fo.chargemenentRapporteAveVDataSetPro(detalitListe, chiminRap, "DataSet1");

            // fo.Show();
        }
        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        private void affichageRapport()
        {
            string codecl;
            // int ci;
            //ci = dGsoldeDeSrivice.CurrentRow.Index;
            //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
            //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
            codecl = Compte;
            //MessageBox.Show(codecl);
            Connection_Data();
            con.Open();
            cmd.CommandText = "Proc_BraSroProRapportRelever";


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@NumCompte", codecl);
            cmd.Parameters.AddWithValue("@NumCompte", codecl);
            cmd.Parameters.AddWithValue("@date1", Date1);
            cmd.Parameters.AddWithValue("@date2", Date2);
            //  MessageBox.Show(codecl);
            //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
            da.Fill(dt);
            con.Close();
            string chiminRap = "Rapport/Report3.rdlc";
           // string chiminRap = "Rapport/Bransimba/ReportReleverUsd.rdlc";
            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
            fo.Show();

        }

        private void chargmentDetailMvtCompte()
        {

            try
            {

                int numCompte = int.Parse(Compte);
                IEnumerable<DetailBalanceModel> detalitListe = new List<DetailBalanceModel>();
                DetailBalanceDataAccesLayer dal = new DetailBalanceDataAccesLayer();
                detalitListe = dal.ListeDetailBalance(numCompte, Date1, Date2);
                dGMouvementdeCmpte.DataSource = detalitListe;

                CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        Double TotalDebit, TotalCredit,SoldeCompte;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string NumeroOperation;
                int ci;
                ci = dGMouvementdeCmpte.CurrentRow.Index;
                NumeroOperation = dGMouvementdeCmpte["NumOperationDG", ci].Value.ToString();
                // fo.Libelle = DgStock["LibelleDg", ci].Value.ToString();
                // MessageBox.Show(NumeroOperation);
                Stock.FormStockDepot fd = new Stock.FormStockDepot();
                fd.NumOperation = NumeroOperation;
                fd.chargmentDetailMvtCompte(NumeroOperation);
                fd.Show();
            }
            catch
            {

            }
        }

        private void dGMouvementdeCmpte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDetailOperation fo = new FormDetailOperation();
            //fo.MdiParent = this.MdiParent;
           // fo.Date1 = tDateR1.Value;
           // fo.Date2 = tdateR2.Value;
            try
            {
                int ci;
                ci = dGMouvementdeCmpte.CurrentRow.Index;
                fo.NumeroOperation = dGMouvementdeCmpte["NumOperationDG", ci].Value.ToString();
                fo.Libelle = dGMouvementdeCmpte["LibelleDg", ci].Value.ToString();
            }

            catch (Exception ex)
            {

                fo.NumeroOperation = "";
                fo.Libelle = "";
            }

            fo.Text = this.Text;
            // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

           // fo.ShowDialog();

            DialogResult Dial = fo.ShowDialog(); 
            if (Dial == DialogResult.OK)
            {
                chargmentDetailMvtCompte();
            }

            else
            {
                chargmentDetailMvtCompte();
            }

            }

        private void CalculdeTotal()
        {
            TotalDebit = 0; TotalCredit = 0;

            string Debit, Credit,solde;
           


            for (int i = 0; i <= dGMouvementdeCmpte.Rows.Count - 1; i++)
            {


                Debit = dGMouvementdeCmpte["Debit", i].Value.ToString().Trim();
                Credit = dGMouvementdeCmpte["Credit", i].Value.ToString().Trim();
                solde = dGMouvementdeCmpte["SoldeDg", i].Value.ToString().Trim();


               
                    try
                    {
                    TotalDebit = TotalDebit + Double.Parse(Debit);
                    TotalCredit = TotalCredit + Double.Parse(Credit);
                    SoldeCompte = Double.Parse(solde);

                }

                    catch (Exception ex)
                    {
                    TotalDebit = 0;
                    TotalCredit = 0;
                    SoldeCompte = 0;

                        MessageBox.Show(ex.Message);
                    }

                

            }

           
            //tTotalPV.Text = TotalSomePV.ToString();

            tTotalCredit.Text = TotalCredit.ToString();
            tTotalDebit.Text = TotalDebit.ToString();
            tSolde.Text = SoldeCompte.ToString();
            tSI.Text = (SoldeCompte + TotalCredit - TotalDebit).ToString();

        }
    }
}
