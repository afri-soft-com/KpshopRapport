using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApplication1;

namespace GoldenStarApplication.LesClasses
{
    class ClasseRequetteDernier
    {

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public string fonctionDernierEntre( String requette)
        {

          try
            {
                float dernier;
                con = new SqlConnection();
                con.ConnectionString = ClassVaribleGolbal.seteconnexion;
                con.Open();
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = requette;

                dernier = float.Parse(cmd.ExecuteScalar().ToString()) + 1;

                return dernier.ToString();
            }
            catch ( Exception ex)
            {
                return "OT";
            }

            


           

        }

        public string fonctionOPSotie( string utilisateur)
        {

            string numOperation;
            float dernier;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            string s = "SELECT        MAX(NumOpSource) AS DernierOp FROM            tOperation";
            cmd.Connection = con;
            cmd.CommandText = s;
            //cmd.Parameters.AddWithValue("@a", type);
            // cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            dernier = float.Parse(cmd.ExecuteScalar().ToString()) + 1;
            numOperation = "ST" + dernier.ToString() + utilisateur.Substring(0, 2).ToUpper();
            return numOperation;


            cmd.Dispose();
            con.Close();

        }

    }
}
