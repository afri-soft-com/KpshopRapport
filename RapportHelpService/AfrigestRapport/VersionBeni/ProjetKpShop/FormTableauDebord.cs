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
    public partial class FormTableauDebord : Form
    {
        public FormTableauDebord()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        private String GroupeClient, GroupeRestourne, GroupeVente, GroupCaisse, GroupeBon,GroupePersonnel;
        private void FormTableauDebord_Load(object sender, EventArgs e)
        {
            GroupeRestourne = GroudeCompteselonIndicateur(411);
            GroupeClient = GroudeCompteselonIndicateur(410);
            GroupeVente = GroudeCompteselonIndicateur(701);
            GroupCaisse = GroudeCompteselonIndicateur(570);
            GroupeBon = GroudeCompteselonIndicateur(470);
            GroupePersonnel = GroudeCompteselonIndicateur(420);
            tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
            tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
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


        private void ChargmenRapporSommireTableauDebord()
        {
            try
            {

                String sPro1, sPro2, sProVente, sCaisse,sClient;
                DataTable Tmouvment, TstockAu, Tvente, TaCaisse, TaClients,TabonGratuit,Tapersonnel ;

                sPro1 = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

                sProVente = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                    "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                    "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                    "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

                sCaisse = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                 "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                 "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                 "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

                sClient = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
               "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
               "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
               "  DesDebut, DesCredit " +
" HAVING (GroupeCompte = @a)";

               
                //comboCodeDepot2

                sPro2 = "RapportSoldeAu";
               
                string[] rRistourne = { GroupeRestourne };
                string[] rVente = { GroupeVente };
                string[] rCaisse = { GroupCaisse };
                string[] rClient = { GroupeClient };
                string[] rBonGratui = { GroupeBon };
                string[] rPersonnel = { GroupePersonnel };
                string[] r = { "" };
                // string[] r = { comboCodeDepot2.SelectedValue.ToString() };
                // string[] r = { "" };GroupCaisse
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                ClassRequette classeReqVente = new ClassRequette();
                ClassRequette classeReqCaisse = new ClassRequette();
                ClassRequette classeReqClient = new ClassRequette();
                ClassRequette classeReqBonGratuit = new ClassRequette();
                ClassRequette classeReqPersonnel = new ClassRequette();

                classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", r, d);
                TstockAu = classeReq2.dt;

                classeReq.chargementAvecLesParametreDate(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", rRistourne, d);
                Tmouvment = classeReq.dt;

                classeReqVente.chargementAvecLesParametreDate(sProVente, ClassVaribleGolbal.seteconnexion, "tVente", rVente, d);
                Tvente = classeReqVente.dt;

                classeReqCaisse.chargementAvecLesParametreDate(sCaisse, ClassVaribleGolbal.seteconnexion, "tcaise",rCaisse , d);
                TaCaisse = classeReqCaisse.dt;

                classeReqClient.chargementAvecLesParametreDate(sClient, ClassVaribleGolbal.seteconnexion, "tclient", rClient, d);
                TaClients = classeReqClient.dt;

                classeReqBonGratuit.chargementAvecLesParametreDate(sClient, ClassVaribleGolbal.seteconnexion, "tbon", rBonGratui, d);
                TabonGratuit = classeReqBonGratuit.dt;

                classeReqPersonnel.chargementAvecLesParametreDate(sClient, ClassVaribleGolbal.seteconnexion, "tPeronnel", rPersonnel, d);
                Tapersonnel = classeReqPersonnel.dt;
                
                
                string chiminRap = "Rapport/Bransimba/Bra2/ReportTableauDebord.rdlc";
                if (cbEnUsd.Checked == true)
                {
                    chiminRap = "Rapport/Bransimba/Bra2/ReportTableauDebordUsd.rdlc";
                }
                else
                {
                    chiminRap = "Rapport/Bransimba/Bra2/ReportTableauDebord.rdlc";
                }
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");

                fo.chargemenentRapporteAveVDataSetPro(Tvente, chiminRap, "DataSetVente");

                fo.chargemenentRapporteAveVDataSetPro(TaCaisse, chiminRap, "DataSetCaisse");

                fo.chargemenentRapporteAveVDataSetPro(TaClients, chiminRap, "DataSetClient");

                fo.chargemenentRapporteAveVDataSetPro(TabonGratuit, chiminRap, "DataSetBonGratuit");

                fo.chargemenentRapporteAveVDataSetPro(Tapersonnel, chiminRap, "DataSetPersonnel");
                //DataSetCaisse
                fo.Show();





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;

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
        private void button34_Click(object sender, EventArgs e)
        {
            UpdateInit(tdateR2.Text);
            ChargmenRapporSommireTableauDebord();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            
        }
    }
}
