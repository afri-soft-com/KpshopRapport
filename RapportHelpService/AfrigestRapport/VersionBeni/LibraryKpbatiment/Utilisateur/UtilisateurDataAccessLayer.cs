using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LibraryKpbatiment.Utilisateur
{
    public class UtilisateurDataAccessLayer
    {

        public UtilisateurModel Login(string nomUtilisateur, string motDePasse)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    UtilisateurModel _list = new UtilisateurModel();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();

                    string s = "SELECT ISNULL(IdUtilisateur, '') as IdUtilisateur, " +
                        "ISNULL(NomUtilisateur, '') as NomUtilisateur," +
                        "ISNULL(MotPasseUtilisateur, '') as MotPasseUtilisateur, " +
                        "ISNULL(NiveauUtilisateur, '') as NiveauUtilisateur," +
                        "ISNULL(FonctionUt, '') as FonctionUt, " +
                        "ISNULL(ServiceAffe, '') as ServiceAffe, " +
                        "ISNULL(Compte, '') as Compte" +
                        " FROM tUtilisateur " +
                        " WHERE NomUtilisateur = @NomUtilisateur " +
                        " and MotPasseUtilisateur = @MotPasseUtilisateur";

                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    objCommand.Parameters.AddWithValue("@NomUtilisateur", nomUtilisateur);
                    objCommand.Parameters.AddWithValue("@MotPasseUtilisateur", motDePasse);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        UtilisateurModel objCust = new UtilisateurModel();
                        objCust.IdUtilisateur = Convert.ToInt32(_Reader["IdUtilisateur"]);
                        objCust.NomUtilisateur = _Reader["NomUtilisateur"].ToString();
                        objCust.MotPasseUtilisateur = _Reader["MotPasseUtilisateur"].ToString();
                        objCust.NiveauUtilisateur = _Reader["NiveauUtilisateur"].ToString();
                        objCust.FonctionUt = _Reader["FonctionUt"].ToString();
                        objCust.ServiceAffe = _Reader["ServiceAffe"].ToString();
                        objCust.Compte = Convert.ToInt32(_Reader["Compte"]);

                        _list = objCust;
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

        public int CreerUtililisateur(UtilisateurModel Obj)
        {
            try
            {
                // string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = " INSERT INTO tUtilisateur " +
                         " (NomUtilisateur, DesignationUt, MotPasseUtilisateur, FonctionUt) " +
" VALUES(@a, @b, @c, @d)";

                //Em.CodeEtatdeBesoin, change par dernier_EB

                string[] r = { Obj.NomUtilisateur, Obj.DesignationUt, Obj.MotPasseUtilisateur, Obj.FonctionUt };

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


        public int ModifierUtililisateur(UtilisateurModel Obj)
        {
            try
            {
                // string dernier_EB = DernierEtatBesoin() + "EB" + InitialNomUtilisateur;
                string s = " UPDATE       tUtilisateur " +
" SET                DesignationUt = @b, MotPasseUtilisateur = @c, FonctionUt = @d, ServiceAffe =@e, Compte =@f, CompteDeclaration =@g, Actif =@h " +
" WHERE(NomUtilisateur = @a)";

                //Em.CodeEtatdeBesoin, change par dernier_EB

                string[] r = { Obj.NomUtilisateur, Obj.DesignationUt, Obj.MotPasseUtilisateur, Obj.FonctionUt, Obj.ServiceAffe, Obj.Compte.ToString(), Obj.CompteDeclaration.ToString(), Obj.Actif.ToString() };

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

        public List<UtilisateurModel> listeUtilisateur()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    //Conn.Open();
                    List<UtilisateurModel> _list = new List<UtilisateurModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = " SELECT * " +
                " FROM tUtilisateur ";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    //objCommand.Parameters.AddWithValue("@a", GroupeCompte);
                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        UtilisateurModel objCust = new UtilisateurModel();
                        objCust.NomUtilisateur = _Reader["NomUtilisateur"].ToString();
                        objCust.DesignationUt = _Reader["DesignationUt"].ToString();
                        objCust.FonctionUt = _Reader["FonctionUt"].ToString();
                        objCust.MotPasseUtilisateur = _Reader["MotPasseUtilisateur"].ToString();
                        objCust.ServiceAffe = _Reader["ServiceAffe"].ToString();
                        //objCust.FonctionUt = _Reader["FonctionUt"].ToString();
                        //Obj.MotPasseUtilisateur
                        try { objCust.Actif = Convert.ToInt32(_Reader["Actif"].ToString()); } catch { objCust.Actif = 0; }
                        try { objCust.Compte = Convert.ToInt32(_Reader["Compte"].ToString()); } catch { objCust.Compte = 0; }
                        try { objCust.CompteDeclaration = Convert.ToInt32(_Reader["CompteDeclaration"].ToString()); } catch { objCust.CompteDeclaration = 0; }

                        // objCust.Solde = _Reader["Solde"].ToString();
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
