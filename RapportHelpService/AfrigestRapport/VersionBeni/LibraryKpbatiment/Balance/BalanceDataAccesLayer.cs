using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.Balance
{
    public class BalanceDataAccesLayer
    {


        public List<BalanceModel> ListeBalanceDeTouLesCompte()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<BalanceModel> _list = new List<BalanceModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT    NumCompte, DesignationCompte, DesignationGroupe, GroupeCompte, Solde, Nombre," +
                        " MaxDateOP " 
                        +" FROM   View_LesSoldeDeCompte ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        BalanceModel objCust = new BalanceModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);
                        objCust.DesignationGroupe = _Reader["DesignationCompte"].ToString();
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        try{ objCust.Nombre = Convert.ToInt32(_Reader["Nombre"]); } catch { objCust.Nombre = 0; }
                        try { objCust.Solde = Convert.ToDouble(_Reader["Solde"]); } catch { objCust.Solde = 0; }
                       
                        
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



        public List<BalanceModel> ListeBalanceDeGroupeDeCompte()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<BalanceModel> _list = new List<BalanceModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT        DesignationGroupe, GroupeCompte, SUM(Solde) AS Solde, SUM(Nombre) AS Nombre, MAX(MaxDateOP) AS MaxDateOP " +
" FROM View_LesSoldeDeCompte " +
" GROUP BY DesignationGroupe, GroupeCompte ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        BalanceModel objCust = new BalanceModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        //objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);
                        objCust.DesignationGroupe = _Reader["DesignationGroupe"].ToString();
                        //objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        try { objCust.Nombre = Convert.ToInt32(_Reader["Nombre"]); } catch { objCust.Nombre = 0; }
                        try { objCust.Solde = Convert.ToDouble(_Reader["Solde"]); } catch { objCust.Solde = 0; }


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


        public List<BalanceModel> ListeBalancePourUnGroupe( string GroupeCompte)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<BalanceModel> _list = new List<BalanceModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT        NumCompte, DesignationCompte, DesignationGroupe, GroupeCompte, Solde, Nombre, MaxDateOP " +
" FROM            View_LesSoldeDeCompte WHERE (GroupeCompte=@a)  ";

                    //                   String s1 = "SELECT        NumCompte, DesignationCompte, DesignationGroupe, GroupeCompte, Solde, Nombre, MaxDateOP " +
                    //" FROM View_LesSoldeDeCompte WHERE(GroupeCompte = 572)  ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", GroupeCompte);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        BalanceModel objCust = new BalanceModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);
                        objCust.DesignationGroupe = _Reader["DesignationGroupe"].ToString();
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();


                        try{objCust.Nombre = Convert.ToInt32(_Reader["Nombre"]);} catch{objCust.Nombre = 0;}
                        try { objCust.Solde = Convert.ToDouble(_Reader["Solde"]); } catch { objCust.Solde = 0; }
                        try { objCust.DateOperation = Convert.ToDateTime(_Reader["MaxDateOP"]); } catch { objCust.DateOperation = DateTime.Now; }

                        
                       
                       

                        
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
