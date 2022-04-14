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
    public partial class FormEmballage : Form
    {
        public FormEmballage()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        public static string RefAchercher;
        Double Taux;
        private void FormEmballage_Load(object sender, EventArgs e)
        {
           
            try
            {

                tDate.Value = ClassVaribleGolbal.DateDuJOUR;
                tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
                tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
                tDateR12.Value = ClassVaribleGolbal.DateDuJOUR;
                tdateR22.Value = ClassVaribleGolbal.DateDuJOUR;

                if (bWvhargmentClient.IsBusy == false)
                {
                    bWvhargmentClient.RunWorkerAsync();
                }
                tNumOP.Text = fonctionOPSotie();
                tNumOp2.Text = fonctionOPSotieEmbalage();
                Taux = ClassVaribleGolbal.TauxFc;
                ltauxFC.Text = Taux.ToString();
            }

            catch  ( Exception ex)
            {

            }
            

        }


        DataTable TableCategorie;
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

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }

        DataTable TableClientEmbllage, TableComboDest,TableCompoPro;
        Boolean BoolCategorie,BoolClients ;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            chargemeentChargmentCatGorie();

            chargemeentChargment();
            
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


           
                comboBoxCategorie.DataSource = TableCategorie;
                comboBoxCategorie.DisplayMember = "DesignationCatClirntEmb";
                comboBoxCategorie.ValueMember = "CatClientEmbal";


            comboBoxCategorie2.DataSource = TableCategorie;
            comboBoxCategorie2.DisplayMember = "DesignationCatClirntEmb";
            comboBoxCategorie2.ValueMember = "CatClientEmbal";



            dGclientEmballage.DataSource = TableClientEmbllage;
            // tClientEmb.CodeClient, tClientEmb.Cleint
            comboCodePro.DataSource = TableCompoPro;
            comboCodePro.DisplayMember = "CodeClient";
            comboCodePro.ValueMember = "CodeClient";
            comboDesignationPro.DataSource = TableCompoPro;
            comboDesignationPro.DisplayMember = "Cleint";
            comboDesignationPro.ValueMember = "CodeClient";

            comboCodeDest.DataSource = TableComboDest;
            comboCodeDest.DisplayMember = "CodeClient";
            comboCodeDest.ValueMember = "CodeClient";

            comboDesignationDest.DataSource = TableComboDest;
            comboDesignationDest.DisplayMember = "Cleint";
            comboDesignationDest.ValueMember = "CodeClient";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {


          FormPop.FormPopEnreClientEmbalage  Fp = new FormPop.FormPopEnreClientEmbalage();
            Fp.Text = this.Text;
            Fp.NumOP = fonctionOPSotie();
            Fp.Utisateur = utilisateur;
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                if (bWvhargmentClient.IsBusy == false)
                {
                    bWvhargmentClient.RunWorkerAsync();
                }
            }
            else
            {
                if (bWvhargmentClient.IsBusy == false)
                {
                    bWvhargmentClient.RunWorkerAsync();
                }

            }

        }

        private string fonctionOPSotie()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        MAX(Num) AS DernierOp FROM            tClientEmb";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString())+1;
           // numOperation = "MD" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return dernier.ToString();


            cmd.Dispose();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string codecl;
            int ci;
            ci = dGclientEmballage.CurrentRow.Index;
            //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
            codecl = dGclientEmballage["CodeClient", ci].Value.ToString();
            FormPop.FormPopEnreClientEmbalage Fp = new FormPop.FormPopEnreClientEmbalage();
            Fp.Text = this.Text;
            Fp.NumOP = codecl;
            Fp.Utisateur = utilisateur;
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                if (bWvhargmentClient.IsBusy == false)
                {
                    bWvhargmentClient.RunWorkerAsync();
                }
            }

        }
        private void SupprimmeeCLientEmblage()
        {
            try
            {
                string codecl;
                int ci;
                ci = dGclientEmballage.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                codecl = dGclientEmballage["CodeClient", ci].Value.ToString();



                string s = " DELETE FROM tClientEmb " +
                     " WHERE(CodeClient = @a)";
               

              

                string[] r = { codecl };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
               
               req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
               
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }

        private void SupprimmeeMouvementEM()
        {
            try
            {
                //string codecl;
                //int ci;
                //ci = dGclientEmballage.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGclientEmballage["CodeClient", ci].Value.ToString();



                string s = " DELETE FROM tMvtEmbalage " +
                     " WHERE(NumOperation = @a)";




                string[] r = { tNumOp2.Text.Trim() };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

            }



            catch (Exception ex)
            { MessageBox.Show("  " + ex.Message); }

        }

        private void SupprimmeeMouvementUnelement()
        {
            try
            {
                string codecl,Refopration;
                int ci;
                ci = dGdernierMvmt.CurrentRow.Index;
                Refopration = dGdernierMvmt["NumOpEmb", ci].Value.ToString();
                codecl = dGdernierMvmt["CodeEmb", ci].Value.ToString();

               // MessageBox.Show(Refopration + " /" + codecl);

                string s = " DELETE FROM tMvtEmbalage " +
                     " WHERE(NumOperation =@a AND CodeEmb=@b)";




                string[] r = { Refopration, codecl };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

            }



            catch (Exception ex)
            { MessageBox.Show("  " + ex.Message); }

        }
        private string fonctionOPSotieEmbalage()
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
            numOperation = "EM" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
        private void enregOprationDestockage()
        {
            //try
            //{

            //string s = " INSERT INTO tOperation " +
            //             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,CompteDebit,CompteCredit, DateOp) " +
            //  " VALUES(@a, @b, @c, @d,@e,@f,@g,@h, @da)";
            string s = " INSERT INTO tOperation " +
                           "  (NumOperation,RefCas, Libelle, NomUt, Compte,TypeOp,BeneFiciare,CompteDebit,CompteCredit,TauxDuJour, DateOp) " +
                " VALUES (@a, @b, @c, @d,@e,@f,@g,@h,@i,@j, @da) ";

            string[] r = { tNumOp2.Text, "", tLIBELLE2.Text, utilisateur, "0", "3", "0", "0", "0", Taux.ToString() };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

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

        private void button4_Click(object sender, EventArgs e)
        {
            if ((tLIBELLE2.Text.Trim() != "") )
            {
                if ( rBMouvement.Checked== true)
                {
                    if (comboCodeDest.Text.Trim() != comboCodePro.Text.Trim())
                    {

                        CompleterMvtOPeration();

                    }
                    else
                    {
                        MessageBox.Show(" LA PROVENANCE  NE DOIT PAS ETRE IDENTIQUE");

                    }




                }
                else
                {
                    CompleterMvtOPeration();

                }

             

            }
             else
            {
                MessageBox.Show(" COMPLETER LE LIBELLE  ");
            }


                
           

            }
         private void CompleterMvtOPeration()
        {
            tNumOp2.Text = fonctionOPSotieEmbalage();
            enregOprationDestockage();


            FormPop.FormPopMouvmentEmbalge Fp = new FormPop.FormPopMouvmentEmbalge();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDestination = comboCodeDest.Text.Trim();
            Fp.CodeProvenance = comboCodePro.Text.Trim();
            // Fp.Compte = comboCompteDestockage.Text.Trim();

            Fp.boolMisencirculation = rBarrivage.Checked;
            Fp.boolMouvment = rBMouvement.Checked;
            Fp.boolSortieEnCiculatio = rbSortieEnCirc.Checked;
            // Fp.boolAutreSotie = rBAutres.Checked;

            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                if (bWcharmentMvt.IsBusy == false)
                {
                    bWcharmentMvt.RunWorkerAsync();
                }
                tLIBELLE2.Text = "";
                bCompleter.Enabled = false;


            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            tNumOp2.Text = fonctionOPSotieEmbalage();
            tLIBELLE2.Text = "";
            bCompleter.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER  ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SupprimmeeCLientEmblage();
                //AnnalerSougroupe();
                //ChargmentDgSousOperation();
            }

            if (bWvhargmentClient.IsBusy == false)
            {
                bWvhargmentClient.RunWorkerAsync();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Boolean boolEmbalageCirc;
        private void bWcharmentMvt_DoWork(object sender, DoWorkEventArgs e)
        {
            if (boolEmbalageCirc== true)
            {
                chargemeentChargmentEmbalageCirc();
            }

            else if ( boolVerification == true)
            {
                chargemeentChargmentEmbalageVerifictioCLintEMB();
            }
            else
            {
                chargemeentChargmentDernieMvtEmbalage();

            }
           
        }

        private void bWcharmentMvt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             if (boolEmbalageCirc == true)
            {
                DgEmbalageEnCirculation.DataSource = TableEmbalageCirculant;
            }

             else if ( boolVerification == true)
            {
                dgVerification.DataSource = TableVerificationEmballage;
            }
             else
            {
                dGdernierMvmt.DataSource = TableMouvementEmb;
            }

            boolEmbalageCirc = false;
            boolVerification = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER  ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SupprimmeeMouvementUnelement();
                //AnnalerSougroupe();
                //ChargmentDgSousOperation();
            }

            if (bWcharmentMvt.IsBusy == false)
            {
                bWcharmentMvt.RunWorkerAsync();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER  ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SupprimmeeMouvementEM();
                //AnnalerSougroupe();
                //ChargmentDgSousOperation();
            }

            if (bWcharmentMvt.IsBusy == false)
            {
                bWcharmentMvt.RunWorkerAsync();
            }

        }

        private void rBarrivage_CheckedChanged(object sender, EventArgs e)
        {
            AffichageMvtEmb();
        }

        private void AffichageMvtEmb()
        {
            if ( rbSortieEnCirc.Checked == true)
            {
                panelDest.Enabled= false;
                panelPro.Enabled = true;
            }
            else if ( rBarrivage.Checked == true)
            {
                panelPro.Enabled = false;
                panelDest.Enabled = true;
            }
            else if ( rBMouvement.Checked ==true)
            {
                panelPro.Enabled = true;
                panelDest.Enabled = true;
            }

        }

        private void rBMouvement_CheckedChanged(object sender, EventArgs e)
        {
            AffichageMvtEmb();
        }

        private void rbSortieEnCirc_CheckedChanged(object sender, EventArgs e)
        {
            AffichageMvtEmb();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boolEmbalageCirc = true;
            if (bWcharmentMvt.IsBusy == false)
            {
                bWcharmentMvt.RunWorkerAsync();
            }
        }
        DataTable tableComboVerification;
        private void chargemeentChargment()
        {
            try
            {

               
                string s = " SELECT        tClientEmb.CodeClient, tClientEmb.Cleint, tCategorieEmbalage.DesignationCatClirntEmb "+
" FROM tClientEmb INNER JOIN " +
                        " tCategorieEmbalage ON tClientEmb.CatClientEmbal = tCategorieEmbalage.CatClientEmbal " +
" ORDER BY tClientEmb.Num DESC  ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                ClassRequette classeReq3 = new ClassRequette();
                ClassRequette classeReq4 = new ClassRequette();

                string[] r = { "0", "0" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                classeReq2.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tclienEMB", r);
                classeReq3.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm2", r);
                classeReq4.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm3", r);




                TableClientEmbllage = classeReq.dt;


                TableComboDest = classeReq2.dt;
                TableCompoPro = classeReq3.dt;
                tableComboVerification = classeReq4.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        DataTable TableMouvementEmb;
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
            { MessageBox.Show(" erreur initial " + ex.Message); }

        }
        private void button9_Click(object sender, EventArgs e)
        {
           
            
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();
                 if  ( cbTous .Checked == true)
                {
                    string chiminRap = "Rapport/Bransimba/ReportEmbalageSyntheseCroise.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageParCl";
                    if (cbSansSoldeNul.Checked == true)
                    {
                         sPro1 = "BraStoProRappotrEmbalageParClNotNull";
                    }

                    else
                    {
                         sPro1 = "BraStoProRappotrEmbalageParCl";

                    }
                    
                    ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

                }

                else
                {
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
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


        }
        private void ChargmenRapporVenteDeclientParProdiut(string chiminRap, string sPro1)
        {
            try
            {


                string codecl;
                int ci;
                ci = DgEmbalageEnCirculation.CurrentRow.Index;

                codecl = DgEmbalageEnCirculation["CodeArticle", ci].Value.ToString();


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


        private void ChargmenRapporVenteDeclientRelever(string chiminRap, string sPro1,String codecl, String codArticle)
        {
            try
            {


             


                DataTable Tmouvment;// TstockAu;



                string[] r = { codecl, codArticle };
                DateTime[] d = { DateTime.Parse(tDateR12.Text), DateTime.Parse(tdateR22.Text) };
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
                DateTime[] d = { DateTime.Parse( Date1), DateTime.Parse( Date2) };
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



        private void ChargmenRapporVenteDeclientSommaireAveUn(string chiminRap, string sPro1,  string codecl, string codecl2, string Date1, string Date2)
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
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                if (tDateR1.Value <= tdateR2.Value)
                {
                    UpdateInit(tdateR2.Text);

                    string codecl, codecl2;
                    int ci;
                    ci = DgEmbalageEnCirculation.CurrentRow.Index;

                    codecl = DgEmbalageEnCirculation["CodeArticle", ci].Value.ToString();
                    string Date1 = tDateR1.Text;
                    string Date2 = tdateR2.Text;
                    // ChargmenRapporReledeFactureClient();

                    if (cbTous.Checked == true)
                    {
                        string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcle.rdlc";
                        string sPro1 = "BraStoProRappotrEmbalageMouvementSomStock";
                        string sPro2 = "BraStoProRappotrEmbalageParClParEmb";
                        ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);


                    }

                    else
                    {

                        codecl2 = comboBoxCategorie2.SelectedValue.ToString();
                        string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcle.rdlc";
                        string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockParCat";
                        string sPro2 = "BraStoProRappotrEmbalageParClParEmb";
                        ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, codecl2, Date1, Date2);


                    }

                }
                else
                {
                    MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

                }
            
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;

            }

           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboCodeClietVer.DataSource = tableComboVerification;
            comboCodeClietVer.DisplayMember = "CodeClient";
            comboCodeClietVer.ValueMember = "CodeClient";

            comboCodeClietVerDES.DataSource = tableComboVerification;
            comboCodeClietVerDES.DisplayMember = "Cleint";
            comboCodeClietVerDES.ValueMember = "CodeClient";
        }

        private void chargemeentChargmentDernieMvtEmbalage()
        {
            try
            {


                string s = " SELECT        tOperation.NumOperation, tMvtEmbalage.CodeEmb, tStock.DesegnationArticle, tMvtEmbalage.QteEntree, tMvtEmbalage.QteSortie, tClientEmb.Cleint " +
" FROM tClientEmb INNER JOIN " +
                        " tMvtEmbalage ON tClientEmb.CodeClient = tMvtEmbalage.CodeClient INNER JOIN "+
                        " tStock ON tMvtEmbalage.CodeEmb = tStock.CodeArticle INNER JOIN "+
                         "tOperation ON tMvtEmbalage.NumOperation = tOperation.NumOperation "+
" WHERE(tOperation.NumOperation = @a) " +
" ORDER BY tMvtEmbalage.QteEntree, tMvtEmbalage.QteSortie";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();
                

                string[] r = { tNumOp2.Text.Trim() };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                // classeReq2.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tclienEMB", r);
                //classeReq3.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm2", r);



                TableMouvementEmb = classeReq.dt;


              //  TableComboDest = classeReq2.dt;
                //TableCompoPro = classeReq3.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable TableEmbalageCirculant;
      
        private void chargemeentChargmentEmbalageCirc()
        {
            try
            {


                string s = " SELECT        BraViewEmbalageCirculant.CodeArticle, BraViewEmbalageCirculant.DesegnationArticle, BraViewEmbalageCirculant.PrixVente, BraViewEmbalageCirculant.SoldeQteCirc, " + 
                         "BraViewEmbalageCirculant.SoldeValeurCirc, BraViewSoldeQteEnStock.SoldeQte, BraViewSoldeQteEnStock.SoldeValeur, " +
                        " BraViewSoldeQteEnStock.SoldeQte - BraViewEmbalageCirculant.SoldeQteCirc AS DiffQte " +
" FROM BraViewEmbalageCirculant INNER JOIN " +
                         " BraViewSoldeQteEnStock ON BraViewEmbalageCirculant.CodeArticle = BraViewSoldeQteEnStock.CodeArticle " +
" GROUP BY BraViewEmbalageCirculant.DesegnationArticle, BraViewEmbalageCirculant.PrixVente, BraViewEmbalageCirculant.SoldeQteCirc, BraViewEmbalageCirculant.SoldeValeurCirc, BraViewEmbalageCirculant.Compte, " +
                       "   BraViewSoldeQteEnStock.SoldeQte, BraViewSoldeQteEnStock.SoldeValeur, BraViewEmbalageCirculant.CodeArticle " +
" HAVING(BraViewEmbalageCirculant.Compte = @a)";




                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();


                string[] r = { ClassVaribleGolbal.CompteEmbale};


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

              


                TableEmbalageCirculant = classeReq.dt;


               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboCodeClietVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            boolVerification = true;
            if (bWcharmentMvt.IsBusy == false)
            {
                bWcharmentMvt.RunWorkerAsync();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {



            if (tDateR12.Value <= tdateR22.Value)
            {
                UpdateInit(tdateR22.Text);
                string codecl;

                string Date1 = tDateR12.Text;
                string Date2 = tdateR22.Text;
                codecl = comboCodeClietVer.Text.Trim();

                // ChargmenRapporReledeFactureClient();

                string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcle2.rdlc";
                string sPro1 = "BraStoProRappotrEmbalageMouvementSomStock2";
                    string sPro2 = "BraStoProRappotrEmbalageParClParEmb2";
                    ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);
                
                   // string sPro1 = "BraStoProRappotrEmbalageMouvementSomStock2";
                   // string sPro2 = "BraStoProRappotrEmbalageParClParEmb2";
                   // ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);

                

               

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }

        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                string s = " SELECT        tClientEmb.CodeClient, tClientEmb.Cleint, tCategorieEmbalage.DesignationCatClirntEmb " +
" FROM tClientEmb INNER JOIN " +
                        " tCategorieEmbalage ON tClientEmb.CatClientEmbal = tCategorieEmbalage.CatClientEmbal " +
"   WHERE (tClientEmb.CatClientEmbal=@a)  ORDER BY tClientEmb.Num DESC  ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();
               // ClassRequette classeReq2 = new ClassRequette();
               // ClassRequette classeReq3 = new ClassRequette();
               // ClassRequette classeReq4 = new ClassRequette();

                string[] r = { comboBoxCategorie.SelectedValue.ToString(),  "0" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                // classeReq2.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tclienEMB", r);
                // classeReq3.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm2", r);
                // classeReq4.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm3", r);




                dGclientEmballage.DataSource = classeReq.dt;


               // TableComboDest = classeReq2.dt;
               // TableCompoPro = classeReq3.dt;
               // tableComboVerification = classeReq4.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void bRecherche_Click(object sender, EventArgs e)
        {
            FormPop.FormRehercheEmballage Fp = new FormPop.FormRehercheEmballage();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCodePro.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCodePro.Text = "";
                // label2.Text = "tu clicl sur cance";

            }




        }

        private void button14_Click(object sender, EventArgs e)
        {

            FormPop.FormRehercheEmballage Fp = new FormPop.FormRehercheEmballage();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCodeDest.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCodePro.Text = "";
                // label2.Text = "tu clicl sur cance";

            }




        }

        private void cbTous_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategorie2.Enabled =! (cbTous.Checked);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            FormPop.FormRehercheEmballage Fp = new FormPop.FormRehercheEmballage();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCodeClietVer.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCodePro.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {


            if (tDateR12.Value <= tdateR22.Value)
            {
                UpdateInit(tdateR22.Text);
                string codecl;

                string Date1 = tDateR12.Text;
                string Date2 = tdateR22.Text;
                codecl = comboCodeClietVer.Text.Trim();

                // ChargmenRapporReledeFactureClient();

                string chiminRap = "Rapport/Bransimba/Report1.rdlc";
               // string sPro1 = "BraStoProRappotrEmbalageMouvementSomStock2";
                string sPro1 = "BraStoProRappotrEmbalageParClParEmb2";
                ChargmenRapporVenteDeclientSommaireAveUn(chiminRap, sPro1, codecl, "1", Date1, Date2);

                // string sPro1 = "BraStoProRappotrEmbalageMouvementSomStock2";
                // string sPro2 = "BraStoProRappotrEmbalageParClParEmb2";
                // ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);





            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }



        }

        private void button16_Click(object sender, EventArgs e)
        {


            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();
               
                    string chiminRap = "Rapport/Bransimba/ReportEmballageSyntheseCroiseGeneral.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageParCl";
                    
                    ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

               
               


            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void button17_Click(object sender, EventArgs e)
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
                cmd.CommandText = "JournaMouvemStoxkEmballage";
                cmd.CommandTimeout = 0;

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
                string chiminRap = "Rapport/Bransimba/ReportJournalEmballage.rdlc";
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

        private void button18_Click(object sender, EventArgs e)
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
                cmd.CommandText = "JournaMouvemStoxkEmballage";
                cmd.CommandTimeout = 0;

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
                string chiminRap = "Rapport/Bransimba/ReportJournalEmballage.rdlc";
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

        private void button12_Click(object sender, EventArgs e)
        { try
            {


                if (tDateR12.Value <= tdateR22.Value)
                {
                    UpdateInit(tdateR22.Text);
                    string codecl,CodeArt;
                    int ci;
                    ci = dgVerification.CurrentRow.Index;

                    CodeArt = dgVerification["CodeArticle2", ci].Value.ToString();

                   // string Date1 = tDateR12.Text;
                  //  string Date2 = tdateR22.Text;
                    codecl = comboCodeClietVer.Text.Trim();

                    // ChargmenRapporReledeFactureClient();

                    string chiminRap = "Rapport/Bransimba/ReportReleveEmbalageParClient.rdlc";
                    string sPro1 = "BraStopProReleverEmbalageParClient";
                    //string sPro2 = "BraStoProRappotrEmbalageParClParEmb2";
                    ChargmenRapporVenteDeclientRelever(chiminRap, sPro1, codecl, CodeArt);

                }
                else
                {
                    MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message );
            }

           
           

        }

        DataTable TableVerificationEmballage;
        Boolean boolVerification;
        private void chargemeentChargmentEmbalageVerifictioCLintEMB ()
        {
            try
            {


                string s = " SELECT        tClientEmb.CodeClient, tStock.DesegnationArticle, tStock.CodeArticle, tStock.PrixVente, SUM(tMvtEmbalage.QteEntree) - SUM(tMvtEmbalage.QteSortie) AS Sstok, ((SUM(tMvtEmbalage.QteEntree)  " +
                      "    - SUM(tMvtEmbalage.QteSortie)) * tStock.PrixVente) AS SoldeValeur " +
" FROM tMvtEmbalage INNER JOIN " +
                       "  tClientEmb ON tMvtEmbalage.CodeClient = tClientEmb.CodeClient INNER JOIN " +
                         "tOperation ON tMvtEmbalage.NumOperation = tOperation.NumOperation INNER JOIN " +
                        " tStock ON tMvtEmbalage.CodeEmb = tStock.CodeArticle INNER JOIN " +
                        " tCategorieEmbalage ON tClientEmb.CatClientEmbal = tCategorieEmbalage.CatClientEmbal " +
" GROUP BY tClientEmb.CodeClient, tClientEmb.CatClientEmbal, tClientEmb.Cleint, tStock.DesegnationArticle, tStock.CodeArticle, tStock.PrixAchat, tStock.PrixVente, tCategorieEmbalage.DesignationCatClirntEmb " +
" HAVING(tClientEmb.CodeClient = @a) AND(SUM(tMvtEmbalage.QteEntree) - SUM(tMvtEmbalage.QteSortie) <> 0) "+
" ORDER BY Sstok";




                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();


                string[] r = { comboCodeClietVer.Text.Trim() };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);




                TableVerificationEmballage = classeReq.dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {

            try
            {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                string codecl, codecl2;
                int ci;
                ci = DgEmbalageEnCirculation.CurrentRow.Index;

                codecl = DgEmbalageEnCirculation["CodeArticle", ci].Value.ToString();
                string Date1 = tDateR1.Text;
                string Date2 = tdateR2.Text;
                // ChargmenRapporReledeFactureClient();

                if (cbTous.Checked == true)
                {
                    string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTous.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockTous";
                    string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                    ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);


                }

                else
                {

                    codecl2 = comboBoxCategorie2.SelectedValue.ToString();
                    string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTous.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockParCatTOUS";
                    string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                    ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, codecl2, Date1, Date2);


                }

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }



              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

            try
            {


                if (tDateR12.Value <= tdateR22.Value)
                {
                    UpdateInit(tdateR22.Text);
                    string codecl, CodeArt;
                    int ci;
                    ci = dgVerification.CurrentRow.Index;

                    CodeArt = dgVerification["CodeArticle2", ci].Value.ToString();

                    // string Date1 = tDateR12.Text;
                    //  string Date2 = tdateR22.Text;
                    codecl = comboCodeClietVer.Text.Trim();

                    // ChargmenRapporReledeFactureClient();

                    string chiminRap = "Rapport/Bransimba/ReportReleveEmbalageParClientTous.rdlc";
                    string sPro1 = "BraStopProReleverEmbalageParClientTous";
                    //string sPro2 = "BraStoProRappotrEmbalageParClParEmb2";
                    ChargmenRapporVenteDeclientRelever(chiminRap, sPro1, codecl, CodeArt);

                }
                else
                {
                    MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void button21_Click(object sender, EventArgs e)
        {

             try
            {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                string codecl, codecl2;
                int ci;
                ci = DgEmbalageEnCirculation.CurrentRow.Index;

                codecl = DgEmbalageEnCirculation["CodeArticle", ci].Value.ToString();
                string Date1 = tDateR1.Text;
                string Date2 = tdateR2.Text;
                // ChargmenRapporReledeFactureClient();

                if (cbTous.Checked == true)
                {
                    string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTousSynthese.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockTous";
                    string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                    ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, "1", Date1, Date2);


                }

                else
                {

                    codecl2 = comboBoxCategorie2.SelectedValue.ToString();
                    string chiminRap = "Rapport/Bransimba/ReportEmballageSommaireParAritcleTousSynthese.rdlc";
                    string sPro1 = "BraStoProRappotrEmbalageMouvementSomStockParCatTOUS";
                    string sPro2 = "BraStoProRappotrEmbalageParClParEmbTous";
                    ChargmenRapporVenteDeclientSommaireAvecDeux(chiminRap, sPro1, sPro2, codecl, codecl2, Date1, Date2);


                }

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }



            
                }

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxCategorie2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
