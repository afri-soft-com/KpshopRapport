using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.EtatDeBesoin
{
   public class EtatDeBesoinDataAccessLayer
    {


        public EtatBesoinModel AjouterEtatDeBesoin(EtatBesoinModel Em, string InitialNomUtilisateur)
        {
            try
            {
                string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = "  INSERT INTO tEtatDeBesoin" +
                    "(CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, CodeLigne, Etat, Demandeur, ValiderPar," +
                    " DateEmision, DateRequise, DateValidation)" +
                    "VALUES(@a, @b, @c, @d, @e, @f, @g, @da, @db, @dc)";

                //Em.CodeEtatdeBesoin, change par dernier_EB

                string[] r = { dernier_EB, Em.DesignationEtatDeBesion, Em.CodeProject, Em.CodeLigne, Em.Etat.ToString(),
                Em.Demandeur, Em.ValiderPar };

                DateTime[] d = { Em.DateEmision, Em.DateRequise, Em.DateValidation };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                EtatBesoinModel etat = new EtatBesoinModel();
                etat.CodeEtatdeBesoin = dernier_EB;
                etat.DesignationEtatDeBesion = Em.DesignationEtatDeBesion;
                etat.CodeProject = Em.CodeProject;
                etat.CodeLigne = Em.CodeLigne;
                etat.Etat = Em.Etat;
                etat.Demandeur = Em.Demandeur;
                etat.ValiderPar = Em.ValiderPar;
                return etat;
            }
            catch
            {
                throw;
            }

        }

        public void ModifierEtatBesoin(EtatBesoinModel Em, string CodeEtatdeBesoin)
        {
            if (Em.Etat==1)
            {
                string s = " UPDATE tEtatDeBesoin " +
                "SET Etat = @a, ValiderPar = @b," +
                " DateValidation = @da WHERE CodeEtatdeBesoin = '" + CodeEtatdeBesoin + "'";
                string[] r = { Em.Etat.ToString(), Em.ValiderPar };
                DateTime[] d = {Em.DateValidation};
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
            }
            else if(Em.Etat==2)
            {
                string s = " UPDATE tEtatDeBesoin " +
                " SET Etat = @a, DateValidation = @da WHERE CodeEtatdeBesoin = '" + CodeEtatdeBesoin+"'";
                string[] r = { Em.Etat.ToString()};
                DateTime[] d = {Em.DateValidation };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
            }
        }


        public Boolean EffacerEtatdeEbesoin( string CodeEtatEbesoin)
        {
           
            try
            {

                string s = "DELETE FROM tEtatDeBesoin WHERE(CodeEtatdeBesoin = @a)";

                string[] r = { CodeEtatEbesoin };

                DateTime[] d = { };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                return true;

            }

            catch ( Exception ex)
            {
                return false;

            }
            
                
           
        }
        public List<EtatBesoinModel> ListeEtatDeBesoin()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<EtatBesoinModel> _list = new List<EtatBesoinModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "SELECT ISNULL(tEtatDeBesoin.IdEtatDuBesoin, 0) as IdEtatDuBesoin," +
                        "ISNULL(tEtatDeBesoin.CodeEtatdeBesoin, '') as CodeEtatdeBesoin," +
                        "ISNULL(tEtatDeBesoin.DesignationEtatDeBesion, '') as DesignationEtatDeBesion," +
                        "ISNULL(tEtatDeBesoin.CodeProject, '') as CodeProject," +
                        "ISNULL(tEtatDeBesoin.CodeLigne, '') as CodeLigne," +
                        "ISNULL(tEtatDeBesoin.Etat, 0) as Etat," +
                        "ISNULL(tEtatDeBesoin.Demandeur, '') as Demandeur," +
                        "ISNULL(tEtatDeBesoin.DateEmision, '') as DateEmision," +
                        "ISNULL(tEtatDeBesoin.DateRequise, '') as DateRequise," +
                        "ISNULL(tEtatDeBesoin.DateValidation, '') as DateValidation," +
                        "ISNULL(tEtatDeBesoin.ValiderPar, '') as ValiderPar," +
                        "tProject.Etat AS Expr1 FROM tEtatDeBesoin INNER JOIN" +
                        " tProject ON tEtatDeBesoin.CodeProject = tProject.CodeProject " +
                        "WHERE(tProject.Etat = 0) and tEtatDeBesoin.Etat = 0";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatBesoinModel objCust = new EtatBesoinModel();
                        objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Demandeur = _Reader["Demandeur"].ToString();
                        objCust.ValiderPar = _Reader["ValiderPar"].ToString();
                        objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]);
                        objCust.DateValidation = Convert.ToDateTime(_Reader["DateValidation"]);
                        objCust.ValiderPar = _Reader["ValiderPar"].ToString();
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

        public int DernierEtatBesoin()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    int dernier_etatBesoin = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "select ISNULL(max(IdEtatDuBesoin), 0) as dernierEtatDeBesoin from tEtatDeBesoin";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    dernier_etatBesoin = int.Parse(objCommand.ExecuteScalar().ToString()) + 1;

                    return dernier_etatBesoin;
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

        public List<EtatBesoinModel> EtatDeBesoinValider() // string codeEtatDeBesoin
        {
            using(SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))
                try
                {
                    conn.Open();
                    List<EtatBesoinModel> etatBesoinModel = new List<EtatBesoinModel>();

                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    String query = "SELECT  IdEtatDuBesoin, CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, CodeLigne, " +
                        "Etat, Demandeur, DateEmision, DateRequise, DateValidation, ValiderPar " +
                        "FROM tEtatDeBesoin " +
                        "WHERE (ValiderPar != '') AND(Etat = 1)"; // and CodeEtatdeBesoin = '"+ codeEtatDeBesoin + 

                    SqlCommand objCommand = new SqlCommand(query, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatBesoinModel objCust = new EtatBesoinModel();
                        objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Demandeur = _Reader["Demandeur"].ToString();
                        objCust.ValiderPar = _Reader["ValiderPar"].ToString();
                        objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]);
                        objCust.DateValidation = Convert.ToDateTime(_Reader["DateValidation"]);
                        etatBesoinModel.Add(objCust);
                    }

                    return etatBesoinModel;

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

        public List<EtatBesoinModel> EtatDeBesoinValiderParProjet(string codeProjet) // string codeEtatDeBesoin
        {
            using (SqlConnection conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))
                try
                {
                    conn.Open();
                    List<EtatBesoinModel> etatBesoinModel = new List<EtatBesoinModel>();

                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    String query = "SELECT  IdEtatDuBesoin, CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, CodeLigne, " +
                        "Etat, Demandeur, DateEmision, DateRequise, DateValidation, ValiderPar " +
                        "FROM tEtatDeBesoin " +
                        "WHERE (ValiderPar != '') AND(Etat = 1) and CodeProject = '" + codeProjet + "'"; // and CodeEtatdeBesoin = '"+ codeEtatDeBesoin + 

                    SqlCommand objCommand = new SqlCommand(query, conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatBesoinModel objCust = new EtatBesoinModel();
                        objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Demandeur = _Reader["Demandeur"].ToString();
                        objCust.ValiderPar = _Reader["ValiderPar"].ToString();
                        objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]);
                        objCust.DateValidation = Convert.ToDateTime(_Reader["DateValidation"]);
                        etatBesoinModel.Add(objCust);
                    }

                    return etatBesoinModel;

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




        public IEnumerable<EtatBesoinModel> ListeEtatDeBesoinParProjet( string CodeProject , int Etat)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<EtatBesoinModel> _list = new List<EtatBesoinModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "SELECT CodeEtatdeBesoin, DesignationEtatDeBesion, SUM(Total) AS Total, CodeProject," +
                        "DesignationProject, Etat,CodeLigne " +
" FROM            View_KpDetailleEB " +
" GROUP BY CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, DesignationProject, Etat,CodeLigne " +
" HAVING        (Etat = @b) AND (CodeProject = @a) ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", CodeProject);
                    objCommand.Parameters.AddWithValue("@b", Etat);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatBesoinModel objCust = new EtatBesoinModel();
                       // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.Etat = Convert.ToInt32(_Reader["Etat"]);
                        objCust.Total = Convert.ToDouble(_Reader["Total"]);
                        // objCust.Demandeur = _Reader["Demandeur"].ToString();
                        // objCust.ValiderPar = _Reader["ValiderPar"].ToString();
                        // objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]);
                        //objCust.DateValidation = Convert.ToDateTime(_Reader["DateValidation"]);
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




        public IEnumerable<EtatdeBesoinViewModel>ListeAficheleTotalEBParLigne(string Codeligne)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<EtatdeBesoinViewModel> _list = new List<EtatdeBesoinViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "SELECT  tLigne.DesignationLIgne, tLigne.CodeLigne, " +
                        "SUM(View_KpDetailleEB.Total) AS TotalConsommation, View_KpDetailleEB.CodeEtatdeBesoin, " +
                        "View_KpDetailleEB.DesignationEtatDeBesion " +
" FROM tProject INNER JOIN " +
                        "  tLigne ON tProject.CodeProject = tLigne.CodeProject LEFT OUTER JOIN " +
                        "  View_KpDetailleEB ON tLigne.CodeLigne = View_KpDetailleEB.CodeLigne " +
" GROUP BY tLigne.DesignationLIgne, tLigne.CodeLigne, View_KpDetailleEB.CodeEtatdeBesoin, View_KpDetailleEB.DesignationEtatDeBesion " +
" HAVING(tLigne.CodeLigne = @a) ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.Parameters.AddWithValue("@a", Codeligne);
                  
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatdeBesoinViewModel objCust = new EtatdeBesoinViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                       
                        objCust.Total = Convert.ToDouble(_Reader["TotalConsommation"]);
                        
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


        public List<EtatdeBesoinViewModel> ListeDesEtabesionValideEtDecaisse(string CodeProjet,int Etat)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<EtatdeBesoinViewModel> _list = new List<EtatdeBesoinViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = "RapportdesEbsSommeValideEtDecaisse";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", CodeProjet);
                    objCommand.Parameters.AddWithValue("@b", Etat);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        EtatdeBesoinViewModel objCust = new EtatdeBesoinViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        try { objCust.Total = Convert.ToDouble(_Reader["SommeValide"]);  } catch { objCust.Total = 0; }
                        try { objCust.SommeDecaisse = Convert.ToDouble(_Reader["SommeDecaisse"]);  } catch { objCust.SommeDecaisse = 0; }
                        try { objCust.DateEmision = Convert.ToDateTime(_Reader["DateEmision"]); } catch { objCust.DateEmision = DateTime.Now; }



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



        public Double VerificationSoldeEB( string  CodeEtaDeBesion , string Compte)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    Double SoldeEb = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "SELECT        SUM(tMvtCompte.Sortie) AS Solde " +
" FROM tOperation INNER JOIN " +
                         " tMvtCompte ON tOperation.NumOperation = tMvtCompte.NumOperation " +
" GROUP BY tMvtCompte.NumCompte, tOperation.CodeEtatdeBesoin " +
" HAVING(tOperation.CodeEtatdeBesoin = @a) AND(tMvtCompte.NumCompte = @b) ";

                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    objCommand.Parameters.AddWithValue("@a", CodeEtaDeBesion);

                    objCommand.Parameters.AddWithValue("@b", Compte);

                    SoldeEb = Double.Parse(objCommand.ExecuteScalar().ToString()) ;

                    return SoldeEb;
                }
                catch
                {
                    return 0;
                    // throw;
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



        public List<EtatdeBesoinParPeriodeViewModel> listeEtaBesoinParPERIODE(DateTime date1, DateTime date2 )
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<EtatdeBesoinParPeriodeViewModel> _list = new List<EtatdeBesoinParPeriodeViewModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s1 = " SELECT        tProject.CodeProject, tProject.DesignationProject, tEtatDeBesoin.CodeEtatdeBesoin, tEtatDeBesoin.DesignationEtatDeBesion, tLigne.CodeLigne, tLigne.DesignationLIgne, tEtatDeBesoin.Etat, tEtatDeBesoin.DateEmision,  "+
                         " tDesingationEtat.DesignationEtat " +
" FROM            tEtatDeBesoin INNER JOIN "+
                         "tLigne ON tEtatDeBesoin.CodeLigne = tLigne.CodeLigne INNER JOIN " +
                         " tProject ON tEtatDeBesoin.CodeProject = tProject.CodeProject INNER JOIN " +
                        "  tDesingationEtat ON tEtatDeBesoin.Etat = tDesingationEtat.Etat " +
" WHERE(tEtatDeBesoin.DateEmision BETWEEN @da AND @db) ORDER BY IdEtatDuBesoin DESC ";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    //objCommand.Parameters.AddWithValue("@a", Etat);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                       EtatdeBesoinParPeriodeViewModel objCust = new EtatdeBesoinParPeriodeViewModel();
                        // objCust.IdEtatDuBesoin = Convert.ToInt32(_Reader["IdEtatDuBesoin"]);
                        objCust.CodeEtatdeBesoin = _Reader["CodeEtatdeBesoin"].ToString();
                        objCust.DesignationEtatDeBesion = _Reader["DesignationEtatDeBesion"].ToString();
                        objCust.CodeLigne = _Reader["CodeLigne"].ToString();
                        objCust.DesignationLIgne = _Reader["DesignationLIgne"].ToString();
                        objCust.CodeProject = _Reader["CodeProject"].ToString();
                        objCust.DesignationProject = _Reader["DesignationProject"].ToString();
                        objCust.DesignationEtat = _Reader["DesignationEtat"].ToString();

                        //objCust.Total = Convert.ToDouble(_Reader["TotalConsommation"]);

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
