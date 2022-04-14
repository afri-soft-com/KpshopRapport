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
    public partial class FormNouveauArticle : Form
    {
        public FormNouveauArticle()
        {
            InitializeComponent();
        }


        public string CodeCategorie;
        public Boolean testeModification;
       
        private void FormNouveauArticle_Load(object sender, EventArgs e)
        {

            Bmodifier.Enabled = false;
            dernierPv();
            chargeementComboCategorie();

        }

        private void  chargeementComboCategorie()
        {

            LesClasses.ClassChargementdeCombo ClasseCharCombo = new LesClasses.ClassChargementdeCombo();
            ClasseCharCombo.chargmentComboCategorie(comboCategorie, comboCategorieDes, ClassVaribleGolbal.CodeDepartement);

        }

        private void dernierPv()
        {
            LesClasses.ClasseRequetteDernier clD = new LesClasses.ClasseRequetteDernier();
            string s = " SELECT        MAX(IdArticle) AS MaxIdPv  FROM            tStock";
            tCodeRef.Text = ClassVaribleGolbal.InitialDep + clD.fonctionDernierEntre(s);

        }



        private void enregistraiment()
        {
            try
            {

                string s = "INSERT INTO tStock " +
                         " (CodeArticle,  DesegnationArticle, CategorieArticle, PrixAchat, Compte,PrixVente) " +
" VALUES        (@a,@b,@c,@d,@e,@f) ";

                String Supdate = "UPDATE       tStock " +
" SET               DesegnationArticle = @b, CategorieArticle = @c, PrixAchat = @d, Compte = @e ,PrixVente=@f" +
" WHERE        (CodeArticle = @a)";


                string[] r = { tCodeRef.Text,  tDesArticle.Text, comboCategorie.Text, tPu.Text, ClassVaribleGolbal.CompteStock,tPuniVente.Text };


                DateTime[] d = { DateTime.Now, DateTime.Now };

                ClassRequette req = new ClassRequette();
                if (testeModification == true)
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Supdate, r, d);
                    MessageBox.Show("MIDIFICATION EFFECTUEE");
                }
                else
                {
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                    MessageBox.Show("ENREGISTREMENT EFFECTUE");
                }

              
                LesClasses.ClasseArticle ClasseArticle = new LesClasses.ClasseArticle();
                ClasseArticle.SupprimerInititialDepot(ClassVaribleGolbal.OPinit, tCodeRef.Text.Trim(), ClassVaribleGolbal.CodeDepotCentral);
                ClasseArticle.enreSrock(ClassVaribleGolbal.OPinit, tCodeRef.Text.Trim(), ClassVaribleGolbal.CodeDepotCentral);
                ClasseArticle.SupprimerLinitial(ClassVaribleGolbal.CodeDepotCentral, tCodeRef.Text.Trim());
                ClasseArticle.EnrigistrementParametre(ClassVaribleGolbal.CodeDepotCentral, tCodeRef.Text.Trim(), tCritique.Text, tPuniVente.Text, "1");
                

            }

           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tCodeRef.Text.Trim() != "") && (tDesArticle.Text.Trim() != ""))
            {

                enregistraiment();
                dernierPv();
                chargemnentDgArticle();
                annuler();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }
        }



        private void chargemnentDgArticle()
        {

            //CodeDepartement,CategorieArticle 
            string s = " SELECT        CodeArticle, DesegnationArticle, PrixAchat, PrixVente,CategorieArticle" +
" FROM            tStock " +
" WHERE        (CategorieArticle = @a) ";
            LesClasses.ClassChargementDatagrig Ccdt = new LesClasses.ClassChargementDatagrig();
           
             string[] r = {  comboCategorie.Text  };
               DateTime[] da = { DateTime.Now };
               Ccdt.chargmentTableDateAvecParametre(s, r, da);
            dgArticle.DataSource = Ccdt.tableEmoir;
           // CalculdeTotal();
        
        
        }

        private void comboCategorieDes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testeModification = true;
            if ((tCodeRef.Text.Trim() != "") && (tDesArticle.Text.Trim() != ""))
            {

                enregistraiment();
                dernierPv();
                chargemnentDgArticle();
                annuler();
            }
            else
            {
                MessageBox.Show("COMPTER LES CASE VIDES");
            }
        }


        private void annuler()
        {
            tDesArticle.Text = "";
            tPu.Text = "";
            tPuniVente.Text = "";
            Bmodifier.Enabled = false;
            dernierPv();
            testeModification = false;
        
        }
        private void dgArticle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ci;
           // FP.CodeProject = CodeProjecte;
            ci = dgArticle.CurrentRow.Index;
           // tCodeRef.Text, ClassVaribleGolbal.CodeDepartement, tDesArticle.Text, comboCategorie.Text, tPu.Text, ClassVaribleGolbal.CompteStock,tPuniVente.Text
            tCodeRef.Text = dgArticle["CodeArticle", ci].Value.ToString();
            tPu.Text = dgArticle["PrixAchat", ci].Value.ToString();
            tPuniVente.Text = dgArticle["PrixVente", ci].Value.ToString();
            tDesArticle.Text = dgArticle["DesegnationArticle", ci].Value.ToString();
            comboCategorie.SelectedValue= dgArticle["CategorieArticle", ci].Value.ToString();

            Bmodifier.Enabled = true;
        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargemnentDgArticle();
        }


        private void chargemeentDgAchercher()
        {
            try
            {
                string s;

                string a = "'%" + "stev" + " %'";
                s = " SELECT        CodeArticle, DesegnationArticle, PrixAchat, PrixVente,CategorieArticle " +
" FROM            tStock " +
" WHERE    (DesegnationArticle) LIKE \'%" + tAchercher.Text + "%\'";


//                string s = " SELECT        CodeArticle, DesegnationArticle, PrixAchat, PrixVente,CategorieArticle" +
//" FROM            tStock " +
//" WHERE        (CategorieArticle = @a) ";


                ClassRequette classeReq = new ClassRequette();

                string[] r = { ClassVaribleGolbal.CodeDepartement };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);






                //Ccdt.chargmentTableDateAvecParametre(s, r, da);
                dgArticle.DataSource = classeReq.dt; 


                //TableAcherche = classeReq.dt;

                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          FormAjoutCategorie FP = new FormAjoutCategorie();
            FP.Text = this.Text;
            FP.CodeCategorie = comboCategorie.Text;
            FP.testeModification = false;
          //FP.DesignationGroupe = comboGroupeDes.Text;
            ///
            // FP.CodeCategorie = comboCat.Text.Trim();

            FP.Text = this.Text;
            // int ci;
            //FP.NumClasse = CodeProjecte;
            //ci = dGgroupe.CurrentRow.Index;
            //FP.GroupeCompte = dGgroupe["GroupeCompte", ci].Value.ToString();
            // FP.DesignationGroupe = dGgroupe["DesignationGroupe", ci].Value.ToString();
            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                    chargeementComboCategorie();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    chargeementComboCategorie();
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
                    chargeementComboCategorie();
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormAjoutCategorie FP = new FormAjoutCategorie();
            FP.Text = this.Text;
            FP.CodeCategorie = comboCategorie.Text;
            FP.CodeCategorieDes = comboCategorieDes.Text;
            FP.testeModification = true;
            //FP.DesignationGroupe = comboGroupeDes.Text;
            ///
            // FP.CodeCategorie = comboCat.Text.Trim();

            FP.Text = this.Text;
            // int ci;
            //FP.NumClasse = CodeProjecte;
            //ci = dGgroupe.CurrentRow.Index;
            //FP.GroupeCompte = dGgroupe["GroupeCompte", ci].Value.ToString();
            // FP.DesignationGroupe = dGgroupe["DesignationGroupe", ci].Value.ToString();
            DialogResult Dial = FP.ShowDialog();


            if (Dial == DialogResult.OK)
            {


                try
                {
                    //  chargmentComboArticle();
                    chargeementComboCategorie();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    chargeementComboCategorie();
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

        private void tAchercher_TextChanged(object sender, EventArgs e)
        {
            if (tAchercher.Text.Trim() != "")
            {
                chargemeentDgAchercher();

            }
            else
            {
                chargemnentDgArticle();
            }
        }
    }
}
