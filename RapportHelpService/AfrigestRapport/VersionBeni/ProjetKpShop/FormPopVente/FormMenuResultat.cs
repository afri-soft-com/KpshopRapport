using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenStarApplication.FormPopVente
{
    public partial class FormMenuResultat : Form
    {
        public FormMenuResultat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Sprocedure = "Proc_ProRapportDeTousLesMvtChargeEtProduit";
            string cheminRap = "Rapport/KPSHOP/ReportTableauDeResulta.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };

            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            // MessageBox.Show(Rapport.FormParamentreDate.Date1.ToString() + " " + Rapport.FormParamentreDate.Date2.ToString());
            clrap.affichetOUUrAPPOR(Sprocedure, cheminRap, parametre, d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sprocedure = "Proc_RapportDeResultatParPeriode";
            string cheminRap = "Rapport/KPSHOP/ReportResultatEvolution.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };

            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            // MessageBox.Show(Rapport.FormParamentreDate.Date1.ToString() + " " + Rapport.FormParamentreDate.Date2.ToString());
            clrap.affichetOUUrAPPOR(Sprocedure, cheminRap, parametre, d);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            string sPro1 = "Proc_RapportDeTousLesMvtCadreCirculant";
            string sPro2 = "Proc_RapportDeTouslesSoldeCompte";
            // DataTable tablePlan;
            string chiminRap = "Rapport/KPSHOP/ReportTableauDebord.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };
            clrap.ModdifierDateINI(tDateR1.Value);
            clrap.affichetOUUrAPPORavecDeux(sPro1, sPro2, chiminRap, parametre, d);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Sprocedure = "Proc_RapportFactureDeVenteGlobal";
            string cheminRap = "Rapport/KPSHOP/ReportVenteC.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };

            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            // MessageBox.Show(Rapport.FormParamentreDate.Date1.ToString() + " " + Rapport.FormParamentreDate.Date2.ToString());
            clrap.affichetOUUrAPPOR(Sprocedure, cheminRap, parametre, d);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Sprocedure = "Proc_RapportFactureDeVenteGlobalParCaissiereTous";
            string cheminRap = "Rapport/KPSHOP/ReportVenteParUtilisateur.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };

            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            // MessageBox.Show(Rapport.FormParamentreDate.Date1.ToString() + " " + Rapport.FormParamentreDate.Date2.ToString());
            clrap.affichetOUUrAPPOR(Sprocedure, cheminRap, parametre, d);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Sprocedure = "Proc_RapportFactureDeVenteDetaille";
            string cheminRap = "Rapport/KPSHOP/ReportVenteParPeriode.rdlc";
            string[] parametre = { "411" };
            DateTime[] d = { tDateR1.Value, tdateR2.Value };

            LesClasses.ClassChargementRapport clrap = new LesClasses.ClassChargementRapport();
            // MessageBox.Show(Rapport.FormParamentreDate.Date1.ToString() + " " + Rapport.FormParamentreDate.Date2.ToString());
            clrap.affichetOUUrAPPOR(Sprocedure, cheminRap, parametre, d);
        }
    }
}
