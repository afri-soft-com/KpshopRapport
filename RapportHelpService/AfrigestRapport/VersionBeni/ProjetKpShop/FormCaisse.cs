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
    public partial class FormCaisse : Form
    {
        public FormCaisse()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test, BoolRappelDeDate;
        Double Taux;
        string CompteCaisse;
        public static string RefAchercher;
        private void FormCaisse_Load(object sender, EventArgs e)
        {
            CompteCaisse = CompteDEservicleint(51, 0);
            tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
            tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
            tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
            utilisateur = ClassVaribleGolbal.UTILISATEUR;
            Taux = ClassVaribleGolbal.TauxFc;
            ltaux.Text = Taux.ToString();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable Tcredi,Tdebit;
        
        private void chargementComboCompte()
        {
            try
            {

                string sEnrtreOrdinnaire = "SELECT        tCadre.Classe, tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre, tCompte.Activer " +
" FROM tCompte INNER JOIN " +
                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                         " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre " +
" WHERE(tCadre.Classe = 4) OR "  +
                " (tCadre.Classe = 5) OR " +
                "  (tCadre.Classe = 5) "  +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";



                string sEnrtreSpecie = "SELECT        tCadre.Classe, tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre, tCompte.Activer " +
" FROM tCompte INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre " +
" WHERE(tCadre.Classe <> 4) OR " +
               " (tCadre.Classe <> 5) OR " +
               "  (tCadre.Classe <> 5) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";




                string sSortieSpecial = "SELECT        tCadre.Classe, tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre, tCompte.Activer " +
" FROM tCompte INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre " +
" WHERE(tCadre.Classe <>4) OR " +
               " (tCadre.Classe <> 5) OR " +
               "  (tCadre.Classe <> 6) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";


                string sSortieORDINNARE = "SELECT        tCadre.Classe, tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre, tCompte.Activer " +
" FROM tCompte INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre " +
" WHERE(tCadre.Classe = 4) OR " +
               " (tCadre.Classe = 5) OR " +
               "  (tCadre.Classe = 6) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";




                string SCaisse = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (NumCompte = @a)";
               // cmd.CommandType = CommandType.Text;
               // cmd.Parameters.AddWithValue("@NumCompte", CompteDEservicleint(51, 1));
                string[] r = { CompteDEservicleint(51, 0) };
                string[] r3 = { ClassVaribleGolbal.GroupeService };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
               
                if (RbEntree.Checked == true)
                {
                    if (rBOrdinnaire.Checked == true)
                    {
                        classeReq.chargementAvecLesParametre(SCaisse, ClassVaribleGolbal.seteconnexion, "tOption", r);
                        classeReq2.chargementAvecLesParametre(sEnrtreOrdinnaire, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                        Tcredi = classeReq2.dt;
                        Tdebit = classeReq.dt;

                    }

                    else if (rbSpecial.Checked == true)
                    {
                        classeReq.chargementAvecLesParametre(SCaisse, ClassVaribleGolbal.seteconnexion, "tOption", r);
                        classeReq2.chargementAvecLesParametre(sEnrtreSpecie, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                        Tcredi = classeReq2.dt;
                        Tdebit = classeReq.dt;


                    }
                    //comboDebitDes.DataSource = classeReq.dt; ;
                    //comboDebit.DataSource = classeReq.dt; ;
                    //comboDebit.DisplayMember = "NumCompte";
                    //comboDebit.ValueMember = "NumCompte";
                    //comboDebitDes.ValueMember = "NumCompte";
                    //comboDebitDes.DisplayMember = "DesignationCompte";





                    ////comboCredit.DataSource = classeReq2.dt; ;
                    ////comboCrediDES.DataSource = classeReq2.dt; ;
                    ////comboCredit.DisplayMember = "NumCompte";
                    ////comboCredit.ValueMember = "NumCompte";
                    ////comboCrediDES.ValueMember = "NumCompte";
                    ////comboDebitDes.DisplayMember = "DesignationCompte";

                }
                else if (rbSortie.Checked == true)
                {

                    if (rBOrdinnaire.Checked == true)
                    {
                        classeReq.chargementAvecLesParametre(sSortieORDINNARE, ClassVaribleGolbal.seteconnexion, "tOption", r);
                        classeReq2.chargementAvecLesParametre(SCaisse, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                        Tcredi = classeReq2.dt;
                        Tdebit = classeReq.dt;


                    }

                    else if (rbSpecial.Checked == true)
                    {
                        classeReq.chargementAvecLesParametre(sSortieSpecial, ClassVaribleGolbal.seteconnexion, "tOption", r);
                        classeReq2.chargementAvecLesParametre(SCaisse, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                        Tcredi = classeReq2.dt;
                        Tdebit = classeReq.dt;

                    }







                    ////comboDebitDes.DataSource = classeReq.dt; ;
                    ////comboDebit.DataSource = classeReq.dt; ;
                    ////comboDebit.DisplayMember = "NumCompte";
                    ////comboDebit.ValueMember = "NumCompte";
                    ////comboDebitDes.ValueMember = "NumCompte";
                    ////comboDebitDes.DisplayMember = "DesignationCompte";





                    //comboCredit.DataSource = classeReq2.dt; ;
                    //comboCrediDES.DataSource = classeReq2.dt; ;
                    //comboCredit.DisplayMember = "NumCompte";
                    //comboCredit.ValueMember = "NumCompte";
                    //comboCrediDES.ValueMember = "NumCompte";
                    //comboDebitDes.DisplayMember = "DesignationCompte";

                }





             
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        
        private string CompteDEservicleint(int type, int sevice)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT NumCompte FROM tPServiceStock WHERE (Type = @a) AND (NumDeservice = @b)";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", type);
            cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            compte = cmd.ExecuteScalar().ToString();
            return compte;


            cmd.Dispose();
            con.Close();

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboDebit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeOP_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  affecherPanelNtree();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            affecherPanelNtree();
            poP.Visible = true;
            chargemeentChargmentMotif();
            chargemeentChargmentCatGorie();
           // chargementComboCompte();
        }

        private void affecherPanelNtree()
        {
            //pEntree.Visible = RbEntree.Checked;
            if (RbEntree.Checked == true)
            {
                //pSortie.Enabled = false;
                //pEntree2.Enabled = true;
               // this.lsortie.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // 
                this.pEntree2.BackColor = System.Drawing.Color.Khaki;
                this.pSortie.BackColor = System.Drawing.Color.DarkGoldenrod;
                bRecheEntre.Enabled = false;
                bRechercheSortie.Enabled = true;
                //lentre.Text = "DESTINNATION";
               // lsortie.Text = "PROVENANCE";
            }
            else if (rbSortie.Checked == true)

            {
                //pEntree2.Enabled = false;
                //pSortie.Enabled = true;
                //this.lsortie.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // 
                this.pSortie.BackColor = System.Drawing.Color.Khaki;
                this.pEntree2.BackColor = System.Drawing.Color.DarkGoldenrod;
                bRecheEntre.Enabled = true;
                bRechercheSortie.Enabled = false;

                //lentre.Text = "PROVENANCE";
                // lsortie.Text = "DESTINNATION";
            }
            if (bwChargementCombo.IsBusy == false)

            {
                bwChargementCombo.RunWorkerAsync();
            }
            else
            {
                lmessaga.Text = "PROCESSU EN COUR";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // pSortie.Visible = rbSortie.Checked;
            affecherPanelNtree();
           // chargementComboCompte();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmotant_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void rBOrdinnaire_CheckedChanged(object sender, EventArgs e)
        {
            affecherPanelNtree();
           // chargementComboCompte();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChargementCombo(Tdebit, comboDebit, comboDebitDes);
            ChargementCombo(Tcredi, comboCredit, comboCrediDES);
            //des.DataSource = Tdebit;
            //if (RbEntree.Checked== true)
            //{
            //    ChargementCombo(Tcredi, comboDebit, comboDebitDes);
            //    ChargementCombo(Tdebit, comboCredit, comboCrediDES);
            //}
            //else
            //{
            //    ChargementCombo(Tdebit, comboDebit, comboDebitDes);
            //    ChargementCombo(Tcredi, comboCredit, comboCrediDES);

            //}
            //////id.DataSource = t1;
            //id.DisplayMember = "NumCompte";
            //id.ValueMember = "NumCompte";
            //des.ValueMember = "NumCompte";
            //des.DisplayMember = "DesignationCompte";
            tNumOP.Text = fonctionOP();
        }
        private void ChargementCombo( DataTable t1, ComboBox id,ComboBox des )
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "NumCompte";
            id.ValueMember = "NumCompte";
            des.ValueMember = "NumCompte";
            des.DisplayMember = "DesignationCompte";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            chargementComboCompte();

        }


        DataTable TablAgent,TableMotif;
        private void chargemeentChargmentCatGorie()
        {
            try
            {


                string s = " SELECT       IdAgent, Noms FROM     tAgent  ORDER BY  Noms  ";
               // string s2 = " SELECT        LibelleCaisse FROM            tLibelle WHERE  Type= @a";
                
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                int IdLibelle = 1;
                if (RbEntree.Checked == true)
                {
                    IdLibelle = 1;
                }
                else
                {
                    IdLibelle = 2;
                }
                string[] r = { IdLibelle.ToString() };

                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //classeReq2.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                TablAgent = classeReq.dt;
                CombotypeOP.DataSource = TablAgent;
                CombotypeOP.DisplayMember = "Noms";
                CombotypeOP.ValueMember = "IdAgent";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void chargemeentChargmentMotif()
        {
            try
            {


                string s = " SELECT       IdMotif, DesMotif FROM            tMotif WHERE  TypeMotif= @a ORDER BY  DesMotif";
               // string s2 = " SELECT        LibelleCaisse FROM            tLibelle WHERE  Type= @a";

                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                int IdLibelle = 1;
                if (RbEntree.Checked == true)
                {
                    IdLibelle = 1;
                }
                else
                {
                    IdLibelle = 2;
                }
                string[] r = { IdLibelle.ToString() };

                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //classeReq2.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                TableMotif = classeReq.dt;
                comboMotif.DataSource = TableMotif;
                comboMotif.DisplayMember = "DesMotif";
                comboMotif.ValueMember = "IdMotif";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            if (BoolRappelDeDate == false)
            {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOULOIR PASSER   LES OPRATIONS A LA   ? \n DATE  ===  " + ClassVaribleGolbal.DateDuJOUR + "\n" +
               " TAUX  =" + Taux.ToString() + "?",
                "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    BoolRappelDeDate = true;
                }
                else
                {
                    BoolRappelDeDate = false;

                }

            }

            if (BoolRappelDeDate == true)
            {

                OperationCaisse();
            }





          
        }




        private void OperationCaisse()
        {
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "")
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                }


            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT");
            }



        }
        private void bwEnreCompte_DoWork(object sender, DoWorkEventArgs e)
        {
            EnrmouvemmentComptble();

        }
        private void EnrmouvemmentComptble()
        {
            try
            {

                enregOprationComptable();
                InserMvtCpte("insererMvtcpt", comboCredit.Text,"0" , tmotant.Text, "0", "0", "0", tNumOP.Text);
                InserMvtCpte("insererMvtcpt", comboDebit.Text, tmotant.Text, "0" ,"0","0", "0", tNumOP.Text);
                ChargmentGg10DernierOP();
                //ChargmentGg10DernierOP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        DataTable JournalOP;
        private void ChargmentGg10DernierOP()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = " SELECT     TOP 20   tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
"FROM            tCompte INNER JOIN" +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" WHERE(tOperation.DateOp = @DateOp) AND(tOperation.NomUt = @NomUt) " +
" ORDER BY tOperation.NumOpSource DESC ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));
                cmd.Parameters.AddWithValue("@NomUt", utilisateur);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                JournalOP = dt;

                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessaga.Text = ex.Message;
            }

            //  da.Dispose();
        }
        String LIBELEreserve, montanReseve, MotanFcRserve;

        private void AnullerOpComptable()
        {
            LIBELEreserve = tLibelle.Text;
            montanReseve = tmotant.Text;
            MotanFcRserve = tmotantFC.Text;
            tLibelle.Text = "";
            tmotant.Text = "";
            tmotantFC.Text = "";


        }

        private void bwEnreCompte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            DgJournal.DataSource = JournalOP;
            tNumOP.Text = fonctionOP();
            AnullerOpComptable();
            CbSereferer.Checked = false;

        }
        private string fonctionOP()
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
            numOperation = "CO" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        private void CBcdf_CheckedChanged(object sender, EventArgs e)
        {


            if (CBcdf.Checked == true)
            {
                tmotant.ReadOnly = true;
                tmotantFC.ReadOnly = false;
            }
            else
            {
                tmotant.ReadOnly = false;
                tmotantFC.ReadOnly = true;
            }
            calculerFc();

        }


        private void calculerFc()
        {

            if (CBcdf.Checked == true)
            {
                try
                {
                    tmotant.Text = ((double.Parse(tmotantFC.Text)) * Taux).ToString();
                    lMotant.Text = string.Format("{0:#,##0.00}", double.Parse(tmotant.Text));
                }
                catch
                {

                    tmotant.Text = "";
                }
            }
            else
            {
                //tmotant.Text = "";
                try
                {
                    tmotantFC.Text = ((double.Parse(tmotant.Text)) / Taux).ToString();
                    lMotant.Text = string.Format("{0:#,##0.00}", double.Parse(tmotant.Text));
                }
                catch
                {

                    tmotant.Text = "";
                }



            }


        }

        private void tmotantFC_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void CbSereferer_CheckedChanged(object sender, EventArgs e)
        {

            if (CbSereferer.Checked == true)
            {
                tLibelle.Text = LIBELEreserve;
                tmotant.Text = montanReseve;
                tmotantFC.Text = MotanFcRserve;

            }
            else
            {
                tLibelle.Text = "";
                tmotant.Text = "";
                tmotantFC.Text = "";

            }

        }

        private void button6_Click(object sender, EventArgs e)
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
                cmd.CommandText = "RapportJournalCompteTous";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDate1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDate1.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportJournal.rdlc";
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

        private void button7_Click(object sender, EventArgs e)
        {
            chargementComboCompte(comboCompteV, comboCompteVdES);
        }



        private void chargementComboCompte(ComboBox id, ComboBox des)
        {
            try
            {

                string sCompte = "SELECT        tCadre.Classe, tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre, tCompte.Activer " +
" FROM tCompte INNER JOIN " +
                        " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte INNER JOIN " +
                        " tCadre ON tGroupeCompte.Cadre = tCadre.Cadre " +
" WHERE(tCadre.Classe = 4) OR " +
               " (tCadre.Classe = 5) OR " +
               "  (tCadre.Classe = 6) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                string[] r = { "" };
                string[] r3 = { ClassVaribleGolbal.GroupeService };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);

                id.DataSource = classeReq.dt;
                des.DataSource = classeReq.dt; ;
                id.DisplayMember = "NumCompte";
                id.ValueMember = "NumCompte";
                des.ValueMember = "NumCompte";
                des.DisplayMember = "DesignationCompte";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCompteV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestDgVerificatio = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();

            }
        }

        private void bWoperationDivers_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TestDgVerificatio == true)
            {
                UpdateInit(tdateR2.Text);
                chargementDgVerfication();

            }
        }
        private void UpdateInit()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = " UPDATE tOperation  SET NumOperation = @NumOperation, DateOp = @DateOp " +
                    "  WHERE        (NumOperation = @NumOperation) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", ClassVaribleGolbal.OPinit);
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));

                cmd.ExecuteNonQuery();

                //  lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
                // MessageBox.Show(" EST AJOUTE");
                // AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }

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

        DataTable TableVerificationStock;
        Boolean TestDgVerificatio;
        private void chargementDgVerfication()
        {


            try
            {
                string sSoldesSerice = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, tCompte.GroupeCompte " +
" FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation" +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
 " HAVING(tCompte.NumCompte = @a)";



                ////                string sMouvementService = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie " +
                ////" FROM tCompte INNER JOIN " +
                ////                        " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                ////                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
                ////" WHERE(tOperation.DateOp BETWEEN @da AND @db)  " +
                ////" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
                ////" HAVING(tCompte.GroupeCompte = 411) OR " +
                ////                "  (tCompte.GroupeCompte = 412) OR " +
                ////               "   (tCompte.GroupeCompte = 571) ";
                //String s3 = "SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte=@a)";
                //" WHERE(tOperation.DateOp BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2018-01-01 00:00:00', 102))  " +
                string[] r = { comboCompteV.Text };
                string[] r3 = { comboCompteV.Text };
                //[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametre(sSoldesSerice, ClassVaribleGolbal.seteconnexion, "tOption", r);

                TableVerificationStock = classeReq.dt;


                // classeReq2.chargementAvecLesParametreDate(sMouvementService, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                //TableMouvemrntService = classeReq2.dt;
                //classeReq.chargementAvecLesParametre(s3, ClassVaribleGolbal.seteconnexion, "tOption2", r3);
                //TableComteVenteService = classeReq.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void bWoperationDivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (TestDgVerificatio == true)
            {
                dGsoldeDeSrivice.DataSource = TableVerificationStock;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
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
                    cmd.CommandText = "RapportReleveCompte";


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                    cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Report3.rdlc";
                    FormEtat fo = new FormEtat();
                    fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    fo.Show();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    // lmessage.Text = ex.Message;

                }
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

          


        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  SUPRIMMER CET OPERATION ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    string codecl;
                    //ConsommationDeproduits();
                    int ci = DgJournal.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    codecl = DgJournal["NumOperation", ci].Value.ToString();
                    //   libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text;
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "DELETE FROM tOperation  WHERE        (NumOperation = @NumOperation)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NumOperation", codecl);

                    cmd.ExecuteNonQuery();

                    // lmessage.Text = " EST AJOUTE ";
                    MessageBox.Show(" EST SUPPRIMME");
                    //AnullerAricle();
                    con.Close();
                    cmd.Dispose();
                    ChargmentGg10DernierOPPourSup();
                }

            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }





        }
        private void ChargmentGg10DernierOPPourSup()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = " SELECT     TOP 20   tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
"FROM            tCompte INNER JOIN" +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" WHERE(tOperation.DateOp = @DateOp) AND(tOperation.NomUt = @NomUt) " +
" ORDER BY tOperation.NumOpSource DESC ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));
                cmd.Parameters.AddWithValue("@NomUt", utilisateur);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                JournalOP = dt;
                DgJournal.DataSource = JournalOP;

                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;
            }





            //  da.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
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
                cmd.CommandText = "RapportJournalCompteTous";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tDateR1.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/ReportJournal.rdlc";
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

        private void button19_Click(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboDebit.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboDebit.Text = "";
                // label2.Text = "tu clicl sur cance";

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCredit.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCredit.Text = "";
                // label2.Text = "tu clicl sur cance";

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
                //con.Close();
                //cmd.Dispose();



                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    cmd.Dispose();
                }
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }
        private void enregOprationComptable()
        {
            try
            {

                string Compte, typeOP;
                
                if (RbEntree.Checked == true)
                {
                    Compte = comboCredit.Text.Trim();
                    typeOP = "1";
                }
                else
                {
                    Compte = comboDebit.Text.Trim();
                    typeOP = "2";
                }

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,CompteDebit,TauxDuJour,Motif, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g,@h,@i, @da)";



                string[] r = { tNumOP.Text, tLibelle.Text, utilisateur, "0", typeOP, CombotypeOP.Text, Compte, Taux.ToString(), comboMotif.Text };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
               // MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //affecherPanelNtree();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormPop.FormInsertion Fp = new FormPop.FormInsertion();
            Fp.BollAgent = true;
            Fp.BoollMotif = false;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargemeentChargmentCatGorie();
                //comboCredit.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                //comboCredit.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPop.FormInsertion Fp = new FormPop.FormInsertion();
            Fp.BollAgent = false;
            Fp.BoollMotif = true;



            int IdLibelle = 1;
            if (RbEntree.Checked == true)
            {
                IdLibelle = 1;
            }
            else
            {
                IdLibelle = 2;
            }

            Fp.typeMotif = IdLibelle;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                chargemeentChargmentMotif();
                
            }

            else if (Dial == DialogResult.Cancel)
            {
                //comboCredit.Text = "";
                // label2.Text = "tu clicl sur cance";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER CE AGENT   ? \n" +
                CombotypeOP.Text , 
                "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SuprimerAgent(CombotypeOP.SelectedValue.ToString());
                chargemeentChargmentCatGorie();
                //AnnalerSougroupe();
               // ChargmentDgSousOperation();
            }
        }


        private void SuprimerAgent(string element)
        {
            string Scumule = " DELETE  FROM   tAgent  WHERE IdAgent=@a ";
            string[] para = new[] { element };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }


        private void SuprimerMotif(string element)
        {
            string Scumule = " DELETE  FROM   tMotif  WHERE IdMotif=@a ";
            string[] para = new[] { element };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }

        private void button8_Click(object sender, EventArgs e)
        {


            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER CE MOTIF   ? \n" +
               comboMotif.Text,
               "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                MessageBox.Show(comboMotif.SelectedValue.ToString());
                SuprimerMotif(comboMotif.SelectedValue.ToString());
                chargemeentChargmentMotif();
                //AnnalerSougroupe();
                // ChargmentDgSousOperation();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string codecl;
                int ci;
              //  ci = dGsoldeDeSrivice.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                codecl = CompteCaisse;
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "BraSroProRapportReleverCaisseCdf";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
                cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tDate1.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/ReportReleveCaisse.rdlc";
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

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string codecl;
                int ci;
                //  ci = dGsoldeDeSrivice.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                codecl = CompteCaisse;
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "BraSroProRapportReleverCaisseCdf";

                //BraSroProRapportReleverCaisse
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/ReportReleveCaisse.rdlc";
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

        private void comboMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            tLibelle.Text = comboMotif.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            try
            {
                string codecl;
                int ci;
                //  ci = dGsoldeDeSrivice.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                codecl = CompteCaisse;
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "BraSroProRapportReleverCaisse";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
                cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tDate1.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/ReportReleveCaisseUsd.rdlc";
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

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string codecl;
                int ci;
                //  ci = dGsoldeDeSrivice.CurrentRow.Index;
                //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                codecl = CompteCaisse;
                //MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "BraSroProRapportReleverCaisse";
                //BraSroProRapportReleverCaisseCdf
                //BraSroProRapportReleverCaisse
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Bransimba/ReportReleveCaisseUsd.rdlc";
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
    }
}
