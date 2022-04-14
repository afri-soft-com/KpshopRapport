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

namespace GoldenStarApplication
{
    public partial class FormRecherche : Form
    {
        public FormRecherche()
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
       
        //

       // Boolean test, test2;

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormRecherche_Load(object sender, EventArgs e)
        {
            tAchercher.Text = nomAchercher;
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            
           chargemeentDgAchercher();
        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgAchercher.DataSource = TableAcherche;
            lMessage.Text = "SUCCES";
        }
        public string nomAchercher;
        private void tAchercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (bwcharmemntCombo.IsBusy==false)
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
        public string REFpat;

        private void faireLarecherche()
        {

            try
            {
                int ci;
                ci = dgAchercher.CurrentRow.Index;

                //string UTILISATEUR, CLIENT;

                REFpat = dgAchercher["Matricule", ci].Value.ToString().Trim();


                this.DialogResult = DialogResult.OK;
               // FormLogement.RefPatiant = REFpat;
                FormVente.RefAchercher = REFpat;
                ClassVaribleGolbal.RefAchercher = REFpat;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            faireLarecherche();

        }

        private void dgAchercher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int ci;
            //    ci = dgAchercher.CurrentRow.Index;

            //    //string UTILISATEUR, CLIENT;

            //    REFpat = dgAchercher["CompteClient", ci].Value.ToString().Trim();


            //    this.DialogResult = DialogResult.OK;
            //    FormLogement.RefPatiant = REFpat;

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            faireLarecherche();

        }

        DataTable TableAcherche;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void chargemeentDgAchercher()
        {
            try
            {

                string a = "'%" + "stev" + " %'";
                string s = "SELECT        Noms, Localite, Telephone1, Telephone2, Email, site, Adresse, IdClient, Matricule " +
" FROM tInformationClient "+
" WHERE((Noms + Localite ) LIKE \'%" + tAchercher.Text + "%\')";



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
