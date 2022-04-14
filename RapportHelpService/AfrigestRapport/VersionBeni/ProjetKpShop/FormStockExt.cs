using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1;

namespace GoldenStarApplication
{
    public partial class FormStockExt : Form
    {
        public FormStockExt()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test;// test2;
        String DepotMagasin = "CD1";
        String AchatStock = "601101";
        String GroupeFournisseur, GroupeBonGratuit;
        private String GroupeCaisse, GroupeVente;
        //String Unite;
        Boolean boolAchat, boolAchatBon;
        Boolean TesteModifierDepot, BoolRappelDeDate;
        Double Taux;

        private void FormStockExt_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            bwcharmemntCombo.RunWorkerAsync();
        }

        private void AffichedeStockage()
        {

            boolAchat = rBStockageAchat.Checked;
            boolAchatBon = rBStockageOffre.Checked;
            ChargmenComboCompte();
            ChargementCombo(CbFournisseur, comboCompteFournisseur, comboFournisseur);
        }

        DataTable CbGroupe, cbSougroupe, CbCat;

        private void dGsousGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string GroudeCompteselonIndicateur(int indicateur)
        {


            string compte;
            con = new SqlConnection();
            con.ConnectionString = ClassVaribleGolbal.seteconnexion;
            con.Open();
            cmd = new SqlCommand();
            string s = " SELECT  GroupeCompte FROM tGroupeCompte WHERE (Indicateur =@a) ";
            cmd.Connection = con;
            cmd.CommandText = s;
            cmd.Parameters.AddWithValue("@a", indicateur);
            //cmd.Parameters.AddWithValue("@b", sevice);
            //SqlDataReader lire;
            try
            {
                compte = cmd.ExecuteScalar().ToString();

            }
            catch
            {
                compte = "0";
            }

            return compte;


            cmd.Dispose();
            con.Close();

        }
        DataTable CbGroupe2, CbGroupe3, CbFournisseur, TableCategorieDp;
        private void ChargmenComboCompte()
        {
            try
            {

                string sCompte2;
                String Scate = " SELECT        CodeCategorieDepot, DesignationCatDepot  FROM            tCategoriDepot";
                string sCompte = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
" FROM tCompte INNER JOIN " +
" tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
" WHERE(tGroupeCompte.Cadre = 31) " +
" ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                string sCagorie = " SELECT        CodeCategorieDepot, DesignationCatDepot FROM            tCategoriDepot WHERE        (CodeCategorieDepot <> 1) ";


                if (cBinitiql.Checked == true)
                {
                    sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                  " FROM tCompte INNER JOIN " +
                  " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                  "  " +
                  " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre ";

                }
                else
                {
                    if (boolAchatBon == true)
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE(tGroupeCompte.GroupeCompte =" + GroupeBonGratuit + ") " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";

                    }

                    else
                    {
                        sCompte2 = " SELECT tCompte.NumCompte, tCompte.DesignationCompte, tCompte.Ordre ,tCompte.Variation" +
                 " FROM tCompte INNER JOIN " +
                 " tGroupeCompte ON tCompte.GroupeCompte = tGroupeCompte.GroupeCompte " +
                 " WHERE(tGroupeCompte.GroupeCompte= " + GroupeFournisseur + " ) " +
                 " ORDER BY tCompte.Ordre, tGroupeCompte.Cadre DESC";


                    }


                }



                string[] r = { "" };
                string[] r3 = { };
                ClassRequette classeReq = new ClassRequette();

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe = classeReq.dt;

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe2 = classeReq.dt;

                classeReq.chargementAvecLesParametre(sCompte, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbGroupe3 = classeReq.dt;

                // CbFournisseur
                classeReq.chargementAvecLesParametre(sCompte2, ClassVaribleGolbal.seteconnexion, "tOption", r);
                CbFournisseur = classeReq.dt;
                //
                classeReq.chargementAvecLesParametre(sCagorie, ClassVaribleGolbal.seteconnexion, "tOption", r);
                TableCategorieDp = classeReq.dt;








            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);

            }



            //  da.Dispose();
        }

        private void ChargementCombo(DataTable t1, ComboBox id, ComboBox des)
        {


            des.DataSource = t1;

            id.DataSource = t1;
            id.DisplayMember = "NumCompte";
            id.ValueMember = "NumCompte";
            des.ValueMember = "NumCompte";
            des.DisplayMember = "DesignationCompte";

        }

        private void rBStockageAchat_CheckedChanged(object sender, EventArgs e)
        {
            AffichedeStockage();
        }

        private void bwcharmemntCombo_DoWork(object sender, DoWorkEventArgs e)
        {
            GroupeFournisseur = GroudeCompteselonIndicateur(400);
            GroupeBonGratuit = GroudeCompteselonIndicateur(470);
            ChargmenComboCompte();
           // ChargmentDepot();
        }

        private void bwcharmemntCombo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                

                ChargementCombo(CbGroupe3, comboCompteStock, comboStockDes);
               // ChargementCombo(CbGroupe3, comboCompteStockInv, comboStockDesInv);
                ChargementCombo(CbFournisseur, comboCompteFournisseur, comboFournisseur);
              //  ChargementCombo(CbGroupe2, comboCompteDestockage, combooDestockageDES);
               // ChargementComboDepot(tableDepot, comboDepot, comboDepotDes);
                //ChargementComboDepot(tableDepot, comboCodeDepot2, comboDepoDES2);
                //comboCompte.DataSource = CbGroupe;
                //comboCompte.DisplayMember = "NumCompte";
                //comboCompte.ValueMember = "NumCompte";

                //comboDEsegnationCompte.DataSource = CbGroupe;
                //comboDEsegnationCompte.DisplayMember = "DesignationCompte";
                //comboDEsegnationCompte.ValueMember = "NumCompte";

                //comboCatDepot.DataSource = TableCategorieDp;
                //comboCatDepot.DisplayMember = "DesignationCatDepot";
                //comboCatDepot.ValueMember = "CodeCategorieDepot";

                //comboTypeDepot.DataSource = TableCategorieDp;
                //comboTypeDepot.DisplayMember = "DesignationCatDepot";
                //comboTypeDepot.ValueMember = "CodeCategorieDepot";
                ////DesignationCatClirntEmb
                //DrnierOP();
                //tCodeDP.Text = fonctionOPdepot();
                //tNumService.Text = NumService;


            }













            catch (Exception ex)
            {

                // lmessage.Text = ex.Message;

            }
        }

    }
}
