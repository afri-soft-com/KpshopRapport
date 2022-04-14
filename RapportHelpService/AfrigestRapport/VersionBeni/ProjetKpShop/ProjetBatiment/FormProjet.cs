using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenStarApplication.ProjetBatiment
{
    public partial class FormProjet : Form
    {
        public FormProjet()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            chargmentDgProject();
        }

        private void chargmentDgProject()
        {

            if (rbEncours.Checked == true)
            {
                chargmentEncour();
            }

            else if (rbClotures.Checked == true)
            {
                chargmentCloturer();
            }


        }

        private void chargmentEncour()
        {
            string s;
            string sEncour = "SELECT        CodeProject, DesignationProject, DateDebut, DateFin, Lieu, ChefDuProjet, etat " +
 " FROM            tProject " +
" WHERE        (etat = 0)";


           



            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, "1");
            DGProjet.DataSource = Ccdt.tableEmoir;


        }

        private void chargmentCloturer()
        {
            string s;
            string sEncour = "SELECT        CodeProject, DesignationProject, DateDebut, DateFin, Lieu, ChefDuProjet, etat " +
 " FROM            tProject " +
" WHERE        (etat = 1)";






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, "1");
            DGProjet.DataSource = Ccdt.tableEmoir;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbClotures_CheckedChanged(object sender, EventArgs e)
        {
            chargmentDgProject();
        }

        private void FormProjet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAjouterUnProject FP = new FormAjouterUnProject();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargmentDgProject(); 
            }
            else
            {
                chargmentDgProject(); 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLibeleDuProjet FP = new FormLibeleDuProjet();
            FP.Text = this.Text;
            int ci;
            ci = DGProjet.CurrentRow.Index;
            FP.CodeProject = DGProjet["CodeProject", ci].Value.ToString();
            FP.LibelleProject = DGProjet["DesignationProject", ci].Value.ToString(); 
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


               // chargmentDgProject();
            }
            else
            {
               // chargmentDgProject();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            string sPro2 = "KpbRapporDeBudjetInitial";
            // DataTable tablePlan;
            int ci;
                string CodeProject;
            ci = DGProjet.CurrentRow.Index;
            CodeProject = DGProjet["CodeProject", ci].Value.ToString();
            string chiminRap = "Rapport/KP/KPb/ReportBudjetIinitial.rdlc";
            string[] parametre = { CodeProject };
            DateTime[] d = { DateTime.Now, DateTime.Now };
            clrap.affichetOUUrAPPOR(sPro2, chiminRap, parametre, d);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCreerEtatBesoin FP = new FormCreerEtatBesoin();
            FP.Text = this.Text;
            int ci;
            ci = DGProjet.CurrentRow.Index;
            FP.CodeProjecte = DGProjet["CodeProject", ci].Value.ToString();
            FP.LibelleProject = DGProjet["DesignationProject", ci].Value.ToString();
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                // chargmentDgProject();
            }
            else
            {
                // chargmentDgProject();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            string sPro2 = "KpbRapporDeBudjetSuivieFinanciere";
            string sPro3 = "KpbRapporDeBudjetInitial";
            // DataTable tablePlan;
            int ci;
            string CodeProject;
            ci = DGProjet.CurrentRow.Index;
            CodeProject = DGProjet["CodeProject", ci].Value.ToString();
            string chiminRap = "Rapport/KP/KPb/ReportSuivieFin.rdlc";
            string[] parametre = { CodeProject };
            DateTime[] d = { DateTime.Now, DateTime.Now };
            clrap.affichetOUUrAPPORavecDeux(sPro2,sPro3, chiminRap, parametre, d);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCaisse FP = new FormCaisse();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                // chargmentDgProject();
            }
            else
            {
                //chargmentDgProject();

            }
        }
    }
}
