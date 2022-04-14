using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryKpbatiment.Operations
{
    public class OperationDataAccessLayer
    {
        public void AjouterOperation(OperationModel Op)
        {
            string s = " INSERT INTO tOperation" +
                " (NumOperation, Libelle, NomUt, DateOp, DateSysteme) " +
                " VALUES(@a, @b, @c, @da, @db)";

            string[] r = { Op.NumOperation, Op.Libelle, Op.CodeEtatdeBesoin, Op.NomUt };

            DateTime[] d = { Op.DateOp, Op.DateSysteme };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
        }

        public OperationModel EnregistrerOperationAuto(OperationModel tbl)
        {
            using (SqlConnection con = new SqlConnection(ClassVariableGlobal.seteconnexion()))
            {


                OperationModel objectResult = new OperationModel();
                con.Open();

                string query = "INSERT INTO tOperation(NumOperation,Libelle,DateOp,NomUt,DateSysteme) VALUES (@NumOperation,@Libelle,@DateOp,@NomUt,@DateSysteme)";

                SqlCommand cmd = new SqlCommand(query, con);
              // tbl.NumOperation = "OP" + DernierOperation() + (tbl.NomUt.Substring(0, 2).ToUpper());
                cmd.Parameters.AddWithValue("@NumOperation", tbl.NumOperation);
               // cmd.Parameters.AddWithValue("@b", tbl.CodeEleve);
                //cmd.Parameters.AddWithValue("@c", tbl.CodeLibele);
                cmd.Parameters.AddWithValue("@Libelle", tbl.Libelle);
                cmd.Parameters.AddWithValue("@DateOp", tbl.DateOp);
                cmd.Parameters.AddWithValue("@NomUt", tbl.NomUt);
               // cmd.Parameters.AddWithValue("@g", tbl.CodeAnnee);
                cmd.Parameters.AddWithValue("@DateSysteme", tbl.DateSysteme);


                int result = cmd.ExecuteNonQuery();


                if (result == 1)
                {
                    objectResult.DateOp = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    objectResult.Libelle = tbl.Libelle;
                    // objectResult.status_result = Convert.ToString(reference);
                    objectResult.status_result = result;
                    objectResult.NumOperation = tbl.NumOperation;
                    // objectResult.status_response = "Insertion réussie avec succès";
                }
                else
                {
                    objectResult.DateOp = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    objectResult.Libelle = "";
                    //   objectResult.Reference = "";
                    objectResult.status_result = result;
                    // objectResult.NumOperation = reference;
                    //objectResult.status_response = "Echec Insertion";
                }
                return objectResult;

            }
        }


        public void SupprimmeerOperation(string  Op)
        {
            string s = " delete FROM tOperation " +
                " WHERE NumOperation=@a  ";
              
            
            string[] r = { Op };


            DateTime[] d = {  DateTime.Now };
            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d);
        }

        public int DernierOperation()
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();
                    int dernier_operation = 0;
                    string s = "select ISNULL(max(NumOpSource), 0) as NumOpSource from tOperation";
                    SqlCommand objCommand = new SqlCommand(s, Conn);
                    //SqlDataReader _Reader = objCommand.ExecuteReader();

                    //while (_Reader.Read())
                    //{
                    //            dernier_operation = Convert.ToInt32(_Reader["dernierOperation"]);
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



        public List<DetailOperationModel> DetailleDuneOperation(string NumeOP)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<DetailOperationModel> _list = new List<DetailOperationModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT        tCompte.NumCompte, tCompte.DesignationCompte, tOperation.NumOperation,  tMvtCompte.Entree, tMvtCompte.Sortie, tCompte.Solde " +
" FROM tMvtCompte INNER JOIN " +
                        " tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation INNER JOIN " +
                        " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte " +
" WHERE(tOperation.NumOperation = @a)";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.Text;
                    objCommand.Parameters.AddWithValue("@a", NumeOP);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        DetailOperationModel objCust = new DetailOperationModel();
                        objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                         objCust.NumOperation = _Reader["NumOperation"].ToString();
                        objCust.DesignationCompte = _Reader["DesignationCompte"].ToString();


                        objCust.Debit = Convert.ToDouble(_Reader["Entree"]);
                        objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);


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



        public List<OperationModel>lilsteDesoperationdeStock(DateTime date1 , DateTime date2)
        {
            using (SqlConnection Conn = new SqlConnection(ClassVariableGlobal.seteconnexion()))

                try
                {
                    Conn.Open();
                    List<OperationModel> _list = new List<OperationModel>();

                    if (Conn.State != System.Data.ConnectionState.Open)
                        Conn.Open();


                    String s1 = "SELECT        tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp " +
" FROM tOperation INNER JOIN " +
" tMvtStock ON tOperation.NumOperation = tMvtStock.NumOperation  " +
" GROUP BY tOperation.NumOperation, tOperation.Libelle, tOperation.NomUt, tOperation.DateOp "+
" HAVING(tOperation.DateOp BETWEEN @da AND @db)";


                    SqlCommand objCommand = new SqlCommand(s1, Conn);
                    objCommand.CommandType = CommandType.Text;
                    objCommand.Parameters.AddWithValue("@da", date1);
                    objCommand.Parameters.AddWithValue("@db", date2);

                    SqlDataReader _Reader = objCommand.ExecuteReader();

                    while (_Reader.Read())
                    {
                        OperationModel objCust = new OperationModel();
                      //  objCust.NumCompte = Convert.ToInt32(_Reader["NumCompte"]);

                        objCust.NumOperation = _Reader["NumOperation"].ToString();
                        objCust.Libelle = _Reader["Libelle"].ToString();


                        try { objCust.DateOp = Convert.ToDateTime(_Reader["DateOp"]); } catch { objCust.DateOp = DateTime.Now; };
                      //  objCust.Credit = Convert.ToDouble(_Reader["Sortie"]);


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
