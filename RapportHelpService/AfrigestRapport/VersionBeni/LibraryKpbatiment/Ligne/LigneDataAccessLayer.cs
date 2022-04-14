using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.Ligne
{
    public class LigneDataAccessLayer
    {
        public void AjouterLigne(LigneModel Lg)
        {
            string s = " INSERT INTO tLigne" +
                " (CodeLigne, CodeProject, DesignationLIgne,Prevision)" +
                " VALUES(@a, @b, @c,@d)";

            string[] r = { Lg.CodeLigne, Lg.CodeProject, Lg.DesignationLIgne,Lg.Prevision.ToString()};

            DateTime[] d = { DateTime.Now };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
        }

        public Boolean UpdateLigne(LigneModel Lg)
        {
            if(LigneExiste(Lg.CodeLigne)>0)
            {
                string s = " UPDATE tLigne " + " SET  CodeProject = @b, DesignationLIgne = @c, Prevision = @d " +
                " WHERE(CodeLigne = @a)";

                string[] r = { Lg.CodeLigne, Lg.CodeProject, Lg.DesignationLIgne, Lg.Prevision.ToString() };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DeleteLigne(LigneModel Lg)
        {
            if (LigneExiste(Lg.CodeLigne) > 0)
            {
                string s = "DELETE FROM tLigne WHERE(CodeLigne = @a)";

                string[] r = { Lg.CodeLigne };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;
            }
            else
            {
                return false;
            }
        }

        int LigneExiste(String LigneCode)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //  Conn.Open();
                    int dernier_operation = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select count(*) from tLigne where CodeLigne = '" +LigneCode+"'";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    dernier_operation = int.Parse(objCommand.ExecuteScalar().ToString());
                    return dernier_operation;
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
        public int DernierLigne()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                  //  Conn.Open();
                    int dernier_operation = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select max(IdLigne) from tLigne";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    //SqlDataReader _Reader = objCommand.ExecuteReader();

                    //while (_Reader.Read())
                    //{
                    //    dernier_operation = Convert.ToInt32(_Reader[""].ToString());
                    //}
                    dernier_operation = int.Parse(objCommand.ExecuteScalar().ToString())+1;
                    return dernier_operation;
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

        public List<LigneModel> ToutesLesLignes()
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    string compteur = "select * from tLigne";

                    List<LigneModel> ligneModels = new List<LigneModel>();

                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();
                    while (_Reader.Read())
                    {
                        LigneModel objCust = new LigneModel();
                        objCust.IdLigne = Convert.ToInt32(_Reader["IdLigne"]);
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        objCust.Prevision = Convert.ToDouble(_Reader["Prevision"]);
                        try
                        {
                            objCust.Prevision = Convert.ToDouble(_Reader["Prevision"]);
                        }
                        catch
                        {
                            objCust.Prevision = 0;
                        }
                        ligneModels.Add(objCust);
                    }

                    return ligneModels;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (conn != null)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
                    }
                }
        }



        public List<LigneModel> ToutesLesLigneParProjet( string codeProject)
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    string compteur = "select * from tLigne where  CodeProject=@a";

                    List<LigneModel> ligneModels = new List<LigneModel>();

                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    objCommand.Parameters.AddWithValue("@a", codeProject);
                    SqlDataReader _Reader = objCommand.ExecuteReader();
                    while (_Reader.Read())
                    {
                        LigneModel objCust = new LigneModel();
                        objCust.IdLigne = Convert.ToInt32(_Reader["IdLigne"]);
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        try
                        {
                            objCust.Prevision = Convert.ToDouble(_Reader["Prevision"]);
                        }
                        catch
                        {
                            objCust.Prevision = 0;
                        }
                       
                        ligneModels.Add(objCust);
                    }

                    return ligneModels;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (conn != null)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
                    }
                }
        }

        public List<LigneModel> LignesParCodeProjet(string codeprojet)
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    string compteur = "select * from tLigne where CodeProject = '" + codeprojet +"'";

                    List<LigneModel> ligneModels = new List<LigneModel>();

                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();
                    while (_Reader.Read())
                    {
                        LigneModel objCust = new LigneModel();
                        objCust.IdLigne = Convert.ToInt32(_Reader["IdLigne"]);
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        try
                        {
                            objCust.Prevision = Convert.ToDouble(_Reader["Prevision"]);
                        }
                        catch
                        {
                            objCust.Prevision = 0;
                        }

                        ligneModels.Add(objCust);
                    }

                    return ligneModels;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (conn != null)
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
                    }
                }
        }


        public List<LigneViewModel> ListeConsommationLigne( String CodeProject)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<LigneViewModel> _list = new List<LigneViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "LesConsommationDeLigneParProjet";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProject);
                    //objCommand.Parameters.AddWithValue("@da", date1);
                    //objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        LigneViewModel objCust = new LigneViewModel();



                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        // objCust.Details = _Reader["Details"].ToString();
                        try
                        {
                            objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]);
                        }
                        catch { objCust.TotalConsommation = 0; }

                        try
                        {
                            objCust.TOtalPrevision = Convert.ToDouble(_Reader["TOtalPrevision"]);
                        }
                        catch { objCust.TOtalPrevision = 0; }
                        try { objCust.TauxCons = Convert.ToDouble(_Reader["TauxCons"]); ; } catch { objCust.TauxCons = 0; }



                        // objCust.DateOperation = Convert.ToDateTime(_Reader["DateOp"]);
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
