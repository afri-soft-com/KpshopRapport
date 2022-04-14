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
using System.IO;


namespace GoldenStarApplication
{
    public partial class FormAcueil : Form
    {
        public FormAcueil()
        {
            InitializeComponent();
        }


        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
       public String utilisateur , libeleOP;
        public string CompteClientOccasionnel = "41202";
        public string CompteClientProChambre = "41201";
        public string CompteClientOrdi = "411";
        public string CaisseReception = "57002";
        //

        Boolean test, test2;

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Boolean exiset = false;
            //foreach (Form c in MdiChildren)
            //{
            //    // c.Text = Me.Text
            //    if (c.Name == "FormLogement")
            //    {
            //        //c.Close();
            //        c.Activate();
            //        // Exit Sub
            //        exiset = true;
            //    }


            //}


            //if (exiset == false)
            //{

            //    FormLogement fo = new FormLogement();
            //    fo.MdiParent = this;
            //    fo.Text = this.Text;
            //    fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

            //    fo.Show();
            //}




           

                }

        private void button4_Click(object sender, EventArgs e)
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






            //Boolean exiset = false;
            //foreach (Form c in MdiChildren)
            //{
            //    // c.Text = Me.Text
            //    if (c.Name == "FormComptable")
            //    {
            //        //c.Close();
            //        c.Activate();
            //        // Exit Sub
            //        exiset = true;
            //    }


            //}


            //if (exiset==false)
            //{

            //    FormComptable fo = new FormComptable();
            //    fo.MdiParent = this;
            //    fo.Text = this.Text;
            //    fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
            //    fo.Show();
            //}





        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            
           
        }

        private void AfficherfORvENTE()
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormParaVente")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormParaVente fo = new FormParaVente();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }

        
        }


        private void AfficherPROJET()
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormProjet")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                // FormEmballage fo = new FormEmballage();
                ProjetBatiment.FormProjet fo = new ProjetBatiment.FormProjet();
                fo.MdiParent = this;
                fo.Text = this.Text;
                //fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }


        }
        private void bCONNECTIION_Click(object sender, EventArgs e)
        {
            Utisateur = tUser.Text;
            motDepasse = tMotDepasse.Text;
           // ClassVaribleGolbal.UTILISATEUR
           // MessageBox.Show(ClassVaribleGolbal.NomServeur);
            //MessageBox.Show(ClassVaribleGolbal.seteconnexion);
          

            if (bwConnexion.IsBusy==false)
            {
                progressBarConnnecxion.Visible = true;
                bwConnexion.RunWorkerAsync();
            }

           

        }


        private void afficherLesDepartement()


        {


            ClassVaribleGolbal.CodeDepartement = "12";
                 AfficherfORvENTE();
           // FormPopDepartement.FormDepartementOperation FP = new FormPopDepartement.FormDepartementOperation();
           // FP.Text = this.Text;
           // // Fp.NumOP = fonctionOPSotie();
           // FP.UTILISATEUR = ClassVaribleGolbal.UTILISATEUR;
           // DialogResult Dial = FP.ShowDialog();
           ////FP.ShowDialog();
           // if (Dial == DialogResult.OK)
           // {

           //     lDepartement.Text = ClassVaribleGolbal.DesignationDepartement;
           //     if (ClassVaribleGolbal.CodeDepartement =="11")
           //     {
           //        // AfficherfORvENTE();
           //         AfficherPROJET();
           //     }

           //     else if (ClassVaribleGolbal.CodeDepartement == "12")
           //     {
           //         AfficherfORvENTE();
           //     }

           //     else if (ClassVaribleGolbal.CodeDepartement == "14")
           //     {
           //         AfficherfORvENTE();
           //     }


           //     //FP.ShowDialog();
           //     //chargmentPVEncour();
           // }
           // else
           // {
           //   // FormPopDepartement.FormDepartementOperation FP = new FormPopDepartement.FormDepartementOperation();
               
              

           // }
        
        }


        private void Connexion()
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            lireLeserveur();
            SetAdmin(false);
           // bwcharmemntCombo.RunWorkerAsync();
        }

        public string LireLeCheminActuel()
        {
            StreamReader SR = File.OpenText("MonServeur.txt");
            string ligne;
            ligne = SR.ReadLine();

            SR.Close();
            return ligne;
        }
        private void lireLeserveur()
        {
            try
            {

                ClassVaribleGolbal.NomServeur = LireLeCheminActuel();
            }
            catch (Exception ex)
            {
                
                //MessageBox.Show(ex.Message);
            }
        }


        private void ParamemetreGeneraux()
        {


            progressBarConnnecxion.Maximum = 4;
           // progressBarConnnecxion.Step = 10;
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT *       from tParametreGeneraux WHERE        (IdPara = N'1') ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());
            bwConnexion.ReportProgress(1);
            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
               // ClassVaribleGolbal.UTILISATEUR = (row["DernierOp"].ToString());
                ClassVaribleGolbal.OPinit = (row["OperationInitial"].ToString());
                ClassVaribleGolbal.DateDuJOUR = DateTime.Parse((row["DateActuelle"].ToString()));
                ClassVaribleGolbal.DateCloturer = DateTime.Parse(row["DateCluture"].ToString());
                ClassVaribleGolbal.AutreInfo = (row["AutreInfo"].ToString());
                ClassVaribleGolbal.ETATbd =Boolean.Parse (row["ETATbd"].ToString());
                ClassVaribleGolbal.TauxFc = Double.Parse(row["TauxFc"].ToString());
                ClassVaribleGolbal.TauxTrans = Double.Parse(row["TauxTrans"].ToString());
                ClassVaribleGolbal.FraisdeTransProduit = Double.Parse(row["FraisdeTransProduit"].ToString());
                ClassVaribleGolbal.FraisdeTransEmbllage = Double.Parse(row["FraisdeTransEmbllage"].ToString());



                //  int num = Convert.ToInt32(DernierNumOP) + 1;ETATbd
                // numOperationPaie = "PF" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                // tNumOPpAIEMENT.Text = "PF" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();
            bwConnexion.ReportProgress(2);
        }


       
        String Utisateur, motDepasse,Niveau,Foction;

        private void bwConnexion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarConnnecxion.Value = e.ProgressPercentage;
        }
        private void SetAdmin(Boolean b)
        {
            BMajouterReceveur.Enabled = b;
            BMcomptable.Enabled = b;
            BMconnecter.Enabled = b;
            BMLancer.Enabled = b;
            BMlogement.Enabled = b;
            BMVente.Enabled = b;
            BMsupprmmer.Enabled = b;
            BMrapport1.Enabled = b;
            BMrapportStock.Enabled = b;
          //  BMlogement.Enabled = b;
            BMcaisse.Enabled = b;
            //BMleventes.Enabled = b;
            BMrapport2.Enabled = b;
            BMajouterUt.Enabled = b;
            BMRapportTierc.Enabled = b;
            BmRapportEMBALLAGE.Enabled = b;
            BMRapportCaisse.Enabled = b;
            BMajouterReceveur.Enabled = b;
            bmEmballage.Enabled = b;
            BMstock.Enabled = b;



        }
        private void SetCOMPTABLE(Boolean b)
        {
            BMajouterReceveur.Enabled = b;
            BMcomptable.Enabled = b;
            BMconnecter.Enabled = b;
            BMLancer.Enabled = b;
            BMlogement.Enabled = b;
            // BMmagasin.Enabled = b;
            //  BMsupprmmer.Enabled = b;
            BMrapport1.Enabled = b;
            BMrapportStock.Enabled = b;
            //BMleventes.Enabled = b;
            BMrapport2.Enabled = b;
            BMcaisse.Enabled = b;
            BMRapportTierc.Enabled = b;
            BmRapportEMBALLAGE.Enabled = b;




        }

        private void SetCAISSE(Boolean b)
        {
            //BMajouter.Enabled = b;
           // BMcomptable.Enabled = b;
            BMconnecter.Enabled = b;
            BMLancer.Enabled = b;
           // BMlogement.Enabled = b;
           // BMmagasin.Enabled = b;
           BMsupprmmer.Enabled = b;
          //  BMrapport1.Enabled = b;
           // BMrapport3.Enabled = b;
           // BMlogement.Enabled = b;
            BMcaisse.Enabled = b;




        }


        private void SetSERVICE(Boolean b)
        {
           // BMajouter.Enabled = b;
            //BMcomptable.Enabled = b;
            BMconnecter.Enabled = b;
            //BMLancer.Enabled = b;
            BMlogement.Enabled = b;
            //BMmagasin.Enabled = b;
            BMsupprmmer.Enabled = b;
            BMrapport1.Enabled = b;
            BMrapportStock.Enabled = b;
            BMlogement.Enabled = b;




        }



        private void SetVENTE(Boolean b)
        {
           // BMajouter.Enabled = b;
           // BMcomptable.Enabled = b;
            BMconnecter.Enabled = b;
             BMLancer.Enabled = b;
             BMVente.Enabled= b;
            //BMlogement.Enabled = b;
            // BMmagasin.Enabled = b;
              BMsupprmmer.Enabled = b;
            // BMrapport1.Enabled = b;
            //BMrapport3.Enabled = b;
            // BMlogement.Enabled = b;
            //BMleventes.Enabled = b;
           // BMrapport2.Enabled = b;



        }




        private void SetMAGASIN(Boolean b)
        {
           // BMajouterReceveur.Enabled = b;
            //BMcomptable.Enabled = b;
            BMstock.Enabled = b;
            BMconnecter.Enabled = b;
            BMLancer.Enabled = b;
           // BMlogement.Enabled = b;
            BMVente.Enabled = b;
            BMsupprmmer.Enabled = b;
            bmEmballage.Enabled = b;
           // BMrapport1.Enabled = b;
           // BMrapport3.Enabled = b;
          //  BMlogement.Enabled = b;
            BmRapportEMBALLAGE.Enabled = b;
            BMrapportStock.Enabled = b;



        }

        private void BMleventes_Click(object sender, EventArgs e)
        {




            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormParaVente")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormParaVente fo = new FormParaVente();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }


        }

        private void BMconnecter_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT VOUS DECOCONNECTER ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                foreach (Form c in MdiChildren)
                {
                    // c.Text = Me.Text

                    c.Close();
                    // c.Activate();
                    // Exit Sub
                    //exiset = true;



                }
                SetAdmin(false);
                Puser.Visible = true;
                bCONNECTIION.Text = "SE CONNECTER";



            }








        }

        private void BMLancer_Click(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormGerance")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormGerance fo = new FormGerance() ;
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
        }

        private void BMquitter_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT VOUS QUITTER ? ", "QUITTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                this.Close();
            }

            }

        private void BMsupprmmer_Click(object sender, EventArgs e)
        {


            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormSupprimer")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormSupprimer fo = new FormSupprimer();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
            //fo.GroupJournal.Visible = true;



        }

        private void BMrapport1_Click(object sender, EventArgs e)
        {
            // exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormPassageRapport")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


          //

               FormPassageRapport fo = new FormPassageRapport();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.SommaireCompte = true;
            fo.BoolBalance = true;
            fo.Show();
            //






        }

        private void BMrapport2_Click(object sender, EventArgs e)
        {
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormPassageRapport")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


            //

            FormPassageRapport fo = new FormPassageRapport();
            fo.MdiParent = this;
            fo.Text = this.Text;
            fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
            fo.SommaireCompte = true;
            fo.BoolChargeEtProduit= true;
            fo.Show();
            //
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void BMrapport3_Click(object sender, EventArgs e)
        {


            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormPassageRapport")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


            //

            FormPassageRapport fo = new FormPassageRapport();
            fo.MdiParent = this;
            fo.Text = this.Text;
            fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
            //  fo.SommaireCompte = true;
            fo.BoolStock = true;
            fo.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormPassageRapport")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


            //

            FormPassageRapport fo = new FormPassageRapport();
            fo.MdiParent = this;
            fo.Text = this.Text;
            fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
          //  fo.SommaireCompte = true;
            fo.BoolTierce = true;
            fo.Show();
        }

        private void BMcaisse_Click(object sender, EventArgs e)
        {





            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormCaisse")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

              FormCaisse fo = new FormCaisse();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
            //fo.GroupJournal.Visible = true;


        }

        private void button2_Click_1(object sender, EventArgs e)
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
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormEmballage")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                // FormEmballage fo = new FormEmballage();
                ProjetBatiment.FormProjet fo = new ProjetBatiment.FormProjet();
                fo.MdiParent = this;
                fo.Text = this.Text;
                //fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormSupprimer")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormUtilisateur fo = new FormUtilisateur();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
            //fo.GroupJournal.Visibl

        }

        private void BMajouter_Click(object sender, EventArgs e)
        {

            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormSupprimer")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPop.FormVendeur fo = new FormPop.FormVendeur();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
            //fo.GroupJournal.Visibl

        }

        
        private void bwConnexion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            //            STOCK
            //COMPTABILTE
            //EMBALLAGE

            if (ConneCTER == true && erreurCon == false)
            {
                if (Niveau == "ADMIN")

                {
                    SetAdmin(true);
                    // MessageBox.Show("EE");

                    MessageBox.Show("BIENVENU " + utilisateur);
                }
                else if (Niveau == "COMPTABILITE")
                {
                    SetCOMPTABLE(true);
                    SetVENTE(true);

                }
                else if (Niveau == "STOCK")
                {
                    SetMAGASIN(true);
                    SetVENTE(true);

                }

                else if (Niveau == "STOCK")
                {

                    SetVENTE(true);
                }

                else if (Niveau == "CAISSE")
                {

                    SetCAISSE(true);
                }

                else if (Niveau == "SERVICE")
                {
                    SetSERVICE(true);

                }





                progressBarConnnecxion.Visible = false;
                Puser.Visible = false;
                BMconnecter.Text = "SE DECONNECTER";
                tUser.Text = "";
                tMotDepasse.Text = "";
            afficherLesDepartement();
            }

            else if (erreurCon == true)
            {
                MessageBox.Show(" une erreur connexion assurez vous que le serveur est Bien allumé ");
            }

            else if (ConneCTER == false) 

            {
                MessageBox.Show(" MOT DE PASSE INCORRECT");

            }

            progressBarConnnecxion.Visible = false;
        }

        private void bwConnexion_DoWork(object sender, DoWorkEventArgs e)
        {
            erreurCon = false;
            try
            {
                ParamemetreGeneraux();
                ConnexionMotDepasse();
                //chargmentParamentreServeurr();

            }
            catch (Exception ex)
            {
                erreurCon = true;

                MessageBox.Show(ex.Message);
            }
            
        }

        Boolean ConneCTER, erreurCon=false;

        private void button2_Click_2(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormSmsRapport")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormSmsRapport fo = new FormSmsRapport();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT        tInformationClient.Matricule, tInformationClient.CategorieClient, tCategorieCleint.DesignationCatClient, tInformationClient.Noms, tInformationClient.Telephone1, tInformationClient.Telephone2, " +
                        " tInformationClient.Email, tInformationClient.site, tInformationClient.Adresse, tInformationClient.Adresse2 " +
" FROM            tInformationClient INNER JOIN " +
                        " tCategorieCleint ON tInformationClient.CategorieClient = tCategorieCleint.CategorieClient ";


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

        private void button4_Click_2(object sender, EventArgs e)
        {
            FormPop.Form1 Fp = new FormPop.Form1();



            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK

            DialogResult Dial = Fp.ShowDialog();
        }

        private void chargmentParamentreServeurr()
        {
            try
            {
                string s = " select * from tServeur WHERE Actif=1  "; // la requette sql pour charger le suffix de departement
                ClassRequette req1 = new ClassRequette();
                string[] r = { "" };
                req1.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tservue", r);
                // req1.ChargerLeDonneEnMemoir(s, "tSousDepartement", setconnexion) ' afectation dans le string 
                ClassVaribleGolbal.userServeur = req1.dt.Rows[0]["NomUtulisateur"].ToString();
                ClassVaribleGolbal.motdepass1 = req1.dt.Rows[0]["MotDePasse"].ToString();
                ClassVaribleGolbal.Motdepass2 = req1.dt.Rows[0]["MotDePasse2"].ToString();
                ClassVaribleGolbal.UrlSite = req1.dt.Rows[0]["urlsite"].ToString();
                ClassVaribleGolbal.Sender = req1.dt.Rows[0]["Sender"].ToString();
                ClassVaribleGolbal.IdServeur = req1.dt.Rows[0]["IdServeur"].ToString();

                req1.ds.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConnexionMotDepasse()
        {

//            STOCK
//COMPTABILTE
//EMBALLAGE
            bwConnexion.ReportProgress(3);
            Connection_Data();
            con.Open();
            cmd.CommandText = "select * from tUtilisateur where NomUtilisateur=@NomUtilisateur and MotPasseUtilisateur=@MotPasseUtilisateur ";

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@NomUtilisateur", Utisateur);
            cmd.Parameters.AddWithValue("@MotPasseUtilisateur", motDepasse);

            // cmd.Parameters.AddWithValue("@MotDePass", motDepasse);


            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {

                //Session["id"] = TextBox1.Text;
                //Response.Redirect("VenteForm1.aspx");
                //Session.RemoveAll();
                utilisateur= dt.Rows[0]["NomUtilisateur"].ToString();
                ClassVaribleGolbal.UTILISATEUR = dt.Rows[0]["NomUtilisateur"].ToString();
                Niveau = dt.Rows[0]["ServiceAffe"].ToString();
                ClassVaribleGolbal.Niveau = dt.Rows[0]["ServiceAffe"].ToString();
                Foction = dt.Rows[0]["FonctionUt"].ToString();
               
                ConneCTER = true;
            }
            else
            {


                ConneCTER = false;
                /// Label1.Text = "You're username and word is incorrect";
                //Label1.ForeColor = System.Drawing.Color.Red;
                bwConnexion.ReportProgress(4);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            afficherLesDepartement();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormPassageRapport")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


            //

            FormPassageRapport fo = new FormPassageRapport();
            fo.MdiParent = this;
            fo.Text = this.Text;
            fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
            //  fo.SommaireCompte = true;
            fo.BoolEMb = true;
            fo.Show();



        }

        private void button6_Click(object sender, EventArgs e)
        {

            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormTableauDebord")
                {
                    c.Close();
                    //.Activate();
                    // Exit Sub
                    // = true;
                }


            }


            //

            FormTableauDebord fo = new FormTableauDebord();
            fo.MdiParent = this;
            fo.Text = this.Text;
            fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
            //  fo.SommaireCompte = true;
           // fo.BoolReleve = true;
           // fo.BoolCaisse = true;
            fo.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormBackUP")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormBackUP fo = new FormBackUP();
                fo.MdiParent = this;
                fo.Text = this.Text;
               // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
            //fo.GroupJournal.Visibl

        }

        private void cbSMS_CheckedChanged(object sender, EventArgs e)
        {
            ClassVaribleGolbal.ModeSms = cbSMS.Checked == true;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormBackUP")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPop.FormConfiguration fo = new FormPop.FormConfiguration();
                fo.MdiParent = this;
                fo.Text = this.Text;
                // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                fo.Show();
            }
            //FormPassageRapport fo = new FormPassageRapport();
            //fo.MdiParent = this;
            //fo.Text = this.Text;
            //fo.bilan = true;
            //fo.bilantNorm = true;
            //fo.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {


            Boolean exiset = false;
            foreach (Form c in MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "FormStockExt")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormStockExt fo = new FormStockExt();
                fo.MdiParent = this;
                fo.Text = this.Text;
                fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

                fo.Show();
            }

        }
            
        
           



}
    }

