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
    public partial class FormGerance : Form
    {
        public FormGerance()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public SqlCommand cmd;
        public String utilisateur, libeleOP;
        Boolean test, test2;

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (tdateAlancer.Value > ClassVaribleGolbal.DateCloturer)
                {
                    string s = "UPDATE       tParametreGeneraux SET TauxFc=@a,  DateActuelle =@da   ";
                    string[] r = { tTaux.Text };
                    DateTime[] d = { DateTime.Parse(tdateAlancer.Text) };

                    ClassRequette req = new ClassRequette();
                    req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                    //  DernierOP();
                    ClassVaribleGolbal.DateDuJOUR = tdateAlancer.Value;
                    ClassVaribleGolbal.TauxFc = double.Parse(tTaux.Text);
                    this.Close();
                }
                else
                {

                    MessageBox.Show("CETTE DATE EST DEJA CLOTURER");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RES = MessageBox.Show("VOULEZ VOUS VRAIMENT VOUS CLURER CETTE DATE? ", "CLOTURE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RES == DialogResult.Yes)
                {

                    if (tDaActurer.Value >= ClassVaribleGolbal.DateCloturer)
                    {
                        string s = "UPDATE       tParametreGeneraux SET  DateCluture =@da   ";
                        string[] r = { tTaux.Text };
                        DateTime[] d = { DateTime.Parse(tDaActurer.Text) };

                        ClassRequette req = new ClassRequette();
                        req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                        //  DernierOP();
                        ClassVaribleGolbal.DateCloturer = tDaActurer.Value;
                      
                       // MessageBox.Show ()
                    }
                    else
                    {

                        MessageBox.Show("CETTE DATE EST DEJA CLOTURER");
                    }

                }
            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string s = "UPDATE       tParametreGeneraux SET TauxFc=@a,TauxTrans=@b ,FraisdeTransProduit=@c,FraisdeTransEmbllage=@d  ";
                string[] r = { tTaux.Text, TauxDeTransport.Text,tFraisdeTransProduit.Text,tFraisdeTransEmbllage.Text };
                DateTime[] d = { DateTime.Parse(tdateAlancer.Text) };

                ClassRequette req = new ClassRequette();
                req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
                //  DernierOP();
               // ClassVaribleGolbal.DateDuJOUR = tdateAlancer.Value;
                ClassVaribleGolbal.TauxFc = double.Parse(tTaux.Text);
                ClassVaribleGolbal.TauxTrans = double.Parse(TauxDeTransport.Text);
                ClassVaribleGolbal.FraisdeTransProduit = double.Parse(tFraisdeTransProduit.Text);
                ClassVaribleGolbal.FraisdeTransEmbllage = double.Parse(tFraisdeTransEmbllage.Text);

                this.Close();




            }

            catch ( Exception ex )
            {
                

            }
           

        }

        private void FormGerance_Load(object sender, EventArgs e)
        {
            tDaActurer.Value = ClassVaribleGolbal.DateCloturer;
            tdateAlancer.Value = ClassVaribleGolbal.DateDuJOUR;
            tTaux.Text = ClassVaribleGolbal.TauxFc.ToString();
            TauxDeTransport.Text = ClassVaribleGolbal.TauxTrans.ToString();
            tFraisdeTransProduit.Text = ClassVaribleGolbal.FraisdeTransProduit.ToString();
            tFraisdeTransEmbllage.Text = ClassVaribleGolbal.FraisdeTransEmbllage.ToString();
        }

        private void Connection_Data()
        {
            con = new SqlConnection(ClassVaribleGolbal.seteconnexion);
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt = new DataTable();
        }

    }
}
