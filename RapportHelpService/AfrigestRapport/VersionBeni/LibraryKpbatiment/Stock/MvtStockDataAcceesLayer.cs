using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.Stock
{
    public class MvtStockDataAcceesLayer
    {

       



        public int EnregistrerMvtStock(MvtStockModel tbl)
        {
            using (SqlConnection con = new SqlConnection(ClassVariableGlobal.seteconnexion()))
            {
                con.Open();

                string query = "INSERT INTO tMvtStock " +
                        "  (NumOperation, CodeArticle, PR, PVentUN, QteEntree, CodeDepot, QteSortie, RefComptabilite) " +
" VALUES(@NumOperation, @CodeArticle, @PR, @PVentUN, @QteEntree, @CodeDepot, @QteSortie, @RefComptabilite) ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NumOperation", tbl.NumOperation);
                cmd.Parameters.AddWithValue("@CodeArticle", tbl.CodeArticle);
                cmd.Parameters.AddWithValue("@PR", tbl.PR);
                cmd.Parameters.AddWithValue("@QteEntree", tbl.QteEntree);
                cmd.Parameters.AddWithValue("@CodeDepot", tbl.CodeDepot);
                cmd.Parameters.AddWithValue("@QteSortie", tbl.QteSortie);
                cmd.Parameters.AddWithValue("@RefComptabilite", tbl.RefComptabilite);
               
                return cmd.ExecuteNonQuery();
            }
        }

        public List<StockModel> listToutLesArticles()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //Conn.Open();
                    List<StockModel> _list = new List<StockModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    //string s1 = "SELECT * FROM tCompte";
                    string s1 = "Proc_ListeDesArticles";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    //objCommand.Parameters.AddWithValue("@a", GroupeCompte);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        StockModel objCust = new StockModel();
                        objCust.PrixAchat = Convert.ToDouble(_Reader["PrixAchat"]);
                        objCust.Nombre = Convert.ToInt32(_Reader["Nombre"]);
                        objCust.PrixVente = Convert.ToDouble(_Reader["PrixVente"]);
                        objCust.DesegnationArticle = _Reader["DesegnationArticle"].ToString();

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
