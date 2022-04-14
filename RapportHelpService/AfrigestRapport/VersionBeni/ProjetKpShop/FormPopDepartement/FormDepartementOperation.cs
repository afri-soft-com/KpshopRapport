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


namespace GoldenStarApplication.FormPopDepartement
{
    public partial class FormDepartementOperation : Form
    {
        public FormDepartementOperation()
        {
            InitializeComponent();
        }

        private void FormDepartementOperation_Load(object sender, EventArgs e)
        {
            ChargementAffectation();
        }

        public String UTILISATEUR;

        private void ChargementAffectation()
        {

            try
            {

                string s = "SELECT        tDepartement.DesignationDepartement, tDepartement.InitialDep, tDepartement.CodeDepartement " +
" FROM            tAffectatioUtAuDepartement INNER JOIN " +
                        "  tDepartement ON tAffectatioUtAuDepartement.CodeDepartement = tDepartement.CodeDepartement " +
" WHERE        (tAffectatioUtAuDepartement.NomUtilisateur = @a) ";

                string[] r = { UTILISATEUR };

                DateTime[] d = { (DateTime.Now) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);

                comboDepartement.DataSource = classeReq.dt;
                comboDepartement.DisplayMember = "DesignationDepartement";
                listBox1.DataSource = classeReq.dt;
                listBox1.DisplayMember = "DesignationDepartement";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.ValueMember = "DesignationDepartement";
            ClassVaribleGolbal.DesignationDepartement = listBox1.SelectedValue.ToString() ;
            listBox1.ValueMember = "InitialDep";
            ClassVaribleGolbal.InitialDep = listBox1.SelectedValue.ToString();
            listBox1.ValueMember = "CodeDepartement";
            ClassVaribleGolbal.CodeDepartement = listBox1.SelectedValue.ToString();

        }

    }
}
