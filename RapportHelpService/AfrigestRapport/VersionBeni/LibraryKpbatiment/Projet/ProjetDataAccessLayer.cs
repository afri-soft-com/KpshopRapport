using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LibraryKpbatiment.Projet
{
     public class ProjetDataAccessLayer
    {
        // public void AjouterProjet(ProjetModel Pm)
        //{
        //    string s = "  INSERT INTO tProject "+
        //                " (CodeProject, DesignationProject, Lieu, ChefDuProjet, Etat, Compte, DateDebut, DateFin) " +
        //                " VALUES(@a, @b, @c, @d, @e, @f, @da, @db)";

        //    string[] r = { Pm.CodeProject, Pm.DesignationProject, Pm.Lieu, Pm.ChefDuProjet,
        //        Pm.Etat.ToString(), Pm.Compte.ToString() };

        //    DateTime[] d = { Pm.DateDebut, Pm.DateFin };
        //    ClassRequette req = new ClassRequette();

        //    req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
           
        //}

        public void AjouterProjet(ProjetModel Pm)
        {
            string s = "  INSERT INTO tProject " +
                        " (CodeProject, DesignationProject, Lieu, ChefDuProjet, Etat, Compte,CompteClient, DateDebut, DateFin) " +
                        " VALUES(@a, @b, @c, @d, @e, @f,@g, @da, @db)";

            //ctreation de Compte caisse Secodaire
            Compte.CompteDataAccessLayer cptDal = new Compte.CompteDataAccessLayer();
            int Cpt = cptDal.AjouterCompteAuto("572", "Caisse " + Pm.DesignationProject) ;

            //ctreation de Compte caisse Client
            Compte.CompteDataAccessLayer cptDal2 = new Compte.CompteDataAccessLayer();
            int Cpt2 = cptDal2.AjouterCompteAuto("411", "Client " + Pm.DesignationProject);


            string[] r = { Pm.CodeProject, Pm.DesignationProject, Pm.Lieu, Pm.ChefDuProjet,
                Pm.Etat.ToString(), Cpt.ToString(),Cpt2.ToString() };

            DateTime[] d = { Pm.DateDebut, Pm.DateFin };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);

        }

        public Boolean ModifierProjet(ProjetModel Pm)
        {
            if(ExistProjet(Pm.CodeProject) > 0)
            {
                string s = "UPDATE tProject " +
                    "SET DesignationProject = @a, Lieu = @b, ChefDuProjet = @c, DateDebut = @da, DateFin = @db " +
                    "WHERE(CodeProject = @d)";

                string[] r = { Pm.DesignationProject, Pm.Lieu, Pm.ChefDuProjet, Pm.CodeProject };

                DateTime[] d = { Pm.DateDebut, Pm.DateFin };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;
            }
            else
            {
                return false;
            }
        }

        int ExistProjet(string codeProjet)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //  Conn.Open();
                    int projet_exist = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select count(*) from tProject where CodeProject = '"+codeProjet+"'";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    projet_exist = int.Parse(objCommand.ExecuteScalar().ToString());
                    return projet_exist;
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

        public int NombreDeProjet()
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();
                    int dernier_operation = 0;

                    string compteur = "select ISNULL(max(IdProject), 0) as DernierNombre from tProject";
                    //int objCust = 0;
                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    //SqlDataReader _Reader = objCommand.ExecuteReader();
                    //while(_Reader.Read())
                    //{
                    //    objCust = Convert.ToInt32(_Reader["DernierNombre"]);
                    //}

                    dernier_operation = int.Parse(objCommand.ExecuteScalar().ToString());

                    return dernier_operation;
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

        public IEnumerable<ProjetModel> ToutLeProjets()
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    string compteur = "select * from tProject";

                    List<ProjetModel> projetModels = new List<ProjetModel>();

                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();
                    while (_Reader.Read())
                    {
                        ProjetModel objCust = new ProjetModel();
                        objCust.IdProject = Convert.ToInt32(_Reader["IdProject"]);
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
                        objCust.DateDebut = Convert.ToDateTime(_Reader["DateDebut"]);
                        objCust.DateFin = Convert.ToDateTime(_Reader["DateFin"]);
                        objCust.ChefDuProjet = _Reader["ChefDuProjet"].ToString();
                        objCust.Compte = Convert.ToInt32(_Reader["Compte"]);
                        objCust.CompteClient = Convert.ToInt32(_Reader["CompteClient"]);
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Lieu = _Reader["Lieu"].ToString();
                        
                        projetModels.Add(objCust);
                    }

                    return projetModels;
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

        public List<ProjetModel> ToutLeProjetsEncours()
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    conn.Open();
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    string compteur = "SELECT IdProject, CodeProject, DesignationProject, DateDebut, " +
                        "DateFin, Lieu, ChefDuProjet, Etat, Compte,CompteClient FROM tProject WHERE(Etat = 0)";

                    List<ProjetModel> projetModels = new List<ProjetModel>();

                    SqlCommand objCommand = new SqlCommand(compteur, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();
                    while (_Reader.Read())
                    {
                        ProjetModel objCust = new ProjetModel();
                        objCust.IdProject = Convert.ToInt32(_Reader["IdProject"]);
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
                        objCust.DateDebut = Convert.ToDateTime(_Reader["DateDebut"]);
                        objCust.DateFin = Convert.ToDateTime(_Reader["DateFin"]);
                        objCust.ChefDuProjet = _Reader["ChefDuProjet"].ToString();
                        objCust.Compte = Convert.ToInt32(_Reader["Compte"]);
                        objCust.CompteClient = Convert.ToInt32(_Reader["CompteClient"]);
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Lieu = _Reader["Lieu"].ToString();

                        projetModels.Add(objCust);
                    }

                    return projetModels;
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



        public List<ConsommationProjetViewModel> ListeConsommationProjet()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<ConsommationProjetViewModel> _list = new List<ConsommationProjetViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "ConsommationPourPrjet";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    //objCommand.Parameters.AddWithValue("@a", NumCompte);
                    //objCommand.Parameters.AddWithValue("@da", date1);
                    //objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        ConsommationProjetViewModel objCust = new ConsommationProjetViewModel();
                        


                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
                        // objCust.Details = _Reader["Details"].ToString();
                        try { 
                            objCust.TotalConsommation = Convert.ToDouble(_Reader["TotalConsommation"]); 
                        } catch { objCust.TotalConsommation = 0; }

                        try {
                            objCust.TOtalPrevision = Convert.ToDouble(_Reader["TOtalPrevision"]);  
                        } catch { objCust.TOtalPrevision = 0; }
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

        public ConsommationProjetViewModel ModeleConsommationProjet( string CodeProjet)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                   // ConsommationProjetViewModel obj = new ConsommationProjetViewModel();
                   ConsommationProjetViewModel objCust = new ConsommationProjetViewModel();
                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "ConsommationPourUnprojet";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    //objCommand.Parameters.AddWithValue("@da", date1);
                    //objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        



                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
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
    }
}
