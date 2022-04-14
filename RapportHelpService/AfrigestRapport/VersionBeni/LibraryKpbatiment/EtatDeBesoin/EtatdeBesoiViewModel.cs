using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.EtatDeBesoin
{
   public class EtatdeBesoinViewModel
    {


        public string CodeEtatdeBesoin { get; set; }
        public string DesignationEtatDeBesion { get; set; }
        public DateTime DateEmision { get; set; }
        public double Total { get; set; }
        public double SommeDecaisse { get; set; }
    }
}
