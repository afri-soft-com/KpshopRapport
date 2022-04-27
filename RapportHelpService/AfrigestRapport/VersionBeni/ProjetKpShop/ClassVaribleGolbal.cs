using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    public static class ClassVaribleGolbal
    {
        //Data Source=DISTRIBUTION;Initial Catalog=BaseGestionBrasimba;User ID=MANDAL
        //private   SqlConnection con;
        // public static string seteconnexion = "Data Source=192.168.0.10;Initial Catalog=BaseHotel;Integrated Security=True";
        //public static string seteconnexion = "Data Source=DISTRIBUTION;Initial Catalog=BaseGestionBrasimba;Integrated Security=false ;User ID=MANDAL; Password =12345678";
        //Data Source=DESKTOP-JC195SC;Initial Catalog=BaseHopital;User ID=LABRECHE
       // public static string seteconnexion = "Data Source=127.0.0.1;Initial Catalog=BaseKpShop2;Integrated Security=True";

        public static String NomServeur;
         //public static string seteconnexion = "Data Source=SERVER-KP-SHOP;Initial Catalog=KPSHOP_DB2021;Integrated Security=false ;User ID=KP-SHOP; Password ='123456789'";

         //public static string seteconnexion = @"Data Source=SQL5061.site4now.net;Initial Catalog=db_a6d169_kpshopdb;User Id=db_a6d169_kpshopdb_admin;Password =12345678GL";
          //public static string seteconnexion = @"Data Source=127.0.0.1;Initial Catalog=BaseKpBunia;Integrated Security=false ;User ID=MANDAL; Password =12345678";
          
        // POUR YANNICK
        public static string seteconnexion = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_BENI;Integrated Security=false ;User ID=Yan; Password ='123456789'";
        //public static string seteconnexion = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_DB;Integrated Security=false ;User ID=Yan; Password ='123456789'";
        //public static string seteconnexion = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_BASE_DONNEE;Integrated Security=false ;User ID=Yan; Password ='123456789'";
          
        // POUR HELP
        //public static string seteconnexion = @"Data Source=SERVEU-HELP\SERVEUHELP;Initial Catalog=HELP_DB;Integrated Security=false ;User ID=HELP2; Password ='123456789'";

        // seteconnexionLoc = @"Data Source=127.0.0.1;Initial Catalog=BaseKpBunia;Integrated Security=false ;User ID=MANDAL; Password =12345678";

        //"Data Source=SQL5061.site4now.net;Initial Catalog=db_a6d169_kpshopdb;User Id=db_a6d169_kpshopdb_admin;Password =12345678GL"
        // public static string seteconnexion = "Data Source=127.0.0.1 ; Initial Catalog=BaseKpShop3;Integrated Security=false ;User ID=MANDAL; Password =12345678";
        //   public static string seteconnexion = "Data Source=127.0.0.1 ; Initial Catalog=BaseHotelIshango;Integrated Security=false ;User ID=MANDAL; Password =12345678";

        //Data Source=SQL5061.site4now.net;Initial Catalog=db_a6d169_kpshopdb;User Id=db_a6d169_kpshopdb_admin;Password =12345678GL
        //  public static string seteconnexion = "Data Source=SQL5092.site4now.net;Initial Catalog=DB_A54EFD_kpShop;User Id=DB_A54EFD_kpShop_admin;Password=12345678GL";

        //
       // public static string seteconnexion = "Data Source=KP-SHOP-SERVER;Initial Catalog=BaseKpShop;Integrated Security=false ;User ID=MANDAL; Password =12345678";

        // public static string seteconnexion = "Data Source=PC-SERVEURKP;Initial Catalog=BaseKp;Integrated Security=false ;User ID=kp; Password =12345678";

        public static string CodeEntreprise = "ECOL";
        public static string CodeDepotCentral = "CD1";
        public static String OPinit = "INITIAL";
        public static String GroupeService = "706";
        public static String CompteRemise = "701901";
        //public static String GroupeLogement = "7061";
       // public static String CompteLogement = "70602";
       // public static String CompteClientChambre = "41101";
        public static String CaisseReception = "571002";
       // public static String CompteclientOccasionne = "41101";
        public static String UTILISATEUR = "INITIAL";
        public static DateTime  DateDuJOUR;
        public static DateTime DateCloturer ;
        public static String AutreInfo = "706";
        public static Boolean ETATbd;
        public static Double TauxFc;
        public static Double TauxTrans;
        public static Double FraisdeTransProduit;
        public static Double FraisdeTransEmbllage;
        public static  Boolean ModeSms = true;

        public static string CompteEmbale = "310101";

        public static string RefAchercher;

        public static String userServeur;
       
        public static String motdepass1;
        public static String Motdepass2;
        public static String UrlSite;
        public static String Sender;
        public static String IdServeur;


        public static string CodeDepartement;
        public static string DesignationDepartement;
        public static string InitialDep;

        public static string CompteVariationStock = "603101";
        public static string venteProduit = "701101";
        public static string CompteStock = "310101";
        public static string CompteAchatstock = "601101";


        public static String Motdepasse = "4444";
        public static String codeINSRE = "4444";

        public static String Niveau;
        


        //public   string   seteconnexion()
        //{ 
        //    string s ;

        //    con = new SqlConnection();
        //    con.ConnectionString = "Data Source=DEVELOPPEUR;Initial Catalog=baselogistique;Integrated Security=True;";
        //    s = con.ConnectionString;
        //    return s;
        //}

    }

    public static class verifierNumbe
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}
