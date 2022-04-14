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
    public partial class FormPopFact : Form
    {

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

     //  Boolean test, test2;

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        public FormPopFact()
        {
            InitializeComponent();
        }
        public string NumOP;
        private void FormPopFact_Load(object sender, EventArgs e)
        {
            try
            {
                tNumOp2.Text = NumOP;
                bwcharmemntCombo.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentDgCAS();
        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableFacure;
        }

        private void dgFacturation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Ctotal=CPu*c
        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            ModifierLafacture();
        }
        private void ModifierLafacture()
        {
            String Qte, Pu, CodeSerice;
            Double TotalSome;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {

                //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // M
                //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
                Qte = dgFacturation["CQte", i].Value.ToString().Trim();
                Pu = dgFacturation["CPu", i].Value.ToString().Trim();
                CodeSerice = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();
              
                if (Double.Parse(Qte)!=0)
                {
                    try
                    {
                        TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                        string s = " UPDATE   tMvtChambre set    QteEntree=@a, PVentUN=@b,Entree=@c WHERE (NumOperation=@d AND  NumCompte=@e)";
                        string[] r = { Qte, Pu, TotalSome.ToString(), tNumOp2.Text.Trim(), CodeSerice.Trim() };
                        DateTime[] d = { DateTime.Now };

                        ClassRequette req = new ClassRequette();
                        req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                        // lmessage.Text = "&  Enregistrement effectué avec succès &";
                        // chargemeentDgELEVE();
                        //MessageBox.Show(CodeSerice.Trim());
                        //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }



            MessageBox.Show("modification reussi");
               
        }

        private void Bannuler_Click(object sender, EventArgs e)
        {

        }

        DataTable TableFacure;
        private void chargemeentDgCAS()
        {
            try
            {


                string s = "SELECT       Compte,  CodeChambre, DesignationChambre, 0 as Qte,TarifChambre " +
" FROM tChambre WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp ";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableFacure = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
