using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Projet
{
    public class ProjetModel
    {

        public  int IdProject { get; set; }
        public string CodeProject { get; set; }
        public string DesignationProject { get; set; }
        public string Lieu { get; set; }
        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }
        public string ChefDuProjet { get; set; }
        public int Compte { get; set; }
        public int CompteClient { get; set; }
        
        public int Etat { get; set; }
    }
}
