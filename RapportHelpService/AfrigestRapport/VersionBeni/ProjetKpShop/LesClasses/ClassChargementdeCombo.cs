using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
namespace GoldenStarApplication.LesClasses
{
    class ClassChargementdeCombo
    {
        //public CodeDepartement=11
        public void chargmentComboArtilce(ComboBox cb1, ComboBox cb2,string para )
        {
            string CodeDepartement = "11";
            string s = "SELECT        CodeArticle, DesegnationArticle, PrixVente,PrixAchat, CategorieArticle " +
" FROM            tStock " +
" WHERE         (CategorieArticle=@a) ";
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, para);
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;
            //cb3.DataSource = Ccdt.tableEmoir;

            cb1.ValueMember = "CodeArticle";
            cb1.DisplayMember = "CodeArticle";

            cb2.ValueMember = "CodeArticle";
            cb2.DisplayMember = "DesegnationArticle";

            //cb3.ValueMember = "Plaque";
            //cb3.DisplayMember = "DisignationVehicul";




        }



        public void chargmentComboCategorie(ComboBox cb1, ComboBox cb2, string para)
        {
            string CodeDepartement = "11";
            string s = "SELECT       DesCategorieA, IdCategorieArtilcle " +
" FROM            tCatArticle ";
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, para);
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;
            //cb3.DataSource = Ccdt.tableEmoir;

            cb1.ValueMember = "IdCategorieArtilcle";
            cb1.DisplayMember = "IdCategorieArtilcle";

            cb2.ValueMember = "IdCategorieArtilcle";
            cb2.DisplayMember = "DesCategorieA";

            //cb3.ValueMember = "Plaque";
            //cb3.DisplayMember = "DisignationVehicul";




        }



        public void chargmentComboArtileDelaLigne(ComboBox cb1, ComboBox cb2 , string para)
        {
            //string CodeDepartement = "11";
            string s = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tLigneBudget.CodeLibele, tLigneBudget.PU " +
" FROM            tLigneBudget INNER JOIN " +
                      "    tStock ON tLigneBudget.CodeArticle = tStock.CodeArticle "  +
" WHERE        (tLigneBudget.CodeLibele = @a)";
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, para);
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;
            //cb3.DataSource = Ccdt.tableEmoir;

            cb1.ValueMember = "CodeArticle";
            cb1.DisplayMember = "CodeArticle";

            cb2.ValueMember = "CodeArticle";
            cb2.DisplayMember = "DesegnationArticle";

            //cb3.ValueMember = "Plaque";
            //cb3.DisplayMember = "DisignationVehicul";




        }

        public void chargmentComboLibeleProjet(ComboBox cb1, ComboBox cb2, string para)
        {
           
            string s = "SELECT        CodeLibele, DesignationLibeleProject " +
" FROM            tlibelProjet "  +
" WHERE        (CodeProject = @a)";
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, para);
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;
            //cb3.DataSource = Ccdt.tableEmoir;

            cb1.ValueMember = "CodeLibele";
            cb1.DisplayMember = "CodeLibele";

            cb2.ValueMember = "CodeLibele";
            cb2.DisplayMember = "DesignationLibeleProject";

            //cb3.ValueMember = "Plaque";
            //cb3.DisplayMember = "DisignationVehicul";




        }


       public void chargementComboCompte(ComboBox cb1, ComboBox cb2, string para)
        {
            try
            {

                string s = " SELECT        NumCompte, GroupeCompte, DesignationCompte " +
" FROM            tCompte "  ;

             
               
                ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
                string[] r = {ClassVaribleGolbal.CodeDepartement, "0" };
                DateTime[] da = { DateTime.Now, DateTime.Now };
                 Ccdt.chargmentTableDateAvecParametre(s, r, da);
                cb1.DataSource = Ccdt.tableEmoir;
                cb2.DataSource = Ccdt.tableEmoir;
                //cb3.DataSource = Ccdt.tableEmoir;

                cb1.DisplayMember = "NumCompte";
                cb1.ValueMember = "NumCompte";
                cb2.ValueMember = "NumCompte";
                cb2.DisplayMember = "DesignationCompte";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chargmentComboAgent(ComboBox cb1, ComboBox cb2)
        {
            string s = "SELECT * from  tAgent";
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, "1");
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;


            cb1.ValueMember = "CodeAgent";
            cb1.DisplayMember = "CodeAgent";

            cb2.ValueMember = "CodeAgent";
            cb2.DisplayMember = "NomAgent";

        }




        public void chargmentEatBESION(ComboBox cb1, ComboBox cb2, ComboBox cb3)
        {
            string s = "SELECT        CodeEtatdeBesoin, DesignationEtatDeBesion, SUM(Total) AS Total, CodeProject, DesignationProject, Etat " +
" FROM            View_KpDetailleEB "  +
" GROUP BY CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, DesignationProject, Etat " +
" HAVING        (Etat = 1)"; ;
            ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            Ccdt.chargmentTable(s, "1");
            cb1.DataSource = Ccdt.tableEmoir;
            cb2.DataSource = Ccdt.tableEmoir;
            cb3.DataSource = Ccdt.tableEmoir;


            cb1.ValueMember = "CodeEtatdeBesoin";
            cb1.DisplayMember = "CodeEtatdeBesoin";

            cb2.ValueMember = "CodeEtatdeBesoin";
            cb2.DisplayMember = "DesignationEtatDeBesion";

            cb3.ValueMember = "CodeProject";
            cb3.DisplayMember = "CodeProject";

        }
    }
}
