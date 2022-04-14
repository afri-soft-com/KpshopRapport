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
    public partial class FormAjouterMateriels : Form
    {
        public FormAjouterMateriels()
        {
            InitializeComponent();
        }
        public string CodeCategorie;
        public Boolean testeModification;
        private void FormAjouterMateriels_Load(object sender, EventArgs e)
        {
            dernierPv();
        }

        private void dernierPv()
        {
            LesClasses.ClasseRequetteDernier clD = new LesClasses.ClasseRequetteDernier();
            string s = " SELECT        MAX(IdArticle) AS MaxIdPv  FROM            tStock";
            tCodeRef.Text =ClassVaribleGolbal.InitialDep+ clD.fonctionDernierEntre(s);

        }


        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tStock " +
                         " (CodeArticle, CodeDepartement, DesegnationArticle, CategorieArticle, PrixAchat, Compte) " +
" VALUES        (@a,@b,@c,@d,@e,@f) ";

                String Supdate = "UPDATE       tStock " +
" SET                CodeDepartement = @b, DesegnationArticle = @c, CategorieArticle = @d, PrixAchat = @e, Compte = @f " +
" WHERE        (CodeArticle = @a)";


                string[] r = { tCodeRef.Text,  ClassVaribleGolbal.CodeDepartement, tDesArticle.Text, CodeCategorie, tPu.Text, ClassVaribleGolbal.CompteStock};


                DateTime[] d = { DateTime.Now, DateTime.Now };

                ClassRequette req = new ClassRequette();
                if (testeModification == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Supdate, r, d);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tCodeRef.Text.Trim() != "") && (tDesArticle.Text.Trim() != ""))
            {

                enregistraiment();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }
        }
    }
}
