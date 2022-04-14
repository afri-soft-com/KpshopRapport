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

namespace GoldenStarApplication.FormPop
{
    public partial class FormPopStockChargment : Form
    {


        public FormPopStockChargment()
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
        public string DEpotCentrale = "CD1";
        public string CaisseReception;
        public string Compte = "3101";
        public string CompteFournissseur, CompteVariation, NumOP, CodeDepot, DesDepot, Vendeur, CompteMarchandise, CategorieArticle;
        public Boolean boolRetourDeStock, boolCharmentStock, boolVenteClient,boolAchat,boolDegusate,boolCaseMaquant,boolAutreSotie, boolAchatBon;
        public Boolean boolEnArgent;

        public Boolean boolCuisine,boolVenteSpecial;

        private void dgFacturation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            FormPopVente.FormQte Fp = new FormPopVente.FormQte();

            int ci =dgFacturation .CurrentRow.Index;
            // tCodeRef.Text, ClassVaribleGolbal.CodeDepartement, tDesArticle.Text, comboCategorie.Text, tPu.Text, ClassVaribleGolbal.CompteStock,tPuniVente.Text
            Fp.NumOperation = tNumOp2.Text;
            Fp.CodeDepot = CodeDepot;
            Fp.CPu = dgFacturation["CPu", ci].Value.ToString();
            Fp.CodeArrcticle = dgFacturation["CodeChambre", ci].Value.ToString();
            Fp.DesignationAricle = dgFacturation["DesignationChambre", ci].Value.ToString();
            Fp.PriunideVent = dgFacturation["PunitaireVente", ci].Value.ToString();


            DialogResult Dial = Fp.ShowDialog();
            //  PasserLoperation = true;
            if (Dial == DialogResult.OK)
            {

                

               
               
            }

            else if (Dial == DialogResult.Cancel)
            {
                

            }
        }

        public Double TauxRestourne;
        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }
        private void FormPopStockChargment_Load(object sender, EventArgs e)
        {
            try
            {
                tNumOp2.Text = NumOP;
                tCodeDepot.Text = CodeDepot;
                tDate1.Value = ClassVaribleGolbal.DateDuJOUR;
                bwcharmemntCombo.RunWorkerAsync();
                if (boolCharmentStock==true)
                {

                    lAfichage.Text = " CHARGEMENT DE :   \n" + DesDepot ;
                }
                else if ( boolRetourDeStock ==true)
                 {
                    lAfichage.Text = " RETOUR DE STOCK :  \n" + DesDepot;
                    //boolVenteClient
                }

                else if (boolVenteClient == true)
                {
                    lAfichage.Text = " VENTE :  \n" + DesDepot + "/" +Vendeur;
                    //boolVenteClient
                }
                else if (boolAchat == true)
                {
                    lAfichage.Text = " ACHATS ";
                    //boolVenteClient
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataTable TableFacure;

        private void Bvalide_Click(object sender, EventArgs e)
        {
            ModifierLeChargement();
        }


        //private void ModifierLeChargement()
        //{
        //    String Qte, Pu, CodeSerice,PriUniVente;
        //    Double TotalSome, TotalSomeVente;
        //    for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
        //    {

        //        //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
        //        // M
        //        //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
        //        Qte = dgFacturation["CQte", i].Value.ToString().Trim();
        //        Pu = dgFacturation["CPu", i].Value.ToString().Trim();
        //        PriUniVente = dgFacturation["PunitaireVente", i].Value.ToString().Trim();
        //        CodeSerice = dgFacturation["CodeChambre", i].Value.ToString().Trim();
        //        // Pu =["RefCas", i].Value.ToString().Trim();

        //        if (Double.Parse(Qte) != 0)
        //        {
        //            try
        //            {
        //                TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
        //                TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

        //                string s = " UPDATE   tMvtStock set    QteEntree=@a, PVentUN=@h,PR=@b,Entree=@c,QteEntreeCharg=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";

        //                string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot, PriUniVente };

        //                string[] rBonEnAregent = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), DEpotCentrale, PriUniVente };


        //                // string[] rAcha = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), DEpotCentrale };



        //                string s2 = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@h,PR=@b,Sortie=@c,QteSortieCharg=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //                string[] r2 = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), DEpotCentrale, PriUniVente };



        //                string sRetour = " UPDATE   tMvtStock set    QteEntree=@a, PVentUN=@b,Entree=@c,QteEntreeRetour=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //              //  string[] rRetour = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot };

        //                string s2Retour = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@b,Sortie=@c,QteSortieRetour=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //                //string[] r2Retour = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), DEpotCentrale };


        //                // vente
        //                string s2Vente = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@c,PR=@b,Sortie=@d,Vente=@d,QteSortieVente=@a,SommeVente=@e,RestournePr=@f WHERE (NumOperation=@g AND  NumCompte=@h AND CodeDepot=@i)";
        //                string[] rVente = { Qte, Pu, PriUniVente, TotalSome.ToString(), TotalSomeVente.ToString(), TauxRestourne.ToString(),tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot };
                        
        //                string s2Degustage = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@h,PR=@b,Sortie=@c,QteSortieDegustage=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //                string[] rDegustage = { Qte, Pu, PriUniVente, TotalSome.ToString(), TotalSomeVente.ToString(), TauxRestourne.ToString(), tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot };

        //                string s2CasseManquat = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@h,PR=@b,Sortie=@c,QteSortieCasseManquant=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";

        //                string s2Autres = " UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@h,PR=@b,Sortie=@c,QteSortieAutre=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";



        //                //string[] r2Retour = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), DEpotCentrale };


        //                string sAchat = " UPDATE   tMvtStock set    QteEntree=@a, PVentUN=@b,Entree=@c,QteEntreeAchat=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //                string sAchatBon = " UPDATE   tMvtStock set    QteEntree=@a, PVentUN=@b,Entree=@c,QteEntreeAchatBon=@d WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";


        //                // string sAchat = " UPDATE   tMvtStock set    QteEntree=40, PVentUN=20,Entree=50,QteEntreeAchat=20 WHERE (NumOperation=@e AND  NumCompte=@f AND CodeDepot=@g)";
        //                //  string[] rRetour = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot };


        //                DateTime[] d = { DateTime.Now };

        //                ClassRequette req = new ClassRequette();
        //                if (boolCharmentStock== true)
        //                {
        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r2, d);

        //                }
        //                else if ( boolRetourDeStock==true)
        //                {

        //                   req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2Retour, r, d);
        //                   req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sRetour, r2, d);

        //                }



        //                else if (boolVenteClient == true)
        //                {

        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2Vente, rVente, d);
        //                  //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

        //                }

        //                else if (boolDegusate == true)
        //                {


        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2Degustage, r, d);
        //                    if ( boolEnArgent == true)
        //                    {
        //                        req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAchat, r, d);

        //                    }
                            
        //                    //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

        //                }

        //                else if (boolCaseMaquant == true)
        //                {

        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2CasseManquat, r, d);
        //                    //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

        //                }

        //                else if (boolAutreSotie == true)
        //                {

        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2Autres, r, d);
        //                    //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

        //                }


        //                else if (boolAchat == true)
        //                {
        //                   //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAchat, r, d);
        //                    //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

        //                    //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

        //                }

        //                else if (boolAchatBon == true)
        //                {
        //                    //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);


        //                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAchatBon, r, d);
                           

        //                }

        //                // lmessage.Text = "&  Enregistrement effectué avec succès &";
        //                // chargemeentDgELEVE();
        //                //MessageBox.Show(CodeSerice.Trim());
        //                //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
        //            }

        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }

        //        }

        //    }



        //    //MessageBox.Show("modification reussi");

        //}


        private void ModifierLeChargement()
        {
            String Qte, Pu, CodeSerice, PriUniVente;
            Double TotalSome, TotalSomeVente;
            for (int i = 0; i <= dgFacturation.Rows.Count - 1; i++)
            {

                //  codecl = DgSoldeClientDechambre["RefCas", ci].Value.ToString().Trim();
                // M
                //  bWpasserLepaiemnet.ReportProgress(i); CodeChambre
                Qte = dgFacturation["CQte", i].Value.ToString().Trim();
                Pu = dgFacturation["CPu", i].Value.ToString().Trim();
                PriUniVente = dgFacturation["PunitaireVente", i].Value.ToString().Trim();
                CodeSerice = dgFacturation["CodeChambre", i].Value.ToString().Trim();
                // Pu =["RefCas", i].Value.ToString().Trim();

                if (Double.Parse(Qte) != 0)
                {
                    try
                    {
                        TotalSome = Double.Parse(Qte) * Double.Parse(Pu);
                         TotalSomeVente = Double.Parse(Qte) * Double.Parse(PriUniVente);

                        // UPDATE   tMvtStock set    QteSortie=@a, PVentUN=@c,PR=@b,Sortie=@d,Vente=@d,QteSortieVente=@a,SommeVente=@e,RestournePr=@f WHERE (NumOperation=@g AND  NumCompte=@h AND CodeDepot=@i)";

                        string sAchat = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAchat,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";
                        string sEntreeProduit = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAutre,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";

                        string sVente = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteSortie, PVentUN,Sortie,QteSortieVente,PR,SommeVente,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
                        //QteSortie
                        string sAutreSorte = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteSortie, PVentUN,Sortie,QteSortieAutre,PR,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                        //QteSortie

                        string[] r = { tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot, Qte, Pu, TotalSome.ToString(), Qte, Pu };
                        string[] rVente = { tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot, Qte, PriUniVente, TotalSome.ToString(), Qte, Pu, TotalSomeVente.ToString(), TotalSomeVente.ToString() };
                        string[] rSortieAutre = { tNumOp2.Text.Trim(), CodeSerice.Trim(), CodeDepot, Qte, Pu, TotalSome.ToString(), Qte, Pu, TotalSomeVente.ToString() };






                        DateTime[] d = { DateTime.Now };

                        ClassRequette req = new ClassRequette();
                        if (boolAchatBon == true)
                        {
                            //req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                            // req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s2, r2, d);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVente, r, d);

                        }

                        else if (boolAchat == true)
                        {
                            //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
                           // req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAchat, r, d);
                            //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

                            //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

                        }

                        else if (boolCuisine == true )
                        {
                            //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAutreSorte, rSortieAutre, d);
                            //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

                            //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

                        }


                        else if (boolVenteSpecial == true)
                        {
                            //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVente, rVente, d);
                            //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

                            //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

                        }


                        else if (boolAutreSotie == true)
                        {
                            //MessageBox.Show(  " QTE " + Qte +" pu" + Pu + " some" + " total"  +TotalSome.ToString() + " qte"  + Qte + " nump" + tNumOp2.Text.Trim()  +"arti"  +CodeSerice.Trim() + "depot" + CodeDepot);
                            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sAutreSorte, rSortieAutre, d);
                            //string[] r = { Qte, Pu, TotalSome.ToString(), Qte, tNumOp2.Text.Trim(), CodeSerice.Trim() ,CodeDepot};

                            //  req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r2, d);

                        }


                        //boolCuisine


                        // lmessage.Text = "&  Enregistrement effectué avec succès &";
                        // chargemeentDgELEVE();
                        //MessageBox.Show(CodeSerice.Trim());
                        //MessageBox.Show( "  qte" + Qte + "  pu " + Pu + "  somme" +  TotalSome.ToString() + " opera" + tNumOp2.Text.Trim() + " code " + CodeSerice.Trim());
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }



            //MessageBox.Show("modification reussi");

        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableFacure;
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentChargment();
        }

        private void chargemeentChargment()
        {
            try
            {


                string s = " SELECT        Compte, CodeArticle AS CodeChambre, DesegnationArticle AS DesignationChambre, 0.0 AS Qte, tStock.PrixVente, tStock.PrixAchat " +
                    " FROM            tStock WHERE CodeDepartement=@a ";// +
//                        " WHERE        (Compte=@a)  " +
//" ORDER BY Compte, IdArticle ";


//                string s = "SELECT        tStock.Compte, tStock.CodeArticle AS CodeChambre, tStock.DesegnationArticle AS DesignationChambre, 0.0 AS Qte, tStock.PrixVente AS TarifChambre, tPametreDepot.PuVente AS PrixVenteLocale  " +
//" FROM            tStock INNER JOIN " +
//                         " tPametreDepot ON tStock.CodeArticle = tPametreDepot.CodeArticle " +
//" WHERE        (tPametreDepot.CodeDepot = @a) AND (tStock.Compte = @b) ORDER BY tStock.Compte, tStock.IdArticle  ";
                
                
                
                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();

                string[] r = { ClassVaribleGolbal.CodeDepartement};


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableFacure = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Bannuler_Click(object sender, EventArgs e)
        {

        }

        private void dgFacturation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (bwcharmemntCombo.IsBusy == false)
                {

                    if (tAchercher.Text.Trim() != "")
                    {
                        BwChargementRechere.RunWorkerAsync();
                        lMessage.Text = "ok";
                    }
                    else
                    {
                        if (bwcharmemntCombo.IsBusy == false)
                        {
                            bwcharmemntCombo.RunWorkerAsync();
                        }
                       
                    }
                   
                }
                else
                {

                    lMessage.Text = "PROCESSUS ENCOUR";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        DataTable TableAcherche;
        private void chargemeentDgAchercher()
        {
            try
            {
                string s;

                string a = "'%" + "stev" + " %'";
                s = " SELECT        Compte, CodeArticle AS CodeChambre, DesegnationArticle AS DesignationChambre, 0.0 AS Qte, tStock.PrixVente, tStock.PrixAchat " +
" FROM            tStock " +
" WHERE   (CodeDepartement=@a) AND  (DesegnationArticle) LIKE \'%" + tAchercher.Text + "%\'";


               

                //" WHERE((DesignationCompte + NumCompte) LIKE \'%" + tAchercher.Text + "%\')";

                //CONCAT (NumCompte ,DesignationCompte)
                //" WHERE((Noms + Localite ) LIKE \'%" + tAchercher.Text + "%\')";
                ClassRequette classeReq = new ClassRequette();

                string[] r = { ClassVaribleGolbal.CodeDepartement };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);









                TableAcherche = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BwChargementRechere_DoWork(object sender, DoWorkEventArgs e)
        {
            chargemeentDgAchercher();
        }

        private void BwChargementRechere_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgFacturation.DataSource = TableAcherche;
            lMessage.Text = "SUCCES";
        }
    }
}
