using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Balance
{
    public class DetailBalanceModel
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

        

    }
}
