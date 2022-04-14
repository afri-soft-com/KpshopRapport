using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.EtatDeBesoin
{
    public class EbValiderServiDataAccesLayer
    {


        public EbValideServiModel AfficherSommedesEB(string CodeProjet, DateTime date1, DateTime date2)
        {

            //double EBnovelid = SommeEBnonvalide(CodeProjet, date1, date2);
            


            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    // ConsommationProjetViewModel obj = new ConsommationProjetViewModel();
                    EbValideServiModel objCust = new EbValideServiModel();
                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "RapportEtebesionValideETservie";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {




                        // objCust.CodeProject = Convert.ToInt32(_Reader["NumCompte"]);
                         objCust.CodeProject = _Reader["CodeProject"].ToString();
                        // objCust.Details = _Reader["Details"].ToString();
                        try { objCust.SommeEbDecaisse = Convert.ToDouble(_Reader["SommeSortie"]); } catch { objCust.SommeEbDecaisse = 0; }
                        try { objCust.SommeEbValide = Convert.ToDouble(_Reader["SommeValide"]); } catch { objCust.SommeEbValide = 0; }
                        //try { objCust.SommeEbEntenteDeValidation = EBnovelid; } catch { objCust.SommeEbEntenteDeValidation = 0; }
                      //  try { objCust.SoldeInitial = objCust.Solde - objCust.Debit + objCust.Credit; } catch { objCust.SoldeInitial = 0; }





                        // objCust.DateOperation = Convert.ToDateTime(_Reader["DateOp"]);
                        //_list.Add(objCust);
                    }

                    return objCust;
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


        public Double SommeEBnonvalide(string CodeProjet, DateTime date1, DateTime date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //  Conn.Open();
                    Double dernier_operation = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "RapportEtebesionNonValider";
                     SqlCommand objCommand = new SqlCommand(s, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);

                    //SqlDataReader _Reader = objCommand.ExecuteReader();

                    //while (_Reader.Read())
                    //{
                    //    dernier_operation = Convert.ToInt32(_Reader[""].ToString());
                    //}
                    dernier_operation = Double.Parse(objCommand.ExecuteScalar().ToString()) ;
                    return dernier_operation;
                }
                catch
                {
                    return 0;
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
