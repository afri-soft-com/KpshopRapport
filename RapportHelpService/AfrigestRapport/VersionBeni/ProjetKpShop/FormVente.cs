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
    public partial class FormVente : Form
    {
        public FormVente()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP, CodeDepot, CodeVendeur, NomsVendeur;
       // Boolean test, test2;
        String Localite;
        String DepotMagasin = "CD1";
        public static string RefAchercher;
        //string CodeDepot;
        Double Taux, TauxRestourne, TauxTrans, TauxProduit,TauxEmb;
        int IdService, IdCpte;
        public string CompteClientOrdi = "411";
        String tpv;
        Boolean BoolRappelDeDate;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        String Unite;
        private void FormVente_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            BwchalrgmentCombo.RunWorkerAsync();
            tDate.Value = ClassVaribleGolbal.DateDuJOUR;
            tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
            tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
            tDteJ.Value = ClassVaribleGolbal.DateDuJOUR;
            lVendeur.Text = NomsVendeur;
            Taux = ClassVaribleGolbal.TauxFc;
            TauxTrans= ClassVaribleGolbal.TauxTrans;
            TauxProduit= ClassVaribleGolbal.FraisdeTransProduit;
            TauxEmb= ClassVaribleGolbal.FraisdeTransEmbllage;

            // ltAUXtransp.Text= ( TauxTrans * Taux).ToString();
            ltauxFC.Text = Taux.ToString();
            ltaux.Text = Taux.ToString();
            SupprimerOratioNonValide();

        }

       // Boolean TesteChargmentDgSommaireArticle;
        private void BwchalrgmentCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            ChargmentDepot();
            ChargmenComboCompte();
            ChargmentDepot2();
            ChargmentDegMouvemennt();
        }

        Boolean OperationCuisine;
        public void afficherLacuisine(Boolean b, string libili, string libele2)
        {
            // pCache.Visible = b;
            tabPage3.Text = libili;
            llibeleVente.Text = libili;
            tabPage2.Text = libele2;

        }



        public void afficherPAsCuisine(Boolean b, string libele2)
        {
            // pCache.Visible = b;
            pRepa1.Visible = b;

            pRepa2.Visible = b;
            //tabPage3.Text = libili;
            // llibeleVente.Text = libili;
            tabPage2.Text = libele2;

        }
        private void BwchalrgmentCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChargementComboDepot(tableDepot, comboCodeDepot2, comboDepoDES2);
            ChargementCombo(TableCompte, comboCompteStock, comboStockDes);
            ChargementCombo(TableCompte, comboCompteVente2, comboCompteVente2Des);
            ChargementCombo(TableCompte2, comboCompteDestockage, combooDestockageDES);
            // ChargementComboDepot(tableDepot, comboCodeDepot2, comboDepoDES2);
            ChargementComboDepot2(tableDepot2, comboDepot, comboDepotDes);

            DgMouvementService.DataSource = TableMouvemrntService;
            //comboCodeDepot2.ValueMember=
            try
            {
                IdService = int.Parse(comboCodeDepot2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            lDepot.Text = comboDepoDES2.Text;
            lDepot2.Text = comboDepoDES2.Text;
            Caisservise = CompteDEservicleint(51, IdService);
            tNumOp2.Text = fonctionOPSotie();
            tNumRef.Text = fonctionMvtStock();
            //if (IdService == 8)
            //{
            //    afficherLacuisine(false, "     VENTILLE LES STOK DE LA CUISINE  ", " STOCKAGE REPAS      ");
            //    OperationCuisine = true;
            //    tAdebut2.Text = "000";

            //}
            //else
            //{
            //    afficherPAsCuisine(false, "");
            //}
        }
        private string CompteDEservicleint(int type, int sevice)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT NumCompte FROM tPServiceStock WHERE (Type = @a) AND (NumDeservice = @b)";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", type);
            cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = cmd.ExecuteScalar().ToString();

            }

            catch
            {
                compte = "";
            }
            return compte;


            cmd.Dispose();
            con.Close();

        }


        private string CompteAutomati(int indicatcateur)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT NumCompte FROM tCompte WHERE (IindicateurCompte = @a) ";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", indicatcateur);
            //cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = cmd.ExecuteScalar().ToString();

            }

            catch
            {
                compte = "";
            }
            return compte;


            cmd.Dispose();
            con.Close();

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

        DataTable tableDepot;

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        DataTable TableCompte, TableCompte2;
        private void ChargmenComboCompte()
        {
            try
            {


                string sCompte = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation,tCompte.Unite,tCompte.IindicateurCompte" +
" FROM tCompte INNER JOIN " +
" tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Cadre = 31) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                string[] r = { "" };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCompte = classeReq.dt;

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                TableCompte2 = classeReq.dt;
                //MessageBox.Show("ok");
                // comboCompteVente2.DataSource = TableCompte;
                // comboCompteVente2.DisplayMember = "NumCompte";
                //   DGsommaireSTOCK .DataSource = classeReq.dt;

                // comboPreIns.ValueMember = "MatriculeEleve";
                //                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;

            }








            //  da.Dispose();
        }
        private void ChargementCombo(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "NumCompte";
            id.ValueMember = "NumCompte";
            des.ValueMember = "NumCompte";
            des.DisplayMember = "DesignationCompte";

        }

        private void bwChargmentDG_DoWork(object sender, DoWorkEventArgs e)
        {
            ChargmenTdgSOMMAIRparDpot();



        }
        private string fonctionOP()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperation";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString());
            numOperation = "ME" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        private void bwChargmentDG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DGsommaireSTOCK.DataSource = TableDgSommaire;
            //chargementComboCompteCat(comboTypeDestockage, comboTypeDestockageDES, TableCategorie3);

            ChargementComboPourCodeArticle(comboArticleDestockage, comboArticleDestokageDes, TableDgSommaire2);
            ChargementComboPourCodeArticle(comboCodeArticleStock, comboCodeArticleStockDes, TableDgSommaire2);
            tNumOP.Text = fonctionOP();

            //TesteChargmentDgSommaireArticle = false;

        }
        private void ChargementComboPourCodeArticle(ComboBox id, ComboBox des, DataTable t1)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "CodeArticle";
            id.ValueMember = "CodeArticle";
            des.ValueMember = "CodeArticle";
            des.DisplayMember = "DesegnationArticle";

        }
        private void EnrmouvemmentComptble()
        {
            try
            {


                enregOprationComptable();

                if (RbProduction.Checked == true)
                {
                    InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, CodeDepot, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);

                    InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteStock.Text, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", "0", "0", "0", DepotMagasin, "0", tNumOP.Text);
                    // InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, DepotMagasin, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);

                    InserMvtCpteStockAvecQte2("insererMvtcpt", tVariariotion.Text, "0", tQteEntree.Text, tQtePu.Text, "0", tTotalStock.Text, "0", "0", "0", DepotMagasin, "0", tNumOP.Text);

                }
                else if (rbRavitaillement.Checked == true)
                {
                    InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, comboDepot.Text, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);
                    InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, CodeDepot, "0", tQteEntree.Text, tQtePu.Text, "0", tTotalStock.Text, tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);


                }


                UpdateInitPU(comboCodeArticleStock.Text, tQtePu.Text);
                ChargmentGg10DernierOP();
                //ChargmentGg10DernierOP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }
        private void UpdateInitPU(String Para, String Para2)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = "UPDATE       tStock SET                PrixAchat = @PrixAchat WHERE        (CodeArticle = @CodeArticle)";
                // "   WHERE        (CodeArticle = @CodeArticle) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeArticle", Para);
                cmd.Parameters.AddWithValue("@PrixAchat", Para2);
                //cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));

                cmd.ExecuteNonQuery();

                //  lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
                // MessageBox.Show(" EST AJOUTE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

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
                MessageBox.Show(" LE PRIX EST MODIFIE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }
        private void ChargmentGg10DernierOP()
        {
            try
            {

                Connection_Data();
                con.Open();
                ////                cmd.CommandText = " SELECT     TOP 20   tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
                ////"FROM            tCompte INNER JOIN" +
                ////                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                ////                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
                ////" WHERE(tOperation.DateOp = @DateOp) AND(tOperation.NomUt = @NomUt) " +
                ////" ORDER BY tOperation.NumOpSource DESC ";
                cmd.CommandText = "SELECT        TOP (20) tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tDepot.DesignationDepot, tOperation.NumOperation, tOperation.Libelle " +
 " FROM tOperation INNER JOIN " +
                         "  tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                          " tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                         "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
                         " WHERE        (tOperation.DateOp = @DateOp)  AND (tOperation.NumOperation <> N'INITIAL') " +
" ORDER BY tOperation.NumOpSource DESC";




                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate.Text));
                cmd.Parameters.AddWithValue("@NomUt", utilisateur);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                JournalOP = dt;

                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }
        private void enregOprationComptable()
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f, @da)";

                string[] r = { tNumOP.Text, tLibelle.Text, utilisateur, "0", "0", " " };
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
                MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        Boolean TesteDestockage, Tesstockage;
        private void DGsommaireSTOCK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  DGsommaireSTOCK.DataSource = DGsommaireSTOCK;
        }

        private void comboCompteVente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TesteChargmentDgSommaireArticle = true;
            if (bwChargmentDG.IsBusy == false)
            {
                bwChargmentDG.RunWorkerAsync();
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private string fonctionOPSotie()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            string s = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperation";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString()) +1;
            numOperation = "ST" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
         
        private int fonctionValiderLop()
        {

           // string numOperation;
            int dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        Valider  FROM            tOperation WHERE        (NumOperation='ST3560ST')";
            cmd.Connection = con;
            cmd.CommandText = s;
          // cmd.Parameters.AddWithValue("@a", tNumOp2.Text.Trim());
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = int.Parse(cmd.ExecuteScalar().ToString());
           // numOperation = "ST" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return dernier;


            cmd.Dispose();
            con.Close();

        }
        private string fonctionMvtStock()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            string s = "SELECT        MAX(NumRef) AS DernierOp FROM            tMvtStock";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString());
            numOperation = dernier.ToString();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
        String Caisservise;
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            //PCredit.Visible = rbCredit.Checked;
            // lPour.Enabled = rbCash.Checked;
            // tPour.Enabled = rbCash.Checked;
            tNumOp2.Text = fonctionOPSotie();
            tNumRef.Text = fonctionMvtStock();//DrnierOpPaiement2();

            tAdebut2.Text = "";
            //if (rbCash.Checked == true)
            //{
            //    tAdebut2.Text = Caisservise;
            //    //rbLoge2.Checked = false;
            //   // RbAncienClient2.Checked = false;
            //}
            //else
            //{

            //}


            try
            {
                comboCompteDestockage.ValueMember = "Variation";
                string v = comboCompteDestockage.SelectedValue.ToString();
                affectationCompteVariation(v);
                comboCompteDestockage.ValueMember = "Unite";
                Unite = comboCompteDestockage.SelectedValue.ToString();
            }
            catch
            {


            }



        }

        private void pCache_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGjournal2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
        }



      //  Boolean ClientOrdinnaire, ClientDechambe, ClientOccasionnel, AncienClients, AutreCompte;


        private void rBclientOrd2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }
        DataTable ComboPaiement;
        private void bWchargmentPaiement_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ChargementDelOperation();

            if (BoolChargmenRest == true)
            {


                comboCptCourant.DataSource = TableCompteCouran;
                comboCptCourant.DisplayMember = "NumCompte";
                comboCptCourant.ValueMember = "NumCompte";

                comboCptCourantDes.DataSource = TableCompteCouran;
                comboCptCourantDes.DisplayMember = "DesignationCompte";
                comboCptCourantDes.ValueMember = "NumCompte";


                comboCptRestourne.DataSource = TableCompteRestourne;
                comboCptRestourne.DisplayMember = "NumCompte";
                comboCptRestourne.ValueMember = "NumCompte";
                try
                {
                   // String tpv;
                    comboCptRestourne.ValueMember = "PourcentPv";
                    tpv = comboCptRestourne.SelectedValue.ToString();
                    
                    TauxRestourne = Double.Parse(tpv);
                    Lpv.Text = tpv;
                    comboCptRestourne.ValueMember = "NumCompte";

                }
                catch
                {
                    //comboCptRestourne.ValueMember = "NumCompte";

                }



                comboCptRestourneDes.DataSource = TableCompteRestourne;
                comboCptRestourneDes.DisplayMember = "DesignationCompte";
                comboCptRestourneDes.ValueMember = "NumCompte";



            }
            else
            {


                ComboMatricule.DataSource = ComboPaiement;
                ComboMatricule.DisplayMember = "Matricule";
                ComboMatricule.ValueMember = "Matricule";

                ComboNomClient.DataSource = ComboPaiement;
                ComboNomClient.DisplayMember = "Noms";
                ComboNomClient.ValueMember = "Matricule";



                comboLoclite.DataSource = ComboPaiement;
                comboLoclite.DisplayMember = "Localite";
                comboLoclite.ValueMember = "Matricule";







            }


            BoolChargmenRest = false;





        }
        string CodeChambreAfactre2;
        private void ComboChambreOcuppe2_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                // CodeChambreAfactre2 = ComboChambreOcuppe2.SelectedValue.ToString();
            }
            catch
            { }
        }

        private void comboCompteDesClient2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                // tPour.Text = comboCompteDesClient2.Text;
            }
            catch
            { }
        }

        private void comboCodeClient2_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void comboCompteDestockage_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectioAricle();



        }


        private void selectioAricle ()
        {

            try
            {
                comboCompteDestockage.ValueMember = "Variation";
                string v = comboCompteDestockage.SelectedValue.ToString();
                affectationCompteVariation(v);
                comboCompteDestockage.ValueMember = "Unite";
                Unite = comboCompteDestockage.SelectedValue.ToString();

                comboCompteDestockage.ValueMember = "IindicateurCompte";
                IdCpte = int.Parse(comboCompteDestockage.SelectedValue.ToString());


                if ( RbDeguStation .Checked == true)
                {
                    ltAUXtransp.Text = (TauxTrans * Taux).ToString();
                    tSommeCredit.Enabled = true;

                }
                 else
                {

                    if (IdCpte == 310)
                    {

                        //if (IdCpte != 14)


                        ltAUXtransp.Text = TauxProduit.ToString();

                        //  MessageBox.Show(TauxProduit.ToString());
                        TauxRestourne = Double.Parse(tpv);
                        Lpv.Text = tpv;
                    }

                    else if (IdCpte == 311)
                    {
                        TauxRestourne = 0;
                        Lpv.Text = "0";
                        ltAUXtransp.Text = TauxEmb.ToString();
                        // MessageBox.Show(TauxEmb.ToString());

                    }
                }




            }
            catch ( Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }

          

        }
        private void affectationCompteVariation(string para)
        {
            // = true;
            // = comboCompteStock.Text;
            // MessageBox.Show(comboCompteStock.Text);
            try
            {

               // tCompteCred3.Text = CompteAutomati(702);
                comboCompteStock.ValueMember = "Variation";
                comboCompteDestockage.ValueMember = "Variation";
                String v = "";
                // MessageBox.Show(comboCompteStock.SelectedValue.ToString());
                // v = comboCompteStock.SelectedValue.ToString();
                // v = comboCompteDestockage.SelectedValue.ToString();
                v = para;
                if (v.Trim() == "B")
                {
                    // tVariariotion.Text = CompteDEservicleint(61, 7);
                    tVariation2.Text = CompteDEservicleint(61, 1);
                    tVente.Text = CompteDEservicleint(72, IdService);
                }


                else if (v.Trim() == "H")
                {
                    tVariariotion.Text = CompteDEservicleint(63, 1);
                    tVariation2.Text = CompteDEservicleint(63, 1);
                    tVente.Text = "0";

                }

                else if (v.Trim() == "C")
                {
                    tVariariotion.Text = CompteDEservicleint(62, 1);
                    tVariation2.Text = CompteDEservicleint(62, 1);
                    tVente.Text = "0";
                }

                else if (v.Trim() == "P")
                {
                    tVariariotion.Text = CompteDEservicleint(65, 1);
                    tVariation2.Text = CompteDEservicleint(65, 1);
                    tVente.Text = CompteDEservicleint(74, IdService);
                }
                else if (v.Trim() == "R")
                {
                    tVariariotion.Text = CompteDEservicleint(65, 1);
                    tVariation2.Text = CompteDEservicleint(65, 1);
                    tVente.Text = CompteDEservicleint(73, IdService);
                }

                else
                {
                    tVariariotion.Text = CompteDEservicleint(64, 1);
                    tVariation2.Text = CompteDEservicleint(64, 1);
                    tVente.Text = CompteDEservicleint(74, IdService);
                }

            }
            catch (Exception ex)
            {
                lmessage.Text = ex.ToString();
            }

            if (bwChargmentDG.IsBusy == false)
            {
                bwChargmentDG.RunWorkerAsync();
            }


        }




        private void affectationCompteVariation2(string para)
        {
            // = true;
            // = comboCompteStock.Text;
            // MessageBox.Show(comboCompteStock.Text);
            try
            {
                comboCompteStock.ValueMember = "Variation";
                // comboCompteDestockage.ValueMember = "Variation";
                String v = "";
                // MessageBox.Show(comboCompteStock.SelectedValue.ToString());
                // v = comboCompteStock.SelectedValue.ToString();
                // v = comboCompteDestockage.SelectedValue.ToString();
                v = para;
                if (v.Trim() == "B")
                {
                    tVariariotion.Text = CompteDEservicleint(61, 7);
                    // tVariation2.Text = CompteDEservicleint(61, 7);
                    // tVente.Text = CompteDEservicleint(70, IdService);
                }


                else if (v.Trim() == "H")
                {
                    tVariariotion.Text = CompteDEservicleint(63, 7);
                    //tVariation2.Text = CompteDEservicleint(63, 7);
                    //tVente.Text = "0";

                }

                else if (v.Trim() == "C")
                {
                    tVariariotion.Text = CompteDEservicleint(62, 7);
                    // tVariation2.Text = CompteDEservicleint(62, 7);
                    //tVente.Text = CompteDEservicleint(72, IdService);
                }

                else if (v.Trim() == "P")
                {
                    tVariariotion.Text = CompteDEservicleint(65, 7);
                    //.Text = CompteDEservicleint(65, 7);
                    //tVente.Text = CompteDEservicleint(74, IdService);
                }
                else if (v.Trim() == "R")
                {
                    tVariariotion.Text = CompteDEservicleint(65, 8);
                    tVariation2.Text = CompteDEservicleint(65, 8);
                    tVente.Text = CompteDEservicleint(73, IdService);
                }
                else
                {
                    tVariariotion.Text = CompteDEservicleint(64, 7);
                    // tVariation2.Text = CompteDEservicleint(64, 7);
                    // tVente.Text = CompteDEservicleint(74, IdService);
                }

            }
            catch (Exception ex)
            {
                lmessage.Text = ex.ToString();
            }

            if (bwChargmentDG.IsBusy == false)
            {
                bwChargmentDG.RunWorkerAsync();
            }


        }
        private void tVariation2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCompteStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCompteStock.ValueMember = "Variation";
            string v = comboCompteStock.SelectedValue.ToString();
            affectationCompteVariation2(v);
        }

        private void comboArticleDestockage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementPrixAcha();
        }
        Double CoutTotalDestockage;
        string PuVente;
        private void ChargementPrixAcha()
        {
            try
            {
                tCreditte2.Text = comboCompteDestockage.Text;
                comboArticleDestockage.ValueMember = "PuVente";
                // tPuSortie.Text = comboArticleDestockage.SelectedValue.ToString();
                PuVente = comboArticleDestockage.SelectedValue.ToString();
                comboArticleDestockage.ValueMember = "PrixAchat";
                Tlifo.Text = comboArticleDestockage.SelectedValue.ToString();
                comboCompteDestockage.ValueMember = "Unite";
                Unite = comboCompteDestockage.SelectedValue.ToString();
                tPuSortie.Text = (double.Parse(PuVente) * double.Parse(PourcentPv)).ToString();

            }
            catch
            {
                tPuSortie.Text = "";

            }
        }
        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tPuSortie_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void comboArticleDestokageDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboArticleDestokageDes_Click(object sender, EventArgs e)
        {
            ChargementPrixAcha();
        }

        private void comboCompteVente2Des_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCompteVente2Des_Click(object sender, EventArgs e)
        {
            if (bwChargmentDG.IsBusy == false)
            {
                bwChargmentDG.RunWorkerAsync();
            }
        }

        private void tQteSortie_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }



        private void calculerPR()
        {
            if (CbReevaluer.Checked == true)
            {
                try
                {
                    tPuSortie.ReadOnly = false;
                    tTotalSortie.ReadOnly = false;
                    tTotalSortie.Text = ((double.Parse(tPuSortie.Text)) * (double.Parse(tQteSortie.Text))).ToString();
                    //tTotalStock.ReadOnly = true;

                    //tMotantOP
                    if (Unite == "2")
                    {
                        //tMotantVente.Text = ((double.Parse(tTotalSortie.Text)) / Taux).ToString();
                        //tMotantVenteCdf.Text = tTotalSortie.Text;
                        tMotantVente.Text = ((double.Parse(tTotalSortie.Text))).ToString();

                        tMotantVenteCdf.Text = "0";




                    }
                    else
                    {
                        tMotantVente.Text = ((double.Parse(tTotalSortie.Text))).ToString();

                        tMotantVenteCdf.Text = "0";
                    }
                    tMotantOP.Text = tMotantVente.Text;
                    tMotaOP2.Text = ((double.Parse(Tlifo.Text) * (double.Parse(tQteSortie.Text)))).ToString();

                }
                catch
                {

                    tTotalSortie.Text = "";
                }
            }
            else
            {
                try
                {
                    tPuSortie.ReadOnly = true;
                    tTotalSortie.ReadOnly = false;
                    tTotalSortie.Text = ((double.Parse(tPuSortie.Text)) * (double.Parse(tQteSortie.Text))).ToString();
                    //tTotalStock.ReadOnly = true;



                    tMotaOP2.Text = ((double.Parse(Tlifo.Text) * (double.Parse(tQteSortie.Text)))).ToString();
                    if (Unite == "2")
                    {
                        tMotantVente.Text = ((double.Parse(tTotalSortie.Text)) / Taux).ToString();
                        tMotantVenteCdf.Text = tTotalSortie.Text;
                    }
                    else
                    {
                        tMotantVente.Text = ((double.Parse(tTotalSortie.Text))).ToString();

                        tMotantVenteCdf.Text = "0";
                    }
                    tMotantOP.Text = tMotantVente.Text;
                    tMotaOP2.Text = ((double.Parse(Tlifo.Text) * (double.Parse(tQteSortie.Text)))).ToString();


                }
                catch
                {

                    tTotalSortie.Text = "";
                }
            }


        }

        private void tTotalSortie_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void combooDestockageDES_Click(object sender, EventArgs e)
        {


            selectioAricle();

            //try
            //{
            //    comboCompteDestockage.ValueMember = "Variation";
            //    string v = comboCompteDestockage.SelectedValue.ToString();
            //    affectationCompteVariation(v);
            //    comboCompteDestockage.ValueMember = "Unite";
            //    Unite = comboCompteDestockage.SelectedValue.ToString();
            //}
            //catch
            //{


            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tVente_TextChanged(object sender, EventArgs e)
        {

        }

        private void MotantOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            //PCredit.Visible = rbCredit.Checked;
            //lPour.Enabled = rbCash.Checked;
            //tPour.Enabled = rbCash.Checked;
            tNumOp2.Text = fonctionOPSotie();        //DrnierOpPaiement2();
            tAdebut2.Text = "";
            //if (rbCash.Checked == true)
            //{
            //    tAdebut2.Text = Caisservise;
            //}
            //else
            //{

            //}

            try
            {
                comboCompteDestockage.ValueMember = "Variation";
                string v = comboCompteDestockage.SelectedValue.ToString();
                affectationCompteVariation(v);
                comboCompteDestockage.ValueMember = "Unite";
                Unite = comboCompteDestockage.SelectedValue.ToString();
            }
            catch
            {


            }


        }

        private void tNumOp2_TextChanged(object sender, EventArgs e)
        {

        }


        private void InserMvtCpteStockAvecQte(string storage, string NumCompte, String CodeDepot, String QteEntree, string QteSortie, string PR, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();

                //MessageBox.Show(" compte" + NumCompte + " code " + CodeDepot + "  QteEntree " + QteEntree + "  QteSortie " + QteSortie + "  PR " + PR + "  Entree " + Entree + " Sortie" + Sortie + " PVentUN" + PVentUN + " refComp" + refComp + " TypeOp" + TypeOp + " NumOp" + NumOp);

                //Connection_Data();
                //if (con.State != ConnectionState.Open)
                //{
                //    con.Open();
                //}
                //MessageBox.Show(" compte" + NumCompte + " code " + CodeDepot + "  QteEntree " + QteEntree + "  QteSortie " + QteSortie + "  PR " + PR + "  Entree " + Entree + " Sortie" + Sortie + " PVentUN" + PVentUN + " refComp" + refComp + " TypeOp" + TypeOp + " NumOp" + NumOp);

                //MessageBox.Show( " dd" + ReferanceCompte + "/" + refComp);
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", NumOp);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", QteEntree);
                cmd.Parameters.AddWithValue("@QteSortie ", QteSortie);
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", PR);
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                //MessageBox.Show(" compte" + NumCompte + " code " + CodeDepot + "  QteEntree " + QteEntree + "  QteSortie " + QteSortie + "  PR " + PR + "  Entree " + Entree + " Sortie" + Sortie + " PVentUN" + PVentUN + " refComp" + refComp + " TypeOp" + TypeOp + " NumOp" + NumOp);
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(ReferanceCompte);
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
                lmessage.Text = "ok";
            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " en ref " + NumCompte);

                lmessage.Text = ex.Message + " en ref " + NumCompte; //ReferanceCompte;

            }

        }




        private void InserMvtCpteStockAvecQte2(string storage, string NumCompte, String QteEntree, string QteSortie, string PR, string Entree, string Sortie, String EntreeFc, string SortieFc, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();

                //  MessageBox.Show(" compte" + NumCompte + " code " + CodeDepot + "  QteEntree " + QteEntree + "  QteSortie " + QteSortie + "  PR " + PR + "  Entree " + Entree + " Sortie" + Sortie + " PVentUN" + PVentUN + " refComp" + refComp + " TypeOp" + TypeOp + " NumOp" + NumOp);

                //Connection_Data();
                //if (con.State != ConnectionState.Open)
                //{
                //    con.Open();
                //}

                //MessageBox.Show( " dd" + ReferanceCompte + "/" + refComp);
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", NumOp);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                //cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", QteEntree);
                cmd.Parameters.AddWithValue("@QteSortie ", QteSortie);
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@EntreeFc", EntreeFc);
                cmd.Parameters.AddWithValue("@SortieFc", EntreeFc);
                cmd.Parameters.AddWithValue("@PR", PR);
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(ReferanceCompte);
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
                //  MessageBox.Show(" compte" + NumCompte + " code " + CodeDepot + "  QteEntree " + QteEntree + "  QteSortie " + QteSortie + "  PR " + PR + "  Entree " + Entree + " Sortie" + Sortie + " PVentUN" + PVentUN + " refComp" + refComp + " TypeOp" + TypeOp + " NumOp" + NumOp);
                // lm
            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " en ref " + NumCompte); //,ReferanceCompte);

                //lmessage.Text = ex.Message + " en ref " + NumCompte; // ReferanceCompte;

            }

        }





        DataTable JournalOP;

        private void ChargmentGg10DernierOP(String para)
        {
            try
            {

                Connection_Data();
                con.Open();
                ////                cmd.CommandText = " SELECT     TOP 20   tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
                ////"FROM            tCompte INNER JOIN" +
                ////                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                ////                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
                ////" WHERE(tOperation.DateOp = @DateOp) AND(tOperation.NomUt = @NomUt) " +
                ////" ORDER BY tOperation.NumOpSource DESC ";
                cmd.CommandText = "SELECT   tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tDepot.DesignationDepot, tOperation.NumOperation, tOperation.Libelle " +
 " FROM tOperation INNER JOIN " +
                         "  tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                          " tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                         "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
                         " WHERE       (tOperation.NumOperation =@NumOperation) " +
" ORDER BY tOperation.NumOpSource DESC";




                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate.Text));
                cmd.Parameters.AddWithValue("@NumOperation", para);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                JournalOP = dt;

                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }



        DataTable JOURNALVIDE;
        private void ChargmentGg10DernierVIDE()
        {
            try
            {

                string s = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie,tMvtStock.Sortie, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation  " +
" FROM tMvtStock INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND(tDepot.CodeDepot = @b)";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { tNumOp2.Text, CodeDepot };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                // FicheDechargement = classeReq.dt;
                JOURNALVIDE = classeReq.dt;

                // if (dt.Rows.Count > 0)
                // {
                //JOURNALVIDE = dt;

                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }
        private void EnrmouvemmentDestockage()
        {
            try
            {
                Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                if (OperationCuisine == true)
                {
                    //InserMvtCpteStockAvecQte("inserertMvtStock", comboArticleDestockage.Text, CodeDepot, "0", tQteSortie.Text, Tlifo.Text, "0", tMotaOP2.Text, tPuSortie.Text, tNumRef.Text, "3", tNumOp2.Text);
                    //InserMvtCpteStockAvecQte2("insererMvtcpt", tVariation2.Text, tQteSortie.Text, "0", Tlifo.Text, tMotaOP2.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                    //InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", tQteSortie.Text, Tlifo.Text, "0", tMotaOP2.Text, "0", "0", tPuSortie.Text, tNumRef.Text, "3", tNumOp2.Text);


                }
                else
                {


                    //  InserMvtCpte("inserertMvtChambre", tNumOp2.Text, CodeChambrINI, "0", "0", "0", "0", "4", " 0", "0", "0");
                    // InserMvtCpteStockAvecQte("inserertMvtChambre", "MD1", CodeDepot, tQteSortie.Text, "0", tPuSortie.Text, tMotantVente.Text, "0", tPuSortie.Text, tNumRef.Text, "3", tNumOp2.Text);

                    // InserMvtCpteStockAvecQte("inserertMvtStock", comboArticleDestockage.Text, CodeDepot, "0", tQteSortie.Text, Tlifo.Text, "0", tMotaOP2.Text, tPuSortie.Text, tNumRef.Text, "3", tNumOp2.Text);

                    //Double Montan as Double;

                   
                    if  ( rbVente .Checked == true)
                    {

                        // compte client et caisse
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", tSommeFactureVente.Text, "0", tRemise.Text, "0", "0", tNumRef.Text, "3", tNumOp2.Text);



                        InserMvtCpteStockAvecQte2("insererMvtcpt", tAdebut2.Text, "0", "0", "0", tCash.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", "0", tCash.Text,"0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);


                        //variation de stock
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVariation2.Text, "0", "0", "0", tPR.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);


                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVente.Text, "0", "0", "0", "0", tSommeFactureVente.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);



                        // restourne

                        InserMvtCpteStockAvecQte2("insererMvtcpt", ClassVaribleGolbal.CompteRemise, "0", "0", "0", tRemise.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptRestourne.Text, "0", "0", "0", "0", tRemise.Text, "0", "0", "0 ", tNumRef.Text, "3", tNumOp2.Text);


                    }
                     else if (RbDeguStation.Checked == true)
                    {
                        // commpte client
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", tSommeCredit.Text, "0", tRemise.Text, "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVente.Text, "0", "0", "0", "0", tSommeCredit.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        //variation de stock
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVariation2.Text, "0", "0", "0", tPR.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);



                        // frais de transport
                       // InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", tFraistransP.Text, "0", tRemise.Text, "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        //InserMvtCpteStockAvecQte2("insererMvtcpt", tCompteCred3.Text, "0", "0", "0", "0", tFraistransP.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        if (cbOffrCash.Checked== true)
                        {


                        InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", "0", "0", tSommeCredit.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tAdebut2.Text, "0", "0", "0", "0", tSommeCredit.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                            //InserMvtCpteStockAvecQte2("insererMvtcpt", tAdebut2.Text, "0", "0", "0", tCash.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                            //tCreditte2

                        }


                    }
                      else if (rbVenteAlaChage.Checked == true)
                    {


                        // commpte client
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", tPR.Text, "0", tRemise.Text, "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVente.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        //variation de stock
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVariation2.Text, "0", "0", "0", tPR.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);




                    }

                    else if (rBAutres.Checked == true)
                    {


                        // commpte client
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCptCourant.Text, "0", "0", "0", tPR.Text, "0", tRemise.Text, "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVente.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);

                        //variation de stock
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVariation2.Text, "0", "0", "0", tPR.Text, "0", "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tCreditte2.Text, "0", "0", "0", "0", tPR.Text, "0", "0", "0", tNumRef.Text, "3", tNumOp2.Text);




                    }






                    // validation de l'opration
                    ValidationDeloperation(tNumOp2.Text);




                   
                }
                //enregOprationDestockage();
                //MessageBox.Show( " ok2");


                //InserMvtCpte("inserertMvtClient", comboArticleDestockage.Text, CodeDepot, "0", tQteSortie.Text, Tlifo.Text, "tTotalSortie.Text", tMotaOP2.Text, tPuSortie.Text, tNumRef.Text, "3", tNumOp2.Text);


                // InserMvtCpteStockAvecQte2("insererMvtcpt", tVariariotion.Text, "0", tQteEntree.Text, tQtePu.Text, "0", tTotalStock.Text, "0", DepotMagasin, "0", tNumOP.Text); ;
                // InserMvtCpteStockAvecQte2("inserertMvtClient", tVariariotion.Text, "0", tQteEntree.Text, tQtePu.Text, "0", tTotalStock.Text, "0", DepotMagasin, "0", tNumOP.Text); ;


                // InserMvtCpte("inserertMvtClient", PnumOp, PcodeClient, "0", Pmotant, Pmotant, PcodeChambre, "0", "0", "0"); ChargmentGg10DernierOP();
                // ChargmentGg10DernierOP(tNumOp2.Text);
                ChargmentGg10DernierVIDE();

                con.Close();
                cmd.Dispose();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }
        // Boolean TesteDestockage;

        private void AnullerDestockage()
        {
            //libelleDestockagere = tLIBELLE2.Text;
            // QteDESTres = tQteSortie.Text;
            // puDestoRES = tPuSortie.Text;
            // QteEntreeRes = tQteEntree.Text;
            tLIBELLE2.Text = "";
            //tTotalSortie.Text = "";
            tQteSortie.Text = "";
            tPuSortie.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            TesteDestockage = true;
            if (tNumOp2.Text.Trim() != "" && (verifierNumbe.IsNumeric(tRemise.Text) == true) && (verifierNumbe.IsNumeric(tSommeFact.Text) == true))
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                }


            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT");
            }


        }
        private void enregOprationDestockage()
        {
            
            if (rbVente.Checked == true)
            {
                Localite = comboLoclite.Text;
            }
            else
            {
                Localite = "";
            }
           
            string s = " INSERT INTO tOperation " +
                           "  (NumOperation,RefCas, Libelle, NomUt, Compte,TypeOp,BeneFiciare,CompteDebit,CompteCredit,Remise,Localite,Valider,Vendeur,TauxDuJour, DateOp) " +
                " VALUES (@a, @b, @c, @d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n, @da) ";

            string[] r = { tNumOp2.Text, "", tLIBELLE2.Text, utilisateur, "0", "3", tPour.Text, tAdebut2.Text, tCreditte2.Text, TauxRestourne.ToString(), Localite,"1", CodeVendeur,Taux.ToString() };
            DateTime[] d = { DateTime.Parse(tDateR1.Text) ,};

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //AnnulerDepensePlan();
            //  lmessage.Text = "&  DEPENSE AJOUTEE &";
            //bWchagementVehicule.RunWorkerAsync();
            //chargemeentDgPlanDepenses();
            //MessageBox.Show("okoppp");
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
        }

        private void bwEnreCompte_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TesteDestockage == true)

            {
                EnrmouvemmentDestockage();

            }
            else if (Tesstockage == true)
            {
                EnrmouvemmentComptble();

            }
        }

        private void tCreditte2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bwEnreCompte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (TesteDestockage == true)
            {
                // dGjournal2.DataSource = JournalOP;
                //tNumOp2.Text = fonctionOPSotie();
                tNumRef.Text = fonctionMvtStock();
                bValide.Enabled = false;
                lMessageVente.Text = "OPERATION DE " + tPour.Text + " A REUSSI";
                bSupprimerFac.Enabled = false;
                bModifierFact.Enabled = false;
                // enboi sms 
                ClasseSMS clSMS = new ClasseSMS();

                if (comboCptRestourne.Text.StartsWith("41") == true && ClassVaribleGolbal.ModeSms== true)
                {
                    //MessageBox.Show(MontanTotalSms.ToString());
                    clSMS.VerificationAchatProduit(comboCptRestourne.Text, tRemise.Text, tTotalQte.Text.Trim(), tSommeFact.Text, " est credite de ", " Ref:" + tNumOp2.Text + "", tNumOp2.Text, "");
                    smsdirecAvecTH(tNumOp2.Text);
                }


                //AnullerOpComptable();
                // AnullerDestockage();
                //  tQteSortie.Text = "";
                //CbSereferer2.Checked = false;

            }
            else
            {


                DgJournal.DataSource = JournalOP;
                tNumOP.Text = fonctionOP();
                AnullerOpComptable();
                CbSereferer.Checked = false;

            }


            TesteDestockage = false;
            //Tesstockage = false;




        }

        private void smsdirecAvecTH(string numOpreation)
        {
            ClasseSMS fo = new ClasseSMS();
            System.Threading.Thread Thread1 = new System.Threading.Thread(fo.ChargementPouEnvoiyerDIRECT);
            fo.op = numOpreation;
            Thread1.Start();
            // Thread1.Join()
            //fo.Dispose();
        }



        private void AnullerOpComptable()
        {
            LIBELEreserve = tLibelle.Text;
            montanReseve = tTotalStock.Text;
            tQtePuRes = tQtePu.Text;
            QteEntreeRes = tQteEntree.Text;
            tLibelle.Text = "";
            tTotalStock.Text = "";
            tQtePu.Text = "";
            tQteEntree.Text = "";

        }
        private void tLIBELLE2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChargementDelOperation()
        {
            if ( rbVente.Checked== true)
            {
                tPour.Text = ComboNomClient.Text + " ";
                tLIBELLE2.Text = "FACTURATION  PRODUIT EN REF:  " + " " + " /" + ComboNomClient.Text;
            }
            else
            {
                tPour.Text = comboCptCourantDes.Text + " ";
                tLIBELLE2.Text = "AUTRE OPEARATION EN REF:  " + " " + " /" + comboCptCourantDes.Text;

            }
           
        }
        DataTable tableDesArticle;
        private void chargemeTousLesArticle()
        {
            try
            {

                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
" FROM tStock WHERE   (Compte =@a) ";
                //" WHERE        (Compte =@a)  ";
                //AND (CategorieArticle = @b)
                string[] r = { comboCompteDestockage.Text.Trim() };
                //MessageBox.Show(para  +"/" +para2);
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                tableDesArticle = classeReq.dt;
                ;

                // MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PasserInitialisatioStock()
        {

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }





            String CodeAricle, Prix;
            //PbEnrePaiemnt.Maximum = TableComteVenteService.Rows.Count - 1;
            for (int i = 0; i <= tableDesArticle.Rows.Count - 1; i++)
            {



                CodeAricle = tableDesArticle.Rows[i]["CodeArticle"].ToString();
                Prix = tableDesArticle.Rows[i]["PrixVente"].ToString();

                //InserMvtCpte2("inserertMvtChambre", tNumOp2.Text, CodeChambrINI, "0", "0", "0", "0", "4", " 0", "0", "0");
                // InserMvtCpte("insererMvtcpt", PnumOp2, tCreditte2.Text, "0", Pmotant2, "1", PcompCredit, "4", "0", "0", "0");
                InserMvtCpteStockAvecQte("inserertMvtStock", CodeAricle, CodeDepot, "0", "0", Prix, "0", "0", "0", comboCompteDestockage.Text, "0", tNumOp2.Text);
                // MessageBox.Show(" ok3");
                // InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, DepotMagasin, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);

                //InserMvtCpteStockAvecQte("inserertMvtStock", CodeAricle, DepotMagasin, "0", "0", Prix, "0", "0", "0", comboCompteDestockage.Text, "0", tNumOp2.Text);
                //Messag
            }


            //hargemeenDGFacturationSerice();


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }


        private void ChargmentPoPcharemenStock()
        {

            FormPop.FormPopStockChargment Fp = new FormPop.FormPopStockChargment();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDepot = CodeDepot;
            Fp.DesDepot = comboDepoDES2.Text;
            Fp.Vendeur = NomsVendeur;
            Fp.TauxRestourne = TauxRestourne;
            Fp.Compte = comboCompteDestockage.Text.Trim();
            
            Fp.boolVenteClient = rbVente.Checked;
            Fp.boolDegusate = RbDeguStation.Checked;
            Fp.boolEnArgent = cbOffrCash.Checked;
            Fp.boolCaseMaquant = rbVenteAlaChage.Checked;
            Fp.boolAutreSotie = rBAutres.Checked;

            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                panelOperation.Enabled = false;

                bSupprimerFac.Enabled = true;
                bModifierFact.Enabled = true;

                ChargmentGgDernierChargement();
                dGjournal2.DataSource = FicheDechargement;
                tSommeFact.Text = SommeFactVenteRestour.ToString();
                tSommeFactureVente.Text = SommeFactVente.ToString();

                tTotalQte.Text = QteVente.ToString();

                if (IdCpte == 310)
                {
                    tFraistransP.Text = (QteVente * TauxProduit).ToString();
                    tPR.Text = (((QteVente * TauxProduit)) + SommeFact).ToString();
                }
                else if (IdCpte == 311)
                {
                    tFraistransP.Text = (QteVente * TauxEmb).ToString();
                    tPR.Text = (((QteVente * TauxEmb)) + SommeFact).ToString();
                }
                // tSommeFact.Text = SommeFact.ToString();
                lMessageVente.Text = "COMPLETER LE CASH POUR PASSER L'OPERARION ";
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";
                // bValideEntete.Enabled = true;
                panelOperation.Enabled = true;
                lMessageVente.Text = "CLIQUEZ SU FACTURER POUR  CHOISIR LE PRODUITS";
            }
        }

        double SommeFact, SommeFactVente, SommeFactVenteRestour,QteVente;
        DataTable FicheDechargement;
        private void ChargmentGgDernierChargement()
        {
            try
            {


                string s = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie,tMvtStock.Sortie,tMvtStock.Vente, tMvtStock.Sortie,(tMvtStock.PVentUN *tMvtStock.QteSortie) AS  SommeVente, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation,tMvtStock.NumRef  " +
" FROM tMvtStock INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteSortie<>0) ";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { tNumOp2.Text, CodeDepot };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                FicheDechargement = classeReq.dt;

                DataTable TB = classeReq.dt;
                Double motant,MontanVente, QteSortie,SomRestou;
                SommeFact = 0;
                SommeFactVente = 0;
                QteVente = 0;
                SommeFactVenteRestour = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Sortie"].ToString());
                    MontanVente = Double.Parse(TB.Rows[i]["SommeVente"].ToString());
                    QteSortie = Double.Parse(TB.Rows[i]["QteSortie"].ToString());
                    SomRestou = Double.Parse(TB.Rows[i]["Vente"].ToString());
                    // tot = tot + motant;
                    SommeFact = SommeFact + motant;
                    SommeFactVente = SommeFactVente + MontanVente;
                    QteVente = QteVente + QteSortie;
                    SommeFactVenteRestour = SommeFactVenteRestour + SomRestou;
                   // MessageBox.Show(QteVente.ToString());
                    // SommeFact
                    //Des = TB.Rows[i]["DesignationCompte"].ToString();
                    //montantc = TB.Rows[i]["Sortie"].ToString();
                    //numop = TB.Rows[i]["NumOP"].ToString();
                    //motantd = TB.Rows[i]["Etree"].ToString();
                    //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }
        private void b_Click(object sender, EventArgs e)
        {
            if (BoolRappelDeDate == false)
            {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOULOIR PASSER   LES OPRATIONS A LA   ? \n DATE  ===  " + ClassVaribleGolbal.DateDuJOUR + "\n" +
               " TAUX  =" + Taux.ToString() + "?",
                "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    BoolRappelDeDate = true;
                }
                else
                {
                    BoolRappelDeDate = false;

                }

            }


            if (BoolRappelDeDate == true)
            {
                CommandeVente();
            }
          




        }


        private void CommandeVente()
        {
            try
            {
                if ((tLIBELLE2.TextLength > 10) && Taux!=0)
                {
                    //verifierNumbe.IsNumeric(tCreditte2.Text) == true
                    tNumOp2.Text = fonctionOPSotie();

                    chargemeTousLesArticle();
                    enregOprationDestockage();
                    PasserInitialisatioStock();

                    ChargmentPoPcharemenStock();


                    // panelOperation.Enabled = false;
                    PCredit.Enabled = false;
                    //pCache.Enabled = false;
                    paneValide.Enabled = true;
                    bValide.Enabled = true;


                }

                else
                {
                    MessageBox.Show(" VIELLER CLIQUE SUR UN COMPTE  ou VOTRE LIBELLE N' EST PAS SUFFISANT OU VERIFIER LE TAUX ");

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(" VIELLER CLIQUE SUR UN COMPTE " + ex.Message);
                panelOperation.Enabled = true;
                PCredit.Enabled = true;
                //pCache.Enabled = true;
                // paneValide.Enabled = false;
                bValide.Enabled = false;


            }



        }
        private void button12_Click(object sender, EventArgs e)
        {
            /// enregOprationDestockage();
            /// 
           // if (fonctionValiderLop()==0)
            //{
                tNumOp2.Text = fonctionOPSotie();
                panelOperation.Enabled = true;
                PCredit.Enabled = true;
                // pCache.Enabled = true;
                paneValide.Enabled = true;
                bValide.Enabled = false;
                tLIBELLE2.Text = "";
                tPour.Text = "";
                tSommeFactureVente.Text = "";
                tSommeFact.Text = "";
                tTotalQte.Text = "0";
                tFraistransP.Text= "0";
                tRemise.Text = "";
                tSommeCredit.Text = "";
                tCash.Text = "0";
                tPR.Text = "0";



                lMessageVente.Text = "VEILLEZ CHOISIR UN CLIENT";
                // ChargmentGg10DernierOP("");
                // dGjournal2.DataSource = JOURNALVIDE;

                ChargmentGgDernierChargement();
                dGjournal2.DataSource = FicheDechargement;
           // }
            //else
            //{
               // MessageBox.Show("L' OPERATION N'EST PAS ENCORE VALIDE");
            //}
            


        }

        private void llibeleVente_Click(object sender, EventArgs e)
        {

        }

        private void tPour_TextChanged(object sender, EventArgs e)
        {
            // tCreditte2.Text = comboCompteDestockage.Text;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboCodeArticleStock_SelectedIndexChanged(object sender, EventArgs e)
        { if (rbRavitaillement.Checked == true)
            {
                comboCodeArticleStock.ValueMember = "PuVente";
                tQtePu.Text = comboCodeArticleStock.SelectedValue.ToString();
                //  MessageBox.Show(comboCodeArticleStock.SelectedValue.ToString());
            }

        }

        private void comboCodeArticleStockDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combooDestockageDES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbAncienClient2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }

        private void tQtePu_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }
        private void calculerFc()
        {
            if (rbRavitaillement.Checked == true)
            {
                try
                {
                    tQtePu.ReadOnly = true;
                    tTotalStock.ReadOnly = true;
                    tTotalStock.Text = ((double.Parse(tQteEntree.Text)) * (double.Parse(tQtePu.Text))).ToString();
                    //tTotalStock.ReadOnly = true;

                }
                catch
                {

                    tTotalStock.Text = "";
                }

            }
            else
            {
                if (CBcdf.Checked == true)
                {
                    try
                    {
                        tQtePu.ReadOnly = false;
                        tTotalStock.ReadOnly = true;
                        tTotalStock.Text = ((double.Parse(tQteEntree.Text)) * (double.Parse(tQtePu.Text))).ToString();
                        //tTotalStock.ReadOnly = true;

                    }
                    catch
                    {

                        tTotalStock.Text = "";
                    }
                }
                else
                {
                    try
                    {
                        tTotalStock.ReadOnly = false;
                        tQtePu.ReadOnly = true;
                        tQtePu.Text = ((double.Parse(tTotalStock.Text)) / (double.Parse(tQteEntree.Text))).ToString();
                        //tQtePu.ReadOnly = true;
                    }
                    catch
                    {

                        tQtePu.Text = "";
                    }
                }

            }




        }

        private void tQteEntree_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void tTotalStock_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }
        String LIBELEreserve, montanReseve, QteEntreeRes, tQtePuRes;

        private void button13_Click(object sender, EventArgs e)
        {


            string codecl;

            int ci = DGsommaireSTOCK.CurrentRow.Index;
            //codecl = DgPaiement[ir]["CompteClient"].ToString();
            codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
            MessageBox.Show(codecl);

            UpdateInitVente(codecl, tPrixVente.Text);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Pdestination.Visible = rbRavitaillement.Checked;
            calculerFc();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void comboCodeArticleStockDes_Click(object sender, EventArgs e)
        {
            if (rbRavitaillement.Checked == true)
            {
                comboCodeArticleStock.ValueMember = "PuVente";
                tQtePu.Text = comboCodeArticleStock.SelectedValue.ToString();

            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tesstockage = true;
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "")
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                }


            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT");
            }






        }

        private void CbSereferer_CheckedChanged(object sender, EventArgs e)
        {


            if (CbSereferer.Checked == true)
            {
                tLibelle.Text = LIBELEreserve;
                tQtePu.Text = tQtePuRes;
                tQteEntree.Text = QteEntreeRes;


            }
            else
            {
                tLibelle.Text = "";
                tTotalStock.Text = "";
                tQtePu.Text = "";
                tQteEntree.Text = "";

            }

        }

        DataTable TableConsommationDeproduit;
        private void ConsommationDeproduits()
        {

            try
            {
                string codecl;

                int ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportMouvemetStockCompte";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdate2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);

                con.Close();
                TableConsommationDeproduit = dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                try
                {

                   // ConsommationDeproduits();
                    string codecl;
                    int ci;
                    ci = DgMouvementService.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                    MessageBox.Show(codecl);
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "RapportReleveCompte";


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Report3.rdlc";
                    FormEtat fo = new FormEtat();
                    fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                  //  fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                    fo.Show();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    // lmessage.Text = ex.Message;

                }
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }








        }

        private void CBcdf_CheckedChanged(object sender, EventArgs e)
        {
            calculerFc();
        }



        private void ChargmenRapporSommeare()
        {
            try
            {


                string sCompte = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, SUM(tMvtStock.QteEntree) AS SqteEntree, SUM(tMvtStock.QteSortie) AS SqteSortie, " +
                         " SUM(tMvtStock.Entree) AS SEntree, SUM(tMvtStock.Sortie) AS Ssortie, tDepot.CodeDepot, tDepot.DesignationDepot, MIN(tOperation.DateOp) AS MinDate, MAX(tOperation.DateOp) AS MaxDate," +
                       "  tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site " +
" FROM            tStock INNER JOIN " +
                        " tMvtStock ON tStock.CodeArticle = tMvtStock.NumCompte INNER JOIN " +
                        " tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                        " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        " tCompte ON tStock.Compte = tCompte.NumCompte CROSS JOIN " +
                         " tEntrepise " +
                         " WHERE(tOperation.DateOp BETWEEN  @da AND @db) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, tDepot.CodeDepot, tDepot.DesignationDepot, tEntrepise.Designation, " +
                       "   tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site " +
                "  HAVING(tDepot.CodeDepot = @a)";

                string sCompte2 = " SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, SUM(tMvtStock.Entree) - SUM(tMvtStock.Sortie) " +
                        "  AS Solde " +
" FROM tOperation INNER JOIN " +
                        " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle " +
" WHERE(tOperation.DateOp BETWEEN CONVERT(DATETIME, '2011-01-01 00:00:00', 102) AND @db) " +
 " GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
              "  HAVING(tDepot.CodeDepot = @a)";


                string[] r = { CodeDepot };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDate(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou1 = classeReq.dt;
                classeReq.chargementAvecLesParametreDate(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou2 = classeReq.dt;
                string chiminRap = "Rapport/ReportSommaireCroise.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(RapportSommaireTou1, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(RapportSommaireTou2, chiminRap, "DataSet2");
                fo.Show();





                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                // CbGroupe2 = classeReq.dt;

                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                //CbGroupe3 = classeReq.dt;












            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }








            //  da.Dispose();
        }

        DataTable RapportSommaireTou1, RapportSommaireTou2;

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                //string codecl;

                // ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportJournalCompteTous";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDteJ.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDteJ.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportJournal.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }

        }

        private void CbReevaluer_CheckedChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    string codeRef;
                  
                    int ci = dGjournal2.CurrentRow.Index;

                    codeRef = dGjournal2["NumRef", ci].Value.ToString();
                    string sint = " UPDATE       tMvtStock " +
" SET QteEntree = @a, QteSortie = @a, Entree = @a, Sortie = @a, RestournePr = @a, PR = @a, Vente = @a, PVentUN = @a, QteSortieRetour = @a, QteSortieVente = @a, QteSortieCharg = @a, QteSortieAutre = @a, " +
                        " QteSortieDegustage = @a, QteSortieCasseManquant = @a, QteEntreeRetour = @a, QteEntreeAutre = @a, QteEntreeAchat = @a, QteEntreeCharg = @a, SommeVente = @a, SommeChargement = @a " +
" WHERE(NumRef = @b)";
                    string[] r2 = { "0", codeRef };
                    DateTime[] d = { DateTime.Now };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sint, r2, d);

                    MessageBox.Show(" EST SUPPRIMME");
                   
                  
                    ChargmentGgDernierChargement();
                    dGjournal2.DataSource = FicheDechargement;

                    tSommeFact.Text = SommeFactVenteRestour.ToString();
                    tSommeFactureVente.Text = SommeFactVente.ToString();
                    tTotalQte.Text = QteVente.ToString();

                    if ( IdCpte == 310)
                    {
                        tFraistransP.Text = (QteVente * TauxProduit).ToString();
                        tPR.Text = (((QteVente * TauxProduit)) + SommeFact).ToString();
                    }
                     else if (IdCpte == 311)
                    {
                        tFraistransP.Text = (QteVente * TauxEmb).ToString();
                        tPR.Text = (((QteVente * TauxEmb)) + SommeFact).ToString();
                    }

                    

                }

            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }








        }
         private void ValidationDeloperation( string op)
        {
            try
            {
                string smodifie = "UPDATE tOperation SET Valider =0, Credit=@a,Cash=@b WHERE (NumOperation = @c)";

                string[] r2 = { tSommeCredit.Text,tCash.Text, op };
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, smodifie, r2, d);


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void SupprimerOratioNonValide()
        {
            try
            {
                string smodifie = "DELETE FROM tOperation WHERE Valider =1";

                string[] r2 = { "" };
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, smodifie, r2, d);


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string codecl;

                // ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "JournaMouvemStoxk";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDteJ.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDteJ.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Report2.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }





        }

        private void button14_Click(object sender, EventArgs e)
        {


            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                string chiminRap = "Rapport/ReportFicheDestockParService.rdlc";
                ChargmenRapporSommeareFicheDestock(chiminRap);
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }
        DataTable TableFicheDestok;
        private void ChargmenRapporSommeareFicheDestock(string chiminRap)
        {
            try
            {

                string codecl;

                int ci = DGsommaireSTOCK.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
                MessageBox.Show(codecl);
                string sCompte = "RapporFicheDestokUnproduit";





                string[] r = { codecl, CodeDepot };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDateStorage(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                TableFicheDestok = classeReq.dt;
                // classeReq.chargementAvecLesParametreDate(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                //RapportSommaireTou2 = classeReq.dt;
               // string chiminRap = "Rapport/ReportFicheDestockParService.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableFicheDestok, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(RapportSommaireTou2, chiminRap, "DataSet2");
                fo.Show();





                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                // CbGroupe2 = classeReq.dt;

                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                //CbGroupe3 = classeReq.dt;



            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        ///  private void comboD
        ///  

        private void ChargmenRapporSommireBransimnba()
        {
            try
            {

                /// string codecl;

                // int ci = DGsommaireSTOCK.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                // codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
                // MessageBox.Show(codecl);
                DataTable Tmouvment, TstockAu;

                string sPro1 = "BraStoProRapportMouvemeSommairStock";

                string sPro2 = "BraStoProRapportSoldeStockAU";




                string[] r = { CodeDepot };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                TstockAu = classeReq2.dt;

                string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargement.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //string codecl;

                // ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportJournalCompteTous";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportJournal.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }

        }

        private void Tlifo_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void lDepot_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //tNumOp2.Text = fonctionOPSotie();
            //tNumRef.Text = fonctionMvtStock();//DrnierOpPaieme

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                string chiminRap = "Rapport/ReportFicheStockParDate.rdlc";
                ChargmenRapporSommeareFicheDestock(chiminRap);
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


        }

        private void rbCasActuel_CheckedChanged(object sender, EventArgs e)
        {
            chargmetOPtonVente();
            //ChargementDelOperation();


        }
         private void chargmetOPtonVente()
        {





            tCash.Enabled = rbVente.Checked;
            tSommeCredit.Enabled = rbVente.Checked;

            cbOffrCash.Visible = RbDeguStation.Checked;

             if (RbDeguStation.Checked == true)
            {

                //lCash.Text = "FRS DE TRNSP";
                //lCredit.Text = " VAL DE PRODUIT";

                ltAUXtransp.Text = (TauxTrans * Taux).ToString();
                tSommeCredit.Enabled = true;


            }

             else if (rbVenteAlaChage .Checked == true )
            {
                // lCash.Text = " ";
                // lCredit.Text = " VAL DE PRODUIT";
                if (IdCpte == 310)
                {
                    ltAUXtransp.Text = TauxProduit.ToString();
                }
                else
                {
                    ltAUXtransp.Text = TauxEmb.ToString();
                }
                


            }

             else
            {


                if (IdCpte ==310)
                {
                    ltAUXtransp.Text = TauxProduit.ToString();
                }
                else
                {
                    ltAUXtransp.Text = TauxEmb.ToString();
                }
                lCash.Text = "CASH";
                lCredit.Text = "CREDIT";

            }


            ChargmentComboDegustage();
            charmementBWpaiementPourSerice();
            

            try
            {
                comboCompteDestockage.ValueMember = "Variation";
                string v = comboCompteDestockage.SelectedValue.ToString();
                affectationCompteVariation(v);
                comboCompteDestockage.ValueMember = "Unite";
                Unite = comboCompteDestockage.SelectedValue.ToString();
                tAdebut2.Text = Caisservise;
                

            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString());
               // chargmetOPtonVente();
            }

        }
        private void RbAncienCas_CheckedChanged(object sender, EventArgs e)
        {

            
            chargmetOPtonVente();
            

            //charmementBWpaiementPourSerice();
            //ChargmentComboDegustage();

            //ChargmentComboDegustage();
            //charmementBWpaiementPourSerice();

            //try
            //{
            //    comboCompteDestockage.ValueMember = "Variation";
            //    string v = comboCompteDestockage.SelectedValue.ToString();
            //    affectationCompteVariation(v);
            //    comboCompteDestockage.ValueMember = "Unite";
            //    Unite = comboCompteDestockage.SelectedValue.ToString();
            //    tAdebut2.Text = Caisservise;
            //}
            //catch
            //{


            //}
        }



        private void ChargmentComboDegustage()
        {

            ChargementDelOperation();
            if (rbVente.Checked == true)
            {

                AfficherVente(true);

            }
            else
            {
                ;
                AfficherVente(false);

                if (bWchargmentComboCompte.IsBusy == false)
                {

                    bWchargmentComboCompte.RunWorkerAsync();
                }
                else
                {


                }

            }






        }

        private void AfficherVente (Boolean b)
     {
            ComboMatricule.Visible = b;
            ComboNomClient.Visible = b;
            comboLoclite.Visible = b;

            bRecherche.Enabled = b;

            lrestourne.Visible = b;

            comboCptRestourne.Visible = b;
            comboCptRestourneDes.Visible = b;

        }

      string  compteClient, PourcentPv;

        private void ComboFicheDeCasID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ComboMatricule.ValueMember = "Compte";
                //compteClient = ComboMatricule.SelectedValue.ToString();

                //tAdebut2.Text = compteClient;



                //ComboMatricule.ValueMember = "PourcentPv";
                //PourcentPv = ComboMatricule.SelectedValue.ToString();
                //// ComboFicheDeCasID.ValueMember = "PourcentPv";
                //Lpv.Text = PourcentPv;


                //ComboMatricule.ValueMember = "CompteClient";


               // ChargementDelOperation();
                lMessageVente.Text = "CLIQUEZ SU FACTURER POUR  CHOISIR LE PRODUITS";
                BoolChargmenRest = true;
                if (bWchargmentPaiement.IsBusy== false)
                {

                    bWchargmentPaiement.RunWorkerAsync();
                }
                ///tVariariotion.Text = CompteDEservicleint(57, 7);

            }

            catch ( Exception ex)
            {
                lmessage.Text = ex.Message;
            }
            
           // ChargementDelOperation()
        }

        private void comboIdCas2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tPour.Text = ComboNomClient.Text + " " ;
            tLIBELLE2.Text = "FACTURATION   MEDICAMENT  EN REF:  " + " " + " /" + ComboNomClient.Text;
        }

        private void comboIdCas2Des_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDelOperation();
        }

        private void PCredit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboFicheDeCasIDdes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDelOperation();
        }

        private void comboNoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDelOperation();
        }

        private void comboPosteNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDelOperation();
        }

        private void typeOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tLibelle.Text = typeOP.Text +  " Suivant Fact No ";
        }

        private void comboPresNoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ChargementDelOperation();
        }

        private void button15_Click(object sender, EventArgs e)
        {


            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                ChargmenRapporSommeare();
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


            



        }

        private void charmementBWpaiementPourSerice()
        {
            //if (RbAncienClient2.Checked == true || rbLoge2.Checked == true)
            //{
            //    ComboChambreOcuppe2.Visible = true;
            //    // ComboChambreOcuppe2.Visible = true;
            //    lChambreOccupe.Visible = true;

            //}
            //else
            //{
            //    ComboChambreOcuppe2.Visible = false;
            //    // ComboChambreOcuppe2.Visible = true;
            //    lChambreOccupe.Visible = false;

            //}

            //ClientDechambe = rbLoge2.Checked;
            //ClientOccasionnel= rbClientOCCasionnel2.Checked;
            //ClientOrdinnaire = rBclientOrd2.Checked;
            //AncienClients = RbAncienClient2.Checked;
            //AutreCompte = rbAutre.Checked;
            if (bWchargmentPaiement.IsBusy == false)
            {
                bWchargmentPaiement.RunWorkerAsync();

            }
            else
            {

                lmessage.Text = "PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER";
                //  MessageBox.Show("PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER");
            }

        }

        private void comboCptRestourne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tSommeFact_TextChanged(object sender, EventArgs e)
        {
            calculerLaSomme();
        }
        private void calculerLaSomme()
        {

            try
            {
                tRemise.Text = (Double.Parse(tSommeFact.Text) * TauxRestourne).ToString();

                if (RbDeguStation.Checked == true)
                {
                    tSommeCredit.Text = (SommeFact + (QteVente * TauxTrans *Taux)).ToString();
                   // tFraistransP.Text = (Double.Parse(tTotalQte.Text) * Taux * TauxTrans).ToString();
                }
                 else if (rbVenteAlaChage.Checked == true)
                {
                   //SommeFact.Text = "0";

                    tSommeCredit.Text = (Double.Parse(tPR.Text) ).ToString();

                    //tSommeCredit.Text = (Double.Parse(tPR.Text) - Double.Parse(tCash.Text)).ToString();


                }

                else
                {
                    tSommeCredit.Text = (Double.Parse(tSommeFactureVente.Text) - Double.Parse(tCash.Text)).ToString();

                }

                ltotalVente.Text = string.Format("{0:#,##0.00}", double.Parse(tSommeFactureVente.Text));
                lcashSeparateur.Text = string.Format("{0:#,##0.00}", double.Parse(tCash.Text));
                lcredittSeparqteur.Text = string.Format("{0:#,##0.00}", double.Parse(tSommeCredit.Text));
            }
            catch
            {
                tRemise.Text = "0";


            }
        }

        private void tCash_TextChanged(object sender, EventArgs e)
        {
            calculerLaSomme();
        }

        private void tAdebut2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            // if (tDate1.Value <= tdate2.Value)
            //  {
            ////ReportFactureSansR
            string chiminRap = "Rapport/Bransimba/ReportFactureSansR.rdlc";
            affecheFacture(chiminRap);


        }
         private void affecheFacture( string chiminRap)
        {
            try
            {


                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactProduits";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumOperation", tNumOp2.Text);

                da.Fill(dt);
                con.Close();
               // string chiminRap = "Rapport/Bransimba/ReportFacture.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                // fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }

        }
        private void button16_Click(object sender, EventArgs e)
        {

            FormRecherche Fp = new FormRecherche();
            Fp.Text = this.Text;
           // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                ComboMatricule.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                ComboMatricule.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareFicheDestock();

                ChargmenRapporSommireBransimnba();
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }

        private void bWchargmentComboCompte_DoWork(object sender, DoWorkEventArgs e)
        {
            ChargementComboCompteDegus();
        }

        private void comboCptCourant_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDelOperation();

        }
        DataTable TableComboVente;

        private void bWchargmentComboCompte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboCptCourant.DataSource = TableComboVente;
            comboCptCourant.DisplayMember = "NumCompte";
            comboCptCourant.ValueMember = "NumCompte";

            comboCptCourantDes.DataSource = TableComboVente;
            comboCptCourantDes.DisplayMember = "DesignationCompte";
            comboCptCourantDes.ValueMember = "NumCompte";
        }

        private void ChargementComboCompteDegus()
        {
            try
            {
                string sDegustage = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tGroupeCompte.Indicateur, tCompte.Unite, tCompte.TypeSous, tCompte.CreerPar " +
"FROM tGroupeCompte INNER JOIN " +
                        " tCompte ON tGroupeCompte.GroupeCompte = tCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Indicateur = 470)";




                string SCasse = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tGroupeCompte.Indicateur, tCompte.Unite, tCompte.TypeSous, tCompte.CreerPar " +
"FROM tGroupeCompte INNER JOIN " +
                        " tCompte ON tGroupeCompte.GroupeCompte = tCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Indicateur = 607)";


                string sAUTRES = "  SELECT tCompte.NumCompte, tCompte.DesignationCompte, tGroupeCompte.Indicateur, tCompte.Unite, tCompte.TypeSous, tCompte.CreerPar " +
"FROM tGroupeCompte INNER JOIN " +
                        " tCompte ON tGroupeCompte.GroupeCompte = tCompte.GroupeCompte ";
//" WHERE(tGroupeCompte.Indicateur = 470)";







                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };
                if (rbVente.Checked == true)
                {
                    // classeReq.chargementAvecLesParametre(sDegustage, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                }
                else if (RbDeguStation.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(sDegustage, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                }
                else if (rbVenteAlaChage.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(SCasse, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                }
                else if (rBAutres.Checked)

                {
                    classeReq.chargementAvecLesParametre(sAUTRES, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                }


                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;



                TableComboVente = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rbVenteAlaChage_CheckedChanged(object sender, EventArgs e)
        {
            //ChargmentComboDegustage();
            
            chargmetOPtonVente();
            //ChargementDelOperation();
            //ChargementDelOperation();
        }

        private void comboCptCourantDes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboCptCourantDes_Click(object sender, EventArgs e)
        {
            ChargementDelOperation();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormPop.FormChangementPrix Fp = new FormPop.FormChangementPrix();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDepot = CodeDepot;
            Fp.Compte = comboCompteVente2.Text.Trim();
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                if (bwChargmentDG.IsBusy == false)
                {
                    bwChargmentDG.RunWorkerAsync();
                }
            }


            }

        private void comboDepoDES2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tSommeFactureVente_TextChanged(object sender, EventArgs e)
        {
            calculerLaSomme();
        }

        private void Lpv_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //ReportFactureSansR
            string chiminRap = "Rapport/Bransimba/ReportFacture.rdlc";
            affecheFacture(chiminRap);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            try
            {

                MessageBox.Show(fonctionValiderLop().ToString());

            }

            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FormVente_FormClosing(object sender, FormClosingEventArgs e)
        {
            SupprimerOratioNonValide();
        }

        private void lDepot2_Click(object sender, EventArgs e)
        {

        }

        private void lVendeur_Click(object sender, EventArgs e)
        {

        }

        private void tSommeCredit_TextChanged(object sender, EventArgs e)
        {
            //calculerLaSomme();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            ChargmentPoPcharemenStock();
        }

        private void rBAutres_CheckedChanged(object sender, EventArgs e)
        {
            // ChargmentComboDegustage();
           // ChargementDelOperation();
            chargmetOPtonVente();
        }

        private void tTotalQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void tPR_TextChanged(object sender, EventArgs e)
        {
            calculerLaSomme();
        }

        private void tCash_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    tCash.Text = string.Format("{0:#,##0.00}", double.Parse(tCash.Text));
            //}

            //catch
            //{


            //}
           
        }

        private void tSommeCredit_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    tSommeCredit.Text = string.Format("{0:#,##0.00}", double.Parse(tSommeCredit.Text));
            //}
            //catch
            //{

            //}
            //tSommeFactureVente
            
        }

        private void tCompteCred3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltAUXtransp_Click(object sender, EventArgs e)
        {

        }

        private void bWchargmentPaiement_DoWork(object sender, DoWorkEventArgs e)
        {
            if (BoolChargmenRest== true)
            {

                chargemeentCombOCompteRestourne();
            }

            else
            {
                chargemeentComboPaiment();

            }
           
        }


       // DataTable ComboPaiement;
        //string compte = CompteDEservicleint(41, 2);
       // Boolean ClientOrdinnaire, ClientDechambe, ClientOccasionnel, AncienClients, AncienClients2;
        private void chargemeentComboPaiment()
        {
            try
            {
                string Sclient = " SELECT        Matricule, IdClient, Noms, Localite, Telephone1, Telephone2, Email, Adresse, Adresse2 " +
                    " FROM            tInformationClient " +
                    " ORDER BY Matricule ";
                   



//                string FicheAncien = " SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte,tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, CONCAT(tClientProvisoire.Noms, ' ', " +
//                        " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM, tCas.RefCas, tCas.Diagnostic, tCas.PLainte, tCas.Etat, tCas.Autres, " +
//                      "  tCas.DateDuCas, tCas.DateEntree " +
//" FROM            tClientProvisoire INNER JOIN " +
//                      "  tCas ON tClientProvisoire.CompteClient = tCas.IDfiche " +
//" WHERE(tCas.Etat = 1 AND TypeDeCas<>0)";




                


                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };
                if (rbVente.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(Sclient, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                }
              
                
                
                //else if (RbDeguStation.Checked == true)
                //{
                //    classeReq.chargementAvecLesParametre(FicheAncien, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //}


                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;



                ComboPaiement = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable TableCompteCouran, TableCompteRestourne;
        Boolean BoolChargmenRest;
        private void chargemeentCombOCompteRestourne()
        {
            try
            {
                string Sclient = " SELECT        NumCompte, Matricule, DesignationCompte, TypeSous, PourcentPv" +
                    " FROM            tCompte " +
                    "WHERE        (Matricule = @a) AND (TypeSous = 1) ";




                string Srestourne = " SELECT        NumCompte, Matricule, DesignationCompte, TypeSous, PourcentPv" +
                    " FROM            tCompte " +
                    "WHERE        (Matricule = @a) AND (TypeSous = 2) ";









                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                string[] r = { ComboMatricule.Text };
                if (rbVente.Checked == true)
                {

                classeReq.chargementAvecLesParametre(Sclient, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                
                classeReq2.chargementAvecLesParametre(Srestourne, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                }






                TableCompteCouran = classeReq.dt;
                TableCompteRestourne= classeReq2.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            // ChargmenComboCompte();
            //ChargementCombo(TableCompte, comboCompteStock, comboStockDes);
            // ChargementCombo(TableCompte, comboCompteVente2, comboCompteVente2Des);
             if  (BwchalrgmentCombo.IsBusy == false)
            {
                try
                {
                    BwchalrgmentCombo.RunWorkerAsync();
                }
                catch
                {

                }
            }
          
        }



        DataTable TableMouvemrntService;
        private void ChargmentDegMouvemennt()
        {
            try
            {
                UpdateInit(tdateR2.Text);
                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie, tPServiceStock.NumDeservice " +
 "FROM tCompte INNER JOIN " +
                        "  tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation INNER JOIN " +
                        "  tPServiceStock ON tCompte.NumCompte = tPServiceStock.NumCompte "+
" WHERE(tOperation.DateOp BETWEEN  @DateOp AND @DateOp1 ) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, tPServiceStock.NumDeservice " +
" HAVING(tPServiceStock.NumDeservice =@NumDeservice )";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", DateTime.Parse(tdateR2.Text));
                cmd.Parameters.AddWithValue("@NumDeservice", IdService);

                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                TableMouvemrntService = dt;
                //MessageBox.Show("ok");

                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void UpdateInit(string datejour)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = " UPDATE tOperation  SET NumOperation = @NumOperation, DateOp = @DateOp " +
                    "  WHERE        (NumOperation = @NumOperation) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NumOperation", ClassVaribleGolbal.OPinit);
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(datejour));

                cmd.ExecuteNonQuery();

                //  lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
                // MessageBox.Show(" EST AJOUTE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }
        private void ChargmentDepot()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        CodeDepot, DesignationDepot, SoldeCompte, SodeQteCompte, CreerPar, " +
 "    IdService FROM tDepot WHERE CodeDepot =@CodeDepot ";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeDepot",CodeDepot);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    tableDepot = dt;
                    // comboDesignatioGroupe.DataSource = dt;
                    // comboPosrIN.DataSource = dt;
                    //  comboPreIns.DataSource = dt;






                    //  comboPosrIN.DisplayMember = "PostnomEleve";
                    //comboPosrIN.ValueMember = "MatriculeEleve";

                    // comboPreIns.DisplayMember = "PrenomEleve";
                    //comboPreIns.ValueMember = "MatriculeEleve";
                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }



        DataTable tableDepot2;
        private void ChargmentDepot2()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        CodeDepot, DesignationDepot, SoldeCompte, SodeQteCompte, CreerPar, " +
 "    IdService FROM tDepot ";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    tableDepot2 = dt;
                    // comboDesignatioGroupe.DataSource = dt;
                    // comboPosrIN.DataSource = dt;
                    //  comboPreIns.DataSource = dt;






                    //  comboPosrIN.DisplayMember = "PostnomEleve";
                    //comboPosrIN.ValueMember = "MatriculeEleve";

                    // comboPreIns.DisplayMember = "PrenomEleve";
                    //comboPreIns.ValueMember = "MatriculeEleve";
                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }
        DataTable TableDgSommaire, TableDgSommaire2;
        private void ChargmenTdgSOMMAIRparDpot()
        {
            try
            {




                //                string sCompte = "SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tStock.Compte, tStock.PrixAchat, tStock.PrixVente AS PuVente" +
                //" FROM tOperation INNER JOIN " +
                //                         " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                //                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                //                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle " +
                //" GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tMvtStock.NumCompte, tStock.Compte, tStock.PrixAchat, tStock.PrixVente " +
                //" HAVING(tDepot.CodeDepot = @a) AND(tStock.Compte = @b)";


                string S = "SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tStock.Compte, tStock.PrixVente, tPametreDepot.PuVente AS PrixVenteLocal " +
" FROM tOperation INNER JOIN " +
                          " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN" +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                         " tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                         "tPametreDepot ON tDepot.CodeDepot = tPametreDepot.CodeDepot AND tStock.CodeArticle = tPametreDepot.CodeArticle " +
 " GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tMvtStock.NumCompte, tStock.Compte, tStock.PrixVente, tPametreDepot.PuVente, tStock.Compte, tStock.IdArticle " +
 " HAVING(tDepot.CodeDepot = 'CD1') AND(tStock.Compte = 310100) ORDER BY tStock.Compte, tStock.IdArticle";

                string sCompte = "SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tStock.Compte,tPametreDepot.PrixRestourne, tStock.PrixVente, tPametreDepot.PuVente AS PrixVenteLocal " +
" FROM tOperation INNER JOIN " +
                         " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN "+
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        " tPametreDepot ON tDepot.CodeDepot = tPametreDepot.CodeDepot AND tStock.CodeArticle = tPametreDepot.CodeArticle " +
" GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tMvtStock.NumCompte, tStock.Compte, tStock.PrixVente, tPametreDepot.PuVente, tStock.Compte, tStock.IdArticle,tPametreDepot.PrixRestourne " +
" HAVING(tDepot.CodeDepot =@a) AND(tStock.Compte =@b) ORDER BY tStock.Compte, tStock.IdArticle";

                string[] r = { CodeDepot ,comboCompteVente2.Text };
                string[] r2 = { CodeDepot, comboCompteDestockage.Text };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();
               // MessageBox.Show(CodeDepot + ""+  comboCompteVente2.Text);
                //MessageBox.Show(CodeDepot + "" + comboCompteDestockage.Text);
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableDgSommaire = classeReq.dt;
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r2);
                TableDgSommaire2 = classeReq.dt;
                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                // CbGroupe2 = classeReq.dt;

                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                //CbGroupe3 = classeReq.dt;












            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;

            }








            //  da.Dispose();
        }


        private void ChargementComboDepot(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "IdService";
            id.ValueMember = "IdService";
            des.ValueMember = "CodeDepot";
            des.DisplayMember = "DesignationDepot";

        }

          private void ChargementComboDepot2(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "CodeDepot";
            id.ValueMember = "CodeDepot";
            des.ValueMember = "CodeDepot";
            des.DisplayMember = "DesignationDepot";

        }

          private void button16_Click_2(object sender, EventArgs e)
          {


              if (tDateR1.Value <= tdateR2.Value)
              {
                  try
                  {

                      // ConsommationDeproduits();
                      //string codecl;
                      //int ci;
                     // ci = DgMouvementService.CurrentRow.Index;
                      //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    //  codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                      //MessageBox.Show(codecl);
                      Connection_Data();
                      con.Open();
                      cmd.CommandText = "BraStoProReleveDeVenteCashEtCredit";


                      cmd.CommandType = CommandType.StoredProcedure;
                      cmd.Parameters.Clear();
                      //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                      cmd.Parameters.AddWithValue("@a", CodeDepot);
                      cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                      cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                      //  MessageBox.Show(codecl);
                      //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                      da.Fill(dt);
                      con.Close();
                      string chiminRap = "Rapport/Bransimba/ReportLeVenteCashEtCredit.rdlc";
                      FormEtat fo = new FormEtat();
                      fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                      //  fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                      fo.Show();

                  }

                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);

                      // lmessage.Text = ex.Message;

                  }
              }
              else
              {
                  MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

              }

          }

          private void comboCodeDepot2_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
          private void ChargmenRapporSommireBransimnbaTous(string sPro1, string sPro2, string chiminRap)
          {
              try
              {


                  DataTable Tmouvment, TstockAu;

                  // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                  // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                  //comboCodeDepot2
                  // string[] r = { DepotMagasin };
                  string[] r = { CodeDepot };
                  DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                  ClassRequette classeReq = new ClassRequette();
                  ClassRequette classeReq2 = new ClassRequette();
                  classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                  Tmouvment = classeReq.dt;

                  classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                  TstockAu = classeReq2.dt;

                  // string chiminRap = "Rapport/Bransimba/ReportSommaireStoctTouts.rdlc";
                  FormEtat fo = new FormEtat();
                  fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                  fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                  fo.Show();





              }
              catch (Exception ex)
              {

                  lmessage.Text = ex.Message;

              }


              //  da.Dispose();
          }
          private void button33_Click(object sender, EventArgs e)
          {
              if (tDateR1.Value <= tdateR2.Value)
              {
                  UpdateInit(tdateR2.Text);
                  //ChargmenRapporSommeareFicheDestock();

                  string sPro1 = "BraStoProRapportMouvemeSommairStock";

                  string sPro2 = "BraStoProRapportSoldeStockAU";
                  string chiminRap = "Rapport/Bransimba/Bra2/ReportSommaireStockChargementVenteParSrd.rdlc";
                  ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);
                  //ChargmenRappor 
              }
              else
              {
                  MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

              }
          }
    }
}
