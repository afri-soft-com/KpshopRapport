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
    public partial class FormStockDepot : Form
    {
        public FormStockDepot()
        {
            InitializeComponent();
        }

        private void FormStockDepot_Load(object sender, EventArgs e)
        {

        }

        public string NumOperation;
        public void chargmentDetailMvtCompte( string NumOperation )
        {

            try
            {

                // int numCompte = int.Parse(Compte);
                IEnumerable<DepotModel> detalitListe = new List<DepotModel>();
                OperationStockDataAceesLayer dal = new OperationStockDataAceesLayer();
                detalitListe = dal.lilsteDesOperationParDepot(NumOperation);
                DgStock.DataSource = detalitListe;

                // CalculdeTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string CodeDEpot;
                int ci;
                ci = DgStock.CurrentRow.Index;
                CodeDEpot = DgStock["CodeDEpot", ci].Value.ToString();
                // fo.Libelle = DgStock["LibelleDg", ci].Value.ToString();
                // MessageBox.Show(NumeroOperation);
                FormMvtStockEntreeSortie fd = new FormMvtStockEntreeSortie();
               // fd.NumOperation = NumeroOperation;
                fd.chargmentDetailMvtCompte(NumOperation, CodeDEpot);
                fd.Show();
            }
            catch
            {

            }
        }
    }
}
