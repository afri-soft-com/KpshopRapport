using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Projet
{
     public class ConsommationProjetViewModel
    {
        public string CodeProject { get; set; }
        public string DesignationProject { get; set; }
        public double TotalConsommation { get; set; }
        public double TOtalPrevision { get; set; }

        public Double TauxCons { get; set; }

    }
}
