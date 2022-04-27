using System;
using LibraryKpbatiment;
namespace LibraryKpbatiment
{
    public class ClassVariableGlobal
    {
        public static string seteconnexionLoc;
        public static string seteconnexion()
        {

            // seteconnexionLoc = "Data Source=SQL5092.site4now.net;Initial Catalog=DB_A54EFD_kpShop;User Id=DB_A54EFD_kpShop_admin;Password=12345678GL";
            // seteconnexionLoc = "Data Source=SQL5026.site4now.net;Initial Catalog=DB_A54EFD_batiment;User Id=DB_A54EFD_batiment_admin;Password=12345678GL";
            //seteconnexionLoc = LibraryKpbatiment.ClassVariableGlobal.seteconnexionLoc;
            // seteconnexionLoc = @"Data Source=192.168.0.100;Initial Catalog=BaseKpBatiment;Integrated Security=false ;User ID=YAN; Password =123456789";
            // seteconnexionLoc = @"Data Source=127.0.0.1;Initial Catalog=BaseKpShop3;Integrated Security=false ;User ID=MANDAL; Password =12345678";
            // seteconnexionLoc = @"Data Source=127.0.0.1;Initial Catalog=BaseHotelIshango;Integrated Security=false ;User ID=MANDAL; Password =12345678";

            //seteconnexionLoc = "Data Source=SQL5092.site4now.net;Initial Catalog=DB_A54EFD_kpShop;User Id=DB_A54EFD_kpShop_admin;Password=12345678GL";
            // seteconnexionLoc = "Data Source=SQL5069.site4now.net;Initial Catalog=DB_A6D169_AfrisoftKonnect;User Id=DB_A6D169_AfrisoftKonnect_admin;Password=12345678GL";

            // seteconnexionLoc = "Data Source=KP-SHOP-SERVER;Initial Catalog=BaseKpShop;User Id=KP;Password=12345678GL";

            //seteconnexionLoc = @"Data Source=SERVER-KP-SHOP;Initial Catalog=KPSHOP_DB2021;Integrated Security=false ;User ID=KP-SHOP; Password ='123456789'";

            // seteconnexionLoc = "Data Source=SQL5061.site4now.net;Initial Catalog=db_a6d169_kpshopdb;User Id=db_a6d169_kpshopdb_admin;Password =12345678GL";
            //seteconnexionLoc = @"Data Source=127.0.0.1;Initial Catalog=BaseKpBunia;Integrated Security=false ;User ID=MANDAL; Password =12345678";

            //Data Source=SQL5061.site4now.net;Initial Catalog=db_a6d169_kpshopdb;User Id=db_a6d169_kpshopdb_admin;Password =12345678GL

            // POUR ESSAI YANNICK
            seteconnexionLoc = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_BENI;Integrated Security=false ;User ID=Yan; Password ='123456789'";
            //seteconnexionLoc = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_DB;Integrated Security=false ;User ID=Yan; Password ='123456789'";
            //seteconnexionLoc = @"Data Source=AFRISOFT;Initial Catalog=KPSHOP_BASE_DONNEE;Integrated Security=false ;User ID=Yan; Password ='123456789'";

            // POUR HELP SERVICE
            ////seteconnexionLoc = @"Data Source=SERVEU-HELP\SERVEUHELP;Initial Catalog=HELP_DB;Integrated Security=false ;User ID=HELP2; Password ='123456789'";


            return seteconnexionLoc;
        }

    }
}
