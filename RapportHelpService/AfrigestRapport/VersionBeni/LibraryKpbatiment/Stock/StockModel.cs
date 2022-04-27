using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Stock
{
    public class StockModel
    {
        public string DesegnationArticle { get; set; }
        public double PrixAchat { get; set; }
        public double PrixVente { get; set; }
        public int Nombre { get; set; }
    }
}
