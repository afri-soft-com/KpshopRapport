using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.RapportDesArticleEtLigneAuProjet
{
    public class RapportDesArticleEtLigneAuProjetDataAccesLayer
    {


        public List<ArticleEtLigneViewModel> ListeDesArticlesConsomesParProjet(string CodeProjet)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<ArticleEtLigneViewModel> _list = new List<ArticleEtLigneViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "RapportDesArticleConsomePourUnProjet";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    //objCommand.Parameters.AddWithValue("@b", CodeLigne);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ArticleEtLigneViewModel objCust = new ArticleEtLigneViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                       // objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                       // objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        try { objCust.Qte = Convert.ToDouble(_Reader["Qte"]); } catch { objCust.Qte = 0; }
                        try { objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]); } catch { objCust.TotalConsommation = 0; }
                        try { objCust.Pu = objCust.TotalConsommation / (objCust.Qte); } catch { objCust.Pu = 0; }

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
        public List<ArticleEtLigneViewModel> ListeDesArticleParRapportAuxLIGNE(string CodeProjet, string CodeLigne)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<ArticleEtLigneViewModel> _list = new List<ArticleEtLigneViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "RapportDesArticleParRapportAuLigne";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@b", CodeLigne);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ArticleEtLigneViewModel objCust = new ArticleEtLigneViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        try { objCust.Qte = Convert.ToDouble(_Reader["Qte"]); } catch { objCust.Qte = 0; }
                        try { objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]); } catch { objCust.TotalConsommation = 0; }
                        try { objCust.Pu = objCust.TotalConsommation/ (objCust.Qte); } catch { objCust.Pu = 0; }

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



        public List<ArticleEtLigneViewModel> ListeDesLigneParRapportAuxArticle(string CodeProjet, string CodeArticle)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<ArticleEtLigneViewModel> _list = new List<ArticleEtLigneViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "RapportDesLigneParRapportAuxArticle";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@b", CodeArticle);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ArticleEtLigneViewModel objCust = new ArticleEtLigneViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        try { objCust.Qte = Convert.ToDouble(_Reader["Qte"]); } catch { objCust.Qte = 0; }
                        try { objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]); } catch { objCust.TotalConsommation = 0; }
                        try { objCust.Prevision = Convert.ToDouble(_Reader["Prevision"]); } catch { objCust.Prevision = 0; }
                        try { objCust.TauxCons = Convert.ToDouble(_Reader["TauxCons"]); } catch { objCust.TauxCons = 0; }
                        try { objCust.Pu = objCust.TotalConsommation / (objCust.Qte); } catch { objCust.Pu = 0; }

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


        public List<DetailEbViewModel> ListeReferenEtatBesionConsome(string CodeProjet, string CodeArticle, string CodeLigne)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailEbViewModel> _list = new List<DetailEbViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "RapportRefEtadeBesoinDesLigneEtArtile";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@b", CodeArticle);
                    objCommand.Parameters.AddWithValue("@c", CodeLigne);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailEbViewModel objCust = new DetailEbViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        try { objCust.Qte = Convert.ToDouble(_Reader["Qte"]); } catch { objCust.Qte = 0; }
                        try { objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]); } catch { objCust.TotalConsommation = 0; }
                        try { objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]); } catch { objCust.DateEmision = DateTime.Now ; }
                       // try { objCust.TauxCons = Convert.ToDouble(_Reader["TauxCons"]); } catch { objCust.TauxCons = 0; }
                        try { objCust.Pu = objCust.TotalConsommation / (objCust.Qte); } catch { objCust.Pu = 0; }

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
