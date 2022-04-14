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
    public partial class FormLigneBudget : Form
    {
        public FormLigneBudget()
        {
            InitializeComponent();
        }

        public string codeLibele, CodeProject, DesignationLibeleProject;
       

        private void FormLigneBudget_Load_1(object sender, EventArgs e)
        {
            chargementLigneBigeteur();
            lProject.Text = " LIBELE : " + DesignationLibeleProject;
        }


        private void chargementLigneBigeteur()
        {
            string s = " SELECT        tlibelProjet.DesignationLibeleProject, tLigneBudget.CodeLibele, tLigneBudget.Idligne, tStock.DesegnationArticle, tStock.CodeArticle, tLigneBudget.Qte, tLigneBudget.PU, " +
    " (tLigneBudget.Qte* tLigneBudget.PU) AS Total  " +
   " FROM            tLigneBudget INNER JOIN  " +
                           " tlibelProjet ON tLigneBudget.CodeLibele = tlibelProjet.CodeLibele INNER JOIN  " +
                            " tStock ON tLigneBudget.CodeArticle = tStock.CodeArticle  WHERE        (tLigneBudget.CodeLibele = @a) ";
            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(s, codeLibele);
            dGlibeleProject.DataSource = Ccdt.tableEmoir;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAJoutLigneBudgjet FP = new FormAJoutLigneBudgjet();
            FP.Text = this.Text;
            FP.CodeProject = CodeProject;
            FP.CodeLibele = codeLibele;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargementLigneBigeteur();
            }
            else
            {
                chargementLigneBigeteur();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAJoutLigneBudgjet FP = new FormAJoutLigneBudgjet();
            FP.Text = this.Text;
            FP.CodeProject = CodeProject;
            FP.CodeLibele = codeLibele;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
            int ci;
            ci = dGlibeleProject.CurrentRow.Index;
            FP.Idligne = dGlibeleProject["Idligne", ci].Value.ToString();
            FP.testeModification = true;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargementLigneBigeteur();
            }
            else
            {
                chargementLigneBigeteur();

            }
        }
    }
}
