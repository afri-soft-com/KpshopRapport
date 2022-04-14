using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Ligne
{
   public class LigneViewModel
    {
        public string CodeLigne { get; set; }
        public string DesignationLIgne { get; set; }
        public string CodeProject { get; set; }
        public string DesignationProject { get; set; }
      

       // public double Prevision { get; set; }

        public double TotalConsommation { get; set; }
        public double TOtalPrevision { get; set; }

        public Double TauxCons { get; set; }
    }
}
