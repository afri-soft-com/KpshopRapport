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
    public partial class FormAjoutDetailEB : Form
    {
        public FormAjoutDetailEB()
        {
            InitializeComponent();
        }

        private void FormAjoutDetailEB_Load(object sender, EventArgs e)
        {
            chargmentComboLigneLibelle();
            tRefEb.Text = CodeEtatdeBesoin;
        }

        private void chargmentComboArticle()
        {
            string Codelibele= comboLib.Text;
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargmentComboArtileDelaLigne(comboArticle, comboArticleDes,Codelibele);
        }


        private void chargmentComboLigneLibelle()
        {
           // MessageBox.Show(CodeProject);
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargmentComboLibeleProjet(comboLib, comboLibDes, CodeProject);
        }

        public String CodeEtatdeBesoin, CodeProject, Idligne;// CodeLibele, CodeProject, Idligne;
        public Boolean testeModification;
        private void enregistraiment()
        {
            try
            {

                string s = " INSERT INTO tDetailEtatBesoin " +
                        "  (CodeEtatdeBesoin, CodeLibele, CodeArticle, Qte, Pu) " +
" VALUES        (@a,@b,@c,@d,@e) ";

                String Supdate = " UPDATE       tDetailEtatBesoin  " +
 " SET                CodeEtatdeBesoin = @a, CodeLibele = @b, CodeArticle = @c, Qte = @d, Pu = @e " +
" WHERE        (IdDetailEB = @f) ";


                string[] r = { tRefEb.Text.Trim(), comboLib.Text.Trim(), comboArticle.Text.Trim(), tQte.Text, tPu.Text };
                string[] r2 = { tRefEb.Text.Trim(), comboLib.Text.Trim(), comboArticle.Text.Trim(),tQte.Text, tPu.Text,  Idligne };


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

        private void comboLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargmentComboArticle();
        }

        private void comboLibDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargmentComboArticle();
        }

        private void bValide_Click(object sender, EventArgs e)
        {
            if ((tRefEb.Text.Trim() != "") && (tQte.Text.Trim() != ""))
            {

                enregistraiment();
                annuler();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }
        
    }


        private void annuler()
        {
            tPu.Text = "";
            tQte.Text = "";

        }

        private void tRefEb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chargmentComboLigneLibelle();
        }

        private void comboArticleDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboArticleDes.ValueMember = "PU";
            tPu.Text = comboArticleDes.SelectedValue.ToString() ;
        }
    }
}
