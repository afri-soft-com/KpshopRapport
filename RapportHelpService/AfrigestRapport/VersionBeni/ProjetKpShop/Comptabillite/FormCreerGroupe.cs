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
    public partial class FormCreerGroupe : Form
    {
        public FormCreerGroupe()
        {
            InitializeComponent();
        }
       public Boolean boolModifier;
        public string Cadre, DesignationCadre, GroupeCompte, DesignationGroupe;
        private void tGroupeAmodifer_TextChanged(object sender, EventArgs e)
        {
            tGroupeCompte.Text = comboCadre.Text + tGroupeAmodifer.Text;
        }

        private void B2enre_Click(object sender, EventArgs e)
        {
            if (tGroupeCompte.Text.Trim() != "" && tDesignqtion.Text.Trim() != "")
            {
                LesClasses.ClassComptable clCompte = new LesClasses.ClassComptable();
                if (boolModifier == false)
                {
                    clCompte.enregistrementGroupe (comboCadre.Text, tGroupeCompte.Text, tDesignqtion.Text);
                   // MessageBox.Show("");

                }

                else if (boolModifier == true)
                {

                    clCompte.modifierGroupe(comboCadre.Text, tDesignqtion.Text, tGroupeCompte.Text);
                    //MessageBox.Show("");
                }
               // enregistrementInitial(tSousGroupe.Text);

            }

            else
            {
                MessageBox.Show("Completer les cases vides");
            }

        }

        private void comboCadre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B2supprimmerGroupe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cadre);
        }

        private void FormCreerGroupe_Load(object sender, EventArgs e)
        {
            comboCadre.Text = Cadre;
            comboDesignatioCadre.Text = DesignationCadre;
            tDesignqtion.Text = DesignationCadre;

            if (boolModifier == true)
            {
                comboCadre.Text = Cadre;
                comboDesignatioCadre.Text = DesignationCadre;
                tDesignqtion.Text = DesignationCadre;
                tGroupeCompte.Text = GroupeCompte;
                tDesignqtion.Text = DesignationGroupe;
                B2enre.Text = "MODIFIER";




            }
        }
    }
}
