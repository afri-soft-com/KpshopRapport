using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibraryKpbatiment.ClasseCadreGroupe
{
     public class GroupeCompteDataAccesLayer
    {
        public List<GroupeCompteModel> ListeDeGroupe()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<GroupeCompteModel> _list = new List<GroupeCompteModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT        GroupeCompte, Cadre, DesignationGroupe "+
                                    " FROM tGroupeCompte ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        GroupeCompteModel objCust = new GroupeCompteModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]); 
                        objCust.DesignationGroupe = _Reader["DesignationGroupe"].ToString();
                        objCust.Cadre = Convert.ToInt32(_Reader["Cadre"]);
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



        public List<GroupeCompteModel> ListeDeGroupePourUngoupr( string Cadre)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<GroupeCompteModel> _list = new List<GroupeCompteModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT        GroupeCompte, Cadre, DesignationGroupe " +
                                    " FROM tGroupeCompte  WHERE (GroupeCompte=@a) ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", Cadre);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        GroupeCompteModel objCust = new GroupeCompteModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        objCust.DesignationGroupe = _Reader["DesignationGroupe"].ToString();
                        objCust.Cadre = Convert.ToInt32(_Reader["Cadre"]);
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


        public List<GroupeCompteModel> ListeDeGroupePourUnCadre(string Cadre)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<GroupeCompteModel> _list = new List<GroupeCompteModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT        GroupeCompte, Cadre, DesignationGroupe " +
                                    " FROM tGroupeCompte  WHERE (Cadre=@a) ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", Cadre);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        GroupeCompteModel objCust = new GroupeCompteModel();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        objCust.DesignationGroupe = _Reader["DesignationGroupe"].ToString();
                        objCust.Cadre = Convert.ToInt32(_Reader["Cadre"]);
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
