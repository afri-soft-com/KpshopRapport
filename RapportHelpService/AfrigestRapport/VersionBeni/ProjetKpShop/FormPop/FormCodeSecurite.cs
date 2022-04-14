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

namespace GoldenStarApplication.FormPop
{
    public partial class FormCodeSecurite : Form
    {
        public FormCodeSecurite()
        {
            InitializeComponent();
        }
      
        private void FormCodeSecurite_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClassVaribleGolbal.codeINSRE = tCodeSecret.Text.Trim();
           
        }
    }
}
