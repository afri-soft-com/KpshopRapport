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

    }
}
