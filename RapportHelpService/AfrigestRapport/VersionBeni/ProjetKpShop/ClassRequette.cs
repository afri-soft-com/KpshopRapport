
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{



    ////  Public con As sqlConnection ' notre instance de la programation
    //Public da As New sqlDataAdapter ' permer la connexion avec la base de donnees
    //Public ds As DataSet ' la base de donnee en memoire
    //Public dt As DataTable
    //Public cmd As sqlCommand
    class ClassRequette
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public string message;
        public void chargementAvecLesParametre(string req, string connexion, string tb, string[] n)
        {
            string[] pn = { "@a", "@b", "@c", "@d", "@e", "@f", "@g", "@h", "@i", "@j", "@k", "@l", "@m", "@n", "@o", "@p", "@q", "@r", "@s", "@t" };
            string[] pd = { "@da", "@db", "@dc", "@dd", "@de", "@df", "@dg" };


            try
            {
                con = new SqlConnection();
                con.ConnectionString = connexion;
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandTimeout = 0;
                //  Cr�ation de la commande
                int i;
                cmd.CommandText = req;
                for (i = 0; (i
                            <= (n.Length - 1)); i++)
                {
                    cmd.Parameters.AddWithValue(pn[i], n[i]);
                    //cmd.Parameters.Add("",SqlDbType.VarChar, 50, "").Value = n[i];
                }

                ds = new DataSet();
                da = new SqlDataAdapter("gestc", con);
                da.SelectCommand = cmd;
                da.Fill(ds, tb);
                dt = new DataTable();
                dt = ds.Tables[tb];
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
            catch (Exception EXC)
            {
                message = EXC.ToString();
                // MessageBox.Show(EXC.Message)
            }

        }




        public void chargementAvecLesParametreDate(string req, string connexion, string tb, string[] n, DateTime[] d)
        {
            string[] pn = { "@a", "@b", "@c", "@d", "@e", "@f", "@g", "@h", "@i", "@j", "@k", "@l", "@m", "@n", "@o", "@p", "@q", "@r", "@s", "@t" };
            string[] pd = { "@da", "@db", "@dc", "@dd", "@de", "@df", "@dg" };


            try
            {
                con = new SqlConnection();
                con.ConnectionString = connexion;
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandTimeout = 0;
                //  Cr�ation de la commande
                int i;
                cmd.CommandText = req;
                
                for (i = 0; (i
                            <= (n.Length - 1)); i++)
                {
                    cmd.Parameters.AddWithValue(pn[i], n[i]);
                    //cmd.Parameters.Add("",SqlDbType.VarChar, 50, "").Value = n[i];
                }

                for (i = 0; (i <= (d.Length - 1)); i++)
                {

                    cmd.Parameters.AddWithValue(pd[i], d[i]);
                    //cmd.Parameters.Add(pd[i], SqlDbType.Date, 50, "").Value = d[i];
                }

                ds = new DataSet();
                da = new SqlDataAdapter("gestc", con);
                da.SelectCommand = cmd;
                da.Fill(ds, tb);
                dt = new DataTable();
                dt = ds.Tables[tb];
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
            catch (Exception EXC)
            {
                message = EXC.ToString();
                // MessageBox.Show(EXC.Message)
            }

        }



        public void chargementAvecLesParametreDateStorage(string req, string connexion, string tb, string[] n, DateTime[] d)
        {
            string[] pn = { "@a", "@b", "@c", "@d", "@e", "@f", "@g", "@h", "@i", "@j", "@k", "@l", "@m", "@n", "@o", "@p", "@q", "@r", "@s", "@t" };
            string[] pd = { "@da", "@db", "@dc", "@dd", "@de", "@df", "@dg" };


            try
            {
                con = new SqlConnection();
                con.ConnectionString = connexion;
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                //  Cr�ation de la commande
                cmd.CommandTimeout = 0;
                int i;
                cmd.CommandText = req;
                cmd.CommandType = CommandType.StoredProcedure;
                for (i = 0; (i
                            <= (n.Length - 1)); i++)
                {
                    cmd.Parameters.AddWithValue(pn[i], n[i]);
                    //cmd.Parameters.Add("",SqlDbType.VarChar, 50, "").Value = n[i];
                }

                for (i = 0; (i <= (d.Length - 1)); i++)
                {

                    cmd.Parameters.AddWithValue(pd[i], d[i]);
                    //cmd.Parameters.Add(pd[i], SqlDbType.Date, 50, "").Value = d[i];
                }

                ds = new DataSet();
                da = new SqlDataAdapter("gestc", con);
                da.SelectCommand = cmd;
                da.Fill(ds, tb);
                dt = new DataTable();
                dt = ds.Tables[tb];
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
            catch (Exception EXC)
            {
                message = EXC.ToString();
                MessageBox.Show(EXC.Message);
            }

        }
        public void ExecuterSqlAvecDate(string connection, string cdText, string[] n, DateTime[] d)
        {
            //string[] pn, string[] pd
            string[] pn = { "@a", "@b", "@c", "@d", "@e", "@f", "@g", "@h", "@i", "@j", "@k", "@l", "@m", "@n", "@o", "@p", "@q", "@r", "@s", "@t" };
            string[] pd = { "@da", "@db", "@dc", "@dd", "@de", "@df", "@dg" };

            con = new SqlConnection();
            con.ConnectionString = connection;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            //  Cr�ation de la commande
            int i;
            //MessageBox.Show(cdText);
            cmd.CommandText = cdText;

            for (i = 0; (i <= (n.Length - 1)); i++)
            {

                cmd.Parameters.AddWithValue(pn[i], n[i]);
                // cmd.Parameters.AddWithValue("@state", txt_State.Text); 
                //cmd.Parameters.Add( pn[i], SqlDbType.VarChar, 100, "").Value = n[i];
            }

            for (i = 0; (i <= (d.Length - 1)); i++)
            {

                cmd.Parameters.AddWithValue(pd[i], d[i]);
                //cmd.Parameters.Add(pd[i], SqlDbType.Date, 50, "").Value = d[i];
            }

            // 
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void ExecuterSqlSansDate(string connection, string cdText, string[] n)
        {
            //string[] pn, string[] pd
            string[] pn = { "@a", "@b", "@c", "@d", "@e", "@f", "@g", "@h", "@i", "@j", "@k", "@l", "@m", "@n", "@o", "@p", "@q", "@r", "@s", "@t" };
            string[] pd = { "@da", "@db", "@dc", "@dd", "@de", "@df", "@dg" };

            con = new SqlConnection();
            con.ConnectionString = connection;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            //  Cr�ation de la commande
            int i;
            cmd.CommandText = cdText;
            for (i = 0; (i <= (n.Length - 1)); i++)
            {

                cmd.Parameters.AddWithValue(pn[i], n[i]);
                // cmd.Parameters.AddWithValue("@state", txt_State.Text); 
                //cmd.Parameters.Add( pn[i], SqlDbType.VarChar, 100, "").Value = n[i];
            }

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public int DernierOP(string connection, string s)
        {

            int DernierNum;
            con = new SqlConnection();
            con.ConnectionString = connection;
            con.Open();
            cmd = new SqlCommand();
            //String s = "   SELECT MAX(tOperation.NumOpSource) AS DernierDeNumOpSource ";
            // s = s + " FROM tOperation; ";
            cmd.Connection = con;
            cmd.CommandText = s;
            DernierNum = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            con.Close();
            return DernierNum;

        }




    }




    // Public Sub chargemenentEnmemoireAvecLeParametre(ByVal req As String, ByVal connexion As String, ByVal tb As String, ByVal n() As String)
    //    Try
    //        con = New sqlConnection
    //        con.ConnectionString = connexion

    //        con.Open()
    //        cmd = New sqlCommand
    //        cmd.Connection = con
    //        ' Création de la commande
    //        Dim i As Integer
    //        cmd.CommandText = req
    //        For i = 0 To n.Length - 1
    //            cmd.Parameters.Add("", sqlType.VarChar, 50, "").Value = n(i)
    //        Next i
    //        ds = New DataSet
    //        da = New sqlDataAdapter("gestc", con)
    //        da.SelectCommand = cmd
    //        da.Fill(ds, tb)

    //        dt = New DataTable
    //        dt = ds.Tables(tb)
    //        cmd.Dispose()
    //        da.Dispose()
    //        con.Close()
    //    Catch EXC As Exception
    //        'MessageBox.Show(EXC.Message)
    //    End Try
    //End Sub





}

