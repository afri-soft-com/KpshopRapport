using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace  GoldenStarApplication.LesClasses
{
    class ClasseOperationMvt
    {

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;


        public void enregistraimentOP(string NumOperation,  string Libelle, string NomUt
            ,   DateTime DateOp)
        {
            try
            {

                string s = " INSERT INTO tOperation " +
                       "  (NumOperation,  Libelle, NomUt, DateOp,DateSysteme) " +
" VALUES        (@a,@b,@c,@da,@db)";



                string[] r = { NumOperation,  Libelle, NomUt   };


                DateTime[] d = { DateOp, DateTime.Now };

                ClassRequette req = new ClassRequette();



                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
              //  PasserOperation = true;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void suprimerUneOeration( string  NumRef)
        {

            string s = " DELETE FROM tMvtStock" +
                           "  WHERE NumRef = @a ";



            string[] r = { NumRef };


            DateTime[] d = { DateTime.Now };

            ClassRequette req = new ClassRequette();



            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //PasserOperation = true;
        }



        public void suprimerUneOperationMouvement(string NumOperation, string NumCompte)
        {

            string s = " DELETE FROM tMvtCompte " +
                           "  WHERE (NumOperation=@a  and NumCompte=@b)";



            string[] r = { NumOperation, NumCompte };


            DateTime[] d = { DateTime.Now };

            ClassRequette req = new ClassRequette();



            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            //PasserOperation = true;
        }
        public void enregistrementMouvment(string NumOperation, string Details, string NumCompte, string Entree, string Sortie )
        {
            try
            {

                string s = " INSERT INTO tMvtCompte "+
                       "  (NumOperation,  NumCompte,  Entree, Sortie,Details,Qte)" +
" VALUES        (@a,@b,@c,@d,@e,@f) ";



                string[] r = { NumOperation, NumCompte, Entree, Sortie, Details, "1" };


                DateTime[] d = {DateTime.Now };

                ClassRequette req = new ClassRequette();



                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
               //PasserOperation = true;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void enregistrementMouvmentCmpte(string NumeroOperation, string NumCompte, string RefComptabilite,  string Entree, string Sortie)
        {
            try
            {

                string s = " INSERT INTO tMvtCompte " +
                        " (NumOperation, RefComptabilite, NumCompte,  Entree, Sortie)" +
" VALUES        (@a,@b,@c,@d,@e) ";



                string[] r = { NumeroOperation, RefComptabilite, NumCompte, Entree, Sortie };


                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();



                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //PasserOperation = true;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InserMvtCpteStockAvecQte2(string storage, string NumCompte, String QteEntree, string QteSortie, string PR, string Entree, string Sortie, string PVentUN, string refComp, string TypeOp, string NumOp)
        {
            try
            {
                //libeleOP = " FRAIS DIVERS ET AVANCE FRAIS SC A L INSCPION DE " + comboMatINS.Text + comboNomINS.Text + comboPosrIN.Text + " EN REF" + tCommentaire.Text.Trim();


                //Connection_Data();
                //if (con.State != ConnectionState.Open)
                //{
                //    con.Open();
                //}

                //MessageBox.Show( " dd" + ReferanceCompte + "/" + refComp);
                cmd.Parameters.Clear();
                cmd.CommandText = storage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumOperation", NumOp);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                //cmd.Parameters.AddWithValue("@CodeDepot", CodeDepot);
                cmd.Parameters.AddWithValue("@RefComptabilite", refComp);
                cmd.Parameters.AddWithValue("@TypeOp", TypeOp);
                cmd.Parameters.AddWithValue("@QteEntree", QteEntree);
                cmd.Parameters.AddWithValue("@QteSortie ", QteSortie);
                cmd.Parameters.AddWithValue("@Entree", Entree);
                cmd.Parameters.AddWithValue("@Sortie", Sortie);
                cmd.Parameters.AddWithValue("@PR", PR);
                cmd.Parameters.AddWithValue("@Vente", "0");
                cmd.Parameters.AddWithValue("@PVentUN", PVentUN);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                // lmessage.Text = tSousGroupe.Text + " EST AJOUTE ";
                //MessageBox.Show(ReferanceCompte);
                // annulerArtclicle();
                //con.Close();
                //cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en ref " + NumCompte + " OP" + NumOp + "Entree" + Entree );
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidationDeloperation(string op)
        {
            try
            {
                string smodifie = "UPDATE tOperation SET Valider =0 WHERE (NumOperation = @a)";

                string[] r2 = { op };
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, smodifie, r2, d);


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        public void ModdifierlEtaOT(string[] r, DateTime[] d)
        {
            string s = " UPDATE       tEtatDeBesoin " +
" SET                Etat = @b, ValiderPar = @c, DateValidation = @da "+
" WHERE        (CodeEtatdeBesoin = @a)";




           // string[] r = { Etat.ToString(), CodeOt };


            //DateTime[] d = { DateTime.Now };

            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

        }
    }
}
