using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1;

namespace GoldenStarApplication.FormPop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
            chargementCompte();
        }
        DataTable TableComboCategorie;
        private void chargementCompte()
        {

            try
            {


                string s = "SELECT        CategorieClient, DesignationCatClient, Autres " +
 " FROM            tCategorieCleint ";



                ClassRequette classeReq = new ClassRequette();
                //tDernierMat.Text
                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableComboCategorie = classeReq.dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboCateGorie.DataSource = TableComboCategorie;
            comboCateGorie.DisplayMember = "DesignationCatClient";
            comboCateGorie.ValueMember = "CategorieClient";


        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  MODIFIER LE TAUX DE RISTOURNE  ?  ==== " + ClassVaribleGolbal.DateDuJOUR, "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {

                    string s = "UPDATE       tCompte " +
" SET PourcentPv=@a" +
" FROM            tInformationClient INNER JOIN "+
                        "  tCompte ON tInformationClient.Matricule = tCompte.Matricule " +
" WHERE(tInformationClient.CategorieClient = @B)";
                    string[] r = { tPourcentage.Text, comboCateGorie.SelectedValue.ToString() };
                    DateTime[] d = { DateTime.Parse(tDate1.Text) };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);



                   // tSmsNonEnvoy.Text = fonctionNombreNonEnoye(); ;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
