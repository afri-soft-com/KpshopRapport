using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.Compte
{
    public class CompteDataAccessLayer
    {
        public List<CompteModel> ListeDeComptes()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<CompteModel> _list = new List<CompteModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT ISNULL(NumCompte, 0) as NumCompte, " +
                        "ISNULL(DesignationCompte, '') as DesignationCompte, " +
                        "ISNULL(GroupeCompte, 0) as GroupeCompte, " +
                        "ISNULL(Unite, 0) as Unite, " +
                        "ISNULL(Solde, '') as Solde  FROM tCompte";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        CompteModel objCust = new CompteModel();
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        objCust.GroupeCompte = Convert.ToInt32(_Reader["GroupeCompte"]);
                        objCust.Unite = Convert.ToInt32(_Reader["Unite"]);
                        objCust.Solde = _Reader["Solde"].ToString();
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




        public GrandLivreModel AfficherModeleGrandLivre(int Compte  , DateTime date1 , DateTime  date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    // ConsommationProjetViewModel obj = new ConsommationProjetViewModel();
                    GrandLivreModel objCust = new GrandLivreModel();
                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "RapportGrandLivre";

                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@a", Compte);
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {




                        objCust.NumCompte = Convert .ToInt32(_Reader["NumCompte"]);
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();
                        // objCust.Details = _Reader["Details"].ToString();
                        try { objCust.Debit = Convert.ToDouble(_Reader["Debit"]); } catch { objCust.Debit = 0; }
                        try { objCust.Credit = Convert.ToDouble(_Reader["Credit"]); } catch { objCust.Credit = 0; }
                        try { objCust.Solde = Convert.ToDouble(_Reader["Solde"]); } catch { objCust.Solde = 0; }
                        try { objCust.SoldeInitial = objCust.Solde - objCust.Debit + objCust.Credit; } catch { objCust.SoldeInitial = 0; }



                        

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


        public int DernierCompte(string GroupeCompte)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //  Conn.Open();
                    int dernier_operation = 0;

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    string s = "SELECT        MAX(NumCompte) AS MaxCompte FROM            tCompte " +
" GROUP BY GroupeCompte HAVING(GroupeCompte = @a)";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    objCommand.CommandType = CommandType.Text;
                    objCommand.Parameters.AddWithValue("@a", GroupeCompte);
                   //objCommand.Parameters.AddWithValue("@da", date1);
                    //objCommand.Parameters.AddWithValue("@db", date2);

                    //SqlDataReader _Reader = objCommand.ExecuteReader();

                    //while (_Reader.Read())
                    //{
                    //    dernier_operation = Convert.ToInt32(_Reader[""].ToString());
                    //}
                    dernier_operation = int.Parse(objCommand.ExecuteScalar().ToString());
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


        public int AjouterCompte( CompteModel Obj)
        {
            try
            {
               // string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = "  INSERT INTO tCompte " +
                        "  (NumCompte, DesignationCompte, GroupeCompte) " +
" VALUES(@a, @b, @c)";

                //Em.CodeEtatdeBesoin, change par dernier_EB

                string[] r = { Obj.NumCompte.ToString(),Obj.DesignationCompte, Obj.GroupeCompte.ToString()  };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                //EtatBesoinModel etat = new EtatBesoinModel();
                //etat.CodeEtatdeBesoin = dernier_EB;
                //etat.DesignationEtatDeBesion = Em.DesignationEtatDeBesion;
                
                return 1;
            }
            catch
            {
                return 0;
                throw;
            }

        }

        public int ModifierUnCompte(CompteModel Obj)
        {
            try
            {
                // string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = "  UPDATE       tCompte " +
" SET DesignationCompte = @b, GroupeCompte = @c " +
" WHERE(NumCompte = @a)";

                //Em.CodeEtatdeBesoin, change par dernier_EB

                string[] r = { Obj.NumCompte.ToString(), Obj.DesignationCompte, Obj.GroupeCompte.ToString() };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                //EtatBesoinModel etat = new EtatBesoinModel();
                //etat.CodeEtatdeBesoin = dernier_EB;
                //etat.DesignationEtatDeBesion = Em.DesignationEtatDeBesion;

                return 1;
            }
            catch
            {
                return 0;
                throw;
            }

        }

        public  int AjouterCompteAuto(string GroupeCompte , string DesignationCompte)
        {
            try
            {
                // string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = "  INSERT INTO tCompte " +
                        "  (NumCompte, DesignationCompte, GroupeCompte) " +
" VALUES(@a, @b, @c)";

                int Compte;
                 // string  DesignationCpte;
                Compte = DernierCompte(GroupeCompte);

                string[] r = { Compte.ToString(), DesignationCompte, GroupeCompte };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();

                req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
                //EtatBesoinModel etat = new EtatBesoinModel();
                //etat.CodeEtatdeBesoin = dernier_EB;
                //etat.DesignationEtatDeBesion = Em.DesignationEtatDeBesion;

                return Compte;
            }
            catch
            {
                return 0;
                throw;
            }

        }

    }
}
