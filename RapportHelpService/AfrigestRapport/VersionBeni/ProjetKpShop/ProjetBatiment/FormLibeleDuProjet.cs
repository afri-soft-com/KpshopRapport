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
    public partial class FormLibeleDuProjet : Form
    {
        public FormLibeleDuProjet()
        {
            InitializeComponent();
        }

        public string CodeProject, LibelleProject;
        private void FormLibeleDuProjet_Load(object sender, EventArgs e)
        {
            chargmentLibelles();
            lProject.Text = " PROJET : " + LibelleProject;
        }


        private void chargmentLibelles()
        {
            
            string sEncour =" SELECT        DesignationLibeleProject, CodeLibele, CodeProject " +
" FROM            tlibelProjet " +
" WHERE        (CodeProject =@a) " ;






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, CodeProject);
            dGlibeleProject.DataSource = Ccdt.tableEmoir;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAjoutLibele FP = new FormAjoutLibele();
            FP.Text = this.Text;
            FP.CodeProjecte = CodeProject;

            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargmentLibelles();
            }
            else
            {
                chargmentLibelles();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjoutLibele FP = new FormAjoutLibele();
            FP.Text = this.Text;
            FP.CodeProjecte = CodeProject;
            FP.testeModification = true;

            int ci;
            ci = dGlibeleProject.CurrentRow.Index;
            FP.LigneBudget = dGlibeleProject["CodeLibele", ci].Value.ToString(); 

            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargmentLibelles();
            }
            else
            {
                chargmentLibelles();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLigneBudget FP = new FormLigneBudget();
            FP.Text = this.Text;
            FP.CodeProject = CodeProject;
           // FP.testeModification = true;

            int ci;
            ci = dGlibeleProject.CurrentRow.Index;
            FP.codeLibele = dGlibeleProject["CodeLibele", ci].Value.ToString();
            FP.DesignationLibeleProject = dGlibeleProject["DesignationLibeleProject", ci].Value.ToString();
            //FP.codeLibele = CodeProject;DesignationLibeleProject
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargmentLibelles();
            }
            else
            {
                chargmentLibelles();

            }
        }

    }
}
