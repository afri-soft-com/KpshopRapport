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
    public partial class FormComptable : Form
    {
        public FormComptable()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test, test2, BoolRappelDeDate;
        Double Taux;
        string StockProduit="310100";
        public static string RefAchercher;
         int BoolbReleve;
        //String OPinit = "INITIAL";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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


        DataTable CbGroupe, cbSougroupe, CbCat, CbClasse, CbCadre;
        private void ChargmentGroupe(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectionGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cadre", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    CbGroupe = dt;
                    comboDesignatioGroupe.DataSource = CbGroupe;
                    comboGroupe.DataSource = CbGroupe;
                    comboDesignatioGroupe.DisplayMember = "DesignationGroupe";
                    comboGroupe.ValueMember = "GroupeCompte";

                    comboGroupe.DisplayMember = "GroupeCompte";
                    comboDesignatioGroupe.ValueMember = "GroupeCompte";

                }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void ChargmentCadre(string para)
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        Cadre, Classe, DesignationCadre FROM            tCadre" +
                    " WHERE        (Classe =@Classe) ORDER BY Classe ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Classe", para);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    CbCadre = dt;
                    // comboDesignatioGroupe.DataSource = dt;
                    // comboPosrIN.DataSource = dt;
                    //  comboPreIns.DataSource = dt;


                    comboDesCade2.DataSource = CbCadre;
                    comboCadre2.DataSource = CbCadre;
                    comboCadre.DataSource = CbCadre;
                    comboDesignatioCadre.DataSource = CbCadre;

                    comboDesCade2.DisplayMember = "DesignationCadre";
                    comboDesignatioCadre.DisplayMember = "DesignationCadre";

                    comboCadre2.ValueMember = "Cadre";
                    comboCadre.ValueMember = "Cadre";
                    comboCadre2.DisplayMember = "Cadre";
                    comboCadre.DisplayMember = "Cadre";



                    //  comboPosrIN.DisplayMember = "PostnomEleve";
                    //comboPosrIN.ValueMember = "MatriculeEleve";

                    // comboPreIns.DisplayMember = "PrenomEleve";
                    //comboPreIns.ValueMember = "MatriculeEleve";
                }

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void ChargmenTClasse()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        NumClasse, DesignationClasse " +
                    " FROM            tClasse ";
                cmd.CommandType = CommandType.Text;
                //  cmd.Parameters.AddWithValue("@Classe", );
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    CbClasse = dt;
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
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }
        private void ChargmentSouGroupe()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectSousgroupec";
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("AneeScolaire", AnneScolaire);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    cbSougroupe = dt;
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




        private void ChargmentCategorie()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectCategorieCpte";
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("AneeScolaire", AnneScolaire);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    CbCat = dt;
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tSousGroupe.Text = comboGroupe.Text + tFormationSOUS.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tSousGroupe.Text = comboGroupe.Text + tFormationSOUS.Text;

            ChargmentDgSousOperation();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tDesignationSous.Text = comboDesignatioGroupe.Text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //ChargmentGroupe();
            // ChargmentSouGroupe();
            ChargmentCategorie();
            ChargmenTClasse();
            chargemeenComboCatClient();
            //charg
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            comboType.DataSource = CbCat;
            comboType.DisplayMember = "Designation";
            comboType.ValueMember = "CategorieCompte";


            comboCateGorie.DataSource = TableComboCategorie;
            comboCateGorie.DisplayMember = "DesignationCatClient";
            comboCateGorie.ValueMember = "CategorieClient";
            // CbChambre =;

            //comboDesignatioGroupe.DataSource = CbGroupe;
            //comboGroupe.DataSource = CbGroupe;
            //comboDesignatioGroupe.DisplayMember = "DesignationGroupe";
            //comboGroupe.ValueMember = "GroupeCompte";

            //comboGroupe.DisplayMember = "GroupeCompte";
            //comboDesignatioGroupe.ValueMember = "GroupeCompte";



            comboClasse.DataSource = CbClasse;
            comboNumClasse.DataSource = CbClasse;
            comboClasse.DisplayMember = "DesignationClasse";
            comboNumClasse.DisplayMember = "NumClasse";

            comboClasse.ValueMember = "NumClasse";
            comboNumClasse.ValueMember = "NumClasse";




            comboNumClasse2.DataSource = CbClasse;
            comboDesClasse2.DataSource = CbClasse;
            comboDesClasse2.DisplayMember = "DesignationClasse";
            comboDesClasse2.ValueMember = "NumClasse";

            comboNumClasse2.DisplayMember = "NumClasse";
            comboNumClasse2.ValueMember = "NumClasse";

            //comboSousGROUPE.DataSource = cbSougroupe;
            //comboSousGroupeDes.DataSource = cbSougroupe;

            //comboSousGroupeDes.ValueMember = "NumCompte";
            //comboSousGroupeDes.DisplayMember = "DesignationCompte";

            //comboSousGROUPE.ValueMember = "NumCompte";
            //comboSousGROUPE.DisplayMember = "NumCompte";







            //ChargmentDgSousOperation();
        }

        private void tSousGroupe_TextChanged(object sender, EventArgs e)
        {

        }




        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormComptable_Load(object sender, EventArgs e)
        { try
            {

                Control.CheckForIllegalCrossThreadCalls = false;
                bWchargmentCombo.RunWorkerAsync();
                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
                tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
                utilisateur = ClassVaribleGolbal.UTILISATEUR;
                Taux = ClassVaribleGolbal.TauxFc;
                ltaux.Text = Taux.ToString();
                AficheleSolde(false);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }


        private void InsereSousGroupe()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "insertionSousGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SousGroupe", tSousGroupe.Text);
                cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupe.Text);
                cmd.Parameters.AddWithValue("@DesignationSousGoupe", tDesignationSous.Text.Trim());
                cmd.Parameters.AddWithValue("@TypeSous", comboType.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PourcentPv", tTauxVente.Text);
                // cmd.Parameters.AddWithValue("@Utulisateur", utilisateur);
                // cmd.Parameters.AddWithValue("FraisScolaireEntendu", fraisScolaire);
                // cmd.Parameters.AddWithValue("AutreFraisEntendu", autreFrais);
                cmd.ExecuteNonQuery();

                lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                // MessageBox.Show(" EST AJOUTE");
                InserMvtCpte("insererMvtcpt", tSousGroupe.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }



        private void ModificationSousGoupe()
        {
            try
            {

                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "ModificationSousGouppe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SousGroupe", tSousGroupe.Text);
                cmd.Parameters.AddWithValue("@SousGroupe2", tModifier.Text);
                cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupe.Text);
                cmd.Parameters.AddWithValue("@DesignationSousGoupe", tDesignationSous.Text.Trim());
                cmd.Parameters.AddWithValue("@TypeSous", comboType.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PourcentPv", tTauxVente.Text);
                // cmd.Parameters.AddWithValue("@Utulisateur", utilisateur);
                // cmd.Parameters.AddWithValue("FraisScolaireEntendu", fraisScolaire);
                // cmd.Parameters.AddWithValue("AutreFraisEntendu", autreFrais);
                cmd.ExecuteNonQuery();

                lmessage.Text = tSousGroupe.Text + " EST  MODIFIER ";
                // MessageBox.Show(" EST AJOUTE");
                InserMvtCpte("insererMvtcpt", tSousGroupe.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                AnnalerSougroupe();
                //  ChargmentDgSousOperation();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            {
                //  Message.Show(ex.Message);
                lmessage.Text = ex.Message;


            }

        }



        private void SupprimmeerSousGoupe()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "DeleteSousGrouppe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumCompte", tSousGroupe.Text);
                // cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupe.Text);

                cmd.ExecuteNonQuery();

                lmessage.Text = tSousGroupe.Text + " EST  SUPPRIMMER ";
                // MessageBox.Show(" EST AJOUTE");
                AnnalerSougroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }


        private void SupprimmeGroupe()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = " delete  from  tGroupeCompte  WHERE GroupeCompte =@GroupeCompte";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GroupeCompte", tmodifierGroupe2.Text);
                // cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupe.Text);

                cmd.ExecuteNonQuery();

                lmessage.Text = tmodidGroupe2DES.Text + " EST  SUPPRIMMER ";
                // MessageBox.Show(" EST A.JOUTE");
                AnnalerGroupe();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

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
        private void AnnalerSougroupe()
        {
            tDesignationSous.Text = "";
            tFormationSOUS.Text = "";
            comboType.Text = "";
            tSousGroupe.Text = "";
            tDesAmodifier.Text = "";
            tModifier.Text = "";
            tTauxVente.Text = "1";


        }


        private void AnnalerGroupe()
        {
            tDesignqtion.Text = "";
            tmodifierGroupe2.Text = "";
            tmodidGroupe2DES.Text = "";
            tGroupeAmodifer.Text = "";
            //tDesAmodifier.Text = "";
            //  tModifier.Text = "";


        }
        private void bSupprimmer_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER CE SOUS GROUPE ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SupprimmeerSousGoupe();
                AnnalerSougroupe();
                ChargmentDgSousOperation();
            }
        }




        private void bEnreSous_Click(object sender, EventArgs e)
        {
            if (tFormationSOUS.TextLength == 2 && tDesignationSous.TextLength > 5)
            {
                if (test == true)
                {
                    if (tModifier.Text.ToString().Trim() != "")
                    {
                        ModificationSousGoupe();
                    }
                    else
                    {
                        MessageBox.Show("le cham est vide ");
                    }

                }

                else
                {
                    InsereSousGroupe();


                }

                ChargmentDgSousOperation();


            }
            else
                MessageBox.Show("LE SOUS GROUPE DOIT AVOIR 5 CHIFFRE " + " LA DESIGNATION AU  MOINS  PULS DE 5 CARACTERE");

        }

        private void ModifierGroupe2()
        {
            try
            {

                string s = "UPDATE       tGroupeCompte " +
" SET Cadre = @a, GroupeCompte = @b, DesignationGroupe = @c, TypeCompte = @d  " +
" WHERE(GroupeCompte = @e) ";

                string[] r = { comboCadre.Text, tGroupeCompte.Text, tDesignqtion.Text, "0", tmodifierGroupe2.Text };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
                MessageBox.Show("ok1");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }



        private void enregistrerGroupe2()
        {
            try
            {

                string s = " INSERT INTO tGroupeCompte " +
                             "  (Cadre, GroupeCompte, DesignationGroupe, TypeCompte) " +
                  " VALUES        (@a,@b,@c,@d)";

                string[] r = { comboCadre.Text, tGroupeCompte.Text, tDesignqtion.Text, "0" };
                DateTime[] d = { DateTime.Parse(tDate1.Text) };
                MessageBox.Show(comboCadre.Text + "/" + tGroupeCompte.Text + "/" + tDesignqtion.Text);
                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
                MessageBox.Show("ok1");
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


        private void InserMvtEmballqge(string storage, string CodeClient,   string CodeEmb,  string NumOp)
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
                cmd.Parameters.AddWithValue("@Entree","0");
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
            { MessageBox.Show(ex.Message + " en ref " + NumCompte); }

        }
        private void dGsousGroupe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ci;
            ci = dGsousGroupe.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            //tSousGroupe.Text = dGsousGroupe["SousGroupe", ci].Value.ToString().Trim();
            tModifier.Text = dGsousGroupe["SousGroupe", ci].Value.ToString().Trim();
            // tSousGroupe.Text= 
        }

        private void tCompte_TextChanged(object sender, EventArgs e)
        {

            try
            {
                test2 = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tCompte ";
                s = s + " where NumCompte=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                //cmd.Parameters.AddWithValue("@a", tCompte.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    //tCompte.Text = lire["NumCompte"].ToString();
                    //tDesignationCompte.Text = lire["DesignationCompte"].ToString();
                    //tTarif.Text = lire["PrixVente"].ToString();
                    //comboSousGROUPE.SelectedValue = lire["SousGroupe"].ToString();
                    ////cbSexe.Text = lire["SexeEleve"].ToString();
                    //txtNationalite.Text = lire["Nationalite"].ToString();
                    //txtProvenance.Text = lire["ProvEcole"].ToString();
                    //cbReligieux.Text = lire["Confession"].ToString();
                    //txtLieuNais.Text = lire["lieuNais"].ToString();
                    //dateNaiss.Text = lire["DateNais"].ToString();

                    test2 = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                //bSupprimmerCompte.Enabled = test2;
                //if ((test == true))
                //{
                //    bEnregistrerCompte.Text = "&MODIFIER";

                //}
                //else
                //{

                //    //cBmodifier.Checked = false;
                //    bEnregistrerCompte.Text = "&ENREGISTRER";
                //}

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ChargmentCadre(comboCadre2.Text);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboNumClasse2_Click(object sender, EventArgs e)
        {
            ChargmentCadre(comboNumClasse2.Text);
        }

        private void comboCadre2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmentGroupe(comboCadre2.Text);

        }

        private void comboDesCade2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmentCadre(comboCadre2.Text);
        }

        private void comboNumClasse_Click(object sender, EventArgs e)
        {
            ChargmentCadre(comboNumClasse.Text);
        }

        private void comboCadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tGroupeCompte.Text = comboCadre.Text + tGroupeAmodifer.Text;
            ChargmentDgGroupe();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {



            try
            {
                test = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tCompte ";
                s = s + " where NumCompte=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tModifier.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    tSousGroupe.Text = lire["NumCompte"].ToString();
                    tDesignationSous.Text = lire["DesignationCompte"].ToString();
                    comboType.SelectedValue = lire["TypeSous"].ToString();
                    comboGroupe.Text = lire["GroupeCompte"].ToString();
                    tTauxVente.Text= lire["PourcentPv"].ToString();
                    //cbSexe.Text = lire["SexeEleve"].ToString();
                    //txtNationalite.Text = lire["Nationalite"].ToString();
                    //txtProvenance.Text = lire["ProvEcole"].ToString();
                    //cbReligieux.Text = lire["Confession"].ToString();
                    //txtLieuNais.Text = lire["lieuNais"].ToString();
                    //dateNaiss.Text = lire["DateNais"].ToString();
                    tDesAmodifier.Text = lire["DesignationCompte"].ToString();
                    test = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSupprimmer.Enabled = test;
                if ((test == true))
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
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        }

        private void comboCadre2_Click(object sender, EventArgs e)
        {
            ChargmentGroupe(comboCadre2.Text);
        }

        private void cbModiferCompte_CheckedChanged(object sender, EventArgs e)
        {
            tModifier.ReadOnly = !cbModiferCompte.Checked;
        }

        private void tGroupeAmodifer_TextChanged(object sender, EventArgs e)
        {
            tGroupeCompte.Text = comboCadre.Text + tGroupeAmodifer.Text;
        }

        private void tGroupe_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmodifierGroupe2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                test2 = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tGroupeCompte ";
                s = s + " where GroupeCompte=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tmodifierGroupe2.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    tGroupeCompte.Text = lire["GroupeCompte"].ToString();
                    tDesignqtion.Text = lire["DesignationGroupe"].ToString();
                    tmodidGroupe2DES.Text = lire["DesignationGroupe"].ToString();
                    comboCadre.SelectedValue = lire["Cadre"].ToString();
                    // comboGroupe.Text = lire["GroupeCompte"].ToString();
                    //cbSexe.Text = lire["SexeEleve"].ToString();
                    //txtNationalite.Text = lire["Nationalite"].ToString();
                    //txtProvenance.Text = lire["ProvEcole"].ToString();
                    //cbReligieux.Text = lire["Confession"].ToString();
                    //txtLieuNais.Text = lire["lieuNais"].ToString();
                    //dateNaiss.Text = lire["DateNais"].ToString();
                    // tDesAmodifier.Text = lire["DesignationCompte"].ToString();
                    test2 = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                B2supprimmerGroupe.Enabled = test2;
                if ((test2 == true))
                {
                    B2enre.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    B2enre.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }
        }

        private void B2enre_Click(object sender, EventArgs e)
        {





            if (tGroupeAmodifer.TextLength == 2 && tDesignqtion.TextLength > 5)
            {
                if (test2 == true)
                {
                    if (tmodifierGroupe2.Text.ToString().Trim() != "")
                    {
                        ModifierGroupe2();
                    }
                    else
                    {
                        MessageBox.Show("le cham est vide ");
                    }

                }

                else
                {
                    enregistrerGroupe2();


                }
                ChargmentDgGroupe();
                AnnalerGroupe();

            }
            else
                MessageBox.Show("LE SOUS GROUPE DOIT AVOIR 5 CHIFFRE " + " LA DESIGNATION AU  MOINS  PULS DE 5 CARACTERE");
        }

        private void comboNumClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmentCadre(comboNumClasse.Text);
        }

        private void DgGroupe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ci;
            ci = DgGroupe.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            //tSousGroupe.Text = dGsousGroupe["SousGroupe", ci].Value.ToString().Trim();
            tmodifierGroupe2.Text = DgGroupe["GroupeCompte", ci].Value.ToString().Trim();
            // tSousGroupe.Text= 
        }

        private void B2supprimmerGroupe_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER CE SOUS GROUPE ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                SupprimmeGroupe();
                ChargmentDgGroupe();
                AnnalerGroupe();
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tmodifierGroupe2.ReadOnly = !checkBox1.Checked;
        }

        private void dGsousGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chargementComboCompteServive();
            //enregOPaffectation();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboSousGROUPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmentDgCompte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboCompteAffec.Text.Trim() !="")
                {
                try
                {
                    enregOPaffectation();
                    chargementdgAFF();
                  //  enregOPaffectation();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

           
        }

        private void comboServiceAffecte_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {

                // chargementComboCompteServive();
                chargementdgAFF();
            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
        DataTable TableTousLesCompteDugroupe;
        private void ChargmentDgSousOperation()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectSousGroupe";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupe.Text.Trim());
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                TableTousLesCompteDugroupe = dt;
                dGsousGroupe.DataSource = dt;
               
                // }

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message; }

            //  da.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chargementComboCompte(comboDebit, comboDebitDes);
            chargementComboCompte(comboCredit, comboCrediDES);
             tNumOP.Text = fonctionOP();
            //.Show(fonctionOP());
                }

        private void comboCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChargmentDgGroupe()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        GroupeCompte, DesignationGroupe, TypeCompte FROM            tGroupeCompte WHERE        (Cadre =@Cadre)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Cadre", comboCadre.Text.Trim());
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                DgGroupe.DataSource = dt;

                // }

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
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
                cmd.Parameters.AddWithValue("@DateOp",DateTime.Parse(tDate1.Text) );
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
                lmessage.Text = ex.Message;
            }





            //  da.Dispose();
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
                lmessage.Text = ex.Message;
            }





            //  da.Dispose();
        }
        String LIBELEreserve, montanReseve,MotanFcRserve;
        
         private void AnullerOpComptable()
        {
            LIBELEreserve = tLibelle.Text;
            montanReseve = tmotant.Text;
            MotanFcRserve = tmotantFC.Text;
            tLibelle.Text= "";
            tmotant.Text = "";
            tmotantFC.Text="";


        }




        private void typeOP_TextChanged(object sender, EventArgs e)
        {

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

            if (BoolRappelDeDate== true)
            {

                PasserOerationComptable();
            }



           
        }
         
        private void PasserOerationComptable()
        {
            if (tLibelle.TextLength > 10 && tNumOP.Text.Trim() != "" && (verifierNumbe.IsNumeric(tmotant.Text) == true))
            {
                if (bwEnreCompte.IsBusy == false)
                {
                    bwEnreCompte.RunWorkerAsync();
                }


            }
            else
            {
                MessageBox.Show("LIBELE EST INSUFFISANT  ou LE MOTANT DOIT ETRE NUMERIC");
            }

        }
        private void ChargmentDgCompte()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SelectCompte";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@SousGroupe", comboSousGROUPE.Text);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                //dGCompte.DataSource = dt;

                // }

            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;
            }

            //  da.Dispose();
        }



        private void chargementComboCompteServive()
        {
            try
            {
                string stype = " SELECT        IdTypeParmatre, Designation FROM            tTyParametreCompte";
                string sCompte = "SELECT        NumCompte, DesignationCompte FROM            tCompte";
                String service = "SELECT        IdService, DesignationService FROM            tService ";

                string[] r = { "" };
                string[] r3 = { ClassVaribleGolbal.GroupeService };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);

                comboCompteAffec.DataSource = classeReq.dt; 
                comboCompteAffecDes.DataSource = classeReq.dt; ;
                comboCompteAffec.DisplayMember = "NumCompte";
                comboCompteAffec.ValueMember = "NumCompte";
                comboCompteAffecDes.DisplayMember = "DesignationCompte";

                classeReq.chargementAvecLesParametre(service, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                comboServiceAffecte.DataSource = classeReq.dt;

                comboServiceAffecte.DisplayMember = "DesignationService";
                comboServiceAffecte.ValueMember = "IdService";

                classeReq.chargementAvecLesParametre(stype, ClassVaribleGolbal.seteconnexion, "tOption2", r3);
                comboTypOPeration.DataSource = classeReq.dt;

                comboTypOPeration.DisplayMember = "Designation";
                comboTypOPeration.ValueMember = "IdTypeParmatre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }



        private void chargementComboCompte( ComboBox id ,ComboBox des)
        {
            try
            {
              
                string sCompte = "SELECT        NumCompte, DesignationCompte FROM            tCompte  ORDER BY  NumCompte ";
                
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

        private void chargementdgAFF()
        {
            try
            {
                string stype = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tTyParametreCompte.Designation " +
" FROM            tPServiceStock INNER JOIN " +
                        " tService ON tPServiceStock.NumDeservice = tService.IdService INNER JOIN " +
                        " tCompte ON tPServiceStock.NumCompte = tCompte.NumCompte INNER JOIN " +
                         "tTyParametreCompte ON tPServiceStock.Type = tTyParametreCompte.IdTypeParmatre " +
" WHERE        (tService.IdService = @a) ";
               
                string[] r = {comboServiceAffecte.SelectedValue.ToString() };
                string[] r3 = { ClassVaribleGolbal.GroupeService };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(stype, ClassVaribleGolbal.seteconnexion, "tOption", r);

                DGaffectaion.DataSource = classeReq.dt;
               // comboCompteAffecDes.DataSource = classeReq.dt; ;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tNumOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBcdf_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcdf.Checked ==true)
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
         private void  calculerFc()
        {
            if (CBcdf.Checked==true)
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

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            tLibelle.Text = typeOP.Text + " SUIVANT ";


                }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dGsoldeDeSrivice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCrediDES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            ChargementDatagrideSolde();


        }
         private void ChargementDatagrideSolde()
        {

            TestDgVerificatio = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
           // chargementComboCompte(comboCompteV, comboCompteVdES);
        }

        private void tmotant_TextChanged(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSereferer.Checked ==true)
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

        private void button13_Click(object sender, EventArgs e)
        {
           

            if (tDateR1.Value <= tdateR2.Value)
            {
                if (cbVerificationUsd.Checked == true)
                {
                    try
                    {
                        string codecl;
                        int ci;
                        ci = dGsoldeDeSrivice.CurrentRow.Index;
                        //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                        codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
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
                        ci = dGsoldeDeSrivice.CurrentRow.Index;
                        //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
                        codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
                        //MessageBox.Show(codecl);
                        Connection_Data();
                        con.Open();
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

        private void bWoperationDivers_DoWork(object sender, DoWorkEventArgs e)
        {
             if(TestDgVerificatio==true)
                {
                UpdateInit(tdateR2.Text);
                chargementDgVerfication();

            }
        }

        private void bwEnreCompte_DoWork(object sender, DoWorkEventArgs e)
        {
           
                    EnrmouvemmentComptble();

                
                
                
               
           
           
        }

        private void bWoperationDivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             if (TestDgVerificatio == true)
            {
                dGsoldeDeSrivice.DataSource = TableVerificationStock;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

           try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate("");
                Fp.Text = this.Text;
                Fp.BoolJournal = true;
               
                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {
                   

                }

                else if (Dial == DialogResult.Cancel)
                {

                   // comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;
                    //ChargementDatagrideSolde();


                    // comboCompteV.Text = "";
                    // label2.Text = "tu clicl sur cance";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboDebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tDateR1_ValueChanged(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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



        private void ChargmenRapporReledeFactureClient()
        {
            try
            {


                string codecl;
                int ci;
                ci = dGsoldeDeSrivice.CurrentRow.Index;
               
                codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString().Trim();
             

                DataTable Tmouvment;// TstockAu;

                string sPro1 = "BraStoProRapportReleverFactureClientSanZero";
               // string sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro2 = "BraStoProRapportSoldeStockAuTous";
                //BraStoProRapportReleverFactureClientSanZero



                string[] r = { codecl };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                // TstockAu = classeReq2.dt;
                //ReportEssai

               // string chiminRap = "Rapport/Bransimba/ReportEssai.rdlc";
              string chiminRap = "Rapport/Bransimba/ReportReleveFactureClient.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }


        private void ChargmenRapporVenteDeclientParProdiut( string chiminRap, string sPro1)
        {
            try
            {


                string codecl;
                int ci;
                ci = dGsoldeDeSrivice.CurrentRow.Index;

                codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();


                DataTable Tmouvment;// TstockAu;

                // sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro2 = "BraStoProRapportSoldeStockAuTous";




                string[] r = { codecl };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                //ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                Tmouvment = classeReq.dt;

                // classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                // TstockAu = classeReq2.dt;

               // string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(Tmouvment, chiminRap, "DataSet1");
                //fo.chargemenentRapporteAveVDataSetPro(TstockAu, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }
        private void button9_Click(object sender, EventArgs e)
        {

            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                ChargmenRapporReledeFactureClient();
            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }


        }

        private void button15_Click(object sender, EventArgs e)
        {


            try
            {
              
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportListeDecompte";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                //cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
               // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
                
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportListeDecompte.rdlc";
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

        public void AFFICHERplan()
        {

            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportListeDecompte";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                //cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportListeDecompte.rdlc";
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

        private void button10_Click(object sender, EventArgs e)
        {
            FormPop.FormPopClient1 fp = new FormPop.FormPopClient1();
            fp.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chargementComboCompte(comboCompteV, comboCompteVdES);
            ChargementComboVeri();
        }

        Boolean boolChaegmentClient;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChargementComboVeri();

        }
         private void ChargementComboVeri ()

        {

          pCompte.Enabled =  rbTousLeCompte.Checked;
            PanelClient.Enabled = rbClients.Checked;
            bRecherche.Enabled = rbClients.Checked;
            boolChaegmentClient = rbClients.Checked;
            bModifierFact.Enabled = rbClients.Checked;
            if (bWchargmentClient.IsBusy == false)
            {
                bWchargmentClient.RunWorkerAsync();
            }

        }
        DataTable TableMatricule, TableComboCategorie;



        private void chargemeenComboCatClient()
        {
            try
            {


                string s = "SELECT        CategorieClient, DesignationCatClient, Autres " +
 " FROM            tCategorieCleint ";



                ClassRequette classeReq = new ClassRequette();
                //tDernierMat.Text
                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableComboCategorie = classeReq.dt;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void chargemeentClient()
        {
            try
            {
                string Sclient = " SELECT        Matricule, IdClient, Noms, Localite, Telephone1, Telephone2, Email, Adresse, Adresse2 " +
                    " FROM            tInformationClient " +
                    " ORDER BY Matricule ";

                
                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };
                if (rbClients.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(Sclient, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                }




                TableMatricule = classeReq.dt;

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bWchargmentClient_DoWork(object sender, DoWorkEventArgs e)
        {
            if (boolChaegmentClient == true)
            {
                chargemeentClient();
            }

        }

        private void bWchargmentClient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             if  ( boolChaegmentClient == true)
            {

                comboMatriculeClients.DataSource = TableMatricule;
                comboMatriculeClients.DisplayMember = "Matricule";
                comboMatriculeClients.ValueMember = "Matricule";

                comboNomsCilents.DataSource = TableMatricule;
                comboNomsCilents.DisplayMember = "Noms";
                comboNomsCilents.ValueMember = "Matricule";
            }
        }

        private void comboCompteVdES_Click(object sender, EventArgs e)
        {
            ChargementDatagrideSolde();
        }

        private void comboMatriculeClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementDatagrideSolde();
        }

        private void comboNomsCilents_Click(object sender, EventArgs e)
        {
            ChargementDatagrideSolde();
        }

        private void bRecherche_Click(object sender, EventArgs e)
        {
            FormRecherche Fp = new FormRecherche();
            Fp.Text = this.Text;
         
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboMatriculeClients.Text = ClassVaribleGolbal. RefAchercher;
              
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboMatriculeClients.Text = "";
                // label2.Text = "tu clicl sur cance";

            }



        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();
                string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                string sPro1 = "BraStoProRapportReleverFactureClient";
                ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);
        
                }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourne.rdlc";
                string sPro1 = "BraStoProRapportReleverFactureClient";
                ChargmenRapporVenteDeclientParProdiut(chiminRap,sPro1);

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ReportReportReleverRestourneDetail.rdlc
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourneDetail.rdlc";
                string sPro1 = "BraStoProRapportReleverFactureClient";
                ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                // string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourne.rdlc";
                // string sPro1 = "BraStoProRapportReleverFactureClientPourTous";
                //ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

                try
                {
                    //string codecl;

                    // ci = DgMouvementService.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                    //MessageBox.Show(codecl);
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = "BraStoProRapportReleverFactureClientPourTous";
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    //  cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourne.rdlc"; 
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
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void tDate1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (comboCompteAffec.Text.Trim() != "")
            {
                try
                {

                    DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMMER CE SOUS GROUPE ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RES == DialogResult.Yes)
                    {
                        SupprimerOPaffectation();
                        chargementdgAFF();

                    }
                       
                    // enregOPaffectation();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void EnrmouvemmentComptble()
        {try
            {

                enregOprationComptable();

                Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                InserMvtCpte("insererMvtcpt", comboCredit.Text, "0", tmotant.Text, "0", "0", "0", tNumOP.Text);
                InserMvtCpte("insererMvtcpt", comboDebit.Text, tmotant.Text, "0", "0", "0", "0", tNumOP.Text);

                Connection_Data();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                ChargmentGg10DernierOP();
               
                //ChargmentGg10DernierOP();
            }
 catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
  

        }

        private void button17_Click(object sender, EventArgs e)
        {

            PasserLesInitiauxDugroupe();

        }
        private void PasserLesInitiauxDugroupe()
        {
            


            //ChargmenTbletousleARTICLE();
            String compte;// CodeChambre, CompteClien, CompteChambre, Tarrif;
           // String PrixVente, Critique, UiniteEnDetaille;
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

           // PbNuite.Maximum = TableTousLesAricle.Rows.Count - 1;
            for (int i = 0; i <= TableTousLesCompteDugroupe.Rows.Count - 1; i++)
            {
                //bwEnreNuitte.ReportProgress(i);
                compte = TableTousLesCompteDugroupe.Rows[i]["NumCompte"].ToString();

                //InserMvtCpteStock("inserertMvtStock", codeAricle, CodeDepotApasser, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte("insererMvtcpt", compte, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);




                
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


       
        private void comboDebitDes_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button21_Click(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            Fp.GroupeSpecique = false;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCompteV.Text = RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCompteV.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //ReportReportReleverRestourneSynthese


            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                // string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourne.rdlc";
                // string sPro1 = "BraStoProRapportReleverFactureClientPourTous";
                //ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

                try
                {
                    //string codecl;

                    // ci = DgMouvementService.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                    //MessageBox.Show(codecl);

                    String ptocedure = "BraStoProRapportReleverFactureClientPourTous";
                    if (CbgroupeClient.Checked == true)
                    {
                        ptocedure = "BraStoProRapportReleverFactureClientPourTousParVille";
                    }
                    else
                    {
                        ptocedure = "BraStoProRapportReleverFactureClientPourTous";
                    }
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = ptocedure;
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    if (CbgroupeClient.Checked == true)
                    {
                     cmd.Parameters.AddWithValue("@b", comboCateGorie.SelectedValue.ToString());
                    }
                     
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourneSynthese.rdlc";
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
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }


        private void ChargmenRapporRestourneSyuntheseComptabilite(string chiminRap, string sPro1, string sPro2)
        {
            try
            {


               // string codecl;
                //int ci;
               // ci = dGsoldeDeSrivice.CurrentRow.Index;

               // codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();


                DataTable TrestourneStok, TRestouCompte;

                // sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro1 = "BraStoProRapportReleverFactureClient";
                //string sPro2 = "BraStoProRapportSoldeStockAuTous";




                string[] r = { "4102" };
                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                TrestourneStok = classeReq.dt;

                 classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption3", r, d);
                TRestouCompte = classeReq2.dt;

                // string chiminRap = "Rapport/Bransimba/ReportVenteProduiParClients.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(TrestourneStok, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(TRestouCompte, chiminRap, "DataSet2");
                fo.Show();





            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }


            //  da.Dispose();
        }
        private void button18_Click(object sender, EventArgs e)
        {

        }


        private void CreerleCompteCrediEMB()
        {



            //ChargmenTbletousleARTICLE();
            String compte, DesCompte,Matrcicule,Nom;// CodeChambre, CompteClien, CompteChambre, Tarrif;
                          // String PrixVente, Critique, UiniteEnDetaille;
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            ClassRequette req = new ClassRequette();
            // PbNuite.Maximum = TableTousLesAricle.Rows.Count - 1;
            for (int i = 0; i <= TableMatriculeClient.Rows.Count - 1; i++)
            {
                //bwEnreNuitte.ReportProgress(i);
                Matrcicule = TableMatriculeClient.Rows[i]["Matricule"].ToString();
                Nom = TableMatriculeClient.Rows[i]["Noms"].ToString();
                compte = (int.Parse(GroupeCreditEmb) * 1000 + int.Parse(Matrcicule)).ToString();
                DesCompte = "CREDIT EMBALLAGE " + Nom.Trim();
                //InserMvtCpteStock("inserertMvtStock", codeAricle, CodeDepotApasser, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);


                string sCompte = " INSERT INTO tCompte " +
                         "    (NumCompte, Matricule, GroupeCompte, DesignationCompte, TypeSous, Unite, CreerPar, PourcentPv) " +
                         " VALUES        (@a,@b,@c,@d,@e,@f,@g,@h) "
                         ;

                string[] rCredit = { compte, Matrcicule, GroupeCreditEmb, DesCompte, "2", "1", utilisateur, "0" };

                DateTime[] d = { DateTime.Now };

                try
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sCompte, rCredit, d);
                    InserMvtCpte("insererMvtcpt", compte, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                    


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message +  "" + Matrcicule + "" + Nom );

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



        private void CreerleCompteCrediEMBMouvment()
        {



            //ChargmenTbletousleARTICLE();
            String compte, DesCompte, Matrcicule, Nom,CodeEmb;// CodeChambre, CompteClien, CompteChambre, Tarrif;
                                                      // String PrixVente, Critique, UiniteEnDetaille;
            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            ClassRequette req = new ClassRequette();
            // PbNuite.Maximum = TableTousLesAricle.Rows.Count - 1;

            for (int i = 0; i <= TableMatriculeClient.Rows.Count - 1; i++)
            {
                 Matrcicule = TableMatriculeClient.Rows[i]["Matricule"].ToString();
                Nom = TableMatriculeClient.Rows[i]["Noms"].ToString();
                compte = (9 * 1000 + int.Parse(Matrcicule)).ToString();
                DesCompte = "CPT EMB  " + Nom.Trim();
                //InserMvtCpteStock("inserertMvtStock", codeAricle, CodeDepotApasser, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);


                string s = " INSERT INTO tClientEmb " +
                      "  (CodeClient, CatClientEmbal, Matricule, Cleint, Creerpar, DateCreation) " +
" VALUES(@a, @b, @C, @d, @e, @da) ";

                string[] rCredit = { compte, "2", Matrcicule, DesCompte, utilisateur, };

                DateTime[] d = { DateTime.Now };

                try
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, rCredit, d);
                    //  InserMvtCpte("insererMvtcpt", compte, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                  //  InserMvtEmballqge("inserertMvtEmballage", compte, CodeEmb, ClassVaribleGolbal.OPinit);


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "" + Matrcicule + "" + Nom + " ");

                }





                for (int j = 0; j <= TableAmballage.Rows.Count - 1; j++)
                {



                    //bwEnreNuitte.ReportProgress(i);
                CodeEmb= TableAmballage.Rows[j]["CodeArticle"].ToString();
               



              //  string[] rCredit = { compte, "2", Matrcicule, DesCompte,  utilisateur, };

              //  DateTime[] d = { DateTime.Now };

                try
                {
                    //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, rCredit, d);
                        //  InserMvtCpte("insererMvtcpt", compte, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                        InserMvtEmballqge("inserertMvtEmballage", compte, CodeEmb, ClassVaribleGolbal.OPinit);


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "" + Matrcicule + "" + Nom  + " " + CodeEmb);

                }

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
        private String GroupeCreditEmb;
        private void button24_Click(object sender, EventArgs e)
        {
            chargemeentDgCompte();
            GroupeCreditEmb = GroudeCompteselonIndicateur(413);
            CreerleCompteCrediEMB();
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

        DataTable TableMatriculeClient;
        private void chargemeentDgCompte()
        {
            try
            {


                string s = "SELECT        IdClient, Matricule, Noms " +
                    " FROM            tInformationClient ";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                TableMatriculeClient = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void bModifierFact_Click(object sender, EventArgs e)
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

                PasserLesOperationRestourne();
            }


           

        }


        private void  PasserLesOperationRestourne ()
        {
            try
            {
                FormPop.FormPasserLecriture Fp = new FormPop.FormPasserLecriture();
                Fp.Text = this.Text;
                Fp.utilisateur = this.utilisateur;

                Fp.Matricule = comboMatriculeClients.SelectedValue.ToString();
                Fp.date2 = tdateR2.Value;
                Fp.date1 = tDateR1.Value;

                // Fp.nomAchercher = comboPostNomCas.Text.Trim();
                //OK

                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {
                    //comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;
                    ChargementDatagrideSolde();

                    //comboCompteV.Text = RefAchercher;
                    //label2.Text = "tu clicl sur ok";
                    // chargemeenDGFacturationSerice();
                    //dgFacturation.DataSource = TableFacturation;
                    // tSommeFact.Text = SommeFact.ToString();


                }

                else if (Dial == DialogResult.Cancel)
                {

                    comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;
                    ChargementDatagrideSolde();


                    // comboCompteV.Text = "";
                    // label2.Text = "tu clicl sur cance";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void tmotant_TextChanged_1(object sender, EventArgs e)
        {
            calculerFc();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            chargemeentDgCompte();
            chargemeentDgEmballage();
            // GroupeCreditEmb = GroudeCompteselonIndicateur(413);
            // CreerleCompteCrediEMB();
            CreerleCompteCrediEMBMouvment();
        }

        private void tmotant_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tmotant.Text = string.Format("{0:#,##0.00}", double.Parse(tmotant.Text));
            //}
            // catch
            //{

            //}
           
        }

        private void tmotant_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    lMotant.Text = string.Format("{0:#,##0.00}", double.Parse(tmotant.Text));
            //}
            //catch
            //{

            //}

        }

        private void CbgroupeClient_CheckedChanged(object sender, EventArgs e)
        {
            comboCateGorie.Visible = CbgroupeClient.Checked;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            //ReportReportReleverRestourneDetail.rdlc
            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                string chiminRap = "Rapport/Bransimba/ReportReleverRestourneMvtCpte.rdlc";
                string sPro1 = "BraStoProRapportReleverFactureClientPourTous";
                //string sPro1 = "BraStoProRapportReleverFactureClientPourTousSansMvt";
                string sPro2 = "BraStroProRapportMvtDeCompteGroupe";
                ChargmenRapporRestourneSyuntheseComptabilite(chiminRap, sPro1, sPro2);

            }
            else
            {
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void bwEnreCompte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            ClasseSMS clSMS = new ClasseSMS();

            if (comboDebit.Text.StartsWith("4102") == true && ClassVaribleGolbal.ModeSms == true)
            {
                //MessageBox.Show(MontanTotalSms.ToString());
                clSMS.VerificationDesituationCompte(comboDebit.Text, tmotant.Text, " est debite de ", " OP:" + tNumOP.Text + " /En raison de " + tLibelle.Text, tNumOP.Text, "");
                smsdirecAvecTH(tNumOP.Text);
            }
             else if ((comboCredit.Text.StartsWith("4102") == true) && ClassVaribleGolbal.ModeSms == true)
            {

                clSMS.VerificationDesituationCompte(comboCredit.Text, tmotant.Text, " est Credite de ", " OP:" + tNumOP.Text + " /En raison de " + tLibelle.Text, tNumOP.Text, "");
                smsdirecAvecTH(tNumOP.Text);
            }

            DgJournal.DataSource = JournalOP;
            tNumOP.Text = fonctionOP();
            ChargementProceduerSoldeCompte();
             AnullerOpComptable();
            CbSereferer.Checked = false;

         

        }
        private void smsdirecAvecTH(string numOpreation)
        {
            ClasseSMS fo = new ClasseSMS();
            System.Threading.Thread Thread1 = new System.Threading.Thread(fo.ChargementPouEnvoiyerDIRECT);
            fo.op = numOpreation;
            Thread1.Start();
            // Thread1.Join()
            //fo.Dispose();
        }
        private void enregOPaffectation()
        {
            string s = "INSERT INTO tPServiceStock" +
      " (NumCompte, NumDeservice, Type)VALUES        (@a,@b,@c)";
            string[] r = { comboCompteAffec.Text, comboServiceAffecte.SelectedValue.ToString(), comboTypOPeration.SelectedValue.ToString() };
            DateTime[] d = { DateTime.Parse(tDate1.Text) };
            
            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //AnnulerDepensePlan();()
            //  lmessage.Text = "&  DEPENSE AJOUTEE &";
            //bWchagementVehicule.RunWorkerAsync();
            //chargemeentDgPlanDepenses();




        }


        private void SupprimerOPaffectation()
        {
            string s = " DELETE FROM tPServiceStock " +
      "  WHERE NumCompte =@a ";
            string[] r = { comboCompteAffec.Text};
            DateTime[] d = { DateTime.Parse(tDate1.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
           



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


        private string fonctioDernierSms()
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = "SELECT        MAX(IdMessage) AS DernierOp FROM            tMessage";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString());
            numOperation = "SMS" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }
        private void button27_Click(object sender, EventArgs e)


        {

            string codecl;
            int ci;
            ci = dGsoldeDeSrivice.CurrentRow.Index;
            //codecl = dGsoldeDeSrivice[ci]["NumCompte"].ToString();
            codecl = dGsoldeDeSrivice["NumCompte", ci].Value.ToString();
             if (codecl.StartsWith("4102") == true)
            {

                tNomSMS.Text = fonctioDernierSms();
                ClasseSMS clSMS = new ClasseSMS();
                clSMS.VerificationDesituationCompteSolde(codecl, tmotant.Text, " est debite de ", " Merci Pour Vtre FidelitE", tNomSMS.Text, "");
                smsdirecAvecTH(tNomSMS.Text);
            }
             else
            {
                MessageBox.Show(" uniquement le compte Restourne ");
            }
           
        }

        private void comboCateGorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {


            if (tDateR1.Value <= tdateR2.Value)
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
                    cmd.CommandText = "BraStoProRapportReleverRistourneZero";


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportAyantRestourneZERO.rdlc";
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
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void button29_Click(object sender, EventArgs e)
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
                        " tCategorieCleint ON tInformationClient.CategorieClient = tCategorieCleint.CategorieClient " ;


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

        //String NumoperationComp, libleOP,
        private void enregOprationComptable()
        {
            try
            {
                 
                string s = " INSERT INTO tOperation " +
                             "  (NumOperation, Libelle, NomUt, Compte,TypeOp,BeneFiciare,TauxDuJour, DateOp) " +
                  " VALUES(@a, @b, @c, @d,@e,@f,@g, @da)";

                string[] r = { tNumOP.Text, tLibelle.Text, utilisateur, "0", "0", " ",Taux.ToString() };
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

        private void bWapercuSolde_DoWork(object sender, DoWorkEventArgs e)
        {
            chercherleSolde(comboDebit.Text, comboCredit.Text,tDate1.Text);
        }

        private double SoldeCompteDebut, SoldeComptCredit;
        private void chercherleSolde(string CompteDebit, string CompteCredi,String Date1)
        {
            try
            {


                string s = "SELECT        SUM(tMvtCompte.Entree)- SUM(tMvtCompte.Sortie) AS SSoldeCompte  " +
" FROM            tOperation INNER JOIN " +
                         " tMvtCompte ON tOperation.NumOperation = tMvtCompte.NumOperation " +
" WHERE        (tOperation.DateOp BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND @db) " +
" GROUP BY tMvtCompte.NumCompte " +
" HAVING        (tMvtCompte.NumCompte = @a) ";

                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReqCre = new ClassRequette();

                string[] r = { CompteDebit };
                string[] rCred = { CompteCredi };
                // MessageBox.Show(CompteDebit, CompteCredi);
                DateTime[] d = { DateTime.Parse(Date1), DateTime.Parse(Date1) };
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);
                classeReqCre.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", rCred, d);



                // FicheDechargement = classeReq.dt;

                DataTable TB = classeReq.dt;
                DataTable TBCre = classeReqCre.dt;
                // Double motant, MontanVente, QteSortie, SomRestou;

                //SSVente, SSommeVente, SQteSortieVente, PourcentPv;
                {
                    SoldeCompteDebut = Double.Parse(TB.Rows[0]["SSoldeCompte"].ToString());
                    SoldeComptCredit = Double.Parse(TBCre.Rows[0]["SSoldeCompte"].ToString());
                    // SSommeVente = Double.Parse(TB.Rows[0]["SSommeVente"].ToString());
                    // SQteSortieVente = Double.Parse(TB.Rows[0]["SQteSortieVente"].ToString());
                    // PourcentPv = Double.Parse(TB.Rows[0]["PourcentPv"].ToString());

                }



            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }



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

                string sClients = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, tCompte.GroupeCompte, tCompte.Matricule " +
" FROM tCompte INNER JOIN " +
                         " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, tCompte.Matricule " +
" HAVING(tCompte.Matricule = @a)";


              
                string[] r = { comboCompteV.Text };
                string[] r2 = { comboMatriculeClients.Text };
                //[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                if (rbTousLeCompte.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(sSoldesSerice, ClassVaribleGolbal.seteconnexion, "tOption", r);
                    TableVerificationStock = classeReq.dt;
                }
                else if ( rbClients .Checked == true)
                {

                    classeReq.chargementAvecLesParametre(sClients, ClassVaribleGolbal.seteconnexion, "tOption", r2);
                    TableVerificationStock = classeReq.dt;
                }

               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void tDesignqtion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            //ReportReportReleverRestourneSynthese


            if (tDateR1.Value <= tdateR2.Value)
            {
                UpdateInit(tdateR2.Text);

                // ChargmenRapporReledeFactureClient();

                // string chiminRap = "Rapport/Bransimba/ReportReportReleverRestourne.rdlc";
                // string sPro1 = "BraStoProRapportReleverFactureClientPourTous";
                //ChargmenRapporVenteDeclientParProdiut(chiminRap, sPro1);

                try
                {
                    //string codecl;

                    // ci = DgMouvementService.CurrentRow.Index;
                    //codecl = DgPaiement[ir]["CompteClient"].ToString();
                    // codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                    //MessageBox.Show(codecl);

                    String ptocedure = "BraStoProRapportReleverFactureClientPourTous";
                    if (CbgroupeClient.Checked == true)
                    {
                       
                        ptocedure = "BraStoProRapportReleverFactureClientPourTousParVille";
                    }
                    else
                    {
                        ptocedure = "BraStoProRapportReleverFactureClientPourTous";
                    }
                    Connection_Data();
                    con.Open();
                    cmd.CommandText = ptocedure;
                    cmd.CommandTimeout = 0;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                    if (CbgroupeClient.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@b", comboCateGorie.SelectedValue.ToString());
                        
                    }
                    //cmd.Parameters.AddWithValue("@c", StockProduit);
                    cmd.Parameters.AddWithValue("@da", Convert.ToDateTime(tDateR1.Text));
                    cmd.Parameters.AddWithValue("@db", Convert.ToDateTime(tdateR2.Text));
                    //  MessageBox.Show(codecl);
                    //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                    da.Fill(dt);
                    con.Close();
                    string chiminRap = "Rapport/Bransimba/ReportRestourneAimprimer.rdlc";
                    if (cBparVente.Checked == true)
                    {
                        chiminRap = "Rapport/Bransimba/ReportRestourneAimprimer2.rdlc";
                    }
                    else
                    {
                        chiminRap = "Rapport/Bransimba/ReportRestourneAimprimer.rdlc";
                    }
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
                MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            }

        }

        private void ChargementProceduerSoldeCompte()
        {
            if (CbApercuSolde.Checked == true)
            {
                if (bWapercuSolde.IsBusy == false)
                {
                    bWapercuSolde.RunWorkerAsync();
                }

            }
        }
        private void comboDebit_Click(object sender, EventArgs e)
        {
            BoolbReleve = 1;
            bReleveCpt.Text = "RLV DE :" + comboDebit.Text;

            ChargementProceduerSoldeCompte();

        }

        private void comboDebitDes_Click(object sender, EventArgs e)
        {
            BoolbReleve = 1;
            bReleveCpt.Text = "RLV DE : " + comboDebitDes.Text;
            ChargementProceduerSoldeCompte();
        }

        private void comboCredit_Click(object sender, EventArgs e)
        {
            BoolbReleve = 2;
            bReleveCpt.Text = "RLV DE : " + comboCredit.Text;

          ChargementProceduerSoldeCompte();

           
        }

        private void comboCrediDES_Click(object sender, EventArgs e)
        {
            BoolbReleve = 2;
            bReleveCpt.Text = "RLV DE : " + comboCrediDES.Text;
            ChargementProceduerSoldeCompte();
        }

        private void bReleveCpt_Click(object sender, EventArgs e)
        {
            try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate("");
                Fp.Text = this.Text;
                Fp.BoolReleve = true;
                String desCompte;
                if (BoolbReleve == 1)
                {
                    desCompte = comboDebitDes.Text;
                    Fp.libeleOP = "RELEVE DE : " + desCompte;
                    Fp.NumCompte = comboDebit.Text.Trim();
                }
                else if (BoolbReleve == 2)
                {
                      desCompte=  comboCrediDES.Text;
                      Fp.libeleOP = "RELEVE DE :" + desCompte;
                      Fp.NumCompte = comboCredit.Text.Trim();
                }
                
                //Fp.utilisateur = this.utilisateur;

               // Fp.Matricule = comboMatriculeClients.SelectedValue.ToString();

                // Fp.nomAchercher = comboPostNomCas.Text.Trim();
                //OK

                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {
                    //comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;
                   // ChargementDatagrideSolde();

                    //comboCompteV.Text = RefAchercher;
                    //label2.Text = "tu clicl sur ok";
                    // chargemeenDGFacturationSerice();
                    //dgFacturation.DataSource = TableFacturation;
                    // tSommeFact.Text = SommeFact.ToString();


                }

                else if (Dial == DialogResult.Cancel)
                {

                   // comboMatriculeClients.Text = ClassVaribleGolbal.RefAchercher;
                    //ChargementDatagrideSolde();


                    // comboCompteV.Text = "";
                    // label2.Text = "tu clicl sur cance";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboNomsCilents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbApercuSolde_CheckedChanged(object sender, EventArgs e)
        {
            AficheleSolde(CbApercuSolde.Checked);

        }

        private void AficheleSolde(Boolean b)
        {
            lsoldeCredit.Visible = b;
            lSoldeDebit.Visible = b;
            tSolde.Visible = b;
            tSoldeCredit.Visible = b;
        
        }

        private void bWapercuSolde_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tSolde.Text=SoldeCompteDebut.ToString();
            tSoldeCredit.Text = SoldeComptCredit.ToString();
        }
    }
}
