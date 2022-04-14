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
    public partial class FormRehercheEmballage : Form
    {
        public FormRehercheEmballage()
        {
            InitializeComponent();
        }


        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur = "STEVE", libeleOP;
        public string CompteClientOccasionnel = "41202";
        public string CompteClientProChambre = "41201";
        public string CompteClientOrdi = "411";
        public string CaisseReception;
        public string nomAchercher;
        public string REFpat;

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentDgAchercher();
        }

        private void tAchercher_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (bwcharmemntCombo.IsBusy == false)
                {
                    bwcharmemntCombo.RunWorkerAsync();
                    lMessage.Text = "ok";
                }
                else
                {

                    lMessage.Text = "PROCESSUS ENCOUR";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable TableAcherche;

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgAchercher.DataSource = TableAcherche;
            lMessage.Text = "SUCCES";
        }

        private void dgAchercher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            faireLarecherche();
        }
        private void faireLarecherche()
        {

            try
            {
                int ci;
                ci = dgAchercher.CurrentRow.Index;

                //string UTILISATEUR, CLIENT;

                REFpat = dgAchercher["Matricule", ci].Value.ToString().Trim();


                this.DialogResult = DialogResult.OK;
                FormEmballage.RefAchercher = REFpat;
              //  FormCaisse.RefAchercher = REFpat;
                // FormVente.RefAchercher = REFpat;
                // ClassVaribleGolbal.RefAchercher = REFpat;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRehercheEmballage_Load(object sender, EventArgs e)
        {
            tAchercher.Text = nomAchercher;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faireLarecherche();
        }

        private void chargemeentDgAchercher()
        {
            try
            {

                string a = "'%" + "stev" + " %'";
                string s = "SELECT        CodeClient, Cleint " +
" FROM            tClientEmb " +
" WHERE(CONCAT (CodeClient ,Cleint) LIKE \'%" + tAchercher.Text + "%\')";


                //" WHERE((DesignationCompte + NumCompte) LIKE \'%" + tAchercher.Text + "%\')";

                //CONCAT (NumCompte ,DesignationCompte)
                //" WHERE((Noms + Localite ) LIKE \'%" + tAchercher.Text + "%\')";
                ClassRequette classeReq = new ClassRequette();

                string[] r = { "%" + "stev" + " %" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableAcherche = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
