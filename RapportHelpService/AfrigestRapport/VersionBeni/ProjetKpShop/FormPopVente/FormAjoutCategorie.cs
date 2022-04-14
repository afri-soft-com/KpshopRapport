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


namespace GoldenStarApplication.FormPopVente
{
    public partial class FormAjoutCategorie : Form
    {
        public FormAjoutCategorie()
        {
            InitializeComponent();
        }
       public Boolean testeModification;
        private void FormAjoutCategorie_Load(object sender, EventArgs e)
        {

            if  (testeModification == true)
            {
                BvALIDER.Text = "MODIFIER";
                tCode.Text = CodeCategorie;
                tDesCtegorie.Text = CodeCategorieDes;

            }
            else
            {

                BvALIDER.Text = "ENREGISTRER";
            }



        }
         public string CodeCategorie , CodeCategorieDes;
        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tCatArticle " +
                       "   (DesCategorieA, Compte) " +
" VALUES(@a, @b) ";

                String Supdate = " UPDATE       tCatArticle " +
" SET                DesCategorieA = @a, Compte = @b " +
" WHERE(IdCategorieArtilcle = @C)";


                string[] r = { tDesCtegorie.Text, ClasskpQuincaillerie.ComptStockQuincaillerie, ClassVaribleGolbal.CodeDepartement, tCode.Text };


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
            enregistraiment();
            
        }
    }
}
