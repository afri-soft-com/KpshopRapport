using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryCtcBD.VenteBILLET
{
    public class BilleDataAccessLayer
    {

        //public void AjouterBillet(BilletModels Bm)
        //{
            


        //    string s = "   INSERT INTO tBillet  " +
        //                " ( IdCompagnie,Nom, PostNom, Telephone, Provenance, Destination, Piece, NombreEnfant," +
        //                " DatedeVoyage, DateOP) " +
        //                    " VALUES (@a, @b, @c, @d, @e, @f, @g,@h, @da, @db)";



        //    //string[] r = { Bm.IdCompagnie.ToString(), Bm.Nom, Bm.PostNom, Bm.Telephone, Bm.Provenance, Bm.Destination, Bm.Piece, Bm.NombreEnfant.ToString() };
        //    string[] r = { Bm.IdCompagnie.ToString(), Bm.Nom, Bm.PostNom, Bm.Telephone,"1","2", "ok", Bm.NombreEnfant.ToString() };



        //   // DateTime[] d = { Bm.DatedeVoyage, Bm.DateOP };
        //    DateTime[] d = { DateTime.Now, DateTime.Now };
        //    ClassRequette req = new ClassRequette();



        //    req.ExecuterSqlAvecDate(ClassVariableGlobal.seteconnexion(), s, r, d); ;


        //}

        //public IEnumerable<BilletModels> GetLesbillets()
        //{
        //    List<BilletModels> listebillet = new List<BilletModels>();
        //    using (SqlConnection con = new SqlConnection(ClassVariableGlobal.seteconnexion()))
        //    {
        //        //string s = "select * from  tBillet";

        //        string billetRequette = "SELECT        tLieu.DisignationLieu AS Provenance, tBillet.IdBillet," +
        //            " tBillet.Nom, tBillet.PostNom, tBillet.Telephone, tLieu_1.DisignationLieu AS Destination," +
        //            " tCompagnie.DesignationCompanie, tBillet.Piece, tBillet.NombreEnfant, "+ 
        //                " tBillet.DatedeVoyage, tBillet.DateOP "+
        //                    " FROM            tBillet INNER JOIN "+
        //                " tCompagnie ON tBillet.IdCompagnie = tCompagnie.IdCompagnie" +
        //                " LEFT OUTER JOIN tLieu AS tLieu_1 ON tBillet.idDestination = tLieu_1.IdLieu LEFT OUTER JOIN "+
        //                " tLieu ON tBillet.idProvenance = tLieu.IdLieu ";


        //        // SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
        //        SqlCommand cmd = new SqlCommand(billetRequette, con);
        //        cmd.CommandType = CommandType.Text;
        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            BilletModels bm = new BilletModels();

        //            bm.IdBillet = Convert.ToInt32(rdr["IdBillet"]);
        //            bm.DesignationCompanie = rdr["DesignationCompanie"].ToString();
        //            bm.Nom = (rdr["Nom"]).ToString();
        //            bm.PostNom = rdr["PostNom"].ToString();
        //            bm.Telephone = rdr["Telephone"].ToString();
        //            bm.IdProvenance = rdr["Provenance"].ToString();
        //            bm.IdDestination = rdr["Destination"].ToString();
        //            bm.Piece = rdr["Piece"].ToString();
        //            bm.NombreEnfant = rdr["NombreEnfant"].ToString();
        //            bm.DatedeVoyage = Convert.ToDateTime(rdr["DatedeVoyage"]);
        //            bm.DateOP = Convert.ToDateTime(rdr["DateOP"]);

        //            listebillet.Add(bm);
        //        }
        //        con.Close();
        //    }
        //    return listebillet;
        //}

        //public IEnumerable<BilletModels> GetLesbillets()
        //{
        //    List<BilletModels> listebillet = new List<BilletModels>();
        //    using (SqlConnection con = new SqlConnection(ClassVariableGlobal.seteconnexion()))
        //    {
        //        con.Open();

        //        if (con.State != System.Data.ConnectionState.Open)
        //            con.Open();

        //        string billetRequette = "SELECT        tBillet.IdBillet as IdBillet, tBillet.Nom as Nom, tBillet.PostNom as PostNom," +
        //            " tBillet.Telephone as Telephone, tBillet.Provenance as Provenance, tBillet.Destination as Destination, " +
        //            "tBillet.Piece as Piece, tBillet.NombreEnfant as NombreEnfant, tBillet.DatedeVoyage as DatedeVoyage," +
        //            " tBillet.DateOP as DateOP, tCompagnie.IdCompagnie AS IdCompagnie " +
        //        "FROM tBillet INNER JOIN " +
        //                " tCompagnie ON tBillet.IdCompagnie = tCompagnie.IdCompagnie";

        //        SqlCommand cmd = new SqlCommand(billetRequette, con);
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            BilletModels bm = new BilletModels();

        //            bm.IdBillet = Convert.ToInt32(rdr["IdBillet"]);
        //            bm.IdCompagnie = Convert.ToInt32(rdr["IdCompagnie"]);
        //            bm.Nom = (rdr["Nom"]).ToString();
        //            bm.PostNom = rdr["PostNom"].ToString();
        //            bm.Telephone = rdr["Telephone"].ToString();
        //            bm.Provenance = rdr["Provenance"].ToString();
        //            bm.Destination = rdr["Destination"].ToString();
        //            bm.Piece = rdr["Piece"].ToString();
        //            bm.NombreEnfant = rdr["NombreEnfant"].ToString();
        //            bm.DatedeVoyage = Convert.ToDateTime(rdr["DatedeVoyage"]);
        //            bm.DateOP = Convert.ToDateTime(rdr["DateOP"]);

        //            listebillet.Add(bm);
        //        }
        //        con.Close();
        //    }
        //    return listebillet;
        //}


        //public string GetBilletDERNIER()
        //{
        //    BilletModels bm = new BilletModels();
        //    int IdBillet =0;
        //    String MaxIdBillet;
        //    using (SqlConnection con = new SqlConnection(ClassVariableGlobal.seteconnexion()))
        //    {
        //        string s = "select MAX(IdBillet)  MaxId from  tBillet  ";
        //        SqlCommand cmd = new SqlCommand(s, con);
        //        cmd.CommandType = CommandType.Text;

        //       // cmd.Parameters.AddWithValue("@a", IdBillet);
        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        while (rdr.Read())

        //        {
        //            IdBillet = Convert.ToInt16( (rdr["MaxId"]).ToString());
        //            MaxIdBillet = IdBillet.ToString();
        //            //bm.Nom = (rdr["Nom"]).ToString();
        //            //bm.PostNom = rdr["PostNom"].ToString();
        //            //bm.Telephone = rdr["Telephone"].ToString();
        //            //bm.Provenance = rdr["Provenance"].ToString();
        //            //bm.Destination = rdr["Destination"].ToString();
        //            //bm.Piece = rdr["Piece"].ToString();
        //            //bm.NombreEnfant = rdr["NombreEnfant"].ToString();
        //            //bm.DatedeVoyage = Convert.ToDateTime(rdr["DatedeVoyage"]);
        //            //bm.DateOP = Convert.ToDateTime(rdr["DateOP"]);
        //        }
        //        MaxIdBillet = IdBillet.ToString();
        //    }
        //    return MaxIdBillet ;
        //}

    }
}
