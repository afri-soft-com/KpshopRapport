using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKpbatiment.Stock;

namespace GoldenStarApplication.Stock
{
    public partial class FormFicheDeStock : Form
    {
        public FormFicheDeStock()
        {
            InitializeComponent();
        }

        public string Article, Depot;
        private void FormFicheDeStock_Load(object sender, EventArgs e)
        {
            LibelleARTICLE.Text = Article;
            ldepot.Text = Depot;
        }


        public void chargmentDetailMvtCompte(string CodeArticle, string codeDEpot, DateTime Date1, DateTime Date2)
        {

            try
            {

                // int numCompte = int.Parse(Compte);
                IEnumerable<MvtStockModel> detalitListe = new List<MvtStockModel>();
                OperationStockDataAceesLayer dal = new OperationStockDataAceesLayer();
                detalitListe = dal.lilsteFicheDeStovk(CodeArticle, codeDEpot, Date1, Date2);
                DGmvtEntreeSortie.DataSource = detalitListe;

                CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        Double TotalDebit, TotalCredit, SoldeCompte;

        private void DGmvtEntreeSortie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalculdeTotal()
        {
            TotalDebit = 0; TotalCredit = 0;

            string Debit, Credit, solde;



            for (int i = 0; i <= DGmvtEntreeSortie.Rows.Count - 1; i++)
            {


                Debit = DGmvtEntreeSortie["QteEntree", i].Value.ToString().Trim();
                Credit = DGmvtEntreeSortie["QteSortie", i].Value.ToString().Trim();
                solde = DGmvtEntreeSortie["Enstock", i].Value.ToString().Trim();



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

            tQteSortie.Text = TotalCredit.ToString();
            tQteEntree.Text = TotalDebit.ToString();
            tStock.Text = SoldeCompte.ToString();
            tSI.Text = (SoldeCompte + TotalCredit - TotalDebit).ToString();

        }
    }
}
