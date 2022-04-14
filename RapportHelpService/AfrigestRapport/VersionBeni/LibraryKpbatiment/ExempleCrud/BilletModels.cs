using System;
//using System.ComponentModel.DataAnnotations;

namespace ClassLibraryCtcBD.VenteBILLET
{
    public class BilletModels
    {

        public int IdBillet { get; set; }
        public int IdCompagnie { get; set; }

        public string DesignationCompanie { get; set; }

        public string Nom { get; set; }
        public string PostNom { get; set; }
       
        public string Telephone { get; set; }

        public string IdProvenance { get; set; }

        public string IdDestination { get; set; }
        public string Piece { get; set; }

        //[RegularExpression("([0-9]+)", ErrorMessage = "Entrer un nombre valide")]
        public string NombreEnfant { get; set; }

        public DateTime DatedeVoyage { get; set; }
        public DateTime DateOP { get; set; }
    }
}
