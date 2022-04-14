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

namespace GoldenStarApplication.FormPopVente
{
    public partial class FormPaiment : Form
    {
        public FormPaiment()
        {
            InitializeComponent();
        }
        public String utilisateur;
        public static string RefAchercher;
        private void FormPaiment_Load(object sender, EventArgs e)
        {
            chargementCombo();
           // tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
            Taux = ClassVaribleGolbal.TauxFc;
            utilisateur = ClassVaribleGolbal.UTILISATEUR;
        }

        public void  Comptabilite(Boolean b)
        {
            RbDepense.Visible = b;
            RbRavitaillement.Visible = b;

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
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        Boolean test, test2, BoolRappelDeDate;
        Double Taux;
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
            numOperation = "CO" + dernier.ToString() + ClassVaribleGolbal.UTILISATEUR.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

        private void chargementCombo()
        {
            chargementComboCompte(comboDebit, comboDebitDes);
            chargementComboCompte(comboCredit, comboCrediDES);
            tNumOP.Text = fonctionOP();
        
        }
        private void chargementComboCompte(ComboBox id, ComboBox des)
        {
            try
            {

                string sCompte = "SELECT        NumCompte, DesignationCompte FROM            tCompte     ORDER BY  NumCompte  ";

                string[] r = { ClassVaribleGolbal.CodeDepartement };
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

                PasserOerationComptable();
                AnullerOpComptable();
                ChargmentGg10DernierOP();
                tNumOP.Text = fonctionOP();
            }



        }


        DataTable JournalOP;
        private void ChargmentGg10DernierOP()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = " SELECT     TOP 2  tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
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
              // lmessage.Text = ex.Message;
            }





            //  da.Dispose();
        }

       // String LIBELEreserve, montanReseve, MotanFcRserve;
        private void AnullerOpComptable()
        {
            LIBELEreserve = tLibelle.Text;
            montanReseve = tmotant.Text;
            MotanFcRserve = tmotantFC.Text;
            tLibelle.Text = "";
            tmotant.Text = "";
            tmotantFC.Text = "";


        }



        private void PasserOerationComptable()
        {
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "" && (verifierNumbe.IsNumeric(tmotant.Text) == true))
            {

                EnrmouvemmentComptble();

            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT  ou LE MOTANT DOIT ETRE NUMERIC");
            }

        }

        private void enregOprationComptable()
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,TauxDuJour, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g, @da)";

                string[] r = { tNumOP.Text, tLibelle.Text, ClassVaribleGolbal.UTILISATEUR, "0", "0", " ", Taux.ToString() };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
                //MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void InserMvtCpte(string storage, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
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
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }
        private void EnrmouvemmentComptble()
        {
            try
            {

                //enregOprationComptable();

                // Connection_Data();
                // if (con.State != ConnectionState.Open)
                // {
                //     con.Open();
                // }
                //// FormComptable FC = new FormComptable();

                // InserMvtCpte("insererMvtcpt", comboCredit.Text, "0", tmotant.Text, "0", "0", "0", tNumOP.Text);

                // InserMvtCpte("insererMvtcpt", comboDebit.Text, tmotant.Text, "0", "0", "0", "0", tNumOP.Text);

                // Connection_Data();
                // if (con.State == ConnectionState.Open)
                // {
                //     con.Close();
                // }


                LesClasses.ClasseOperationMvt clMTop = new LesClasses.ClasseOperationMvt();
                //if (PasserOperation == false)
                {
                    clMTop.enregistraimentOP(tNumOP.Text,  tLibelle.Text , ClassVaribleGolbal.UTILISATEUR, tDate1.Value);
                    clMTop.enregistrementMouvment(tNumOP.Text, tLibelle.Text, comboDebit.Text,  tmotant.Text, "0");
                    clMTop.enregistrementMouvment(tNumOP.Text, tLibelle.Text, comboCredit.Text, "0", tmotant.Text);
                    //PasserOperation = true;
                }

          
                // ChargmentGg10DernierOP();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void CBcdf_CheckedChanged(object sender, EventArgs e)
        {

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
                cmd.CommandText = " SELECT     TOP 2  tOperation.NumOperation, tOperation.Libelle, tMvtCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie " +
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
               // lmessage.Text = ex.Message;
            }





            //  da.Dispose();
        }
        String LIBELEreserve, montanReseve, MotanFcRserve;

        private void RbRavitaillement_CheckedChanged(object sender, EventArgs e)
        {
            ErireLibele();
        }

        private void rBAutre_CheckedChanged(object sender, EventArgs e)
        {
            ErireLibele();
        }

        private void comboDebit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbDepense_CheckedChanged(object sender, EventArgs e)
        {
            ErireLibele();
        }

        //private void AnullerOpComptable()
        //{
        //    LIBELEreserve = tLibelle.Text;
        //    montanReseve = tmotant.Text;
        //    MotanFcRserve = tmotantFC.Text;
        //    tLibelle.Text = "";
        //    tmotant.Text = "";
        //    tmotantFC.Text = "";


        //}

        private void button19_Click(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboDebit.Text = ClassVaribleGolbal.RefAchercher;
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

                comboCredit.Text = ClassVaribleGolbal.RefAchercher;
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


        private void ErireLibele()
        {

            if (RbDepense.Checked == true)
            {

                tLibelle.Text = "Sorti caisse suivant BSC N";
                // pEB.Enabled = true;
                comboCredit.Text = ClasskpQuincaillerie.ComptCaisseKpQuincaillerie;
                comboDebit.Text = ClasskpQuincaillerie.ComptSuspensCaissekPQuincaillerie;
                pCredit.Enabled = false;
                paneDebut.Enabled = true;

            }

            else if (RbRavitaillement.Checked == true)
            {
                //pEB.Enabled = false;
                tLibelle.Text = "Aprovisionnement Caisse PAR ";
                comboDebit.Text = ClasskpQuincaillerie.ComptCaisseKpQuincaillerie;
                comboCredit.Text = ClasskpQuincaillerie.ComptSuspensCaissekPQuincaillerie;
                pCredit.Enabled = true;
                paneDebut.Enabled = false;
            }

            else if (rBAutre.Checked == true)
            {
               // pEB.Enabled = false;
                tLibelle.Text = "AUTRE Operation";
                pCredit.Enabled = true;
                paneDebut.Enabled = true;
            }


        }

    }
}
