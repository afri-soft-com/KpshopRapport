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
    public partial class FormPopCategorieAticle : Form
    {
        public FormPopCategorieAticle()
        {
            InitializeComponent();
        }

        private void FormPopCategorieAticle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "INSERT INTO tCatArticle  ( DesCategorieA) values (@a)";
            string[] r = { tDesignation.Text };
            DateTime[] d = {  DateTime.Now };

            ClassRequette req = new ClassRequette();
            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);
            // lmessage.Text = "&  Enregistrement effectué avec succès &";
            // chargemeentDgELEVE();
        }
    }
}
