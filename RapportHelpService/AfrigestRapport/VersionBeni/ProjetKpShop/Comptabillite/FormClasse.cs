using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenStarApplication.Comptabillite
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            chargmentClasse();
        }


        private void chargmentClasse()
        {
            string s;
            string sEncour = "SELECT        tClasse.NumClasse, tClasse.DesignationClasse, COUNT(tCadre.Cadre) AS NombreCadre " +
" FROM tClasse LEFT OUTER JOIN "  +
              " tCadre ON tClasse.NumClasse = tCadre.Classe"  +
" GROUP BY tClasse.NumClasse, tClasse.DesignationClasse";






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, "1");
            dGClasse.DataSource = Ccdt.tableEmoir;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormCadre FP = new FormCadre();
                FP.Text = this.Text;
                // Fp.NumOP = fonctionOPSotie();
                ///Fp.Utisateur = utilisateur;
                ///
                // FP.CodeCategorie = comboCat.Text.Trim();

                FP.Text = this.Text;
                int ci;
                //FP.NumClasse = CodeProjecte;
                ci = dGClasse.CurrentRow.Index;
                FP.NumClasse = dGClasse["NumClasse", ci].Value.ToString();
                FP.DesignationClasse = dGClasse["DesignationClasse", ci].Value.ToString();
                DialogResult Dial = FP.ShowDialog();


                if (Dial == DialogResult.OK)
                {


                    try
                    {
                        //  chargmentComboArticle();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        // chargmentComboArticle();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
