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
    public partial class FormSmsRapport : Form
    {
        public FormSmsRapport()
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
        private string idsms, DesignationCompte, Email, Tele, Compte, Nom, Solde, Motant, CompteCredi, matricule, numoperation;
        private void FormSmsRapport_Load(object sender, EventArgs e)
        {
            try
            {

                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
                tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
                //tDateR12.Value = ClassVaribleGolbal.DateDuJOUR;
                // tdateR22.Value = ClassVaribleGolbal.DateDuJOUR;

                //if (bWvhargmentClient.IsBusy == false)
                //{
                //    bWvhargmentClient.RunWorkerAsync();
                //}
                tSmsEnvoye.Text = fonctionNombreEnvoye();
                tSmsNonEnvoy.Text = fonctionNombreNonEnoye();
                Taux = ClassVaribleGolbal.TauxFc;
                //ltauxFC.Text = Taux.ToString();
                chargementCompte();
            }

            catch (Exception ex)
            {

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
        private void button11_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                try
                {
                    //string codecl;
                    //int ci;
                    //ci = dGsoldeDeSrivice.CurrentRow.Index;
                    ////codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                    //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                    //MessageBox.Show(codecl);
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "SELECT        tMessage.Message, tMessage.Tele, tMessage.Compte, tMessage.Matricule, tMessage.Envoyer, tMessage.DateEnvoi, tMessage.comment, tMessage.DateOp, tInformationClient.Noms, tInformationClient.Localite,  "+
                        " tInformationClient.Adresse, tInformationClient.Adresse2, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tInformationClient.site, tMessage.NumOP, tMessage.IdMessage, " +
                        " tInformationClient.CategorieClient "+
" FROM            tMessage INNER JOIN " +
                      "   tInformationClient ON tMessage.Matricule = tInformationClient.Matricule " +
" WHERE(tMessage.DateOp BETWEEN @da AND @db) AND(tMessage.Envoyer = 0)";


                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportSmsTous.rdlc";
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

            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void ChargmenRapporVenteDeclientRelever(string chiminRap, string sPro1, String codecl, String codArticle)
        {
            try
            {





                DataTable Tmouvment;// TstockAu;



                string[] r = { codecl, codArticle };
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                try
                {
                    //string codecl;
                    //int ci;
                    //ci = dGsoldeDeSrivice.CurrentRow.Index;
                    ////codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                    //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                    //MessageBox.Show(codecl);
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "SELECT        tMessage.Message, tMessage.Tele, tMessage.Compte, tMessage.Matricule, tMessage.Envoyer, tMessage.DateEnvoi, tMessage.comment, tMessage.DateOp, tInformationClient.Noms, tInformationClient.Localite,  " +
                        " tInformationClient.Adresse, tInformationClient.Adresse2, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tInformationClient.site, tMessage.NumOP, tMessage.IdMessage, " +
                        " tInformationClient.CategorieClient " +
" FROM            tMessage INNER JOIN " +
                      "   tInformationClient ON tMessage.Matricule = tInformationClient.Matricule " +
" WHERE(tMessage.DateOp BETWEEN @da AND @db) AND(tMessage.Envoyer = 1)";


                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportSmsTous.rdlc";
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

            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //string codecl;
                //int ci;
                //ci = dGsoldeDeSrivice.CurrentRow.Index;
                ////codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        tInformationClient.Matricule, tInformationClient.CategorieClient, tCategorieCleint.DesignationCatClient, tInformationClient.Noms, tInformationClient.Telephone1, tInformationClient.Telephone2, "+
                        " tInformationClient.Email, tInformationClient.site, tInformationClient.Adresse, tInformationClient.Adresse2 " +
" FROM            tInformationClient INNER JOIN " +
                        " tCategorieCleint ON tInformationClient.CategorieClient = tCategorieCleint.CategorieClient "+
" WHERE len(tInformationClient.Telephone1 ) <> 12";


                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
               // cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
               // cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/ReportListeDeClient.rdlc";
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

        DataTable TableComboCategorie, TableMatricule;

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOULOIR ENVOYER   LES SOLDE  A LA   ? \n DATE  ===  " + ClassVaribleGolbal.DateDuJOUR + "\n" +
             " TAUX  =" + Taux.ToString() + "?",
              "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                ChargementEnvoyerSoldeRestourne();
            }

           
        }

        private void tMessage_TextChanged(object sender, EventArgs e)
        {
            Lnombre.Text = tMessage.TextLength.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER  LES SMS DU  ?  ==== " + ClassVaribleGolbal.DateDuJOUR, "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {

                    string s = "DELETE FROM tMessage  WHERE        (DateOp=@da) AND (Envoyer = 0)";
                    string[] r = { "" };
                    DateTime[] d = { DateTime.Parse(tDate1.Text) };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);



                    tSmsNonEnvoy.Text = fonctionNombreNonEnoye(); ;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboCateGorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chargementCompte()
        {

            try
            {


                string s = "SELECT        CategorieClient, DesignationCatClient, Autres " +
 " FROM            tCategorieCleint ";

                string Sclient = " SELECT        Matricule, IdClient, Noms, Localite, Telephone1, Telephone2, Email, Adresse, Adresse2 " +
                   " FROM            tInformationClient " +
                   " ORDER BY Matricule ";

                ClassRequette classeReq = new ClassRequette();
                //tDernierMat.Text
                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                TableComboCategorie = classeReq.dt;
                classeReq.chargementAvecLesParametre(Sclient, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                TableMatricule = classeReq.dt;
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboCateGorie.DataSource = TableComboCategorie;
            comboCateGorie.DisplayMember = "DesignationCatClient";
            comboCateGorie.ValueMember = "CategorieClient";

            comboMatriculeClients.DataSource = TableMatricule;
            comboMatriculeClients.DisplayMember = "Matricule";
            comboMatriculeClients.ValueMember = "Matricule";

            comboNomsCilents.DataSource = TableMatricule;
            comboNomsCilents.DisplayMember = "Noms";
            comboNomsCilents.ValueMember = "Matricule";


        }
        private string fonctionNombreEnvoye()
        {
            try
            {
                string numOperation;
                float dernier;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "SELECT        COUNT(Envoyer) AS compte " +
    " FROM tMessage " +
    " WHERE(DateOp BETWEEN @da AND @db) " +
    " GROUP BY Envoyer " +
    " HAVING(Envoyer = 1)";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@da", DateTime.Parse(tDateR1.Text));
                cmd.Parameters.AddWithValue("@db", DateTime.Parse( tdateR2.Text));
                //SqlDataReader lire;
                dernier = float.Parse(cmd.ExecuteScalar().ToString()) + 1;
                // numOperation = "MD" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
                return dernier.ToString();


                cmd.Dispose();
                con.Close();

            }
            catch ( Exception  )
            {
                return "0";
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tSmsEnvoye.Text = fonctionNombreEnvoye();
            tSmsNonEnvoy.Text = fonctionNombreNonEnoye();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            progressBar1.Visible = true;
            progressBar1.PerformStep();
            bWenvoyerSMS.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ClasseSMS clsms = new ClasseSMS();
            clsms.ChargementPouEnvoiyerDIRECTTout(tDateR1.Text, tdateR2.Text);

        }

        private void bWenvoyerSMS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("message ENVOYE");
            progressBar1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tMessage.TextLength > 10)
            {

                ChargementEnvoyerTOUS();
            }
            

        }
        public void ChargementEnvoyerTOUS()
        {
            try
            {
               
                    // MsgBox("Computer is connected.")
                    // finENvoi1 = False
                    // Dim Ip As Integer
                    string s = " SELECT        CategorieClient, Matricule, Noms, Localite, Telephone1, Telephone2, Email, site, Adresse, Adresse2 "+
  "FROM tInformationClient " +
" WHERE(CategorieClient = @a)";

                    ClassRequette req1 = new ClassRequette();
                    string[] r = { comboCateGorie.SelectedValue.ToString() };
                    DateTime[] d = { DateTime.Now };
                    req1.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "TcompteDebut", r, d);
                    // 
                    var tb = req1.dt;
                ProgressBarSms.Visible = true;
                ProgressBarSms.Value = 0;
                ProgressBarSms.Maximum = tb.Rows.Count - 1;

                for (int i = 0; i <= tb.Rows.Count - 1; i++)
                {
                     ProgressBarSms.Step = 1;
                    // classeReq.dt.Rows[0]["Solde"].ToString()
                    DesignationCompte = tb.Rows[i]["Noms"].ToString();
                    Tele = tb.Rows[i]["Telephone1"].ToString();
                    matricule = tb.Rows[i]["Matricule"].ToString();
                    ProgressBarSms.PerformStep();

                    if (Tele.Trim() != "")
                    {
                        string mesagebody = "Client:" + DesignationCompte + " ," + tMessage.Text.Trim()  + " ." + ClassVaribleGolbal.DateDuJOUR.ToShortDateString();

                        // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                        Enregistrementsms("TOUS", mesagebody, Tele, matricule, matricule);
                    } 

                    }





                MessageBox.Show((tb.Rows.Count - 1).ToString() + " MESSAGE ENVOYE");
                req1.ds.Clear();

                ProgressBarSms.Visible = false;
               
            }
            catch (Exception ex)
            {
               //MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
               // MessageBox.Show(MessageSMSout);

            }
        }

        public void ChargementEnvoyerTOUSindividuell()
        {
            try
            {

                // MsgBox("Computer is connected.")
                // finENvoi1 = False
                // Dim Ip As Integer
                string s = " SELECT        CategorieClient, Matricule, Noms, Localite, Telephone1, Telephone2, Email, site, Adresse, Adresse2 " +
"FROM tInformationClient " +
" WHERE(Matricule = @a)";

                ClassRequette req1 = new ClassRequette();
                string[] r = { comboMatriculeClients.SelectedValue.ToString() };
                DateTime[] d = { DateTime.Now };
                req1.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "TcompteDebut", r, d);
                // 
                var tb = req1.dt;
                ProgressBarSms.Visible = true;
                ProgressBarSms.Value = 0;
                ProgressBarSms.Maximum = tb.Rows.Count - 1;

                for (int i = 0; i <= tb.Rows.Count - 1; i++)
                {
                    ProgressBarSms.Step = 1;
                    // classeReq.dt.Rows[0]["Solde"].ToString()
                    DesignationCompte = tb.Rows[i]["Noms"].ToString();
                    Tele = tb.Rows[i]["Telephone1"].ToString();
                    matricule = tb.Rows[i]["Matricule"].ToString();
                    ProgressBarSms.PerformStep();

                    if (Tele.Trim() != "")
                    {
                        string mesagebody = "Client:" + DesignationCompte + " ," + tMessageIndividuel.Text.Trim() + " ." + ClassVaribleGolbal.DateDuJOUR.ToShortDateString();

                        // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                        Enregistrementsms("TOUS", mesagebody, Tele, matricule, matricule);
                    }

                }





                MessageBox.Show((tb.Rows.Count ).ToString() + " MESSAGE ENVOYE");
                req1.ds.Clear();

                ProgressBarSms.Visible = false;

            }
            catch (Exception ex)
            {
                //MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                // MessageBox.Show(MessageSMSout);

            }
        }


        public void ChargementEnvoyerSoldeRestourne()
        {
            try
            {

                // MsgBox("Computer is connected.")
                // finENvoi1 = False
                // Dim Ip As Integer
                string s = " SELECT        tInformationClient.CategorieClient, tInformationClient.Matricule, tInformationClient.Noms, tInformationClient.Localite, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, " +
                        " tInformationClient.site, tInformationClient.Adresse, tInformationClient.Adresse2, tCompte.DesignationCompte, tCompte.NumCompte, tCompte.GroupeCompte " +
" FROM            tInformationClient INNER JOIN " +
                        "  tCompte ON tInformationClient.Matricule = tCompte.Matricule " +
" WHERE(tInformationClient.CategorieClient=@a) AND(tCompte.GroupeCompte = 4102)";

                ClassRequette req1 = new ClassRequette();
                string[] r = {comboCateGorie.SelectedValue.ToString() };
                DateTime[] d = { DateTime.Now };
                req1.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "TcompteDebut", r, d);
                // 
                var tb = req1.dt;
                ProgressBarSms.Visible = true;
                ProgressBarSms.Value = 0;
                ProgressBarSms.Maximum = tb.Rows.Count - 1;

                for (int i = 0; i <= tb.Rows.Count - 1; i++)
                {
                    ProgressBarSms.Step = 1;
                    // classeReq.dt.Rows[0]["Solde"].ToString()
                    DesignationCompte = tb.Rows[i]["DesignationCompte"].ToString();
                    Tele = tb.Rows[i]["Telephone1"].ToString();
                    matricule = tb.Rows[i]["Matricule"].ToString();
                    Compte = tb.Rows[i]["NumCompte"].ToString();
                    ProgressBarSms.PerformStep();

                    if (Tele.Trim() != "")
                    {

                        ClasseSMS clsSMS = new ClasseSMS();

                        double SoldeCompte = Double.Parse(clsSMS.fonctionSoldeCompte(Compte));

                        //  fo.verification(Compte);
                        double soldedec = System.Convert.ToDouble(SoldeCompte);

                        string solde = (Math.Round(soldedec, 3)).ToString();

                        // fo.Dispose();

                        string mesagebody = "Votre cpt: " + Compte + " : " + DesignationCompte +
      "  " + " a un solde  de " + solde + "FC  au  " + ClassVaribleGolbal.DateDuJOUR.ToShortDateString() + " Merci Pr votre FidelitE" ;




                        //  string mesagebody = "Client:" + DesignationCompte + " ," + tMessage.Text.Trim() + " ." + ClassVaribleGolbal.DateDuJOUR.ToShortDateString();

                        // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                        Enregistrementsms("TOUS", mesagebody, Tele, matricule, matricule);
                    }

                }





                MessageBox.Show((tb.Rows.Count - 1).ToString() + " MESSAGE ENVOYE");
                req1.ds.Clear();

                ProgressBarSms.Visible = false;

            }
            catch (Exception ex)
            {
                //MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                // MessageBox.Show(MessageSMSout);

            }
        }
        private void Enregistrementsms(String numOP, String message, String tele, String compte, String matricule)
        {

            String s = " insert into  tMessage (NumOP,Message,Tele,Compte,Matricule,DateOp) Values (@a,@b,@c,@d,@e,@da)";
            string[] r = { numOP, message, tele, compte, matricule };
            DateTime[] d = { ClassVaribleGolbal.DateDuJOUR };
            // Dim req As New ClasseRequete
            //req.ExecuterSqlSansDate(setconnexion, s, r)
            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
        }
        private string fonctionNombreNonEnoye()
        {
            try
            { 
            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        COUNT(Envoyer) AS compte " +
" FROM tMessage " +
" WHERE(DateOp BETWEEN @da AND @db) " +
" GROUP BY Envoyer " +
" HAVING(Envoyer = 0)";
            cmd.Connection = con;
            cmd.CommandText = s;
                //cmd.Parameters.AddWithValue("@a", type);
                // cmd.Parameters.AddWithValue("@b", sevice);
                cmd.Parameters.AddWithValue("@da", DateTime.Parse(tDateR1.Text));
                cmd.Parameters.AddWithValue("@db", DateTime.Parse(tdateR2.Text));
                //SqlDataReader lire;
                dernier = float.Parse(cmd.ExecuteScalar().ToString()) + 1;
            // numOperation = "MD" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return dernier.ToString();


            cmd.Dispose();
            con.Close();

        }
            catch (Exception  )
            {
                return "0";
            }


}

        private void bRecherche_Click(object sender, EventArgs e)
        {
            FormRecherche Fp = new FormRecherche();
            Fp.Text = this.Text;

            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;

            }

            else if (Dial == DialogResult.Cancel)
            {
                comboMatriculeClients.Text = "";
                // label2.Text = "tu clicl sur cance";

            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tMessageIndividuel.TextLength > 10)
            {

                ChargementEnvoyerTOUSindividuell();
            }
        }

        private void tMessageIndividuel_TextChanged(object sender, EventArgs e)
        {
            lnombreIND.Text = tMessageIndividuel.TextLength.ToString();
        }
    }
}
