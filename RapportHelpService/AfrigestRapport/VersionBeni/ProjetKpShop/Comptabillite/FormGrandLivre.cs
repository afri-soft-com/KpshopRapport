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
    public partial class FormGrandLivre : Form
    {
        string _provenance;
        int _numCompte = 0;
        public FormGrandLivre(string provenance)
        {
            InitializeComponent();
            _provenance = provenance;
            if(_provenance == "relever_stock")
            {
                tDateR1.Enabled = false;
                tdateR2.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void FormGrandLivre_Load(object sender, EventArgs e)
        {
            chargementCombo();
            comboCompte.Text = Compte;
        }
        public string Compte;
        private void chargementCombo()
        {
            LesClasses.ClassChargementdeCombo classeCombo = new LesClasses.ClassChargementdeCombo();
            classeCombo.chargementComboCompte(comboCompte, comboCompteDes, ClassVaribleGolbal.CodeDepartement) ;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            FormPop.FormRecherCompte Fp = new FormPop.FormRecherCompte();
            Fp.Text = this.Text;
            // Fp.nomAchercher = comboPostNomCas.Text.Trim();
            //OK
            DialogResult Dial = Fp.ShowDialog();
            if (Dial == DialogResult.OK)
            {

                comboCompte.Text = ClassVaribleGolbal.RefAchercher;
                //label2.Text = "tu clicl sur ok";
                //chargemeenDGFacturationSerice();
                //dgFacturation.DataSource = TableFacturation;
                // tSommeFact.Text = SommeFact.ToString();
            }

            else if (Dial == DialogResult.Cancel)
            {
                comboCompte.Text = "";
                // label2.Text = "tu clicl sur cance";

            }
        }


        private void chargmentClasse()
        {
            //            string s;
            //            string sEncour = " SELECT       tCompte.NumCompte, tCompte.DesignationCompte, SUM(tMvtCompte.Entree) - SUM(tMvtCompte.Sortie) AS Solde, COUNT(DISTINCT tCompte.NumCompte) AS Nombre " +
            //" FROM tMvtCompte INNER JOIN " +
            //                        "  tOperation ON tMvtCompte.NumOperation = tOperation.NumOperation LEFT OUTER JOIN " +
            //                         " tCompte ON tMvtCompte.NumCompte = tCompte.NumCompte " +
            //" GROUP BY tCompte.CodeDepartement, tCompte.GroupeCompte, tCompte.DesignationCompte, tCompte.NumCompte " +
            //" HAVING(tCompte.CodeDepartement = @a) AND(tCompte.GroupeCompte = @b); ";

            string sEncour = "   SELECT tCompte.NumCompte, tCompte.DesignationCompte, View_LesMouvementCompte.Solde, View_LesMouvementCompte.Nombre " +
" FROM             tCompte LEFT OUTER JOIN" +
                        "  View_LesMouvementCompte ON tCompte.NumCompte = View_LesMouvementCompte.NumCompte " +
" WHERE    (tCompte.NumCompte = @a)";


            string[] r = { comboCompte.Text.Trim() };
            DateTime[] da = { DateTime.Now };

            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
            Ccdt.chargmentTableDateAvecParametre(sEncour, r, da);
            dGcOMPTE.DataSource = Ccdt.tableEmoir;


        }

        private void comboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargmentClasse();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                FormPop.FormPopPassageDate Fp = new FormPop.FormPopPassageDate(_provenance);
                Fp.Text = this.Text;
                Fp.BoolReleve = true;
                String desCompte;

                desCompte = comboCompteDes.Text;
                Fp.libeleOP = "RELEVE DE : " + desCompte;
                Fp.NumCompte = comboCompte.Text.Trim();




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

        private void button2_Click(object sender, EventArgs e)
        {
            FormDetailMvtCompte fo = new FormDetailMvtCompte();
            //fo.MdiParent = this.MdiParent;
            fo.Date1 = tDateR1.Value;
            fo.Date2 = tdateR2.Value;
            try
            {
                int ci;
                ci = dGcOMPTE.CurrentRow.Index;
                fo.Compte = dGcOMPTE["NumCompte", ci].Value.ToString();
            }

            catch (Exception ex)
            {

                fo.Compte = "";
            }

            fo.Text = this.Text;
            // fo.utilisateur = ClassVaribleGolbal.UTILISATEUR;

            fo.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboCompteDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGcOMPTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
