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
    public partial class FormPopMouvementIntaire : Form
    {

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur = "STEVE", libeleOP;
        public string CompteClientOccasionnel = "41202";
        public string CompteClientProChambre = "41201";
        public string DEpotCentrale = "CD1";
        public FormPopMouvementIntaire()
        {
            InitializeComponent();
        }

        private void FormPopMouvementIntaire_Load(object sender, EventArgs e)
        {


            try
            {
                //tNumOp2.Text = NumOP;
               // tCodeDepot.Text = CodeDepot;
                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                bwcharmemntCombo.RunWorkerAsync();
               



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

        DataTable TableInventaire;
        private void chargemeentChargment()
        {
            try
            {

                //                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
                //" FROM tStock ";
                // string s = "SELECT   Compte as    Compte, CodeArticle AS  CodeChambre,DesegnationArticle AS  DesignationChambre, 0 as Qte, PrixVente AS TarifChambre " +
                //" FROM tStock WHERE  Compte =@a   ";

                string s = "SELECT        tInventaire.CodeArticle, tStock.DesegnationArticle, tInventaire.Physique, tInventaire.Aretire, tInventaire.StockSurCamion, tInventaire.IdInvetaire " +
" FROM            tInventaire INNER JOIN " +
                         " tStock ON tInventaire.CodeArticle = tStock.CodeArticle "+
" WHERE        (tInventaire.DateInventaire = @da)  ORDER BY tStock.Compte, tStock.IdArticle   ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

               string[] r = { ""};
               DateTime[] pd = { tDate1 .Value};



                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r,pd);


                TableInventaire = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableInventaire;
        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            ModifierLeChargement();
        }


        private void ModifierLeChargement()
        {
            String QtePh, QteAR, idInventaire, QteCamion;
           // Double TotalSome, TotalSomeVente;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {

                //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // M
                //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
                QtePh = dgFacturation["Physique", i].Value.ToString().Trim();
                QteAR = dgFacturation["Aretire", i].Value.ToString().Trim();
                QteCamion = dgFacturation["StockSurCamion", i].Value.ToString().Trim();
                idInventaire = dgFacturation["IdInvetaire", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

               
                    try
                    {
                        //TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                        //TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

                        string s = " UPDATE   tInventaire set    Physique=@a, Aretire=@b,StockSurCamion=@c WHERE IdInvetaire=@d";

                        string[] r = { QtePh, QteAR, QteCamion, idInventaire };


                       
                        DateTime[] d = {tDate1.Value};

                        ClassRequette req = new ClassRequette();
                       
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                            //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r2, d);

                       

                        

                        //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                

            }



            //MessageBox.Show("modification reussi");

        }

    }
}
