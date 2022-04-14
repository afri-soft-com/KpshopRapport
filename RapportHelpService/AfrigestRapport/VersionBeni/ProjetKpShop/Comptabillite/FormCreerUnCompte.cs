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

namespace GoldenStarApplication.Comptabillite
{
    public partial class FormCreerUnCompte : Form
    {
        public FormCreerUnCompte()
        {
            InitializeComponent();
        }
         public Boolean boolModifier;
        private void FormCreerUnCompte_Load(object sender, EventArgs e)
        {


            comboGroupe.Text = GroupeCompte;
            comboDesignatioGroupe.Text = DesignationGroupe;
            tDesignationSous.Text= DesignationGroupe;
            if( boolModifier == true)
            {
                comboGroupe.Text = GroupeCompte;
                comboDesignatioGroupe.Text = DesignationGroupe;
                tDesignationSous.Text = DesignationCompte;
                tSousGroupe.Text = Compte;
                bValider.Text = "MODIFIER";




            }
        }

        public String GroupeCompte, DesignationGroupe,Compte ,DesignationCompte;

        private void comboGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tSousGroupe.Text = comboGroupe.Text + tFormationSOUS.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tSousGroupe.Text.Trim() != "" && tDesignationSous.Text.Trim() != "")
            {
                LesClasses.ClassComptable clCompte = new LesClasses.ClassComptable();
                if ( boolModifier== false)
                {
                    clCompte.enregistrementComptabe(tSousGroupe.Text, "1", comboGroupe.Text, tDesignationSous.Text, ClassVaribleGolbal.CodeDepartement);
                   //MessageBox.Show("");
                
                        
                 
                }
                else if (boolModifier == true)
                {

                    clCompte.modifierCompte(tSousGroupe.Text, "1", comboGroupe.Text, tDesignationSous.Text);
                   // MessageBox.Show("");
                }
                enregistrementInitial(tSousGroupe.Text);

            }

            else
            {
                MessageBox.Show("Completer les cases vides");
            }

        }

        private void enregistrementInitial( string Compte)
        {
            LesClasses.ClasseOperationMvt clmvt = new LesClasses.ClasseOperationMvt();
            clmvt.suprimerUneOperationMouvement(ClassVaribleGolbal.OPinit, Compte);
            clmvt.enregistrementMouvmentCmpte(ClassVaribleGolbal.OPinit, Compte, "1", "0", "0");
         
            MessageBox.Show("ok");
        }
        private void tFormationSOUS_TextChanged(object sender, EventArgs e)
        {
            tSousGroupe.Text = comboGroupe.Text + tFormationSOUS.Text;
        }
    }
}
