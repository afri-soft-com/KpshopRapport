using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.Data.SqlClient;

namespace GoldenStarApplication.FormPop
{
    public partial class FormPopPassageDate : Form
    {
        string _provenance;
        public FormPopPassageDate(string provenance)
        {
            InitializeComponent();
            this._provenance = provenance;
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        public string NumCompte;
        public Boolean BoolJournal, BoolReleve, BoolBalanceMVT, BoolBalance;
        private void FormPopPassageDate_Load(object sender, EventArgs e)
        {
           // tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
           // tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
            tlibele.Text = libeleOP;
            if (BoolBalance == true || BoolBalanceMVT == true)
            {
                cbTouteLabalance.Visible = true;
                rBSynthese.Visible = true;
            }
            else
            {
                cbTouteLabalance.Visible = false;
                rBSynthese.Visible = false;
            }
        }
        private void UpdateInit( string date2)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                string s = " UPDATE tOperation  SET NumOperation = @NumOperation, DateOp = @DateOp " +
                    "  WHERE        (NumOperation = @NumOperation) ";
                cmd.CommandText = s;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", ClassVaribleGolbal.OPinit);
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(date2));

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
        private void button4_Click(object sender, EventArgs e)
        {
            FormPassageRapport fo = new FormPassageRapport();
            fo.UpdateInit(tdateR2.Text);
            if (BoolReleve== true)
            {
                chargmentReleve();
            }
            else if (BoolJournal == true)
            {
                chargementJournal();
            
            }
            else if (BoolBalanceMVT == true)
            {
               //ChargementDecompteSommqireTous(true);


                ChargementDecompteSommqireTous(cbTouteLabalance.Checked);
         
               


               
            }
            


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


        private void chargmentReleve()
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                if (cbVerificationUsd.Checked == true)
                {
                    try
                    {
                        string codecl;
                       // int ci;
                        //ci = dGsoldeDeSrivice.CurrentRow.Index;
                        //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                        //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                        codecl = NumCompte;
                        //MessageBox.Show(codecl);
                        Connection_Data();
                        con.Open();
                        cmd.CommandText = "BraSroProRapportRelever";


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
                        string chiminRap = "Rapport/Bransimba/ReportReleverUsd.rdlc";
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

                else
                {
                    try
                    {
                        string codecl;
                        int ci;
                        //ci = dGsoldeDeSrivice.CurrentRow.Index;
                        //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                        //codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                        //MessageBox.Show(codecl);

                        codecl = NumCompte;
                        Connection_Data();
                        con.Open();

                        if (_provenance == "relever_stock")
                        {
                            cmd.CommandText = "ReleverCompteYann";

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                            //MessageBox.Show("NumCompte : " + NumCompte);
                            cmd.Parameters.AddWithValue("@NumCompte", codecl);
                            cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                            cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                            //  MessageBox.Show(codecl);
                            //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                            da.Fill(dt);
                            con.Close();

                            string chiminRap = "Rapport/Report3_Stock.rdlc";
                            FormEtat fo = new FormEtat();

                            fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                            fo.Show();
                        }
                        else
                        {
                            cmd.CommandText = "RapportReleveCompte";

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
                            string chiminRap = "Rapport/Report3.rdlc";
                            FormEtat fo = new FormEtat();

                            fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                            fo.Show();
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                        // lmessage.Text = ex.Message;

                    }

                }
                //ChargmenRappor 
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


        }
        private void chargementJournal()
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
                cmd.Parameters.AddWithValue("@DateOp1", Convert.ToDateTime(tdateR2.Text));
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

        DataTable TableRapporSommair;
        private void CharrrmentRapporSommairSerice()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportSoldeAu";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                TableRapporSommair = dt;

                //string chiminRap = "Rapport/ReportReleveCompte.rdlc";
                //FormEtat fo = new FormEtat();
                //fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                //fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }

       // DataTable TableRapporSommair;
        private void ChargementDecompteSommqireTous(Boolean BMouvement)
        {
            try
            {

                string sPro1mvt = " SELECT        NumCompte, DesignationCompte, SUM(SommeEntreeUsd) AS SommeEntreeUsd, SUM(SommeEntree) AS SommeEntree, SUM(SommeSortie) AS SommeSortie, SUM(SommeSortieUsd) AS SommeSortieUsd, " +
                       "  SUM(QteEntree) AS QteEntree, SUM(QteSortie) AS QteSortie, MAX(DateOp) AS MaxDateMVT, MIN(DateOp) AS MinDateOP, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, " +
                       "  IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, DesDebut, DesCredit " +
" FROM BraViewMouvementComptePeriode " +
" WHERE(DateOp BETWEEN @DateOp AND @DateOp2)  " +
" GROUP BY NumCompte, DesignationCompte, DesignationGroupe, Cadre, DesignationCadre, NumClasse, DesignationClasse, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site, RefCadre, GroupeCompte, " +
                       "  DesDebut, DesCredit " +
" HAVING  (SUM(SommeEntree)-SUM(SommeSortie))<>0 ";



                CharrrmentRapporSommairSerice();
                Connection_Data();
                con.Open();
                //  if ()
                if (BMouvement == true)
                {
                    cmd.CommandText = sPro1mvt;
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                }
                else
                {
                    cmd.CommandText = "RapportMouvementCompte";
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();

                }

                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@DateOp", Convert.ToDateTime(tDateR1.Text));
                cmd.Parameters.AddWithValue("@DateOp2", Convert.ToDateTime(tdateR2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                //ReportBalanceSynthes
                string chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                if (rBSynthese.Checked == true)
                {
                    chiminRap = "Rapport/ReportBalanceSynthes.rdlc";
                }
                else
                {

                    chiminRap = "Rapport/ReportSommairCompteTotal.rdlc";
                }

                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TableRapporSommair, chiminRap, "DataSet2");
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                fo.Show();
                //ReportBalanceSynthes
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }



        }
    }
}
