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
    class ClassComptable
    {


        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;



        public void enregistrementComptabe(string NumCompte, string Matricule, string GroupeCompte, string DesignationCompte, string CodeDepartement)
        {
            try
            {

                string s = "  INSERT INTO tCompte " +
                         "  (NumCompte, Matricule, GroupeCompte, DesignationCompte) " +
                    " VALUES(@a, @b, @c, @d ) ";
                
                string[] r = { NumCompte, Matricule, GroupeCompte, DesignationCompte };
                
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();

                
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

                MessageBox.Show("ENREGISTREMENT EFFECTUE");
            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }



        public void enregistrementGroupe(string Cadre, string GroupeCompte, string DesignationGroupe)
        {
            try
            {

                string s = "  INSERT INTO tGroupeCompte " +
                         " (Cadre, GroupeCompte, DesignationGroupe)" +
                        " VALUES(@a, @b, @c)";

                string[] r = { Cadre, GroupeCompte, DesignationGroupe  };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                MessageBox.Show("ENREGISTREMENT EFFECTUE");

            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }



        public void modifierCompte(string NumCompte, string Matricule, string GroupeCompte, string DesignationCompte)
        {
            try
            {

                string s = " UPDATE       tCompte " +
" SET NumCompte = @a, Matricule = @b, GroupeCompte = @c, DesignationCompte = @d " +
" WHERE(NumCompte = @a) ";

                
                string[] r = { NumCompte, Matricule, GroupeCompte, DesignationCompte };
                
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();
                
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                MessageBox.Show("MODIFICATION EFFECTUEE");

            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }



        public void modifierGroupe(string Cadre,  string DesignationGroupe, string GroupeCompte)
        {
            try
            {

                string s = " UPDATE       tGroupeCompte "+
" SET Cadre=@a,DesignationGroupe=@b " +
" WHERE(GroupeCompte=@c) ";


                string[] r = { Cadre, DesignationGroupe, GroupeCompte };

                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                MessageBox.Show("MODIFICATION EFFECTUEE");

            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

    }


}
