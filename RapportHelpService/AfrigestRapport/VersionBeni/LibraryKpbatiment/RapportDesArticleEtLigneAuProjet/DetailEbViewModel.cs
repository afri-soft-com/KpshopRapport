using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.RapportDesArticleEtLigneAuProjet
{
    public class DetailEbViewModel
    {

        public string CodeArticle { get; set; }

        public string DesegnationArticle { get; set; }

        public double Qte { get; set; }
        public double Pu { get; set; }

        public double TotalConsommation { get; set; }
        public string CodeEtatdeBesoin { get; set; }
        public string DesignationEtatDeBesion { get; set; }
        public string Demandeur { get; set; }
        public DateTime DateEmision { get; set; }


    }
}
