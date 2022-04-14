using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Compte
{
   public class GrandLivreModel
    {

        public int NumCompte { get; set; }
        public string DesignationCompte { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Solde { get; set; }
        public double SoldeInitial { get; set; }

    }
}
