using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using WindowsFormsApplication1;

namespace GoldenStarApplication
{
    public partial class FormBackUP : Form
    {
        public FormBackUP()
        {
            InitializeComponent();
        }

        DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);

        private static Server srvr;
        ServerConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {

            //Data Source=DISTRIBUTION;Initial Catalog=BaseGestionBrasimba;Integrated Security=false ;User ID=MANDAL; Password =12345678
           // ServerConnection srvConn = new ServerConnection("DISTRIBUTION", "MANDAL", "12345678");
            ServerConnection srvConn = new ServerConnection("DESKTOP-6LF9CSG", "ISHANGO", "12345678");
            //DESKTOP-6LF9CSG
            srvConn.LoginSecure = false;
           // srvConn.Login = "User ID=MANDAL";
            Server srvr = new Server(srvConn);
            foreach (Database dbServer in srvr.Databases)
            {
                cmbDataBase.Items.Add(dbServer.Name);
                //cmbDataBase.Text = srvr.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

             Backup bkp = new Backup();
            conn = new ServerConnection();
            srvr = new Server(conn);
            try
            {
                string databaseName = cmbDataBase.Text;
                bkp.Action = BackupActionType.Database;
                bkp.Database = databaseName;
                string path;
                if (!(txtPath.Text.EndsWith("\\")))
                {
                    path = txtPath.Text + "\\";
                }
                else
                {
                    path = txtPath.Text; 
               }
                BackupDeviceItem bkpDevice = new BackupDeviceItem(path + databaseName + ".bak", DeviceType.File);

                bkp.Devices.Add(bkpDevice);
                bkp.Incremental = false;
                bkp.SqlBackup(srvr);
                MessageBox.Show("Database Backup created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = false;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                txtPath.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }
    }

        }
    
