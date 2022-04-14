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

namespace GoldenStarApplication.Stock
{
    public partial class FormOperationStock : Form
    {
        public FormOperationStock()
        {
            InitializeComponent();
        }

        private void FormOperationStock_Load(object sender, EventArgs e)
        {

        }


        public void chargmentDetailMvtCompte(DateTime Date1 , DateTime Date2)
        {

            try
            {

               // int numCompte = int.Parse(Compte);
                IEnumerable<OperationModel> detalitListe = new List<OperationModel>();
                OperationDataAccessLayer dal = new OperationDataAccessLayer();
                detalitListe = dal.lilsteDesoperationdeStock(Date1, Date2);
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
                string NumeroOperation;
                int ci;
                ci = DgStock.CurrentRow.Index;
                NumeroOperation = DgStock["NumOperationDG", ci].Value.ToString();
                // fo.Libelle = DgStock["LibelleDg", ci].Value.ToString();
               // MessageBox.Show(NumeroOperation);
                FormStockDepot fd = new FormStockDepot();
                fd.NumOperation = NumeroOperation;
                fd.chargmentDetailMvtCompte(NumeroOperation);
                fd.Show();
            }
            catch
            {

            }
        }

        private void DgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
