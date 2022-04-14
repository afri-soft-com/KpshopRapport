using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace GoldenStarApplication.ProjetBatiment
{
    public partial class FormDetaillEB : Form
    {
        public FormDetaillEB()
        {
            InitializeComponent();
        }

        private void FormDetaillEB_Load(object sender, EventArgs e)
        {
            chargementLigneBigeteur();
        }

        public string CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject;
        private void chargementLigneBigeteur()
        {
            string s = " SELECT       tlibelProjet.DesignationLibeleProject, tStock.CodeArticle, tStock.DesegnationArticle, tlibelProjet.CodeLibele,  tDetailEtatBesoin.Qte, tDetailEtatBesoin.Pu, tDetailEtatBesoin.Qte * tDetailEtatBesoin.Pu AS Total, " +
                        " tEtatDeBesoin.CodeEtatdeBesoin  "+
" FROM            tEtatDeBesoin INNER JOIN  "+
                        " tDetailEtatBesoin ON tEtatDeBesoin.CodeEtatdeBesoin = tDetailEtatBesoin.CodeEtatdeBesoin INNER JOIN  "+
                         " tStock ON tDetailEtatBesoin.CodeArticle = tStock.CodeArticle INNER JOIN  "+
                         " tlibelProjet ON tDetailEtatBesoin.CodeLibele = tlibelProjet.CodeLibele  " +
" WHERE        (tEtatDeBesoin.CodeEtatdeBesoin = @a) ";
            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(s, CodeEtatdeBesoin);
            dGlibeleProject.DataSource = Ccdt.tableEmoir;
            CalculdeTotal();

        }

        Double TotalSomeVente;

        private void tTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculdeTotal()
        {


            string tot;
            TotalSomeVente = 0;


            for (int i = 0; i <= dGlibeleProject.Rows.Count - 1; i++)
            {


                tot = dGlibeleProject["Total2", i].Value.ToString().Trim();



                if (Double.Parse(tot) != 0)
                {
                    try
                    {
                        TotalSomeVente = TotalSomeVente + Double.Parse(tot);


                    }

                    catch (Exception ex)
                    {
                        TotalSomeVente = 0;
                        MessageBox.Show(ex.Message);
                    }

                }

            }

            tTotal.Text = TotalSomeVente.ToString();

            //  MessageBox.Show("modification reussi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAjoutDetailEB FP = new FormAjoutDetailEB();
            FP.Text = this.Text;
           // FP.CodeProject =;
            FP.CodeEtatdeBesoin = CodeEtatdeBesoin;
            FP.CodeProject = CodeProject;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargementLigneBigeteur();
            }
            else
            {
                chargementLigneBigeteur();

            }
        }
    }
}
