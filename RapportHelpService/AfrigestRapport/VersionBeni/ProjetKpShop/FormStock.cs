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
using GoldenStarApplication.Comptabillite;

namespace GoldenStarApplication
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test;// test2;
        String DepotMagasin = "CD1";
        String AchatStock="601101";
        String GroupeFournisseur, GroupeBonGratuit;
        private String GroupeCaisse, GroupeVente;
        //String Unite;
        Boolean boolAchat,boolAchatBon;
        Boolean TesteModifierDepot,BoolRappelDeDate;
        Double Taux;
      //  Boolean PasserLoperation;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
             bwcharmemntCombo.RunWorkerAsync();
            //tDate.Value = ClassVaribleGolbal.DateDuJOUR;
            //tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
            //tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
            //tDateJ.Value = ClassVaribleGolbal.DateDuJOUR;
            //tdateInventaire.Value = ClassVaribleGolbal.DateDuJOUR;
            panelEntree.Visible = false;
            panelSortie.Visible = false;
            SupprimerOratioNonValide();
            pCommande.Enabled = false;
            Taux = ClassVaribleGolbal.TauxFc;
            //tVente.Text = CompteDEservicleint(72, 1);
            
            // pStockage.Visible = false;
            // tabPage3.Text = "";

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           // GroupeFournisseur = GroudeCompteselonIndicateur(400);
           // GroupeBonGratuit = GroudeCompteselonIndicateur(7310);
           // GroupeCaisse = GroudeCompteselonIndicateur(570);
           
           // ChargmenComboCompte();
            ChargmentDepot();
           
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


            catch (Exception ex)
            {
                compte = "0";
                MessageBox.Show(ex.Message);
            }
            
            return compte;


            cmd.Dispose();
            con.Close();

        }




        private void chargementComboCompteCat(ComboBox id, ComboBox des, DataTable tb)
        {
            try
            {

                //                string sCompte = "SELECT        DesCategorieA, IdCategorieArtilcle, Compte " +
                // " FROM tCatArticle " +
                //" WHERE(Compte = @a)";

                //                string[] r = { para };
                //                string[] r3 = { };
                //                ClassRequette classeReq = new ClassRequette();
                //                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);

                            id.DataSource = tb;
                des.DataSource = tb; 
                id.DisplayMember = "IdCategorieArtilcle";
                id.ValueMember = "IdCategorieArtilcle";
                des.ValueMember = "IdCategorieArtilcle";
                des.DisplayMember = "DesCategorieA";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        DataTable TableCategorie, TableCategorie2, TableCategorie3;
        private void chargementComboCateAarticle( string para)
        {
            try
            {

                string sCompte = "SELECT        DesCategorieA, IdCategorieArtilcle, Compte " +
 " FROM tCatArticle ";
//" WHERE(Compte = @a)";

                string[] r = { para };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();
                
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCategorie = classeReq.dt;

                //classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //TableCategorie2 = classeReq2.dt;


               
                //id.DataSource = classeReq.dt;
                //des.DataSource = classeReq.dt; ;
                //id.DisplayMember = "IdCategorieArtilcle";
                //id.ValueMember = "IdCategorieArtilcle";
                //des.ValueMember = "IdCategorieArtilcle";
                //des.DisplayMember = "DesCategorieA";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       // DataTable TableCategorie2, TableCategorie3;

        private void chargementComboCateAarticle2(string para)
        {
            try
            {

                string sCompte = "SELECT        DesCategorieA, IdCategorieArtilcle, Compte " +
 " FROM tCatArticle "; //+
//" WHERE(Compte = @a)";

                string[] r = { para };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCategorie2 = classeReq.dt;

                //classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //TableCategorie2 = classeReq2.dt;



                //id.DataSource = classeReq.dt;
                //des.DataSource = classeReq.dt; ;
                //id.DisplayMember = "IdCategorieArtilcle";
                //id.ValueMember = "IdCategorieArtilcle";
                //des.ValueMember = "IdCategorieArtilcle";
                //des.DisplayMember = "DesCategorieA";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void chargementComboCateAarticle3(string para)
        {
            try
            {

                string sCompte = "SELECT        DesCategorieA, IdCategorieArtilcle, Compte " +
 " FROM tCatArticle " +
" WHERE(Compte = @a)";

                string[] r = { para };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCategorie3 = classeReq.dt;

                //classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //TableCategorie2 = classeReq2.dt;



                //id.DataSource = classeReq.dt;
                //des.DataSource = classeReq.dt; ;
                //id.DisplayMember = "IdCategorieArtilcle";
                //id.ValueMember = "IdCategorieArtilcle";
                //des.ValueMember = "IdCategorieArtilcle";
                //des.DisplayMember = "DesCategorieA";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataTable TableComboArticle, TableComboArticle2;
        String IdypeArtece, compteAticleSectionne, IdypeArtece2, compteAticleSectionne2;
        private void chargementComboArticle(string para,String para2)
        {
            try
            {

                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle,QteEnDet " +
" FROM tStock " +
" WHERE        (Compte =@a)  ";//AND (CategorieArticle = @b)

                string[] r = { para2, para };
                //MessageBox.Show(para  +"/" +para2);
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableComboArticle = classeReq.dt;
                //id.DataSource = classeReq.dt;
                //des.DataSource = classeReq.dt; ;
                //id.DisplayMember = "IdCategorieArtilcle";
                //id.ValueMember = "IdCategorieArtilcle";
                //des.ValueMember = "IdCategorieArtilcle";
                //des.DisplayMember = "DesCategorieA";

               // MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void chargementComboArticle2(string para, String para2)
        {
            try
            {

                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
" FROM tStock " +
" WHERE        (Compte =@a)  ";
                //AND (CategorieArticle = @b)
                string[] r = { para2, para };
                //MessageBox.Show(para  +"/" +para2);
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableComboArticle2 = classeReq.dt;
               ;

                // MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        DataTable tableDesArticle;
        private void chargemeTousLesArticle( string compte)
        {
            try
            {

                string sCompte = "SELECT        CodeArticle, DesegnationArticle, PrixAchat,PrixVente, Compte, CategorieArticle " +
" FROM tStock WHERE   (Compte =@a) ";
//" WHERE        (Compte =@a)  ";
                //AND (CategorieArticle = @b)
               //string[] r = { comboCompteDestockage.Text.Trim() };
                string[] r = { compte };
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
        private void ChargementComboPourCodeArticle( ComboBox id, ComboBox des, DataTable t1)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "CodeArticle";
            id.ValueMember = "CodeArticle";
            des.ValueMember = "CodeArticle";
            des.DisplayMember = "DesegnationArticle";

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


        private void ChargementComboDepot(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "CodeDepot";
            id.ValueMember = "CodeDepot";
            des.ValueMember = "CodeDepot";
            des.DisplayMember = "DesignationDepot";

        }
        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                //comboCatArti.DataSource = CbCat;
                //comboCatArti.DisplayMember = "DesCategorieA";
                //comboCatArti.ValueMember = "IdCategorieArtilcle";

                ChargementCombo(CbGroupe3, comboCompteStock, comboStockDes);
                ChargementCombo(CbGroupe3, comboCompteStockInv, comboStockDesInv);
                ChargementCombo(CbFournisseur, comboCompteFournisseur, comboFournisseur);
                ChargementCombo(CbGroupe2, comboCompteDestockage, combooDestockageDES);
                ChargementComboDepot(tableDepot, comboDepot, comboDepotDes);
                ChargementComboDepot(tableDepot, comboCodeDepot2, comboDepoDES2);
                comboCompte.DataSource = CbGroupe;
                comboCompte.DisplayMember = "NumCompte";
                comboCompte.ValueMember = "NumCompte";

                comboDEsegnationCompte.DataSource = CbGroupe;
                comboDEsegnationCompte.DisplayMember = "DesignationCompte";
                comboDEsegnationCompte.ValueMember = "NumCompte";

                comboCatDepot.DataSource = TableCategorieDp;
                comboCatDepot.DisplayMember = "DesignationCatDepot";
                comboCatDepot.ValueMember = "CodeCategorieDepot";
                //DesignationCatClirntEmb
                DrnierOP();
                tCodeDP.Text = fonctionOPdepot();
                tNumService.Text = NumService;
                //tNumOP.Text = fonctionOP();


            }
            
           
           




           





            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }
        }

        DataTable CbGroupe, cbSougroupe, CbCat;

        private void dGsousGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable CbGroupe2, CbGroupe3,CbFournisseur,TableCategorieDp;
        private void ChargmenComboCompte()
        {
            try
            {

                string sCompte2;

                string sCompte = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
" FROM tCompte INNER JOIN " +
" tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Cadre = 31) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                string sCagorie = " SELECT        CodeCategorieDepot, DesignationCatDepot FROM            tCategoriDepot WHERE        (CodeCategorieDepot <> 1) ";


                if ( cBinitiql.Checked == true)
                {
                    sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                  " FROM tCompte INNER JOIN " +
                  " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                  "  " +
                  " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre ";

                }
                else
                {
                    if  (boolAchatBon == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE(tGroupeCompte.GroupeCompte =" + GroupeBonGratuit +") " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                    }


                    else if (rbDepenseCuisine.Checked == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE (tGroupeCompte.GroupeCompte= " + GroupeBonGratuit + "  ) " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";
                    }

                    else if (rbVenteSpecial.Checked == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE (tGroupeCompte.GroupeCompte= " + GroupeCaisse + "  ) " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                    }


                    else if (rbSortieAutre.Checked == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                    }

                    else if (rBStockageAutreAchat.Checked == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                    }
                    //rbSortieAutre
                    //" WHERE (tGroupeCompte.GroupeCompte= " + GroupeCaisse + "  ) " +
                       // rBStockageAutreAchat
                  
                    else
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE (tGroupeCompte.GroupeCompte= " + GroupeFournisseur + "  ) OR (tGroupeCompte.GroupeCompte= 5101  ) " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";


                    }


                }



                string[] r = { "" };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe = classeReq.dt;

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe2 = classeReq.dt;

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe3 = classeReq.dt;

                // CbFournisseur
                classeReq.chargementAvecLesParametre(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbFournisseur = classeReq.dt;
                //
                classeReq.chargementAvecLesParametre(sCagorie, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCategorieDp = classeReq.dt;








                //                Connection_Data();
                //                con.Open();
                //                cmd.CommandText = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                //" FROM tCompte INNER JOIN " +
                //" tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                //" WHERE(tGroupeCompte.Cadre = 31) " +
                //" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                //                cmd.CommandType = CommandType.Text;
                //                cmd.Parameters.AddWithValue("@CategorieCompte", 2);
                //                da.Fill(dt);
                //                con.Close();


                //                if (dt.Rows.Count > 0)
                //                {
                //                    CbGroupe = dt;
                //                    comboDesignatioGroupe.DataSource = dt;
                //                    comboPosrIN.DataSource = dt;
                //                    comboPreIns.DataSource = dt;






                //                    comboPosrIN.DisplayMember = "PostnomEleve";
                //                    comboPosrIN.ValueMember = "MatriculeEleve";

                //                    comboPreIns.DisplayMember = "PrenomEleve";
                //                    comboPreIns.ValueMember = "MatriculeEleve";
                //                }

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);

            }








            //  da.Dispose();
        }

        private void ChargmenTdgSOMMAIRparDpotRechercherParNon()
        {
            try
            {


                string sCompte = " SELECT (SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie)) AS Enstok,   ((SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie)) * tStock.PrixAchat) AS Solde ,tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
" FROM            tOperation INNER JOIN " +
               "   tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                       "   tStock ON tMvtStock.CodeArticle = tStock.CodeArticle " +
" GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, tStock.Compte, tStock.IdArticle ,tStock.PrixAchat " +
" HAVING(tDepot.CodeDepot = @a)  AND  (tStock.DesegnationArticle) LIKE \'%" + tCherche.Text + "%\'" + " ORDER BY tStock.Compte, tStock.IdArticle ";

                string[] r = { comboCodeDepot2.Text, ClassVaribleGolbal.CodeDepartement };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableDgSommaire = classeReq.dt;

               







            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }








            //  da.Dispose();
        }


        DataTable TableDgSommaire;
        private void ChargmenTdgSOMMAIRparDpot()
        {
            try
            {


                string sCompte = " SELECT (SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie)) AS Enstok,   ((SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie)) * tStock.PrixAchat) AS Solde ,tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
" FROM            tOperation INNER JOIN " +
               "   tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                       "   tStock ON tMvtStock.CodeArticle = tStock.CodeArticle " +
" GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, tStock.Compte, tStock.IdArticle ,tStock.PrixAchat " +
" HAVING(tDepot.CodeDepot = @a)   ORDER BY tStock.Compte, tStock.IdArticle ";

                string[] r = { comboCodeDepot2.Text, ClassVaribleGolbal.CodeDepartement };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                 classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableDgSommaire = classeReq.dt;

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






        DataTable tableDepot;

        private void ChargmentDepot()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        CodeDepot, DesignationDepot, SoldeCompte, SodeQteCompte, CreerPar " +
 " FROM tDepot ";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CategorieCompte", 2);
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

                 lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }
        private void comboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmenArticledg();
            //chargementComboCompteCat(comboCatArticle, comboCatDes, comboCompte.Text);
            TesteCate = true;
            Compteselectionne = comboCompte.Text;
            if (bwChaCategorie.IsBusy ==false)
            {
                bwChaCategorie.RunWorkerAsync();
            }
          

        }
        DataTable TableAricle;
        private void ChargmenArticledg( )
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectArticleDG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                //  dGArticle.DataSource = dt;
                TableAricle = dt;
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

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }



        private void ChargmenArticleDgDerect()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectArticleDG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                //  dGArticle.DataSource = dt;
                dGArticle.DataSource = dt;
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

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        String CodeArticlInitiaApasser,ReferanceCompte;
        String StockCritiqueApassa, PuVenteAppasser,  UniteAppasser;
        String SprixPoindedevente = "INSERT INTO tPametreDepot " +
                       "   (CodeDepot, CodeArticle, StockCritique, PuVente, Unite) VALUES(@CodeDepot, @CodeArticle, @StockCritique, @PuVente, @Unite)";
        private void PasserLesInitiauxesArticleAUdepot()
        {
           // enregOpration();
            String codeDepot;// CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbNuite.Maximum = tableDepot.Rows.Count - 1;
            for (int i = 0; i <= tableDepot.Rows.Count - 1; i++)
            {
                bwEnreNuitte.ReportProgress(i);
                codeDepot = tableDepot.Rows[i]["CodeDepot"].ToString();
                //CompteClien = DtNuite.Rows[i]["Compte"].ToString();
                // CompteChambre = DtNuite.Rows[i]["CptCh"].ToString();
                // CodeChambre = DtNuite.Rows[i]["CodeChambre"].ToString();
                //Tarrif = DtNuite.Rows[i]["PrixConvenu"].ToString();

                // InserMvtCpte("inserertMvtChambre", numOperationLO, CodeChambre, Tarrif, "0", Tarrif, codeClient, "1", "0", "0");

                //InserMvtCpte("inserertMvtClient", numOperationLO, codeClient, Tarrif, "0", Tarrif, CodeChambre, "1", "0", "0");
                //InserMvtCpte("insererMvtcpt", numOperationLO, CompteChambre, "0", Tarrif, Tarrif, CodeChambre, "1", "0", "0");

                // InserMvtCpte("insererMvtcpt", numOperationLO, CompteClien, Tarrif, "0", Tarrif, codeClient, "1", "0", "0");


                //CptCh
                //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";

                InserMvtCpteStock("inserertMvtStock", CodeArticlInitiaApasser, codeDepot, "0", "0", "0", ReferanceCompte, "0", ClassVaribleGolbal.OPinit);
                 
                InsererPrixParDepot(SprixPoindedevente, codeDepot, CodeArticlInitiaApasser, StockCritiqueApassa, PuVenteAppasser, UniteAppasser);
                //MessageBox.Show(ReferanceCompte);
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }

        DataTable TableTousLesAricle;
        private void ChargmenTbletousleARTICLE()
        {
            try
            {
                
                string sCompte = "Select * from tStock ";

           
                string[] r = { "" };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableTousLesAricle = classeReq.dt;

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        DataTable TableDepot2;
        private void ChargmenDgDepot()
        {
            try
            {

                string sCompte = "SELECT        tDepot.CodeDepot, tCategoriDepot.DesignationCatDepot, tDepot.DesignationDepot, tDepot.Vehicule, tDepot.Chauffeur, tDepot.Receveur " +
 " FROM tDepot INNER JOIN " +
                        "   tCategoriDepot ON tDepot.CodeCategorieDepot = tCategoriDepot.CodeCategorieDepot  ORDER BY Id ";


                string[] r = { "" };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableDepot2 = classeReq.dt;

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }
        private void PasserLesInitiauxDedepot()
        {
            // enregOpration();


            ChargmenTbletousleARTICLE();
            String codeAricle;// CodeChambre, CompteClien, CompteChambre, Tarrif;
            String PrixVente, Critique, UiniteEnDetaille;
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbNuite.Maximum = TableTousLesAricle.Rows.Count - 1;
            for (int i = 0; i <= TableTousLesAricle.Rows.Count - 1; i++)
            {
                bwEnreNuitte.ReportProgress(i);
                codeAricle = TableTousLesAricle.Rows[i]["CodeArticle"].ToString();
                PrixVente = TableTousLesAricle.Rows[i]["PrixVente"].ToString();
                Critique = TableTousLesAricle.Rows[i]["Critique"].ToString();
                UiniteEnDetaille = TableTousLesAricle.Rows[i]["UiniteEnDetaille"].ToString();
               // MessageBox.Show(" art" + codeAricle + "dp" + CodeDepotApasser);
                InserMvtCpteStock("inserertMvtStock", codeAricle, CodeDepotApasser, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);

                //if (TesteModifierDepot == false)
                //{
                    InsererPrixParDepot(SprixPoindedevente, CodeDepotApasser, codeAricle, Critique, PrixVente, UiniteEnDetaille);
                //}
                
                   
                //MessageBox.Show(ReferanceCompte);
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }


        private void UpdateInitPU( String Para, String Para2)
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
        private void InserMvtCpteStock(string storage, string NumCompte, String CodeDepot,  string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


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
                 cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", "0");
                cmd.Parameters.AddWithValue("@QteSortie ", "0");
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", "0");
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(ReferanceCompte);
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
            }



            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message + " en ref " + NumCompte,ReferanceCompte);

                lmessage.Text = ex.Message + " en ref " + NumCompte +ReferanceCompte;

            }

        }






        private void InserMvtCpteStockAvecQte(string storage, string NumCompte, String CodeDepot, String QteEntree, string QteSortie, string PR, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


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

                //MessageBox.Show(ex.Message + " en ref " + NumCompte,ReferanceCompte);

                lmessage.Text = ex.Message + " en ref " + NumCompte + ReferanceCompte;

            }

        }
        private void InserMvtCpteStockAvecQte2(string storage, string NumCompte,  String QteEntree, string QteSortie, string PR, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


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
            }



            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message + " en ref " + NumCompte,ReferanceCompte);

                lmessage.Text = ex.Message + " en ref " + NumCompte + ReferanceCompte;

            }

        }


        private void InsererPrixParDepot(string s, string CodeDepot, String CodeArticle, string StockCritique, string PuVente, string Unite)
        {
            try
            {
               

                //MessageBox.Show( " dd" + ReferanceCompte + "/" + refComp);
                cmd.Parameters.Clear();
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                cmd.Parameters.AddWithValue("@CodeArticle", CodeArticle);
                cmd.Parameters.AddWithValue("@StockCritique", StockCritique);
                cmd.Parameters.AddWithValue("@PuVente", PuVente);
                cmd.Parameters.AddWithValue("@Unite", Unite);
               
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(ReferanceCompte);
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();



                //if (con.State == ConnectionState.Open)
                //{
                //    con.Open();
                //    con.Close();
                //}

            }



            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message + " en ref " + NumCompte,ReferanceCompte);

                lmessage.Text = ex.Message + " en ref " + CodeDepot + CodeArticle;

            }

        }
        private void bEnreSous_Click(object sender, EventArgs e)
        {
            boolProcedureEneDepot = false;
            CodeArticlInitiaApasser = tCodeArticle.Text;
           // MessageBox.Show(comboCompte.Text);
            ReferanceCompte = comboCompte.Text;
            //MessageBox.Show(ReferanceCompte);
            StockCritiqueApassa = tCritique.Text;
            PuVenteAppasser = tPrixdeVente.Text;
            UniteAppasser = tUnitesEnDetail.Text;
            PbNuite.Visible = true;
            if  (tCodeArticle.Text .Trim() !="")
            {

                if (bwEnreNuitte.IsBusy == false)
                {

                    bwEnreNuitte.RunWorkerAsync();
                }
                //MessageBox.Show(ReferanceCompte);
                //if (bwEnreNuitte.IsBusy == false)
                //{
                //    if (test == true)
                //    {

                //        ModificationSousArticle();
                //        ChargmenArticledg();

                //    }

                //    else
                //    {
                //        InsereSousArticle();
                //         ChargmenArticledg();

                //    }








                // ChargmenArticleDgDerect();
            }

        }

        //private void ChargmenComboCategorie()
        //{
        //    try
        //    {

        //        Connection_Data();
        //        con.Open();
        //        cmd.CommandText = "SelectCategorieArticle";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //       // cmd.Parameters.AddWithValue("@CategorieCompte", 2);
        //        da.Fill(dt);
        //        con.Close();


        //        if (dt.Rows.Count > 0)
        //        {
        //            CbCat = dt;
        //            // comboDesignatioGroupe.DataSource = dt;
        //            // comboPosrIN.DataSource = dt;
        //            //  comboPreIns.DataSource = dt;






        //            //  comboPosrIN.DisplayMember = "PostnomEleve";
        //            //comboPosrIN.ValueMember = "MatriculeEleve";

        //            // comboPreIns.DisplayMember = "PrenomEleve";
        //            //comboPreIns.ValueMember = "MatriculeEleve";
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        // lmessage.Text = ex.Message;

        //    }

        //    //  da.Dispose();
        //}

        private void tCodeArticle_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dGArticle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ci;
            ci = dGArticle.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tModifier.Text = dGArticle["SousGroupe", ci].Value.ToString().Trim();



        }

        private void InsereSousArticle()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "InsertStock";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeArticle", tCodeArticle.Text);
                cmd.Parameters.AddWithValue("@DesegnationArticle", tDesignatonArticle.Text);
                cmd.Parameters.AddWithValue("@CategorieArticle", comboCatArticle.Text);
                cmd.Parameters.AddWithValue("@PrixVente", tPrixdeVente.Text);
                cmd.Parameters.AddWithValue("@PrixAchat", tPrixUsine.Text);
                //@PrixAchat
                cmd.Parameters.AddWithValue("@CreeerPar", utilisateur);
                 cmd.Parameters.AddWithValue("@Critique", tCritique.Text);
                cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                 cmd.Parameters.AddWithValue("@Compte", comboCompte.Text.Trim());


                cmd.Parameters.AddWithValue("@UniteEngro", tUinteEngros.Text);
                cmd.Parameters.AddWithValue("@UiniteEnDetaille", tUnitesEnDetail.Text);
                cmd.Parameters.AddWithValue("@QteEnDet", tQteEnDetail.Text.Trim());
                cmd.ExecuteNonQuery();

               // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
               //  MessageBox.Show(" EST AJOUTE");
                annulerArtclicle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void comboCatArti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        //private string CompteDEservicleint(int type, int sevice)
        //{


        //    string compte;
        //    con = new SqlConnection();
        //    con.ConnectionString = ClassVaribleGolbal.seteconnexion;
        //    con.Open();
        //    cmd = new SqlCommand();
        //    string s = "SELECT NumCompte FROM tPServiceStock WHERE (Type = @a) AND (NumDeservice = @b)";
        //    cmd.Connection = con;
        //    cmd.CommandText = s;
        //    cmd.Parameters.AddWithValue("@a", type);
        //    cmd.Parameters.AddWithValue("@b", sevice);
        //    //SqlDataReader lire;
        //    compte = cmd.ExecuteScalar().ToString();
        //    return compte;


        //    cmd.Dispose();
        //    con.Close();

        //}

        private void rbStockBoisson_CheckedChanged(object sender, EventArgs e)
        {
            //combo CompteDEservicleint()
            //if (rbStockAlimant.Checked == true)
            //{
            //    comboCompte.Text = CompteDEservicleint(35, 7);
            //}
            //if (rbStockBoisson.Checked == true)
            //{

            //    comboCompte.Text = CompteDEservicleint(31, 7);
            //}
            //if (RbAutres.Checked == true)
            //{
            //    comboCompte.Text = CompteDEservicleint(35, 7);
            //}

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboDEsegnationCompte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChargementEngros();
            calculerFc();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        Boolean TesteCate, TesteArtice;
        private void comboCompteStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            affectationCompteVariation();

        }
         
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementCBstock();

        }
         private void  affectationCompteVariation()
        {
            TesteCate = true;
            Compteselectionne2 = comboCompteStock.Text;
           // MessageBox.Show(comboCompteStock.Text);
            try
            {
                comboCompteStock.ValueMember = "Variation";
                String v = "";
                // MessageBox.Show(comboCompteStock.SelectedValue.ToString());
                v = comboCompteStock.SelectedValue.ToString();
                if (v.Trim() == "B")
                {
                    tVariariotion.Text = CompteDEservicleint(61, 1);
                }


                else if (v.Trim() == "H")
                {
                    tVariariotion.Text = CompteDEservicleint(63, 1);

                }

                else if (v.Trim() == "C")
                {
                    tVariariotion.Text = CompteDEservicleint(62, 1);
                }

                else if (v.Trim() == "P")
                {
                    tVariariotion.Text = CompteDEservicleint(65, 1);
                }

                else
                {
                    tVariariotion.Text = CompteDEservicleint(64, 1);
                }

            }
            catch (Exception ex)
            {
                lmessage.Text = ex.ToString();
            }

            //if (bwChaCategorie.IsBusy == false)
            //{
            //    bwChaCategorie.RunWorkerAsync();
            //}

           // chargementCBstock();
        }





        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        String QteENdetaik;
        private void ChargementEngros()
        {
            try
            {
                if (cBenGros .Checked == true )

                {
                    tQteEntree.Enabled = false;
                    tAgros.Enabled = true;
                    // tCreditte2.Text = comboCompteDestockage.Text;
                    comboCodeArticleStock.ValueMember = "QteEnDet";
                    // tPuSortie.Text = comboArticleDestockage.SelectedValue.ToString();
                    QteENdetaik = comboCodeArticleStock.SelectedValue.ToString();
                    //comboArticleDestockage.ValueMember = "PrixAchat";
                    //Tlifo.Text = comboArticleDestockage.SelectedValue.ToString();
                    // comboCompteDestockage.ValueMember = "Unite";
                    // Unite = comboCompteDestockage.SelectedValue.ToString();
                    tQteEntree.Text = (double.Parse(QteENdetaik) * double.Parse(tAgros.Text)).ToString();
                }

                else
                {
                    tQteEntree.Enabled = true;
                    tAgros.Enabled = false;

                }



              

            }
            catch
            {
                tQteEntree.Text = "";

            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementPUAchat();
        }
         private void ChargementPUAchat()
        {

            try
            {

                comboCodeArticleStock.ValueMember = "PrixVente";
                tQtePu.Text = comboCodeArticleStock.SelectedValue.ToString();
              //  MessageBox.Show(comboCodeArticleStock.SelectedValue.ToString());
                comboCodeArticleStock.ValueMember = "CodeArticle";
                //tVariariotion.Text = CompteDEservicleint(1, 2);
               // ChargementEngros();

            }

            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void typeOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tNumOP.Text = fonctionOP();
            tLibelle.Text = typeOP.Text + "SUIVANT No";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        string Compteselectionne, Compteselectionne2, Compteselectionne3;

        private void bwChaCategorie_DoWork(object sender, DoWorkEventArgs e)
        {

            if (TesteCate == true)
            {
                chargementComboCateAarticle(Compteselectionne);
                chargementComboCateAarticle2(Compteselectionne2);
                chargementComboCateAarticle3(Compteselectionne3);
                ChargmenArticledg();
                //MessageBox.Show(Compteselectionne + "000");
            }
            else if (TesteArtice == true)
            {

                chargementComboArticle(IdypeArtece, compteAticleSectionne);
                chargementComboArticle2(IdypeArtece2, compteAticleSectionne2);

            }




           
        }

        private void comboTypeStock_Click(object sender, EventArgs e)
        {
            
        }
         private void chargementCBstock()
        {
            //chargementComboArticle
            TesteArtice = true;
            TesteCate = false;
            // Compteselectionne = comboCompteStock.Text;
            IdypeArtece = comboTypeStock.Text;
            compteAticleSectionne = comboCompteStock.Text.Trim();
            if (bwChaCategorie.IsBusy == false)
            {
                bwChaCategorie.RunWorkerAsync();
            }
        }
        private void comboTypeDestockage_Click(object sender, EventArgs e)
        { 
            //chargementComboArticle
           

        }

         private void chargementComboDestockage()
        {

            TesteArtice = true;
            TesteCate = false;
            // Compteselectionne = comboCompteStock.Text;
            IdypeArtece2 = comboTypeDestockage.Text;
            compteAticleSectionne2 = comboCompteDestockage.Text.Trim();
            if (bwChaCategorie.IsBusy == false)
            {
                bwChaCategorie.RunWorkerAsync();
            }
        }


        private void cbModiferCompte_CheckedChanged(object sender, EventArgs e)
        {
            tModifier.ReadOnly = !cbModiferCompte.Checked;
        }

        private void tModifier_TextChanged(object sender, EventArgs e)
        {
           


            try
            {
                test = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tStock ";
                s = s + " where CodeArticle=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tModifier.Text.Trim());
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {
                    tModifier.Text= lire["CodeArticle"].ToString();
                    tCodeArticle.Text = lire["CodeArticle"].ToString();
                    tDesignatonArticle.Text = lire["DesegnationArticle"].ToString();
                    comboCatDes.SelectedValue = lire["CategorieArticle"].ToString();
                    tPrixdeVente.Text = lire["PrixVente"].ToString();
                    tPrixUsine.Text = lire["PrixAchat"].ToString();
                    tCritique.Text = lire["Critique"].ToString();
                    comboCompte.SelectedValue = lire["Compte"].ToString();
                    tUinteEngros.Text = lire["UniteEngro"].ToString();
                    tUnitesEnDetail.Text = lire["UiniteEnDetaille"].ToString();
                    tQteEnDetail.Text = lire["QteEnDet"].ToString();
                    //dateNaiss.Text = lire["DateNais"].ToString();
                    tDesAmodifier.Text = lire["DesegnationArticle"].ToString();

                    //cmd.Parameters.AddWithValue("@UniteEngro", tUinteEngros.Text);
                    //cmd.Parameters.AddWithValue("@UiniteEnDetaille", tUnitesEnDetail.Text);
                    //cmd.Parameters.AddWithValue("@QteEnDet", tQteEnDetail.Text.Trim());

                    test = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSupprimmer.Enabled = test;
                if ((test == true))
                {
                    bEnreSous.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreSous.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        }

        private void bwEnreNuitte_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PbNuite.Value = e.ProgressPercentage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Tesstockage = true;
            Tesstockage = rbEntreeStock.Checked;
            TesteDestockage = rbSortieStock.Checked;
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "")
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                    BoolRappelDeDate = true;
                }

                bValiderAchat.Enabled = false;
            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT");
            }



        }


            private void EnrmouvemmentComptble()
            {
                try
                {

                Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                //  enregOprationComptable();

                // InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, DepotMagasin, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text,  tVariariotion.Text, "0", tNumOP.Text);

                InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteStock.Text,"0", "0","0",tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOP.Text);

                // InserMvtCpteStockAvecQte("inserertMvtStock", comboCodeArticleStock.Text, DepotMagasin, tQteEntree.Text, "0", tQtePu.Text, tTotalStock.Text, "0", tQtePu.Text, tVariariotion.Text, "0", tNumOP.Text);
                InserMvtCpteStockAvecQte2("insererMvtcpt", AchatStock, "0", "0", "0", tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOP.Text);

                InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteFournisseur.Text, "0","0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOP.Text);

                InserMvtCpteStockAvecQte2("insererMvtcpt", tVariariotion.Text, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOP.Text);

                // UpdateInitPU(comboCodeArticleStock.Text,tQtePu.Text);

                ValidationDeloperation(tNumOP.Text);
                //  ChargmentGg10DernierOP();
                //ChargmentGg10DernierOP();


                con.Close();
                cmd.Dispose();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            




        }

        private void ValidationDeloperation(string op)
        {
            try
            {
                string smodifie = "UPDATE tOperation SET Valider =0 WHERE (NumOperation = @a)";

                string[] r2 = { op };
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
            {

                // MessageBox.Show(ex.Message); 
            
            }


        }

        Boolean TesteDestockage, Tesstockage;
        private void EnrmouvemmentDestockage()
        {
            try
            {

                
                //enregOprationDestockage();
              
                //InserMvtCpteStockAvecQte("inserertMvtStock", comboArticleDestockage.Text, comboDepot.Text, tQteSortie.Text, "0", tPuSortie.Text, tTotalSortie.Text, "0", "0", comboCompteDestockage.Text, "0", tNumOp2.Text);
             
                //InserMvtCpteStockAvecQte("inserertMvtStock", comboArticleDestockage.Text, DepotMagasin, "0", tQteSortie.Text, tPuSortie.Text, "0", tTotalSortie.Text, "0", comboCompteDestockage.Text, "0", tNumOp2.Text);
              
                //UpdateInitPU(comboArticleDestockage.Text, tPuSortie.Text);










              

                    Connection_Data();
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    //  enregOprationComptable();

                    if (rbDepenseCuisine.Checked == true || rbSortieAutre.Checked== true)
                    {
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteStock.Text, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOP.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteFournisseur.Text, "0", "0", "0", tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOP.Text);

                    }

                    else if (rbVenteSpecial.Checked == true)
                    {
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVariariotion.Text, "0", "0", "0", tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOP.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteStock.Text, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOP.Text);

                        InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteFournisseur.Text, "0", "0", "0", tSommeVente.Text, "0", "0", DepotMagasin, "0", tNumOP.Text);
                        InserMvtCpteStockAvecQte2("insererMvtcpt", tVente.Text, "0", "0", "0", "0", tSommeVente.Text, "0", DepotMagasin, "0", tNumOP.Text);
                    
                    }
                   

                   // InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompteFournisseur.Text, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOP.Text);

                   
                    // UpdateInitPU(comboCodeArticleStock.Text,tQtePu.Text);

                    ValidationDeloperation(tNumOP.Text);
                    //  ChargmentGg10DernierOP();
                    //ChargmentGg10DernierOP();


                    con.Close();
                    cmd.Dispose();
                
                


                //ChargmentGg10DernierOP();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }
        DataTable JournalOP;
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
                cmd.CommandText =  "SELECT        TOP (20) tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tDepot.DesignationDepot, tOperation.NumOperation, tOperation.Libelle " +
 " FROM tOperation INNER JOIN " +
                         "  tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN "  +
                          " tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN "  +
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

        DataTable FicheDechargement;
        Double ValeurChargement, VEntreeQte, VSortieQte;
        private void ChargmentGgDernierChargement()
        {
            try
            {

          
                string s = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation,tMvtStock.NumRef  " +
", (tMvtStock.Entree + tMvtStock.Sortie) AS Valeur   FROM tMvtStock INNER JOIN " + 
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " + 
                        "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND(tDepot.CodeDepot <>@b)";


              


                ClassRequette classeReq = new ClassRequette();

                string[] r = { tNumOp2.Text,DepotMagasin };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                FicheDechargement = classeReq.dt;


                DataTable TB = classeReq.dt;
                Double motant,QteEntree,QteSortie;
                ValeurChargement = 0;
                VEntreeQte = 0; VSortieQte = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Valeur"].ToString());
                    QteEntree = Double.Parse(TB.Rows[i]["QteEntree"].ToString());
                    QteSortie = Double.Parse(TB.Rows[i]["QteSortie"].ToString());
                    // tot = tot + motant;
                    ValeurChargement = ValeurChargement + motant;
                    VEntreeQte = VEntreeQte + QteEntree;
                    VSortieQte = VSortieQte + QteSortie;
                    // SommeFact

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }
        DataTable FicheDechargementAchat;
        double SommeFact, SommeQteAchat, SommeVente;
        private void ChargmentGgDernierChargementAchat()
        {
            try
            {
                string s;

                string sEntree = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree AS Qte , tMvtStock.QteSortie,tMvtStock.Entree AS Valeur, tMvtStock.Entree AS Vente, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation,tMvtStock.NumRef  " +
" FROM tMvtStock INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteEntree <>0) ";

                string sSortie = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteSortie AS Qte,tMvtStock.Sortie AS Valeur, tMvtStock.Vente AS Vente, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation,tMvtStock.NumRef, tMvtStock.PVentUN  " +
" FROM tMvtStock INNER JOIN " +
                      "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                      "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                       " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteSortie <>0) ";




                ClassRequette classeReq = new ClassRequette();

                if (rbEntreeStock.Checked == true)
                {
                    s = sEntree;
                }
                else
                {
                    s = sSortie;
                }

                string[] r = { tNumOP.Text, DepotMagasin };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                FicheDechargementAchat = classeReq.dt;

                DataTable TB = classeReq.dt;
                Double motant,QteAchat,Vente ;
                SommeFact = 0;
                SommeQteAchat = 0;
                SommeVente = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Valeur"].ToString());
                    QteAchat = Double.Parse(TB.Rows[i]["Qte"].ToString());
                    Vente = Double.Parse(TB.Rows[i]["Vente"].ToString());
                    // tot = tot + motant;
                    SommeFact = SommeFact + motant;
                    SommeQteAchat = SommeQteAchat + QteAchat;
                    SommeVente = SommeVente + Vente;
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
        private void ChargmentGg10DernierOPVide()
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
                DgJournal.DataSource = JournalOP;
                dGjournal2.DataSource = JournalOP;
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }
        private void InserMvtCpte(string storage, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                //Connection_Data();
                //if (con.State != ConnectionState.Open)
                //{
                //    con.Open();
                //}
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", NumOp);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", "0");
                cmd.Parameters.AddWithValue("@QteSortie ", "0");
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", "0");
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(" EST AJOUTE");
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }



        private void InserMvtCpteDstok(string storage, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                //Connection_Data();
                //if (con.State != ConnectionState.Open)
                //{
                //    con.Open();
                //}
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", NumOp);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", "0");
                cmd.Parameters.AddWithValue("@QteSortie ", "0");
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", "0");
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(" EST AJOUTE");
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }

        private void enregOprationComptable()
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,Valider,TauxDuJour, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g,@h, @da)";

                string[] r = { tNumOP.Text, tLibelle.Text, utilisateur, "0", "0", " " ,"1",Taux.ToString()};
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
                //MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }


        private void enregOprationDestockage()
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,TauxDuJour, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g, @da)";

                string[] r = { tNumOp2.Text, tLIBELLE2.Text, utilisateur, "0", "0", " ",Taux.ToString() };
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
//MessageBox.Show("okoppp");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void bwEnreCompte_DoWork(object sender, DoWorkEventArgs e)
        {
            if  (TesteDestockage ==true)

            {
                EnrmouvemmentDestockage();
            }
            else if (Tesstockage ==true)
            {
                EnrmouvemmentComptble();

            }

           
        }

        private void bwEnreCompte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            if (TesteDestockage == true)
            {
                dGjournal2.DataSource = JournalOP;
                tNumOp2.Text = fonctionOPSotie();
                //AnullerOpComptable();
                AnullerDestockage();
                CbSereferer2.Checked = false;

            }
            else
            {


               // DgJournal.DataSource = JournalOP;
               // tNumOP.Text = fonctionOP();
                AnullerOpComptable();
                CbSereferer.Checked = false;
                bValiderAchat.Enabled = false;
                lMessageStock.Text = "L'OPERATION  D' ACHAT EST ENRIGISTRE";

            }


            TesteDestockage = false;
            Tesstockage = false;

        }

        String LIBELEreserve, montanReseve, QteEntreeRes, tQtePuRes;

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

        private void CBcdf_CheckedChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void tTotalStock_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void tQtePu_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // tNumOP.Text = fonctionOP();
            tNumOp2.Text = fonctionOPSotie();
            //ChargmentGg10DernierOPVide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void calculerFc()
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




            //if (CBcdf.Checked == true)
            //{
            //    try
            //    {
            //        tQtePu.ReadOnly = false;
            //        tTotalStock.ReadOnly = true;
            //        tTotalStock.Text = ((double.Parse(tQteEntree.Text)) * (double.Parse( tQtePu.Text))).ToString();
            //        //tTotalStock.ReadOnly = true;
                   
            //    }
            //    catch
            //    {

            //        tTotalStock.Text = "";
            //    }
            //}
            //else
            //{
            //    //try
            //    //{
            //    //    tTotalStock.ReadOnly = false;
            //    //    tQtePu.ReadOnly = true;
            //    //    tQtePu.Text = ((double.Parse(tTotalStock.Text)) / (double.Parse(tQteEntree.Text))).ToString();
            //    //    //tQtePu.ReadOnly = true;
            //    //}
            //    //catch
            //    //{

            //    //    tQtePu.Text = "";
            //    //}
            //}


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
                }
                catch
                {

                    tTotalSortie.Text = "";
                }
            }


        }
        private void AnullerOpComptable()
        {
            ////LIBELEreserve = tLibelle.Text;
            ////montanReseve = tTotalStock.Text;
            ////tQtePuRes = tQtePu.Text;
            ////QteEntreeRes = tQteEntree.Text;
            tLibelle.Text = "";
            //tTotalStock.Text = "";
            //tQtePu.Text = "";
            //tQteEntree.Text = "";

            tSommeFact.Text = "";
            tQteApro.Text = "";
            tSommeVente.Text = "";

        }


        string libelleDestockagere, QteDESTres, puDestoRES;
        private void AnullerDestockage()
        {
            libelleDestockagere = tLIBELLE2.Text;
            QteDESTres = tQteSortie.Text;
            puDestoRES = tPuSortie.Text;
           // QteEntreeRes = tQteEntree.Text;
            tLIBELLE2.Text = "";
            tTotalSortie.Text = "";
            tQteSortie.Text = "";
            tPuSortie.Text = "";

        }

        private void comboArticleDestockage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tPuSortie.Text = fonctionPU(comboArticleDestockage.Text);
            ChargementPuSortie();
        }

        private void ChargementPuSortie()
        {

            try
            {

                comboArticleDestockage.ValueMember = "PrixVente";
                tPuSortie.Text = comboArticleDestockage.SelectedValue.ToString();
                //  MessageBox.Show(comboCodeArticleStock.SelectedValue.ToString());
                comboArticleDestockage.ValueMember = "CodeArticle";
                //tVariariotion.Text = CompteDEservicleint(1, 2);
                // ChargementEngros();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void comboDepot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbSereferer2_CheckedChanged(object sender, EventArgs e)
        {

            if (CbSereferer2.Checked == true)
            {
                tLIBELLE2.Text = libelleDestockagere;
                tQteSortie.Text =QteDESTres;
                tPuSortie.Text = puDestoRES;


            }
            else
            {
                tLIBELLE2.Text = "";
                tTotalSortie.Text = "";
                tPuSortie.Text = "";
                tQteSortie.Text = "";

            }

        }

        private void comboSCatStokDes_ChangeUICues(object sender, UICuesEventArgs e)
        {
           


        }

        private void comboTypeDestockageDES_Click(object sender, EventArgs e)
        {


           // chargementComboDestockage();
            ////chargementComboArticle
            //TesteArtice = true;
            //TesteCate = false;
            //// Compteselectionne = comboCompteStock.Text;
            //IdypeArtece2 = comboTypeDestockage.Text;
            //compteAticleSectionne2 = comboCompteDestockage.Text.Trim();
            //if (bwChaCategorie.IsBusy == false)
            //{
            //    bwChaCategorie.RunWorkerAsync();
            //}



        }

        private void tTotalSortie_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void tPuSortie_TextChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgJournal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboDepotDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormationDElibleDestockage();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void bWchargementINFO_DoWork(object sender, DoWorkEventArgs e)
        {
            //ChargmenTdgSOMMAIRparDpot();
            // ChargmenRapporSommeare();

            if (tCherche.Text.Trim() != "")
            {
                ChargmenTdgSOMMAIRparDpotRechercherParNon();
            }
            else
            {
                ChargmenTdgSOMMAIRparDpot();
            }
        }

        private void bWchargementINFO_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DGsommaireSTOCK.DataSource = TableDgSommaire;
        }

        private void comboCodeDepot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bWchargementINFO.IsBusy== false)
            {
                bWchargementINFO.RunWorkerAsync();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChargmenTdgSOMMAIRparDpot();
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
        DataTable RapportSommaireTou1, RapportSommaireTou2;

        private void button11_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2 .Value)
            {
                UpdateInit(tdateR2.Text);
                ChargmenRapporSommeareFicheDestock();
                    //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }




        }

        private void ChargmenRapporSommeare()
        {
            try
            {

                string sCompte;
                string sCompteTous = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, SUM(tMvtStock.QteEntree) AS SqteEntree, SUM(tMvtStock.QteSortie) AS SqteSortie, " +
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
                       "   tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site "+
                "  HAVING(tDepot.CodeDepot = @a)";

                string sCompteMvt = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, SUM(tMvtStock.QteEntree) AS SqteEntree, SUM(tMvtStock.QteSortie) AS SqteSortie, " +
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
                      "   tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site,tMvtStock.QteEntree + tMvtStock.QteSortie " +
               "  HAVING(tDepot.CodeDepot = @a) AND (tMvtStock.QteEntree + tMvtStock.QteSortie <> 0) ";

                string sCompte2 = " SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, SUM(tMvtStock.Entree) - SUM(tMvtStock.Sortie) " +
                        "  AS Solde " +
" FROM tOperation INNER JOIN " +
                        " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle " +
" WHERE(tOperation.DateOp BETWEEN CONVERT(DATETIME, '2011-01-01 00:00:00', 102) AND @db) " +
 " GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
              "  HAVING(tDepot.CodeDepot = @a)";


                if (CbUniquementLeMvt.Checked == true)
                {
                    sCompte = sCompteMvt;
                }

                else
                {
                    sCompte = sCompteTous;
                }
                string[] r = { comboCodeDepot2.Text };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDate(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r,d);
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



        private void ChargmenRapporSommeareEngros()
        {
            try
            {


                string sCompte = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, SUM(tMvtStock.QteEntree) AS SqteEntree, SUM(tMvtStock.QteSortie) AS SqteSortie, " +
                        "  SUM(tMvtStock.Entree) AS SEntree, SUM(tMvtStock.Sortie) AS Ssortie, tDepot.CodeDepot, tDepot.DesignationDepot, MIN(tOperation.DateOp) AS MinDate, MAX(tOperation.DateOp) AS MaxDate," +
                       "  tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tStock.UniteEngro, tStock.QteEnDet, tStock.UiniteEnDetaille "+
 " FROM            tStock INNER JOIN " +
                       "   tMvtStock ON tStock.CodeArticle = tMvtStock.NumCompte INNER JOIN " +
                       "   tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN "+
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                       "   tCompte ON tStock.Compte = tCompte.NumCompte CROSS JOIN "+
                       "   tEntrepise " +
" WHERE(tOperation.DateOp BETWEEN @da AND @db) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, tDepot.CodeDepot, tDepot.DesignationDepot, tEntrepise.Designation, " +
                       "   tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tStock.UniteEngro, tStock.QteEnDet, tStock.UiniteEnDetaille " +
" HAVING(tDepot.CodeDepot = @a)";

                string sCompte2 = " SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, SUM(tMvtStock.Entree) - SUM(tMvtStock.Sortie) " +
                        "  AS Solde " +
" FROM tOperation INNER JOIN " +
                        " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle " +
" WHERE(tOperation.DateOp BETWEEN CONVERT(DATETIME, '2011-01-01 00:00:00', 102) AND @db) " +
 " GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
              "  HAVING(tDepot.CodeDepot = @a)";


                string[] r = { comboCodeDepot2.Text };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDate(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou1 = classeReq.dt;
                classeReq.chargementAvecLesParametreDate(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou2 = classeReq.dt;
                string chiminRap = "Rapport/ReportSommaireStokEngros.rdlc";
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




        DataTable TableFicheDestok;

        private void tNumOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateJ.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDateJ.Text));
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            ApercuJournal();


        }
          private void ApercuJournal()
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
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateJ.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDateJ.Text));
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
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGjournal2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ApercuJournal();
        }



        private void ChargmenRapporSommireBransimnbaTous( string sPro1, string sPro2,string chiminRap)
        {
            try
            {

                
                DataTable Tmouvment, TstockAu;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                string[] r = { comboCodeDepot2.Text.Trim(), ClassVaribleGolbal.CodeDepartement };
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


        private void ChargmenRapporSommireBransimnbaStockParDepot()
        {
            try
            {


                DataTable Tmouvment;// TstockAu;

                string sPro1 = "BraStoProRapportSoldeStockAuParDepot";

                //string sPro2 = "BraStoProRapportSoldeStockAuTous";




                string[] r = { DepotMagasin };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

               // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
               // TstockAu = classeReq2.dt;

                string chiminRap = "Rapport/Bransimba/ReportStockParDepot.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }


        private void ChargmenRapporSommireBransimnbaStockParDepotSlmeent()
        {
            try
            {


                DataTable Tmouvment;// TstockAu;

                string sPro1 = "BraStoProRapportMvmntSomaireSlmt ";

                //string sPro2 = "BraStoProRapportSoldeStockAuTous";


                //comboCodeDepot2

               // string[] r = { DepotMagasin };
                string[] r = { comboCodeDepot2.Text };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                // TstockAu = classeReq2.dt;

                string chiminRap = "Rapport/Bransimba/ReportSommaireMvtSeulement.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }
        private void button14_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();


                if (cbTousLeDepot.Checked== true)
                {
                    string sPro1 = "BraStoProRapportMouvementSommaireTous";

                    string sPro2 = "BraStoProRapportSoldeStockAuTous";
                    string chiminRap = "Rapport/Bransimba/ReportSommaireStoctTouts.rdlc";
                    ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);

                }
                else
                {
                    string sPro1;
                    if (CbUniquementLeMvt.Checked == true)
                    {
                        //sPro1 = "TouchProUniqumentMouvment";
                        sPro1 = "Proc_UniqumentMouvmentStocPourUnePeriode";
                        
                    }

                    else
                    {
                        //Pro_BraStoProRapportMouvemeSommairStock
                        //sPro1 = "BraStoProRapportMouvemeSommairStock";
                        sPro1 = "Pro_BraStoProRapportMouvemeSommairStock";
                    }
                   

                    //string sPro2 = "BraStoProRapportSoldeStockAU";
                    string sPro2 = "Pro_BraStoProRapportSoldeStockAU";
                    //  Pro_BraStoProRapportSoldeStockAU
                    string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargement.rdlc";
                    ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);


                }

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


           
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
                cmd.CommandText = "JournaMouvemStoxk";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDate.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDate.Text));
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    string codecl;
                    //ConsommationDeproduits();
                    int ci = dGjournal2.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    codecl = dGjournal2["NumOperation2", ci].Value.ToString();
                    //   libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text;
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "DELETE FROM tOperation  WHERE        (NumOperation = @NumOperation)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NumOperation", codecl);

                    cmd.ExecuteNonQuery();

                    // lmessage.Text = " EST AJOUTE ";
                    MessageBox.Show(" EST SUPPRIMME");
                    //AnullerAricle();
                    con.Close();
                    cmd.Dispose();
                    // CHargement de  datagrid
                    ChargmentGgDernierChargement();
                    dGjournal2.DataSource = FicheDechargement;
                }

            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }





        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                ChargmenRapporSommeareFicheDestockParDate();
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    string codecl;
                    //ConsommationDeproduits();
                    int ci = DgJournal.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    codecl = DgJournal["NumRef", ci].Value.ToString();
                    //   libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text;
                 
                    string sint = " UPDATE       tMvtStock " +
" SET QteEntree = @a, QteSortie = @a, Entree = @a, Sortie = @a, RestournePr = @a, PR = @a, Vente = @a, PVentUN = @a, QteSortieRetour = @a, QteSortieVente = @a, QteSortieCharg = @a, QteSortieAutre = @a, " +
                       " QteSortieDegustage = @a, QteSortieCasseManquant = @a, QteEntreeRetour = @a, QteEntreeAutre = @a, QteEntreeAchat = @a, QteEntreeCharg = @a, SommeVente = @a, SommeChargement = @a " +
" WHERE(NumRef = @b)";
                    string[] r2 = { "0", codecl };
                    DateTime[] d = { DateTime.Now };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sint, r2, d);

                    MessageBox.Show(" EST SUPPRIMME");
                    // ChargmentGg10DernierOPVide();
                    // chargemnt de datagrid
                    ChargmentGgDernierChargementAchat();
                    DgJournal.DataSource = FicheDechargementAchat;
                    tSommeFact.Text = SommeFact.ToString();
                    tQteApro.Text = SommeQteAchat.ToString();
                    tSommeVente.Text = SommeVente.ToString();




                }

            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }





        }

        private void cBenGros_CheckedChanged(object sender, EventArgs e)
        {
            ChargementEngros();
        }

        private void tAgros_TextChanged(object sender, EventArgs e)
        {
            ChargementEngros();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportListeArticle";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                //cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportListeDesAricle.rdlc";
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

        private void comboCompteFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBinitiql_CheckedChanged(object sender, EventArgs e)
        {

            ChargmenComboCompte();
            ChargementCombo(CbFournisseur, comboCompteFournisseur, comboFournisseur);
        }

        private void Bajouter_Click(object sender, EventArgs e)
        {
            FormPopCategorieAticle Fp = new FormPopCategorieAticle();
           // Fp.NumOP = tNumOp2.Text;
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                // chargemeenDGFacturationSerice();
                // dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();


                TesteCate = true;
                Compteselectionne = comboCompte.Text;
                if (bwChaCategorie.IsBusy == false)
                {
                    bwChaCategorie.RunWorkerAsync();
                }
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

            }
        }

        private void comboArticleDestokageDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCodeArticleStockDes_Click(object sender, EventArgs e)
        {
            ChargementPUAchat();
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
                operationCommadeDestockage();

            }

               
            




        }


        private void operationCommadeDestockage ()
        {
            boolAchat = false;
            if (RbChargement.Checked == false && rBRetourDestock.Checked == false)
            {

                MessageBox.Show("VEILLEZ CHOISIR LE  TYPE D'OPERATION ");

            }

            else
            {

                if (comboDepot.Text.Trim() != "CD1" && tLIBELLE2.TextLength > 5)
                {
                    tNumOp2.Text = fonctionOPSotie();
                    chargemeTousLesArticle(comboCompteDestockage.Text.Trim());

                    enregOprationDestockage();

                    PasserInitialisatioStock();

                    ChargmentPoPcharemenStock();





                    pChoix.Enabled = false;
                    b.Enabled = false;
                    bNauveau.Enabled = true;


                }
                else
                {
                    MessageBox.Show("CHOISIR LE DEPOT MOBIL ou COMPLETER BIEN LE LIBELE");
                }




            }

        }
        private void ChargmentPoPcharemenStock ()
        {

            FormPop.FormPopStockChargment Fp = new FormPop.FormPopStockChargment();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDepot = comboDepot.Text.Trim();
            Fp.Compte = comboCompteDestockage.Text.Trim();
            Fp.boolCharmentStock = RbChargement.Checked;
            Fp.boolRetourDeStock = rBRetourDestock.Checked;
            Fp.DesDepot = comboDepotDes.Text;
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                ChargmentGgDernierChargement();
        dGjournal2.DataSource = FicheDechargement;
         tValeurChargement.Text = ValeurChargement.ToString();
                tEntreeQte.Text = VEntreeQte.ToString();
                tSortieQte.Text = VSortieQte.ToString();
                lMessageChargrent.Text = "CLIQUEZ SUR NOUVEAU POUR UN NOUVEU CHARGEMENT";
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

            }
        }

       
        private void ChargmentPoPcharemenStockAchat()
        {

            FormPop.FormAchaProduit Fp = new FormPop.FormAchaProduit();
           Fp.NumOP = tNumOP.Text.Trim();
            Fp.CodeDepot =DepotMagasin ;
            Fp.Compte = comboCompteStock.Text.Trim();
            Fp.CompteFournissseur = comboCompteFournisseur.Text.Trim();
            Fp.CompteVariation = tVariariotion.Text.Trim();
            Fp.CategorieArticle=comboTypeStock.Text.Trim();
            //Fp.boolCharmentStock = RbChargement.Checked;
            // Fp.boolRetourDeStock = rBRetourDestock.Checked;
            Fp.boolAchat = boolAchat;
            Fp.boolAchatBon = boolAchatBon;
            DialogResult Dial = Fp.ShowDialog();
          //  PasserLoperation = true;
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                // ChargmentGgDernierChargement();
                //DgJournal.DataSource = FicheDechargement;
                // tSommeFact.Text = SommeFact.ToString();


                // ChargmentGgDernierChargement();
                ChargmentGgDernierChargementAchat();

                DgJournal.DataSource = FicheDechargementAchat;
                tSommeFact.Text = SommeFact.ToString();
               tQteApro.Text = SommeQteAchat.ToString();
               tSommeVente.Text = SommeVente.ToString();
                //pCommande.Enabled = false;
                bValiderAchat.Enabled = true;
                lMessageStock.Text = " VALIDER L'OPERATION DE L'ACHAT ";
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";
               
                pCommande.Enabled = false;
                lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";

            }
        }



        private void ChargmentPoPcharemenStockVente()
        {

            FormPop.FormPopStockChargment Fp = new FormPop.FormPopStockChargment();
            Fp.NumOP = tNumOP.Text.Trim();
            Fp.CodeDepot = DepotMagasin;
            Fp.Compte = comboCompteStock.Text.Trim();
            Fp.CompteFournissseur = comboCompteFournisseur.Text.Trim();
            Fp.CompteVariation = tVariariotion.Text.Trim();
            Fp.CategorieArticle = comboTypeStock.Text.Trim();
            //Fp.boolCharmentStock = RbChargement.Checked;
            // Fp.boolRetourDeStock = rBRetourDestock.Checked;
           // Fp.boolAchat = boolAchat;
           // Fp.boolAchatBon = boolAchatBon;0
            Fp.boolCuisine = rbDepenseCuisine.Checked;
            Fp.boolVenteSpecial = rbVenteSpecial.Checked;
            Fp.boolAutreSotie = rbSortieAutre.Checked;

            DialogResult Dial = Fp.ShowDialog();
            //  PasserLoperation = true;
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                // ChargmentGgDernierChargement();
                //DgJournal.DataSource = FicheDechargement;
                // tSommeFact.Text = SommeFact.ToString();


                // ChargmentGgDernierChargement();
                ChargmentGgDernierChargementAchat();

                DgJournal.DataSource = FicheDechargementAchat;
                tSommeFact.Text = SommeFact.ToString();
                tQteApro.Text = SommeQteAchat.ToString();
                tSommeVente.Text = SommeVente.ToString();
                //pCommande.Enabled = false;
                bValiderAchat.Enabled = true;
                lMessageStock.Text = " VALIDER L'OPERATION DE L'ACHAT ";
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

                pCommande.Enabled = false;
                lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";

            }
        }
        private void PasserInitialisatioStock()
        {
            
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }





            String CodeAricle,Prix ;
            //PbEnrePaiemnt.Maximum = TableComteVenteService.Rows.Count - 1;
            for (int i = 0; i <= tableDesArticle.Rows.Count - 1; i++)
            {



                CodeAricle = tableDesArticle.Rows[i]["CodeArticle"].ToString();
                Prix = tableDesArticle.Rows[i]["PrixVente"].ToString();

                //InserMvtCpte2("inserertMvtChambre", tNumOp2.Text, CodeChambrINI, "0", "0", "0", "0", "4", " 0", "0", "0");
                // InserMvtCpte("insererMvtcpt", PnumOp2, tCreditte2.Text, "0", Pmotant2, "1", PcompCredit, "4", "0", "0", "0");

                if ( boolAchat == false && boolAchatBon==false)
                {
                    InserMvtCpteStockAvecQte("inserertMvtStock", CodeAricle, comboDepot.Text, "0", "0", Prix, "0", "0", "0", comboCompteDestockage.Text, "0", tNumOp2.Text);
                    InserMvtCpteStockAvecQte("inserertMvtStock", CodeAricle, DepotMagasin, "0", "0", Prix, "0", "0", "0", comboCompteDestockage.Text, "0", tNumOp2.Text);

                } 
                else  if (boolAchat == true || boolAchatBon == true)
                {

                    InserMvtCpteStockAvecQte("inserertMvtStock", CodeAricle, DepotMagasin, "0", "0", Prix, "0", "0", "0", comboCompteStock.Text, "0", tNumOP.Text);

                }

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

        private void button29_Click(object sender, EventArgs e)
        {
            ChargmentPoPcharemenStock();
        }

        private void bNauveau_Click(object sender, EventArgs e)
        {
            tNumOp2.Text = fonctionOPSotie();
            pChoix.Enabled = true;
            b.Enabled = true;
            ChargmentGgDernierChargement();
            dGjournal2.DataSource = FicheDechargement;
            lMessageChargrent.Text = "COMPLETEZ LE CHARGEMENT";
            tEntreeQte.Text = "0";
            tSortieQte.Text = "0";
            tValeurChargement.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {


            if (BoolRappelDeDate == false)
            {
                DialogResult RES = MessageBox.Show("ETES VOUS SUR DE VOILOIR PASSER   LES OPRATION A LA   ? \n DATE  ===  " + ClassVaribleGolbal.DateDuJOUR + "\n" +
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

            if (BoolRappelDeDate== true)
            {
                passerlOPERATIONCOMANE();
            }
             

           






        }
         private void passerlOPERATIONCOMANE ()
        {

            if (rBStockageAchat.Checked == false && rBStockageOffre.Checked == false && rbDepenseCuisine.Checked == false && rbVenteSpecial.Checked == false && rbSortieAutre.Checked == false)
            {

                MessageBox.Show("CHOISISSEZ  ACHAT OU BON");
            }


            else
            {
                boolAchat = rBStockageAchat.Checked;
                boolAchatBon = rBStockageOffre.Checked;
                
                if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "")
                {
                    // tNumOp2.Text = fonctionOPSotie();
                    
                    
                        //tNumOP.Text = fonctionOP();
                        //enregOprationComptable();
                    
                    
                    

                    chargemeTousLesArticle(comboCompteStock.Text.Trim());

                    // enregOprationDestockage();
                   

                   ///// PasserInitialisatioStock();

                    //ChargmentPoPcharemenStock();
                    if (rbEntreeStock.Checked == true)
                    {
                        ChargmentPoPcharemenStockAchat();
                    }

                    else if (rbSortieStock.Checked == true)
                    {
                        ChargmentPoPcharemenStockVente();
                    
                    }


                  




                    // pChoix.Enabled = false;
                    // b.Enabled = false;
                    // bNauveau.Enabled = true;


                }
                else
                {
                    MessageBox.Show("COMPLETER LE BILAN");
                }


            }


        }
        private void ChargmenRapporSommeareFicheDestock()
        {
            try
            {

                string codecl;

                int ci = DGsommaireSTOCK.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
                MessageBox.Show(codecl);
                string sCompte = "RapporFicheDestokUnproduit";
                
                string[] r = { codecl, comboCodeDepot2.Text };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDateStorage(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                TableFicheDestok = classeReq.dt;
               // classeReq.chargementAvecLesParametreDate(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                //RapportSommaireTou2 = classeReq.dt;
                string chiminRap = "Rapport/ReportFicheDestockParService.rdlc";
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

        private void button18_Click(object sender, EventArgs e)
        {
            //PasserLoperation = true;
            panel6.Enabled = true;
            tNumOP.Text = fonctionOP();
            AnullerOpComptable();
            CbSereferer.Checked = false;
            bValiderAchat.Enabled = false;
            pCommande.Enabled =false;
            lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";
        }

        private void tSommeFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();
                //ChargmenRapporSommireBransimnbaTous();
                ChargmenRapporSommireBransimnbaStockParDepot();
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();
                //ChargmenRapporSommireBransimnbaTous();
                // ChargmenRapporSommireBransimnbaStockParDepot();
                ChargmenRapporSommireBransimnbaStockParDepotSlmeent();
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }



        }

      
        private void enregitrementIDepot()
        {

           try
            {
                string s = "INSERT INTO tDepot " +
                        "  (CodeDepot, CodeCategorieDepot, DesignationDepot, Vehicule, Chauffeur, Receveur,IdService) " +
" VALUES(@a, @b, @c, @d, @e, @f,@g)";
                string sService = "INSERT INTO tService " +
                       " (IdService, DesignationService) " +
" VALUES        (@a,@b)";

                string sUpd = "UPDATE       tDepot " +
    " SET CodeDepot = @a, CodeCategorieDepot = @b, DesignationDepot = @c, Vehicule = @d, Chauffeur = @e, Receveur = @f " +
    " WHERE(CodeDepot = @a)";

                string sCompte = " INSERT INTO tCompte " +
                       "    (NumCompte, Matricule, GroupeCompte, DesignationCompte, TypeSous, Unite, CreerPar, PourcentPv) " +
                       " VALUES        (@a,@b,@c,@d,@e,@f,@g,@h) "
                       ;


                string[] rcp = { tCompteVente.Text, "1", GroupeVente, tCompteVenteDes.Text, "1", "1", utilisateur,"0" };
                string[] rcp2 = { tCompteCaisse.Text, "1", GroupeCaisse, tCompteCaisseDes.Text, "1", "1", utilisateur, "0" };

                string[] r = { tCodeDP.Text, comboCatDepot.SelectedValue.ToString(), tDesignation.Text, tVehicule.Text, tChauffeur.Text, tReceveur.Text, tNumService.Text };
                string[] r2 = { tCodeDP.Text, comboCatDepot.SelectedValue.ToString(), tDesignation.Text, tVehicule.Text, tChauffeur.Text, tReceveur.Text };

                string[] rServ = { tNumService.Text, tDesignation.Text };
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
               // MessageBox.Show(TesteModifierDepot.ToString());
                if (TesteModifierDepot == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sUpd, r2, d);
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sService, rServ, d);


                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rcp, d);
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rcp2, d);


                    enregOPaffectation(tCompteVente.Text, NumService, "72");
                    enregOPaffectation(tCompteCaisse.Text, NumService, "51");
                    InserMvtCpte("insererMvtcpt", tCompteVente.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                    InserMvtCpte("insererMvtcpt", tCompteCaisse.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);

                }
                ChargmenDgDepot();
                PasserLesInitiauxDedepot();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            

            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }
        String CodeDepotApasser;
        private void button22_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TesteModifierDepot.ToString());
            CodeDepotApasser = tCodeDP.Text;
           // tCodeDP.Text = fonctionOPdepot();
            //tNumService.Text = NumService;
            boolProcedureEneDepot = true;
           // MessageBox.Show(TesteModifierDepot.ToString());
            if  ( bwEnreNuitte.IsBusy == false)
            {
                bwEnreNuitte.RunWorkerAsync();
            }

            chargmentInitialDepot();
        }
        private void enregOPaffectation(string Compte,string Servi, string type)
        {
            string s = "INSERT INTO tPServiceStock" +
      " (NumCompte, NumDeservice, Type)VALUES        (@a,@b,@c)";
            string[] r = { Compte, Servi, type };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //AnnulerDepensePlan();()
            //  lmessage.Text = "&  DEPENSE AJOUTEE &";
            //bWchagementVehicule.RunWorkerAsync();
            //chargemeentDgPlanDepenses();




        }
        private void tDesAmodifier_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCodeDP_TextChanged(object sender, EventArgs e)
        {

            try
            {
                TesteModifierDepot = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tDepot ";
                s = s + " where CodeDepot=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tCodeDP.Text.Trim());
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {
                    tCodeDP.Text = lire["CodeDepot"].ToString();
                    comboCatDepot.SelectedValue = lire["CodeCategorieDepot"].ToString();
                    tDesignation.Text = lire["DesignationDepot"].ToString();
                    tReceveur.Text = lire["Receveur"].ToString();
                    tChauffeur.Text = lire["Chauffeur"].ToString();
                    tVehicule.Text = lire["Vehicule"].ToString();




                    TesteModifierDepot = true;
                    //MessageBox.Show(TesteModifierDepot.ToString());
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSuppDepot.Enabled = TesteModifierDepot;
                if ((TesteModifierDepot == true))
                {
                    bEnreDEpot.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreDEpot.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // lmessage.Text = ex.Message;
            }


        }

        private void ChargmenRapporSommeareFicheDestockParDate()
        {
            try
            {

                string codecl;

                int ci = DGsommaireSTOCK.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
                MessageBox.Show(codecl);
                string sCompte = "RapporFicheDestokUnproduit";

                string[] r = { codecl, comboCodeDepot2.Text };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDateStorage(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                TableFicheDestok = classeReq.dt;
               
                string chiminRap = "Rapport/ReportFicheStockParDate.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableFicheDestok, chiminRap, "DataSet1");
               
                 fo.Show();

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }
            //  da.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ci;
            ci = dgDepot.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tCodeDP.Text = dgDepot["CodeDepot", ci].Value.ToString().Trim();


        }

        private void comboDEsegnationCompte_Click(object sender, EventArgs e)
        {
            ChargmenArticledg();
            //chargementComboCompteCat(comboCatArticle, comboCatDes, comboCompte.Text);
            TesteCate = true;
            Compteselectionne = comboCompte.Text;
            if (bwChaCategorie.IsBusy == false)
            {
                bwChaCategorie.RunWorkerAsync();
            }

        }

        private string GroudeCompteselonIndicateur(int indicateur)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT  GroupeCompte FROM tGroupeCompte WHERE (Indicateur =@a) ";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", indicateur);
            //cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = cmd.ExecuteScalar().ToString();

            }
            catch
            {
                compte = "0";
            }

            return compte;


            cmd.Dispose();
            con.Close();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            chargmentInitialDepot();

        }
         private void chargmentInitialDepot()
        {
            try
            {

                GroupeVente = GroudeCompteselonIndicateur(701);
                GroupeCaisse = GroudeCompteselonIndicateur(570);

                tCompteCaisse.Text = (int.Parse(GroupeCaisse) * 1000 + int.Parse(NumService)).ToString();
                tCompteVente.Text = (int.Parse(GroupeVente) * 1000 + int.Parse(NumService)).ToString();
                formationDesCompte();

                ChargmenDgDepot();
                dgDepot.DataSource = TableDepot2;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void tNumService_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDesignation_TextChanged(object sender, EventArgs e)
        {
            formationDesCompte();
        }

        private void formationDesCompte()
        {
            tCompteVenteDes.Text = "VENTE DE  " + tDesignation.Text;
            tCompteCaisseDes.Text = "CAISSE DE  " + tDesignation.Text;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            ChargmentPoPcharemenStockAchat();
        }

        private void FormStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            SupprimerOratioNonValide();
        }

        private void RbChargement_CheckedChanged(object sender, EventArgs e)
        {
            //FormationCOmbobox();
            //FormationDElibleDestockage();
            AffichedeDestockafge();
        }
        private void FormationCOmbobox()
        {
            comboTypeOP2.Items.Clear();
            if (RbChargement.Checked == true)
            {
                comboTypeOP2.Items.Add("CHARGEMENT");
              //  comboTypeOP2.Text = "CHARGEMENT";
            }

            else if (rBRetourDestock.Checked == true)
            {
                comboTypeOP2.Items.Add("RETOUR");
                //comboTypeOP2.Text = "RETOUR";

            }
           

        }
         private void FormationDElibleDestockage()
        {

            if (RbChargement.Checked == true)
            {
                
                comboTypeOP2.Text = "CHARGEMENT";
            }

            else if (rBRetourDestock.Checked == true)
            {
               
                comboTypeOP2.Text = "RETOUR";

            }
            tLIBELLE2.Text = comboTypeOP2.Text + " " + comboDepotDes.Text;
        }

        private void rBRetourDestock_CheckedChanged(object sender, EventArgs e)
        {
           // FormationCOmbobox();
            //FormationDElibleDestockage();
            AffichedeDestockafge();
        }

        private void comboTypeOP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormationDElibleDestockage();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    string codArticle,OP;
                    //ConsommationDeproduits();
                    int ci = dGjournal2.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    codArticle = dGjournal2["CodeArticle2", ci].Value.ToString();
                    OP = dGjournal2["NumOperation2", ci].Value.ToString();
                    //NumOperation2
                    //   libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text;

                    string sint = " UPDATE       tMvtStock " +
" SET QteEntree = @a, QteSortie = @a, Entree = @a, Sortie = @a, RestournePr = @a, PR = @a, Vente = @a, PVentUN = @a, QteSortieRetour = @a, QteSortieVente = @a, QteSortieCharg = @a, QteSortieAutre = @a, " +
                       " QteSortieDegustage = @a, QteSortieCasseManquant = @a, QteEntreeRetour = @a, QteEntreeAutre = @a, QteEntreeAchat = @a, QteEntreeCharg = @a, SommeVente = @a, SommeChargement = @a " +
" WHERE(NumCompte =@b AND NumOperation =@c)";
                    string[] r2 = { "0", codArticle, OP };
                    DateTime[] d = { DateTime.Now };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sint, r2, d);

                    MessageBox.Show(" EST SUPPRIMME");
                    // ChargmentGg10DernierOPVide();
                    // chargemnt de datagrid
                    ChargmentGgDernierChargement();
                    dGjournal2.DataSource = FicheDechargement;
                    tValeurChargement.Text = ValeurChargement.ToString();
                    tEntreeQte.Text = VEntreeQte.ToString();
                    tSortieQte.Text = VSortieQte.ToString();
                    // tSommeFact.Text = SommeFact.ToString();



                }

            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void rBStockageAchat_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void button25_Click(object sender, EventArgs e)
        {

            Stock.FormOperationStock FOstock = new Stock.FormOperationStock();
            FOstock.chargmentDetailMvtCompte(tDateR1.Value, tdateR2.Value);
            FOstock.Show();






            //try
            //{
            //    string codecl;

            //    ci = DgMouvementService.CurrentRow.Index;
            //    codecl = DgPaiement[ir]["CompteClient"].ToString();
            //    codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
            //    MessageBox.Show(codecl);
            //    Connection_Data();
            //    con.Open();
            //    cmd.CommandText = "JournaMouvemStoxk";
            //    cmd.CommandTimeout = 0;

            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Clear();
            //    cmd.Parameters.AddWithValue("@NumCompte", codecl);
            //    cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
            //    cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
            //    cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tdateR2.Text));
            //    MessageBox.Show(codecl);
            //    cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
            //    da.Fill(dt);
            //    con.Close();
            //    string chiminRap = "Rapport/Report2.rdlc";
            //    FormEtat fo = new FormEtat();
            //    fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
            //    fo.Show();

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //    lmessage.Text = ex.Message;

            //}

        }

        private void AffichedeStockage ( )
        {

            boolAchat = rBStockageAchat.Checked;
            boolAchatBon = rBStockageOffre.Checked;
            ChargmenComboCompte();
            ChargementCombo(CbFournisseur, comboCompteFournisseur, comboFournisseur);
        }


        private void AffichedeDestockafge()
        {

            //boolAchat = rBStockageAchat.Checked;
            //boolAchatBon = rBStockageOffre.Checked;

            FormationCOmbobox();
            FormationDElibleDestockage();
            ChargmenComboCompte();
           // ChargementCombo(CbFournisseur, comboBox1, comboBox2);
        }
        //comboCompteVenteSpecial

        private void rBStockageOffre_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();


               
                    string sPro1 = "BraStoProRapportMouvementSommaireTous";

                    string sPro2 = "BraStoProRapportSoldeStockAuTous";
                    string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargementBonGratuit.rdlc";
                    ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);

               
               

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


        }

        private void tValeurChargement_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGsommaireSTOCK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combooDestockageDES_Click(object sender, EventArgs e)
        {

            chargementCategorieDestockage();

        }

        private void comboTypeDestockage_SelectedIndexChanged(object sender, EventArgs e)
        {
           // chargementComboDestockage();
        }

        private void comboCompteDestockage_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementCategorieDestockage();

        }
         private void  chargementCategorieDestockage( )
        {
            TesteCate = true;
            Compteselectionne3 = comboCompteDestockage.Text;

            if (bwChaCategorie.IsBusy == false)
            {
                bwChaCategorie.RunWorkerAsync();
            }

        }
        private void CbReevaluer_CheckedChanged(object sender, EventArgs e)
        {
            calculerPR();
        }

        private void comboSCatStokDes_Click(object sender, EventArgs e)
        {
            chargementCBstock();



            ////chargementComboArticle
            //TesteArtice = true;
            //TesteCate = false;
            //// Compteselectionne = comboCompteStock.Text;
            //IdypeArtece = comboTypeStock.Text;
            //compteAticleSectionne = comboCompteStock.Text.Trim();
            //if (bwChaCategorie.IsBusy == false)
            //{
            //    bwChaCategorie.RunWorkerAsync();
            //}


        }

        private void comboStockDes_Click(object sender, EventArgs e)
        {
            affectationCompteVariation();
        }

        private void comboArticleDestockage_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboArticleDestokageDes_Click(object sender, EventArgs e)
        {
            // tPuSortie.Text = fonctionPU(comboArticleDestockage.Text);
            ChargementPuSortie();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TesteDestockage = true;
            if (tLIBELLE2.TextLength > 10 && tNumOp2.Text.Trim() != ""  && comboDepot.Text.Trim()!="CD1")
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                }


            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT ou VERIFIER LA DESTINNATION " );
            }

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
            dernier = float.Parse(cmd.ExecuteScalar().ToString()) +1;
            numOperation = "RS" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
        string NumService;
        private string fonctionOPdepot()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        MAX(Id) AS DernierOp FROM    tDepot";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString()) +1;
            numOperation = "CD" + dernier.ToString() ;
            NumService = dernier.ToString();
            return numOperation;
            MessageBox.Show(NumService);

            cmd.Dispose();
            con.Close();

        }

        private string fonctionPU( String CODE)
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT       PrixAchat AS DernierOp FROM            tStock   WHERE        (CodeArticle = @CodeArticle)";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@CodeArticle", CODE);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;

            try
            {
                numOperation = (cmd.ExecuteScalar().ToString());
               // numOperation = "ME" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();

            }
             catch
            {
                numOperation = " ";
            }

            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        private string fonctionOPSotie()
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
            dernier = float.Parse(cmd.ExecuteScalar().ToString())+1;
            numOperation = "MS" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
        private void bSupprimmer_Click(object sender, EventArgs e)
        {
            annulerArtclicle();
        }


        Boolean boolProcedureEneDepot;
        private void bwEnreNuitte_DoWork(object sender, DoWorkEventArgs e)
        {
             
            if (boolProcedureEneDepot == true)
            {

                enregitrementIDepot();


            }

            else
            {


                if (test == true)
                {

                    ModificationSousArticle();
                    ChargmenArticledg();

                }

                else
                {
                    InsereSousArticle();
                    ChargmenArticledg();

                }
                PasserLesInitiauxesArticleAUdepot();

            }




            

        }
         
        private void bwEnreNuitte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (boolProcedureEneDepot==true)
            {
                dgDepot.DataSource = TableDepot2;
                annulerDept();
                tCodeDP.Text = fonctionOPdepot();
                tNumService.Text = NumService;
            }
            else
            {
                PbNuite.Visible = false;
                dGArticle.DataSource = TableAricle;
                lmessage.Text = "L'ENREGISTREMENT EFFECTUE ";
            }
            PbNuite.Visible = false;
            boolProcedureEneDepot = false;
        }

        private void bVente_Click(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in this.MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

               Stock.FormOparationVente fo = new Stock.FormOparationVente();
                //fo.MdiParent = this.MdiParent;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.CodeDepot = comboDepot.Text;
               // fo.CodeVendeur = comboCodeDeVendeur.Text;
                //fo.NomsVendeur = comboVendeurDes.Text;
                fo.ShowDialog();
            }

        }

        private void button35_Click(object sender, EventArgs e)
        {


            string codecl, desArticle;

            int ci = DGsommaireSTOCK.CurrentRow.Index;
            //codecl = DgPaiement[ir]["CompteClient"].ToString();
            codecl = DGsommaireSTOCK["CodeArticle", ci].Value.ToString();
            desArticle = DGsommaireSTOCK["DesegnationArticle", ci].Value.ToString();
            
            MessageBox.Show(codecl);
          //  string sCompte = "RapporFicheDestokUnproduit";

            string[] r = { codecl, comboCodeDepot2.Text };
            DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };

            Stock.FormFicheDeStock FOstock = new Stock.FormFicheDeStock();
            FOstock.chargmentDetailMvtCompte(codecl, comboCodeDepot2.Text,tDateR1.Value, tdateR2.Value);
            FOstock.Depot = comboDepoDES2.Text;
            FOstock.Article = desArticle;
            FOstock.Show();

        }

        private void tCherche_TextChanged(object sender, EventArgs e)
        {
            if (bWchargementINFO.IsBusy == false)
            {
                bWchargementINFO.RunWorkerAsync();
            }
        }

        // YANNICK , AJOUTER CE BOUTON POUR AFFICHER LE RAPPORT DU RELEVER DE STOCK PAR COMPTE
        private void button37_Click(object sender, EventArgs e)
        {
            FormGrandLivre FP = new FormGrandLivre("relever_stock");
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
           // FP.CodeCategorie = comboCat.Text.Trim();

            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    // chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void bwChaCategorie_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (TesteCate ==true)
            {
                chargementComboCompteCat(comboCatArticle, comboCatDes, TableCategorie);
                chargementComboCompteCat(comboTypeStock, comboSCatStokDes, TableCategorie2);
                chargementComboCompteCat(comboTypeDestockage, comboTypeDestockageDES, TableCategorie3);
                // chargementComboCompteCat(comboCatArticle, comboCatDes, comboCompte.Text);
                dGArticle.DataSource = TableAricle;
               // comboCodeArticleStock.ValueMember = "";
                //tVariariotion.Text = CompteDEservicleint(1, 2);

            }
            else if  ( TesteArtice ==true)
            {
                ChargementComboPourCodeArticle(comboCodeArticleStock, comboCodeArticleStockDes,TableComboArticle);
                ChargementComboPourCodeArticle(comboArticleDestockage, comboArticleDestokageDes, TableComboArticle2);

            }





           // tNumOP.Text = fonctionOP();
            tNumOp2.Text = fonctionOPSotie();
            TesteCate = false; TesteArtice =false;
        }

        private void comboCatArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificationSousArticle()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "ModificatonArticle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeArticle", tCodeArticle.Text);
                cmd.Parameters.AddWithValue("@DesegnationArticle", tDesignatonArticle.Text);
                cmd.Parameters.AddWithValue("@CategorieArticle", comboCatDes.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PrixVente", tPrixdeVente.Text);
                cmd.Parameters.AddWithValue("@CreeerPar", utilisateur);
                //@PrixAchat
                cmd.Parameters.AddWithValue("@PrixAchat", tPrixUsine.Text);
                cmd.Parameters.AddWithValue("@Critique", tCritique.Text);
                cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text.Trim());

                cmd.Parameters.AddWithValue("@UniteEngro", tUinteEngros.Text);
                cmd.Parameters.AddWithValue("@UiniteEnDetaille", tUnitesEnDetail.Text);
                cmd.Parameters.AddWithValue("@QteEnDet", tQteEnDetail.Text.Trim());
                cmd.Parameters.AddWithValue("@CodeArticle2", tModifier.Text);
                // @CodeArticle VARCHAR(50)= '',
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST AJOUTE");
                annulerArtclicle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void annulerArtclicle()
        {
            tCodeArticle.Text="";
            tDesignatonArticle.Text = "";
            tPrixdeVente.Text = "";
            tPrixUsine.Text = "";
            tUinteEngros.Text = "UNITES";
            tUnitesEnDetail.Text = "UNITES";
            tQteEnDetail.Text ="1";
            tModifier.Text = "";
            tDesAmodifier.Text = "";
            DrnierOP();






        }


        private void annulerDept()
        {
            tCodeDP.Text = "";
            comboCatDepot.Text = "";
            tDesignation.Text = "";
            tReceveur.Text = "";
            tChauffeur.Text = "";
            tVehicule.Text = "";
           

        }


        string DerinierArticle;
        private void DrnierOP()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "DernierArticle";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DerinierArticle = (row["MaxArticle"].ToString());
                int num = Convert.ToInt32(DerinierArticle) + 1;
                tCodeArticle.Text = "AR" + num.ToString();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }

        private void button26_Click(object sender, EventArgs e)
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
                cmd.CommandText = "JournaMouvemStoxk2";
                cmd.CommandTimeout = 0;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@CodeDepot", comboCodeDepot2.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tdateR2.Text));
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

        private void button27_Click(object sender, EventArgs e)
        {
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "")
            {

                tNumOP.Text = fonctionOP();
                enregOprationComptable();
                panel6.Enabled = false;
                pCommande.Enabled = true;
               
            
            }

            else
            {
                MessageBox.Show("COMPLETER LE BILAN");
            }
            

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            FormationCOmbobox();
            FormationDElibleDestockage();
            AffichedeDestockafge();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            affichagePanel();
        }

        private void rbEntreeStock_CheckedChanged(object sender, EventArgs e)
        {
            affichagePanel();
        }

        private void affichagePanel()
        {
          panelEntree.Visible= rbEntreeStock.Checked;
          panelSortie.Visible= rbSortieStock.Checked;
          rBStockageAchat.Checked = false;
          rBStockageOffre.Checked = false;
          rBStockageAutreAchat.Checked= false;
          rbDepenseCuisine.Checked = false;
          rbVenteSpecial.Checked = false;
          rbSortieAutre.Checked = false;
           
        
        }

        private void rbSortieStock_CheckedChanged(object sender, EventArgs e)
        {
            affichagePanel();
        }

        private void rbDepenseCuisine_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void rbVenteSpecial_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void rbSortieAutre_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tQteApro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            Fp.GroupeSpecique = false;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCompteFournisseur.Text = ClassVaribleGolbal.RefAchercher; ;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCompteFournisseur.Text = "";
                // label2.Text = "tu clicl sur cance";

            }
        }

        private void rBStockageAutreAchat_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();


                if (cbTousLeDepot.Checked == true)
                {
                    string sPro1 = "BraStoProRapportMouvementSommaireTous";

                    string sPro2 = "BraStoProRapportSoldeStockAuTous";
                    string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargementAvecPU.rdlc";
                    ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);

                }
                else
                {
                    string sPro1;
                    if (CbUniquementLeMvt.Checked == true)
                    {
                        sPro1 = "TouchProUniqumentMouvment";
                    }

                    else
                    {
                        sPro1 = "BraStoProRapportMouvemeSommairStock";
                    }


                    string sPro2 = "BraStoProRapportSoldeStockAU";
                    string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargementAvecPU.rdlc";
                    ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap);


                }

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }

        private void PasserInitialisationInventaire()
        {







            String CodeAricle, Prix;
            //PbEnrePaiemnt.Maximum = TableComteVenteService.Rows.Count - 1;
            for (int i = 0; i <= tableDesArticle.Rows.Count - 1; i++)
            {



                CodeAricle = tableDesArticle.Rows[i]["CodeArticle"].ToString();
                Prix = tableDesArticle.Rows[i]["PrixVente"].ToString();




                string s = " INSERT INTO tInventaire " +
                           "  (CodeArticle, Physique, Aretire, StockSurCamion,DateInventaire) " +
                " VALUES(@a, @b, @c, @d, @da)";

                string[] r = { CodeAricle, "0", "0", "0", };
                DateTime[] d = { DateTime.Parse(tdateInventaire.Text) };

                ClassRequette req = new ClassRequette();
                try
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                }


                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                    lmessageInventaire.Text = ex.Message;

                    // lmessage.Text = ex.Message;

                }

                //Messag
            }


            //hargemeenDGFacturationSerice();





        }
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {

                chargemeTousLesArticle(comboCompteStockInv.Text.Trim());
                PasserInitialisationInventaire();



                FormPop.FormPopMouvementIntaire Fp = new FormPop.FormPopMouvementIntaire();

                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {

                    if (BWinventaire.IsBusy == false)
                    {
                        BWinventaire.RunWorkerAsync();

                    }
                    // lMessageStock.Text = " VALIDER L'OPERATION DE L'ACHAT ";
                }

                else if (Dial == DialogResult.Cancel)
                {
                    // label2.Text = "tu clicl sur cance";

                    pCommande.Enabled = false;
                    // lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }

        private void BWinventaire_DoWork(object sender, DoWorkEventArgs e)
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
                         " tStock ON tInventaire.CodeArticle = tStock.CodeArticle " +
" WHERE        (tInventaire.DateInventaire = @da)  ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };
                DateTime[] pd = { tdateInventaire.Value };



                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, pd);


                TableInventaire = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BWinventaire_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGinventaire.DataSource = TableInventaire;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (BWinventaire.IsBusy == false)
            {
                BWinventaire.RunWorkerAsync();

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string sPro1 = "BraStopProInventairePyisique";

            // string sPro2 = "BraStopProInventairePyisique";
            string chiminRap = "Rapport/Bransimba/ReportInvemtairePhysique.rdlc";
            ChargmenRapporSommireBransimnbaTousInventaire(sPro1, chiminRap);
        }

        private void ChargmenRapporSommireBransimnbaTousInventaire(string sPro1, string chiminRap)
        {
            try
            {


                DataTable Tmouvment, TstockAu;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                string[] r = { DepotMagasin };
                DateTime[] d = { DateTime.Parse(tdateInventaire.Text), DateTime.Parse(tdateInventaire.Text) };
                ClassRequette classeReq = new ClassRequette();
                // ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                // TstockAu = classeReq2.dt;

                // string chiminRap = "Rapport/Bransimba/ReportSommaireStoctTouts.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                // fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        private void comboCompteStockInv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAfficherLesMenus_CheckedChanged(object sender, EventArgs e)
        {
            pMenuAVance.Visible = cbAfficherLesMenus.Checked;
        }

    }




}
