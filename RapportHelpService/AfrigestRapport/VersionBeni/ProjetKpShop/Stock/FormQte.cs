using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace GoldenStarApplication.Stock
{
    public partial class FormQte : Form
    {
        public FormQte()
        {
            InitializeComponent();
        }
        public string CodeArrcticle, DesignationAricle, PriunideVent, CPu, NumOperation,  CodeDepot;
        private double TotalSome, TotalSomeVente;
        public string DEpotCentrale = "CD1";
        private void button1_Click(object sender, EventArgs e)
        {
            calculerPlus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculerMoin();
        }


        public Boolean Ravitaillement, Achat;
        private void Bvalide_Click(object sender, EventArgs e)
        {
           
            if ( Ravitaillement == true)
            {
                enregistrement();
            }
            else
            {
                enregistrementAchat();
            }

            //QteSortie
        }

        private void tPrixVente_TextChanged(object sender, EventArgs e)
        {
            Calculer();
        }

        private void enregistrement()
        {

            try
            {


               // MessageBox.Show("enregistrement");

                string sVente = " INSERT  INTO   tMvtStock     (NumOperation,CodeArticle,CodeDepot,QteSortie, PVentUN,Sortie,QteSortieVente,PR,SommeVente,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
                string sVentENTRE = " INSERT  INTO   tMvtStock     (NumOperation,CodeArticle,CodeDepot,QteEntree, PVentUN,Entree,QteSortieVente,PR,SommeVente,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";


                string[] rVente = { NumOperation, CodeArrcticle.Trim(), DEpotCentrale, tQte.Text, tPrixVente.Text.Trim(), TotalSome.ToString(), tQte.Text, CPu, TotalSomeVente.ToString(), TotalSomeVente.ToString() };
                string[] RVentENTRE = { NumOperation, CodeArrcticle.Trim(), CodeDepot, tQte.Text, tPrixVente.Text.Trim(), TotalSome.ToString(), tQte.Text, CPu, TotalSomeVente.ToString(), TotalSomeVente.ToString() };

                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVente, rVente, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVentENTRE, RVentENTRE, d);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void enregistrementAchat()
        {

            try
            {


               // MessageBox.Show("enregistrementAchat");

                string sVente = " INSERT  INTO   tMvtStock     (NumOperation,CodeArticle,CodeDepot,QteEntree, PVentUN,Entree,QteSortieVente,PR,SommeVente,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
                string sModifier = " UPDATE       tStock SET         PrixAchat = @b WHERE        (CodeArticle = @a) ";

                string[] rVente = { NumOperation, CodeArrcticle.Trim(), DEpotCentrale, tQte.Text, tPrixVente.Text.Trim(), TotalSome.ToString(), tQte.Text, tPrixVente.Text.Trim(), TotalSomeVente.ToString(), TotalSomeVente.ToString() };
                string[] rModifier = { CodeArrcticle.Trim(), tPrixVente.Text.Trim() };
                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVente, rVente, d);
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sModifier, rModifier, d);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void tQte_TextChanged(object sender, EventArgs e)
        {
            Calculer();
        }

        private void calculerPlus()
        {
            try
            {
                tQte.Text = ((double.Parse(tQte.Text)) + 1).ToString();
            }

            catch (Exception ex)
            {

                tQte.Text = "1";
            }
        }

        private void calculerMoin()
        {
            try
            {

                if ((double.Parse(tQte.Text))>1)
                {
                    tQte.Text = ((double.Parse(tQte.Text)) - 1).ToString();
                }
               

        }

            catch (Exception ex)
            {

                tQte.Text = "1";
            }
}

        private void FormQte_Load(object sender, EventArgs e)
        {
            if (Ravitaillement == true)
            {
                lprixAchat.Text = "PRIX DE VENTE";
                tPrixVente.Text = PriunideVent;

            }
            else
            {
                lprixAchat.Text = "PRIX ACHAT";
                tPrixVente.Text = CPu;
            }
            
                

            lARTICLE.Text = DesignationAricle;
            Calculer();
        }

        private  void Calculer ()
        {
            double Total;
            try
            {
                Total = (double.Parse(tPrixVente.Text)) * (double.Parse(tQte.Text));
                tTotal.Text = Total.ToString();
                TotalSomeVente = Total;
                TotalSome = (double.Parse(CPu)) * (double.Parse(tQte.Text));
            }
            catch ( Exception ex)
             {

                tTotal.Text = "0";
            }
        }
    }
}
