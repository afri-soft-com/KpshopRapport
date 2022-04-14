using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Stock
{
   public class MvtStockModel
    {
        public string CodeArticle { get; set; }
        public string DesegnationArticle { get; set; }
        public string CodeDepot { get; set; }
        public int NumOperation { get; set; }

        public string RefComptabilite { get; set; }
        public double PR { get; set; }
        public double PVentUN { get; set; }


        public double QteSortie { get; set; }
        public double QteEntree { get; set; }

        public double Vente { get; set; }
        public double Valeur { get; set; }

        public double Enstock { get; set; }

        public DateTime DateOp { get; set; }


    }
}
