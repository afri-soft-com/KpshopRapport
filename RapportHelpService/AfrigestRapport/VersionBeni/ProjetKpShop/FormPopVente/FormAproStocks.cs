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
    public partial class FormAproStocks : Form
    {
        public FormAproStocks()
        {
            InitializeComponent();
        }
        private string groupeFournisseur = "4010";
        private string GroupeComAchatTrasitoir = "4101";
        public String utilisateur, libeleOP, CodeDepot, CodeVendeur, NomsVendeur;
        double Taux ;
       // Taux = ClassVaribleGolbal. TauxFc;
      
        Boolean TesteModifierDepot, BoolRappelDeDate;

        string DepotMagasin = "CD1";
        public DataTable dt;
        public DataSet ds;
      
        

        private void FormAproStocks_Load(object sender, EventArgs e)
        {
            tDate.Value = ClassVaribleGolbal.DateDuJOUR;
            Taux = ClassVaribleGolbal.TauxFc;
            bValide.Enabled = false;
            Bannuler.Enabled = false;
            LesClasses.ClasseRequetteDernier cd = new LesClasses.ClasseRequetteDernier();
            tNumOp2.Text = cd.fonctionOPSotie(ClassVaribleGolbal.UTILISATEUR);

        }

        Boolean BoolPasseLoperation;
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

                string sSortie = "SELECT        tStock.CodeArticle, tStock.DesegnationArticle, tMvtStock.QteEntree AS Qte,tMvtStock.Entree AS Valeur, tMvtStock.Entree AS Vente,tMvtStock.NumRef,tMvtStock.PVentUN  " +
" FROM tMvtStock INNER JOIN " +
                      "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                      "  tOperation ON tMvtStock.NumOperation = tOperation.NumOperation INNER JOIN " +
                       " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot " +
" WHERE(tOperation.NumOperation = @a) AND (tDepot.CodeDepot = @b) AND (tMvtStock.QteEntree <>0) ";




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




        private void chargementComtpte()
        {
            string scaisse = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte = @a)";
            string sclient = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte = @a)";
            string sautre = " SELECT        NumCompte, DesignationCompte, GroupeCompte FROM    tCompte";

            if (rBFournissseur.Checked == true)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, scaisse, groupeFournisseur);

            }

            else if (rbCredit.Checked == true)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, sclient, GroupeComAchatTrasitoir);
            }

            else if (rbAutres.Checked)
            {
                chargmentComboCompte(comboCompte, comboCompteDes, sautre, groupeFournisseur);

            }







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

        private void ecrireLebele()
        {
            if (rBFournissseur.Checked == true)
            {
                tLibelle.Text = "ACHAT PRODUIT PAR " + tBene.Text;
            }
            else if (rbCredit.Checked == true)
            {
                tLibelle.Text = "ACHAT PRODUIT PAR " + tBene.Text;
            }
            else if (rbAutres.Checked == true)
            {
                tLibelle.Text = "ACHAT PRODUIT PAR  " + tBene.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LesClasses.ClasseRequetteDernier cd = new LesClasses.ClasseRequetteDernier();
            //tNumOp2.Text = cd.fonctionOPSotie(ClassVaribleGolbal.UTILISATEUR);
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
                //bValide.Enabled = true;
                bValide.Enabled = true;
                Bannuler.Enabled = true;
                bNouveau.Enabled = false;
            }
        }

        private void enregOprationDestockage()
        {


            string s = " INSERT INTO tOperation " +
                           "  (NumOperation, Libelle, NomUt,TypeOp,BeneFiciare,Valider,Vendeur,TauxDuJour, DateOp) " +
                " VALUES (@a, @b, @c, @d,@e,@f,@g,@h, @da) ";

            string[] r = { tNumOp2.Text, tLibelle.Text, ClassVaribleGolbal.UTILISATEUR, "3", tLibelle.Text, "1", CodeVendeur, Taux.ToString() };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            BoolPasseLoperation = true;

        }

        private void passerlOPERATIONCOMANE()
        {

            if (rBFournissseur.Checked == false && rbCredit.Checked == false && rbAutres.Checked == false)
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

        private void ChargmentPoPcharemenStockVente()
        {

            FormPop.FormAchaProduit Fp = new FormPop.FormAchaProduit();
            Fp.NumOP = tNumOp2.Text.Trim();
            Fp.CodeDepot = CodeDepot;
            Fp.Compte = "comboCompteStock.Text.Trim()";
            Fp.CompteFournissseur = comboCompte.Text.Trim();
            Fp.CompteVariation = ClassVaribleGolbal.CompteVariationStock;

            Fp.boolAchat = true;


            DialogResult Dial = Fp.ShowDialog();
            //  PasserLoperation = true;
            if (Dial == DialogResult.OK)
            {

                ChargmentGgDernierChargementFactuaration();

                dataFacturation.DataSource = TableFacturaion;
                tValeure.Text = SommeFact.ToString();
               
                tSommeFact.Text = SommeVente.ToString();
               
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

                //pCommande.Enabled = false;
                //lMessageStock.Text = "COMPLETEZ LE NOUVEAU COMMANDE";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void Bannuler_Click(object sender, EventArgs e)
        {
            try
            {
                LesClasses.ClasseOperationMvt clMvt = new LesClasses.ClasseOperationMvt();
                int ci = dataFacturation.CurrentRow.Index;
                // tCodeRef.Text, ClassVaribleGolbal.CodeDepartement, tDesArticle.Text, comboCategorie.Text, tPu.Text, ClassVaribleGolbal.CompteStock,tPuniVente.Text
                string numRe = dataFacturation["NumRef", ci].Value.ToString();
                clMvt.suprimerUneOeration(numRe);
                ChargmentGgDernierChargementFactuaration();
                dataFacturation.DataSource = TableFacturaion;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tNumOp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bValide_Click(object sender, EventArgs e)
        {
            EnrmouvemmentComptble();

            bValide.Enabled = false;
            Bcompleter.Enabled = false;
            Bannuler.Enabled = false;
            bNouveau.Enabled = true;
        }


       
        private void EnrmouvemmentComptble()
        {
            try
            {



                LesClasses.ClasseOperationMvt clmvt = new LesClasses.ClasseOperationMvt();
                //clmvt.InserMvtCpteStockAvecQte2("insererMvtcpt", ClassVaribleGolbal.CompteStock, "0", "0", "0", tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOp2.Text);

               
                //clmvt.InserMvtCpteStockAvecQte2("insererMvtcpt",ClassVaribleGolbal. CompteAchatstock, "0", "0", "0", tSommeFact.Text, "0", "0", DepotMagasin, "0", tNumOp2.Text);

                //clmvt.InserMvtCpteStockAvecQte2("insererMvtcpt", comboCompte.Text, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0", tNumOp2.Text);

                //clmvt.InserMvtCpteStockAvecQte2("insererMvtcpt", ClassVaribleGolbal.CompteVariationStock, "0", "0", "0", "0", tSommeFact.Text, "0", DepotMagasin, "0",tNumOp2.Text);




                clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.CompteStock, "1", tValeure.Text, "0");
                clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, comboCompte.Text, "1", "0", tValeure.Text); ;

                clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.CompteAchatstock, "1", tValeure.Text, "0");
                clmvt.enregistrementMouvmentCmpte(tNumOp2.Text, ClassVaribleGolbal.CompteVariationStock, "1", "0", tValeure.Text); ;
               
               
                
                clmvt.ValidationDeloperation(tNumOp2.Text);
               
              


               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









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
            BoolPasseLoperation = false;
           
            Bcompleter.Enabled = true;
            tSommeFact.Text = SommeVente.ToString();
        }

        private void comboCompteDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBene_TextChanged(object sender, EventArgs e)
        {
            ecrireLebele();
        }

        private void tLibelle_TextChanged(object sender, EventArgs e)
        {
            ecrireLebele();
        }


    }
}
