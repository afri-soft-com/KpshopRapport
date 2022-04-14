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

namespace GoldenStarApplication.FormPop
{
    public partial class FormInsertion : Form
    {
        public FormInsertion()
        {
            InitializeComponent();
        }

        public int typeMotif;
        public Boolean BoollMotif, BollAgent;

        private void FormInsertion_Load(object sender, EventArgs e)
        {

        }


        private void insererMotif(string element, string id)
        {
            string Scumule = " INSERT  INTO  tMotif  (DesMotif,TypeMotif) VALUES (@a,@b) ";
            string[] para = new[] { element, id };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }


        private void insererAgent(string element)
        {
            string Scumule = " INSERT  INTO  tAgent  (Noms) VALUES (@a) ";
            string[] para = new[] { element };
            DateTime[] pd = new[] { ClassVaribleGolbal.DateDuJOUR };
            ClassRequette reqette = new ClassRequette();
            reqette.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, Scumule, para, pd);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoollMotif == true)
            {

                insererMotif(telement.Text, typeMotif.ToString());
            }

            else if (BollAgent == true)
            {

                insererAgent(telement.Text);

            }
        }


    }
}
