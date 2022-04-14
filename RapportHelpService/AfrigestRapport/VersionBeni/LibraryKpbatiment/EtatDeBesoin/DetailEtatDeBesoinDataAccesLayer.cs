using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.EtatDeBesoin
{
     public class DetailEtatDeBesoinDataAccesLayer
    {
        public void AjouterDetailEtatDebesion( DetailEtatDeBesoinModel DEm)
        {

            string s = "  INSERT INTO tDetailEtatBesoin " +
                "(CodeEtatdeBesoin, CodeArticle, CodeLigne, LibelleDetail, Qte, Pu, Sortie, Entree) " +
                "VALUES(@a, @b, @c, @d, @e, @f, @g, @h)";

            string[] r = {DEm.CodeEtatdeBesoin, DEm.CodeArticle, DEm.CodeLigne, 
                DEm.LibelleDetail, DEm.Qte.ToString(), DEm.Pu.ToString(), DEm.Sortie.ToString(), DEm.Entree.ToString()};

            DateTime[] d = {};
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d); ;

        }

        public Boolean EffacerDetailEtatBesoin(DetailEtatDeBesoinModel DEm)
        {
            if (Exist(DEm.IdDetailEB) > 0)
            {
                string s = "DELETE FROM tDetailEtatBesoin WHERE(IdDetailEB = @a)";

                string[] r = { DEm.IdDetailEB.ToString() };

                DateTime[] d = { };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ModifierDetailEtatDebesion(DetailEtatDeBesoinModel DEm)
        {

            if(Exist(DEm.IdDetailEB) > 0)
            {
                string s = "UPDATE tDetailEtatBesoin " +
                    "SET LibelleDetail = @a, Qte = @b, Pu = @c " +
                    "WHERE(IdDetailEB = " + DEm.IdDetailEB+")";

                string[] r = { DEm.LibelleDetail, DEm.Qte.ToString(), DEm.Pu.ToString()};

                DateTime[] d = { };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;
            }
            else
            {
                return false;
            }

        }

        int Exist(int idEtatDeBesoin)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    int detailEtatBesoin_exist = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select count(*) from tDetailEtatBesoin" +
                        " where IdDetailEB = " + idEtatDeBesoin ;
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    detailEtatBesoin_exist = int.Parse(objCommand.ExecuteScalar().ToString());
                    return detailEtatBesoin_exist;
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

        public int DernierDetailEtatDeBesoin()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    int dernier_detail_besoin = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select ISNULL(MAX(IdDetailEB), 0) from tDetailEtatBesoin";
                    SqlCommand objCommand = new SqlCommand(s, Conn);

                    dernier_detail_besoin = int.Parse(objCommand.ExecuteScalar().ToString()) + 1;
                    return dernier_detail_besoin;
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

        public List<DetailEtatDeBesoinModel> ListeDetailEtatDeBesoin(string codeEtatBesoin)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailEtatDeBesoinModel> _list = new List<DetailEtatDeBesoinModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT ISNULL(tDetailEtatBesoin.IdDetailEB, 0) AS IdDetailEB, " +
                        "ISNULL(tDetailEtatBesoin.CodeEtatdeBesoin, '') AS CodeEtatdeBesoin, " +
                        "ISNULL(tDetailEtatBesoin.CodeArticle, '') AS CodeArticle, " +
                        "ISNULL(tDetailEtatBesoin.CodeLigne, '')  " +
                         "AS CodeLigne, ISNULL(tDetailEtatBesoin.LibelleDetail, '') AS LibelleDetail, " +
                         "ISNULL(tDetailEtatBesoin.Qte, 0) AS Qte, " +
                         "ISNULL(tDetailEtatBesoin.Pu, 0) AS Pu, " +
                         "ISNULL(tDetailEtatBesoin.Sortie, 0) AS Sortie," +
                        "  ISNULL(tDetailEtatBesoin.Entree, 0) AS Entree, " +
                        "ISNULL(tArticle.DesegnationArticle , '') AS DesegnationArticle" +
                        " FROM  tDetailEtatBesoin INNER JOIN " +
                       "   tArticle ON tDetailEtatBesoin.CodeArticle = tArticle.CodeArticle " +
                       "WHERE(tDetailEtatBesoin.CodeEtatdeBesoin ='" + codeEtatBesoin + "') ";
                      //  "WHERE CodeEtatdeBesoin = '"+codeEtatBesoin+"'";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailEtatDeBesoinModel objCust = new DetailEtatDeBesoinModel();
                        objCust.IdDetailEB = Convert.ToInt32(_Reader["IdDetailEB"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.LibelleDetail = _Reader["LibelleDetail"].ToString();
                        objCust.Qte = Convert.ToDouble(_Reader["Qte"]);
                        objCust.Pu = Convert.ToDouble(_Reader["Pu"]);
                        objCust.Sortie = Convert.ToDouble(_Reader["Sortie"]);
                        objCust.Entree = Convert.ToDouble(_Reader["Entree"]);
                        _list.Add(objCust);
                    }

                    return _list;
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




        public List<DetailEtatDeBesoinModel> ListeDetailEtatDeBesoinRappor(string codeEtatBesoin, string codeLigne)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailEtatDeBesoinModel> _list = new List<DetailEtatDeBesoinModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT Ligne.DesignationLIgne, tLigne.CodeLigne, SUM(View_KpDetailleEB.Total) AS TotalConsommation, " +
                        "View_KpDetailleEB.CodeEtatdeBesoin, View_KpDetailleEB.DesignationEtatDeBesion, View_KpDetailleEB.CodeArticle," +
                        "  View_KpDetailleEB.Qte, View_KpDetailleEB.Pu, tArticle.DesegnationArticle, View_KpDetailleEB.LibelleDetail " +
" FROM      tArticle INNER JOIN" +
                        "  View_KpDetailleEB ON tArticle.CodeArticle = View_KpDetailleEB.CodeArticle RIGHT OUTER JOIN " +
                         " tProject INNER JOIN " +
                        "  tLigne ON tProject.CodeProject = tLigne.CodeProject ON View_KpDetailleEB.CodeLigne = tLigne.CodeLigne " +
" GROUP BY tLigne.DesignationLIgne, tLigne.CodeLigne, View_KpDetailleEB.CodeEtatdeBesoin, View_KpDetailleEB.DesignationEtatDeBesion, View_KpDetailleEB.CodeArticle, View_KpDetailleEB.Qte, View_KpDetailleEB.Pu,  " +
                         " tArticle.DesegnationArticle, View_KpDetailleEB.LibelleDetail " +
" HAVING(tLigne.CodeLigne = @b) AND(View_KpDetailleEB.CodeEtatdeBesoin = @a) ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", codeEtatBesoin);
                    objCommand.Parameters.AddWithValue("@b", codeLigne);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailEtatDeBesoinModel objCust = new DetailEtatDeBesoinModel();
                        //objCust.IdDetailEB = Convert.ToInt32(_Reader["IdDetailEB"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.LibelleDetail = _Reader["DesegnationArticle"].ToString();
                        objCust.Qte = Convert.ToDouble(_Reader["Qte"]);
                        objCust.Pu = Convert.ToDouble(_Reader["Pu"].ToString());
                        objCust.Total = Convert.ToDouble(_Reader["TotalConsommation"].ToString());
                        _list.Add(objCust);
                    }

                    return _list;

//                    string query = "SELECT        tDetailEtatBesoin.IdDetailEB, tDetailEtatBesoin.CodeEtatdeBesoin, tDetailEtatBesoin.CodeArticle, tDetailEtatBesoin.CodeLigne, tDetailEtatBesoin.LibelleDetail, tDetailEtatBesoin.Qte, tDetailEtatBesoin.Pu, 
//                         tDetailEtatBesoin.Sortie, tDetailEtatBesoin.Entree, tArticle.DesegnationArticle, tArticle.CodeArticle, tArticle.CompteFournisseur, tArticle.CategorieArticle, tArticle.PrixAchat, tArticle.Critique, tArticle.PrixVente, 
//                         tArticle.Compte, tArticle.QteEnDet, tArticle.Enstock, tArticle.Solde, tArticle.UniteEngro, tArticle.UiniteEnDetaille, tArticle.CodeDepartement, tArticle.IdArticle
//FROM            tDetailEtatBesoin INNER JOIN
//                         tArticle ON tDetailEtatBesoin.CodeArticle = tArticle.CodeArticle
//WHERE(tDetailEtatBesoin.CodeEtatdeBesoin = 'EB168')";
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

        public List<DetailEtatDeBesoinModel> ListeDetailEtatDeBesoinArticle(string codeEtatBesoin)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailEtatDeBesoinModel> _list = new List<DetailEtatDeBesoinModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

        string query = "SELECT tDetailEtatBesoin.IdDetailEB, " +
                        "tDetailEtatBesoin.CodeEtatdeBesoin," +
                        " tDetailEtatBesoin.CodeArticle, tDetailEtatBesoin.CodeLigne, " +
                        "tDetailEtatBesoin.LibelleDetail, " +
                        "tDetailEtatBesoin.Qte, tDetailEtatBesoin.Pu, " +
                        "tDetailEtatBesoin.Sortie, tDetailEtatBesoin.Entree, tArticle.DesegnationArticle," +
                        " tArticle.CodeArticle, tArticle.CategorieArticle, " +
                        "tArticle.PrixAchat, tArticle.PrixVente " +
                        "FROM tDetailEtatBesoin INNER JOIN " +
                        "tArticle ON tDetailEtatBesoin.CodeArticle = tArticle.CodeArticle " +
                        "WHERE(tDetailEtatBesoin.CodeEtatdeBesoin = @a)";

                    SqlCommand objCommand = new SqlCommand(query, Conn);
                    objCommand.Parameters.AddWithValue("@a", codeEtatBesoin);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailEtatDeBesoinModel objCust = new DetailEtatDeBesoinModel();
                        objCust.IdDetailEB = Convert.ToInt32(_Reader["IdDetailEB"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.LibelleDetail = _Reader["LibelleDetail"].ToString();
                        objCust.Qte = Convert.ToDouble(_Reader["Qte"]);
                        objCust.Pu = Convert.ToDouble(_Reader["Pu"]);
                        objCust.Sortie = Convert.ToDouble(_Reader["Sortie"]);
                        objCust.Entree = Convert.ToDouble(_Reader["Entree"]);
                        _list.Add(objCust);
                    }

                    return _list;

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
