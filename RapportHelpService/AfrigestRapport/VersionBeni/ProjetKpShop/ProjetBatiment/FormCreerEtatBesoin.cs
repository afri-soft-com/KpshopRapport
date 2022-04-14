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
    public partial class FormCreerEtatBesoin : Form
    {
        public FormCreerEtatBesoin()
        {
            InitializeComponent();
        }
        public string CodeProjecte, LibelleProject;
        private void DGProjet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCreerEtatBesoin_Load(object sender, EventArgs e)
        {
            lProject.Text = " PROJET : " + LibelleProject;
            
        }

        private void chargmentEncour()
        {
            string s;
            string sEncour = "SELECT        CodeEtatdeBesoin, Etat, Demandeur, DateEmision, DateRequise, DesignationEtatDeBesion, CodeProject "  +
" FROM            tEtatDeBesoin " +
" WHERE        (CodeProject = @a)  AND (Etat = 0) ";






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, CodeProjecte);
            DGProjet.DataSource = Ccdt.tableEmoir;


        }


        private void chargmentCloture()
        {
            string s;
            string sEncour = "SELECT        CodeEtatdeBesoin, Etat, Demandeur, DateEmision, DateRequise, DesignationEtatDeBesion, CodeProject " +
" FROM            tEtatDeBesoin " +
" WHERE        (CodeProject = @a)  AND (Etat = 1) ";






            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTable(sEncour, CodeProjecte);
            DGProjet.DataSource = Ccdt.tableEmoir;


        }

        private void rbEncours_CheckedChanged(object sender, EventArgs e)
        {
            chargementdg();
        }

        private void chargementdg()
        {
            if (rbEncours.Checked == true)
            {
                chargmentEncour();
            }
            else if (rbClotures.Checked == true)
            {
                chargmentCloture();
            }
        }

        private void rbClotures_CheckedChanged(object sender, EventArgs e)
        {
            chargementdg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjoutEtatDeBesoin FP = new FormAjoutEtatDeBesoin();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            FP.CodeProject = CodeProjecte;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargementdg();
            }
            else
            {
                chargementdg();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDetaillEB FP = new FormDetaillEB();
            FP.Text = this.Text;
            int ci;
            FP.CodeProject = CodeProjecte;
            ci = DGProjet.CurrentRow.Index;
            FP.CodeEtatdeBesoin = DGProjet["CodeEtatdeBesoin", ci].Value.ToString();
            FP.DesignationEtatDeBesion = DGProjet["DesignationEtatDeBesion", ci].Value.ToString();
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


            string CodeOt;
            int ci;
            int Etat;
            ci = DGProjet.CurrentRow.Index;

            CodeOt = DGProjet["CodeEtatdeBesoin", ci].Value.ToString();
            Etat = int.Parse(DGProjet["ETAT", ci].Value.ToString());
             string[] r = { CodeOt,"1", ClassVaribleGolbal.UTILISATEUR };
             string[] r1 = { CodeOt, "0", ClassVaribleGolbal.UTILISATEUR };


            DateTime[] d = {tdateEB.Value };

            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT CLOTUREE  ? ", "CLOTURE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                LesClasses.ClasseOperationMvt clmvt = new LesClasses.ClasseOperationMvt();


                if (Etat ==0)
                {
                    clmvt.ModdifierlEtaOT(r, d);
                }
                else if (Etat == 1)
                {

                    FormPop.FormCodeSecurite FP = new FormPop.FormCodeSecurite();
                    FP.Text = this.Text;


                    DialogResult Dial = FP.ShowDialog();
                    if (Dial == DialogResult.OK)
                    {
                        if (ClassVaribleGolbal.codeINSRE == ClassVaribleGolbal.Motdepasse)
                        {
                            clmvt.ModdifierlEtaOT(r1, d);
                        }
                        else
                        {
                            MessageBox.Show("CODE INCORRECTE");
                        }

                    }
                    else
                    {


                    }

                }







                // chargmentPVEncour();
                chargementdg();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
