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
    public partial class FormMvtStockEntreeSortie : Form
    {
        public FormMvtStockEntreeSortie()
        {
            InitializeComponent();
        }

        private void FormMvtStockEntreeSortie_Load(object sender, EventArgs e)
        {

        }


        public void chargmentDetailMvtCompte(string NumOperation, string codeDEpot)
        {

            try
            {

                // int numCompte = int.Parse(Compte);
                IEnumerable<MvtStockModel> detalitListe = new List<MvtStockModel>();
                OperationStockDataAceesLayer dal = new OperationStockDataAceesLayer();
                detalitListe = dal.lilsteDesOperationEntreeSortie(NumOperation, codeDEpot);
                DGmvtEntreeSortie.DataSource = detalitListe;

                 CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


       private  double TotalEnValeur ,TotalVente , TotalQteEntre ,TotalQteSortie ;
        private void CalculdeTotal()
        {
            TotalEnValeur = 0; TotalVente = 0;
            TotalQteEntre = 0; TotalQteSortie = 0;

            string QteEntree, QteSortie, Vente,Achat;



            for (int i = 0; i <= DGmvtEntreeSortie.Rows.Count - 1; i++)
            {
              //  QteEntree

                QteEntree = DGmvtEntreeSortie["QteEntree", i].Value.ToString().Trim();
                QteSortie = DGmvtEntreeSortie["QteSortie", i].Value.ToString().Trim();
                Vente = DGmvtEntreeSortie["Vente", i].Value.ToString().Trim();
                Achat = DGmvtEntreeSortie["Valeur", i].Value.ToString().Trim();



                try
                {
                    TotalEnValeur = TotalEnValeur + Double.Parse(Achat);
                    TotalVente = TotalVente + Double.Parse(Vente);
                    TotalQteEntre = TotalQteEntre + Double.Parse(QteEntree);
                    TotalQteSortie = TotalQteSortie + Double.Parse(QteSortie);
                   // SoldeCompte = Double.Parse(solde);

                }

                catch (Exception ex)
                {
                    TotalEnValeur = 0;
                    TotalVente = 0;
                    TotalQteEntre = 0;
                    TotalQteSortie = 0;

                    MessageBox.Show(ex.Message);
                }



            }


            //tTotalPV.Text = TotalSomePV.ToString();

            tQteSortie.Text = TotalQteSortie.ToString();
            tQteEntree.Text = TotalQteEntre.ToString();
            tValeurVente.Text = TotalVente.ToString();
           tValeurAchat.Text = TotalEnValeur.ToString();

        }

    }
    }
