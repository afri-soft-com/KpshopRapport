using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Balance
{
    public class ReleveModel
    {
        public int NumCompte { get; set; }
        public string DesignationCompte { get; set; }


        public string NumOperation { get; set; }
        public string Libelle { get; set; }
        public DateTime DateOperation { get; set; }

        public string Details { get; set; }
        public double Qte { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Solde { get; set; }

        public string DesignationEnt { get; set; }

        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string TeleEnt { get; set; }

        public string Email { get; set; }
        public string Site { get; set; }
        public string Republique { get; set; }
        public string ZoneSante { get; set; }

        public string Autre { get; set; }




    }
}
