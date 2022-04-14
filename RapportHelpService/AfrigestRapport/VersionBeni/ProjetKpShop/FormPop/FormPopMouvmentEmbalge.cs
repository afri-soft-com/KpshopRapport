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
    public partial class FormPopMouvmentEmbalge : Form
    {
        public FormPopMouvmentEmbalge()
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
        public string DEpotCentrale = "CD1";
        public string CaisseReception;
        public string NumOP, CodeDestination, CodeProvenance;
        public Boolean boolMisencirculation, boolSortieEnCiculatio, boolMouvment;

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableFacure;
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
        }

        public Double TauxRestourne;

        private void Bvalide_Click(object sender, EventArgs e)
        {
            EnregimentMvtEmblage();
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
        private void FormPopMouvmentEmbalge_Load(object sender, EventArgs e)
        {

            try
            {
                tNumOp2.Text = NumOP;
               // tCodeDepot.Text = CodeDepot;
                bwcharmemntCombo.RunWorkerAsync();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable TableFacure;
        private void chargemeentChargment()
        {
            try
            {

                //                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
                //" FROM tStock ";
                // string s = "SELECT   Compte as    Compte, CodeArticle AS  CodeChambre,DesegnationArticle AS  DesignationChambre, 0 as Qte, PrixVente AS TarifChambre " +
                //" FROM tStock WHERE  Compte =@a   ";
                // 0.0 AS Qte
                string s = "SELECT        Compte, CodeArticle , DesegnationArticle,  0.0 AS Qte, PrixVente  " +
" FROM tStock " +
" WHERE(Compte = @a AND indicateur <>1) ORDER BY CategorieArticle ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

                string[] r = { ClassVaribleGolbal. CompteEmbale };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableFacure = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void EnregimentMvtEmblage()
        {
            String Qte, Pu, CodeArticleEmb ;
            Double TotalSome ;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {

               
                Qte = dgFacturation["CQte", i].Value.ToString().Trim();
                Pu = dgFacturation["CPu", i].Value.ToString().Trim();
               // PriUniVente = dgFacturation["PunitaireVente", i].Value.ToString().Trim();
                CodeArticleEmb = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

                if (Double.Parse(Qte) != 0)
                {
                    try
                    {
                        TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                       // TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

                        string sPro = " INSERT INTO tMvtEmbalage " +
                        "  (NumOperation, CodeClient, CodeEmb, QteSortie, Sortie, PR) " +
" VALUES(@a, @b, @c, @d, @e, @f)";

                        string sDest = " INSERT INTO tMvtEmbalage " +
                       "  (NumOperation, CodeClient, CodeEmb, QteEntree, Entree, PR) " +
" VALUES(@a, @b, @c, @d, @e, @f)";

                        //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot };

                        string[] rDest = { tNumOp2.Text.Trim() ,CodeDestination , CodeArticleEmb , Qte , TotalSome.ToString() ,Pu};

                       string[] rPro = { tNumOp2.Text.Trim(), CodeProvenance, CodeArticleEmb, Qte, TotalSome.ToString(), Pu };







                        DateTime[] d = { DateTime.Now };

                        ClassRequette req = new ClassRequette();
                        if (boolMouvment == true)
                        {
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sPro, rPro, d);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sDest, rDest, d);

                        }
                        else if (boolMisencirculation == true)
                        {

                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sDest, rDest, d);

                          //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sRetour, r2, d);

                        }



                        else if (boolSortieEnCiculatio == true)
                        {

                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sPro, rPro, d);

                        }

                       
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



        Double TotalSomeQte;
        private void CalculdeTotal()
        {
            String Qte, Pu, CodeArticleEmb;
            TotalSomeQte=0;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {


                Qte = dgFacturation["CQte", i].Value.ToString().Trim();
                Pu = dgFacturation["CPu", i].Value.ToString().Trim();
                // PriUniVente = dgFacturation["PunitaireVente", i].Value.ToString().Trim();
                CodeArticleEmb = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

                if (Double.Parse(Qte) != 0)
                {
                    try
                    {
                        TotalSomeQte = TotalSomeQte+  Double.Parse(Qte) ;
                        // TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

                       
                        //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
                    }

                    catch (Exception ex)
                    {
                        TotalSomeQte = 0;
                        MessageBox.Show(ex.Message);
                    }

                }

            }



          //  MessageBox.Show("modification reussi");

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            try
            {
                CalculdeTotal();
                tQteTotal.Text = TotalSomeQte.ToString();

            }

            catch (Exception ex)
            {
                //TotalSomeQte = 0;
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           

        }
    }
}
