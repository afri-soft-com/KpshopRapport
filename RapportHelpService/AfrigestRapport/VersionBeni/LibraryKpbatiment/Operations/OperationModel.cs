using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Operations
{
    public class OperationModel
    {
        public int NumOpSource { get; set; }
        public string NumOperation { get; set; }
        public string Libelle { get; set; }
        public DateTime DateOp { get; set; }
        public DateTime DateSysteme { get; set; }
        public string NomUt { get; set; }
        public string CodeEtatdeBesoin { get; set; }

        public int status_result { get; set; }
    }
}
