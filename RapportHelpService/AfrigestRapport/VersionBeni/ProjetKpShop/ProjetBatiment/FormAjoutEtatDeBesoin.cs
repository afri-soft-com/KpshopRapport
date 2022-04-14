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

namespace GoldenStarApplication.ProjetBatiment
{
    public partial class FormAjoutEtatDeBesoin : Form
    {
        public FormAjoutEtatDeBesoin()
        {
            InitializeComponent();
        }
        public string CodeProject;
        private void FormAjoutEtatDeBesoin_Load(object sender, EventArgs e)
        {
            dernierPv();
            tCodePROJECT.Text = CodeProject;
        }

        public Boolean testeModification;
        private void dernierPv()
        {
            LesClasses.ClasseRequetteDernier clD = new LesClasses.ClasseRequetteDernier();
            string s = " SELECT        MAX(IdEtatDuBesoin) AS MaxIdPv  FROM            tEtatDeBesoin";
            tRefEB.Text ="EB"+ clD.fonctionDernierEntre(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enregistraiment();
        }


        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tEtatDeBesoin " +
                        " (CodeEtatdeBesoin, DesignationEtatDeBesion, CodeProject, Demandeur, Etat, DateEmision, DateRequise) " +
" VALUES        (@a,@b,@c,@d,@e,@da,@db)";

                String Supdate = "UPDATE       tEtatDeBesoin " +
" SET                CodeEtatdeBesoin = @a, DesignationEtatDeBesion = @b, CodeProject = @c, Demandeur = @d, Etat = @e, DateEmision = @da, DateRequise = @db "+
" WHERE        (CodeEtatdeBesoin = @a)";


                string[] r = { tRefEB.Text, tDesignationEb.Text, tCodePROJECT.Text, tDemandeur.Text,"0" };


                DateTime[] d = { tDateEb.Value, tDateRequise.Value };

                ClassRequette req = new ClassRequette();
                if (testeModification == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Supdate, r, d);
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
