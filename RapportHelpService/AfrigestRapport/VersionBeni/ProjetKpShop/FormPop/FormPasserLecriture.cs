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
    public partial class FormPasserLecriture : Form
    {
        public FormPasserLecriture()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP,Matricule;
        Boolean test, test2, boolChaegmentClient, TestDgVerificatio;
        Double Taux;
        public static string RefAchercher;
        private double SSVente, SSommeVente, SQteSortieVente, PourcentPv, SSoldeCompte ,ValeurRestourne;
        public DateTime date1, date2;

        private void bWchargmentClient_DoWork(object sender, DoWorkEventArgs e)
        {
            if (boolChaegmentClient == true)
            {
                chargemeentClient();
            }
        }

        private void bWchargmentClient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (boolChaegmentClient == true)
            {

                comboMatriculeClients.DataSource = TableMatricule;
                comboMatriculeClients.DisplayMember = "Matricule";
                comboMatriculeClients.ValueMember = "Matricule";

                comboNomsCilents.DataSource = TableMatricule;
                comboNomsCilents.DisplayMember = "Noms";
                comboNomsCilents.ValueMember = "Matricule";

                comboMatriculeClients.Text = Matricule;
                comboEmballage.DataSource = TableEmballage;
                comboEmballage.DisplayMember = "DesignationCompte";
                comboEmballage.ValueMember = "NumCompte";

                comboOp.DataSource = TableOperation;
                comboOp.DisplayMember = "NumOperation";
                comboOp.ValueMember = "NumOperation";

            }

            tNumOP.Text = fonctionOP();
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
            numOperation = "CO" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        private Double fonctionVerifierMouvement(string compte)
        {

           // string numOperation;
            Double dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde "  +
 " FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
" HAVING(tCompte.NumCompte =@a)";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@a", compte);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString());
           // numOperation = "CO" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return dernier;


            cmd.Dispose();
            con.Close();

        }


        private void bWoperationDivers_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TestDgVerificatio == true)
            {
               // UpdateInit(tdateR2.Text);
                chargementDgVerfication();

            }
        }
        DataTable TableCompteCredit, TableCompteDebit, TableEmballage;

        private void bWoperationDivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboCredit.DataSource = TableCompteCredit;
            comboCrediDES.DataSource = TableCompteCredit; ;
            comboCredit.DisplayMember = "NumCompte";
            comboCredit.ValueMember = "NumCompte";
            comboCrediDES.ValueMember = "NumCompte";
            comboCrediDES.DisplayMember = "DesignationCompte";


            comboDebit.DataSource = TableCompteDebit;
            comboDebitDes.DataSource = TableCompteDebit; ;
            comboDebit.DisplayMember = "NumCompte";
            comboDebit.ValueMember = "NumCompte";
            comboDebitDes.ValueMember = "NumCompte";
            comboDebitDes.DisplayMember = "DesignationCompte";

            comboEmballage.DataSource = TableEmballage;
            comboEmballage.DisplayMember = "DesignationCompte";
            comboEmballage.ValueMember = "NumCompte";
        }
        private void enregOprationComptable()
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,TauxDuJour, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g, @da)";

                string[] r = { tNumOP.Text, tLibelle.Text, utilisateur, "0", "0", " ",Taux.ToString() };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };

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

        private void EnregistrmentLibeleFacture()
        {

            try
            {

                string s = "INSERT INTO tLibelleRistourne " +
                       "   ( NumOperation, QteRest, Vente, PaimentDette, RetEmballage, AchatProduit, AncienReg,ValeurRestourne,Matricule, tDate1, tDate2) " +
" VALUES        (@a,@b,@c,@d,@e,@f,@g,@h,@i,@da,@db)";

                string[] r = { tNumOP.Text, tQteVendue.Text, tValeurAchat.Text, tRetenueProduit.Text, tmotant.Text, tmontantEmb.Text, tDiff.Text, tRistourne.Text,comboMatriculeClients.Text};
                DateTime[] d = { date1 ,date2 };

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
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {

                if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "" && (verifierNumbe.IsNumeric(tmotant.Text) == true))
                {
                    Double montanApasserRist,montanApasserAucredi ;
                   // MotantRestourne = fonctionVerifierMouvement(comboDebit.Text.Trim());
                    montanApasserRist = Double.Parse(tmotant.Text) + Double.Parse(tmontantEmb.Text) + double.Parse(tRetenueProduit.Text);
                    montanApasserAucredi = Double.Parse(tmotant.Text) + double.Parse(tRetenueProduit.Text);

                    // MessageBox.Show((montanApasserRist + SSoldeCompte).ToString());
                    if (montanApasserRist + SSoldeCompte <= 0)
                    {

                        enregOprationComptable();

                        InserMvtCpte("insererMvtcpt", comboCredit.Text, "0", montanApasserAucredi.ToString(), "0", "0", "0", tNumOP.Text);
                       // MessageBox.Show("1");
                        InserMvtCpte("insererMvtcpt", comboDebit.Text, montanApasserRist.ToString(), "0", "0", "0", "0", tNumOP.Text);
                       // MessageBox.Show("2");
                        InserMvtCpte("insererMvtcpt", comboEmballage.SelectedValue.ToString(), "0", tmontantEmb.Text, "0", "0", "0", tNumOP.Text);
                      //  MessageBox.Show("3");
                        EnregistrmentLibeleFacture();
                       // MessageBox.Show("4");
                    }
                     else
                    {
                        MessageBox.Show("LE COMPTE RESTOURNE NE  SERA PAS DEBUTEUR " +
                       "\n  LA SOMME EST DE :  " + ValeurRestourne);

                    }


                    ClasseSMS clSMS = new ClasseSMS();

                    if (comboDebit.Text.StartsWith("41") == true)
                    {
                        //MessageBox.Show(MontanTotalSms.ToString());
                        clSMS.VerificationDesituationCompte(comboDebit.Text, montanApasserRist.ToString(), " est debite de ", " OP:" + tNumOP.Text + " /En raison de " +  " vrmnt ristourne", tNumOP.Text, "");
                        smsdirecAvecTH(tNumOP.Text);
                    }

                    tNumOP.Text = fonctionOP();
                    tmotant.Text = "";
                    lmessage.Text = "L'OPERATION ENRIGISTREE";

                    AficheSolde();

                }



                else
                {
                    MessageBox.Show("LIBELE EST INSUFFISANT");
                }

            }

            catch ( Exception  ex)
            {
                MessageBox.Show(ex.Message);

            }
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
        private void comboCrediDES_SelectedIndexChanged(object sender, EventArgs e)
        {
            tLibelle.Text = "VIREMENT DE RESOURNE  SU  " + comboCrediDES.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassVaribleGolbal.RefAchercher= comboMatriculeClients.Text.Trim();

        }

        //Boolean TestDgVerificatio;
        private void chargementDgVerfication()
        {


            try
            {
                
                string sClientsDebit = " SELECT        tCompte.NumCompte, tCompte.GroupeCompte, tCompte.Matricule, tGroupeCompte.Indicateur, tCompte.DesignationCompte " +
" FROM tCompte INNER JOIN " +
                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Indicateur = 411) AND(tCompte.Matricule = @a)";

               


                string sClientsCredit = " SELECT        tCompte.NumCompte, tCompte.GroupeCompte, tCompte.Matricule, tGroupeCompte.Indicateur, tCompte.DesignationCompte " +
" FROM tCompte INNER JOIN " +
                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Indicateur <> 411) AND(tCompte.Matricule = @a)";


                string[] r = { comboMatriculeClients.Text };
               // string[] r2 = { comboMatriculeClients.Text };
                //[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                ClassRequette classeReq3 = new ClassRequette();
                
               classeReq.chargementAvecLesParametre(sClientsDebit, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCompteDebit = classeReq.dt;
                classeReq2.chargementAvecLesParametre(sClientsCredit, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCompteCredit = classeReq2.dt;
                





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
        private void comboMatriculeClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestDgVerificatio = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();

            }
        }

        private void FormPasserLecriture_Load(object sender, EventArgs e)
        {
            boolChaegmentClient = true;
            bWchargmentClient.RunWorkerAsync();
            tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
            Taux = ClassVaribleGolbal.TauxFc;
            tDateR1.Value= date1;
            tdateR2.Value = date2;
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
        DataTable TableMatricule, TableOperation;

        private void comboDebitDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chargemeentClient()
        {
            try
            {
                string Sclient = " SELECT        Matricule, IdClient, Noms, Localite, Telephone1, Telephone2, Email, Adresse, Adresse2 " +
                    " FROM            tInformationClient " +
                    " ORDER BY Matricule ";

                string sClientEmb = " SELECT        tCompte.NumCompte, tCompte.GroupeCompte, tCompte.Matricule, tGroupeCompte.Indicateur, tCompte.DesignationCompte " +
" FROM tCompte INNER JOIN " +
                       " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Indicateur = 473)";

                string sop = "SELECT        NumOperation FROM            tLibelleRistourneWHERE        (tDate1 = @da) AND (tDate2 = @db)";

                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq3 = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();

                string[] r = { "" };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
               // if (rbClients.Checked == true)
               // {

                    classeReq.chargementAvecLesParametre(Sclient, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    classeReq3.chargementAvecLesParametre(sClientEmb, ClassVaribleGolbal.seteconnexion, "tOption", r);
                    classeReq2.chargementAvecLesParametreDate(sop, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                    
                TableEmballage = classeReq3.dt;
                
                // }


              

                TableMatricule = classeReq.dt;
                TableOperation = classeReq2.dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chercherleVolume()
        {
            try
            {


                string s = "SELECT        SUM(BraViewDetailOperatioClient.SCQteSortie) AS SCQteSortie, SUM(BraViewDetailOperation.SSEntree) AS SSEntree, SUM(BraViewDetailOperation.SSSortie) AS SSSortie, SUM(BraViewDetailOperation.SSVente) " +
                        " AS SSVente, SUM(BraViewDetailOperation.SSommeVente) AS SSommeVente, SUM(BraViewDetailOperation.SQteSortieVente) AS SQteSortieVente, BraViewDetailOperatioClient.NumCompte, " +
                        " BraViewDetailOperatioClient.DesignationCompte, BraViewDetailOperatioClient.Noms, BraViewDetailOperatioClient.PourcentPv, tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2,  " +
                       "  tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tEntrepise.Republique, tEntrepise.ZoneSante, tEntrepise.Autre " +
"FROM            BraViewDetailOperatioClient INNER JOIN " +
                        " BraViewDetailOperation ON BraViewDetailOperatioClient.NumOperation = BraViewDetailOperation.NumOperation CROSS JOIN " +
                        "  tEntrepise" +
" WHERE        (BraViewDetailOperation.DateOp BETWEEN @da AND @db) " +
" GROUP BY BraViewDetailOperatioClient.NumCompte, BraViewDetailOperatioClient.DesignationCompte, BraViewDetailOperatioClient.Noms, BraViewDetailOperatioClient.PourcentPv, tEntrepise.Designation, " +
                      "    tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site, tEntrepise.Republique, tEntrepise.ZoneSante, tEntrepise.Autre " +
" HAVING        (SUM(BraViewDetailOperation.SQteSortieVente) <> 0) AND (BraViewDetailOperatioClient.NumCompte = @a) ";


                ClassRequette classeReq = new ClassRequette();

                string[] r = { comboDebit.Text };

                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);



               // FicheDechargement = classeReq.dt;

                DataTable TB = classeReq.dt;
               // Double motant, MontanVente, QteSortie, SomRestou;

                //SSVente, SSommeVente, SQteSortieVente, PourcentPv;
                {
                    SSVente = Double.Parse(TB.Rows[0]["SSVente"].ToString());
                    SSommeVente = Double.Parse(TB.Rows[0]["SSommeVente"].ToString());
                    SQteSortieVente = Double.Parse(TB.Rows[0]["SQteSortieVente"].ToString());
                    PourcentPv = Double.Parse(TB.Rows[0]["PourcentPv"].ToString());
                    ValeurRestourne = SSVente * PourcentPv;
                    
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        
        
        }

        private void chercherleSolde()
        {
            try
            {


                string s = "SELECT        SUM(tMvtCompte.Entree)- SUM(tMvtCompte.Sortie) AS SSoldeCompte  " +
" FROM            tOperation INNER JOIN " +
                         " tMvtCompte ON tOperation.NumOperation = tMvtCompte.NumOperation " +
" WHERE        (tOperation.DateOp BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND @db) " +
" GROUP BY tMvtCompte.NumCompte " +
" HAVING        (tMvtCompte.NumCompte = @a)";

                ClassRequette classeReq = new ClassRequette();

                string[] r = { comboDebit.Text };

                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);



                // FicheDechargement = classeReq.dt;

                DataTable TB = classeReq.dt;
                // Double motant, MontanVente, QteSortie, SomRestou;

                //SSVente, SSommeVente, SQteSortieVente, PourcentPv;
                {
                    SSoldeCompte = Double.Parse(TB.Rows[0]["SSoldeCompte"].ToString());
                   // SSommeVente = Double.Parse(TB.Rows[0]["SSommeVente"].ToString());
                   // SQteSortieVente = Double.Parse(TB.Rows[0]["SQteSortieVente"].ToString());
                   // PourcentPv = Double.Parse(TB.Rows[0]["PourcentPv"].ToString());

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }



        }

        private void tmotant_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDebit_SelectedIndexChanged(object sender, EventArgs e)
        {
           


           
               
        }

        private void comboDebit_Click(object sender, EventArgs e)
        {
            AficheSolde();
        }

        private void AficheSolde()
        {
            if (comboDebit.Text.Trim() != "")
            {
                chercherleVolume();
                chercherleSolde();

                tQteVendue.Text = SQteSortieVente.ToString();
                tValeurAchat.Text = SSVente.ToString();
                tRistourne.Text = (ValeurRestourne).ToString();
                tSolde.Text = SSoldeCompte.ToString();
                tDiff.Text = ((SSoldeCompte * -1) - ValeurRestourne).ToString();
                calculer();
            }
        
        }
        private void tSolde_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculer()
        {
            try
            {

                double matanApasser;
                double montanCredit,MontanRrteCreditProduit;
                    try
                    {
                     montanCredit= double.Parse(tmontantEmb.Text);
                     MontanRrteCreditProduit = double.Parse(tRetenueProduit.Text);
                    }
                catch
                  {
                montanCredit =0;
                MontanRrteCreditProduit = 0;
                }
                    matanApasser = (SSoldeCompte * -1) - montanCredit - MontanRrteCreditProduit;
                tmotant.Text = matanApasser.ToString();
                tmontantEmb.Text = montanCredit.ToString();
                tLibelle.Text = "vrmt Rest " + " Volume :" + tQteVendue.Text + " c sur  Achat : " + tValeurAchat.Text + "/ Ret Emb : " + tmontantEmb.Text +
                    " Ret Crd Prdts:" + tRetenueProduit.Text + " Acht Prdts:" + tmotant.Text + "/ Avec " +tDiff.Text + "" + tCommentaire.Text + " du " + date1.ToShortDateString() + ""+ date2.ToShortDateString();
            
            }
            catch ( Exception ex)
            { }
        
        }

        private void tmontantEmb_TextChanged(object sender, EventArgs e)
        {
             calculer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculer();
        }

        private void tDiff_TextChanged(object sender, EventArgs e)
        {
            calculer();
        }

        private void tCommentaire_TextChanged(object sender, EventArgs e)
        {
            calculer();
        }

        private void bReleveCpt_Click(object sender, EventArgs e)
        {
            try
            {
                //string codecl;

                // ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                //MessageBox.Show(codecl);

                string op;
                if (cbOp.Checked == true)
                {
                    op = comboOp.Text;
                }

                else
                {
                    op = tNumOP.Text;
                }
                Connection_Data();
                con.Open();
                cmd.CommandText = "BraStoLibelleRestourne";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@a",op);
                cmd.Parameters.AddWithValue("@b", comboDebit.Text);
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/Report2.rdlc";
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
    }
}
