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
    public partial class FormAchaProduit : Form
    {
        public FormAchaProduit()
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
        public string CompteFournissseur,CompteVariation,CompteMarchandise, CategorieArticle;
        public string CaisseReception;
        public string NumOP, CodeDepot, Compte, DesDepot, Vendeur;
        
        public Boolean boolRetourDeStock, boolCharmentStock, boolVenteClient, boolAchat, boolDegusate, boolCaseMaquant, boolAutreSotie, boolAchatBon;
        public Boolean boolEnArgent;
        public Double TauxRestourne;


        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        private void FormAchaProduit_Load(object sender, EventArgs e)
        {


            try
            {
                tNumOp2.Text = NumOP;
                tCodeDepot.Text = CodeDepot;
                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                tVariation.Text = CompteVariation;
                tCompte.Text = Compte;
                tCompteFournisseur.Text = CompteFournissseur;

                bwcharmemntCombo.RunWorkerAsync();
                if (boolCharmentStock == true)
                {

                    lAfichage.Text = " CHARGEMENT DE :   \n" + DesDepot;
                }
                else if (boolRetourDeStock == true)
                {
                    lAfichage.Text = " RETOUR DE STOCK :  \n" + DesDepot;
                    //boolVenteClient
                }

                else if (boolVenteClient == true)
                {
                    lAfichage.Text = " VENTE :  \n" + DesDepot + "/" + Vendeur;
                    //boolVenteClient
                }
                else if (boolAchat == true)
                {
                    lAfichage.Text = " ACHATS ";
                    //boolVenteClient
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
        }

        DataTable TableFacure;
        private void chargemeentChargment()
        {
            try
            {



                string s = " SELECT        Compte, CodeArticle AS CodeChambre, DesegnationArticle AS DesignationChambre, 0.0 AS Qte, 0.0 AS PU  " +
                    " FROM            tStock  WHERE CodeDepartement=@a ";                   



//                string s = " SELECT        Compte, CodeArticle AS CodeChambre, DesegnationArticle AS DesignationChambre, 0.0 AS Qte, 0.0 AS PU  " +
//" FROM            tStock " +
//                         " WHERE        (Compte=@a) AND (CategorieArticle=@b) " +
//" ORDER BY Compte, IdArticle ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

                string[] r = {ClassVaribleGolbal.CodeDepartement };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                TableFacure = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableFacure;
        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            ModifierLeChargement();
        }


        private void ModifierLeChargement()
        {
            String Qte, Pu, CodeSerice, PriUniVente;
            Double TotalSome, TotalSomeVente;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {

                //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // M
                //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
                Qte = dgFacturation["CQte", i].Value.ToString().Trim();
                Pu = dgFacturation["CPu", i].Value.ToString().Trim();
               // PriUniVente = dgFacturation["PunitaireVente", i].Value.ToString().Trim();
                CodeSerice = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

                if (Double.Parse(Qte) != 0)
                {
                    try
                    {
                        TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                       // TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

                      

                        string sAchat = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAchat,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";
                        string sEntreeProduit = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAutre,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";
                        string sModifier = " UPDATE       tStock SET         PrixAchat = @b WHERE        (CodeArticle = @a) ";


                        string[] r = { tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot, Qte, Pu, TotalSome.ToString(), Qte, Pu };
                        string[] rModifier = { CodeSerice.Trim(), Pu };

                      

                        DateTime[] d = { DateTime.Now };

                        ClassRequette req = new ClassRequette();
                        if (boolAchatBon == true)
                        {
                            //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                           // req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r2, d);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sEntreeProduit, r, d);

                        }
                       
                        else if (boolAchat == true)
                        {
                            //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAchat, r, d);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sModifier, rModifier, d);
                            //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

                            //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

                        }

                       

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



            //MessageBox.Show("modification reussi");

        }

    }
}
