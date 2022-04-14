using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.Balance
{
     public class DetailBalanceDataAccesLayer
    {
        public List<DetailBalanceModel> ListeDetailBalance(int NumCompte ,DateTime date1 ,DateTime date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailBalanceModel> _list = new List<DetailBalanceModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "Proc_RapportReleveCompte";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", NumCompte);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailBalanceModel objCust = new DetailBalanceModel();
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);
                        
                        objCust.NumOperation = _Reader["NumOperation"].ToString();
                       // objCust.DesignationCompte = "   :" + _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.Libelle = _Reader["Libelle"].ToString();
                        objCust.Details = _Reader["Details"].ToString();

                        objCust.Debit = Convert.ToDouble(_Reader["Entree"]);
                        objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);
                        objCust.Solde = Convert.ToDouble(_Reader["Solde"]);
                        objCust.DateOperation = Convert.ToDateTime(_Reader["DateOp"]);
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



        public List<DetailBalanceModel> ListeDetetailEB(String CodeEB)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailBalanceModel> _list = new List<DetailBalanceModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT        tOperation.NumOperation, tOperation.DateOp, tOperation.Libelle, tMvtCompte.Details,tMvtCompte.Sortie AS Total , tOperation.CodeEtatdeBesoin, tMvtCompte.NumCompte, tCompte.DesignationCompte " +
 " FROM tMvtCompte INNER JOIN " +
                         " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation INNER JOIN " +
                         " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte " +
" WHERE(tOperation.CodeEtatdeBesoin = @a) AND(tMvtCompte.Sortie <> 0)";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                   // objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeEB);
                    
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailBalanceModel objCust = new DetailBalanceModel();
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.NumOperation = _Reader["NumOperation"].ToString();
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        objCust.Libelle = _Reader["Libelle"].ToString();
                        objCust.Details = _Reader["Details"].ToString();

                        objCust.Debit = Convert.ToDouble(_Reader["Total"]);
                        objCust.Credit = Convert.ToDouble(_Reader["Total"]);
                        objCust.Solde = Convert.ToDouble(_Reader["Total"]);
                        objCust.DateOperation = Convert.ToDateTime(_Reader["DateOp"]);
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
        public List<ReleveModel> ReleveCompte(int NumCompte, DateTime date1, DateTime date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<ReleveModel> _list = new List<ReleveModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "ReleverCompte";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", NumCompte);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ReleveModel objCust = new ReleveModel();
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.NumOperation = _Reader["NumOperation"].ToString();
                        //
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        objCust.Libelle = _Reader["Libelle"].ToString();
                        objCust.Details = _Reader["Details"].ToString();

                        objCust.Debit = Convert.ToDouble(_Reader["Entree"]);
                        objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);
                        objCust.Solde = Convert.ToDouble(_Reader["Solde"]);
                        objCust.DateOperation = Convert.ToDateTime(_Reader["DateOp"]);

                        objCust.DesignationEnt = _Reader["Designation"].ToString();
                        objCust.TeleEnt = _Reader["TeleEnt"].ToString();
                        objCust.Adresse1 = _Reader["Adresse1"].ToString();
                        objCust.Adresse2 = _Reader["Adresse2"].ToString();
                        objCust.Email = _Reader["Email"].ToString();
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
