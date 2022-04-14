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
    public partial class FormPopClient1 : Form
    {
        public FormPopClient1()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur = "STEVE", libeleOP;
        private String GroupeClient, GroupeRestourne, GroupeCreditEmb;
        public string CaisseReception;
        private int Matricule,DerMatricule;
        //

       // Boolean test, test2;

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        private void FormPopClient1_Load(object sender, EventArgs e)
        {
            GroupeClient = GroudeCompteselonIndicateur(410);
            GroupeRestourne = GroudeCompteselonIndicateur(411);
            GroupeCreditEmb = GroudeCompteselonIndicateur(413);
            lGROUPE.Text = GroupeClient + " , " + GroupeRestourne + " et " + GroupeCreditEmb;

            FormationDeCompteEtMatricule();
            chargemeenComboCatClient();
        }
         private void FormationDeCompteEtMatricule()
        {

            DerMatricule = DerinierMatricule();
            Matricule = (DerinierMatricule() + 1);
            tMatricule.Text = Matricule.ToString();
            tDernierMat.Text = DerMatricule.ToString();
            tCompteClient.Text = (int.Parse(GroupeClient) * 1000 + Matricule).ToString();
            tCompteRestourne.Text = (int.Parse(GroupeRestourne) * 1000 + Matricule).ToString();
            tCrediEmballage.Text = (int.Parse(GroupeCreditEmb) * 1000 + Matricule).ToString();

        }

        private void bEnreSous_Click(object sender, EventArgs e)
        {
            try
            {
                if ((verifierNumbe.IsNumeric(tPourcentage.Text) == true) && (tNoms.TextLength > 4))
               {

                    if (testVerificationMatricule== true)
                    {
                        ModificationClieint();
                        chargemeentDgCompte(tMatriculeAmodifier.Text.Trim());
                        dgCompteClients.DataSource = TableCompte;

                    }

                    else
                    {
                        enregistraiment();
                        FormationDeCompteEtMatricule();
                        chargemeentDgCompte(tDernierMat.Text.Trim());
                        dgCompteClients.DataSource = TableCompte;
                    }
                  
                   


                    
                   
                    annulerCompte();
                    cbAmodifier.Checked = false;
                    tMatriculeAmodifier.Text = "";

                }
                else
                {
                    MessageBox.Show(" COMPLETER LE TAUX ET LE NOMS");
                }
               

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void annulerCompte ()
        {
            tMatricule.Text = "";
            tNoms.Text = "";
            ttele1.Text = "";
            ttele2.Text = "";
            tadresse1.Text = "";
            tadresse2.Text = "";
            tsiteweb.Text = "";
            tEamail.Text = "";

            tCompteClient.Text = "";
            tCompteClientDes.Text = "";

            tCompteRestourne.Text = "";
            tCompteRestourneDes.Text = "";
            tPourcentage.Text = "";

            FormationDeCompteEtMatricule();
            testVerificationMatricule = false;
        }


        DataTable TableCompte,TableComboCategorie;
        private void chargemeentDgCompte( string MatriculeCpte)
        {
            try
            {


                string s = "SELECT        tCompte.Matricule, tCompte.NumCompte, tInformationClient.Noms, tCompte.DesignationCompte, tCompte.PourcentPv " +
                         " FROM            tCompte INNER JOIN " +
"   tInformationClient ON tCompte.Matricule = tInformationClient.Matricule " +
"  WHERE        (tCompte.Matricule = @a) ";
                       


                ClassRequette classeReq = new ClassRequette();
                //tDernierMat.Text
                string[] r = { MatriculeCpte };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableCompte = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void chargemeenComboCatClient()
        {
            try
            {


                string s = "SELECT        CategorieClient, DesignationCatClient, Autres "+
 " FROM            tCategorieCleint ";



                ClassRequette classeReq = new ClassRequette();
                //tDernierMat.Text
                string[] r = { ""};


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableComboCategorie = classeReq.dt;

                comboCateGorie.DataSource = TableComboCategorie;
                comboCateGorie.DisplayMember = "DesignationCatClient";
                comboCateGorie.ValueMember = "CategorieClient";
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private string ChercherLecompteDeceMatricule(String Groupe, String Matricule)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT         NumCompte FROM            tCompte WHERE        (Matricule = @a) AND (GroupeCompte = @b) ";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", Matricule);
            cmd.Parameters.AddWithValue("@b", Groupe);
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


        private string ChercherLeTaux(String Compte)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT         PourcentPv FROM            tCompte       WHERE        (NumCompte = @a) ";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", Compte);
           // cmd.Parameters.AddWithValue("@b", Groupe);
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

            {
                //MessageBox.Show(ex.Message + " en ref " + NumCompte); 
            }

        }

        private void enregistraiment()
        {
            try
            {

                string s = " INSERT INTO tInformationClient " +
                            "    (Matricule, Noms, Localite,Telephone1, Telephone2, Email, site, Adresse, Adresse2,CategorieClient) " +
                            " VALUES        (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j) "
                            ;

                string sCompte = " INSERT INTO tCompte " +
                         "    (NumCompte, Matricule, GroupeCompte, DesignationCompte, TypeSous, Unite, CreerPar, PourcentPv) " +
                         " VALUES        (@a,@b,@c,@d,@e,@f,@g,@h) "
                         ;

               


                string[] r = { tMatricule.Text ,tNoms.Text , tLocalite.Text,ttele1.Text, ttele2.Text, tEamail.Text, tsiteweb.Text, tadresse1.Text, tadresse2.Text,comboCateGorie.SelectedValue.ToString()  };
                string[] rcp = {tCompteClient.Text, tMatricule.Text, GroupeClient, tCompteClientDes.Text, "1", "1",utilisateur, tPourcentage.Text };

                string[] rStourne = { tCompteRestourne.Text, tMatricule.Text, GroupeRestourne, tCompteRestourneDes.Text, "2", "1", utilisateur,tPourcentage.Text  };

                string[] rCredit = { tCrediEmballage.Text, tMatricule.Text, GroupeCreditEmb, tCrediEmballageDES.Text, "2", "1", utilisateur, tPourcentage.Text };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rcp, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rStourne, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rCredit, d);


                InserMvtCpte("insererMvtcpt", tCompteRestourne.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte("insererMvtcpt", tCompteClient.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte("insererMvtcpt", tCrediEmballage.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);



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



        private void ModificationClieint()
        {
            try
            {

                string s = " UPDATE       tInformationClient " +
                            "   SET                Noms = @a, Localite = @b, Telephone1 = @c, Telephone2 = @d, Email = @e, site = @f, Adresse = @g, Adresse2 = @h,CategorieClient=@i " +
                            " WHERE        (Matricule = @j) "
                            ;
                //  "    (Matricule, Noms, Localite,Telephone1, Telephone2, Email, site, Adresse, Adresse2) " +
                string sCompte = " UPDATE tCompte " +
                         "    SET   DesignationCompte=@a,PourcentPv=@b  " +
                         "  WHERE        (NumCompte = @c) "
                         ;




                string[] r = {  tNoms.Text, tLocalite.Text, ttele1.Text, ttele2.Text, tEamail.Text, tsiteweb.Text, tadresse1.Text, tadresse2.Text, comboCateGorie.SelectedValue.ToString(), tMatricule.Text };
                string[] rcp = { tCompteClientDes.Text, tPourcentage.Text, tCompteClient.Text };

                string[] rStourne = { tCompteRestourneDes.Text, tPourcentage.Text, tCompteRestourne.Text };

                string[] rCredit = { tCrediEmballageDES.Text, tPourcentage.Text, tCrediEmballage.Text };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rcp, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rStourne, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rCredit, d);


                InserMvtCpte("insererMvtcpt", tCompteRestourne.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte("insererMvtcpt", tCompteClient.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte("insererMvtcpt", tCrediEmballage.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);



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
        private void tNoms_TextChanged(object sender, EventArgs e)
        {
            EcrireUnCompte();
        }
        Boolean testVerificationMatricule;
        private void tMatriculeAmodifier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                testVerificationMatricule = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tInformationClient ";
                s = s + " where Matricule=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tMatriculeAmodifier.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    tNoms.Text = lire["Noms"].ToString();
                    tLocalite.Text = lire["Localite"].ToString();
                    ttele1.Text = lire["Telephone1"].ToString();
                    ttele2.Text = lire["Telephone2"].ToString();
                    tadresse1.Text = lire["Adresse"].ToString();
                    tadresse2.Text = lire["Adresse2"].ToString();
                    tMatricule.Text = lire["Matricule"].ToString();
                    tEamail.Text = lire["Email"].ToString();
                    tsiteweb.Text = lire["site"].ToString();
                    comboCateGorie.SelectedValue = lire["CategorieClient"].ToString();
                    //tadresse1.Text = lire["PourcentPv"].ToString();
                    // tadresse2.Text = lire["DesignationCompte"].ToString();
                    testVerificationMatricule = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSupprimmer.Enabled = testVerificationMatricule;
                if ((testVerificationMatricule == true))
                {
                    bEnreSous.Text = "&MODIFIER";
                tCompteClient.Text =   ChercherLecompteDeceMatricule(GroupeClient, tMatriculeAmodifier.Text.Trim());
                tCompteRestourne.Text = ChercherLecompteDeceMatricule(GroupeRestourne, tMatriculeAmodifier.Text.Trim());
                 tCrediEmballage.Text = ChercherLecompteDeceMatricule(GroupeCreditEmb, tMatriculeAmodifier.Text.Trim());
                    //ChercherLeTaux
                 tPourcentage.Text = ChercherLeTaux(tCompteRestourne.Text.Trim());
                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreSous.Text = "&ENREGISTRER";
                    annulerCompte();
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
               // lmessage.Text = ex.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            annulerCompte();
            cbAmodifier.Checked = false;
            tMatriculeAmodifier.Text = "";
        }

        private void tCompteClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCrediEmballageDES_TextChanged(object sender, EventArgs e)
        {

        }

        private void tMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAmodifier_CheckedChanged(object sender, EventArgs e)
        {
            tMatriculeAmodifier.Visible = cbAmodifier.Checked;
            tMatriculeAmodifier.Enabled = cbAmodifier.Checked;
        }

        private int DerinierMatricule ()
        {


            int compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT MAX(Matricule) AS DernierMatr  FROM tInformationClient ";
            cmd.Connection = con;
            cmd.CommandText = s;
           // cmd.Parameters.AddWithValue("@a", indicateur);
            //cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = int.Parse (cmd.ExecuteScalar().ToString());

            }
            catch
            {
                compte = 0;
            }

            return compte;


            cmd.Dispose();
            con.Close();

        }


        private void EcrireUnCompte()
        {
            try
            {
                tCompteClientDes.Text = " CLIENT " + tNoms.Text;
                tCompteRestourneDes.Text = "RISTOURNE " + tNoms.Text;
                tCrediEmballageDES.Text = "CREDIT EMB " + tNoms.Text;
            }

            catch
            {


            }


        }
        private void DrnierClient()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(IdClient) AS MaxIdClient FROM            tClientProvisoire ";
            cmd.CommandType = CommandType.Text;
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
                ////DernienCompte = (row["MaxIdClient"].ToString());
              ////  int num = Convert.ToInt32(DernienCompte) + 1;
              ////  tCompteClient.Text = "P" + num.ToString();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }

    }
}
