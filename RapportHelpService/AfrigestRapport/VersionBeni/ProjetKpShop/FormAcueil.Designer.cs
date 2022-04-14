namespace GoldenStarApplication
{
    partial class FormAcueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcueil));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.BMLancer = new System.Windows.Forms.Button();
            this.BMquitter = new System.Windows.Forms.Button();
            this.BMconnecter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bmEmballage = new System.Windows.Forms.Button();
            this.BMstock = new System.Windows.Forms.Button();
            this.BMcaisse = new System.Windows.Forms.Button();
            this.BMlogement = new System.Windows.Forms.Button();
            this.BMVente = new System.Windows.Forms.Button();
            this.BMcomptable = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.BMRapportCaisse = new System.Windows.Forms.Button();
            this.BmRapportEMBALLAGE = new System.Windows.Forms.Button();
            this.BMRapportTierc = new System.Windows.Forms.Button();
            this.BMrapportStock = new System.Windows.Forms.Button();
            this.BMrapport2 = new System.Windows.Forms.Button();
            this.BMrapport1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BMajouterUt = new System.Windows.Forms.Button();
            this.BMsupprmmer = new System.Windows.Forms.Button();
            this.BMajouterReceveur = new System.Windows.Forms.Button();
            this.Puser = new System.Windows.Forms.Panel();
            this.cbSMS = new System.Windows.Forms.CheckBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tMotDepasse = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.bCONNECTIION = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bwConnexion = new System.ComponentModel.BackgroundWorker();
            this.progressBarConnnecxion = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lDepartement = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.Puser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 108);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.BMLancer);
            this.tabPage1.Controls.Add(this.BMquitter);
            this.tabPage1.Controls.Add(this.BMconnecter);
            this.tabPage1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       ACUIELL           ";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(570, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "COMMENCER";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // BMLancer
            // 
            this.BMLancer.BackColor = System.Drawing.Color.White;
            this.BMLancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMLancer.Image = ((System.Drawing.Image)(resources.GetObject("BMLancer.Image")));
            this.BMLancer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMLancer.Location = new System.Drawing.Point(334, 6);
            this.BMLancer.Name = "BMLancer";
            this.BMLancer.Size = new System.Drawing.Size(230, 60);
            this.BMLancer.TabIndex = 3;
            this.BMLancer.Text = "LANCER  OU CLUTURER";
            this.BMLancer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMLancer.UseVisualStyleBackColor = false;
            this.BMLancer.Click += new System.EventHandler(this.BMLancer_Click);
            // 
            // BMquitter
            // 
            this.BMquitter.BackColor = System.Drawing.Color.White;
            this.BMquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMquitter.Image = ((System.Drawing.Image)(resources.GetObject("BMquitter.Image")));
            this.BMquitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMquitter.Location = new System.Drawing.Point(172, 6);
            this.BMquitter.Name = "BMquitter";
            this.BMquitter.Size = new System.Drawing.Size(146, 60);
            this.BMquitter.TabIndex = 2;
            this.BMquitter.Text = "QUITTER";
            this.BMquitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMquitter.UseVisualStyleBackColor = false;
            this.BMquitter.Click += new System.EventHandler(this.BMquitter_Click);
            // 
            // BMconnecter
            // 
            this.BMconnecter.BackColor = System.Drawing.Color.White;
            this.BMconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMconnecter.Image = ((System.Drawing.Image)(resources.GetObject("BMconnecter.Image")));
            this.BMconnecter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMconnecter.Location = new System.Drawing.Point(8, 6);
            this.BMconnecter.Name = "BMconnecter";
            this.BMconnecter.Size = new System.Drawing.Size(158, 60);
            this.BMconnecter.TabIndex = 0;
            this.BMconnecter.Text = "SE CONNECTER";
            this.BMconnecter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMconnecter.UseVisualStyleBackColor = false;
            this.BMconnecter.Click += new System.EventHandler(this.BMconnecter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.bmEmballage);
            this.tabPage2.Controls.Add(this.BMstock);
            this.tabPage2.Controls.Add(this.BMcaisse);
            this.tabPage2.Controls.Add(this.BMlogement);
            this.tabPage2.Controls.Add(this.BMVente);
            this.tabPage2.Controls.Add(this.BMcomptable);
            this.tabPage2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "       OPERATION        ";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(990, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 59);
            this.button6.TabIndex = 16;
            this.button6.Text = "EXTERIEUR";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(720, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "SMS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // bmEmballage
            // 
            this.bmEmballage.BackColor = System.Drawing.Color.White;
            this.bmEmballage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmEmballage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmEmballage.Image = ((System.Drawing.Image)(resources.GetObject("bmEmballage.Image")));
            this.bmEmballage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bmEmballage.Location = new System.Drawing.Point(856, 3);
            this.bmEmballage.Name = "bmEmballage";
            this.bmEmballage.Size = new System.Drawing.Size(118, 59);
            this.bmEmballage.TabIndex = 14;
            this.bmEmballage.Text = "EMBALLAGE";
            this.bmEmballage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bmEmballage.UseVisualStyleBackColor = false;
            this.bmEmballage.Visible = false;
            this.bmEmballage.Click += new System.EventHandler(this.button3_Click);
            // 
            // BMstock
            // 
            this.BMstock.BackColor = System.Drawing.Color.White;
            this.BMstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMstock.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMstock.Image = ((System.Drawing.Image)(resources.GetObject("BMstock.Image")));
            this.BMstock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMstock.Location = new System.Drawing.Point(145, 6);
            this.BMstock.Name = "BMstock";
            this.BMstock.Size = new System.Drawing.Size(162, 59);
            this.BMstock.TabIndex = 13;
            this.BMstock.Text = "STOCKS";
            this.BMstock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMstock.UseVisualStyleBackColor = false;
            this.BMstock.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BMcaisse
            // 
            this.BMcaisse.BackColor = System.Drawing.Color.White;
            this.BMcaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMcaisse.Image = ((System.Drawing.Image)(resources.GetObject("BMcaisse.Image")));
            this.BMcaisse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMcaisse.Location = new System.Drawing.Point(890, 5);
            this.BMcaisse.Name = "BMcaisse";
            this.BMcaisse.Size = new System.Drawing.Size(105, 60);
            this.BMcaisse.TabIndex = 7;
            this.BMcaisse.Text = "CAISSE";
            this.BMcaisse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMcaisse.UseVisualStyleBackColor = false;
            this.BMcaisse.Visible = false;
            this.BMcaisse.Click += new System.EventHandler(this.BMcaisse_Click);
            // 
            // BMlogement
            // 
            this.BMlogement.BackColor = System.Drawing.Color.White;
            this.BMlogement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMlogement.Image = ((System.Drawing.Image)(resources.GetObject("BMlogement.Image")));
            this.BMlogement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMlogement.Location = new System.Drawing.Point(870, 9);
            this.BMlogement.Name = "BMlogement";
            this.BMlogement.Size = new System.Drawing.Size(135, 60);
            this.BMlogement.TabIndex = 6;
            this.BMlogement.Text = "RECEPTION";
            this.BMlogement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMlogement.UseVisualStyleBackColor = false;
            this.BMlogement.Visible = false;
            this.BMlogement.Click += new System.EventHandler(this.button5_Click);
            // 
            // BMVente
            // 
            this.BMVente.BackColor = System.Drawing.Color.White;
            this.BMVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMVente.Image = ((System.Drawing.Image)(resources.GetObject("BMVente.Image")));
            this.BMVente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMVente.Location = new System.Drawing.Point(890, 3);
            this.BMVente.Name = "BMVente";
            this.BMVente.Size = new System.Drawing.Size(130, 59);
            this.BMVente.TabIndex = 4;
            this.BMVente.Text = "VENTES";
            this.BMVente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMVente.UseVisualStyleBackColor = false;
            this.BMVente.Visible = false;
            this.BMVente.Click += new System.EventHandler(this.button2_Click);
            // 
            // BMcomptable
            // 
            this.BMcomptable.BackColor = System.Drawing.Color.White;
            this.BMcomptable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMcomptable.Image = ((System.Drawing.Image)(resources.GetObject("BMcomptable.Image")));
            this.BMcomptable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMcomptable.Location = new System.Drawing.Point(8, 6);
            this.BMcomptable.Name = "BMcomptable";
            this.BMcomptable.Size = new System.Drawing.Size(131, 59);
            this.BMcomptable.TabIndex = 3;
            this.BMcomptable.Text = "COMPTABILITE";
            this.BMcomptable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMcomptable.UseVisualStyleBackColor = false;
            this.BMcomptable.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.BMRapportCaisse);
            this.tabPage3.Controls.Add(this.BmRapportEMBALLAGE);
            this.tabPage3.Controls.Add(this.BMRapportTierc);
            this.tabPage3.Controls.Add(this.BMrapportStock);
            this.tabPage3.Controls.Add(this.BMrapport2);
            this.tabPage3.Controls.Add(this.BMrapport1);
            this.tabPage3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1333, 72);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "        RAPPORT       ";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(1009, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "LES CLIENTS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BMRapportCaisse
            // 
            this.BMRapportCaisse.BackColor = System.Drawing.Color.White;
            this.BMRapportCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMRapportCaisse.Image = ((System.Drawing.Image)(resources.GetObject("BMRapportCaisse.Image")));
            this.BMRapportCaisse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMRapportCaisse.Location = new System.Drawing.Point(195, 6);
            this.BMRapportCaisse.Name = "BMRapportCaisse";
            this.BMRapportCaisse.Size = new System.Drawing.Size(156, 60);
            this.BMRapportCaisse.TabIndex = 11;
            this.BMRapportCaisse.Text = "TABLEAU DE BORD";
            this.BMRapportCaisse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMRapportCaisse.UseVisualStyleBackColor = false;
            this.BMRapportCaisse.Click += new System.EventHandler(this.button6_Click);
            // 
            // BmRapportEMBALLAGE
            // 
            this.BmRapportEMBALLAGE.BackColor = System.Drawing.Color.White;
            this.BmRapportEMBALLAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BmRapportEMBALLAGE.Image = ((System.Drawing.Image)(resources.GetObject("BmRapportEMBALLAGE.Image")));
            this.BmRapportEMBALLAGE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BmRapportEMBALLAGE.Location = new System.Drawing.Point(972, 6);
            this.BmRapportEMBALLAGE.Name = "BmRapportEMBALLAGE";
            this.BmRapportEMBALLAGE.Size = new System.Drawing.Size(156, 60);
            this.BmRapportEMBALLAGE.TabIndex = 10;
            this.BmRapportEMBALLAGE.Text = "LES EMBALLAGES";
            this.BmRapportEMBALLAGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BmRapportEMBALLAGE.UseVisualStyleBackColor = false;
            this.BmRapportEMBALLAGE.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // BMRapportTierc
            // 
            this.BMRapportTierc.BackColor = System.Drawing.Color.White;
            this.BMRapportTierc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMRapportTierc.Image = ((System.Drawing.Image)(resources.GetObject("BMRapportTierc.Image")));
            this.BMRapportTierc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMRapportTierc.Location = new System.Drawing.Point(562, 6);
            this.BMRapportTierc.Name = "BMRapportTierc";
            this.BMRapportTierc.Size = new System.Drawing.Size(156, 60);
            this.BMRapportTierc.TabIndex = 9;
            this.BMRapportTierc.Text = "LES TIERS";
            this.BMRapportTierc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMRapportTierc.UseVisualStyleBackColor = false;
            this.BMRapportTierc.Click += new System.EventHandler(this.button1_Click);
            // 
            // BMrapportStock
            // 
            this.BMrapportStock.BackColor = System.Drawing.Color.White;
            this.BMrapportStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMrapportStock.Image = ((System.Drawing.Image)(resources.GetObject("BMrapportStock.Image")));
            this.BMrapportStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMrapportStock.Location = new System.Drawing.Point(357, 6);
            this.BMrapportStock.Name = "BMrapportStock";
            this.BMrapportStock.Size = new System.Drawing.Size(199, 60);
            this.BMrapportStock.TabIndex = 8;
            this.BMrapportStock.Text = "SOMMAIRES DE STOCKS";
            this.BMrapportStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMrapportStock.UseVisualStyleBackColor = false;
            this.BMrapportStock.Click += new System.EventHandler(this.BMrapport3_Click);
            // 
            // BMrapport2
            // 
            this.BMrapport2.BackColor = System.Drawing.Color.White;
            this.BMrapport2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMrapport2.Image = ((System.Drawing.Image)(resources.GetObject("BMrapport2.Image")));
            this.BMrapport2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMrapport2.Location = new System.Drawing.Point(724, 6);
            this.BMrapport2.Name = "BMrapport2";
            this.BMrapport2.Size = new System.Drawing.Size(211, 60);
            this.BMrapport2.TabIndex = 7;
            this.BMrapport2.Text = "LES CHARGES ET DEPENSES";
            this.BMrapport2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMrapport2.UseVisualStyleBackColor = false;
            this.BMrapport2.Click += new System.EventHandler(this.BMrapport2_Click);
            // 
            // BMrapport1
            // 
            this.BMrapport1.BackColor = System.Drawing.Color.White;
            this.BMrapport1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMrapport1.Image = ((System.Drawing.Image)(resources.GetObject("BMrapport1.Image")));
            this.BMrapport1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMrapport1.Location = new System.Drawing.Point(6, 6);
            this.BMrapport1.Name = "BMrapport1";
            this.BMrapport1.Size = new System.Drawing.Size(183, 60);
            this.BMrapport1.TabIndex = 6;
            this.BMrapport1.Text = "LA BALANCE";
            this.BMrapport1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMrapport1.UseVisualStyleBackColor = false;
            this.BMrapport1.Click += new System.EventHandler(this.BMrapport1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.BMajouterUt);
            this.tabPage4.Controls.Add(this.BMsupprmmer);
            this.tabPage4.Controls.Add(this.BMajouterReceveur);
            this.tabPage4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1333, 72);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "       PARAMETRES      ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(570, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "SERVEUR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(1077, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "MODIFIER LE TAUX  RISTURNE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(376, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACKUP";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BMajouterUt
            // 
            this.BMajouterUt.BackColor = System.Drawing.Color.White;
            this.BMajouterUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMajouterUt.Image = ((System.Drawing.Image)(resources.GetObject("BMajouterUt.Image")));
            this.BMajouterUt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMajouterUt.Location = new System.Drawing.Point(188, 6);
            this.BMajouterUt.Name = "BMajouterUt";
            this.BMajouterUt.Size = new System.Drawing.Size(167, 60);
            this.BMajouterUt.TabIndex = 3;
            this.BMajouterUt.Text = "AJOUTER UTILISATEUR";
            this.BMajouterUt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMajouterUt.UseVisualStyleBackColor = false;
            this.BMajouterUt.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // BMsupprmmer
            // 
            this.BMsupprmmer.BackColor = System.Drawing.Color.White;
            this.BMsupprmmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMsupprmmer.Image = ((System.Drawing.Image)(resources.GetObject("BMsupprmmer.Image")));
            this.BMsupprmmer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMsupprmmer.Location = new System.Drawing.Point(8, 6);
            this.BMsupprmmer.Name = "BMsupprmmer";
            this.BMsupprmmer.Size = new System.Drawing.Size(167, 60);
            this.BMsupprmmer.TabIndex = 2;
            this.BMsupprmmer.Text = "SUPPRIMER L\'OPERATION";
            this.BMsupprmmer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMsupprmmer.UseVisualStyleBackColor = false;
            this.BMsupprmmer.Click += new System.EventHandler(this.BMsupprmmer_Click);
            // 
            // BMajouterReceveur
            // 
            this.BMajouterReceveur.BackColor = System.Drawing.Color.White;
            this.BMajouterReceveur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMajouterReceveur.Image = ((System.Drawing.Image)(resources.GetObject("BMajouterReceveur.Image")));
            this.BMajouterReceveur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMajouterReceveur.Location = new System.Drawing.Point(1009, 12);
            this.BMajouterReceveur.Name = "BMajouterReceveur";
            this.BMajouterReceveur.Size = new System.Drawing.Size(167, 60);
            this.BMajouterReceveur.TabIndex = 1;
            this.BMajouterReceveur.Text = "AJOUTER UN RECEVEUR";
            this.BMajouterReceveur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BMajouterReceveur.UseVisualStyleBackColor = false;
            this.BMajouterReceveur.Visible = false;
            this.BMajouterReceveur.Click += new System.EventHandler(this.BMajouter_Click);
            // 
            // Puser
            // 
            this.Puser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Puser.Controls.Add(this.cbSMS);
            this.Puser.Controls.Add(this.tUser);
            this.Puser.Controls.Add(this.tMotDepasse);
            this.Puser.Controls.Add(this.button9);
            this.Puser.Controls.Add(this.bCONNECTIION);
            this.Puser.Controls.Add(this.labe);
            this.Puser.Controls.Add(this.label1);
            this.Puser.Controls.Add(this.pictureBox1);
            this.Puser.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puser.Location = new System.Drawing.Point(229, 130);
            this.Puser.Name = "Puser";
            this.Puser.Size = new System.Drawing.Size(512, 168);
            this.Puser.TabIndex = 2;
            // 
            // cbSMS
            // 
            this.cbSMS.AutoSize = true;
            this.cbSMS.Location = new System.Drawing.Point(151, 145);
            this.cbSMS.Name = "cbSMS";
            this.cbSMS.Size = new System.Drawing.Size(92, 19);
            this.cbSMS.TabIndex = 7;
            this.cbSMS.Text = "MODE SMS";
            this.cbSMS.UseVisualStyleBackColor = true;
            this.cbSMS.CheckedChanged += new System.EventHandler(this.cbSMS_CheckedChanged);
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(250, 38);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(234, 23);
            this.tUser.TabIndex = 6;
            // 
            // tMotDepasse
            // 
            this.tMotDepasse.Location = new System.Drawing.Point(250, 66);
            this.tMotDepasse.Name = "tMotDepasse";
            this.tMotDepasse.PasswordChar = 'X';
            this.tMotDepasse.Size = new System.Drawing.Size(234, 23);
            this.tMotDepasse.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LemonChiffon;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(363, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 45);
            this.button9.TabIndex = 4;
            this.button9.Text = "SE DECONNECTER";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // bCONNECTIION
            // 
            this.bCONNECTIION.BackColor = System.Drawing.Color.LemonChiffon;
            this.bCONNECTIION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCONNECTIION.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCONNECTIION.Location = new System.Drawing.Point(250, 95);
            this.bCONNECTIION.Name = "bCONNECTIION";
            this.bCONNECTIION.Size = new System.Drawing.Size(107, 45);
            this.bCONNECTIION.TabIndex = 3;
            this.bCONNECTIION.Text = "CONNECTER";
            this.bCONNECTIION.UseVisualStyleBackColor = false;
            this.bCONNECTIION.Click += new System.EventHandler(this.bCONNECTIION_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(133, 69);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(99, 15);
            this.labe.TabIndex = 2;
            this.labe.Text = "MOT DE PASSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "UTILISATEUR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bwConnexion
            // 
            this.bwConnexion.WorkerReportsProgress = true;
            this.bwConnexion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnexion_DoWork);
            this.bwConnexion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwConnexion_ProgressChanged);
            this.bwConnexion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwConnexion_RunWorkerCompleted);
            // 
            // progressBarConnnecxion
            // 
            this.progressBarConnnecxion.Location = new System.Drawing.Point(229, 111);
            this.progressBarConnnecxion.Name = "progressBarConnnecxion";
            this.progressBarConnnecxion.Size = new System.Drawing.Size(512, 23);
            this.progressBarConnnecxion.TabIndex = 4;
            this.progressBarConnnecxion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conception et Réalisation :  AFRI-SOFT  : www.afri-soft.com  ";
            // 
            // lDepartement
            // 
            this.lDepartement.AutoSize = true;
            this.lDepartement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDepartement.Location = new System.Drawing.Point(1, 107);
            this.lDepartement.Name = "lDepartement";
            this.lDepartement.Size = new System.Drawing.Size(68, 13);
            this.lDepartement.TabIndex = 8;
            this.lDepartement.Text = "Departement";
            // 
            // FormAcueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 544);
            this.Controls.Add(this.lDepartement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarConnnecxion);
            this.Controls.Add(this.Puser);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FormAcueil";
            this.Text = "AFRISOSFT -RAPPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.Puser.ResumeLayout(false);
            this.Puser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BMconnecter;
        private System.Windows.Forms.Button BMquitter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BMlogement;
        private System.Windows.Forms.Button BMVente;
        private System.Windows.Forms.Button BMcomptable;
        private System.Windows.Forms.Button BMajouterReceveur;
        private System.Windows.Forms.Panel Puser;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tMotDepasse;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bCONNECTIION;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bwConnexion;
        private System.Windows.Forms.ProgressBar progressBarConnnecxion;
        private System.Windows.Forms.Button BMLancer;
        private System.Windows.Forms.Button BMrapportStock;
        private System.Windows.Forms.Button BMrapport2;
        private System.Windows.Forms.Button BMrapport1;
        private System.Windows.Forms.Button BMsupprmmer;
        private System.Windows.Forms.Button BMcaisse;
        private System.Windows.Forms.Button BMRapportTierc;
        private System.Windows.Forms.Button BMstock;
        private System.Windows.Forms.Button bmEmballage;
        private System.Windows.Forms.Button BMajouterUt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BmRapportEMBALLAGE;
        private System.Windows.Forms.Button BMRapportCaisse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbSMS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lDepartement;
        private System.Windows.Forms.Button button7;
    }
}

