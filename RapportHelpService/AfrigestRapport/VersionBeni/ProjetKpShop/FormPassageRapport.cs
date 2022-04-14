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
    public partial class FormPassageRapport : Form
    {
        public FormPassageRapport()
        {
            InitializeComponent();
        }

        private void FormPassageRapport_Load(object sender, EventArgs e)
        {
            tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
            tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;

            affichageDepanel();
            if ( bWchargment.IsBusy == false)
            {
                bWchargment.RunWorkerAsync();

            }
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
        public string CaisseReception = "57002";
        public string CompteCaisse = "57001";
        //57001
        public static string RefAchercher;

        public Boolean BoolBalance, BoolChargeEtProduit, BoolTierce, BoolStock, BoolEMb, BoolReleve, BoolReleveBalance,BoolCaisse;
        //
        DataTable TableCategorie;

             
        private void Connection_Data()
        { 
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }

           public Boolean SommaireCompte;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void UpdateInit(string datejour)
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
        private void chargemeentChargmentCatGorie()
        {
            try
            {


                string s = " SELECT        DesignationCatClirntEmb, CatClientEmbal FROM            tCategorieEmbalage";

                //string s2 = "SELECT        Matricule, Noms, Localite, IdClient FROM            tInformationClient ";







                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                string[] r = { "0", "0" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //classeReq2.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                TableCategorie = classeReq.dt;
                //  TableMatricule = classeReq2.dt;









                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ChargementEnUSDbalance()
        {

            string sPro1 = "BraStoRapportMouvementCompte";

            //Procedure pour le mouvmenet

            string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db)  " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING  (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

            string sPro2 = "RapportSoldeAu";
            string chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
            if (rBSynthese.Checked == true)
            {
                 chiminRap = "Rapport/Bransimba/ReportBalandeSyntheseUsd.rdlc";
                //ReportBalandeSyntheseUsd
                 if (cbBalanceMvt.Checked == true)
                 {
                    // ChargmentBalanceTous(sPro1, sPro2, chiminRap);
                     ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, "");
                 }
                 else
                 {
                     ChargmentBalanceTous(sPro1, sPro2, chiminRap);
                 }
                
            }
            else if (rbTous.Checked ==true)
            {
                chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";

                if (cbBalanceMvt.Checked == true)
                {
                   // ChargmentBalanceTous(sPro1, sPro2, chiminRap);
                    ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, "");
                }
                else
                {
                    ChargmentBalanceTous(sPro1, sPro2, chiminRap);
                }
              
            }
            else if ( rbPaGroupe .Checked ==  true)
            {
                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING(Cadre = @a)";


                // pour le mpuvment uniquement

                sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING(Cadre = @a) AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

                chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";

                if (cbBalanceMvt.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                
            }


            else if (rbSousGroupe.Checked == true)
            {
                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

                sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)   AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

                chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";




                if (cbBalanceMvt.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, comboDesignatioGroupe.SelectedValue.ToString());
            
                }
                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboDesignatioGroupe.SelectedValue.ToString());
            
                }
                
              
            
            
            
            }


            else if (rbReleveBalance.Checked == true)
            {
                
                //chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
               // ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboDesignatioGroupe.SelectedValue.ToString());
                try
                {
                    string codecl;
                    //int ci;
                   // ci = dGsoldeDeSrivice.CurrentRow.Index;
                    //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                   // codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                    codecl = comboCompte2.Text.Trim();
                    //MessageBox.Show(codecl);
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "BraSroProRapportRelever";


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
                    string chiminRap2 = "Rapport/Bransimba/ReportReleverUsd.rdlc";
                    FormEtat fo = new FormEtat();
                    fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap2, "DataSet1");
                    fo.Show();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    // lmessage.Text = ex.Message;

                }

            
            }
            
        }



        private void ChargementCdfTfr()
        {
            UpdateInit(tdateR2.Text);

            string sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                         "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                         "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
 " FROM BraViewMouvementComptePeriode " +
 " WHERE(DateOp BETWEEN @da AND @db) " +
 " GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                         "  DesDebut, DesCredit " +
 " HAVING (NumClasse = 7) or  (NumClasse = 6) ";

            string sPro1Mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                         "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                         "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
 " FROM BraViewMouvementComptePeriode " +
 " WHERE(DateOp BETWEEN @da AND @db) " +
 " GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                         "  DesDebut, DesCredit " +
 " HAVING ((NumClasse = 7) or  (NumClasse = 6)) AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

            string sPro2 = "RapportSoldeAu";
            string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
          //  string chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
            if (rbSyntheseResultq.Checked == true)
            {
              
                if (  cbUsdResultat.Checked == true)
                {
                    chiminRap = "Rapport/Bransimba/ReportBalandeSyntheseUsd.rdlc";
                    //chiminRap = "Rapport/ReportBalanceSynthes.rdlc";
                }
                else
                {
                    chiminRap = "Rapport/ReportBalanceSynthes.rdlc";

                }

                if (cbDepenseProfiMvt.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1Mvt, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                
            }
            else if (rbTousCharge.Checked == true)
            {
                
                if ( cbUsdResultat .Checked == true)
                {
                    // chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                    chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
                    //chiminRap = "Rapport/Bransimba/ReportBalandeSyntheseUsd.rdlc";
                }
                else
                {
                    chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                }


                if (cbDepenseProfiMvt.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1Mvt, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }

                
            }
            else if (rbPaGroupe.Checked == true)
            {
                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING(Cadre = @a)";

                chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
                ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
            }

        }


        private void ChargementTiers()
        {


            UpdateInit(tdateR2.Text);
            string sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                         "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                         "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
 " FROM BraViewMouvementComptePeriode " +
 " WHERE(DateOp BETWEEN @da AND @db) " +
 " GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                         "  DesDebut, DesCredit " +
 " HAVING (NumClasse = 4)  ";

            string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db)  " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING (NumClasse = 4) and (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

            string sPro2 = "RapportSoldeAu";
            string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
            //  string chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
            if (rbSyntheseTerce.Checked == true)
            {

                if (cbTiers.Checked == true)
                {
                    chiminRap = "Rapport/Bransimba/ReportBalandeSyntheseUsd.rdlc";
                    //chiminRap = "Rapport/ReportBalanceSynthes.rdlc";
                }
                else
                {
                    chiminRap = "Rapport/ReportBalanceSynthes.rdlc";

                }

                if (rbMouvmentTierce.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, comboCadre.SelectedValue.ToString());

                }

                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
            
                }
               
            
            }
            else if (rbTousTierce.Checked == true)
            {

                if (cbTiers.Checked == true)
                {
                    // chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                    chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
                    //chiminRap = "Rapport/Bransimba/ReportBalandeSyntheseUsd.rdlc";
                }
                else
                {
                    chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                }



                if (rbMouvmentTierce.Checked == true)
                {
                    ChargmentBalanceTousEnDetaille(sPro1mvt, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }

                else
                {
                    ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
                }
                
            }
            else if (rbPaGroupe.Checked == true)
            {
                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                        "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                        "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                        "  DesDebut, DesCredit " +
" HAVING(Cadre = @a)";

                chiminRap = "Rapport/Bransimba/ReportBalandeDetailleUsd.rdlc";
                ChargmentBalanceTousEnDetaille(sPro1, sPro2, chiminRap, comboCadre.SelectedValue.ToString());
            }

        }




        private void ChargmentStock()
        {
            UpdateInit(tdateR2.Text);

            if (rbTousleStocks.Checked == true)
            {

               // UpdateInit(tdateR2.Text);
                string sPro1 = "BraStoProRapportMouvementSommaireTous";

                string sPro2 = "BraStoProRapportSoldeStockAuTous";
                string chiminRap = "Rapport/Bransimba/ReportSommaireStoctTouts.rdlc";
                ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap, comboCodeDepot2.SelectedValue.ToString());
            }

            else if ( rbParSrd.Checked == true)
            {
                string sPro1 = "BraStoProRapportMouvemeSommairStock";

                string sPro2 = "BraStoProRapportSoldeStockAU";
                string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargement.rdlc";
                ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap, comboCodeDepot2.SelectedValue.ToString());

                //ChargmenRapporAvecUnseulPro
            }
            else if (RbVnteEtVersment.Checked == true)
            {
                string sPro1 = "BraStoProReleveDeVenteCashEtCreditTous";
              //  string sPro1 = "BraStoProReleveDeVenteCashEtCreditTousSanDate";
                //BraStoProReleveDeVenteCashEtCreditTousSanDate
                string sPro2 = "BraStoProReleveDeVirmentSynthese";
                string chiminRap = "Rapport/Bransimba/Bra2/ReportLeVenteCashEtCrediEtVersment.rdlc";
                ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap,ClassVaribleGolbal.CaisseReception);

                //ChargmenRapporAvecUnseulPro
            }

            else if (RbVenteGen.Checked == true)
            {
                string sPro1 = "BraStoProReleveDeVenteCashEtCreditTous";

                //string sPro2 = "BraStoProRapportSoldeStockAU";
                string chiminRap = "Rapport/Bransimba/ReportLeVenteCashEtCredit.rdlc";
                ChargmenRapporAvecUnseulPro(sPro1, chiminRap);

                //ChargmenRapporAvecUnseulPro
            }

            else if (RbVenteParSrd.Checked == true)
            {
                string sPro1 = "BraStoProReleveDeVenteCashEtCredit";

                //string sPro2 = "BraStoProRapportSoldeStockAU";
                string chiminRap = "Rapport/Bransimba/ReportLeVenteCashEtCredit.rdlc";
                ChargmenRapporAvecUnseulPro(sPro1, chiminRap);

                //ChargmenRapporAvecUnseulPro
            }


            else if (RbVenteGenSynthese.Checked == true)
            {
                string sPro1 = "BraStoProReleveDeVenteCashEtCreditTous";

                //string sPro2 = "BraStoProRapportSoldeStockAU";
                string chiminRap = "Rapport/Bransimba/ReportLeVenteCashEtCredit2.rdlc";
                ChargmenRapporAvecUnseulPro(sPro1, chiminRap);

                //ChargmenRapporAvecUnseulPro
            }
            else if ( rbBonGratuits .Checked == true)
            {

                UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();



                string sPro1 = "BraStoProRapportMouvementSommaireTous";

                string sPro2 = "BraStoProRapportSoldeStockAuTous";
                string chiminRap = "Rapport/Bransimba/ReportSommaireStockChargementBonGratuit.rdlc";
                ChargmenRapporSommireBransimnbaTous(sPro1, sPro2, chiminRap, comboCodeDepot2.SelectedValue.ToString());

            }


            else if (rbInventaire.Checked == true)
            {

               // UpdateInit(tdateR2.Text);
                //ChargmenRapporSommeareEngros();



                string sPro1 = "BraStopProInventairePyisique";

                //string sPro2 = "BraStoProRapportSoldeStockAuTous";
                string chiminRap = "Rapport/Bransimba/ReportInvemtairePhysique.rdlc";
                ChargmenRapporAvecUnseulPro(sPro1, chiminRap);

            }

        }




        private void ChargmentEmballage()
        {

            string codecl=" ", codecl2 = "";
            UpdateInit(tdateR2.Text);

            if (rbEmbSomGL.Checked == true)
            {
                 codecl ="" ;
                // UpdateInit(tdateR2.Text);
                string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTousSynthese.rdlc";
                string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockTous";
                string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", tDateR1.Text, tdateR2.Text);

            }

            else if (rbEmbSomParCat.Checked == true)
            {
                codecl2 = comboBoxCategorie2.SelectedValue.ToString();
                string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTous.rdlc";
                string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockParCatTOUS";
                string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, codecl2, tDateR1.Text, tdateR2.Text);


            }

            else if (rbEmbLesStockAU.Checked == true)
            {

                UpdateInit(tdateR2.Text);
                string chiminRap = "Rapport/Bransimba/ReportEmbalageSyntheseCroise.rdlc";
                //BraStoProRappotrEmbalageParClParEmbParCatSansZero
                string sPro1 = "BraStoProRappotrEmbalageParClParEmbParCat";
                if (cbSansSoldeNul.Checked == true)
                {
                    sPro1 = "BraStoProRappotrEmbalageParClParEmbParCatSansZero";
                }

                else
                {
                    sPro1 = "BraStoProRappotrEmbalageParClParEmbParCat";

                }


                ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

            }

        }


        private void ChargmenRapporVenteDeclientParProdiut(string chiminRap, string sPro1)
        {
            try
            {


                string codecl;
                int ci;
               // ci = DgEmbalageEnCirculation.CurrentRow.Index;

               // codecl = DgEmbalageEnCirculation["CodeArticle", ci].Value.ToString();
                codecl = "";

                DataTable Tmouvment;// TstockAu;



                string[] r = { codecl, comboBoxCategorie2.SelectedValue.ToString() };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                // TstockAu = classeReq2.dt;

                // string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }


        private void ChargmenRapporVenteDeclientSommaireAvecDeux(string chiminRap, string sPro1, string sPro2, string codecl, string codecl2, string Date1, string Date2)
        {
            try
            {




                DataTable Tmouvment;// TstockAu;
                DataTable TstockAu;
                // sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro2 = "BraStoProRapportSoldeStockAuTous";




                string[] r = { codecl, codecl2 };
                DateTime[] d = { DateTime.Parse(Date1), DateTime.Parse(Date2) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                TstockAu = classeReq2.dt;

                // string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }



        private void ChargmenRapporVenteRapportAVECun(string chiminRap, string sPro1, string codecl, string codecl2, string Date1, string Date2)
        {
            try
            {




                DataTable Tmouvment;// TstockAu;
                DataTable TstockAu;
                // sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro2 = "BraStoProRapportSoldeStockAuTous";




                string[] r = { codecl, codecl2 };
                DateTime[] d = { DateTime.Parse(Date1), DateTime.Parse(Date2) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

               // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                //TstockAu = classeReq2.dt;

                // string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
               // fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        private void ChargmenRapporSommireBransimnbaTous(string sPro1, string sPro2, string chiminRap,string Parametre)
        {
            try
            {


                DataTable Tmouvment, TstockAu;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
               // string[] r = { comboCodeDepot2.SelectedValue.ToString() };
                string[] r = { Parametre };
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

                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }


        private void ChargmenRapporSommireTableauDebord()
        {
            try
            {

                String sPro1, sPro2;
                DataTable Tmouvment, TstockAu;

                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

                sPro2 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)   AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                // string[] r = { comboCodeDepot2.SelectedValue.ToString() };
                string[] r = { "" };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                TstockAu = classeReq2.dt;

                string chiminRap = "Rapport/Bransimba/ReportSommaireStoctTouts.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }

        private void ChargmenRapporAvecUnseulPro(string sPro1, string chiminRap)
        {
            try
            {


                DataTable Tmouvment;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                string[] r = { comboCodeDepot2.SelectedValue.ToString() };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
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

                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }
        private void ChargmentBalanceTous(string sPro1, string sPro2, string chiminRap)
        {
            try
            {


                DataTable Tmouvment, TstockAu;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                string[] r = { " " };
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

               MessageBox.Show( ex.Message);

            }


            //  da.Dispose();
        }


        private void ChargmentBalanceTousEnDetaille(string sPro1, string sPro2, string chiminRap,string CODE)
        {
            try
            {


                DataTable Tmouvment, TstockAu;

                // string sPro1 = "BraStoProRapportMouvementSommaireTous";

                // string sPro2 = "BraStoProRapportSoldeStockAuTous";



                //comboCodeDepot2
                // string[] r = { DepotMagasin };
                string[] r = { CODE };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
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

                MessageBox.Show(ex.Message);

            }


            //  da.Dispose();
        }

        private void affichageDepanel()
        {
            PanelChargeEtDepenses.Visible = BoolChargeEtProduit;
            panelBalance.Visible = BoolBalance;
            panelTierse.Visible = BoolTierce;
            panelStock.Visible = BoolStock;
            pEmballage.Visible = BoolEMb;
            paneLRelever.Visible = BoolReleve;
            CbCdfCaisse.Visible = BoolCaisse;
           


        }
        private void button15_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                 if (BoolBalance== true)
                {
                    chargmentBalance();
                }
                 else if ( BoolChargeEtProduit == true)
                {
                    ChargementCdfTfr(); 

                }
                 else if (BoolTierce== true)
                {
                    ChargementTiers();
                }

                else if (BoolStock == true)
                {
                    ChargmentStock();
                }

                 else if (BoolEMb == true)
                 {
                     ChargmentEmballage();
                 }

                 else if (BoolCaisse == true)
                 {
                     caisseChargment();
                // ChargmenRapporVenteRapportAVECun
                 
                 }

                //BoolStock




            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


            
        }


        private void caisseChargment()
        {


            //  string codecl =" ";
             // string chiminRap = "Rapport/Bransimba/ReportReleveCaisseUsd.rdlc";
            //string sPro1 = "BraSroProRapportReleverCaisse";
           // string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
           // ChargmenRapporVenteRapportAVECun(chiminRap, sPro1, codecl,codecl, tDateR1.Text, tdateR2.Text);
            try
            {
            string codecl;
                          //  int ci;
                           // ci = dGsoldeDeSrivice.CurrentRow.Index;
                            //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                              codecl = CompteCaisse;
                            //MessageBox.Show(codecl);
                            Connection_Data();
                            con.Open();
                            if (CbCdfCaisse.Checked == true)
                            {
                                cmd.CommandText = "BraSroProRapportReleverCaisseCdf";
                            }
                            else
                            {
                                cmd.CommandText = "BraSroProRapportReleverCaisse";
                            }
                            


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


                            string chiminRap = "Rapport/Bransimba/ReportReleveCaisseUsd.rdlc";


                            if (CbCdfCaisse.Checked == true)
                            {
                                //cmd.CommandText = "BraSroProRapportReleverCaisse";
                                chiminRap = "Rapport/Bransimba/ReportReleveCaisse.rdlc";
                            }
                            else
                            {
                                //cmd.CommandText = "BraSroProRapportReleverCaisse";
                                chiminRap = "Rapport/Bransimba/ReportReleveCaisseUsd.rdlc";
                            }
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
        private void chargmentBalance()
        {


            if (cbEnUsd.Checked == true)
            {
                UpdateInit(tdateR2.Text);
                ChargementEnUSDbalance();

            }

            else
            {
                if (SommaireCompte == true)
                {
                    if (rbTous.Checked == true)
                    {
                        UpdateInit(tdateR2.Text);

                        ChargementDecompteSommqireTous();
                    }
                    else if (rbPaGroupe.Checked == true)
                    {
                        UpdateInit(tdateR2.Text);
                        //ChargementDecompteSommqireTous();
                        ChargementDecompteSommqireParGroupe();

                    }

                    else if (rbSousGroupe.Checked == true)
                    {
                        UpdateInit(tdateR2.Text);
                        //ChargementDecompteSommqireTous();
                        ChargementDecompteSommqireSousGroupe();

                    }

                    else if (rbReleveBalance.Checked == true)
                    {
                        UpdateInit(tdateR2.Text);
                        //ChargementDecompteSommqireTous();

                        try
                        {
                            string codecl;
                          //  int ci;
                           // ci = dGsoldeDeSrivice.CurrentRow.Index;
                            //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                            codecl = comboCompte2.Text.Trim();
                            //MessageBox.Show(codecl);
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
                            fo.Show();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                            // lmessage.Text = ex.Message;

                        }

                    }


                    else if (rBSynthese.Checked == true)
                    {
                        UpdateInit(tdateR2.Text);
                        ChargementDecompteSommqireTous();

                    }


                }


            }

        }

        DataTable TableCadre,TableGroupe;
        private void chargemeentChargment()
        {
            try
            {


                string sCadre = " SELECT        tCadre.Cadre, tCadre.DesignationCadre" +
" FROM tCadre INNER JOIN " +
                         " tGroupeCompte ON tCadre.Cadre = tGroupeCompte.Cadre INNER JOIN " +
                         " tCompte ON tGroupeCompte.GroupeCompte = tCompte.GroupeCompte " +
" GROUP BY tCadre.Cadre,tCadre.DesignationCadre ORDER BY tCadre.Cadre ";
                //tCadre.DesignationCadre



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();
               // ClassRequette classeReq2 = new ClassRequette();
               // ClassRequette classeReq3 = new ClassRequette();
                //ClassRequette classeReq4 = new ClassRequette();

                string[] r = { "0", "0" };


                classeReq.chargementAvecLesParametre(sCadre, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                //classeReq2.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tclienEMB", r);
                //  classeReq3.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm2", r);
                //  classeReq4.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm3", r);




                TableCadre = classeReq.dt;


                // TableComboDest = classeReq2.dt;
                //TableCompoPro = classeReq3.dt;
                //tableComboVerification = classeReq4.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void ChargmentGroupe(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectionGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cadre", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    TableGroupe = dt;
                    comboDesignatioGroupe.DataSource = TableGroupe;
                  //  comboGroupe.DataSource = TableGroupe;
                    comboDesignatioGroupe.DisplayMember = "DesignationGroupe";
                  //  comboGroupe.ValueMember = "GroupeCompte";

                   /// comboGroupe.DisplayMember = "GroupeCompte";
                    comboDesignatioGroupe.ValueMember = "GroupeCompte";

                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void ChargmentGroupe2(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectionGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cadre", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    TableGroupe = dt;
                    comboGroupe1.DataSource = TableGroupe;
                    comboGroupe1Des.DataSource = TableGroupe;
                    comboGroupe1Des.DisplayMember = "DesignationGroupe";
                    comboGroupe1Des.ValueMember = "DesignationGroupe";

                    comboGroupe1.DisplayMember = "GroupeCompte";
                    comboGroupe1.ValueMember = "GroupeCompte";

                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void ChargmentGroupe3(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectSousGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GroupeCompte", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    TableGroupe = dt;
                    comboCompte1.DataSource = TableGroupe;
                    comboCompte1Des.DataSource = TableGroupe;
                    comboCompte1Des.DisplayMember = "DesignationCompte";
                    comboCompte1Des.ValueMember = "NumCompte";

                    comboCompte1.DisplayMember = "NumCompte";
                    comboCompte1.ValueMember = "NumCompte";

                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }

        private void ChargmentGroupe4(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectSousGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GroupeCompte", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    TableGroupe = dt;
                    comboCompte2.DataSource = TableGroupe;
                    comboCompte2Des.DataSource = TableGroupe;
                    comboCompte2Des.DisplayMember = "DesignationCompte";
                    comboCompte2Des.ValueMember = "NumCompte";

                    comboCompte2.DisplayMember = "NumCompte";
                    comboCompte2.ValueMember = "NumCompte";

                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }
        private void AfficherCom()
        {
            if (rbPaGroupe.Checked == true)
            {
                comboCadre.Enabled = true;
                comboDesignatioGroupe.Enabled = false;
                comboCompte2.Visible = false;
                comboCompte2Des.Visible = false;
                bRecherche.Visible = false;


            }
            else if (rbSousGroupe.Checked == true)
            {
                comboCadre.Enabled = true;
                comboDesignatioGroupe.Enabled = true;
                comboCompte2.Visible = false;
                comboCompte2Des.Visible = false;
                bRecherche.Visible = false;
            }


            else if (rbReleveBalance.Checked == true)
            {
                comboCadre.Enabled = true;
                comboDesignatioGroupe.Enabled = true;
                comboCompte2.Visible = true;
                comboCompte2Des.Visible = true;
                bRecherche.Visible = true;
            }
            //rbReleveBalance
            else
            {
                comboCadre.Enabled = false;
                comboDesignatioGroupe.Enabled = false;
                comboCompte2.Visible = false;
                comboCompte2Des.Visible = false;
                bRecherche.Visible = false;

            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AfficherCom();

        }

        private void  ChargementDecompteSommqireTous ()
        {
            try
            {

                string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @DateOp AND @DateOp2)  " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING  (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";



                CharrrmentRapporSommairSerice();
                Connection_Data();
                con.Open();
              //  if ()
                if (cbBalanceMvt.Checked == true)
                {
                    cmd.CommandText = sPro1mvt;
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                }
                else
                {
                    cmd.CommandText = "RapportMouvementCompte";
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                
                }
                
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                //ReportBalanceSynthes
                string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                if (rBSynthese.Checked == true)
                {
                     chiminRap = "Rapport/ReportBalanceSynthes.rdlc";
                }
                else
                {

                     chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                }
               
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableRapporSommair, chiminRap, "DataSet2");
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();
                //ReportBalanceSynthes
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }


        private void ChargementDecompteSommqireParGroupe()
        {
            try
            {

                string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                      "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                      "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @DateOp AND @DateOp2) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                      "  DesDebut, DesCredit " +
" HAVING(Cadre = @a) AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

                string s = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie, SUM(tMvtCompte.QteEntree) AS QteEntree, SUM(tMvtCompte.QteSortie) " +
                         "AS QteSortie, MAX(tOperation.DateOp) AS MaxDateMVT, tGroupeCompte.DesignationGroupe, tGroupeCompte.DesDebut, tGroupeCompte.DesCredit, tCadre.Cadre, tCadre.DesignationCadre, tClasse.NumClasse, " +
                        " tClasse.DesignationClasse, tEntrepise.IdEntreprise, tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tCadre.RefCadre, " +
                         "MIN(tOperation.DateOp) AS MinDateOP, tGroupeCompte.GroupeCompte " +
" FROM            tCompte INNER JOIN " +
                       "  tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                        " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre INNER JOIN " +
                        " tClasse ON tCadre.Classe = tClasse.NumClasse CROSS JOIN " +
                         "tEntrepise " +
 " WHERE(tOperation.DateOp BETWEEN @DateOp AND @DateOp2) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tGroupeCompte.GroupeCompte, tGroupeCompte.DesignationGroupe, tGroupeCompte.DesDebut, tGroupeCompte.DesCredit, tCadre.Cadre,  " +
                        "  tCadre.DesignationCadre, tClasse.NumClasse, tClasse.DesignationClasse, tEntrepise.IdEntreprise, tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, " +
                         " tEntrepise.Site, tCadre.RefCadre " +
" HAVING(tCadre.Cadre = @a)";


                CharrrmentRapporSommairSerice();
                Connection_Data();
                con.Open();
                //cmd.CommandText = "RapportMouvementCompte";
                if (cbBalanceMvt.Checked == true)
                {
                    cmd.CommandText = sPro1mvt;
                }
                else
                {
                    cmd.CommandText = s;
                }
               

                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                 cmd.Parameters.AddWithValue("@a", comboCadre.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableRapporSommair, chiminRap, "DataSet2");
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }



        private void ChargementDecompteSommqireSousGroupe()
        {
            try
            {

                string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                     "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                     "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @DateOp AND @DateOp2) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                     "  DesDebut, DesCredit " +
" HAVING (GroupeCompte=@a) AND (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";

                string s = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie, SUM(tMvtCompte.QteEntree) AS QteEntree, SUM(tMvtCompte.QteSortie) " +
                         "AS QteSortie, MAX(tOperation.DateOp) AS MaxDateMVT, tGroupeCompte.DesignationGroupe, tGroupeCompte.DesDebut, tGroupeCompte.DesCredit, tCadre.Cadre, tCadre.DesignationCadre, tClasse.NumClasse, " +
                        " tClasse.DesignationClasse, tEntrepise.IdEntreprise, tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tCadre.RefCadre, " +
                         "MIN(tOperation.DateOp) AS MinDateOP, tGroupeCompte.GroupeCompte " +
" FROM            tCompte INNER JOIN " +
                       "  tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                        " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre INNER JOIN " +
                        " tClasse ON tCadre.Classe = tClasse.NumClasse CROSS JOIN " +
                         "tEntrepise " +
 " WHERE(tOperation.DateOp BETWEEN @DateOp AND @DateOp2) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tGroupeCompte.GroupeCompte, tGroupeCompte.DesignationGroupe, tGroupeCompte.DesDebut, tGroupeCompte.DesCredit, tCadre.Cadre,  " +
                        "  tCadre.DesignationCadre, tClasse.NumClasse, tClasse.DesignationClasse, tEntrepise.IdEntreprise, tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, " +
                         " tEntrepise.Site, tCadre.RefCadre " +
" HAVING(tGroupeCompte.GroupeCompte = @a)";


                CharrrmentRapporSommairSerice();
                Connection_Data();
                con.Open();
                //cmd.CommandText = "RapportMouvementCompte";

                //cmd.CommandText = s;


                if (cbBalanceMvt.Checked == true)
                {
                    cmd.CommandText = sPro1mvt;
                }
                else
                {
                    cmd.CommandText = s;
                }
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@a", comboDesignatioGroupe.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableRapporSommair, chiminRap, "DataSet2");
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }
        DataTable TableRapporSommair;

        private void tdateR2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tDateR1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try

            {
              //  UpdateInit(tdate2.Text);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportChargementVenteService";


                //             

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@IdCatogieSerive", 4);
                // cmd.Parameters.AddWithValue("@TypeSous2", 4);
//cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
//cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdate2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportServicePourunePeriode.rdlc";
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

        private void bWchargment_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
            ChargmentDepot();
            chargemeentChargmentCatGorie();
        }
        DataTable tableDepot;
        private void bWchargment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboCadre.DataSource = TableCadre;
            comboCadre.ValueMember = "Cadre";
            comboCadre.DisplayMember = "DesignationCadre";
            comboCadre1.DataSource = TableCadre;
            comboCadre1.ValueMember = "Cadre";
            comboCadre1.DisplayMember = "Cadre";
            comboCadreDes.DataSource = TableCadre;
            comboCadreDes.ValueMember = "Cadre";
            comboCadreDes.DisplayMember = "DesignationCadre";
           
            ChargementComboDepot(tableDepot, comboCodeDepot2, comboCodeDepot2);

            comboBoxCategorie2.DataSource = TableCategorie;
            comboBoxCategorie2.DisplayMember = "DesignationCatClirntEmb";
            comboBoxCategorie2.ValueMember = "CatClientEmbal";
        }


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

             //   lmessage.Text = ex.Message;

            }

            //  da.Dispose();
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

        private void rbSousGroupe_CheckedChanged(object sender, EventArgs e)
        {
            AfficherCom();
        }

        private void rbParSrd_CheckedChanged(object sender, EventArgs e)
        {
            //comboCodeDepot2.Enabled = rbParSrd.Checked;


            if (RbVenteParSrd.Checked == true || rbParSrd.Checked == true)
            {

                comboCodeDepot2.Enabled = true;
            }

            else
            {
                comboCodeDepot2.Enabled = false;


            }
        }

        private void rbTous_CheckedChanged(object sender, EventArgs e)
        {
            AfficherCom();
        }

        private void rBSynthese_CheckedChanged(object sender, EventArgs e)
        {
            AfficherCom();
        }

        private void comboDesignatioGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChargmentGroupe4(comboDesignatioGroupe.SelectedValue.ToString());
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }


        }

        private void comboCadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChargmentGroupe(comboCadre.SelectedValue.ToString());
            }

           

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }

        private void CharrrmentRapporSommairSerice()
        {
            try
            {
               
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportSoldeAu";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                TableRapporSommair = dt;

                //string chiminRap = "Rapport/ReportReleveCompte.rdlc";
                //FormEtat fo = new FormEtat();
                //fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                //fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }

        private void RbVenteParSrd_CheckedChanged(object sender, EventArgs e)
        {
            if (RbVenteParSrd.Checked == true || rbParSrd.Checked == true)
            {

                comboCodeDepot2.Enabled = true;
            }

            else
            {
                comboCodeDepot2.Enabled = false;
            
            
            }
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboCadre1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ChargmentGroupe2(comboCadre1.SelectedValue.ToString());
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }

        private void comboGroupe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChargmentGroupe3(comboGroupe1.SelectedValue.ToString());
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            AfficherCom();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            Fp.GroupeSpecique = true;
            Fp.GroupeCompteAchere = comboDesignatioGroupe.SelectedValue.ToString();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                
                comboCompte2.Text =RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCompte2.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }
    }
}
