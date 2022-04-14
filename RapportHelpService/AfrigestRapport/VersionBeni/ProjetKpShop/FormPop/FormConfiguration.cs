using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication1;

namespace GoldenStarApplication.FormPop
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            try
            {

                tNomServeur.Text = LireLeCheminActuel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string LireLeCheminActuel()
        {
            StreamReader SR = File.OpenText("MonServeur.txt");
            string ligne;
            ligne = SR.ReadLine();

            SR.Close();
            return ligne;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                StreamWriter Sw  =  File.CreateText("MonServeur.txt");
                 Sw.WriteLine(tNomServeur.Text);
                ClassVaribleGolbal.NomServeur=tNomServeur.Text;
                   Sw.Close();
                 MessageBox.Show("ok ");
               
            }

            catch  ( Exception  ex)
            {
             MessageBox.Show(ex.Message);
            }
           
        }
    }
}
