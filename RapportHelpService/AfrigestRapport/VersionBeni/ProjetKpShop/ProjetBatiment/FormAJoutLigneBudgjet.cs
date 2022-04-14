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
    public partial class FormAJoutLigneBudgjet : Form
    {
        public FormAJoutLigneBudgjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tCodeProject.Text.Trim() != "") && (tligne.Text.Trim() != ""))
            {

                enregistraiment();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }

        }

        public String CodeLibele, CodeProject, Idligne;
        public Boolean testeModification;
        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tLigneBudget " +
                       "  (CodeLibele, CodeProject, CodeArticle, PU, Qte)" +
" VALUES        (@a,@b,@c,@d,@e) ";

                String Supdate = " UPDATE       tLigneBudget " +
" SET                CodeLibele = @a, CodeProject = @b, CodeArticle = @c, PU = @d, Qte = @e " +
" WHERE        (Idligne = @f) ";


                string[] r = { CodeLibele, CodeProject, comboArticle.Text.Trim(), tPu.Text, tQte.Text };
                string[] r2 = { CodeLibele, CodeProject, comboArticle.Text.Trim(), tPu.Text, tQte.Text, Idligne };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                if (testeModification == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Supdate, r2, d);
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void chargmentComboArticle()
        {
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargmentComboArtilce(comboArticle, comboArticleDes, comboCat.Text.Trim());
            //chargmentComboCategorie
        }

        private void chargmentCombocATEGORIE()
        {
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargmentComboCategorie(comboCat, comboCatDes, " ");
            //chargmentComboCategorie
        }

        private void FormAJoutLigneBudgjet_Load(object sender, EventArgs e)
        {
            //chargmentComboArticle();

            chargmentCombocATEGORIE();

            tligne.Text = CodeLibele;
            tCodeProject.Text = CodeProject;
            tIdLigne.Visible = testeModification;
            tIdLigne.Text = Idligne;
            if (testeModification==true)
            {
                bValide.Text = "MODIFIER";


            }

            else
            {
                bValide.Text = "VALIDER";
            }
        }

        private void comboArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboArticle.ValueMember = "PrixAchat";
            tPu.Text = comboArticle.SelectedValue.ToString();
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chargmentComboArticle();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAjouterMateriels FP = new FormAjouterMateriels();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
            FP.CodeCategorie = comboCat.Text.Trim();
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                try
                {
                    chargmentComboArticle();
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
                    chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
