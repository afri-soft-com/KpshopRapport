using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.MvtCompte
{
    public class MvtCompteDataAccessLayer
    {
        public int AjouterMvtCompte(MvtCompteModel MvtC)
        {
            string s = " INSERT INTO tMvtCompte " +
                "(NumCompte, NumOperation, Details, QteEntree, Entree, Sortie) " +
                "VALUES(@a, @b, @c, @d, @e, @f)";

            string[] r = { MvtC.NumCompte, MvtC.NumOperation, MvtC.Details.ToString(),
                MvtC.Qte.ToString(), MvtC.Entree.ToString(), MvtC.Sortie.ToString() };

            DateTime[] d = { };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
            return 1;

        }

        public int DernierMvtCompte()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    int dernier_mvt_compte = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select max(IdMouvement) as IdMouvement from tMvtCompte";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    dernier_mvt_compte = int.Parse(objCommand.ExecuteScalar().ToString())+1;

                    return dernier_mvt_compte;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (Conn != null)
                    {
                        if (Conn.State == ConnectionState.Open)
                        {
                            Conn.Close();
                            Conn.Dispose();
                        }
                    }
                }
        }
    }
}
