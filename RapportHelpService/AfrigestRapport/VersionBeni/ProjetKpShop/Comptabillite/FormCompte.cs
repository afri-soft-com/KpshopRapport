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
    public partial class FormCompte : Form
    {
        public FormCompte()
        {
            InitializeComponent();
        }

        private void FormCompte_Load(object sender, EventArgs e)
        {
            comboGroupe.Text = GroupeCompte;
            comboGroupeDes.Text = DesignationGroupe;
            chargmentClasse();


        }

        public String GroupeCompte, DesignationGroupe;

        private void button3_Click(object sender, EventArgs e)
        {





            FormCreerUnCompte FP = new FormCreerUnCompte();
            FP.Text = this.Text;
            FP.GroupeCompte = comboGroupe.Text;
            FP.DesignationGroupe = comboGroupeDes.Text;
            ///
            // FP.CodeCategorie = comboCat.Text.Trim();

            FP.Text = this.Text;
            //int ci;
            //FP.NumClasse = CodeProjecte;
            //ci = dGcOMPTE.CurrentRow.Index;
            //FP.Compte = dGcOMPTE["GroupeCompte", ci].Value.ToString();
            //FP.DesignationCompte = dGcOMPTE["DesignationGroupe", ci].Value.ToString();
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
                    chargmentClasse();
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

        private void comboGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormComptable FO = new FormComptable();
            FO.AFFICHERplan();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {

                FormCreerUnCompte FP = new FormCreerUnCompte();
                FP.Text = this.Text;
                FP.GroupeCompte = comboGroupe.Text;
                FP.DesignationGroupe = comboGroupeDes.Text;
                ///
                // FP.CodeCategorie = comboCat.Text.Trim();

                FP.Text = this.Text;
                FP.boolModifier = true;
                int ci;
               //FP.NumClasse = CodeProjecte;

                ci = dGcOMPTE.CurrentRow.Index;
                FP.Compte = dGcOMPTE["NumCompte", ci].Value.ToString();
                FP.DesignationCompte = dGcOMPTE["DesignationCompte", ci].Value.ToString();
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
                        chargmentClasse();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormGrandLivre FP = new FormGrandLivre("");
                FP.Text = this.Text;
                int ci;
                //FP.NumClasse = CodeProjecte;

                ci = dGcOMPTE.CurrentRow.Index;
                FP.Compte = dGcOMPTE["NumCompte", ci].Value.ToString();

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
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargmentClasse()
        {
            //            string s;
            //            string sEncour = " SELECT       tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, COUNT(DISTINCT tCompte.NumCompte) AS Nombre " +
            //" FROM tMvtCompte INNER JOIN " +
            //                        "  tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation LEFT OUTER JOIN " +
            //                         " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte " +
            //" GROUP BY tCompte.CodeDepartement, tCompte.GroupeCompte, tCompte.DesignationCompte, tCompte.NumCompte " +
            //" HAVING(tCompte.CodeDepartement = @a) AND(tCompte.GroupeCompte = @b); ";

            string sEncour = "   SELECT tCompte.NumCompte, tCompte.DesignationCompte, View_LesMouvementCompte.Solde, View_LesMouvementCompte.Nombre " +
" FROM             tCompte LEFT OUTER JOIN" +
                        "  View_LesMouvementCompte ON tCompte.NumCompte = View_LesMouvementCompte.NumCompte " +
" WHERE    (tCompte.GroupeCompte = @a)";


            string[] r = { comboGroupe.Text };
            DateTime[] da = { DateTime.Now };

            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTableDateAvecParametre(sEncour, r, da);
            dGcOMPTE.DataSource = Ccdt.tableEmoir;


        }

    }
}
