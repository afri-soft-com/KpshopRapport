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
using Microsoft.Reporting.WinForms;

namespace GoldenStarApplication
{
    public partial class FormLogement : Form
    {
        public FormLogement()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur = "STEVE", libeleOP;
        public string CompteClientOccasionnel = "41202";
        public string CompteClientProChambre = "41201";
        public string CompteClientOrdi = "411";
        public string CaisseReception;
        public static string RefPatiant;
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


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }




        private void FormLogement_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {

                tDate.Value = ClassVaribleGolbal.DateDuJOUR;
                //tDateR1.Value = ClassVaribleGolbal.DateDuJOUR;
                //  tdateR2.Value = ClassVaribleGolbal.DateDuJOUR;
                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                tdate2.Value = ClassVaribleGolbal.DateDuJOUR;

                tDate21.Value = ClassVaribleGolbal.DateDuJOUR;
                tDate22.Value = ClassVaribleGolbal.DateDuJOUR;

//DrnierOpPaiement();


                if (bwcharmemntCombo.IsBusy == false)
                {
                    pbCombo.Visible = true;
                    bwcharmemntCombo.RunWorkerAsync();
                    //  CaisseReception = CompteDEservicleint(51, 2);

                }



                this.reportViewer1.RefreshReport();
                //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
                //  this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmenArticledg();
        }
        DataTable TableDgClients;
        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            pbCombo.Maximum = 10;
            ChargmenComboCompte();
            bwcharmemntCombo.ReportProgress(2);
          //  ChargmenComboCompte2();
            chargemeentFiche();
            bwcharmemntCombo.ReportProgress(4);
            ChargmenComboCategorie();
            ChargmenComboCompteService();
            bwcharmemntCombo.ReportProgress(6);
            ChargmenChambreAUdemarage();
            bwcharmemntCombo.ReportProgress(7);
            chargemeentComboFactIinitial();
            bwcharmemntCombo.ReportProgress(8);
            chargemeentTypeCas();
            ChargmentLogement2();
            bwcharmemntCombo.ReportProgress(9);
            DrnierOP();
            DrnierClient();
            DrnierCas();
            chargemeentDgCAS();
             DrnierOpPaiement();
            chargemeentTypeSerivce();
            tCaisseReception.Text = CaisseReception;
        }

        DataTable CbGroupe, cbCompte, CbCat, CbChambre, CbCompte2;

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            comboFicheCas.DataSource = tableFiche;
            comboFicheCasDes.DataSource = tableFiche;
            comboFicheCas.DisplayMember = "CompteClient";
            comboFicheCas.ValueMember = "CompteClient";
            comboFicheCasDes.DisplayMember = "Fiche";
            comboFicheCasDes.ValueMember = "CompteClient";

            comboPostNomCas.DataSource = tableFiche;
            comboPostNomCas.DisplayMember = "NOM";
            comboPostNomCas.ValueMember = "CompteClient";


            comboDesCompteCas.DataSource = tableFiche;
            comboDesCompteCas.DisplayMember = "DesignationCompte";
            comboDesCompteCas.ValueMember = "CompteClient";

            //comboPresNomsCas.DataSource = tableFiche;
            //comboPresNomsCas.DisplayMember = "Prenoms";
            // comboPresNomsCas.ValueMember = "CompteClient";

            comboTypeCas.DataSource = TableType;
            comboTypeCas.DisplayMember = "DesiganationTypesCas";
            comboTypeCas.ValueMember = "RefTypeCas";

            comboCatArti.DataSource = CbCat;
            comboCatArti.DisplayMember = "DesCatCatChambre";
            comboCatArti.ValueMember = "IdCatChambre";



            comboCompte.DataSource = CbGroupe;
            comboCompte.DisplayMember = "NumCompte";
            comboCompte.ValueMember = "NumCompte";

            comboDEsegnationCompte.DataSource = CbGroupe;
            comboDEsegnationCompte.DisplayMember = "DesignationCompte";
            comboDEsegnationCompte.ValueMember = "NumCompte";


            //tableSERVICE

            comboTypeHospCode.DataSource = tableSERVICE;
            comboTypeHospCode.DisplayMember = "CodeSeviceHosp";
            comboTypeHospCode.ValueMember = "CodeSeviceHosp";

            comboTypeHospCodeDes.DataSource = tableSERVICE;
            comboTypeHospCodeDes.DisplayMember = "DesignationService";
            comboTypeHospCodeDes.ValueMember = "CodeSeviceHosp";



            //comboCompteSevice.DataSource = TableComteVenteService;
            //comboCompteSevice.DisplayMember = "CodeChambre";
            //comboCompteSevice.ValueMember = "CodeChambre";

            //comboDesignationSErvice.DataSource = TableComteVenteService;
            //comboDesignationSErvice.DisplayMember = "DesignationChambre";
            //comboDesignationSErvice.ValueMember = "CodeChambre";

            //comboCpteService.DataSource = TableComteVenteService;
            //comboCpteService.DisplayMember = "Compte";
            //comboCpteService.ValueMember = "Compte";



            comboCompteIdent.DataSource = cbCompte;
            comboCompteIdent.DisplayMember = "NumCompte";
            comboCompteIdent.ValueMember = "NumCompte";

            comboCompteDesId.DataSource = cbCompte;
            comboCompteDesId.DisplayMember = "DesignationCompte";
            comboCompteDesId.ValueMember = "NumCompte";


            comboGroupeCompte.DataSource = TableGroupe;
            comboGroupeCompte.DisplayMember = "DesignationGroupe";
            comboGroupeCompte.ValueMember = "GroupeCompte";


            comboGroupeNv.DataSource = TableGroupe2;
            comboGroupeNv.DisplayMember = "DesignationGroupe";
            comboGroupeNv.ValueMember = "GroupeCompte";
            //comboGroupeNv
            ////comboCodeChambre.DataSource = CbChambre;
            ////comboCodeChambre.DisplayMember = "CodeChambre";
            ////comboCodeChambre.ValueMember = "CodeChambre";


            ////comboDesChambre.DataSource = CbChambre;
            ////comboDesChambre.DisplayMember = "DesignationChambre";
            ////comboDesChambre.ValueMember = "DesignationChambre";


            //comboComptePart.DataSource = CbCompte2;
            //comboComptePart.DisplayMember = "NumCompte";
            //comboComptePart.ValueMember = "NumCompte";

            //comboDesPartenaire.DataSource = CbCompte2;
            //comboDesPartenaire.DisplayMember = "DesignationCompte";
            //comboDesPartenaire.ValueMember = "NumCompte";

            dGArticle.DataSource = TableChambre;

            DgClients.DataSource = TableDgClients;

            dgCas.DataSource = TableCas;
            //ChargmentLogement();

            pbCombo.Visible = false;


          
        }

        DataTable TableComteVenteService;
        private void chargemeentComboFactIinitial()
        {
            try
            {
                string s = " SELECT        tCompte.GroupeCompte, tGroupeCompte.Cadre, tCompte.NumCompte, tCompte.DesignationCompte " +
" FROM tCompte INNER JOIN " +
"  tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Cadre = 41)  ";
                string s2 = " SELECT  * from tChambre WHERE  CategorieChambre <> 0  ";
                String s3 = "SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte=@a)";

                string[] r = { "" };
                string[] r3 = { ClassVaribleGolbal.GroupeService };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                CbCompte2 = classeReq.dt;


                classeReq.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                CbChambre = classeReq.dt;
                classeReq.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption2", r3);
                TableComteVenteService = classeReq.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable TABLEPaiemnt;
        private void chargemeenDGpaiement()
        {
            try
            {
                string s = " SELECT    TOP (10)     tMvtClient.NumOperation, tClientProvisoire.CompteClient, tClientProvisoire.Noms, tOperration.Libelle, tMvtClient.Sortie, tOperration.DateOp " +
" FROM tClientProvisoire INNER JOIN " +
 "  tMvtClient ON tClientProvisoire.CompteClient = tMvtClient.NumCompte INNER JOIN " +
    "  tOperration ON tMvtClient.NumOperation = tOperration.NumOperation " +
" WHERE        (tMvtClient.TypeOp = 0) AND (tOperration.DateOp =@da)";

                string[] r = { "" };
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                TABLEPaiemnt = classeReq.dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        DataTable TableFacturation;
        double SommeFact;
        private void chargemeenDGFacturationSerice()
        {
            try
            {
                //                string s = " SELECT        tMvtCompte.NumOperation, tMvtCompte.NumRef, tMvtCompte.NumCompte, tMvtCompte.Sortie, tCompte.DesignationCompte " +
                //" FROM tMvtCompte INNER JOIN "+
                //    " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte INNER JOIN " +
                //                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                // " WHERE(tMvtCompte.NumOperation = @a) AND(tGroupeCompte.GroupeCompte =@b)";

                string s = " SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tMvtChambre.QteEntree, tMvtChambre.Entree, tMvtChambre.PVentUN, tOperration.NumOperation " +
" FROM tChambre INNER JOIN " +
                        "  tMvtChambre ON tChambre.CodeChambre = tMvtChambre.NumCompte INNER JOIN " +
                        "  tOperration ON tMvtChambre.NumOperation = tOperration.NumOperation WHERE ((tOperration.NumOperation)=@a AND  (tMvtChambre.Entree)<>0)  ";

                string[] r = { tNumOp2.Text, ClassVaribleGolbal.GroupeService };
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                TableFacturation = classeReq.dt;
                DataTable TB = classeReq.dt;
                Double motant;
                SommeFact = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Entree"].ToString());
                    // tot = tot + motant;
                    SommeFact = SommeFact + motant;
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
            }

        }

        DataTable TableMedicamenentFact;
        Boolean BcharmenntTableMedicament;
        private void chargemeenDGFacturationPourMedicament()
        {
            try
            {
                //                string s = " SELECT        tMvtCompte.NumOperation, tMvtCompte.NumRef, tMvtCompte.NumCompte, tMvtCompte.Sortie, tCompte.DesignationCompte " +
                //" FROM tMvtCompte INNER JOIN "+
                //    " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte INNER JOIN " +
                //                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                // " WHERE(tMvtCompte.NumOperation = @a) AND(tGroupeCompte.GroupeCompte =@b)";

//                string s = " SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tMvtChambre.QteEntree, tMvtChambre.Entree,tMvtChambre.NumRef ,tMvtChambre.PVentUN, tOperration.NumOperation " +
//" FROM tChambre INNER JOIN " +
//                        "  tMvtChambre ON tChambre.CodeChambre = tMvtChambre.NumCompte INNER JOIN " +
//                        "  tOperration ON tMvtChambre.NumOperation = tOperration.NumOperation WHERE ((tOperration.NumOperation)=@a AND  (tMvtChambre.Entree)<>0)  ";

                string s = "SELECT   tStock.CodeArticle AS CodeChambre,       tMvtStock.NumOperation, tMvtStock.NumRef, tStock.DesegnationArticle AS DesignationChambre , tMvtStock.QteSortie AS QteEntree, tMvtStock.Sortie AS Entree, tMvtStock.PVentUN " +
" FROM tMvtStock INNER JOIN tStock ON tMvtStock.NumCompte = tStock.CodeArticle INNER JOIN " +
                        "  tOperration ON tMvtStock.NumOperation = tOperration.NumOperation " +
" WHERE(tMvtStock.NumOperation = @a)";


                string[] r = { comboRefMed.Text, ClassVaribleGolbal.GroupeService };
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                TableMedicamenentFact = classeReq.dt;
                DataTable TB = classeReq.dt;
                Double motant;
                SommeFact = 0;
                for (int i = 0; i <= TB.Rows.Count - 1; i++)
                {
                    motant = Double.Parse(TB.Rows[i]["Entree"].ToString());
                    // tot = tot + motant;
                    SommeFact = SommeFact + motant;
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
            }

        }
        DataTable tablePaiementPourHOP;
        private void chargemeenDGPourLESpaiement()
        {
            try
            {

                string s = " SELECT        TOP (20) tOperration.NumOperation, tCompte.NumCompte, tCompte.DesignationCompte, tMvtCompte.Entree, tMvtCompte.Sortie, tOperration.NomUt " +
"    ,tOperration.Libelle, tOperration.DateOp FROM            tOperration INNER JOIN " +
                        "  tMvtCompte ON tOperration.NumOperation = tMvtCompte.NumOperation INNER JOIN " +
                         " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte " +
" WHERE        (tOperration.NomUt = @a)  ORDER BY tOperration.NumOpSource DESC ";
                string[] r = { utilisateur};
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                MessageBox.Show("ok");
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                tablePaiementPourHOP = classeReq.dt;
               

              




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void chargemeenDGFacturationSericeVide()
        {
            try
            {
                //                string s = " SELECT        tMvtCompte.NumOperation, tMvtCompte.NumRef, tMvtCompte.NumCompte, tMvtCompte.Sortie, tCompte.DesignationCompte " +
                //" FROM tMvtCompte INNER JOIN " +
                //    " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte INNER JOIN " +
                //                         " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                // " WHERE(tMvtCompte.NumOperation = @a) AND(tGroupeCompte.GroupeCompte =@b)";
                string s = " SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tMvtChambre.QteEntree, tMvtChambre.Entree, tMvtChambre.PVentUN, tOperration.NumOperation " +
" FROM tChambre INNER JOIN " +
                       "  tMvtChambre ON tChambre.CodeChambre = tMvtChambre.NumCompte INNER JOIN " +
                       "  tOperration ON tMvtChambre.NumOperation = tOperration.NumOperation WHERE ((tOperration.NumOperation)=@a AND  (tMvtChambre.Entree)<>0)  ";





                string[] r = { "", ClassVaribleGolbal.GroupeService };
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

                dgFacturation.DataSource = classeReq.dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void chargemeentComboApresENRE()
        {
            try
            {
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                string s2 = " SELECT  * from tChambre ";

                string[] r = { "" };

                ClassRequette classeReq = new ClassRequette();
                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;


                classeReq.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                //comboCodeChambre.DataSource = classeReq.dt;
                //comboDesChambre.DataSource= classeReq.dt;


                //comboCodeChambre.DisplayMember = "CodeChambre";
                //comboCodeChambre.ValueMember = "CodeChambre";


                //comboDesChambre.DataSource = CbChambre;
                //comboDesChambre.DisplayMember = "DesignationChambre";
                //comboDesChambre.ValueMember = "DesignationChambre";

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable TableChambreSolde;
        string Datedeverication = ClassVaribleGolbal.DateDuJOUR.ToShortDateString();
        private void chargemeentDgSoleClienChambre()
        {

            try
            {
                // string compte = CompteDEservicleint(41, 2);
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                //tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms
                string StoucasActuel = "SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Fiche,CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  " +
                        " tClientProvisoire.Tele, SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, "+
                        " tCompte.DesignationCompte, tCas.Etat, tCas.DateEntree " +
" FROM            tCas INNER JOIN " +
                        " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                         " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                        "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                        "  tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele,  " +
                        " tCas.DateEntree, tClientProvisoire.Fiche, tCompte.NumCompte, tCompte.DesignationCompte, tCas.Etat " +
" HAVING(tCas.Etat = 0) ";


                string sEmbilatoire = "SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Fiche,CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  " +
                        " tClientProvisoire.Tele, SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, " +
                        " tCompte.DesignationCompte, tCas.Etat, tCas.DateEntree " +
" FROM            tCas INNER JOIN " +
                        " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                         " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                        "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                        "  tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele,  " +
                        " tCas.DateEntree, tClientProvisoire.Fiche, tCompte.NumCompte, tCompte.DesignationCompte, tCas.Etat " +
" HAVING        (tCas.Etat = 0) AND (tCas.TypeDeCas = 1) ";


                string sHospitalise  = "SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Fiche,CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  " +
                        " tClientProvisoire.Tele, SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, " +
                        " tCompte.DesignationCompte, tCas.Etat, tCas.DateEntree " +
" FROM            tCas INNER JOIN " +
                        " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                         " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                        "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                        "  tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele,  " +
                        " tCas.DateEntree, tClientProvisoire.Fiche, tCompte.NumCompte, tCompte.DesignationCompte, tCas.Etat " +
" HAVING        (tCas.Etat = 0) AND (tCas.TypeDeCas =2) ";


                string Scpn = "SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Fiche,CONCAT(tClientProvisoire.Noms, ' ',  " +
                      " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  " +
                     " tClientProvisoire.Tele, SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, " +
                     " tCompte.DesignationCompte, tCas.Etat, tCas.DateEntree " +
" FROM            tCas INNER JOIN " +
                     " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                      " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                     "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                     "  tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                     " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele,  " +
                     " tCas.DateEntree, tClientProvisoire.Fiche, tCompte.NumCompte, tCompte.DesignationCompte, tCas.Etat " +
" HAVING        (tCas.Etat = 0) AND (tCas.TypeDeCas =3) ";

                string sCloture = "SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Fiche,CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  " +
                        " tClientProvisoire.Tele, SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, " +
                        " tCompte.DesignationCompte, tCas.Etat, tCas.DateEntree " +
" FROM            tCas INNER JOIN " +
                        " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                         " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                        "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                        "  tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele,  " +
                        " tCas.DateEntree, tClientProvisoire.Fiche, tCompte.NumCompte, tCompte.DesignationCompte, tCas.Etat " +
" HAVING        (tCas.Etat = 1)  ";

                string[] r = { "" };
                DateTime[] d = { DateTime.Parse(Datedeverication) };
                ClassRequette classeReq = new ClassRequette();

                if (rbCasAtuelVer.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(StoucasActuel, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    // classeReq.chargementAvecLesParametre(soRtie, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                }

                else if (rbAmbilatoir.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(sEmbilatoire, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                }
                else if (rbHospitalise.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(sHospitalise, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                }
                else if (RbCpn.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(Scpn, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                }
                else if (rbTousCasCloture.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(sCloture, ClassVaribleGolbal.seteconnexion, "tOption3", r);

                }

                // classeReq.chargementAvecLesParametre(soRtie, ClassVaribleGolbal.seteconnexion, "tOption", r);


                TableChambreSolde = classeReq.dt;



                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        DataTable TableCasParFche;
        private void chargemeentDgFichesCas()
        {

            try
            {
                // string compte = CompteDEservicleint(41, 2);
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                string StoucasActuel = " SELECT        tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele, " +
                        " SUM(tMvtChambre.Entree) AS SommeEntree, SUM(tMvtChambre.Sortie) AS SommeSortie, SUM(tMvtChambre.Entree) -SUM(tMvtChambre.Sortie) AS Reste, tCompte.NumCompte, tCompte.DesignationCompte, " +
                        " tCas.DateEntree, tEtaClient.DesignationEtat, tCas.Etat " +
 "FROM            tCas INNER JOIN " +
                        " tOperration ON tCas.RefCas = tOperration.RefCas INNER JOIN " +
                        " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient INNER JOIN " +
                         " tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte INNER JOIN " +
                        " tMvtChambre ON tOperration.NumOperation = tMvtChambre.NumOperation INNER JOIN " +
                         " tEtaClient ON tCas.Etat = tEtaClient.Etat " +
" GROUP BY tCas.TypeDeCas, tTypeCas.DesiganationTypesCas, tCas.RefCas, tCas.Diagnostic, tCas.IDfiche,tCas.Etat, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Tele, " +
                         " tCas.DateEntree, tCompte.NumCompte, tCompte.DesignationCompte, tTypeCas.IdTypeCas, tEtaClient.DesignationEtat " +
                         " HAVING(tCas.IDfiche = @a) " +
                " ORDER BY tTypeCas.IdTypeCas DESC";





                string[] r = { comboCodeFiche.Text };
                DateTime[] d = { DateTime.Parse(Datedeverication) };
                ClassRequette classeReq = new ClassRequette();




                classeReq.chargementAvecLesParametre(StoucasActuel, ClassVaribleGolbal.seteconnexion, "tOption3", r);



                // classeReq.chargementAvecLesParametre(soRtie, ClassVaribleGolbal.seteconnexion, "tOption", r);


                TableCasParFche = classeReq.dt;



                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable TableVerificationSoldeClient;
        String NomVerificationSolde, ChambreVericationsolde, SoldeVericationSolde;
        private void chargemeentVerificationDeSoldeDuClient(string CompteAverifierLeSolde, string GroupeCompteAverifierLeSolde)
        {
            try
            {
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";



                string sEmbilatoire = " SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tClientProvisoire.Noms, tClientProvisoire.CompteClient, tClientProvisoire.Compte, tClientProvisoire.ComptePartenaire, SUM(tMvtClient.Sortie)  " +
                      "   - SUM(tMvtClient.Entree) AS SODLE, DATEDIFF(day, tClientProvisoire.DateEntree, GETDATE()) AS JOURS, tClientProvisoire.DateEntree, DATEDIFF(day, GETDATE(), tClientProvisoire.DateSortie) AS RESTE, " +
                        " tClientProvisoire.DateSortie, tClientProvisoire.Etat " +
 "FROM            tMvtClient INNER JOIN " +
                       "   tClientProvisoire ON tMvtClient.NumCompte = tClientProvisoire.CompteClient INNER JOIN " +
                       "   tOperration ON tMvtClient.NumOperation = tOperration.NumOperation INNER JOIN " +
                        "  tChambre ON tClientProvisoire.ChambreActuel = tChambre.CodeChambre " +
" GROUP BY tClientProvisoire.CompteClient, tClientProvisoire.Compte, tClientProvisoire.ComptePartenaire, tClientProvisoire.Noms, tChambre.DesignationChambre, tClientProvisoire.DateEntree, tClientProvisoire.DateSortie,  " +
                       "   tClientProvisoire.Etat, tChambre.CodeChambre " +
" HAVING        (tClientProvisoire.CompteClient =@a) AND (tClientProvisoire.Compte =@b) ";


                string[] r = { CompteAverifierLeSolde, GroupeCompteAverifierLeSolde };
                DateTime[] d = { DateTime.Parse(tDate.Text) };
                ClassRequette classeReq = new ClassRequette();




                classeReq.chargementAvecLesParametre(sEmbilatoire, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                TableVerificationSoldeClient = classeReq.dt;

                NomVerificationSolde = TableVerificationSoldeClient.Rows[0]["Noms"].ToString();
                ChambreVericationsolde = TableVerificationSoldeClient.Rows[0]["DesignationChambre"].ToString();
                SoldeVericationSolde = TableVerificationSoldeClient.Rows[0]["SODLE"].ToString();

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable ComboPaiement;
        //string compte = CompteDEservicleint(41, 2);
        Boolean ClientOrdinnaire, ClientDechambe, ClientOccasionnel, AncienClients, AncienClients2;
        private void chargemeentComboPaiment()
        {
            try
            {

                // string compte = CompteDEservicleint(41,2);
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                string FicheActuels = "  SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte, tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, CONCAT(tClientProvisoire.Noms, ' ', " +
                        " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM, tCas.RefCas, tCas.Diagnostic, tCas.PLainte, tCas.Etat, tCas.Autres, tCas.DateDuCas, tCas.DateEntree, tCompte.DesignationCompte " +
"FROM            tClientProvisoire INNER JOIN " +
                       "  tCas ON tClientProvisoire.CompteClient = tCas.IDfiche INNER JOIN " +
                         "tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" WHERE(tCas.Etat = 0 AND TypeDeCas<>0) ";



                string FicheAncien = "  SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte, tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, CONCAT(tClientProvisoire.Noms, ' ', " +
                        " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM, tCas.RefCas, tCas.Diagnostic, tCas.PLainte, tCas.Etat, tCas.Autres, tCas.DateDuCas, tCas.DateEntree, tCompte.DesignationCompte " +
"FROM            tClientProvisoire INNER JOIN " +
                       "  tCas ON tClientProvisoire.CompteClient = tCas.IDfiche INNER JOIN " +
                         "tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" WHERE(tCas.Etat = 1 AND TypeDeCas<>0) ";
                //MessageBox.Show(compte);


                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };
                if (rbCasActuel.Checked == true)
                { classeReq.chargementAvecLesParametre(FicheActuels, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    tCreditte2.Text = "70602";
                }

                else if (RbAncienCas.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(FicheAncien, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    tCreditte2.Text = "70602";
                }
                else if (RbValidationFact.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(FicheActuels, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    tCreditte2.Text = "70602";

                }


                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;



                ComboPaiement = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        DataTable tableFiche;
        private void chargemeentFiche()
        {
            try
            {

                //string compte = CompteDEservicleint(41, 2);
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                // string sClientDechambre = " 
                string sFiche = "SELECT    tClientProvisoire.CompteClient,tClientProvisoire.Fiche, tClientProvisoire.Noms , tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Sexe, tClientProvisoire.DateNaiss, tCompte.DesignationCompte,tClientProvisoire.Compte,   CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM " +
"  FROM tClientProvisoire INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" ORDER BY tClientProvisoire.IdClient DESC";
                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(sFiche, ClassVaribleGolbal.seteconnexion, "tOption2", r);


                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;



                tableFiche = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable TableFiche2;
        Boolean BparaFichePaiement;
        private void chargemeentFiche2()
        {
            try
            {

                //string compte = CompteDEservicleint(41, 2);
                // string s = " SELECT  * from tCompte   WHERE GroupeCompte =411";
                // string sClientDechambre = " 
                string sFiche = "SELECT    tClientProvisoire.CompteClient, tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Sexe, tClientProvisoire.DateNaiss, tCompte.DesignationCompte,tClientProvisoire.Compte " +
"  FROM tClientProvisoire INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" ORDER BY tClientProvisoire.IdClient DESC";


                string sFiche2 = "SELECT    tClientProvisoire.CompteClient,tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Sexe, tClientProvisoire.DateNaiss, tCompte.DesignationCompte,tClientProvisoire.Compte " +
"  FROM tClientProvisoire INNER JOIN " +
                       " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
"  WHERE (tClientProvisoire.Compte=@a)  ORDER BY tClientProvisoire.IdClient DESC";
                ClassRequette classeReq = new ClassRequette();

                string[] r = { combCompteAbone.Text };
                string[] r2 = { comboPCompte.Text };

                if (rbAbonneFiche.Checked == true)
                {
                    classeReq.chargementAvecLesParametre(sFiche2, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                }
                else if (BparaFichePaiement == true)
                {
                    classeReq.chargementAvecLesParametre(sFiche2, ClassVaribleGolbal.seteconnexion, "tOption2", r2);

                }

                else
                {
                    classeReq.chargementAvecLesParametre(sFiche, ClassVaribleGolbal.seteconnexion, "tOption2", r);


                }


                // classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption", r);

                // CbCompte2 = classeReq.dt;



                TableFiche2 = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable TableType, TableGroupe2;
        private void chargemeentTypeCas()
        {
            try
            {


                string s = "SELECT        RefTypeCas, DesiganationTypesCas FROM            tTypeCas";
                string s4 = "SELECT        GroupeCompte, DesignationGroupe FROM            tGroupeCompte WHERE        (Cadre = 41)";



                ClassRequette classeReq = new ClassRequette();
                ClassRequette classeReq2 = new ClassRequette();
                string[] r = { combCompteAbone.Text };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);


                classeReq2.chargementAvecLesParametre(s4, ClassVaribleGolbal.seteconnexion, "tOptiongr", r);



                TableGroupe = classeReq2.dt;
                TableGroupe2= classeReq2.dt;





                TableType = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        DataTable TableOperation;
        Boolean BoperationFact;
        private void chargemeentOeratioFact()
        {
            try
            {


                string s = " SELECT        NumOperation, RefCas, Valider FROM tOperration " +
                    " WHERE(Valider = 0) AND(RefCas = @a) ";


                ClassRequette classeReq = new ClassRequette();

                string[] r = { comboIdCas2.Text };



                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                TableOperation = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DernierCas()
        {
            try
            {


                string s = "SELECT        tCas.RefCas, tClientProvisoire.CompteClient, MAX(tCas.IdCas) AS idCas " +
" FROM            tCas INNER JOIN " +
                        " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient " +
" GROUP BY tCas.RefCas, tClientProvisoire.CompteClient " +
" HAVING        (tClientProvisoire.CompteClient = @a) ";


                ClassRequette classeReq = new ClassRequette();

                string[] r = { comboPrefPat.Text };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                comboDernierCas.DataSource = classeReq.dt;
                comboDernierCas.ValueMember = "RefCas";
                comboDernierCas.DisplayMember = "RefCas";

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Boolean BchargementComboPaiement;
        DataTable TableComboPaiment,TableGroupe;
        private void chargemeentComboPaiement()
        {
            try
            {


                string s = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @a  )";
                string s2 = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @a  )";
                string s3 = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @a  )";
              //  string s4 = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @GroupeCompte  )";

              


                ClassRequette classeReq = new ClassRequette();
               
                string[] r = { "4101"};
                string[] r2 = { "4102" };
                string[] r3 = {"4103"};
                string[] r4 = { comboPCompte .Text};


                if (RbClientPriver.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);
                    //classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);



                }

                else if (RbAbonne.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(s3, ClassVaribleGolbal.seteconnexion, "tOption2", r3);


                }

                else if (RbAbbonneFamille.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(s2, ClassVaribleGolbal.seteconnexion, "tOption2", r2);


                }

                else if (rbAutrePaiemment.Checked == true)
                {

                    classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);


                }


                //rbAutrePaiemment




             
                TableComboPaiment = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable TableCas;
        private void chargemeentDgCAS()
        {
            try
            {


                string s = "SELECT    TOP(20)    tCas.IdCas, tCas.RefCas, tClientProvisoire.CompteClient, tClientProvisoire.Fiche, tCas.Diagnostic, tCas.PLainte, tCas.Autres, tTypeCas.DesiganationTypesCas,  CONCAT(tClientProvisoire.Noms, ' ',  " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM " +
" FROM tCas INNER JOIN " +
                        "  tTypeCas ON tCas.TypeDeCas = tTypeCas.RefTypeCas INNER JOIN " +
                         " tClientProvisoire ON tCas.IDfiche = tClientProvisoire.CompteClient " +
" ORDER BY tCas.IdCas DESC";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { combCompteAbone.Text };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableCas = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable tableSERVICE;
        private void chargemeentTypeSerivce()
        {
            try
            {


                string s = " SELECT        CodeSeviceHosp, DesignationService  FROM       tServiceHopital WHERE (Cat = 1)";



                ClassRequette classeReq = new ClassRequette();

                string[] r = { "" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);


                tableSERVICE = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void bEnreSous_Click(object sender, EventArgs e)
        {

            if (tCodeArticle.Text.Trim() != "")
            {

                if (test == true && tCodeAmodifie.Text.Trim() != "")
                {

                    ModificationChambre();
                    ChargmenArticledg();

                }

                else
                {
                    InserChambre();
                    ChargmenArticledg();

                }
                chargemeentComboApresENRE();


            }

        }

        private void ChargmenArticledg()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tChambre.TarifChambre, tCatChambre.DesCatCatChambre, tChambre.Compte " +
" FROM tChambre INNER JOIN " +
                         " tCatChambre ON tChambre.CategorieChambre = tCatChambre.IdCatChambre " +
" WHERE(tChambre.Compte = @Compte) " +
 " ORDER BY tChambre.CodeChambre DESC ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                dGArticle.DataSource = dt;

                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }

        DataTable TableChambre;
        private void ChargmenChambreAUdemarage()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        tChambre.CodeChambre, tChambre.DesignationChambre, tChambre.TarifChambre, tCatChambre.DesCatCatChambre, tChambre.Compte " +
" FROM tChambre INNER JOIN " +
                         " tCatChambre ON tChambre.CategorieChambre = tCatChambre.IdCatChambre " +
" WHERE(tChambre.Compte = @Compte) " +
 " ORDER BY tChambre.CodeChambre DESC ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Compte", ClassVaribleGolbal.CompteLogement);
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                // dGArticle.DataSource = dt;
                TableChambre = dt;
                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        private void ChargmentLogement()
        {
            try
            {

                Connection_Data();
                con.Open();
                //                cmd.CommandText = "SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte, tChambre.DesignationChambre, tClientProvisoire.Noms, tClientProvisoire.PrixConvenu,tClientProvisoire.DateSortie, tClientProvisoire.DateEntree " +
                //" FROM tClientProvisoire INNER JOIN " +
                //                        "  tChambre ON tClientProvisoire.ChambreActuel = tChambre.CodeChambre " +
                //" WHERE(tClientProvisoire.Etat = 0) " +
                //" ORDER BY tClientProvisoire.CompteClient DESC";
                cmd.CommandText = "SELECT        TOP (20) tClientProvisoire.CompteClient,tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Sexe, tClientProvisoire.DateNaiss, tCompte.DesignationCompte,tClientProvisoire.Compte " +
"  FROM tClientProvisoire INNER JOIN " +
                         " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" ORDER BY tClientProvisoire.IdClient DESC";


                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CompteClient", tCompteClient.Text.Trim());
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                DgClients.DataSource = dt;

                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }






        private void ChargmentLogement2()
        {
            try
            {

                Connection_Data();
                con.Open();
                //                cmd.CommandText = "SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte, tChambre.DesignationChambre, tClientProvisoire.Noms, tClientProvisoire.PrixConvenu,tClientProvisoire.DateSortie, tClientProvisoire.DateEntree " +
                //" FROM tClientProvisoire INNER JOIN " +
                //                        "  tChambre ON tClientProvisoire.ChambreActuel = tChambre.CodeChambre " +
                //" WHERE(tClientProvisoire.Etat = 0) " +
                //" ORDER BY tClientProvisoire.CompteClient DESC";



                cmd.CommandText = "SELECT        TOP (20) tClientProvisoire.CompteClient,tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, tClientProvisoire.Sexe, tClientProvisoire.DateNaiss, tCompte.DesignationCompte,tClientProvisoire.Compte " +
"  FROM tClientProvisoire INNER JOIN " +
                        " tCompte ON tClientProvisoire.Compte = tCompte.NumCompte " +
" ORDER BY tClientProvisoire.IdClient DESC";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CompteClient", tCompteClient.Text.Trim());
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                TableDgClients = dt;

                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }


        DataTable DtNuite;
        private void ChargmentLogementChambreOccuper()
        {
            
        }
        private void InserChambre()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "InserChambre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeChambre", tCodeArticle.Text);
                cmd.Parameters.AddWithValue("@CodeSeviceHosp", comboTypeHospCode.Text);
                cmd.Parameters.AddWithValue("@DesignationChambre", tDesignatonArticle.Text);
                cmd.Parameters.AddWithValue("@CategorieChambre", comboCatArti.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TarifChambre", tPrixdeVente.Text);
                cmd.Parameters.AddWithValue("@CreeerPar", utilisateur);
                // cmd.Parameters.AddWithValue("@Critique", tCritique.Text);
                cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text.Trim());
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST AJOUTE");
                //  InserMvtCpte("insererMvtcpt", tCodeArticle.Text, "0", "0", "0", "0", "0", ClassVaribleGolbal.OPinit);
                InserMvtCpte2("inserertMvtChambre", ClassVaribleGolbal.OPinit, tCodeArticle.Text, "0", "0", "0", "0", "1", "0", "0", "0");

                annulerArtclicle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message + " icc"); }

        }



        private void InserMvt()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "InserChambre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeChambre", tCodeArticle.Text);
                cmd.Parameters.AddWithValue("@DesignationChambre", tDesignatonArticle.Text);
                cmd.Parameters.AddWithValue("@CategorieChambre", comboCatArti.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TarifChambre", tPrixdeVente.Text);
                cmd.Parameters.AddWithValue("@CreeerPar", utilisateur);
                // cmd.Parameters.AddWithValue("@Critique", tCritique.Text);
                cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text.Trim());
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST AJOUTE");
                annulerArtclicle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void InserIdentite()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "InsertIdentite";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompteClient", tCompteClient.Text);
                cmd.Parameters.AddWithValue("@Compte", comboCompteIdent.Text);
                cmd.Parameters.AddWithValue("@Fiche", tFiche.Text);
                cmd.Parameters.AddWithValue("@Tele ", ttele.Text);
                cmd.Parameters.AddWithValue("@Noms", tNoms.Text);
                cmd.Parameters.AddWithValue("@PosteNom", tPostNom.Text);
                cmd.Parameters.AddWithValue("@Prenoms", tPrenoms.Text);
                cmd.Parameters.AddWithValue("@Sexe", comboSexe.Text);
                cmd.Parameters.AddWithValue("@Ntionnalite", tNationnalite.Text);
                //cmd.Parameters.AddWithValue("@Critique", );
                cmd.Parameters.AddWithValue("@NoCarte", tNoCarte.Text);
                cmd.Parameters.AddWithValue("@Foction", tFonction.Text);


                cmd.Parameters.AddWithValue("@Destinnation", tPrenoms.Text);
                cmd.Parameters.AddWithValue("@Provenance", tPostNom.Text);
                // cmd.Parameters.AddWithValue("@DateSortie", tdateSortie.Value);
                // cmd.Parameters.AddWithValue("@DateEntree", TdateEnntree.Value);


                cmd.Parameters.AddWithValue("@DateNaiss", tDateNaissance.Value);
                //  cmd.Parameters.AddWithValue("@ChambreActuel", comboCodeChambre.Text);
                //  cmd.Parameters.AddWithValue("@PrixConvenu", tPrixCovenu.Text);

                cmd.Parameters.AddWithValue("@CreerPar", utilisateur);
                cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST AJOUTE");
                annulerArtclicle();
                InserMvtCpte("inserertMvtClient", ClassVaribleGolbal.OPinit, tCompteClient.Text, "0", "0", "0", "0", "0", "0", "0", "0");

                //ModificationChambreOcuppe();

                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }




        private void modifierIdentite()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "ModifierIdent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompteClient", tCompteClient.Text);
                cmd.Parameters.AddWithValue("@Compte", comboCompteIdent.Text);
                //cmd.Parameters.AddWithValue("@ComptePartenaire", comboComptePart.Text);
                cmd.Parameters.AddWithValue("@Fiche", tFiche.Text);
                cmd.Parameters.AddWithValue("@Tele ", ttele.Text);
                cmd.Parameters.AddWithValue("@Noms", tNoms.Text);
                cmd.Parameters.AddWithValue("@PosteNom", tPostNom.Text);
                cmd.Parameters.AddWithValue("@Prenoms", tPrenoms.Text);
                cmd.Parameters.AddWithValue("@Sexe", comboSexe.Text);
                cmd.Parameters.AddWithValue("@Ntionnalite", tNationnalite.Text);
                //cmd.Parameters.AddWithValue("@Critique", );
                cmd.Parameters.AddWithValue("@NoCarte", tNoCarte.Text);
                cmd.Parameters.AddWithValue("@Foction", tFonction.Text);
                //
                cmd.Parameters.AddWithValue("@Destinnation", tPrenoms.Text);
                cmd.Parameters.AddWithValue("@Provenance", tPostNom.Text);
                // cmd.Parameters.AddWithValue("@DateSortie", tdateSortie.Value);
                // cmd.Parameters.AddWithValue("@DateEntree", TdateEnntree.Value);
                // AJOUT DE 

                cmd.Parameters.AddWithValue("@DateNaiss", tDateNaissance.Value);
                // cmd.Parameters.AddWithValue("@ChambreActuel",comboCodeChambre.Text);
                // cmd.Parameters.AddWithValue("@PrixConvenu", tPrixCovenu.Text);
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST AJOUTE");

                //ModificationChambreOcuppe();
                InserMvtCpte("inserertMvtClient", ClassVaribleGolbal.OPinit, tCompteClient.Text, "0", "0", "0", "0", "1", "0", "0", "0");

                annulerArtclicle();

                con.Close();
                cmd.Dispose();
            }









            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }


        //private void modifierIdentiteSanToucherLachambre()
        //{
        //    try
        //    {
        //        //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
        //        Connection_Data();
        //        con.Open();
        //        cmd.CommandText = "ModifierIdentSanChambre";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@CompteClient", tCompteClient.Text);
        //        cmd.Parameters.AddWithValue("@Compte", comboCompteIdent.Text);
        //        cmd.Parameters.AddWithValue("@ComptePartenaire", comboComptePart.Text);
        //        cmd.Parameters.AddWithValue("@Tele ", ttele.Text);
        //        cmd.Parameters.AddWithValue("@Noms", tNoms.Text);
        //        cmd.Parameters.AddWithValue("@Sexe", comboSexe.Text);
        //        cmd.Parameters.AddWithValue("@Ntionnalite", tNationnalite.Text);
        //        //cmd.Parameters.AddWithValue("@Critique", );
        //        cmd.Parameters.AddWithValue("@NoCarte", tNoCarte.Text);
        //        cmd.Parameters.AddWithValue("@Foction", tFonction.Text);


        //        cmd.Parameters.AddWithValue("@Destinnation", tPrenoms.Text);
        //        cmd.Parameters.AddWithValue("@Provenance", tPostNom.Text);
        //       // cmd.Parameters.AddWithValue("@DateSortie", tdateSortie.Value);
        //      //  cmd.Parameters.AddWithValue("@DateEntree", TdateEnntree.Value);


        //        cmd.Parameters.AddWithValue("@DateNaiss", tDateNaissance.Value);
        //      //  cmd.Parameters.AddWithValue("@ChambreActuel", comboCodeChambre.Text);
        //       // cmd.Parameters.AddWithValue("@PrixConvenu", tPrixCovenu.Text);
        //        cmd.ExecuteNonQuery();

        //        // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
        //        MessageBox.Show(" EST AJOUTE");

        //        //ModificationChambreOcuppe();
        //        InserMvtCpte("inserertMvtClient", ClassVaribleGolbal.OPinit, tCompteClient.Text, "0", "0", "0", "0", "0", "0", "0");

        //        annulerArtclicle();

        //        con.Close();
        //        cmd.Dispose();
        //    }



        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message); }

        //}
        //private void ModificationChambreOcuppe()
        //{
        //    string s = "UPDATE       tChambre SET                Etat =1, OcuperPar =@a, DateEntree =@da, DateSortie =@db WHERE CodeChambre =@b ";
        //    string[] r = { tCompteClient.Text, comboCodeChambre.Text };
        //    DateTime[] d = { DateTime.Parse(TdateEnntree.Text) , DateTime.Parse(tdateSortie.Text) };

        //    ClassRequette req = new ClassRequette();
        //    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
        //    //  DernierOP();
        //    //annuleVehicule();
        //    //  lmessage.Text = "&  Modification effectuée avec succès &";

        //    // bWchagementVehicule.RunWorkerAsync();
        //}



        private void ModificationChambreLibire(string CodeChambreALIBERE, int etat)
        {
            string s = "UPDATE       tChambre SET                Etat =" + etat + ", DateSortie =@da WHERE CodeChambre =@a ";
            string[] r = { CodeChambreALIBERE };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //  DernierOP();
            //annuleVehicule();
            //  lmessage.Text = "&  Modification effectuée avec succès &";

            // bWchagementVehicule.RunWorkerAsync();
        }


        private void ModificationClientLibre(string CodeClient, int etat)
        {
            string s = "UPDATE       tClientProvisoire SET     Etat =" + etat + ", DateLibere =@da WHERE CompteClient =@a ";
            string[] r = { CodeClient };
            DateTime[] d = { DateTime.Parse(tDate.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //  DernierOP();
            //annuleVehicule();
            //  lmessage.Text = "&  Modification effectuée avec succès &";

            // bWchagementVehicule.RunWorkerAsync();
        }
        private void ModificationChambre()
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                cmd.CommandText = "ModifierChambre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeChambre", tCodeArticle.Text);
                cmd.Parameters.AddWithValue("@DesignationChambre", tDesignatonArticle.Text);
                cmd.Parameters.AddWithValue("@CodeSeviceHosp", comboTypeHospCode.Text);
                cmd.Parameters.AddWithValue("@CategorieChambre", comboCatArti.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TarifChambre", tPrixdeVente.Text);
                cmd.Parameters.AddWithValue("@CodeChambre2", tCodeAmodifie.Text);
                // cmd.Parameters.AddWithValue("@Critique", tCritique.Text);
                //cmd.Parameters.AddWithValue("@DateCreation", tDate.Value);
                cmd.Parameters.AddWithValue("@Compte", comboCompte.Text.Trim());
                cmd.ExecuteNonQuery();

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                MessageBox.Show(" EST  MODIFIE");
                InserMvtCpte2("inserertMvtChambre", ClassVaribleGolbal.OPinit, tCodeArticle.Text, "0", "0", "0", "0", "0", "0", "0", "0");

                annulerArtclicle();
                con.Close();
                cmd.Dispose();
            }



            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);


            }

        }

        private void annulerArtclicle()
        {
            tCodeArticle.Text = "";
            tDesignatonArticle.Text = "";
            tPrixdeVente.Text = "";
            tCodeAmodifie.Text = "";
            DrnierOP();





        }

        private void dGArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tCodeArticle_TextChanged(object sender, EventArgs e)
        {




        }

        private void dGArticle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ci;
            ci = dGArticle.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tCodeAmodifie.Text = dGArticle["SousGroupe", ci].Value.ToString().Trim();




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        string DerinierArticle, DernienCompte, DernierNumOP;

        private void tCompteClient_TextChanged(object sender, EventArgs e)
        {

            try
            {
                test2 = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tClientProvisoire ";
                s = s + " where CompteClient=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tCompteClient.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {




                    tCompteClient.Text = lire["CompteClient"].ToString();
                    tFiche.Text = lire["Fiche"].ToString();
                    tNoms.Text = lire["Noms"].ToString();
                    comboSexe.Text = lire["Sexe"].ToString();
                    tNationnalite.Text = lire["Ntionnalite"].ToString();
                    tNoCarte.Text = lire["NoCarte"].ToString();
                    tFonction.Text = lire["Foction"].ToString();
                    tPrenoms.Text = lire["Prenoms"].ToString();
                    tPostNom.Text = lire["PosteNom"].ToString();
                    // tdateSortie .Text= lire["DateSortie"].ToString();
                    comboCompteIdent.Text = lire["Compte"].ToString();

                    // TdateEnntree.Text = lire["DateEntree"].ToString();
                    tDateNaissance.Text = lire["DateNaiss"].ToString();
                    // comboCodeChambre.Text = lire["ChambreActuel"].ToString();
                    // tPrixCovenu.Text = lire["PrixConvenu"].ToString();
                    test2 = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bEnreSupIdentite.Enabled = test2;
                if ((test2 == true))
                {
                    bEnreIdentite.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreIdentite.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        }


        Boolean passeNuite;
        string messageNuite;
        private void VericationPassageNuit()
        {
            try
            {
                string ReferenceOperation, DatedeLOperaion, Libelle, NomUt;
                passeNuite = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT        TypeOp, DateOp,NumOperation, Libelle, NomUt FROM tOperration " +
                  " WHERE (TypeOp = @a) AND (DateOp = @da) ";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", "1");
                cmd.Parameters.AddWithValue("@da", DateTime.Parse(tDate.Text));
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {


                    NomUt = lire["NomUt"].ToString();
                    Libelle = lire["Libelle"].ToString();
                    ReferenceOperation = lire["NumOperation"].ToString();
                    DatedeLOperaion = lire["DateOp"].ToString();
                    passeNuite = true;
                    messageNuite = " CET OPERATION EST DEJA PASSE REF :" + ReferenceOperation + " A LA DATE DU  " + DatedeLOperaion + "Ref:" + Libelle;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();

                //   MessageBox.Show(passeNuite.ToString() + "/" +tDate.Value.ToString());

                //bEnreSupIdentite.Enabled = test2;
                if ((passeNuite == true))
                {
                    //bEnreIdentite.Text = "&MODIFIER";
                    //  tlibeleAutp.Text = messageNuite;

                }
                else
                {


                    // tlibeleAutp.Text = libeleOP;
                    //cBmodifier.Checked = false;
                    //bEnreIdentite.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lmessage.Text = ex.Message;
            }

        }

        private void DgClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ci;
            ci = DgClients.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tCompteClient.Text = DgClients["CompteCl", ci].Value.ToString().Trim();



        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDesChambre_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        Boolean EtadeChambre;
        private void comboCodeChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //comboCodeChambre.ValueMember = "TarifChambre";
            //   // tTarrif.Text = comboCodeChambre.SelectedValue.ToString();
            //   // comboCodeChambre.ValueMember = "Etat";
            //    EtadeChambre = Boolean.Parse(comboCodeChambre.SelectedValue.ToString());
            //     if (EtadeChambre== true)
            //    {
            //        //  MessageBox.Show(comboCodeChambre.Text + "CETTE CHAMBRE EST OCCUPE DEJA PAR UN AUTRE CLEINT");
            //        lmessage.Text = comboCodeChambre.Text + "CETTE CHAMBRE EST OCCUPE DEJA PAR UN AUTRE CLEINT";
            //    }
            //     else
            //    {
            //        lmessage.Text = "CETTE CHAMBRE EST LIBRE";

            //    }
            //}

            //catch (Exception ex)
            //{

            //     lmessage.Text = ex.Message;

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //libeleOP = "FACTURATION  LOGEMENT DU " + tDate.Text + "EN " + tlbelle.Text;
            //ChargmentLogementChambreOccuper();
            //DrnierOpLogement();
            //VericationPassageNuit();

        }

        private void DgOccupeChambre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        // Boolean passeLAprocedureDenuit;
        private void button2_Click_1(object sender, EventArgs e)
        {

           


        }



        private void bwEnreNuitte_DoWork(object sender, DoWorkEventArgs e)
        {

            chargemeentDgFichesCas();
            //PasserLesNuite();



        }

        private void PasserLesNuite()
        {
            enregOpration();
            String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbNuite.Maximum = DtNuite.Rows.Count - 1;
            for (int i = 0; i <= DtNuite.Rows.Count - 1; i++)
            {
                bwEnreNuitte.ReportProgress(i);
                codeClient = DtNuite.Rows[i]["CompteClient"].ToString();
                CompteClien = DtNuite.Rows[i]["Compte"].ToString();
                CompteChambre = DtNuite.Rows[i]["CptCh"].ToString();
                CodeChambre = DtNuite.Rows[i]["CodeChambre"].ToString();
                Tarrif = DtNuite.Rows[i]["PrixConvenu"].ToString();

                InserMvtCpte2("inserertMvtChambre", numOperationLO, CodeChambre, Tarrif, "0", Tarrif, codeClient, "1", "0", "0", "0");

                InserMvtCpte("inserertMvtClient", numOperationLO, codeClient, Tarrif, "0", Tarrif, CodeChambre, "1", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", numOperationLO, CompteChambre, "0", Tarrif, Tarrif, CodeChambre, "1", "0", "0", "0");

                InserMvtCpte("insererMvtcpt", numOperationLO, CompteClien, Tarrif, "0", Tarrif, codeClient, "1", "0", "0", "0");


                //CptCh
                //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";



            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }


        string PcodeClient, PcompteCaisse, PcompteClient, PcodeChambre, plibelle, Pmotant, PnumOp, QteServ, PuServ;
        private void PasserPaiementFacture()
        {
            enregOprationPaiement();
            // String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbEnrePaiemnt.Maximum = 4;
            //MessageBox.Show("ok1");
            bWpasserLepaiemnet.ReportProgress(1);


            //   InserMvtCpte("inserertMvtChambre", CodeChambre, Tarrif, "0", Tarrif, codeClient);

            InserMvtCpte("inserertMvtClient", PnumOp, PcodeClient, "0", Pmotant, Pmotant, PcodeChambre, "2", "0", "0", "0");
            bWpasserLepaiemnet.ReportProgress(2);

            InserMvtCpte("insererMvtcpt", PnumOp, PcompteClient, "0", Pmotant, Pmotant, PcodeClient, "0", "0", "0", "0");
            bWpasserLepaiemnet.ReportProgress(3);

            InserMvtCpte("insererMvtcpt", PnumOp, PcompteCaisse, Pmotant, "0", Pmotant, PcodeClient, "0", "0", "0", "0");

            bWpasserLepaiemnet.ReportProgress(4);
            //CptCh
            //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";


            chargemeenDGpaiement();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }

        Boolean passeFacturation;

        private void PasserFacturation()
        {
            // enregOprationPaiement();
            // String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbEnrePaiemnt.Maximum = 4;
            // MessageBox.Show("ok1");
            bWpasserLepaiemnet.ReportProgress(1);

            //MessageBox.Show(PcodeClient2 +" NN "+ PcompCredit);
            //   InserMvtCpte("inserertMvtChambre", CodeChambre, Tarrif, "0", Tarrif, codeClient);


            //if (PourLeNouveaDeFactSeulement == false)


            // {


            // if (cash == false)
            {
                MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
               // InserMvtCpte("inserertMvtClient", PnumOp2, ComboFicheDeCasID.Text, Pmotant2, "0", tPu.Text, PcompCredit, "4", tQteP.Text, "0", comboCompteSevice.Text);
             //   InserMvtCpte2("inserertMvtChambre", PnumOp2, comboCompteSevice.Text, Pmotant2, "0", tPu.Text, PcompCredit, "4", tQteP.Text, "0", "0");
                InserMvtCpte("insererMvtcpt", PnumOp2, tCreditte2.Text, "0", Pmotant2, "1", PcompCredit, "4", "0", "0", "0");

            }
            bWpasserLepaiemnet.ReportProgress(2);
            // MessageBox.Show(PnumOp2);

            //InserMvtCpte("insererMvtcpt", PnumOp2, PcompCredit, "0", Pmotant2, PuServ, PcodeClient2, "4", "0", QteServ);
            bWpasserLepaiemnet.ReportProgress(3);
            // MessageBox.Show(PcodeClient2);
            // MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
            // InserMvtCpte("insererMvtcpt", PnumOp2, PcompteDebt, Pmotant2, "0", PuServ, PcompCredit, "4", QteServ, "0");

            bWpasserLepaiemnet.ReportProgress(4);
            //CptCh
            //}


            //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";


            chargemeenDGFacturationSerice();


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }


        Boolean BpasserEcriturePaiement;
        private void PasserPaiement()
        {
            enregOprationPaiement();
            // String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            PbEnrePaiemnt.Maximum = 4;
            // MessageBox.Show("ok1");
            bWpasserLepaiemnet.ReportProgress(1);



            //string s = " INSERT INTO    tMvtChambre    (NumOperation, NumCompte,QteSortie,QteEntree,Sortie,Entree)  Values (@a,@b,@c,@d,@e,@f)";
            //string s2 = " UPDATE   tOperration set    CompteDebit=@a, Remise=@b,Cash=@c WHERE (NumOperation=@d)";

            //string[] r = { tNumOp2.Text, "AU1", "1", "0", tNetApayer.Text, "0" };
            //string[] r2 = { tNumOp2.Text, "AU2", "1", "0", tRemise.Text, "0" };
           
            if (RbClientPriver.Checked == true)
            {
                ClassRequette req = new ClassRequette();
                string s = " INSERT INTO    tMvtChambre    (NumOperation, NumCompte,QteSortie,QteEntree,Sortie,Entree)  Values (@a,@b,@c,@d,@e,@f)";
                string[] r = { tNumOPpAIEMENT.Text, "AU1", "1", "0", tMotant.Text, "0" };
                DateTime[] d = { DateTime.Now };
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            }
            //else
            //{
            //    string[] r = { tNumOPpAIEMENT.Text, "AU1", "1", "0", tMotant.Text, "0" };

            //    DateTime[] d = { DateTime.Now };
            //    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //}

           
          
                MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
                InserMvtCpte("insererMvtcpt", tNumOPpAIEMENT.Text, tCaisseReception.Text, tMotant.Text, "0", "1", "1", "4", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", tNumOPpAIEMENT.Text, tCredit.Text, "0", tMotant.Text, "1", "1", "4", "0", "0", "0");

           
            
            
            bWpasserLepaiemnet.ReportProgress(2);
            // MessageBox.Show(PnumOp2);

            //InserMvtCpte("insererMvtcpt", PnumOp2, PcompCredit, "0", Pmotant2, PuServ, PcodeClient2, "4", "0", QteServ);
            bWpasserLepaiemnet.ReportProgress(3);
            // MessageBox.Show(PcodeClient2);
            // MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
            // InserMvtCpte("insererMvtcpt", PnumOp2, PcompteDebt, Pmotant2, "0", PuServ, PcompCredit, "4", QteServ, "0");

            bWpasserLepaiemnet.ReportProgress(4);
            //CptCh
            //}


            //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";


            //chargemeenDGFacturationSerice();
            chargemeenDGPourLESpaiement();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }



        private void PasserFacturationInitialFact()
        {
            // enregOprationPaiement();
            // String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //PbEnrePaiemnt.Maximum = 4;
            // MessageBox.Show("ok1");
            bWpasserLepaiemnet.ReportProgress(1);

            //MessageBox.Show(PcodeClient2 +" NN "+ PcompCredit);
            //   InserMvtCpte("inserertMvtChambre", CodeChambre, Tarrif, "0", Tarrif, codeClient);


            //if (PourLeNouveaDeFactSeulement == false)


            // {
            String CodeChambrINI;
            PbEnrePaiemnt.Maximum = TableComteVenteService.Rows.Count - 1;
            for (int i = 0; i <= TableComteVenteService.Rows.Count - 1; i++)
            {


                bWpasserLepaiemnet.ReportProgress(i);
                CodeChambrINI = TableComteVenteService.Rows[i]["CodeChambre"].ToString();
                //  MessageBox.Show(CodeChambrINI + " N");

                //InserMvtCpte("inserertMvtClient", PnumOp2, ComboFicheDeCasID.Text, Pmotant2, "0", tPu.Text, PcompCredit, "4", tQteP.Text, "0", comboCompteSevice.Text);
                InserMvtCpte2("inserertMvtChambre", tNumOp2.Text, CodeChambrINI, "0", "0", "0", "0", "4", " 0", "0", "0");
                // InserMvtCpte("insererMvtcpt", PnumOp2, tCreditte2.Text, "0", Pmotant2, "1", PcompCredit, "4", "0", "0", "0");

            }
            bWpasserLepaiemnet.ReportProgress(2);
            // MessageBox.Show(PnumOp2);

            //InserMvtCpte("insererMvtcpt", PnumOp2, PcompCredit, "0", Pmotant2, PuServ, PcodeClient2, "4", "0", QteServ);
            bWpasserLepaiemnet.ReportProgress(3);
            // MessageBox.Show(PcodeClient2);
            // MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
            // InserMvtCpte("insererMvtcpt", PnumOp2, PcompteDebt, Pmotant2, "0", PuServ, PcompCredit, "4", QteServ, "0");

            bWpasserLepaiemnet.ReportProgress(4);
            //CptCh
            //}


            //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";


            chargemeenDGFacturationSerice();


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }

        Boolean FactureDejaPayer;
        private void PasserFacturation2()
        {
            // enregOprationPaiement();
            // String codeClient, CodeChambre, CompteClien, CompteChambre, Tarrif;

            Connection_Data();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //PbEnrePaiemnt.Maximum = 4;
            // MessageBox.Show("ok1");
            // bWpasserLepaiemnet.ReportProgress(1);

            //MessageBox.Show(PcodeClient2 +" NN "+ PcompCredit);
            //   InserMvtCpte("inserertMvtChambre", CodeChambre, Tarrif, "0", Tarrif, codeClient);


            //if (PourLeNouveaDeFactSeulement == false)


            // {


            if (rBcASH.Checked == true || rBAbonnem.Checked == true)

            {
               // MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
               // InserMvtCpte("inserertMvtClient", PnumOp2, ComboFicheDeCasID.Text, "0", "1", "1", "1", "4", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", tNumOp2.Text, tAdebut2.Text, tNetApayer.Text, "0", "1", "1", "4", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", tNumOp2.Text, tCreditte2.Text, "0", tSommeFact.Text, "1", "1", "4", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", tNumOp2.Text,ClassVaribleGolbal.CompteRemise, tRemise.Text, "0", "1", "1", "4", "0", "0", "0");

                // InserMvtCpte("insererMvtcpt", PnumOp2, ComboFicheDeCasID.Text, "0", tSommeFact.Text, "1", PcompCredit, "4", "0", "0");

                //CompteRemise
               /// MessageBox.Show("cach et abbonne");
                // InserMvtCpte("inserertMvtChambre", PnumOp2, comboCompteSevice.Text, Pmotant2, "0", tPu.Text, PcompCredit, "4", tQteP.Text, "0");

            }

            else
            {

                InserMvtCpte("insererMvtcpt", tNumOp2.Text, tAdebut2.Text, tSommeFact.Text, "0", "1", "1", "4", "0", "0", "0");
                InserMvtCpte("insererMvtcpt", tNumOp2.Text, tCreditte2.Text, "0", tSommeFact.Text, "1", "1", "4", "0", "0", "0");

                
                // InserMvtCpte("insererMvtcpt", PnumOp2, ComboFicheDeCasID.Text, "0", tSommeFact.Text, "1", PcompCredit, "4", "0", "0");

               // MessageBox.Show("privee");
            }
            //bWpasserLepaiemnet.ReportProgress(2);
            // MessageBox.Show(PnumOp2);

            //InserMvtCpte("insererMvtcpt", PnumOp2, PcompCredit, "0", Pmotant2, PuServ, PcodeClient2, "4", "0", QteServ);
            //  bWpasserLepaiemnet.ReportProgress(3);
            // MessageBox.Show(PcodeClient2);
            // MessageBox.Show(PcodeClient2 + " NN " + PcompCredit);
            // InserMvtCpte("insererMvtcpt", PnumOp2, PcompteDebt, Pmotant2, "0", PuServ, PcompCredit, "4", QteServ, "0");

            //bWpasserLepaiemnet.ReportProgress(4);
            //CptCh
            //}


            //journalSup = journalSup + COMPTE + "= " + Des + " ," + numop + ", " + montantc + "," + motantd + ", ";


            // chargemeenDGFacturationSerice();

            tSommeFact.Text = "";
            tRemise.Text = "0";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
            cmd.Dispose();


        }


        private void InsertionDepaiementEtRemise()
        {

            string CachPaiem;
            if (rBcASH.Checked==true)
            {
                CachPaiem = "1";

            }
            else if (rBAbonnem.Checked == true)
            {
                CachPaiem = "2";

            }

            else
            {
                CachPaiem = "3";

            }






                try
                    {
                        //TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                 string s = " INSERT INTO    tMvtChambre    (NumOperation, NumCompte,QteSortie,QteEntree,Sortie,Entree)  Values (@a,@b,@c,@d,@e,@f)";
                string s2 = " UPDATE   tOperration set    CompteDebit=@a, Remise=@b,Cash=@c,Valider=1 WHERE (NumOperation=@d)";

                string[] r = { tNumOp2.Text, "AU1", "1", "0", tNetApayer.Text,"0" };
                          string[] r2 = { tNumOp2.Text, "AU2", "1","0", tRemise.Text, "0" };
                string[] r3 = { tAdebut2.Text, tRemise.Text, CachPaiem, tNumOp2.Text };
                DateTime[] d = { DateTime.Now };

                        ClassRequette req = new ClassRequette();
                        if (rBcASH.Checked == true || rBAbonnem.Checked == true)
                        {

                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);
                        }
                       
                        
                         req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r3, d);


                //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
            }

            catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                

            
            MessageBox.Show("modification reussi");

        }
        private void InserMvtCpte(string storage, String Op, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string QteEntree, String QteSortie, String AutresCpt)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                //Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", Op.Trim());
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", QteEntree);
                cmd.Parameters.AddWithValue("@QteSortie ", QteSortie);
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", "0");
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.Parameters.AddWithValue("@AutresCpt", AutresCpt);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(" EST AJOUTE");
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
           }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " en ref " + NumCompte);
               lmessage.Text = ex.Message + " en ref " + NumCompte;
            }

        }

        private void InserMvtCpte2(string storage, String Op, string NumCompte, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string QteEntree, String QteSortie, String AutresCpt)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                //Connection_Data();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", Op.Trim());
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                cmd.Parameters.AddWithValue("@CodeDepot","CD2");
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", QteEntree);
                cmd.Parameters.AddWithValue("@QteSortie ", QteSortie);
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", "0");
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.Parameters.AddWithValue("@AutresCpt", AutresCpt);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(" EST AJOUTE");
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " en ref " + NumCompte);
                lmessage.Text = ex.Message + " en ref " + NumCompte;
            }

        }
        private void enregOpration()

        {
            try
            {

                string s = " INSERT INTO tOperration " +
                       "  (NumOperation, Libelle, NomUt, Compte,TypeOp, DateOp) " +
            " VALUES(@a, @b, @c, @d,@e, @da)";

                string[] r = { tNumOp.Text, libeleOP, utilisateur, "0", "1" };
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //AnnulerDepensePlan();
                //  lmessage.Text = "&  DEPENSE AJOUTEE &";
                //bWchagementVehicule.RunWorkerAsync();
                //chargemeentDgPlanDepenses();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " en ref ");
                //lmessage.Text = ex.Message + " en ref " + NumCompte;
            }

        }




        private void enregOprationPaiement()
        {

            try
            {

                string s = " INSERT INTO tOperration " +
                              "  (NumOperation,RefCas, Libelle, NomUt, Compte,TypeOp,BeneFiciare, DateOp) " +
                   " VALUES (@a, @b, @c, @d,@e,@f,@g, @da) ";

                string[] r = { tNumOPpAIEMENT.Text, "AUTRE", tLiblllePaiement.Text, utilisateur, "0", "2", comboPComptreDes.Text };

                string[] r2 = { tNumOPpAIEMENT.Text, comboDernierCas.Text, tLiblllePaiement.Text, utilisateur, "0", "2", comboPComptreDes.Text };
              
                DateTime[] d = { DateTime.Parse(tDate.Text) };

                ClassRequette req = new ClassRequette();
                if (RbClientPriver.Checked == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                }
               
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

        private void enregOprationFactuarion()
        {
            try
            {

                string s = " INSERT INTO tOperration " +
                             "  (NumOperation,RefCas, Libelle, NomUt, Compte,TypeOp,BeneFiciare, DateOp) " +
                  " VALUES (@a, @b, @c, @d,@e,@f,@g, @da) ";

                string[] r = { tNumOp2.Text, comboIdCas2.Text, tLibelleFacrtation.Text, utilisateur, "0", "2", tPour.Text };
                DateTime[] d = { DateTime.Parse(tDate.Text) };

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





        String ChambreOccuperPar;
        Boolean ChambreLibre2;
        //        private void VerifierLavhambre()
        //        {

        ////bwConnexion.ReportProgress(3);
        //            Connection_Data();
        //            con.Open();
        //            cmd.CommandText = "SELECT        Noms, ChambreActuel  FROM            tClientProvisoire " +
        //                    " WHERE        (ChambreActuel =@ChambreActuel) AND (Etat = 0)";

        //            cmd.Connection = con;
        //            cmd.Parameters.AddWithValue("@ChambreActuel", comboCodeChambre.Text);
        //            /// cmd.Parameters.AddWithValue("@MotPasseUtilisateur", motDepasse);

        //            // cmd.Parameters.AddWithValue("@MotDePass", motDepasse);
        //            String CHAMBRE;

        //            da.Fill(dt);
        //            con.Close();
        //            if (dt.Rows.Count > 0)
        //            {

        //                ChambreLibre2 = true;
        //                //Session["id"] = TextBox1.Text;
        //                //Response.Redirect("VenteForm1.aspx");
        //                //Session.RemoveAll();
        //                ChambreOccuperPar = dt.Rows[0]["Noms"].ToString();
        //                // ClassVaribleGolbal.UTILISATEUR = dt.Rows[0]["NomUtilisateur"].ToString();
        //                 CHAMBRE = dt.Rows[0]["ChambreActuel"].ToString();
        //                // Foction = dt.Rows[0]["FonctionUt"].ToString();
        //                MessageBox.Show(" LA CHAMBRE " + CHAMBRE + " EST OCCUPE PAR " + ChambreOccuperPar);
        //               // ConneCTER = true;
        //            }
        //            else
        //            {
        //                ChambreOccuperPar = "";
        //                ChambreLibre2 = false;
        //              ///  ConneCTER = false;
        //              /// Label1.Text = "You're username and word is incorrect";
        //                //Label1.ForeColor = System.Drawing.Color.Red;
        //                // bwConnexion.ReportProgress(4);

        //            }

        //        }


        private void button2_Click(object sender, EventArgs e)
        {




            // from Steve
            //VerifierLavhambre();
            if (tNoms.Text.Trim() != "")
            {
                if (test2 == true)
                {

                    modifierIdentite();




                    ChargmentLogement();
                    chargemeentComboApresENRE();
                    //ChargmentLogement()
                }
                else
                {
                    InserIdentite();
                    AnnuleChambre();



                    ChargmentLogement();

                }
                // chargemeentComboApresENRE();
            }
            else
            {
                MessageBox.Show(" COMPLETER LES NOMS  OU LES PRIX DOIVENT ETRE NUMIRIQUE OU LA CHAMBRE EST OCCUPPEE");

            }

            DrnierClient();

        }

        private void bwEnreNuitte_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //PbNuite.Visible = false;
            //MessageBox.Show("L'ENREGISTREMENT EFFECTUE ");
            //   paiementDesFactureReception = false;
            dgFicheDeCas.DataSource = TableCasParFche;
        }

        private void bwEnreNuitte_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PbNuite.Value = e.ProgressPercentage;
        }

        private void tlbelle_TextChanged(object sender, EventArgs e)
        {
            if (passeNuite == false)
            {
                //tlibeleAutp.Text = libeleOP + tlbelle.Text;

            }
        }

        private void tlibeleAutp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDateNaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bEnreSupIdentite_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RES = MessageBox.Show(" \n" + "VOULEZ VOUS VRAIMENT SUPPRIMER CE MALADE ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    /// ModificationChambreLibire(tCodeArticle.Text, 0);
                    /// 

                    //  VerificationDeCasActuelModification();



                    //UpdateCas();
                    //  SupprimerLesCas();
                    SupprimerLesMalade();
                        AnnuleChambre();
                        ChargmentLogement();
                        chargemeentComboApresENRE();
                  

                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void DgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //charmementBWpaiement();
            ProcedureChargemennPaiement();
        }

        private void bWchargmentPaiement_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentComboPaiment();
        }

        private void bWchargmentPaiement_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //DrnierOpPaiement();
            //  DrnierOpPaiement2();
            //comboPCodeClient.DataSource = ComboPaiement;
            //comboPCodeClient.DisplayMember = "CompteClient";
            //comboPCodeClient.ValueMember = "CompteClient";

            ComboFicheDeCasID.DataSource = ComboPaiement;
            ComboFicheDeCasID.DisplayMember = "CompteClient";
            ComboFicheDeCasID.ValueMember = "CompteClient";

            ComboFicheDeCasIDdes.DataSource = ComboPaiement;
            ComboFicheDeCasIDdes.DisplayMember = "NOM";
            ComboFicheDeCasIDdes.ValueMember = "CompteClient";


            comboPosteNom.DataSource = ComboPaiement;
            comboPosteNom.DisplayMember = "Fiche";
            comboPosteNom.ValueMember = "CompteClient";

            comboPresNoms.DataSource = ComboPaiement;
            comboPresNoms.DisplayMember = "Prenoms";
            comboPresNoms.ValueMember = "CompteClient";


            comboIdCas2Des.DataSource = ComboPaiement;
            comboIdCas2Des.DisplayMember = "Diagnostic";
            comboIdCas2Des.ValueMember = "RefCas";

            comboIdCas2.DataSource = ComboPaiement;
            comboIdCas2.DisplayMember = "RefCas";
            comboIdCas2.ValueMember = "RefCas";

            //comboPDsiengantion.DataSource = ComboPaiement;
            //comboPDsiengantion.DisplayMember = "Noms";
            //comboPDsiengantion.ValueMember = "Noms";


            // comboIdCas2.DataSource = ComboPaiement;
            //  comboIdCas2.DisplayMember = "Noms";
            //  comboIdCas2.ValueMember = "Noms";


        }

        private void comboPCodeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //comboPCompte.ValueMember = "Compte";
                //tCredit.Text = comboPCompte.SelectedValue.ToString();
                //comboPCompte.ValueMember = "CompteClient";

                tCredit.Text = comboPCompte.Text;
                 if  (RbClientPriver.Checked ==true)
                 {
                     BchargementFiche2 = true;
                     BparaFichePaiement = true;


                     if (bWoperationDivers.IsBusy == false)
                     {
                         bWoperationDivers.RunWorkerAsync();
                     }
                     else
                     {
                         lmessage.Text = "LES PROCESSUS ENCOUR";
                     }

                 
                 }


            }
            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }
        }

        private void RbClientDeChambre_CheckedChanged(object sender, EventArgs e)
        {
            ProcedureChargemennPaiement();


        }

        private void ProcedureChargemennPaiement()
        {
            tCaisseReception.Text = ClassVaribleGolbal.CaisseReception;

            Pfiche.Visible = RbClientPriver.Checked;
            lCAS.Visible = RbClientPriver.Checked;
            comboDernierCas.Visible = RbClientPriver.Checked;

            BchargementComboPaiement = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();
            }    
        }
        /// Boolean paiementDesFactureReception;
        private void button4_Click_1(object sender, EventArgs e)
        {

            BpasserEcriturePaiement = true;

            DrnierOpPaiement();
            if ((verifierNumbe.IsNumeric(tMotant.Text) == true) & (tLiblllePaiement.TextLength > 10))
            {
                if (bWchargmentPaiement.IsBusy == false)
                {
                    bWpasserLepaiemnet.RunWorkerAsync();

                }

            }
            else
            {

                MessageBox.Show(" LE MONTAN DOIT ETRE NUMERIC  OU LE LIBELLE DOIT AVOIR AU MOIN 10 LETTRE");

            }



        }

        private void bWpasserLepaiemnet_DoWork(object sender, DoWorkEventArgs e)
        {
            //  PasserPaiementFacture();
            if (passeFacturation == true)
            {
                PasserFacturation();
            }
            else if (BpasserEcriturePaiement == true)
            {
                PasserPaiement();
            
            }
            else if (BcharmenntTableMedicament==true)
            {
                chargemeenDGFacturationPourMedicament();
            }

            else
            {
                PasserFacturationInitialFact();
            }

        }

        private void bWpasserLepaiemnet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (BpasserEcriturePaiement == true)
            {
                //DrnierOpPaiement();
                DgPaiement.DataSource = tablePaiementPourHOP;
            }
             else if  (BcharmenntTableMedicament == true)
            {
                dgFacturation.DataSource = TableMedicamenentFact;
                // chargemeenDGFacturationPourMedicament
            }
            else
            {
                dgFacturation.DataSource = TableFacturation;
            }


            BcharmenntTableMedicament = false;
            passeFacturation = false;
            BpasserEcriturePaiement = false;
          
         
            //charmementBWpaiement();
            tSommeFact.Text = SommeFact.ToString();
            PbEnrePaiemnt.Visible = false;
           






        }

        private void bWpasserLepaiemnet_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PbEnrePaiemnt.Value = e.ProgressPercentage;
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(DgSoldeClientDechambre.CurrentCell.Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bWchargementSolde_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentDgSoleClienChambre();
        }

        private void bWchargementSolde_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DgSoldeClientDechambre.DataSource = TableChambreSolde;
           // CaisseReception = CompteDEservicleint(51, 2);
        }

        Boolean logeENCOUR, logesortieDette, LogeSotrie;
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

            procedureChargemntDgSolde();
        }

        private void rbSortie_CheckedChanged(object sender, EventArgs e)
        {
            
            procedureChargemntDgSolde();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            // if (tDate1.Value <= tdate2.Value)
            //  {
            try
            {

                string codecl;
                // ConsommationDeproduits();
                int ci = DgSoldeClientDechambre.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactGobal";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@RefCas", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdate2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportFact.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                // fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
            // }
            //else
            //{
            //    MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            //}





        }

        private void procedureChargemntDgSolde()
        {

            logeENCOUR = rbCasAtuelVer.Checked;
            logesortieDette = rbAmbilatoir.Checked;
            LogeSotrie = rbHospitalise.Checked;

            if (bWchargementSolde.IsBusy == false)
            {
                bWchargementSolde.RunWorkerAsync();
            }
            else
            {
                // MessageBox.Show("LES PROCESSUS EST ENCOUR");
                lmessage.Text = ("LES PROCESSUS EST ENCOUR");


            }
        }
        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {


            procedureChargemntDgSolde();
            //if (bWchargementSolde.IsBusy == false)
            //{
            //    bWchargementSolde.RunWorkerAsync();
            //}
            //else
            //{
            //    MessageBox.Show("LES PROCESSUS EST ENCOUR");


            //}
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            //lPour.Visible = rbCash.Checked;
            //tPour.Visible = rbCash.Checked;
            //PCredit.Visible = rbCredit.Checked;
            DrnierOpPaiement2();
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            //PCredit.Visible = rbCredit.Checked;
            //lPour.Enabled = rbCash.Checked;
            //tPour.Enabled = rbCash.Checked;
            //DrnierOpPaiement2();
            //tAdebut2.Text = "";
            //if (rbCash.Checked==true)
            //{
            //    tAdebut2.Text = CaisseReception;
            //}
            //else
            //{

            //}
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiement();
        }

        private void rbLoge2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
            DrnierOpPaiement2();
        }

        private void rbClientOCCasionnel2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }

        private void rBclientOrd2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }


        private void UpdateInit(string datejour)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();
                Connection_Data();
                con.Open();
                String s = " UPDATE tOperration  SET NumOperation = @NumOperation, DateOp = @DateOp " +
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
            { MessageBox.Show(" CE SOUS GROUPE  PEUT AVOIR DES COMPTES VOUS POUVEZ SEULEMENT LE MODIFIER " + ex.Message); }

        }
        private void button7_Click(object sender, EventArgs e)
        {



            // if (tDate1.Value <= tdate2.Value)
            //  {
            try
            {



                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactureParOrganisation";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", DateTime.Parse(tdate2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportPaeServiceFact.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }





        }


        DataTable RapportSommaireTou1, RapportSommaireTou2;
        private void ChargmenRapporSommeare()
        {
            try
            {


                string sCompte = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, SUM(tMvtStock.QteEntree) AS SqteEntree, SUM(tMvtStock.QteSortie) AS SqteSortie, " +
                         " SUM(tMvtStock.Entree) AS SEntree, SUM(tMvtStock.Sortie) AS Ssortie, tDepot.CodeDepot, tDepot.DesignationDepot, MIN(tOperration.DateOp) AS MinDate, MAX(tOperration.DateOp) AS MaxDate," +
                       "  tEntrepise.Designation, tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site " +
" FROM            tStock INNER JOIN " +
                        " tMvtStock ON tStock.CodeArticle = tMvtStock.NumCompte INNER JOIN " +
                        " tOperration ON tMvtStock.NumOperation = tOperration.NumOperation INNER JOIN " +
                        " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        " tCompte ON tStock.Compte = tCompte.NumCompte CROSS JOIN " +
                         " tEntrepise " +
                         " WHERE(tOperration.DateOp BETWEEN  @da AND @db) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tStock.CodeArticle, tStock.DesegnationArticle, tStock.CategorieArticle, tDepot.CodeDepot, tDepot.DesignationDepot, tEntrepise.Designation, " +
                       "   tEntrepise.Adresse1, tEntrepise.Adresse2, tEntrepise.TeleEnt, tEntrepise.Email, tEntrepise.Site " +
                "  HAVING(tDepot.CodeDepot = @a)";

                string sCompte2 = " SELECT        SUM(tMvtStock.QteEntree) - SUM(tMvtStock.QteSortie) AS Enstok, tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot, SUM(tMvtStock.Entree) - SUM(tMvtStock.Sortie) " +
                        "  AS Solde " +
" FROM tOperration INNER JOIN " +
                        " tMvtStock ON tOperration.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.NumCompte = tStock.CodeArticle " +
" WHERE(tOperration.DateOp BETWEEN CONVERT(DATETIME, '2011-01-01 00:00:00', 102) AND @db) " +
 " GROUP BY tStock.CodeArticle, tStock.DesegnationArticle, tDepot.CodeDepot, tDepot.DesignationDepot " +
              "  HAVING(tDepot.CodeDepot = @a)";


                string[] r = { "" };
                DateTime[] d = { DateTime.Parse(tDate1.Text), DateTime.Parse(tdate2.Text) };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametreDate(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou1 = classeReq.dt;
                classeReq.chargementAvecLesParametreDate(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r, d);
                RapportSommaireTou2 = classeReq.dt;
                string chiminRap = "Rapport/ReportSommaireCroise.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(RapportSommaireTou1, chiminRap, "DataSet1");
                fo.chargemenentRapporteAveVDataSetPro(RapportSommaireTou2, chiminRap, "DataSet2");
                fo.Show();





                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                // CbGroupe2 = classeReq.dt;

                // classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                //CbGroupe3 = classeReq.dt;












            }
            catch (Exception ex)
            {

                lmessage.Text = ex.Message;

            }








            //  da.Dispose();
        }

        private void comboCompteDesClient2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                tPour.Text = comboIdCas2.Text;
                 if ( RbValidationFact.Checked==true)
                {
                    BoperationFact = true;
                    if (bWoperationDivers.IsBusy == false)
                    {
                        bWoperationDivers.RunWorkerAsync();
                    }
                }
             

            }
            catch
            { }
        }

        private void comboCodeClient2_SelectedIndexChanged(object sender, EventArgs e)
        {


            //try
            //{
            //   if  (rbCredit.Created==true)
            //        {
            //        comboCodeClient2.ValueMember = "Compte";
            //        tAdebut2.Text = comboCodeClient2.SelectedValue.ToString();
            //        comboCodeClient2.ValueMember = "CompteClient";

            //    }
            //    else if (rbCash.Checked== true) 

            //    {
            //        tAdebut2.Text = CaisseReception;

            //    }

            //}
            //catch (Exception ex)
            //{

            //    // lmessage.Text = ex.Message;

            //}

        }

        private void comboCompteSevice_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboCompteDesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // enregOprationPaiement();
            enregOprationFactuarion();
            //panelOperation.Enabled = true;
            PCredit.Enabled = false;
            //pCache.Enabled = false;
            pvALIDE.Enabled = false;
            ModificationF = false;
            ChargementAjoutFact();
            FactureDejaPayer = false;
        }

        private void panel17_Paint_1(object sender, PaintEventArgs e)
        {

        }
        Boolean PourLeNouveaDeFactSeulement;

        private void button9_Click(object sender, EventArgs e)
        {
            //enregOprationPaiement();
            // PourLeNouveaDeFactSeulement = true;
            DrnierOpPaiement2();
            PCredit.Enabled = true;
            //pCache.Enabled = true;
            pvALIDE.Enabled = true;
            bNauveau.Enabled = false;
            //panelOperation.Enabled = false;

            chargemeenDGFacturationSericeVide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DrnierOpPaiement2();
            PCredit.Enabled = true;
            // pCache.Enabled = true;
            pvALIDE.Enabled = true;
            bNauveau.Enabled = false;
            //panelOperation.Enabled = false;

            chargemeenDGFacturationSericeVide();


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        string CodeChambreAfactre2, compteClient;
        private void ComboChambreOcuppe2_SelectedIndexChanged(object sender, EventArgs e)
        { try
            {
                CodeChambreAfactre2 = ComboFicheDeCasID.SelectedValue.ToString();
                ComboFicheDeCasID.ValueMember = "Compte";
                compteClient = ComboFicheDeCasID.SelectedValue.ToString();
                ComboFicheDeCasID.ValueMember = "CompteClient";
                tAdebut2.Text = compteClient;
                ChargementDelOperation();

            }
            catch
            { }

        }


        private void ChargementDelOperation()
        {
            tLibelleFacrtation.Text = "FACTURATION   SERVICE  EN REF:  " + comboIdCas2.Text + " /" + ComboFicheDeCasIDdes.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show(" ce bon");
                this.reportViewer1.LocalReport.DataSources.Clear();
                tabControl1.SelectedTab = tabPagImpresion;
                //ChargementFactureMedicament();

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportRecuPourCaisse";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumOperation", tNumOPpAIEMENT.Text);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/Report2.rdlc";
               // string chiminRap2 = "Rapport/Hop/ReportFactueMedicament.rdlc";
               // FormEtat fo = new FormEtat();
               
                    // fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    // fo.chargemenentRapporteAveVDataSetPro(TableFactureMedicament, chiminRap2, "DataSet2");
                    //fo.Show();
                    chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                   // chargemenentRapporteAveVDataSetPro(TableFactureMedicament, chiminRap2, "DataSet2");
              
                    // fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    // // fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                    //  fo.Show();
                   // chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }




        }

        private void tQteP_TextChanged(object sender, EventArgs e)
        { try
            {
                //tTotal.Text = (double.Parse(tPu.Text) * double.Parse(tQteP.Text)).ToString();
            }
            catch
            {

            }

        }

        private void tPu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //tTotal.Text = (double.Parse(tPu.Text) * double.Parse(tQteP.Text)).ToString();
            }
            catch
            {

            }
        }

        Boolean cash;

        private void tCodeAmodifie_TextChanged(object sender, EventArgs e)
        {
            try
            {
                test = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from  tChambre ";
                s = s + " where CodeChambre=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tCodeAmodifie.Text.Trim());
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {

                    tCodeArticle.Text = lire["CodeChambre"].ToString();
                    tCodeAmodifie.Text = lire["CodeChambre"].ToString();
                    tDesignatonArticle.Text = lire["DesignationChambre"].ToString();
                    comboCatArti.SelectedValue = lire["CategorieChambre"].ToString();
                    tPrixdeVente.Text = lire["TarifChambre"].ToString();
                    // tCritique.Text = lire["Critique"].ToString();
                    comboCompte.SelectedValue = lire["Compte"].ToString();
                    //txtProvenance.Text = lire["ProvEcole"].ToString();
                    //cbReligieux.Text = lire["Confession"].ToString();
                    //txtLieuNais.Text = lire["lieuNais"].ToString();
                    //dateNaiss.Text = lire["DateNais"].ToString();

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

        private void bSupprimmer_Click(object sender, EventArgs e)

        {
            DialogResult RES = MessageBox.Show(" \n" + "VOULEZ VOUS VRAIMENT FORCER DE  LIBEREZ LA CHAMBRES ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                ModificationChambreLibire(tCodeArticle.Text, 0);

            }

        }

        private void rbLogeEncour_Click(object sender, EventArgs e)
        {
            procedureChargemntDgSolde();
        }

        private void rbLogeSortieDette_Click(object sender, EventArgs e)
        {
            procedureChargemntDgSolde();
        }

        private void rbSortie_Click(object sender, EventArgs e)
        {
            tDateVerification.Visible = rbHospitalise.Checked;
            if (rbHospitalise.Checked == true)
            {

                Datedeverication = tDateVerification.Text;
            }
            procedureChargemntDgSolde();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            //        if (tDateR1.Value <= tdateR2.Value)
            //        {

            //            try
            //            {
            //                //string codecl;

            //                //int ci = DgMouvementService.CurrentRow.Index;
            //                //codecl = DgPaiement[ir]["CompteClient"].ToString();
            //                //codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
            //                //MessageBox.Show(codecl);

            //                CharrrmentRapporSommairSerice();
            //                Connection_Data();
            //                con.Open();
            //                cmd.CommandText = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie, SUM(tMvtCompte.QteEntree) AS QteEntree, " +
            //"   SUM(tMvtCompte.QteSortie) AS QteSortie, MAX(tOperration.DateOp) AS MaxDateMVT FROM tCompte INNER JOIN " +
            //                        "  tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
            //                         " tOperration ON tMvtCompte.NumOperation = tOperration.NumOperation " +
            //" WHERE(tOperration.DateOp BETWEEN @date1 AND @date2) " +
            //" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
            //" HAVING(tCompte.GroupeCompte = 411) OR " +
            //                 " (tCompte.GroupeCompte = 412) OR " +
            //                "  (tCompte.GroupeCompte = 571)";


            //                cmd.CommandType = CommandType.Text;
            //                cmd.Parameters.Clear();
            //                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
            //                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
            //                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
            //                cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
            //                //  MessageBox.Show(codecl);
            //                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
            //                da.Fill(dt);
            //                con.Close();
            //                string chiminRap = "Rapport/ReportSommairCompteService.rdlc";
            //                FormEtat fo = new FormEtat();
            //                fo.chargemenentRapporteAveVDataSetPro(TableRapporSommair, chiminRap, "DataSet1");
            //                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet2");
            //                fo.Show();

            //            }

            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message);

            //                // lmessage.Text = ex.Message;

            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            //        }




        }

        DataTable TableRapporSommair;

        private void CharrrmentRapporSommairSerice()
        {
            try
            {
                string codecl;

                // int ci = DgMouvementService.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                //  codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
                // MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        GroupeCompte, Cadre, DesignationGroupe, DesignationCompte, NumCompte, SUM(Solde) AS Solde , IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site " +
" FROM VSodeDEcompteAU " +
" WHERE(DateOp BETWEEN CONVERT(DATETIME, '2011-01-01 00:00:00', 102) AND @date2 ) " +
" GROUP BY GroupeCompte, Cadre, DesignationGroupe, DesignationCompte, NumCompte, IdEntreprise, Designation, Adresse1, Adresse2, TeleEnt, Email, Site " +
" HAVING(GroupeCompte = 411) OR " +
                "  (GroupeCompte = 412) OR " +
                "  (GroupeCompte = 571)";


                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@NumCompte", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                //cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
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

        private void comboCompteIdent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        DataTable TableMouvemrntService, TableSodeSerice; Boolean chargmentDgmouvement = false;
        private void button16_Click(object sender, EventArgs e)
        {

        }
        Boolean BchargementFiche2;
        private void bWoperationDivers_DoWork(object sender, DoWorkEventArgs e)
        {
            if (chargmentDgmouvement == true)
            {
                //chargementDgMOUVEMENTetDgSolde();
                ChargmentDegMouvemennt();

            }

            else if (BchargementFiche2 == true)
            {
                chargemeentFiche2();
            }

            else if (BchargementComboPaiement == true)
            {

                chargemeentComboPaiement();
            }

            else if (BoperationFact == true)
            {
                chargemeentOeratioFact();
            }
        }

        private void bWoperationDivers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (chargmentDgmouvement == true)
            {
                //DgMouvementService.DataSource = TableMouvemrntService;
                // dGsoldeDeSrivice.DataSource = TableSodeSerice;
            }

            else if (BchargementFiche2 == true)
            {
                comboCodeFiche.DataSource = TableFiche2;
                comboNomsF.DataSource = TableFiche2;
                comboPostNomF.DataSource = TableFiche2;
                comboPrenomsF.DataSource = TableFiche2;
                comboDesFiche.DataSource = TableFiche2;
                comboCodeFiche.DisplayMember = "CompteClient";
                comboCodeFiche.ValueMember = "CompteClient";
                comboNomsF.DisplayMember = "Noms";
                comboNomsF.ValueMember = "CompteClient";
                // tClientProvisoire.PosteNom, tClientProvisoire.Prenoms
                comboPostNomF.DisplayMember = "PosteNom";
                comboPostNomF.ValueMember = "CompteClient";

                comboPrenomsF.DisplayMember = "Prenoms";
                comboPrenomsF.ValueMember = "CompteClient";

                comboDesFiche.DisplayMember = "Fiche";
                comboDesFiche.ValueMember = "CompteClient";
                if (BparaFichePaiement == true)
                {



                    comboPrefPat.DataSource = TableFiche2;
                    comboPnoms.DataSource = TableFiche2;
                    comboPPosteNoms.DataSource = TableFiche2;
                    comboPprenom.DataSource = TableFiche2;
                    comboPdesFiche.DataSource = TableFiche2;
                    comboPrefPat.DisplayMember = "CompteClient";
                    comboPrefPat.ValueMember = "CompteClient";

                    comboPnoms.DisplayMember = "Noms";
                    comboPnoms.ValueMember = "CompteClient";
                    // tClientProvisoire.PosteNom, tClientProvisoire.Prenoms
                    comboPPosteNoms.DisplayMember = "PosteNom";
                    comboPPosteNoms.ValueMember = "CompteClient";

                    comboPprenom.DisplayMember = "Prenoms";
                    comboPprenom.ValueMember = "CompteClient";

                    comboPdesFiche.DisplayMember = "Fiche";
                    comboPdesFiche.ValueMember = "CompteClient";
                
                }


            }
            else if (BchargementComboPaiement == true)
            {
                comboPCompte.DataSource = TableComboPaiment;
                comboPCompte.DisplayMember = "NumCompte";
                comboPCompte.ValueMember = "NumCompte";

                comboPComptreDes.DataSource = TableComboPaiment;
                comboPComptreDes.DisplayMember = "DesignationCompte";
                comboPComptreDes.ValueMember = "NumCompte";
            }


            else if (BoperationFact == true)
            {
                comboRefMed.DataSource = TableOperation;
                comboRefMed.DisplayMember = "NumOperation";
                comboRefMed.ValueMember = "NumOperation";

                //comboPComptreDes.DataSource = TableComboPaiment;
               // comboPComptreDes.DisplayMember = "DesignationCompte";
               // comboPComptreDes.ValueMember = "NumCompte";
            }
            chargmentDgmouvement = false;
            BchargementFiche2 = false;
            BchargementComboPaiement = false;
            BparaFichePaiement = false;
            BoperationFact = false;

        }

        //        private void chargementDgMOUVEMENTetDgSolde()
        //        {


        //            try
        //            {
        //                string sSoldesSerice = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, tCompte.GroupeCompte, tGroupeCompte.Cadre " +
        //" FROM tCompte INNER JOIN " +
        //                        " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
        //                       "   tOperration ON tMvtCompte.NumOperation = tOperration.NumOperation INNER JOIN " +
        //                       "   tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
        //" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, tGroupeCompte.Cadre " +
        //" HAVING(tGroupeCompte.Cadre = 41) OR " +
        //               "   (tGroupeCompte.Cadre = 57) ";


        //                string sMouvementService = " SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie " +
        //" FROM tCompte INNER JOIN " +
        //                        " tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
        //                         " tOperration ON tMvtCompte.NumOperation = tOperration.NumOperation " +
        //" WHERE(tOperration.DateOp BETWEEN @da AND @db)  " +
        //" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte " +
        //" HAVING(tCompte.GroupeCompte = 411) OR " +
        //                "  (tCompte.GroupeCompte = 412) OR " +
        //               "   (tCompte.GroupeCompte = 571) ";
        //                String s3 = "SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte=@a)";
        //                //" WHERE(tOperration.DateOp BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2018-01-01 00:00:00', 102))  " +
        //                string[] r = { "" };
        //                string[] r3 = { ClassVaribleGolbal.GroupeService };
        //                DateTime[] d = { DateTime.Parse(tDateR1.Text), DateTime.Parse(tdateR2.Text) };
        //                ClassRequette classeReq = new ClassRequette();
        //                ClassRequette classeReq2 = new ClassRequette();
        //                classeReq.chargementAvecLesParametre(sSoldesSerice, ClassVaribleGolbal.seteconnexion, "tOption", r);

        //                TableSodeSerice = classeReq.dt;


        //               // classeReq2.chargementAvecLesParametreDate(sMouvementService, ClassVaribleGolbal.seteconnexion, "tOption2", r, d);

        //                //TableMouvemrntService = classeReq2.dt;
        //                //classeReq.chargementAvecLesParametre(s3, ClassVaribleGolbal.seteconnexion, "tOption2", r3);
        //                //TableComteVenteService = classeReq.dt;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }





        //        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if (tDateR1.Value <= tdateR2.Value)
            //{

            //    try
            //    {
            //        string codecl;

            //        int ci = DgMouvementService.CurrentRow.Index;
            //        codecl = DgPaiement[ir]["CompteClient"].ToString();
            //        codecl = DgMouvementService["CompteRapp", ci].Value.ToString();
            //        MessageBox.Show(codecl);
            //        Connection_Data();
            //        con.Open();
            //        cmd.CommandText = "RapportReleveCompte";


            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Clear();
            //        cmd.Parameters.AddWithValue("@NumCompte", codecl);
            //        cmd.Parameters.AddWithValue("@NumCompte", codecl);
            //        cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
            //        cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));
            //        MessageBox.Show(codecl);
            //        cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
            //        da.Fill(dt);
            //        con.Close();
            //        string chiminRap = "Rapport/Report3.rdlc";
            //        FormEtat fo = new FormEtat();
            //        fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
            //        fo.Show();

            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);

            //        lmessage.Text = ex.Message;

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("PROBLEME DE CHOISIR LA DATE ");

            //}









        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tDateR1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tdateR2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dGsoldeDeSrivice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel17_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void DgMouvementService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void RbAncienClient_CheckedChanged(object sender, EventArgs e)
        {
            //charmementBWpaiement();
            ProcedureChargemennPaiement();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // MessageBox.Show( CompteDEservicleint("41"));
        }

        private void tAdebut2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pCache_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tCaisseReception_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (bwcharmemntCombo.IsBusy == false)
            {
                pbCombo.Visible = true;
                bwcharmemntCombo.RunWorkerAsync();
              //  CaisseReception = CompteDEservicleint(51, 2);

            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void bwcharmemntCombo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbCombo.Value = e.ProgressPercentage;
        }

        private void button19_Click(object sender, EventArgs e)
        {




            AnnuleChambre();


        }
        private void AnnuleChambre()
        {

            tCompteClient.Text = "";
            // comboComptePart.Text = "";
            tNoms.Text = "";
            comboSexe.Text = "";
            tNationnalite.Text = "";
            tNoCarte.Text = "";
            tFonction.Text = "";
            tPrenoms.Text = "";
            tPostNom.Text = "";
            tFiche.Text = "";
            // tdateSortie.Text = "";


            // TdateEnntree.Text = "";
            tDateNaissance.Text = "";
            // comboCodeChambre.Text = "";
            // tPrixCovenu.Text = "";

        }


        private void AnnuleCas()
        {

            tRefCas.Text = "";
            // comboComptePart.Text = "";
            tDiagnostique.Text = "";
            tPlainte.Text = "";
            tAutres.Text = "";

            DrnierCas();




        }

        private void tdate2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {



           



        }

        private void button21_Click(object sender, EventArgs e)
        {


            // if (tDate1.Value <= tdate2.Value)
            //  {
            try
            {

               
               
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportDesServiceGlobal";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@DateOp",DateTime.Parse( tDate1.Text));
                cmd.Parameters.AddWithValue("@DateOp1", DateTime.Parse(tdate2.Text));
                
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportParService.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
              
                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

               

            }
           



        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {

                string codecl;
                // ConsommationDeproduits();
                int ci = DgSoldeClientDechambre.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DgSoldeClientDechambre["IDfiche", ci].Value.ToString().Trim();


                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportChargementReleveFicheDet";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompteClient", codecl);
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(tDate1.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(tdate2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportMvmtDeFiche.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }
        DataTable TableConsommationDeproduit;
        private void ConsommationDeproduits()
        {

            try
            {
                string codecl;

                int ci = DgSoldeClientDechambre.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DgSoldeClientDechambre["CompteClient", ci].Value.ToString();
                MessageBox.Show(codecl);
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportsDecosommationDuClientLoge";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                cmd.Parameters.AddWithValue("@CompteClient", codecl);
                // cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDate1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdate2.Text));
                //  MessageBox.Show(codecl);
                //cmd.Parameters.AddWithValue("@DateOperation2", tDate2.Value);
                da.Fill(dt);

                con.Close();
                TableConsommationDeproduit = dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
          



        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void comboComptePart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tPrixCovenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Boolean test3;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            try
            {
                test3 = false;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();
                string s = "   SELECT * from   tCas ";
                s = s + " where RefCas=@a";
                cmd.Connection = con;
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@a", tRefCas.Text);
                SqlDataReader lire;
                lire = cmd.ExecuteReader();

                while (lire.Read())
                {




                    tDiagnostique.Text = lire["Diagnostic"].ToString();
                    tPlainte.Text = lire["PLainte"].ToString();
                    tAutres.Text = lire["Autres"].ToString();
                    tDateEntree.Text = lire["DateDuCas"].ToString();
                    comboFicheCas.Text= lire["IDfiche"].ToString();
                    comboTypeCas.SelectedValue= lire["TypeDeCas"].ToString();
                    //IDfiche:


                    test3 = true;
                }

                lire.Close();
                cmd.Dispose();
                con.Close();
                bSupprimer.Enabled = test3;
                if ((test3 == true))
                {
                    bEnreigistrerCas.Text = "&MODIFIER";

                }
                else
                {

                    //cBmodifier.Checked = false;
                    bEnreigistrerCas.Text = "&ENREGISTRER";
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                lmessage.Text = ex.Message;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        Boolean CasActuels;
        String RefCasActuels;
        private void VerificationDeCasActuel()
        {

           // bwConnexion.ReportProgress(3);
            Connection_Data();
            con.Open();
            cmd.CommandText = " SELECT        tClientProvisoire.CompteClient, tClientProvisoire.Compte,tClientProvisoire.Fiche, tClientProvisoire.Noms, tClientProvisoire.PosteNom, tClientProvisoire.Prenoms, CONCAT(tClientProvisoire.Noms, ' ', " +
                         " tClientProvisoire.PosteNom, ' ', tClientProvisoire.Prenoms)  AS NOM,  tCas.RefCas, tCas.Diagnostic, tCas.PLainte, tCas.Etat, tCas.Autres, " +
                       "  tCas.DateDuCas, tCas.DateEntree " +
" FROM            tClientProvisoire INNER JOIN " +
                       "  tCas ON tClientProvisoire.CompteClient = tCas.IDfiche " +
" WHERE(tClientProvisoire.CompteClient =@CompteClient AND tCas.Etat = 0) ";

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@CompteClient", comboFicheCas.Text.Trim());
           // cmd.Parameters.AddWithValue("@MotPasseUtilisateur", motDepasse);

            // cmd.Parameters.AddWithValue("@MotDePass", motDepasse);


            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {

                CasActuels = true;
                RefCasActuels = dt.Rows[0]["RefCas"].ToString();
                //  ClassVaribleGolbal.UTILISATEUR = dt.Rows[0]["NomUtilisateur"].ToString();
                // Niveau = dt.Rows[0]["ServiceAffe"].ToString();
                // Foction = dt.Rows[0]["FonctionUt"].ToString();

                //ConneCTER = true;
            }
            else
            {


                CasActuels  = false;
                /// Label1.Text = "You're username and word is incorrect";
                //Label1.ForeColor = System.Drawing.Color.Red;
               // bwConnexion.ReportProgress(4);

            }

        }
        Boolean BcasEstEncoreActuel;
        private void VerificationDeCasActuelModification()
        {

            // bwConnexion.ReportProgress(3);
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        RefCas, IDfiche, Etat " +
                       "  FROM            tCas " +
" WHERE        (Etat = 0)   AND (RefCas=@RefCas) ";

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@RefCas", tRefCas.Text.Trim());
            
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {

                BcasEstEncoreActuel = true;
              //  RefCasActuels = dt.Rows[0]["RefCas"].ToString();
               
            }
            else
            {


                BcasEstEncoreActuel = false;
             
            }

        }
        private void button24_Click(object sender, EventArgs e)
        {
            try
            {


                if (tRefCas.Text.Trim() != "")
                {

                    if (test3 == true)
                    {
                        VerificationDeCasActuelModification();

                        if (BcasEstEncoreActuel == true)
                        {

                            UpdateCas();
                            AnnuleCas();
                            chargemeentDgCAS();
                            dgCas.DataSource = TableCas;
                        }

                        else
                        {
                            MessageBox.Show("CE CAS EST DEJA CLOTURE ");

                        }


                    }

                    else
                    {
                        VerificationDeCasActuel();
                        if (CasActuels == false)
                        {

                            enregitrementCas();
                            AnnuleCas();
                            chargemeentDgCAS();
                            dgCas.DataSource = TableCas;
                        }

                        else
                        {
                            MessageBox.Show(" CE MALADE A UN CAS ENCOUR \n" + " EN REF :" + RefCasActuels + " \n" +
                                " VEUILLEZ CLOTURER ");

                        }


                    }



                }




            }

            catch ( Exception  ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
        private void enregitrementCas()
        {
            string s = "INSERT INTO tCas (RefCas, IDfiche, TypeDeCas,Diagnostic, PLainte, Autres, DateDuCas, DateEntree) VALUES        (@a,@b,@c,@d,@e,@f,@da,@db) ";
            string[] r = { tRefCas.Text, comboFicheCas.Text, comboTypeCas.SelectedValue.ToString(), tDiagnostique.Text, tPlainte.Text, tAutres.Text };
            DateTime[] d = { DateTime.Parse(tDate.Text), DateTime.Parse(tDateEntree.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            MessageBox.Show("ok");
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }


        private void UpdateCas()
        {
            string s = " UPDATE  tCas SET  IDfiche=@a, TypeDeCas =@b,Diagnostic=@c, PLainte=@d, Autres=@e, DateDuCas=@da, DateEntree=@db WHERE   RefCas =@f  ";
            string[] r = {  comboFicheCas.Text, comboTypeCas.SelectedValue.ToString(), tDiagnostique.Text, tPlainte.Text, tAutres.Text, tRefCas.Text };
            DateTime[] d = { DateTime.Parse(tDate.Text), DateTime.Parse(tDateEntree.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            MessageBox.Show("ok");
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }



        private void SupprimerLesCas()
        {
            string s = " DELETE  FROM tCas  WHERE  RefCas =@a  ";
            string[] r = { tRefCas.Text };
            DateTime[] d = { DateTime.Parse(tDate.Text), DateTime.Parse(tDateEntree.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            MessageBox.Show("ok");
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }

        private void SupprimerLesMalade()
        {
            string s = " DELETE  FROM tClientProvisoire  WHERE  CompteClient =@a  ";
            string[] r = { tCompteClient.Text };
            DateTime[] d = { DateTime.Parse(tDate.Text), DateTime.Parse(tDateEntree.Text) };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            MessageBox.Show("ok");
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RES = MessageBox.Show(" \n" + "VOULEZ VOUS VRAIMENT SUPPRIMER CE CAS ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {
                    /// ModificationChambreLibire(tCodeArticle.Text, 0);
                    /// 

                    VerificationDeCasActuelModification();

                    if (BcasEstEncoreActuel == true)
                    {

                        //UpdateCas();
                        SupprimerLesCas();
                        AnnuleCas();
                        chargemeentDgCAS();
                        dgCas.DataSource = TableCas;
                    }

                    else
                    {
                        MessageBox.Show("CE CAS EST DEJA CLOTURE ");

                    }

                }


            }


            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
         



        }

        private void rBcASH_CheckedChanged_1(object sender, EventArgs e)
        {
            AffecteLecompte();


        }
        private void AffecteLecompte()
        {
            if (rBcASH.Checked == true)
            {
                tAdebut2.Text = ClassVaribleGolbal.CaisseReception;

            }

            else if (rbPrivee.Checked == true)
            {
                tAdebut2.Text = ClassVaribleGolbal.CompteClientChambre;
            }
            else
            {
                tAdebut2.Text = compteClient;
            }

        }
        private void rbPrivee_CheckedChanged(object sender, EventArgs e)
        {
            AffecteLecompte();
        }

        private void rBAbonnem_CheckedChanged(object sender, EventArgs e)
        {
            AffecteLecompte();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (verifierNumbe.IsNumeric(tSommeFact.Text) == true && (verifierNumbe.IsNumeric(tCreditte2.Text) == true))
            {
                if (Double.Parse(tSommeFact.Text) != 0)
                {
                    PasserFacturation2();
                    InsertionDepaiementEtRemise();
                    FactureDejaPayer = true;
                    ProcedureImprimerFacture();
                    bNauveau.Enabled = true;
                }

                else
                {

                    MessageBox.Show("COMPTER LE CHAMPS VIDE");
                }

            }

        }

        private void combCompteAbone_SelectedIndexChanged(object sender, EventArgs e)
        {
            BchargementFiche2 = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();
            }
            else
            {
                lmessage.Text = "LES PROCESSUS ENCOUR";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            combCompteAbone.Visible = rbAbonneFiche.Checked;
            comboGroupeCompte.Visible = rbAbonneFiche.Checked;
            combCompteAboneDes.Visible = rbAbonneFiche.Checked;
        }

        private void comboCpteService_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    // comboCompteSevice.ValueMember = "NumCompte";
            //    tCreditte2.Text = comboCpteService.SelectedValue.ToString();
            //    // comboCodeClient2.ValueMember = "CompteClient";
            //}
            //catch (Exception ex)
            //{

            //    // lmessage.Text = ex.Message;

            //}
        }

        private void rbTousFiche_CheckedChanged(object sender, EventArgs e)
        {

            BchargementFiche2 = true;
            if (bWoperationDivers.IsBusy == false)
            {
                bWoperationDivers.RunWorkerAsync();
            }
            else
            {
                lmessage.Text = "LES PROCESSUS ENCOUR";
            }

        }

        private void comboCodeFiche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bwEnreNuitte.IsBusy == false)
            {
                bwEnreNuitte.RunWorkerAsync();
            }


        }

        private void tDate1_ValueChanged(object sender, EventArgs e)
        {

        }

        Boolean ModificationF;
        private void ChargementAjoutFact()
        {
            PourLeNouveaDeFactSeulement = false;
            passeFacturation = false;
            //cash = rbCash.Checked;
            bNauveau.Enabled = true;

            PbEnrePaiemnt.Visible = true;
            PnumOp2 = tNumOp2.Text;

            ///  plibelle = ""


            if (bWchargmentPaiement.IsBusy == false)
            {
                if (ModificationF == false)
                {
                    chargemeentComboFactIinitial();
                    bWpasserLepaiemnet.RunWorkerAsync();

                }
                else if (ModificationF == true)
                {
                    // chargemeentComboFactIinitial();
                    // bWpasserLepaiemnet.RunWorkerAsync();
                }

            }


            FormPopFact Fp = new FormPopFact();
            Fp.NumOP = tNumOp2.Text;
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {
                //label2.Text = "tu clicl sur ok";
                chargemeenDGFacturationSerice();
                dgFacturation.DataSource = TableFacturation;
                tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                // label2.Text = "tu clicl sur cance";

            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            ChargementAjoutFact();







        }

        private void ComboFicheDeCasIDdes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

            if (FactureDejaPayer == false)
            {
                ModificationF = true;
                ChargementAjoutFact();

            }
            else
            {
                MessageBox.Show("CETE OPERATION EST DEJA FACTURE  VEILLLER ANNULER LA FACTURE POUR MODIFIER");



            }

        }

        private void tSommeFact_TextChanged(object sender, EventArgs e)
        {
            ChargementNetApayer();
        }
        private void ChargementNetApayer ()

        {
            try
            {
                tNetApayer.Text = (Double.Parse(tSommeFact.Text) - Double.Parse(tRemise.Text)).ToString();
            }

            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }
           

        }

        private void tRemise_TextChanged(object sender, EventArgs e)
        {
            ChargementNetApayer();
        }

        private void button9_Click_1(object sender, EventArgs e)
        { 
           



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            tCodeAmodifie.Text = "";
            annulerArtclicle(); 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
        }

        string PcodeChambre2,OP2, PcompteDebt, PcompCredit, PcodeClient2, plibelle2, Pmotant2, PnumOp2, BeneFiciare;

        private void comboDesignationSErvice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageFacturatio;
        }

        private void comboGroupeNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmenComboCompte3();
            comboCompteIdent.DataSource = cbCompte;
            comboCompteIdent.DisplayMember = "NumCompte";
            comboCompteIdent.ValueMember = "NumCompte";

            comboCompteDesId.DataSource = cbCompte;
            comboCompteDesId.DisplayMember = "DesignationCompte";
            comboCompteDesId.ValueMember = "NumCompte";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FormRecherche Fp = new FormRecherche();
            Fp.Text = this.Text;
            Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboFicheCas.Text = RefPatiant;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboFicheCas.Text = "";
                // label2.Text = "tu clicl sur cance";

            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {



                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportChargementReleveFicheDet";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompteClient", comboCodeFiche.Text);
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(tDate21.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(tDate22.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportMvtSynthes.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }



        }

        private void button9_Click_2(object sender, EventArgs e)
        {

        }

        private void rbTousCasCloture_CheckedChanged(object sender, EventArgs e)
        {
            tDateVerification.Visible = rbTousCasCloture.Checked;
            if (rbTousCasCloture.Checked == true)
            {

                Datedeverication = tDateVerification.Text;
            }

            procedureChargemntDgSolde();


        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                string codecl , Noms ,Solde, RefCas;
                // ConsommationDeproduits();
                int ci = DgSoldeClientDechambre.CurrentRow.Index;
                //codecl = DgPaiement[ir]["CompteClient"].ToString();
                codecl = DgSoldeClientDechambre["IDfiche", ci].Value.ToString().Trim();
                Noms =  DgSoldeClientDechambre["NOM", ci].Value.ToString().Trim();
                Solde= DgSoldeClientDechambre["Solde", ci].Value.ToString().Trim();
                RefCas = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();

                DialogResult RES = MessageBox.Show(" ETES VOUS SUR DE VOILOIR  CLOTURER CE CAS ?  ==== " + " \n " + " \n " +
                    "REF :" + codecl + " \n " + Noms + " \n " + " RESTE : " + Solde, 
                    "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {

                    //string s = " INSERT INTO    tMvtChambre    (NumOperation, NumCompte,QteSortie,QteEntree,Sortie,Entree)  Values (@a,@b,@c,@d,@e,@f)";
                    string s = " UPDATE   tCas set    Etat=@a, DateCloture=@da WHERE (RefCas=@b)";

                  //string[] r = { tNumOp2.Text, "AU1", "1", "0", tNetApayer.Text, "0" };
                  //  string[] r2 = { tNumOp2.Text, "AU2", "1", "0", tRemise.Text, "0" };
                    string[] r1 = {"1", RefCas };
                    string[] r2 = { "0" , RefCas };

                    DateTime[] d = { DateTime.Parse (tDate.Text) };

                    ClassRequette req = new ClassRequette();
                    if (rbTousCasCloture.Checked == true )
                    {

                        req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);
                      
                    }

                    else
                    {
                        req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r1, d);
                    }




                    procedureChargemntDgSolde();

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void comboCatArti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {

            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportTousLesService";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@NumCompte", codecl);
                //cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                //cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportListeService.rdlc";
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

        private void comboFicheCas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgCas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ci;
            ci = dgCas.CurrentRow.Index;

            //string UTILISATEUR, CLIENT;

            tRefCas.Text = dgCas["RefCas2", ci].Value.ToString().Trim();

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            AnnuleCas();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {


            try
            {

                Connection_Data();
                con.Open();


                String s = "SELECT        VListeDeMalade.*, GroupeCompte " +
                    "FROM            VListeDeMalade WHERE        (NumCompte =@NumCompte)";
                String s2 = "SELECT        VListeDeMalade.*, GroupeCompte " +
                   "FROM            VListeDeMalade WHERE        (GroupeCompte =@GroupeCompte)";

                if (checkBox1.Checked == false)
                {
                    cmd.CommandText = s;

                }

                else
                {
                    cmd.CommandText = s2;

                }
               

              



                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                if (checkBox1.Checked == false)
                {
                    // s = s2;
                   
                    cmd.Parameters.AddWithValue("@NumCompte", comboCompteIdent.Text);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupeNv.SelectedValue.ToString());
                }


               
                //cmd.Parameters.AddWithValue("@NumCompte", comboCompteV.Text);
                //cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(tDateR1.Text));
                // cmd.Parameters.AddWithValue("@date2", Convert.ToDateTime(tdateR2.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportListeMalade.rdlc";
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

        private void RbCpn_CheckedChanged(object sender, EventArgs e)
        {
            procedureChargemntDgSolde();
        }

        private void comboTypeHospCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboRefMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( bWpasserLepaiemnet.IsBusy == false)

            {
                tNumOp2.Text = comboRefMed.Text;
                BcharmenntTableMedicament = true;
                bWpasserLepaiemnet.RunWorkerAsync();

            }
        }

        private void RbValidationFact_CheckedChanged(object sender, EventArgs e)
        {
            charmementBWpaiementPourSerice();
            comboRefMed.Visible = RbValidationFact.Checked;
            lrefMed.Visible = RbValidationFact.Checked;

            if (RbValidationFact.Checked == true)
            {
                tCreditte2.Text = "701101";
                BoperationFact = true;
                if (bWoperationDivers.IsBusy == false)
                {
                    bWoperationDivers.RunWorkerAsync();
                }
            }
            else
            {
                tCreditte2.Text = "70602";

            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {



                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactureParOrganisation2";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDate21.Text));
                cmd.Parameters.AddWithValue("@DateOp1", DateTime.Parse(tDate21.Text));
                cmd.Parameters.AddWithValue("@NumCompte ", combCompteAbone.Text);
                //411201
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportPaeServiceFact.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }



        }

        private void comboGroupeCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargmenComboCompte2();
            combCompteAbone.DataSource = TableAbonne;
            combCompteAbone.DisplayMember = "NumCompte";
            combCompteAbone.ValueMember = "NumCompte";

            combCompteAboneDes.DataSource = TableAbonne;
            combCompteAboneDes.DisplayMember = "DesignationCompte";
            combCompteAboneDes.ValueMember = "NumCompte";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {



                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportChargementReleveFicheDet";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompteClient", comboCodeFiche.Text);
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(tDate21.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(tDate22.Text));

                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportMvmtDeFiche.rdlc";
                FormEtat fo = new FormEtat();
                fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                fo.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PourLeNouveaDeFactSeulement = false;
            passeFacturation = true;
            //cash = rbCash.Checked;
            bNauveau.Enabled = true;

            PbEnrePaiemnt.Visible = true;
            PnumOp2 = tNumOp2.Text;
            PcodeClient2 = comboIdCas2Des.Text;
            PcompteDebt = tAdebut2.Text;
            PcompCredit = tCreditte2.Text;
            PcodeChambre2 = CodeChambreAfactre2;
            plibelle2= tLibelleFacrtation.Text;
            ///  plibelle = ""
            BeneFiciare = tPour.Text;
           // Pmotant2 = tTotal.Text;

            MessageBox.Show(PcodeClient2);

            if ((tLibelleFacrtation.TextLength > 10))
            {
                if (bWchargmentPaiement.IsBusy == false)
                {
                    bWpasserLepaiemnet.RunWorkerAsync();

                }

            }
            else
            {

                MessageBox.Show(" LE MONTAN DOIT ETRE NUMERIC  OU LE LIBELLE DOIT AVOIR AU MOIN 10 LETTRE");

            }



        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboPDsiengantion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void charmementBWpaiement()
        {
            if (RbAbonne.Checked == true || RbClientPriver.Checked == true)
            {
               // ComboChambreOcuppe2.Visible = true;
                // ComboChambreOcuppe2.Visible = true;
                //lChambreOccupe.Visible = true;
                comboPrefPat.Visible = true; ;
                lChambre.Visible = true; ;

            }
            else
            {
                //ComboChambreOcuppe2.Visible = false;
                //ComboChambreOcuppe2.Visible = true;
                //lChambreOccupe.Visible = false;
                comboPrefPat.Visible = false; ;
                lChambre.Visible = false; ;

            }


           
            ClientDechambe = RbClientPriver.Checked;
            ClientOccasionnel = RbAbbonneFamille.Checked;
            ClientOrdinnaire = rbAutrePaiemment.Checked;
            AncienClients = RbAbonne.Checked;
            if (bWchargmentPaiement.IsBusy == false)
            {
                bWchargmentPaiement.RunWorkerAsync();

            }
            else
            {

                lmessage.Text = "PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER";
              //  MessageBox.Show("PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER");
            }

        }



        private void charmementBWpaiementPourSerice()
        {
           
            
            
            
            
            
            
            //if (RbAncienClient2.Checked ==true || rbLoge2.Checked==true)
            //{
            //    ComboFicheDeCasID.Visible = true;
            //   // ComboChambreOcuppe2.Visible = true;
            //    lChambreOccupe.Visible = true;

            //}
            //else
            //{
            //    ComboFicheDeCasID.Visible = false;
            //    // ComboChambreOcuppe2.Visible = true;
            //    lChambreOccupe.Visible = false;

            //}
           
            //ClientDechambe = rbLoge2.Checked;
            //ClientOccasionnel = rbClientOCCasionnel2.Checked;
            //ClientOrdinnaire = rBclientOrd2.Checked;
            //AncienClients = RbAncienClient2.Checked;
            if (bWchargmentPaiement.IsBusy == false)
            {

              bWchargmentPaiement.RunWorkerAsync();

            }
            else
            {

               lmessage.Text = "PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER";
            //    //  MessageBox.Show("PROCESSUS EST ENCOUR VEILLLEZ PANETIRNTER");
            }

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrnierOP()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(IdChambre) AS MaxArticle FROM            tChambre ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DerinierArticle = (row["MaxArticle"].ToString());
                int num = Convert.ToInt32(DerinierArticle) + 1;
                tCodeArticle.Text = "S" +num.ToString();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }

        private void DrnierCas()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = " SELECT        MAX(IdCas) AS MaxArticle FROM            tCas ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DerinierArticle = (row["MaxArticle"].ToString());
                int num = Convert.ToInt32(DerinierArticle) + 1;
                tRefCas.Text = "CAS" + num.ToString();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }


        private string CompteDEservicleint (int type, int sevice)
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
            try
            {
                compte = cmd.ExecuteScalar().ToString();

            }
            catch
            {
                compte="0";
            }
           
            return compte;


            cmd.Dispose();
            con.Close();

        }
        private void DrnierClient()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(IdClient) AS MaxIdClient FROM            tClientProvisoire ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DernienCompte = (row["MaxIdClient"].ToString());
                int num = Convert.ToInt32(DernienCompte) + 1;
                tCompteClient.Text ="P"+ num.ToString();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }



        string numOperationLO,   numOperationPaie,  numOperationRectte;
        private void DrnierOpLogement()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperration ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DernierNumOP = (row["DernierOp"].ToString());
                int num = Convert.ToInt32(DernierNumOP) + 1;
                numOperationLO= "LG" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                tNumOp.Text = "LG" + num.ToString()+ utilisateur.Substring(0, 2).ToUpper();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }



        private void DrnierOpPaiement()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperration ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DernierNumOP = (row["DernierOp"].ToString());
                int num = Convert.ToInt32(DernierNumOP) + 1;
                numOperationPaie = "PF" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                tNumOPpAIEMENT.Text = "PF" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }



        private void DrnierOpPaiement2()
        {
            Connection_Data();
            con.Open();
            cmd.CommandText = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperration ";
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("DateOperation", TdateStock.Value);
            // cmd.Parameters.AddWithValue("Autres", tLibelle.Text);
            // cmd.Parameters.AddWithValue("Pvente", tPrixVente.Text.Trim());

            // cmd.ExecuteNonQuery();
            da.Fill(dt);
            con.Close();
            //lmessage.Text = " EST AJOUTE ";
            foreach (DataRow row in dt.Rows)
            {
                //dernierMat
                DernierNumOP = (row["DernierOp"].ToString());
                int num = Convert.ToInt32(DernierNumOP) + 1;
                numOperationRectte = "RS" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                tNumOp2.Text = "RS" + num.ToString() + utilisateur.Substring(0, 2).ToUpper();
                //  tidEleve.Text = dernierMat;
            }
            con.Close();
            da.Dispose();

        }
        private void ChargmenComboCompte()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        NumCompte, DesignationCompte, GroupeCompte FROM            tCompte WHERE        (GroupeCompte=@GroupeCompte)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GroupeCompte", ClassVaribleGolbal.GroupeLogement);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    CbGroupe = dt;
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
        DataTable tableComboCompteSevice;
        private void ChargmenComboCompteService()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        GroupeCompte, DesignationCompte, NumCompte " +
" FROM tCompte "  +
" WHERE(GroupeCompte = @GroupeCompte) " +
" ORDER BY GroupeCompte ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GroupeCompte",ClassVaribleGolbal.GroupeService);
                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    tableComboCompteSevice = dt;
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

        DataTable TableAbonne;
        private void ChargmenComboCompte2()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @GroupeCompte  )";
                cmd.CommandType = CommandType.Text;
               // cmd.Parameters.AddWithValue("@NumCompte", CompteDEservicleint(41,2));
                cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupeCompte.SelectedValue.ToString());

                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    cbCompte = dt;
                    TableAbonne= dt;
                    
                }

            }
            catch (Exception ex)
            {

              

            }

            
        }

        private void ChargmenComboCompte3()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        NumCompte, DesignationCompte FROM            tCompte WHERE        (GroupeCompte = @GroupeCompte  )";
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@NumCompte", CompteDEservicleint(41,2));
                cmd.Parameters.AddWithValue("@GroupeCompte", comboGroupeNv.SelectedValue.ToString());

                da.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    cbCompte = dt;
                   // TableAbonne = dt;

                }

            }
            catch (Exception ex)
            {



            }


        }
        private void ChargmenComboCategorie()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        IdCatChambre, DesCatCatChambre FROM       tCatChambre WHERE  (IdCatChambre =1) ";

                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@CategorieCompte", 2);
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




        private void ChargmentDegMouvemennt()
        {
            try
            {

                Connection_Data();
                con.Open();
                cmd.CommandText = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, SUM(tMvtCompte.Entree) AS SommeEntree, SUM(tMvtCompte.Sortie) AS SommeSortie, tGroupeCompte.Cadre " +
 " FROM tCompte INNER JOIN " +
                        "  tMvtCompte ON tCompte.NumCompte = tMvtCompte.NumCompte INNER JOIN " +
                        "  tOperration ON tMvtCompte.NumOperation = tOperration.NumOperation INNER JOIN " +
                        "  tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tOperration.DateOp BETWEEN @DateOp AND @DateOp1) " +
" GROUP BY tCompte.NumCompte, tCompte.DesignationCompte, tCompte.GroupeCompte, tGroupeCompte.Cadre " +
" HAVING(tGroupeCompte.Cadre = 41) OR " +
               "   (tGroupeCompte.Cadre = 57)";
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@DateOp", DateTime.Parse(tDateR1.Text));
               // cmd.Parameters.AddWithValue("@DateOp1", DateTime.Parse(tdateR2.Text));
                da.Fill(dt);
                con.Close();


                // if (dt.Rows.Count > 0)
                // {
                // CbGroupe = dt;
                TableMouvemrntService= dt;
                MessageBox.Show("ok");

                // comboDesignatioGroupe.DataSource = dt;
                // comboPosrIN.DataSource = dt;
                //  comboPreIns.DataSource = dt;






                //  comboPosrIN.DisplayMember = "PostnomEleve";
                //comboPosrIN.ValueMember = "MatriculeEleve";

                // comboPreIns.DisplayMember = "PrenomEleve";
                //comboPreIns.ValueMember = "MatriculeEleve";
                // }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               // lmessage.Text = ex.Message;

            }

            //  da.Dispose();
        }

        DataTable TableFactureMedicament;
             
        private void ChargementFactureMedicament ()
        {
            try
            {
                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactureMedicament";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumOperation", tNumOp2.Text);
                da.Fill(dt);
                con.Close();
                TableFactureMedicament = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }


        }

        public void chargemenentRapporteAveVDataSetPro(DataTable FactureTable, string CheminRap, string dtset)
        {

           // this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dtset, FactureTable));
            //  
            this.reportViewer1.LocalReport.ReportPath = CheminRap;
            reportViewer1.RefreshReport();







        }
        private void button12_Click_1(object sender, EventArgs e)
        {

            ProcedureImprimerFacture();

        }
         private void ProcedureImprimerFacture ()
        {
            // tabControl1.SelectedTab = tabPagImpresion;
            try
            {

                this.reportViewer1.LocalReport.DataSources.Clear();
                tabControl1.SelectedTab = tabPagImpresion;
                ChargementFactureMedicament();

                Connection_Data();
                con.Open();
                cmd.CommandText = "RapportFactureRecu";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumOperation", tNumOp2.Text);
                da.Fill(dt);
                con.Close();
                string chiminRap = "Rapport/Hop/ReportRecu.rdlc";
                string chiminRap2 = "Rapport/Hop/ReportFactueMedicament.rdlc";
                FormEtat fo = new FormEtat();
                if (RbValidationFact.Checked == true)
                {

                    // fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    // fo.chargemenentRapporteAveVDataSetPro(TableFactureMedicament, chiminRap2, "DataSet2");
                    //fo.Show();
                    chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    chargemenentRapporteAveVDataSetPro(TableFactureMedicament, chiminRap2, "DataSet2");
                }

                else
                {
                    // fo.chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");
                    // // fo.chargemenentRapporteAveVDataSetPro(TableConsommationDeproduit, chiminRap, "DataSet2");
                    //  fo.Show();
                    chargemenentRapporteAveVDataSetPro(dt, chiminRap, "DataSet1");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // lmessage.Text = ex.Message;

            }


        }

        private void comboPrefPat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DernierCas();
        }

        private void comboPdesFiche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tNumOPpAIEMENT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
