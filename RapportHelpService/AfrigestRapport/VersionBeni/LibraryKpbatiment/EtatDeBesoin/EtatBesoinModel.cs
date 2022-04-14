using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.EtatDeBesoin
{
    public class EtatBesoinModel
    {

        public int IdEtatDuBesoin { get; set; }
        public string CodeEtatdeBesoin { get; set; }
        public string DesignationEtatDeBesion { get; set; }
        public string CodeProject { get; set; }
        public string CodeLigne { get; set; }
       
        public int Etat { get; set; }
        public string Demandeur { get; set; }
        public string ValiderPar { get; set; }
        public double Total { get; set; }
        public DateTime DateEmision { get; set; }
        public DateTime DateRequise { get; set; }
        public DateTime DateValidation { get; set; }

    }
}
