using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Balance
{
   public class BalanceModel
    {
        public int NumCompte { get; set; }
        public string DesignationCompte { get; set; }
        public int GroupeCompte { get; set; }
        public string DesignationGroupe { get; set; }
        public int Nombre { get; set; }
        public double Solde { get; set; }
        public DateTime DateOperation { get; set; }

        public string TeleEnt { get; set; }
    }
}
