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
    public partial class FormPopEnreClientEmbalage : Form
    {
        public FormPopEnreClientEmbalage()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public string NumOP, Utisateur, Compte;
        private Boolean test;
        private void FormPopEnreClientEmbalage_Load(object sender, EventArgs e)
        {
             if (bWchargmentCombo.IsBusy == false)
            {
                bWchargmentCombo.RunWorkerAsync();
            }
            tBCodeClienAmblage.Text = NumOP;


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

        private void bWchargmentCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
        }

        private void bWchargmentCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboBoxCategorie.DataSource = TableCategorie;
            comboBoxCategorie.DisplayMember = "DesignationCatClirntEmb";
            comboBoxCategorie.ValueMember = "CatClientEmbal";


            comboBMatricule.DataSource = TableMatricule;
            comboBMatricule.DisplayMember = "Matricule";
            comboBMatricule.ValueMember = "Matricule";

            comboBoNomMatricule.DataSource = TableMatricule;
            comboBoNomMatricule.DisplayMember = "Noms";
            comboBoNomMatricule.ValueMember = "Matricule";
        }

        DataTable TableCategorie, TableMatricule;

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBCodeClienAmblage.Text.Trim()!="")
            {
                enregistraiment();

                chargemeentDgEmballage();
                CreerleCompteCrediEMBMouvment(tBCodeClienAmblage.Text.Trim());
                Annnuler();

            }
        }


        DataTable TableAmballage;
        private void chargemeentDgEmballage()
        {
            try
            {


                string s = " SELECT        DesegnationArticle, CodeArticle, Compte " +
" FROM            tStock " +
" WHERE(Compte = 310101)";


                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableAmballage = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreerleCompteCrediEMBMouvment( string CodeClients)
        {



            //ChargmenTbletousleARTICLE();
            String  CodeEmb;// CodeChambre, CompteClien, CompteChambre, Tarrif;
                                                               // String PrixVente, Critique, UiniteEnDetaille;
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            ClassRequette req = new ClassRequette();
            

                for (int j = 0; j <= TableAmballage.Rows.Count - 1; j++)
                {



                    //bwEnreNuitte.ReportProgress(i);
                    CodeEmb = TableAmballage.Rows[j]["CodeArticle"].ToString();




                    //  string[] rCredit = { compte, "2", Matrcicule, DesCompte,  utilisateur, };

                    //  DateTime[] d = { DateTime.Now };

                    try
                    {
                        //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, rCredit, d);
                        //  InserMvtCpte("insererMvtcpt", compte, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                        InserMvtEmballqge("inserertMvtEmballage", CodeClients, CodeEmb, ClassVaribleGolbal.OPinit);


                    }

                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message + "" + " " + CodeEmb);

                    }

                




            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
                cmd.Dispose();
            }
            // con.Close();
            // cmd.Dispose();
            MessageBox.Show("ok");


        }

private void InserMvtEmballqge(string storage, string CodeClient, string CodeEmb, string NumOp)
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
        cmd.Parameters.AddWithValue("@CodeClient", CodeClient);
        cmd.Parameters.AddWithValue("@CodeEmb", CodeEmb);
        // cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
        cmd.Parameters.AddWithValue("@QteEntree", "0");
        cmd.Parameters.AddWithValue("@QteSortie ", "0");
        cmd.Parameters.AddWithValue("@Entree", "0");
        cmd.Parameters.AddWithValue("@Sortie", "0");
        cmd.Parameters.AddWithValue("@PR", "0");
        // cmd.Parameters.AddWithValue("@Vente", "0");
        // cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
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
        //MessageBox.Show(ex.Message + " en ref " ); 
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


        private string fonctionDernierClientEmb( string cat)
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s ="  SELECT        COUNT(CodeClient) + 1 AS Nombre " +
" FROM tClientEmb " +
" GROUP BY CatClientEmbal " +
" HAVING(CatClientEmbal = @a)"  ;
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", cat);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString()) + 1;
            // numOperation = "MD" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return dernier.ToString();


            cmd.Dispose();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBCodeClienAmblage.Text = fonctionOPSotie();
        }

        private void tBCodeClienAmblage_TextChanged(object sender, EventArgs e)
        {


            try
            {
                test = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tClientEmb ";
                s = s + " where CodeClient=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a",tBCodeClienAmblage.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    tBCodeClienAmblage.Text = lire["CodeClient"].ToString();
                    tBDesignationClientEmb.Text = lire["Cleint"].ToString();
                    comboBoxCategorie.SelectedValue = lire["CatClientEmbal"].ToString();

                    comboBMatricule.Text = lire["Matricule"].ToString();
                   
                   // tDesAmodifier.Text = lire["DesignationCompte"].ToString();
                    test = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
               // bSupprimmer.Enabled = test;
                if ((test == true))
                {
                    btEnre.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    btEnre.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
               // lmessage.Text = ex.Message;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        string dernierClientEmb;
        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cBModification.Checked == false)
                {
                    dernierClientEmb = fonctionDernierClientEmb(comboBoxCategorie.SelectedValue.ToString());
                    chargmentNomClientDepot();
                }
              

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
         private void chargmentNomClientDepot()
        {



            try
            {
                if (comboBoxCategorie.SelectedValue.ToString() == "2")
                {
                    string Des;
                    Des = "CPT EMB " + comboBoNomMatricule.Text.Trim();
                    tBDesignationClientEmb.Text = Des;
                    tBCodeClienAmblage.Text = (9000 + int.Parse(comboBMatricule.Text)).ToString(); ;

                }
                else if (comboBoxCategorie.SelectedValue.ToString() == "1")
                {
                    string Des;
                    Des = "DEPOT  ";
                    tBCodeClienAmblage.Text =(7000+ int.Parse( dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }

                else if (comboBoxCategorie.SelectedValue.ToString() == "6")
                {
                    string Des;
                    Des = "DEPOT  ";
                    tBCodeClienAmblage.Text = (7000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }

                else if (comboBoxCategorie.SelectedValue.ToString() == "3")
                {
                    string Des;
                    Des = "PERSONNEL ";
                    tBCodeClienAmblage.Text = (8000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }

                else if (comboBoxCategorie.SelectedValue.ToString() == "4")
                {
                    string Des;
                    Des = "CPT EMB ";
                    tBCodeClienAmblage.Text = (6000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }


                else if (comboBoxCategorie.SelectedValue.ToString() == "5")
                {
                    string Des;
                    Des = "FOURNISSEUR";
                    tBCodeClienAmblage.Text = (5000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }
                else if (comboBoxCategorie.SelectedValue.ToString() == "7")
                {
                    string Des;
                    Des = "DEPOT  ";
                    tBCodeClienAmblage.Text = (7000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }



                else 
                {
                    string Des;
                    Des = "DEPOT  ";
                    tBCodeClienAmblage.Text = (7000 + int.Parse(dernierClientEmb)).ToString();

                    tBDesignationClientEmb.Text = Des;


                }


            }

            catch (Exception ex)

            {


               // MessageBox.Show(ex.Message);
            }




        }

        private void comboBMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargmentNomClientDepot();
        }

        private void comboBoNomMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategorie_Click(object sender, EventArgs e)
        {
            try
            {

                if (cBModification.Checked == false)
                {
                    chargmentNomClientDepot();
                    dernierClientEmb = fonctionDernierClientEmb(comboBoxCategorie.SelectedValue.ToString());
                }

              
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void chargemeentChargment()
        {
            try
            {

               
                string s = " SELECT        DesignationCatClirntEmb, CatClientEmbal FROM            tCategorieEmbalage";

                string s2 = "SELECT        Matricule, Noms, Localite, IdClient FROM            tInformationClient ";







                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                string[] r = {"0", "0" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                classeReq2.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                TableCategorie = classeReq.dt;
                TableMatricule = classeReq2.dt;









                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Annnuler()
        {
            tBCodeClienAmblage.Text = "";
            tBDesignationClientEmb.Text = "";
            comboBMatricule.Text = "";


        }
        private void enregistraiment()
        {
            try
            {

                string s = " INSERT INTO tClientEmb " +
                        "  (CodeClient, CatClientEmbal, Matricule, Cleint, Creerpar, DateCreation) " +
" VALUES(@a, @b, @C, @d, @e, @da) ";

                String Supdate = "UPDATE       tClientEmb " +
" SET CodeClient = @a, CatClientEmbal = @b,Matricule = @c, Cleint = @d,  Creerpar = @e, DateCreation = @da " +
" WHERE(CodeClient = @a)";
                

                string[] r = { tBCodeClienAmblage.Text, comboBoxCategorie.SelectedValue.ToString(), comboBMatricule.Text, tBDesignationClientEmb.Text, Utisateur };
              

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                if ( test == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Supdate, r, d);
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                }
                
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
