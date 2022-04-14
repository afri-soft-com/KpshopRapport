using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.Article
{
    public class ArticleDataAccessLayer
    {
        public void AjouterArticle(ArticleModel Art)
        {
            string s = "INSERT INTO tArticle" +
                "(CodeArticle, DesegnationArticle, CategorieArticle, PrixAchat," +
                " PrixVente) " +
                "VALUES(@a, @b, @c, @d, @e)";
            if (ArticleExiste(Art.CodeArticle) > 0)
            {
                Art.CodeArticle = Art.CodeArticle + "B";
            }

            string[] r = { Art.CodeArticle, Art.DesegnationArticle, 
            Art.CategorieArticle.ToString(), Art.PrixAchat.ToString(), Art.PrixVente.ToString()};

            DateTime[] d = { };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);

        }

        public Boolean DeleteArticle(ArticleModel Art)
        {
            if (ArticleExiste(Art.CodeArticle) > 0)
            {
                string s = "DELETE FROM tArticle WHERE(CodeArticle = @a)";

                string[] r = { Art.CodeArticle};

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

        public Boolean ModifierArticle(ArticleModel Art)
        {
            if(ArticleExiste(Art.CodeArticle) > 0)
            {
                string s = "UPDATE tArticle " +
                "SET DesegnationArticle = @a, CategorieArticle = @b, PrixAchat = @c, " +
                "PrixVente = @d WHERE CodeArticle = '" + Art.CodeArticle+"'";

                string[] r = { Art.DesegnationArticle, Art.CategorieArticle.ToString(), Art.PrixAchat.ToString(),
                 Art.PrixVente.ToString()};

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

        int ArticleExiste(String CodeArticle)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //  Conn.Open();
                    int article_exist = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select count(*) from tArticle where CodeArticle = '" + CodeArticle + "'";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    article_exist = int.Parse(objCommand.ExecuteScalar().ToString());
                    return article_exist;
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

        public int DernierArticle()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    int dernier_article = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select max(IdArticle) as IdArticle from tArticle";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    dernier_article = int.Parse(objCommand.ExecuteScalar().ToString()) + 1;

                    return dernier_article;
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

        public List<ArticleModel> ListDesArticles()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    List<ArticleModel> _list = new List<ArticleModel>();

                    //string s1 = "SELECT ISNULL(IdArticle, 0) as IdArticle, " +
                    //    "ISNULL(CodeArticle, '') as CodeArticle, " +
                    //    "ISNULL(CodeDepartement, '') as CodeDepartement," +
                    //    "ISNULL(DesegnationArticle, '') as DesegnationArticle, " +
                    //    "ISNULL(CategorieArticle, 0) as CategorieArticle, " +
                    //    "ISNULL(PrixAchat, 0.0) as PrixAchat, " +
                    //    "ISNULL(Critique, 0) as Critique, " +
                    //    "ISNULL(PrixVente, 0.0) as PrixVente, " +
                    //    "ISNULL(Compte, 0) as Compte, " +
                    //    "ISNULL(UniteEngro, '') as UniteEngro, " +
                    //    "ISNULL(UiniteEnDetaille, '') as UiniteEnDetaille, " +
                    //    "ISNULL(QteEnDet, 0.0) as QteEnDet, " +
                    //    "ISNULL(Enstock, 0.0) as Enstock, " +
                    //    "ISNULL(Solde, 0.0) as Solde, " +
                    //    "ISNULL(CompteFournisseur, 0) as CompteFournisseur " +
                    //    "FROM tArticle ";

                    string s = "select * from tArticle";

                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ArticleModel objCust = new ArticleModel();
                        objCust.IdArticle = Convert.ToInt32(_Reader["IdArticle"]);
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        objCust.CategorieArticle = Convert.ToInt32(_Reader["CategorieArticle"]);
                        try { objCust.PrixAchat = Convert.ToDouble(_Reader["PrixAchat"]); } catch { objCust.PrixAchat = 0; }
                        try { objCust.PrixVente = Convert.ToDouble(_Reader["PrixVente"]); } catch { objCust.PrixVente = 0; }

                       
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
