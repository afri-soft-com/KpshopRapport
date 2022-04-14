using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.EtatDeBesoin
{
    public class DetailEtatDeBesoinModel
    {

        public int IdDetailEB { get; set; }
        public string CodeEtatdeBesoin { get; set; }
        public string CodeArticle { get; set; }
        public string CodeLigne { get; set; }
        public string DesegnationArticle { get; set; }
        public string LibelleDetail { get; set; }
       // public string DesegnationArticle { get; set; }
        
        public double Qte { get; set; }
        public double Pu { get; set; }
        public double Sortie { get; set; }
        public double Entree { get; set; }
        public double Total { get; set; }
    }
}
