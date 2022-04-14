using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenStarApplication.Comptabillite
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void bCreeUnCompte_Click(object sender, EventArgs e)
        {
            Boolean exiset = false;
            foreach (Form c in this.MdiChildren)
            {
                // c.Text = Me.Text
                if (c.Name == "")
                {
                    //c.Close();
                    c.Activate();
                    // Exit Sub
                    exiset = true;
                }


            }


            if (exiset == false)
            {

                FormPopVente.FormPaiment fo = new FormPopVente.FormPaiment();
                // fo.MdiParent = this.MdiParent;
                fo.Comptabilite(false);
                fo.Text = this.Text;
                // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;
                //fo.CodeDepot = comboDepot.Text;
                //fo.CodeVendeur = comboCodeDeVendeur.Text;
                // fo.NomsVendeur = comboVendeurDes.Text;
                fo.ShowDialog();
            }

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             FormClasse FP = new FormClasse();
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
           // FP.CodeCategorie = comboCat.Text.Trim();
            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    // chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGrandLivre FP = new FormGrandLivre("relever_compte");
            FP.Text = this.Text;
            // Fp.NumOP = fonctionOPSotie();
            ///Fp.Utisateur = utilisateur;
            ///
           // FP.CodeCategorie = comboCat.Text.Trim();

            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    // chargmentComboArticle();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate("");
                Fp.Text = this.Text;
                Fp.BoolJournal = true;
               // String desCompte;

               // desCompte = comboCompteDes.Text;
                Fp.libeleOP = "JOURNAL : " ;
                Fp.NumCompte = "";




                DialogResult Dial = Fp.ShowDialog();
                if (Dial == DialogResult.OK)
                {



                }

                else if (Dial == DialogResult.Cancel)
                {



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
