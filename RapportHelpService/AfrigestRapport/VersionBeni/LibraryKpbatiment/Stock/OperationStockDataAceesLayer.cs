using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.Stock
{
    public class OperationStockDataAceesLayer
    {

        public List<DepotModel> lilsteDesOperationParDepot(string Numperation)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DepotModel> _list = new List<DepotModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT        tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp, tMvtStock.CodeDepot, tDepot.CodeDepot AS Expr1, tDepot.DesignationDepot "+
" FROM tOperation INNER JOIN " +
                         " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                         " tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot "+
" GROUP BY tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp, tMvtStock.CodeDepot, tDepot.CodeDepot, tDepot.DesignationDepot "+
" HAVING(tOperation.NumOperation = @a) " ;


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.Text;
                    objCommand.Parameters.AddWithValue("@a", Numperation);
                   // objCommand.Parameters.AddWithValue("@db", date2);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DepotModel objCust = new DepotModel();
                        //  objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.CodeDepot = _Reader["CodeDepot"].ToString();
                        objCust.DesignationDepot = _Reader["DesignationDepot"].ToString();


                       // try { objCust.DateOp = Convert.ToDateTime(_Reader["DateOp"]); } catch { objCust.DateOp = DateTime.Now; };
                        //  objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);


                        //objCust.Autre = _Reader["Autre"].ToString();

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



        public List<MvtStockModel> lilsteDesOperationEntreeSortie(string Numperation , string CodeDepot)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<MvtStockModel> _list = new List<MvtStockModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT        tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp, tMvtStock.CodeDepot, tDepot.DesignationDepot, tStock.CodeArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tMvtStock.PR,  " +
                       "   tMvtStock.PVentUN, tStock.DesegnationArticle, tMvtStock.Sortie, tMvtStock.Entree, (tMvtStock.QteEntree * tMvtStock.PR) AS Valeur , (tMvtStock.QteSortie * tMvtStock.PVentUN) AS Vente " +
" FROM            tOperation INNER JOIN " +
                         " tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation INNER JOIN " +
                        "  tDepot ON tMvtStock.CodeDepot = tDepot.CodeDepot INNER JOIN " +
                        "  tStock ON tMvtStock.CodeArticle = tStock.CodeArticle " +
" GROUP BY tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp, tMvtStock.CodeDepot, tDepot.DesignationDepot, tStock.CodeArticle, tMvtStock.QteEntree, tMvtStock.QteSortie, tMvtStock.PR,  " +
                         " tMvtStock.PVentUN, tStock.DesegnationArticle, tMvtStock.Sortie, tMvtStock.Entree, tMvtStock.Vente " +
" HAVING(tOperation.NumOperation = @a) AND(tMvtStock.CodeDepot = @b) ";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.Text;
                    objCommand.Parameters.AddWithValue("@a", Numperation);
                    objCommand.Parameters.AddWithValue("@b", CodeDepot);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        MvtStockModel objCust = new MvtStockModel();
                        //  objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.CodeDepot = _Reader["CodeDepot"].ToString();
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();

                        try { objCust.PVentUN = Convert.ToDouble(_Reader["PVentUN"]); } catch { objCust.PVentUN = 0; };
                        try { objCust.PR = Convert.ToDouble(_Reader["PR"]); } catch { objCust.PR = 0; };
                        try { objCust.QteEntree = Convert.ToDouble(_Reader["QteEntree"]); } catch { objCust.QteEntree = 0; };
                        try { objCust.QteSortie = Convert.ToDouble(_Reader["QteSortie"]); } catch { objCust.QteSortie = 0; };

                        try { objCust.Vente = Convert.ToDouble(_Reader["Vente"]); } catch { objCust.Vente = 0; };
                        try { objCust.Valeur = Convert.ToDouble(_Reader["Valeur"]); } catch { objCust.Valeur = 0; };



                        //  objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);


                        //objCust.Autre = _Reader["Autre"].ToString();

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



        public List<MvtStockModel> lilsteFicheDeStovk(string CodeArticle, string CodeDepot, DateTime date1, DateTime date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<MvtStockModel> _list = new List<MvtStockModel>();

                    if (Conn.State != System.Data.ConnectionState.Open) 
                        Conn.Open();


                    String s1 = "RapporFicheDestokUnproduit";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure ;
                    objCommand.Parameters.AddWithValue("@a", CodeArticle);
                    objCommand.Parameters.AddWithValue("@b", CodeDepot);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        MvtStockModel objCust = new MvtStockModel();
                        //  objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.CodeDepot = _Reader["CodeDepot"].ToString();
                        objCust.DesegnationArticle = _Reader["Libelle"].ToString();
                        objCust.CodeArticle = _Reader["CodeArticle"].ToString();
                       // objCust.DateOp = _Reader["DateOp"];

                        try { objCust.PVentUN = Convert.ToDouble(_Reader["PVentUN"]); } catch { objCust.PVentUN = 0; };
                        try { objCust.PR = Convert.ToDouble(_Reader["PR"]); } catch { objCust.PR = 0; };
                        try { objCust.QteEntree = Convert.ToDouble(_Reader["QteEntree"]); } catch { objCust.QteEntree = 0; };
                        try { objCust.QteSortie = Convert.ToDouble(_Reader["QteSortie"]); } catch { objCust.QteSortie = 0; };

                        try { objCust.Vente = Convert.ToDouble(_Reader["Vente"]); } catch { objCust.Vente = 0; };
                        try { objCust.Valeur = Convert.ToDouble(_Reader["Valeur"]); } catch { objCust.Valeur = 0; };
                        try { objCust.Enstock = Convert.ToDouble(_Reader["Enstock"]); } catch { objCust.Enstock = 0; };

                        try { objCust.DateOp = Convert.ToDateTime(_Reader["DateOp"]); } catch { objCust.DateOp = DateTime.Now; };

                        //  objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);Enstock


                        //objCust.Autre = _Reader["Autre"].ToString();

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
