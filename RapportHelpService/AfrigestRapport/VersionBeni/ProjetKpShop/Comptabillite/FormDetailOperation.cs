using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKpbatiment.Operations;

namespace GoldenStarApplication.Comptabillite
{
    public partial class FormDetailOperation : Form
    {
        public FormDetailOperation()
        {
            InitializeComponent();
        }

        private void FormDetailOperation_Load(object sender, EventArgs e)
        {
            chargmentDetailMvtCompte(NumeroOperation);
        }

        public string NumeroOperation, Libelle;
        private void chargmentDetailMvtCompte( string NumOperation)
        {

            try
            {

               // int numCompte = int.Parse(Compte);
                IEnumerable<DetailOperationModel> detalitListe = new List<DetailOperationModel>();
                OperationDataAccessLayer dal = new OperationDataAccessLayer();
                detalitListe = dal.DetailleDuneOperation(NumOperation);
                dGMouvementdeCmpte.DataSource = detalitListe;

                CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        Double TotalDebit, TotalCredit, SoldeCompte;

        private void bEnreSupIdentite_Click(object sender, EventArgs e)
        {
            if (WindowsFormsApplication1.ClassVaribleGolbal.Niveau =="ADMIN")
            {
                try
                {
                    DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ?  ==== " + Libelle, "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RES == DialogResult.Yes)
                    {
                        // enregitrementEleve();
                        SuprimerOP();

                        chargmentDetailMvtCompte(NumeroOperation);


                        // ChargementMouvement();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
                else
            {

                MessageBox.Show("Connetez vous comme ADMIN");

            }


           
        }


        private void SuprimerOP()
        {

            try
            {

                
                OperationDataAccessLayer dal = new OperationDataAccessLayer();
               
                dal.SupprimmeerOperation(NumeroOperation);

              //  CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void CalculdeTotal()
        {
            TotalDebit = 0; TotalCredit = 0;

            string Debit, Credit, solde;



            for (int i = 0; i <= dGMouvementdeCmpte.Rows.Count - 1; i++)
            {


                Debit = dGMouvementdeCmpte["Debit", i].Value.ToString().Trim();
                Credit = dGMouvementdeCmpte["Credit", i].Value.ToString().Trim();
               // solde = dGMouvementdeCmpte["SoldeDg", i].Value.ToString().Trim();



                try
                {
                    TotalDebit = TotalDebit + Double.Parse(Debit);
                    TotalCredit = TotalCredit + Double.Parse(Credit);
                   // SoldeCompte = Double.Parse(solde);

                }

                catch (Exception ex)
                {
                    TotalDebit = 0;
                    TotalCredit = 0;
                  //  SoldeCompte = 0;

                    MessageBox.Show(ex.Message);
                }



            }


            //tTotalPV.Text = TotalSomePV.ToString();

            tTotalCredit.Text = TotalCredit.ToString();
            tTotalDebit.Text = TotalDebit.ToString();
           // tSolde.Text = SoldeCompte.ToString();
           // tSI.Text = (SoldeCompte + TotalCredit - TotalDebit).ToString();

        }
    }
}
