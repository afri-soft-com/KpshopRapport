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

namespace GoldenStarApplication.FormPopVente
{
    public partial class FormOparationVente : Form
    {
        public FormOparationVente()
        {
            InitializeComponent();
        }

        private string groupeCaisse = "570";
        private string GroupeCLient = "4101";
        Double Taux;
        Boolean TesteModifierDepot, BoolRappelDeDate;

        public String utilisateur, libeleOP, CodeDepot, CodeVendeur, NomsVendeur;

        private void FormOparationVente_Load(object sender, EventArgs e)
        {
            Taux = ClassVaribleGolbal.TauxFc;
            tDate.Value = ClassVaribleGolbal.DateDuJOUR;
            LesClasses.ClasseRequetteDernier cd = new LesClasses.ClasseRequetteDernier();
            tNumOp2.Text = cd.fonctionOPSotie(utilisateur);
            bNouveau.Enabled = false;
            bValide.Enabled = false;
            Bannuler.Enabled = false;


        }

        public void chargmentComboCompte(ComboBox cb1, ComboBox cb2, string s, string para)
        {
            // string s = "SELECT * from  tCompte where  GroupeCompte=";
            ClassRequette classeReq = new ClassRequette();
            string[] r = { para };
            classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);
            // ClassChargementDatagrig Ccdt = new ClassChargementDatagrig();
            //Ccdt.chargmentTable(s, "1");
            cb1.DataSource = classeReq.dt;
            cb2.DataSource = classeReq.dt;


            cb1.ValueMember = "NumCompte";
            cb1.DisplayMember = "NumCompte";

            cb2.ValueMember = "NumCompte";
            cb2.DisplayMember = "DesignationCompte";

        }

        private void chargementComtpte()
        {
            string scaisse = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte = @a)  and  CodeDepartement= " + ClassVaribleGolbal.CodeDepartement;
            string sclient = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte = @a)  and CodeDepartement = " + ClassVaribleGolbal.CodeDepartement;
            string sautre = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM    tCompte WHERE CodeDepartement = " + ClassVaribleGolbal.CodeDepartement;

            if (rBcash.Checked == true)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, scaisse, groupeCaisse);

            }

            else if (rbCredit.Checked == true)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, sclient, GroupeCLient);
            }

            else if (rbAutres.Checked)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, sautre, GroupeCLient);

            }







        }

        private void rBcash_CheckedChanged(object sender, EventArgs e)
        {
            chargementComtpte();
            ecrireLebele();
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            chargementComtpte();
            ecrireLebele();
        }

        private void rbAutres_CheckedChanged(object sender, EventArgs e)
        {
            chargementComtpte();
            ecrireLebele();
        }

        private  Boolean BoolPasseLoperation;
        private void button1_Click(object sender, EventArgs e)
        {

           // LesClasses.ClasseRequetteDernier cd = new LesClasses.ClasseRequetteDernier();
           // tNumOp2.Text = cd.fonctionOPSotie(utilisateur);
            if (BoolRappelDeDate == false)
            {
                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR PASSER   LES OPRATION A LA   ? \n DATE  ===  " + ClassVaribleGolbal.DateDuJOUR + "\n" +
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

                if (BoolPasseLoperation == false)
                {
                    enregOprationDestockage();
                }

                
                
                passerlOPERATIONCOMANE();
                
                
                bValide.Enabled = true;
                Bannuler.Enabled = true;
                bNouveau.Enabled = false;
            }



        }


        private void passerlOPERATIONCOMANE()
        {

            if (rBcash.Checked == false && rbCredit.Checked == false && rbAutres.Checked == false)
            {

                MessageBox.Show("CHOISISSEZ  ACHAT OU BON");
            }


            else
            {
                //boolAchat = rBStockageAchat.Checked;
                // boolAchatBon = rBStockageOffre.Checked;

                if (tLibelle.TextLength > 10 && tNumOp2.Text.Trim() != "")
                {





                    //chargemeTousLesArticle(comboCompteStock.Text.Trim());


                    //  if (rBcash.Checked == true)
                    // {
                    ChargmentPoPcharemenStockVente();
                    //}





                }
                else
                {
                    MessageBox.Show("COMPLETER LE BILAN");
                }


            }


        }

        private void enregOprationDestockage()
        {


            string s = " INSERT INTO tOperation " +
                           "  (NumOperation, Libelle, NomUt,TypeOp,BeneFiciare,Valider,Vendeur,TauxDuJour, DateOp) " +
                " VALUES (@a, @b, @c, @d,@e,@f,@g,@h, @da) ";

            string[] r = { tNumOp2.Text, tLibelle.Text, utilisateur, "3", tLibelle.Text, "1", CodeVendeur, Taux.ToString() };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

            BoolPasseLoperation = true;

        }


        private void ChargmentPoPcharemenStockVente()
        {

            FormPop.FormPopStockChargment Fp = new FormPop.FormPopStockChargment();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDepot = CodeDepot;
            Fp.Compte = "comboCompteStock.Text.Trim()";
            Fp.CompteFournissseur = comboCompte.Text.Trim();
            Fp.CompteVariation = ClassVaribleGolbal.CompteVariationStock;

            Fp.boolVenteSpecial = true;
            Fp.CodeDepot = "CD1";

            DialogResult Dial = Fp.ShowDialog();
            //  PasserLoperation = true;
            if (Dial == DialogResult.OK)
            {

                ChargmentGgDernierChargementFactuaration();

                dataFacturation.DataSource = TableFacturaion;
                tValeure.Text = SommeFact.ToString();
                // tQteApro.Text = SommeQteAchat.ToString();
                tVenteValeur.Text = SommeVente.ToString();
                ////pCommande.Enabled = false;
                //bValiderAchat.Enabled = true;
                //lMessageStock.Text = " VALIDER L'OPERATION DE L'ACHAT ";
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

                //pCommande.Enabled = false;
                //lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";
                ChargmentGgDernierChargementFactuaration();

            }
        }


        DataTable TableFacturaion;
        double SommeFact, SommeQteAchat, SommeVente;
        private void ChargmentGgDernierChargementFactuaration()
        {
            try
            {
                string s;

                string sEntree = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree AS Qte , tMvtStock.QteSortie,tMvtStock.Entree AS Valeur, tMvtStock.Entree AS Vente, tDepot.DesignationDepot, tOperation.Libelle,tOperation.NumOperation,tMvtStock.NumRef  " +
" FROM tMvtStock INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteEntree <>0) ";

                string sSortie = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteSortie AS Qte,tMvtStock.Sortie AS Valeur, tMvtStock.Vente AS Vente,tMvtStock.NumRef,tMvtStock.PVentUN  " +
" FROM tMvtStock INNER JOIN " +
                      "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                      "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                       " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteSortie <>0) ";




                ClassRequette classeReq = new ClassRequette();

                //if (rbEntreeStock.Checked == true)
                //{
                //    s = sEntree;
                //}
                //else
                //{
                s = sSortie;
                //}

                string[] r = { tNumOp2.Text, CodeDepot };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                TableFacturaion = classeReq.dt;

                DataTable TB = classeReq.dt;
                Double motant, QteAchat, Vente;
                SommeFact = 0;
                SommeQteAchat = 0;
                SommeVente = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Valeur"].ToString());
                    QteAchat = Double.Parse(TB.Rows[i]["Qte"].ToString());
                    Vente = Double.Parse(TB.Rows[i]["Vente"].ToString());
                    // tot = tot + motant;
                    SommeFact = SommeFact + motant;
                    SommeQteAchat = SommeQteAchat + QteAchat;
                    SommeVente = SommeVente + Vente;
                    // SommeFact
                    //Des = TB.Rows[i]["DesignationCompte"].ToString();
                    //montantc = TB.Rows[i]["Sortie"].ToString();
                    //numop = TB.Rows[i]["NumOP"].ToString();
                    //motantd = TB.Rows[i]["Etree"].ToString();
                    //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;
            }
            //  da.Dispose();
        }



        private void passerOperationCompte()
        {
            LesClasses.ClasseOperationMvt clmvt = new LesClasses.ClasseOperationMvt();

            clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.CompteVariationStock, "1", tValeure.Text, "0");
            clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.CompteStock, "1", "0", tValeure.Text);

            clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, comboCompte.Text, "1", tVenteValeur.Text, "0");
            clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.venteProduit, "1", "0", tVenteValeur.Text);


            clmvt.ValidationDeloperation(tNumOp2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LesClasses.ClasseRequetteDernier cd = new LesClasses.ClasseRequetteDernier();
            tNumOp2.Text = cd.fonctionOPSotie(utilisateur);
           // ChargmentPoPcharemenStockVente();
            ChargmentGgDernierChargementFactuaration();

            dataFacturation.DataSource = TableFacturaion;
            tValeure.Text = SommeFact.ToString();
            // tQteApro.Text = SommeQteAchat.ToString();
            tVenteValeur.Text = SommeVente.ToString();
            BoolPasseLoperation = false;
            Bcompleter.Enabled = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (tLibelle.TextLength > 10 && tNumOp2.Text.Trim() != "")
            {
                passerOperationCompte();
                bValide.Enabled = false;
                Bcompleter.Enabled = false;
                Bannuler.Enabled = false;
                bNouveau.Enabled = true;

            }

        }

        private void tBene_TextChanged(object sender, EventArgs e)
        {
            ecrireLebele();
        }
        private void ecrireLebele()
        {
            if (rBcash.Checked == true)
            {
                tLibelle.Text = "VENTE CASH " + tBene.Text;
            }
            else if (rbCredit.Checked == true)
            {
                tLibelle.Text = "VENTE CREDIT " + tBene.Text;
            }
            else if (rbAutres.Checked == true)
            {
                tLibelle.Text = "AUTRE VENTE POUR " + tBene.Text;
            }

        }

        private void tLibelle_TextChanged(object sender, EventArgs e)
        {
            // ecrireLebele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            LesClasses.ClasseOperationMvt clMvt = new LesClasses.ClasseOperationMvt();
             int ci = dataFacturation.CurrentRow.Index;
           // tCodeRef.Text, ClassVaribleGolbal.CodeDepartement, tDesArticle.Text, comboCategorie.Text, tPu.Text, ClassVaribleGolbal.CompteStock,tPuniVente.Text
            string numRe = dataFacturation["NumRef", ci].Value.ToString();
            clMvt.suprimerUneOeration(numRe);
            ChargmentGgDernierChargementFactuaration();
            dataFacturation.DataSource = TableFacturaion;



        }

        private void affecheFacture(string chiminRap)
        {
            try
            {


                //Connection_Data();
                //con.Open();
                //cmd.CommandText = "RapportFactProduits";


                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Clear();
                ////cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumOperation", tNumOp2.Text);

                //da.Fill(dt);
                //con.Close();
                string pro = "KpRapportFactProduits";
                string[] r = { tNumOp2.Text};
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette clr = new ClassRequette();
                clr.chargementAvecLesParametreDateStorage(pro, ClassVaribleGolbal.seteconnexion, "facture", r, d);
                // string chiminRap = "Rapport/Bransimba/ReportFacture.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(clr.dt, chiminRap, "DataSet1");
                // fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // string chiminRap = "Rapport/KP/ReportFactureSansR.rdlc";
            string chiminRap = "Rapport/KP/ReportFacturePetiFoma.rdlc";
            //ReportFacturePetiFoma
            affecheFacture(chiminRap);
        }
    }
}
