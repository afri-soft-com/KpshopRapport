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
    public partial class FormVendeur : Form
    {
        public FormVendeur()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur = "STEVE", libeleOP;
        private String GroupeClient, GroupeRestourne;
        public string CaisseReception;
        private int Matricule, DerMatricule;
        //
        private void FormVendeur_Load(object sender, EventArgs e)
        {
            GroupeClient = GroudeCompteselonIndicateur(420);
            FormationDeCompteEtMatricule();

            chargemeentDgCompte();
            dgCompteClients.DataSource = TableCompte;
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

        private void bEnreSous_Click(object sender, EventArgs e)
        {
            enregistraiment();
           annulerCompte();
            chargemeentDgCompte();
            dgCompteClients.DataSource = TableCompte;

        }

        DataTable TableCompte;
        private void chargemeentDgCompte()
        {
            try
            {


                string s = "SELECT       idVendeu, CodeVendeu, Noms, Compte FROM            tVendeur ORDER BY idVendeu DESC ";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableCompte = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void annulerCompte()
        {
            tDesNoms.Text = "";
            GroupeClient = GroudeCompteselonIndicateur(420);
            FormationDeCompteEtMatricule();

        }

        private void enregistraiment()
        {
            try
            {

                string s = " INSERT INTO tVendeur " +
                            "   (CodeVendeu, Noms, Compte) " +
                            " VALUES        (@a,@b,@c) "
                            ;
                string sUpdede = " UPDATE       tVendeur  SET " +
                           "   CodeVendeu = @a, Noms = @b" +
                           " WHERE idVendeu =@c ";
                           

                string sCompte = " INSERT INTO tCompte " +
                         "    (NumCompte, Matricule, GroupeCompte, DesignationCompte, TypeSous, Unite, CreerPar, PourcentPv) " +
                         " VALUES        (@a,@b,@c,@d,@e,@f,@g,@h) "
                         ;




                string[] r = { tCodeVendeur.Text.Trim(), tDesNoms.Text.Trim(), tCompteClient.Text.Trim() };
                string[] rUpdate = { tCodeVendeur.Text.Trim(), tDesNoms.Text.Trim(), tRefVendeur.Text.Trim() };

                string[] rcp = { tCompteClient.Text, "0", GroupeClient, tCompteClientDes.Text, "1", "1", utilisateur, "0"};

               

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();

                if (TesteModifieVendeur == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sUpdede, rUpdate, d);

                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);



                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rcp, d);
                    //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rStourne, d);

                    //  InserMvtCpte("insererMvtcpt", tCompteRestourne.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                    InserMvtCpte("insererMvtcpt", tCompteClient.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);


                }




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
        private void InserMvtCpte(string storage, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                   con.Open();
                }
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
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }

        private void tDesNoms_TextChanged(object sender, EventArgs e)
        {
            EcrireUnCompte();
        }


        private void EcrireUnCompte()
        {
            try
            {
                tCompteClientDes.Text = " COMPTE PERSONNEL " + tDesNoms.Text;
               // tCompteRestourneDes.Text = "RESTOURNE " + tNoms.Text;
            }

            catch
            {


            }


        }

        private void dgCompteClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgCompteClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int ci;
                ci = dgCompteClients.CurrentRow.Index;



                tRefVendeur.Text = dgCompteClients["idVendeu", ci].Value.ToString().Trim();


            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        Boolean TesteModifieVendeur;
        private void tCodeVendeur_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tRefVendeur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TesteModifieVendeur = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tVendeur ";
                s = s + " where idVendeu=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tRefVendeur.Text.Trim());
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {
                    tRefVendeur.Text = lire["idVendeu"].ToString();
                    tCodeVendeur.Text = lire["CodeVendeu"].ToString();
                    tDesNoms.Text = lire["Noms"].ToString();
                    //tReceveur.Text = lire["Receveur"].ToString();
                    //tChauffeur.Text = lire["Chauffeur"].ToString();
                    //tVehicule.Text = lire["Vehicule"].ToString();




                    TesteModifieVendeur = true;
                    //MessageBox.Show(TesteModifierDepot.ToString());
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                // bSuppDepot.Enabled = TesteModifierDepot;
                if ((TesteModifieVendeur == true))
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
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;
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
        private int DerinierMatricule()
        {


            int compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT MAX(idVendeu) AS DernierMatr  FROM tVendeur ";
            cmd.Connection = con;
            cmd.CommandText = s;
            // cmd.Parameters.AddWithValue("@a", indicateur);
            //cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = int.Parse(cmd.ExecuteScalar().ToString());

            }
            catch
            {
                compte = 0;
            }

            return compte;


            cmd.Dispose();
            con.Close();

        }
        private void FormationDeCompteEtMatricule()
        {

            DerMatricule = DerinierMatricule();
            Matricule = (DerinierMatricule() + 1);
            tRefVendeur.Text = Matricule.ToString();
            //tDernierMat.Text = DerMatricule.ToString();
            tCodeVendeur.Text = "RV" + Matricule;
            tCompteClient.Text = (int.Parse(GroupeClient) * 1000 + Matricule).ToString();
           // tCompteRestourne.Text = (int.Parse(GroupeRestourne) * 1000 + Matricule).ToString();

        }
    }
}
