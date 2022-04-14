using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApplication1;
using System.Windows.Forms;

namespace GoldenStarApplication.LesClasses
{
    class ClasseArticle
    {

        public void  EnrigistrementParametre(string CodeDepot, string CodeArticle, string StockCritique, string PuVente, string Unite)
        {

            try
            {

                String s = "INSERT INTO tPametreDepot " +
                      "   (CodeDepot, CodeArticle, StockCritique, PuVente, Unite) VALUES(@a, @b, @c, @d, @e)";


                string[] r = { CodeDepot, CodeArticle, StockCritique, PuVente, Unite };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //MessageBox.Show(CodeDepot + ", " + CodeArticle + " ," + StockCritique);
                //MessageBox.Show("ENREGISTREMENT EFFECTUE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //  string sAchat = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAchat,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";

          

        }

        public void enreSrock( string NumOperation, string NumCompte, string CodeDepot)
        {

            try
            {

                String s = " INSERT  INTO   tMvtStock     (NumOperation,CodeArticle,CodeDepot) VALUES (@a,@b,@c)";



                string[] r = { NumOperation, NumCompte, CodeDepot };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

                //MessageBox.Show("ENREGISTREMENT EFFECTUE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void SupprimerInititialDepot(string NumOperation, string NumCompte, string CodeDepot)
        {

            try
            {

                String s = " DELETE from   tMvtStock     WHERE (NumOperation=@a) AND (CodeArticle=@b) AND (CodeDepot=@c) ";



                string[] r = { NumOperation, NumCompte, CodeDepot };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

              //  MessageBox.Show("ENREGISTREMENT EFFECTUE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void SupprimerLinitial(string CodeDepot, string CodeArticle)
        {

            try
            {

                String s = " DELETE  FROM tPametreDepot " +
                      "  WHERE (CodeDepot =@a) and (CodeArticle=@b)";


                string[] r = { CodeDepot, CodeArticle };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

               // MessageBox.Show("ENREGISTREMENT EFFECTUE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //  string sAchat = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteEntree, PVentUN,Entree,QteEntreeAchat,PR) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";



        }

    }
}
