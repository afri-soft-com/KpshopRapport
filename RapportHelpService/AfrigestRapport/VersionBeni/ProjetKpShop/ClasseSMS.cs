using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApplication1;
using System.Data;
using System.Windows.Forms;
//using System.System.Web;
using System.Net;

namespace GoldenStarApplication
{
    class ClasseSMS
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        private string idsms, DesignationCompte, Email, Tele, Compte, Nom, Solde, Motant, CompteCredi, matricule, numoperation;
        private int  Interval;


        public static bool TcpSocketTest()
        {
            try
            {
                System.Net.Sockets.TcpClient client =
                    new System.Net.Sockets.TcpClient("www.google.com", 80);
                client.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public void VerificationDesituationCompte(string Compte, string motant, string typemessage, string libele, string numOP, string par)
        {
            try
            {
                // If Ttotal.Text <> "0" Then
                int CODEunites=5;
                string DesUnite = "";
                numoperation = numOP;
                con = new SqlConnection();
                cmd = new SqlCommand();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion; // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CKULE\Documents\CarnetAdresses.accdb" 'Donner le chemin d'Acces 
                con.Open();
                cmd.Connection = con;
                // cmd.CommandText = "SELECT* FROM tIdentite WHERE NumMat='A0004'"
                string s = "SELECT        tInformationClient.Noms, tInformationClient.Matricule, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tCompte.NumCompte, tCompte.DesignationCompte, " +
                        "  tCompte.SmsType,tCompte.Unite " +
                " FROM             tCompte INNER JOIN " +
                        "  tInformationClient ON tCompte.Matricule = tInformationClient.Matricule WHERE (tCompte.NumCompte=@a) ";


                // compte = MultiColumnComboCompteADebuter.Text
                cmd.CommandText = s;
                //cmd.Parameters.Add("@a", SqlDbType.VarChar, 50, "").Value = Compte; // MultiColumnComboCompteADebuter.Text
                cmd.Parameters.AddWithValue("@a", Compte);
                SqlDataReader LIRE;
                LIRE = cmd.ExecuteReader();
                while ((LIRE.Read()))
                {
                    idsms = LIRE["SmsType"].ToString();
                    Email = LIRE["Email"].ToString();
                    Tele = LIRE["Telephone1"].ToString();
                    DesignationCompte = LIRE["DesignationCompte"].ToString();
                    matricule = LIRE["Matricule"].ToString();
                    CODEunites = System.Convert.ToInt32(LIRE["Unite"]);
                }
                LIRE.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                // If idsms = "1" And Tele.Trim <> "" Then
                if ((CODEunites == 6))
                    DesUnite = "cdf";
                else if ((CODEunites == 1))
                    DesUnite = "cdf";
                else
                    DesUnite = " cdf";

                if (Tele.Trim() != "" & idsms == "1")
                {
                   // FormDepotRetrait fo = new FormDepotRetrait();

                   double SoldeCompte = Double.Parse(fonctionSoldeCompte(Compte));

                  //  fo.verification(Compte);
                   double soldedec = System.Convert.ToDouble(SoldeCompte);

                    string solde = (Math.Round(soldedec, 3)).ToString();

                   // fo.Dispose();

                    string mesagebody =  "Votre Cpt " + Compte +" : " + DesignationCompte + typemessage + motant + " " + DesUnite +
  " Le " + ClassVaribleGolbal.DateDuJOUR.ToShortDateString () + " Votre Solde est de " + solde +" " +libele ;
                    
               // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                    Enregistrementsms(numOP, mesagebody, Tele, Compte, matricule);
                }
            }


            // End If
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // Messagebox.Show(ex.Message);
            }
        }

        public void VerificationDesituationCompteSolde(string Compte, string motant, string typemessage, string libele, string numOP, string par)
        {
            try
            {
                // If Ttotal.Text <> "0" Then
                int CODEunites = 5;
                string DesUnite = "";
                numoperation = numOP;
                con = new SqlConnection();
                cmd = new SqlCommand();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion; // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CKULE\Documents\CarnetAdresses.accdb" 'Donner le chemin d'Acces 
                con.Open();
                cmd.Connection = con;
                // cmd.CommandText = "SELECT* FROM tIdentite WHERE NumMat='A0004'"
                string s = "SELECT        tInformationClient.Noms, tInformationClient.Matricule, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tCompte.NumCompte, tCompte.DesignationCompte, " +
                        "  tCompte.SmsType,tCompte.Unite " +
                " FROM             tCompte INNER JOIN " +
                        "  tInformationClient ON tCompte.Matricule = tInformationClient.Matricule WHERE (tCompte.NumCompte=@a) ";


                // compte = MultiColumnComboCompteADebuter.Text
                cmd.CommandText = s;
                //cmd.Parameters.Add("@a", SqlDbType.VarChar, 50, "").Value = Compte; // MultiColumnComboCompteADebuter.Text
                cmd.Parameters.AddWithValue("@a", Compte);
                SqlDataReader LIRE;
                LIRE = cmd.ExecuteReader();
                while ((LIRE.Read()))
                {
                    idsms = LIRE["SmsType"].ToString();
                    Email = LIRE["Email"].ToString();
                    Tele = LIRE["Telephone1"].ToString();
                    DesignationCompte = LIRE["DesignationCompte"].ToString();
                    matricule = LIRE["Matricule"].ToString();
                    CODEunites = System.Convert.ToInt32(LIRE["Unite"]);
                }
                LIRE.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                // If idsms = "1" And Tele.Trim <> "" Then
                if ((CODEunites == 6))
                    DesUnite = "cdf";
                else if ((CODEunites == 1))
                    DesUnite = "cdf";
                else
                    DesUnite = " cdf";

                if (Tele.Trim() != "" & idsms == "1")
                {
                    // FormDepotRetrait fo = new FormDepotRetrait();

                    double SoldeCompte = Double.Parse(fonctionSoldeCompte(Compte));

                    //  fo.verification(Compte);
                    double soldedec = System.Convert.ToDouble(SoldeCompte);

                    string solde = (Math.Round(soldedec, 3)).ToString();

                    // fo.Dispose();

                    string mesagebody = "Votre cpt: " + Compte + " : " + DesignationCompte + 
  "  " + " a un solde   de " + solde + "cdf au  " + ClassVaribleGolbal.DateDuJOUR.ToShortDateString() + " " + libele;

                    // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                    Enregistrementsms(numOP, mesagebody, Tele, Compte, matricule);
                    MessageBox.Show("MESSAGE ENVOYE " + Tele);
                }
            }


            // End If
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Messagebox.Show(ex.Message);
            }
        }


        public void EnvoyerSMSpourTous(string Compte, string motant, string typemessage, string libele, string numOP, string par)
        {
            try
            {
                // If Ttotal.Text <> "0" Then
                int CODEunites = 5;
                string DesUnite = "";
                numoperation = numOP;
                con = new SqlConnection();
                cmd = new SqlCommand();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion; // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CKULE\Documents\CarnetAdresses.accdb" 'Donner le chemin d'Acces 
                con.Open();
                cmd.Connection = con;
                // cmd.CommandText = "SELECT* FROM tIdentite WHERE NumMat='A0004'"
                string s = "SELECT        tInformationClient.Noms, tInformationClient.Matricule, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tCompte.NumCompte, tCompte.DesignationCompte, " +
                        "  tCompte.SmsType,tCompte.Unite " +
                " FROM             tCompte INNER JOIN " +
                        "  tInformationClient ON tCompte.Matricule = tInformationClient.Matricule WHERE (tCompte.NumCompte=@a) ";


                // compte = MultiColumnComboCompteADebuter.Text
                cmd.CommandText = s;
                //cmd.Parameters.Add("@a", SqlDbType.VarChar, 50, "").Value = Compte; // MultiColumnComboCompteADebuter.Text
                cmd.Parameters.AddWithValue("@a", Compte);
                SqlDataReader LIRE;
                LIRE = cmd.ExecuteReader();
                while ((LIRE.Read()))
                {
                    idsms = LIRE["SmsType"].ToString();
                    Email = LIRE["Email"].ToString();
                    Tele = LIRE["Telephone1"].ToString();
                    DesignationCompte = LIRE["DesignationCompte"].ToString();
                    matricule = LIRE["Matricule"].ToString();
                    CODEunites = System.Convert.ToInt32(LIRE["Unite"]);
                }
                LIRE.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                // If idsms = "1" And Tele.Trim <> "" Then
                if ((CODEunites == 6))
                    DesUnite = "cdf";
                else if ((CODEunites == 1))
                    DesUnite = "cdf";
                else
                    DesUnite = " cdf";

                if (Tele.Trim() != "" & idsms == "1")
                {
                    // FormDepotRetrait fo = new FormDepotRetrait();

                    double SoldeCompte = Double.Parse(fonctionSoldeCompte(Compte));

                    //  fo.verification(Compte);
                    double soldedec = System.Convert.ToDouble(SoldeCompte);

                    string solde = (Math.Round(soldedec, 3)).ToString();

                    // fo.Dispose();

                    string mesagebody = "Votre cpt: " + Compte + " : " + DesignationCompte +
  "  " + " a un solde   de " + solde + " cdf au  " + ClassVaribleGolbal.DateDuJOUR.ToShortDateString() + " " + libele;

                    // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                    Enregistrementsms(numOP, mesagebody, Tele, Compte, matricule);
                }
            }


            // End If
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Messagebox.Show(ex.Message);
            }
        }
        public void VerificationAchatProduit(string Compte, string motant,string Qte,string ValeurTot, string typemessage, string libele, string numOP, string par)
        {
            try
            {
                // If Ttotal.Text <> "0" Then
                int CODEunites = 5;
                string DesUnite = "";
                numoperation = numOP;
                con = new SqlConnection();
                cmd = new SqlCommand();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion; // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CKULE\Documents\CarnetAdresses.accdb" 'Donner le chemin d'Acces 
                con.Open();
                cmd.Connection = con;
                // cmd.CommandText = "SELECT* FROM tIdentite WHERE NumMat='A0004'"
                string s = "SELECT        tInformationClient.Noms, tInformationClient.Matricule, tInformationClient.Telephone1, tInformationClient.Telephone2, tInformationClient.Email, tCompte.NumCompte, tCompte.DesignationCompte, " +
                        "  tCompte.SmsType,tCompte.Unite " +
                " FROM             tCompte INNER JOIN " +
                        "  tInformationClient ON tCompte.Matricule = tInformationClient.Matricule WHERE (tCompte.NumCompte=@a) ";


                // compte = MultiColumnComboCompteADebuter.Text
                cmd.CommandText = s;
                //cmd.Parameters.Add("@a", SqlDbType.VarChar, 50, "").Value = Compte; // MultiColumnComboCompteADebuter.Text
                cmd.Parameters.AddWithValue("@a", Compte);
                SqlDataReader LIRE;
                LIRE = cmd.ExecuteReader();
                while ((LIRE.Read()))
                {
                    idsms = LIRE["SmsType"].ToString();
                    Email = LIRE["Email"].ToString();
                    Tele = LIRE["Telephone1"].ToString();
                    DesignationCompte = LIRE["Noms"].ToString();
                    matricule = LIRE["Matricule"].ToString();
                    CODEunites = System.Convert.ToInt32(LIRE["Unite"]);
                }
                LIRE.Close();
                cmd.Dispose();
                con.Close();
                con.Dispose();
                // If idsms = "1" And Tele.Trim <> "" Then
                if ((CODEunites == 6))
                    DesUnite = "FC";
                else if ((CODEunites == 1))
                    DesUnite = "FC";
                else
                    DesUnite = " ";

                if (Tele.Trim() != "" & idsms == "1")
                {
                    // FormDepotRetrait fo = new FormDepotRetrait();

                    double SoldeCompte = Double.Parse(fonctionSoldeCompte(Compte));

                    //  fo.verification(Compte);
                    double soldedec = System.Convert.ToDouble(SoldeCompte);

                    string solde = (Math.Round(soldedec, 3)).ToString();

                    // fo.Dispose();

                    string mesagebody = "Votre cpt " + Compte + " : " + DesignationCompte + typemessage + motant +  DesUnite+ " pr un vlm de: " + Qte  +"C AU :"+ ValeurTot +" " + DesUnite +
  " Le " + ClassVaribleGolbal.DateDuJOUR.ToShortDateString() + " Solde est de " + solde + "FC " + libele;

                    // Dim destination As String = Tele & smsPovider// Dim destination As String = Tele & smsPovider&

                    Enregistrementsms(numOP, mesagebody, Tele, Compte, matricule);
                }
            }


            // End If
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Messagebox.Show(ex.Message);
            }
        }
       private void Enregistrementsms(   String numOP,   String message,   String tele,   String compte,   String matricule)
    {
    
      String s = " insert into  tMessage (NumOP,Message,Tele,Compte,Matricule,DateOp) Values (@a,@b,@c,@d,@e,@da)";
       string [] r = {numOP, message, tele, compte, matricule};
            DateTime [] d ={ ClassVaribleGolbal.DateDuJOUR};
       // Dim req As New ClasseRequete
        //req.ExecuterSqlSansDate(setconnexion, s, r)
       ClassRequette req = new ClassRequette();
       req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
    }



        public string fonctionSoldeCompte(string compte)
        {

            string numOperation;
            Double dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
//            string s = " SELECT SUM(tMvtCompte.Sortie)-SUM(tMvtCompte.Entree)  AS Solde " +
//" FROM tCompte INNER JOIN " +
//                        " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
//                        " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation" +
//" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
//" HAVING(tCompte.NumCompte = @a)";



            string s = " SELECT        SUM(tMvtCompte.Sortie) - SUM(tMvtCompte.Entree) AS Solde " +
" FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" WHERE(tOperation.DateOp BETWEEN CONVERT(DATETIME, '2018-01-01 00:00:00', 102) AND @da) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
" HAVING(tCompte.NumCompte = @a)";
            cmd.Connection = con;
            cmd.CommandText = s;

            cmd.Parameters.AddWithValue("@a", compte);
             cmd.Parameters.AddWithValue("@da", ClassVaribleGolbal.DateDuJOUR);
            //SqlDataReader lire;
            dernier = Double.Parse(cmd.ExecuteScalar().ToString());
            numOperation = (dernier).ToString();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        public string MessageSMSout, op;
        string messageAenvoye, TeleSMS, Idmessage;
        public void ChargementPouEnvoiyerDIRECT()
        {
            try
            {
                if (TcpSocketTest() ==true)
                {
                    // MsgBox("Computer is connected.")
                    // finENvoi1 = False
                    // Dim Ip As Integer
                    string s = " SELECT tMessage.IdMessage, tMessage.Message, tMessage.Tele, tMessage.Envoyer FROM tMessage  WHERE (((tMessage.Envoyer)=0) And ((tMessage.NumOP)='" + op + "')) ";

                    ClassRequette req1 = new ClassRequette();
                    string[] r = { "" };
                    DateTime[] d = { ClassVaribleGolbal.DateDuJOUR };
                    req1.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "TcompteDebut", r);
                    // 
                    var tb = req1.dt;
                    // ProgressBarSms.Visible = True
                    // ProgressBarSms.Value = 0
                    // ProgressBarSms.Maximum = tb.Rows.Count - 1

                    for (int i = 0; i <= tb.Rows.Count - 1; i++)
                    {
                        // ProgressBarSms.Step = 1
                       // classeReq.dt.Rows[0]["Solde"].ToString()
                        Idmessage = tb.Rows[i]["IdMessage"].ToString();
                        TeleSMS = tb.Rows[i]["Tele"].ToString();
                        messageAenvoye = tb.Rows[i]["Message"].ToString();
                        // ProgressBarSms.PerformStep()
                        try
                        {
                            string strGet;

                            if (ClassVaribleGolbal.IdServeur == "1")
                                strGet = ClassVaribleGolbal.UrlSite + "username=" + ClassVaribleGolbal.userServeur + "&hash=" + ClassVaribleGolbal.motdepass1
        + "&numbers=" + TeleSMS + "&message=" + WebUtility.HtmlEncode(messageAenvoye) + "&sender=" +ClassVaribleGolbal. Sender;
                            else if (ClassVaribleGolbal.IdServeur == "2")
                                strGet = ClassVaribleGolbal.UrlSite + "user=" + ClassVaribleGolbal.userServeur + "&password=" +ClassVaribleGolbal. motdepass1
              + "&api_id=" + ClassVaribleGolbal.Motdepass2 + "&to=" + TeleSMS + "&text=" + WebUtility.HtmlEncode(messageAenvoye) + "&from=" + ClassVaribleGolbal.Sender;
                            else if (ClassVaribleGolbal.IdServeur == "3")
                                strGet = ClassVaribleGolbal.UrlSite + "username=" + ClassVaribleGolbal.userServeur + "&password=" + ClassVaribleGolbal.motdepass1
              + "&from=" + ClassVaribleGolbal.Sender + "&to=" + TeleSMS + "&text=" + WebUtility.HtmlEncode(messageAenvoye) + "&type=0";
                            else
                            {
                                MessageSMSout = DateTime.Now.TimeOfDay.ToString() + ":  le nom de domaine n'est pas activé ";
                                return;
                            }


                            System.Net.WebClient webClient = new System.Net.WebClient();
                            string result = webClient.DownloadString(strGet);



                            // Tecranserveur.Text = Tecranserveur.Text & vbCrLf & Now.TimeOfDay.ToString & result

                            if (result.StartsWith("ID: ") | result.Contains("batch_id") | result.StartsWith("OK"))
                                validationSMS(result, Idmessage);
                            else
                                NONvalidationSMS(result, Idmessage);


                            if (i == tb.Rows.Count - 1)
                            {
                            }
                            // ProgressBarSms.PerformStep()
                            MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + result;
                           // MessageBox.Show(MessageSMSout);
                        }
                        catch (Exception ex)
                        {

                           // MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                           MessageBox.Show(MessageSMSout);
                        
                        }
                    }






                    req1.ds.Clear();
                }
                else
                    MessageSMSout = DateTime.Today.TimeOfDay.ToString() + ":  l' ordinateur n' est pas connecté";
               // MessageBox.Show(MessageSMSout);
            
            }
            catch (Exception ex)
            {
                MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                MessageBox.Show(MessageSMSout);
            
            }
        }

        public void ChargementPouEnvoiyerDIRECTTout( String Date1, String Date2)
        {
            try
            {
                if (TcpSocketTest() == true)
                {
                    // MsgBox("Computer is connected.")
                    // finENvoi1 = False
                    // Dim Ip As Integer
                    string s = " SELECT tMessage.IdMessage, tMessage.Message, tMessage.Tele, tMessage.Envoyer FROM tMessage  WHERE (((tMessage.Envoyer)=0) And (tMessage.DateOp BETWEEN @da AND @db)) ";

                    ClassRequette req1 = new ClassRequette();
                    string[] r = { "" };
                    DateTime[] d = { DateTime.Parse(Date1), DateTime.Parse(Date2) };
                    req1.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "TcompteDebut", r, d);
                    // 
                    var tb = req1.dt;
                    // ProgressBarSms.Visible = True
                    // ProgressBarSms.Value = 0
                    // ProgressBarSms.Maximum = tb.Rows.Count - 1

                    for (int i = 0; i <= tb.Rows.Count - 1; i++)
                    {
                        // ProgressBarSms.Step = 1
                        // classeReq.dt.Rows[0]["Solde"].ToString()
                        Idmessage = tb.Rows[i]["IdMessage"].ToString();
                        TeleSMS = tb.Rows[i]["Tele"].ToString();
                        messageAenvoye = tb.Rows[i]["Message"].ToString();
                        // ProgressBarSms.PerformStep()
                        try
                        {
                            string strGet;

                            if (ClassVaribleGolbal.IdServeur == "1")
                                strGet = ClassVaribleGolbal.UrlSite + "username=" + ClassVaribleGolbal.userServeur + "&hash=" + ClassVaribleGolbal.motdepass1
        + "&numbers=" + TeleSMS + "&message=" + WebUtility.HtmlEncode(messageAenvoye) + "&sender=" + ClassVaribleGolbal.Sender;
                            else if (ClassVaribleGolbal.IdServeur == "2")
                                strGet = ClassVaribleGolbal.UrlSite + "user=" + ClassVaribleGolbal.userServeur + "&password=" + ClassVaribleGolbal.motdepass1
              + "&api_id=" + ClassVaribleGolbal.Motdepass2 + "&to=" + TeleSMS + "&text=" + WebUtility.HtmlEncode(messageAenvoye) + "&from=" + ClassVaribleGolbal.Sender;
                            else if (ClassVaribleGolbal.IdServeur == "3")
                                strGet = ClassVaribleGolbal.UrlSite + "username=" + ClassVaribleGolbal.userServeur + "&password=" + ClassVaribleGolbal.motdepass1
              + "&from=" + ClassVaribleGolbal.Sender + "&to=" + TeleSMS + "&text=" + WebUtility.HtmlEncode(messageAenvoye) + "&type=0";
                            else
                            {
                                MessageSMSout = DateTime.Now.TimeOfDay.ToString() + ":  le nom de domaine n'est pas activé ";
                                return;
                            }


                            System.Net.WebClient webClient = new System.Net.WebClient();
                            string result = webClient.DownloadString(strGet);



                            // Tecranserveur.Text = Tecranserveur.Text & vbCrLf & Now.TimeOfDay.ToString & result

                            if (result.StartsWith("ID: ") | result.Contains("batch_id") | result.StartsWith("OK"))
                                validationSMS(result, Idmessage);
                            else
                                NONvalidationSMS(result, Idmessage);


                            if (i == tb.Rows.Count - 1)
                            {
                            }
                            // ProgressBarSms.PerformStep()
                            MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + result;
                             //MessageBox.Show(MessageSMSout);
                        }
                        catch (Exception ex)
                        {

                            // MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                            MessageBox.Show(MessageSMSout);

                        }
                    }






                    req1.ds.Clear();
                }
                else
                    MessageSMSout = DateTime.Today.TimeOfDay.ToString() + ":  l' ordinateur n' est pas connecté";
                // MessageBox.Show(MessageSMSout);

            }
            catch (Exception ex)
            {
                MessageSMSout = DateTime.Today.TimeOfDay.ToString() + " : " + ex.Message;
                MessageBox.Show(MessageSMSout);

            }
        }
        private void validationSMS(string messageServeur, string id)
        {
            string Scumule = " Update    tMessage  set comment=@a,Envoyer=1,DateEnvoi=@da WHERE IdMessage=@b ";
            string[] para = new[] { messageServeur, id };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }



        private void NONvalidationSMS(string messageServeur, string id)
        {
            string Scumule = " Update    tMessage  set comment=@a,Envoyer=0,DateEnvoi=@da  WHERE IdMessage=@b ";
            string[] para = new[] { messageServeur, id };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            //ClassVaribleGolbal.DateDuJOUR
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }


        private void validationSMStous(string messageServeur, string id)
        {
            string Scumule = " Update    tMessagePourTous  set comment=@a,Envoyer=1,DateEnvoi=@da WHERE IdMessage=@b ";
            string[] para = new[] { messageServeur, id };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }



    }
}
