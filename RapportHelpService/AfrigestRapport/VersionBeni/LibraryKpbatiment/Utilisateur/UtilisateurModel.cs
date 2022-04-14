using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryKpbatiment.Utilisateur
{
    public class UtilisateurModel
    {
        public int IdUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string DesignationUt { get; set; }
        public string MotPasseUtilisateur { get; set; }
        public string NiveauUtilisateur { get; set; }
        public string FonctionUt { get; set; }
        public string ServiceAffe { get; set; }
        public int Compte { get; set; }
        public int CompteDeclaration { get; set; }
        public int Actif { get; set; }
    }
}
