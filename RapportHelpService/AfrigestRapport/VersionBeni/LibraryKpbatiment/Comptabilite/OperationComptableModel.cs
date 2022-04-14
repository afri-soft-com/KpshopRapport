using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Comptabilite
{
   public class OperationComptableModel
    {
        public int NumOpSource { get; set; }
        public string NumOperation { get; set; }
      
        public string Libelle { get; set; }
        public DateTime DateOp { get; set; }
        public string NomUt { get; set; }
       
        public DateTime DateSysteme { get; set; }




        public int IdMouvement { get; set; }
        public string NumCompteDebitEntree { get; set; }

        public string NumCompteCreditSortie { get; set; }

        public string Details { get; set; }
        public double Qte { get; set; }
        public double Montant { get; set; }
      
    }
}
