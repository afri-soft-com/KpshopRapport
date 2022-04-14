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
    public partial class FormSupprimer : Form
    {
        public FormSupprimer()
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSupprimer_Load(object sender, EventArgs e)
        {
            // ChargementOperation();
            tdate.Value = ClassVaribleGolbal.DateDuJOUR;
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


        private void ChargementOperation()
        {

            try
            {
                //string s = "SELECT  dbo.tEleve.MatriculeEleve, dbo.tEleve.NomEleve, dbo.tEleve.PostnomEleve, dbo.tEleve.PrenomEleve, dbo.tEleve.SexeEleve, dbo.tEleve.Nationalite," +
                //         "dbo.tEleve.ProvEcole, dbo.tEleve.lieuNais, dbo.tEleve.DateNais, dbo.tInscription.codeSale, dbo.tInscription.codeAnnee, dbo.tInscription.codeEcole, " +
                //        " dbo.tInscription.DateInscription, dbo.tInscription.FraisIscription, dbo.tInscription.TypeInsription" +
                //            "FROM  dbo.tEleve INNER JOIN" +
                //         "dbo.tInscription ON dbo.tEleve.MatriculeEleve = dbo.tInscription.MatriculeEleve";

                string s2 = "SELECT        NumOperation, Libelle, NomUt, DateOp FROM            tOperation" +
                              "            WHERE        (DateOp = @da) AND (NomUt = @a)";



                string s = "SELECT        NumOperation, Libelle, NomUt, DateOp FROM            tOperation" +
                              "            WHERE        (DateOp = @da)";

                string[] r = { utilisateur };
                // DateTime[] d = {tDateOP.Value }; ;
                DateTime[] d = { DateTime.Parse(tdate.Text) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);
                // dgClasse.DataSource = classeReq.dt;
                comboOperation.DataSource = classeReq.dt;
                comboOperation.DisplayMember = "NumOperation";
                //comboOperation.ValueMember = "ProvenanceMat";
                //tDestina.Text = comboOperation.SelectedValue.ToString();
                comboOperation.ValueMember = "Libelle";
                tLibelle.Text = comboOperation.SelectedValue.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        string journalSup ="",JournalCH=" ",JournalStock=" ",JournalClient=" ";
        Boolean ChargmentIni = false;
        private void comboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumOPeration = comboOperation.Text;
            DateOperaton=tdate.Text;
            ChargmentIni = false;
            if (backgroundWorker1.IsBusy ==false)
            {
                backgroundWorker1.RunWorkerAsync();
                comboOperation.ValueMember = "Libelle";
                tLibelle.Text = comboOperation.SelectedValue.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChargementOperation();
        }

        private void dgCompte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgchambre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bEnreSupIdentite_Click(object sender, EventArgs e)
        {
            try {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ?  ==== " + tLibelle.Text, "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    enregitrementEleve();
                    SupprimerOP();
                    supprressionDesElements();
                    ChargmentIni = true;
                    if (backgroundWorker1.IsBusy == false)
                    {
                        backgroundWorker1.RunWorkerAsync();
                        // comboOperation.ValueMember = "Libelle";
                        tLibelle.Text = "";

                    }


                    ChargementMouvement();

                }




            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgCompte.DataSource = tableComptaSUP;
            dgStock.DataSource = TableStockSup;
            DgClientPro.DataSource = TableChambre;
            //  dgchambre.DataSource=tableComptaSUP;
            //PVentUN

            dgchambre.DataSource = TableClienPrp;


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ChargmentIni == true)
            {
                ChargementMouvementInit();
            }
            else
            {

                ChargementMouvement();
            }

           
        }


        private void enregitrementSuprimmer()
        {
            string s = "INSERT INTO tSupprimmer " +
                         " (Libelle, JournalOP, JournanStock, JournalClient, JournanChambre, Par, DatOP, DateSup) " +
 " VALUES(@a, @b, @c, @d, @e, @f, @da, @db) ";
            string[] r = { tLibelle.Text, journalSup, JournalStock, JournalClient, JournalCH, utilisateur };
            DateTime[] d = { DateTime.Parse(tdate.Text), DateTime.Now};

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }
        String NumOPeration,DateOperaton;

        private void tdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try

            {
               // UpdateInit();
                Connection_Data();
                con.Open();
                cmd.CommandText = "RappportSupprimer";


                //             

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@DateSup", DateTime.Parse( tDate1.Text));
                 cmd.Parameters.AddWithValue("@DateSup2", DateTime.Parse(tDate2.Text));
               // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
               // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdate2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportSupprimer.rdlc";
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

        DataTable tableComptaSUP, TableStockSup, TableChambre, TableClienPrp;
        private void ChargementMouvement()
        {

            try
            {
                //string s = "SELECT  dbo.tEleve.MatriculeEleve, dbo.tEleve.NomEleve, dbo.tEleve.PostnomEleve, dbo.tEleve.PrenomEleve, dbo.tEleve.SexeEleve, dbo.tEleve.Nationalite," +
                //         "dbo.tEleve.ProvEcole, dbo.tEleve.lieuNais, dbo.tEleve.DateNais, dbo.tInscription.codeSale, dbo.tInscription.codeAnnee, dbo.tInscription.codeEcole, " +
                //        " dbo.tInscription.DateInscription, dbo.tInscription.FraisIscription, dbo.tInscription.TypeInsription" +
                //            "FROM  dbo.tEleve INNER JOIN" +
                //         "dbo.tInscription ON dbo.tEleve.MatriculeEleve = dbo.tInscription.MatriculeEleve";

                string s = "SELECT        NumOperation, NumCompte, Entree, Sortie, PR " +
" FROM            tMvtCompte" +
"  WHERE        (NumOperation = @a) ";


                string s2 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie, Vente " +
        " FROM            tMvtEmbalage " +
        "  WHERE        (NumOperation = @a) ";



                string s3 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie, Vente, PVentUN " +
" FROM            tMvtStock " +
"  WHERE        (NumOperation = @a) ";


                string s4 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie " +
     " FROM            tMvtEmbalage " +
     "  WHERE        (NumOperation = @a) ";

                string[] r = { NumOPeration };
                // DateTime[] d = {tDateOP.Value }; ;
                DateTime[] d = { DateTime.Parse(DateOperaton) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve1", r, d);
                tableComptaSUP= classeReq.dt;

                classeReq.chargementAvecLesParametreDate(s2, ClassVaribleGolbal.seteconnexion, "tEleve2", r, d);
                TableChambre = classeReq.dt;

                classeReq.chargementAvecLesParametreDate(s3, ClassVaribleGolbal.seteconnexion, "tEleve3", r, d);
                TableStockSup = classeReq.dt;

                classeReq.chargementAvecLesParametreDate(s4, ClassVaribleGolbal.seteconnexion, "tEleve4", r, d);
                TableClienPrp = classeReq.dt;

                String COMPTE, motantd, montantc, numop, Des,pr,pv;
                journalSup = "";

                if (tableComptaSUP.Rows.Count > 0)
                {
                    for (int i = 0; i <= tableComptaSUP.Rows.Count - 1; i++)
                    {
                        COMPTE = tableComptaSUP.Rows[i]["NumCompte"].ToString();
                        numop = tableComptaSUP.Rows[i]["NumOperation"].ToString();
                        montantc = tableComptaSUP.Rows[i]["Entree"].ToString();
                        motantd = tableComptaSUP.Rows[i]["Sortie"].ToString();
                        pr = tableComptaSUP.Rows[i]["PR"].ToString();
                        journalSup = journalSup + COMPTE + "= " + " ," + numop + ", " + montantc + "," + motantd + ", " +pr;
                    }
                }
                else
                {

                    journalSup = "";
                }


                if (TableChambre.Rows.Count > 0)
                {
                    for (int i = 0; i <= tableComptaSUP.Rows.Count - 1; i++)
                    {
                        COMPTE = TableChambre.Rows[i]["NumCompte"].ToString();
                        numop = TableChambre.Rows[i]["NumOperation"].ToString();
                        motantd = TableChambre.Rows[i]["Entree"].ToString();
                        montantc = TableChambre.Rows[i]["Sortie"].ToString();
                        pv = TableChambre.Rows[i]["Sortie"].ToString();
                        JournalCH = JournalCH + COMPTE + "= "  + " ," + numop + ", " + montantc + "," + motantd + ", " + pv ;
                    }
                }
                else
                {

                    JournalCH = "";
                }






                // DataTable TB = classeReq.dt;

                // MessageBox.Show(journalSup);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        private void ChargementMouvementInit()
        {

            try
            {
                //string s = "SELECT  dbo.tEleve.MatriculeEleve, dbo.tEleve.NomEleve, dbo.tEleve.PostnomEleve, dbo.tEleve.PrenomEleve, dbo.tEleve.SexeEleve, dbo.tEleve.Nationalite," +
                //         "dbo.tEleve.ProvEcole, dbo.tEleve.lieuNais, dbo.tEleve.DateNais, dbo.tInscription.codeSale, dbo.tInscription.codeAnnee, dbo.tInscription.codeEcole, " +
                //        " dbo.tInscription.DateInscription, dbo.tInscription.FraisIscription, dbo.tInscription.TypeInsription" +
                //            "FROM  dbo.tEleve INNER JOIN" +
                //         "dbo.tInscription ON dbo.tEleve.MatriculeEleve = dbo.tInscription.MatriculeEleve";

                string s = "SELECT        NumOperation, NumCompte, Entree, Sortie, PR " +
" FROM            tMvtCompte" +
"  WHERE        (NumOperation = @a) ";


                string s2 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie, Vente " +
  " FROM            tMvtEmbalage " +
  "  WHERE        (NumOperation = @a) ";


                string s3 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie, Vente" +
" FROM            tMvtStock " +
"  WHERE        (NumOperation = @a) ";


                string s4 = "SELECT        NumOperation, QteEntree, QteSortie, Entree, Sortie, Vente " +
" FROM            tMvtEmbalage " +
"  WHERE        (NumOperation = @a) ";

                string[] r = { "" };
                // DateTime[] d = {tDateOP.Value }; ;
                DateTime[] d = { DateTime.Parse(tdate.Text) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);
                tableComptaSUP = classeReq.dt;

                classeReq.chargementAvecLesParametreDate(s2, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);
                TableChambre = classeReq.dt;

                classeReq.chargementAvecLesParametreDate(s3, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);
                TableStockSup = classeReq.dt;

               classeReq.chargementAvecLesParametreDate(s4, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);
                TableClienPrp = classeReq.dt;

                String COMPTE, motantd, montantc, numop, Des, pr, pv;
                journalSup = "";

                if (tableComptaSUP.Rows.Count > 0)
                {
                    for (int i = 0; i <= tableComptaSUP.Rows.Count - 1; i++)
                    {
                        COMPTE = tableComptaSUP.Rows[i]["NumCompte"].ToString();
                        numop = tableComptaSUP.Rows[i]["NumOperation"].ToString();
                        montantc = tableComptaSUP.Rows[i]["Entree"].ToString();
                        motantd = tableComptaSUP.Rows[i]["Sortie"].ToString();
                        pr = tableComptaSUP.Rows[i]["PR"].ToString();
                        journalSup = journalSup + COMPTE + "= " + " ," + numop + ", " + montantc + "," + motantd + ", " + pr;
                    }
                }
                else
                {

                    journalSup = "";
                }


                if (TableChambre.Rows.Count > 0)
                {
                    for (int i = 0; i <= tableComptaSUP.Rows.Count - 1; i++)
                    {
                        COMPTE = TableChambre.Rows[i]["NumCompte"].ToString();
                        numop = TableChambre.Rows[i]["NumOperation"].ToString();
                        motantd = TableChambre.Rows[i]["Entree"].ToString();
                        montantc = TableChambre.Rows[i]["Sortie"].ToString();
                        pv = TableChambre.Rows[i]["Sortie"].ToString();
                        JournalCH = JournalCH + COMPTE + "= " + " ," + numop + ", " + montantc + "," + motantd + ", " + pv;
                    }
                }
                else
                {

                    JournalCH = "";
                }






                // DataTable TB = classeReq.dt;

                // MessageBox.Show(journalSup);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void enregitrementEleve()
        {
            string s = "INSERT INTO tSupprimmer  ( Libelle, JournalOP,JournanStock,JournalClient,JournanChambre ,Par, DatOP, DateSup) values (@a,@b,@c,@d,@e,@f,@da,@db)";
            string[] r = { tLibelle.Text, journalSup, JournalStock, JournalCH, JournalClient, utilisateur };
            DateTime[] d = { DateTime.Parse(tdate.Text), DateTime.Now };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }




        private void SupprimerOP()
        {
            try
            {
                //   libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text;
                Connection_Data();
                con.Open();
                cmd.CommandText = "DELETE FROM tOperation  WHERE        (NumOperation = @NumOperation)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NumOperation", comboOperation.Text.Trim());

                cmd.ExecuteNonQuery();

                // lmessage.Text = " EST AJOUTE ";
                MessageBox.Show(" EST SUPPRIMME");
                //AnullerAricle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }


        private void supprressionDesElements()
        {
            try
            {

                string s = " DELETE FROM  tLibelleRistourne  WHERE NumOperation=@a";
                string s2 = " DELETE FROM  tMessage  WHERE NumOP=@a";

                string[] r = { comboOperation.Text.Trim() };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r, d);
                
                //MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

    }
}
