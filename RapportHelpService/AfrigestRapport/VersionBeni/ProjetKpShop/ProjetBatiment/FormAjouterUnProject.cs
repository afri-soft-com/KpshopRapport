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
    public partial class FormAjouterUnProject : Form
    {
        public FormAjouterUnProject()
        {
            InitializeComponent();
        }

        private void FormAjouterUnProject_Load(object sender, EventArgs e)
        {
            dernierPv();
        }

        public Boolean testeModification;
        private void dernierPv()
        {
            LesClasses.ClasseRequetteDernier clD = new LesClasses.ClasseRequetteDernier();
            string s = " SELECT        MAX(IdProject) AS MaxIdPv  FROM            tProject";
            tcodeProject.Text = clD.fonctionDernierEntre(s);

        }


        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tProject " +
                       "  (CodeProject, DesignationProject, Lieu, ChefDuProjet, DateDebut, DateFin)" +
" VALUES        (@a,@b,@c,@d,@da,@db) ";

                String Supdate = "UPDATE       tProject " +
" SET                CodeProject = @a, DesignationProject = @b, Lieu = @c, ChefDuProjet = @d, DateDebut = @da, DateFin = @db " +
" WHERE        (CodeProject = @a) ";


                string[] r = { tcodeProject.Text, tLibeleProject.Text, tLIEU.Text, tChefDuProject.Text };


                DateTime[] d = { tDateDebut.Value, tDateFIN.Value };

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
            if ((tcodeProject.Text.Trim() != "") && (tLibeleProject.Text.Trim() != ""))
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
