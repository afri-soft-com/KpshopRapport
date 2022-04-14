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
    public partial class FormParaVente : Form
    {
        public FormParaVente()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test, test2;
        String DepotMagasin = "CD1";
        private void FormParaVente_Load(object sender, EventArgs e)
        {


            Control.CheckForIllegalCrossThreadCalls = false;
            BwchalrgmentCombo.RunWorkerAsync();
            //tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
            utilisateur = ClassVaribleGolbal.UTILISATEUR;
            // Taux = ClassVaribleGolbal.TauxFc;
            //ltaux.Text = Taux.ToString();
            SetAdmin(false);
            AfichageDeContole();

        }

        private void  AfichageDeContole()
        {

            if ( ClassVaribleGolbal.Niveau == "ADMIN")

            {
                SetAdmin(true);
                // MessageBox.Show("EE");

               //MessageBox.Show("BIENVENU " + utilisateur);
            }

            else if (ClassVaribleGolbal.Niveau == "CAISSE")
            {

                SetCaisse(true);
            }
        }
        private void SetAdmin(Boolean b)
        {
            bCaisse.Enabled = b;
            bLivreDecisse.Enabled = b;
           bVente.Enabled = b;
            bLesStock.Enabled = b;
            bLemouvement.Enabled = b;
            bComptabilte.Enabled = b;
            bAproStock.Enabled = b;
            bLesArticle.Enabled = b;
              
        }


        private void SetCaisse(Boolean b)
        {
            bCaisse.Enabled = b;
            bLivreDecisse.Enabled = b;
            bVente.Enabled = b;
            bLesStock.Enabled = b;
           // bLemouvement.Enabled = b;
            //bComptabilte.Enabled = b;
            bAproStock.Enabled = b;
            bLesArticle.Enabled = b;

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

        DataTable tableDepot,TableVendeur;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ChargmentDepot();
            ChargmentVendeur();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChargementComboDepot(tableDepot, comboDepot, comboDepotDes);
            ChargementComboVendeur(TableVendeur, comboCodeDeVendeur, comboVendeurDes);
        }

        private void ChargementComboDepot(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;
           // Receveur.DataSource = t1;
            id.DataSource = t1;
            id.DisplayMember = "CodeDepot";
            id.ValueMember = "CodeDepot";
            des.ValueMember = "CodeDepot";
            des.DisplayMember = "DesignationDepot";
          //  Receveur.DisplayMember = "Receveur";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormStock")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormStock fo = new FormStock();
                //fo.MdiParent = this.MdiParent;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Boolean exiset = false;
            //foreach (Form c in this.MdiChildren)
            //{
            //    // c.Text = Me.Text
            //    if (c.Name == "FormStock")
            //    {
            //        //c.Close();
            //        c.Activate();
            //        // Exit Sub
            //        exiset = true;
            //    }


            //}


            //if (exiset == false)
            //{

            //    FormStock fo = new FormStock();
            //    fo.MdiParent = this.MdiParent;
            //   // fo.MdiParent = this;
            //    fo.Text = this.Text;
            //    fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

            //    fo.Show();
            //}


        }

        private void ChargementComboVendeur(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "CodeVendeu";
            id.ValueMember = "CodeVendeu";
            des.ValueMember = "CodeVendeu";
            des.DisplayMember = "Noms";

        }




        private void ChargmentDepot()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        CodeDepot, DesignationDepot, Receveur,SoldeCompte, SodeQteCompte, CreerPar " +
 " FROM tDepot ORDER BY Id ";

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

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }

        private void ChargmentVendeur()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        CodeVendeu, Noms " +
 " FROM            tVendeur ";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CategorieCompte", 2);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    TableVendeur = dt;
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

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            Boolean exiset = false;
            foreach (Form c in this.MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPopVente.FormOparationVente fo = new FormPopVente.FormOparationVente();
                //fo.MdiParent = this.MdiParent;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.CodeDepot = comboDepot.Text;
                fo.CodeVendeur = comboCodeDeVendeur.Text;
                fo.NomsVendeur = comboVendeurDes.Text;
                fo.ShowDialog();
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in this.MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPopVente.FormPaiment fo = new FormPopVente.FormPaiment();
               // fo.MdiParent = this.MdiParent;
                fo.Text = this.Text;
                // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                //fo.CodeDepot = comboDepot.Text;
                //fo.CodeVendeur = comboCodeDeVendeur.Text;
               // fo.NomsVendeur = comboVendeurDes.Text;
                fo.ShowDialog();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Boolean exiset = false;
            foreach (Form c in this.MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormVente")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPopVente.FormAproStocks fo = new FormPopVente.FormAproStocks();
               // fo.MdiParent = this.MdiParent;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.CodeDepot = comboDepot.Text;
                fo.CodeVendeur = comboCodeDeVendeur.Text;
                fo.NomsVendeur = comboVendeurDes.Text;
                fo.ShowDialog();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Comptabillite.FormMenu FP = new Comptabillite.FormMenu();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
           // FP.CodeCategorie = comboCat.Text.Trim();
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    // chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormPopVente.FormMenuResultat fo = new FormPopVente.FormMenuResultat();
          
            fo.Text = this.Text;
           
            fo.ShowDialog();
        }

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
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (TcpSocketTest() == true)
            {
                System.Diagnostics.Process.Start(@"AfriSync\AfriSync.exe");
            }
            else
            {
                MessageBox.Show("connexion internet");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate("");
                Fp.Text = this.Text;
                Fp.BoolReleve = true;
                String desCompte;
                
                    desCompte = " caisse";
                    Fp.libeleOP = "RELEVE DE : " + desCompte;
                    Fp.NumCompte = ClassVaribleGolbal.CaisseReception;
                

               

                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {
                   


                }

                else if (Dial == DialogResult.Cancel)
                {

                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate("");
                Fp.Text = this.Text;
                Fp.BoolBalanceMVT = true;
                String desCompte;

                desCompte = " ";
                Fp.libeleOP = " LES COMPTES QUI ONT ONT ETE MOUVEMENTE";
                Fp.NumCompte = ClassVaribleGolbal.CaisseReception;




                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {



                }

                else if (Dial == DialogResult.Cancel)
                {



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPopVente.FormNouveauArticle FP = new FormPopVente.FormNouveauArticle();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
           // FP.CodeCategorie = comboCat.Text.Trim();
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                try
                {
                   //  chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                   // chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }




    }
}
