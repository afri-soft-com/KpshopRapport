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

namespace GoldenStarApplication.FormPopVente
{
    public partial class FormQte : Form
    {
        public FormQte()
        {
            InitializeComponent();
        }
        public string CodeArrcticle, DesignationAricle, PriunideVent, CPu, NumOperation,  CodeDepot;
        private double TotalSome, TotalSomeVente;

        private void button1_Click(object sender, EventArgs e)
        {
            calculerPlus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculerMoin();
        }

        private void Bvalide_Click(object sender, EventArgs e)
        {
            try
            {


                string sVente = " INSERT  INTO   tMvtStock     (NumOperation,NumCompte,CodeDepot,QteSortie, PVentUN,Sortie,QteSortieVente,PR,SommeVente,Vente) VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
                string[] rVente = { NumOperation, CodeArrcticle.Trim(), CodeDepot, tQte.Text, tPrixVente.Text.Trim(), TotalSome.ToString(), tQte.Text, CPu, TotalSomeVente.ToString(), TotalSomeVente.ToString() };
                DateTime[] d = { DateTime.Now };
                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, sVente, rVente, d);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //QteSortie
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
            tPrixVente.Text = PriunideVent;
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
