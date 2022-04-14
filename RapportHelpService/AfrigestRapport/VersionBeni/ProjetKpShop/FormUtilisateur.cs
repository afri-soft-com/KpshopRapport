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
    public partial class FormUtilisateur : Form
    {
        public FormUtilisateur()
        {
            InitializeComponent();
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            ChargementUtisateur();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test;// test2;
        //String DepotMagasin = "CD1";
       // String AchatStock = "601101";
       // private String GroupeCaisse, GroupeVente;
        //String Unite;
        Boolean boolModifier;
        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        DataTable TableUtilisateur;
        private void ChargementUtisateur()
        {

            try
            {
               
                string s = " SELECT        IdUtilisateur, NomUtilisateur, DesignationUt, FonctionUt, ServiceAffe" +
                              "           FROM            tUtilisateur ";

                string[] r = { "" };
               
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);

                TableUtilisateur = classeReq.dt;
                dGutilisateur.DataSource = TableUtilisateur;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
         private void Annuler()
        {
            tNomUSER.Text = "";
            tDesignationUt.Text = "";
            tMotDepasse .Text= "";
            comboService.Text = "";
            tFonction.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( tNomUSER.Text.Trim() !="" && comboService.Text.Trim()!="" )
            {

                try
                {
                    enregitrementUtilisateur();
                    ChargementUtisateur();
                    Annuler();

                }
                 catch (Exception ex)
                {

                    //ex.Message;
                    MessageBox.Show(ex.Message);
                }
              

            }
            else
            {
                MessageBox.Show("COMPLETER LES CASES VIDES");
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ci;
            ci = dGutilisateur.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tNomUSER.Text = dGutilisateur["NomUtilisateur", ci].Value.ToString().Trim();

        }

        private void tNomUSER_TextChanged(object sender, EventArgs e)
        {

            try
            {
                boolModifier = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tUtilisateur ";
                s = s + " where NomUtilisateur=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tNomUSER.Text.Trim());
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {
                    tNomUSER.Text = lire["NomUtilisateur"].ToString();
                    comboService.Text = lire["ServiceAffe"].ToString();
                    tDesignationUt.Text = lire["DesignationUt"].ToString();
                    tFonction.Text = lire["FonctionUt"].ToString();
                    tMotDepasse.Text = lire["MotPasseUtilisateur"].ToString();
                    //tVehicule.Text = lire["Vehicule"].ToString();




                    boolModifier = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSupUser.Enabled = boolModifier;
                if ((boolModifier == true))
                {
                    bEnreUser.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreUser.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Annuler();
        }

        private void enregitrementUtilisateur()
        {
            string s = "INSERT INTO tUtilisateur  ( NomUtilisateur,DesignationUt, MotPasseUtilisateur,FonctionUt,ServiceAffe) values (@a,@b,@c,@d,@e)";


            string sUpdate = "UPDATE  tUtilisateur  Set  NomUtilisateur=@a, DesignationUt=@b,MotPasseUtilisateur=@c,FonctionUt=@d,ServiceAffe=@e WHERE  NomUtilisateur=@a ";

            string[] r = { tNomUSER.Text, tDesignationUt.Text, tMotDepasse.Text, tFonction.Text, comboService.Text };
            DateTime[] d = { DateTime.Now };

            ClassRequette req = new ClassRequette();

            if (boolModifier == true)
            {
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sUpdate, r, d);
            }
            else
            {
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

            }
            
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            FormPopDepartement.FormAffectation FP = new FormPopDepartement.FormAffectation();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                //chargmentPVEncour();
            }
            else
            {
               // chargmentPVEncour();

            }
        }



    }
}
