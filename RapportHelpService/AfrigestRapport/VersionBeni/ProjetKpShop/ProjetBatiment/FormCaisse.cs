using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenStarApplication.ProjetBatiment
{
    public partial class FormCaisse : Form
    {
        public FormCaisse()
        {
            InitializeComponent();
        }

        private void RbDepense_CheckedChanged(object sender, EventArgs e)
        {
            chargementComboEB();
            ErireLibele();
        }

        private void FormCaisse_Load(object sender, EventArgs e)
        {
            chargementCombo();
        }

        private void chargementCombo()
        {
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargementComboCompte(comboDebit, comboDebitDes, " ");
            cb.chargementComboCompte(comboCredit, comboCrediDES, " ");
            
        
        }

        private void chargementComboEB()
        {
            LesClasses.ClassChargementdeCombo cb = new LesClasses.ClassChargementdeCombo();
            cb.chargmentEatBESION(comboEtatCode, comboEtatCodeDES, cBProject);
            //cb.chargementComboCompte(comboCredit, comboCrediDES, " ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDetaillEB FP = new FormDetaillEB();
            FP.Text = this.Text;
            int ci;
            //FP.CodeProject = CodeProjecte;
            //ci = DGProjet.CurrentRow.Index;
            //FP.CodeEtatdeBesoin = DGProjet["CodeEtatdeBesoin", ci].Value.ToString();
            FP.CodeEtatdeBesoin = comboEtatCode.Text.Trim() ;
            //FP.DesignationEtatDeBesion = DGProjet["DesignationEtatDeBesion", ci].Value.ToString();
            DialogResult Dial = FP.ShowDialog();
            if (Dial == DialogResult.OK)
            {


                // chargmentDgProject();
            }
            else
            {
                // chargmentDgProject();

            }
        }

        private string DesignationProject;
        private void comboEtatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEtatCode.ValueMember = "Total";
            tmotant.Text = comboEtatCode.SelectedValue.ToString();
            comboEtatCode.ValueMember = "DesignationProject";
            DesignationProject = comboEtatCode.SelectedValue.ToString();
            ErireLibele();   
        }

        private void comboEtatCodeDES_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEtatCodeDES.ValueMember = "Total";
            tmotant.Text = comboEtatCodeDES.SelectedValue.ToString();
            comboEtatCodeDES.ValueMember = "DesignationProject";
            DesignationProject = comboEtatCodeDES.SelectedValue.ToString();
            ErireLibele();   
        }

        private void ErireLibele()
        {
        
            if(RbDepense.Checked == true)
             {

                 tLibelle.Text = "PROJETC:" + DesignationProject + " EB: " + comboEtatCode.Text + "/" + comboEtatCodeDES.Text;
            pEB.Enabled = true;
            comboCredit.Text = ClassKpBatimentVariableGobal.ComptCaisseKpBatiment;
            comboDebit.Text = ClassKpBatimentVariableGobal.ComptChargeKpBatiment;
            pCredit.Enabled = false;
            paneDebut.Enabled = false;
            
            }

            else if ( RbRavitaillement.Checked == true)
            {
              pEB.Enabled = false;
            tLibelle.Text =  "Aprovisionnement Caisse PAR";
            comboDebit.Text = ClassKpBatimentVariableGobal.ComptCaisseKpBatiment;
            comboCredit.Text = ClassKpBatimentVariableGobal.ComptCompteAssBatiment;
            pCredit.Enabled = true;
            paneDebut.Enabled = false;
            }

             else if ( rBAutre.Checked == true)
            {
             pEB.Enabled = false;
            tLibelle.Text =  "AUTRE Operation";
            pCredit.Enabled = true;
            paneDebut.Enabled = true;
            }
        
        
        }

        private void RbRavitaillement_CheckedChanged(object sender, EventArgs e)
        {
            ErireLibele();
        }

        private void rBAutre_CheckedChanged(object sender, EventArgs e)
        {
            ErireLibele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
