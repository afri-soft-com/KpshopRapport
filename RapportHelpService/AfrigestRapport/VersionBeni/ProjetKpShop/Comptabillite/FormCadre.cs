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
    public partial class FormCadre : Form
    {
        public FormCadre()
        {
            InitializeComponent();
        }

        private void FormCadre_Load(object sender, EventArgs e)
        {
            comboClasse.Text = NumClasse;
            comboClasseDES.Text = DesignationClasse;
            chargmentClasse();
        }

        public String NumClasse, DesignationClasse;

        private void dGcadre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargmentClasse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                FormGroupeCompte FP = new FormGroupeCompte();
                FP.Text = this.Text;
                // Fp.NumOP = fonctionOPSotie();
                ///Fp.Utisateur = utilisateur;
                ///
                // FP.CodeCategorie = comboCat.Text.Trim();

                FP.Text = this.Text;
                int ci;
                //FP.NumClasse = CodeProjecte;
                ci = dGcadre.CurrentRow.Index;
                FP.Cadre = dGcadre["Cadre", ci].Value.ToString();
                FP.DesignationCadre = dGcadre["DesignationCadre", ci].Value.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chargmentClasse()
        {
            string s;
            string sEncour = "SELECT        tCadre.Cadre, tCadre.DesignationCadre, COUNT(tGroupeCompte.GroupeCompte) AS Nombre " +
" FROM            tCadre FULL OUTER JOIN " +
              "  tGroupeCompte ON tCadre.Cadre = tGroupeCompte.Cadre " +
" WHERE(tCadre.Classe =@a) " +
" GROUP BY tCadre.Cadre, tCadre.DesignationCadre ";






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, comboClasse.Text);
            dGcadre.DataSource = Ccdt.tableEmoir;


        }
    }
}
