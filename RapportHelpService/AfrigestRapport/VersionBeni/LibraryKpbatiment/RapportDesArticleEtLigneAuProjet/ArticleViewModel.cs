using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.RapportDesArticleEtLigneAuProjet
{
    public class ArticleEtLigneViewModel
    {

        public string CodeArticle { get; set; }
       
        public string DesegnationArticle { get; set; }

        public double Qte { get; set; }
        public double Pu { get; set; }
        
        public double TotalConsommation { get; set; }
        public string CodeLigne { get; set; }
        public string DesignationLIgne { get; set; }
        public double TauxCons { get; set; }
        public double Prevision { get; set; }

    }
}
