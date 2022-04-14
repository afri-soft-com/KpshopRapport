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

namespace GoldenStarApplication.Comptabillite
{
    public partial class FormGroupeCompte : Form
    {
        public FormGroupeCompte()
        {
            InitializeComponent();
        }

        private void FormGroupeCompte_Load(object sender, EventArgs e)
        {
            comboCadre.Text =Cadre;
            comboCadreDes.Text = DesignationCadre;
            chargmentClasse();
        }

        public String Cadre, DesignationCadre;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                FormCompte FP = new FormCompte();
                FP.Text = this.Text;
                // Fp.NumOP = fonctionOPSotie();
                ///Fp.Utisateur = utilisateur;
                ///
                // FP.CodeCategorie = comboCat.Text.Trim();

                FP.Text = this.Text;
                int ci;
                //FP.NumClasse = CodeProjecte;
                ci = dGgroupe.CurrentRow.Index;
                FP.GroupeCompte = dGgroupe["GroupeCompte", ci].Value.ToString();
                FP.DesignationGroupe = dGgroupe["DesignationGroupe", ci].Value.ToString();
                DialogResult Dial = FP.ShowDialog();


                if (Dial == DialogResult.OK)
                {


                    try
                    {
                        //  chargmentComboArticle();
                        chargmentClasse();
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

        private void dGgroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCreerGroupe FP = new FormCreerGroupe();
            FP.Text = this.Text;
            FP.Cadre = comboCadre.Text;
            FP.DesignationCadre = comboCadreDes.Text;
            ///
            // FP.CodeCategorie = comboCat.Text.Trim();

            FP.Text = this.Text;
            // int ci;
            //FP.NumClasse = CodeProjecte;
            //ci = dGgroupe.CurrentRow.Index;
            //FP.GroupeCompte = dGgroupe["GroupeCompte", ci].Value.ToString();
            // FP.DesignationGroupe = dGgroupe["DesignationGroupe", ci].Value.ToString();
            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                    chargmentClasse();
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
                    chargmentClasse();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FormCreerGroupe FP = new FormCreerGroupe();
                FP.Text = this.Text;
                // Fp.NumOP = fonctionOPSotie();
                ///Fp.Utisateur = utilisateur;
                ///
                // FP.CodeCategorie = comboCat.Text.Trim();

                FP.Text = this.Text;
                FP.Cadre = comboCadre.Text;
                FP.DesignationCadre = comboCadreDes.Text;
                FP.boolModifier = true;
                int ci;
                //FP.NumClasse = CodeProjecte;
                ci = dGgroupe.CurrentRow.Index;
                FP.GroupeCompte = dGgroupe["GroupeCompte", ci].Value.ToString();
                FP.DesignationGroupe = dGgroupe["DesignationGroupe", ci].Value.ToString();
                DialogResult Dial = FP.ShowDialog();


                if (Dial == DialogResult.OK)
                {


                    try
                    {
                        //  chargmentComboArticle();
                        chargmentClasse();
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

        private void chargmentClasse()
        {
            string s;
            string sEncour =" SELECT        tGroupeCompte.GroupeCompte, tGroupeCompte.DesignationGroupe, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, COUNT(DISTINCT tCompte.NumCompte) AS Nombre " +
" FROM tMvtCompte INNER JOIN" +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation LEFT OUTER JOIN " +
                         " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte RIGHT OUTER JOIN " +
                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" GROUP BY tGroupeCompte.GroupeCompte, tGroupeCompte.DesignationGroupe,  tGroupeCompte.Cadre " +
" HAVING (tGroupeCompte.Cadre = @b) ;"  ;




            string[] r = { ClassVaribleGolbal.CodeDepartement, comboCadre.Text };
            DateTime[] da = { DateTime.Now };

            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTableDateAvecParametre(sEncour, r, da);
            dGgroupe.DataSource = Ccdt.tableEmoir;


        }




    }



}
