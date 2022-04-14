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
    public partial class FormAjoutLibele : Form
    {
        public FormAjoutLibele()
        {
            InitializeComponent();
        }

        public Boolean testeModification;
        public string CodeProjecte, LigneBudget;

        private void enregistraiment()
        {
            try
            {

                string s = " INSERT INTO tlibelProjet " +
                       "  (CodeProject,DesignationLibeleProject) " +
" VALUES        (@a,@b) ";

                String Supdate = "UPDATE       tlibelProjet " +
" SET               SET                DesignationLibeleProject = @b, CodeProject = @b " +
" WHERE        (CodeLibele = @c) ";


                string[] r = { tCodeProject.Text, tLibelleProjet.Text, tLigneCode.Text.Trim()};


                DateTime[] d = { DateTime.Now };

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
            if ((tCodeProject.Text.Trim() != "") && (tLibelleProjet.Text.Trim() != ""))
            {

                enregistraiment();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }
        }

        private void FormAjoutLibele_Load(object sender, EventArgs e)
        {
            tCodeProject.Text = CodeProjecte;
        }
    }
}
