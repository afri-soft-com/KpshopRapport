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
    public partial class FormChangementPrix : Form
    {
        public FormChangementPrix()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public string NumOP, CodeDepot, Compte;
        private void FormChangementPrix_Load(object sender, EventArgs e)
        {
            bwcharmemntCombo.RunWorkerAsync();
        }

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        DataTable TablePrix;
        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DGsommaireSTOCK.DataSource = TablePrix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            ModifierLeChargement();
        }
        private void ModifierLeChargement()
        {
            String  Pu, CodeArticle,PuR;
           // Double TotalSome, TotalSomeVente;
            for (int i = 0; i <= DGsommaireSTOCK.Rows.Count - 1; i++)
            {

                //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // M
                //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
                CodeArticle = DGsommaireSTOCK["CodeArticle", i].Value.ToString().Trim();
                Pu = DGsommaireSTOCK["PrixAmodif", i].Value.ToString().Trim();
                PuR = DGsommaireSTOCK["PRIXrest", i].Value.ToString().Trim();
                //CodeSerice = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

                if (Double.Parse(Pu) != 0)
                {
                    try
                    {
                        UpdateInitVente(CodeArticle, Pu);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                if (Double.Parse(PuR) != 0)
                {
                    try
                    {
                        UpdateInitRestourne(CodeArticle, PuR);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }



            MessageBox.Show("modification reussi");

        }
        private void UpdateInitVente(String Para, String Para2)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = "UPDATE       tPametreDepot " +
" SET   PuVente = @PuVente " +
" WHERE(CodeDepot = @CodeDepot) AND(CodeArticle = @CodeArticle) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeArticle", Para);
                cmd.Parameters.AddWithValue("@PuVente", Para2);
                cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                //cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));

                cmd.ExecuteNonQuery();

                //  lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
              //  MessageBox.Show(" LE PRIX EST MODIFIE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }

        private void UpdateInitRestourne(String Para, String Para2)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = "UPDATE       tPametreDepot " +
" SET   PrixRestourne=@PuVente " +
" WHERE(CodeDepot = @CodeDepot) AND(CodeArticle = @CodeArticle) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeArticle", Para);
                cmd.Parameters.AddWithValue("@PuVente", Para2);
                cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                //cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));

                cmd.ExecuteNonQuery();

                //  lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
                //  MessageBox.Show(" LE PRIX EST MODIFIE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }
        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
        }


        private void chargemeentChargment()
        {
            try
            {

                //                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
                //" FROM tStock ";
                // string s = "SELECT   Compte as    Compte, CodeArticle AS  CodeChambre,DesegnationArticle AS  DesignationChambre, 0 as Qte, PrixVente AS TarifChambre " +
                //" FROM tStock WHERE  Compte =@a   ";
               // MessageBox.Show(CodeDepot);
                string s = "SELECT        tStock.CodeArticle , tStock.DesegnationArticle , 0.0 AS PRIX, 0.0 AS PRIXrest, tPametreDepot.PuVente AS PrixVenteLocale,tPametreDepot.PrixRestourne, tPametreDepot.CodeDepot " +
" FROM tStock INNER JOIN " +
                        " tPametreDepot ON tStock.CodeArticle = tPametreDepot.CodeArticle " +
" WHERE(tPametreDepot.CodeDepot = @a)  AND (tStock.Compte = @b) ORDER BY tStock.Compte, tStock.IdArticle ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

                string[] r = { CodeDepot,Compte };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TablePrix = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
