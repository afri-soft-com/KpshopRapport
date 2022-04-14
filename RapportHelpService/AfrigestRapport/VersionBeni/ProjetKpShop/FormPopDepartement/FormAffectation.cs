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
    public partial class FormAffectation : Form
    {
        public FormAffectation()
        {
            InitializeComponent();
        }

        private void FormAffectation_Load(object sender, EventArgs e)
        {

            ChargementUtisateur();
            ChargementDepartement();
            


        }


        private void ChargementUtisateur()
        {

            try
            {

                string s = " SELECT        IdUtilisateur, NomUtilisateur, DesignationUt, FonctionUt, ServiceAffe" +
                              "           FROM            tUtilisateur ";

                string[] r = { "" };

                DateTime[] d = { (DateTime.Now) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);

                comboUt.DataSource = classeReq.dt;
                comboUt.DisplayMember = "DesignationUt";
                comboUt.ValueMember = "NomUtilisateur";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void ChargementDepartement()
        {

            try
            {

                string s = "SELECT        IdDepartement, CodeDepartement, DesignationDepartement, InitialDep " +
" FROM            tDepartement ";

                string[] r = { "" };

                DateTime[] d = { (DateTime.Now) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);

                comboDepartement.DataSource = classeReq.dt;
                comboDepartement.DisplayMember = "DesignationDepartement";
                comboDepartement.ValueMember = "CodeDepartement";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void ChargementAffectation()
        {

            try
            {

                string s = "SELECT        tDepartement.DesignationDepartement, tDepartement.InitialDep, tDepartement.CodeDepartement " +
" FROM            tAffectatioUtAuDepartement INNER JOIN " +
                        "  tDepartement ON tAffectatioUtAuDepartement.CodeDepartement = tDepartement.CodeDepartement " +
" WHERE        (tAffectatioUtAuDepartement.NomUtilisateur = @a) ";

                string[] r = { comboUt.SelectedValue.ToString() };

                DateTime[] d = { (DateTime.Now) };

                ClassRequette classeReq = new ClassRequette();
                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tEleve", r, d);

                dGaffectation.DataSource = classeReq.dt;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            enregitrementUtilisateur();
            ChargementAffectation();
        }


        private void enregitrementUtilisateur()
        {


            try
            { 
            
            
            string s = "INSERT INTO tAffectatioUtAuDepartement (CodeDepartement, NomUtilisateur) VALUES        (@a,@b)";


          //  string sUpdate = "UPDATE  tUtilisateur  Set  NomUtilisateur=@a, DesignationUt=@b,MotPasseUtilisateur=@c,FonctionUt=@d,ServiceAffe=@e WHERE  NomUtilisateur=@a ";

            string[] r = { comboDepartement.SelectedValue.ToString(), comboUt.SelectedValue.ToString() };
            DateTime[] d = { DateTime.Now };

            ClassRequette req = new ClassRequette();

           
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }



        private void suprimer()
        {


            try
            {


                string s = " DELETE  FROM tAffectatioUtAuDepartement WHERE  (CodeDepartement=@a AND NomUtilisateur=@b)";


                //  string sUpdate = "UPDATE  tUtilisateur  Set  NomUtilisateur=@a, DesignationUt=@b,MotPasseUtilisateur=@c,FonctionUt=@d,ServiceAffe=@e WHERE  NomUtilisateur=@a ";

                string[] r = { comboDepartement.SelectedValue.ToString(), comboUt.SelectedValue.ToString() };
                DateTime[] d = { DateTime.Now };

                ClassRequette req = new ClassRequette();


                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }


        private void comboUt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargementAffectation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suprimer();
            ChargementAffectation();
        }

    }  
}
