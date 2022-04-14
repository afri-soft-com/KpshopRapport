namespace GoldenStarApplication
{
    partial class FormStockExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockExt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rBStockageAutreAchat = new System.Windows.Forms.RadioButton();
            this.rBStockageOffre = new System.Windows.Forms.RadioButton();
            this.rBStockageAchat = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.typeOP = new System.Windows.Forms.ComboBox();
            this.tLibelle = new System.Windows.Forms.TextBox();
            this.pCommande = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cBinitiql = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboCompteFournisseur = new System.Windows.Forms.ComboBox();
            this.comboFournisseur = new System.Windows.Forms.ComboBox();
            this.comboCodeArticleStockDes = new System.Windows.Forms.ComboBox();
            this.comboCodeArticleStock = new System.Windows.Forms.ComboBox();
            this.comboSCatStokDes = new System.Windows.Forms.ComboBox();
            this.comboStockDes = new System.Windows.Forms.ComboBox();
            this.comboCompteStock = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboTypeStock = new System.Windows.Forms.ComboBox();
            this.button18 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.tQteApro = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tSommeFact = new System.Windows.Forms.TextBox();
            this.CbSereferer = new System.Windows.Forms.CheckBox();
            this.tVariariotion = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.bValiderAchat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tAgros = new System.Windows.Forms.TextBox();
            this.cBenGros = new System.Windows.Forms.CheckBox();
            this.CBcdf = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tQteEntree = new System.Windows.Forms.TextBox();
            this.tQtePu = new System.Windows.Forms.TextBox();
            this.tTotalStock = new System.Windows.Forms.TextBox();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pCommande.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 36);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    STOCK EXTERIEUR       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.panel16);
            this.tabPage2.Controls.Add(this.CbSereferer);
            this.tabPage2.Controls.Add(this.tVariariotion);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.bValiderAchat);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.pCommande);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.rBStockageAutreAchat);
            this.panel6.Controls.Add(this.rBStockageOffre);
            this.panel6.Controls.Add(this.rBStockageAchat);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.typeOP);
            this.panel6.Controls.Add(this.tLibelle);
            this.panel6.Location = new System.Drawing.Point(8, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 93);
            this.panel6.TabIndex = 19;
            // 
            // rBStockageAutreAchat
            // 
            this.rBStockageAutreAchat.AutoSize = true;
            this.rBStockageAutreAchat.Location = new System.Drawing.Point(309, 3);
            this.rBStockageAutreAchat.Name = "rBStockageAutreAchat";
            this.rBStockageAutreAchat.Size = new System.Drawing.Size(69, 17);
            this.rBStockageAutreAchat.TabIndex = 33;
            this.rBStockageAutreAchat.TabStop = true;
            this.rBStockageAutreAchat.Text = "AUTRES";
            this.rBStockageAutreAchat.UseVisualStyleBackColor = true;
            // 
            // rBStockageOffre
            // 
            this.rBStockageOffre.AutoSize = true;
            this.rBStockageOffre.Location = new System.Drawing.Point(141, 3);
            this.rBStockageOffre.Name = "rBStockageOffre";
            this.rBStockageOffre.Size = new System.Drawing.Size(111, 17);
            this.rBStockageOffre.TabIndex = 32;
            this.rBStockageOffre.TabStop = true;
            this.rBStockageOffre.Text = "OFFRE  OU BON ";
            this.rBStockageOffre.UseVisualStyleBackColor = true;
            // 
            // rBStockageAchat
            // 
            this.rBStockageAchat.AutoSize = true;
            this.rBStockageAchat.Location = new System.Drawing.Point(26, 3);
            this.rBStockageAchat.Name = "rBStockageAchat";
            this.rBStockageAchat.Size = new System.Drawing.Size(61, 17);
            this.rBStockageAchat.TabIndex = 31;
            this.rBStockageAchat.TabStop = true;
            this.rBStockageAchat.Text = "ACHAT";
            this.rBStockageAchat.UseVisualStyleBackColor = true;
            this.rBStockageAchat.CheckedChanged += new System.EventHandler(this.rBStockageAchat_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "LIBELLE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "TYPE DE L\'OPERATION";
            // 
            // typeOP
            // 
            this.typeOP.FormattingEnabled = true;
            this.typeOP.Items.AddRange(new object[] {
            "APPROVISIONNEMENT"});
            this.typeOP.Location = new System.Drawing.Point(179, 27);
            this.typeOP.Name = "typeOP";
            this.typeOP.Size = new System.Drawing.Size(238, 21);
            this.typeOP.TabIndex = 28;
            // 
            // tLibelle
            // 
            this.tLibelle.Location = new System.Drawing.Point(179, 50);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(240, 40);
            this.tLibelle.TabIndex = 27;
            // 
            // pCommande
            // 
            this.pCommande.BackColor = System.Drawing.Color.Khaki;
            this.pCommande.Controls.Add(this.button17);
            this.pCommande.Controls.Add(this.label8);
            this.pCommande.Controls.Add(this.cBinitiql);
            this.pCommande.Controls.Add(this.label29);
            this.pCommande.Controls.Add(this.comboCompteFournisseur);
            this.pCommande.Controls.Add(this.comboFournisseur);
            this.pCommande.Controls.Add(this.comboCodeArticleStockDes);
            this.pCommande.Controls.Add(this.comboCodeArticleStock);
            this.pCommande.Controls.Add(this.comboSCatStokDes);
            this.pCommande.Controls.Add(this.comboStockDes);
            this.pCommande.Controls.Add(this.comboCompteStock);
            this.pCommande.Controls.Add(this.label10);
            this.pCommande.Controls.Add(this.label9);
            this.pCommande.Controls.Add(this.comboTypeStock);
            this.pCommande.Location = new System.Drawing.Point(8, 114);
            this.pCommande.Name = "pCommande";
            this.pCommande.Size = new System.Drawing.Size(459, 169);
            this.pCommande.TabIndex = 20;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(205, 84);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(240, 49);
            this.button17.TabIndex = 33;
            this.button17.Text = "COMPLETER LA COMMANDE";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "GROUPE";
            // 
            // cBinitiql
            // 
            this.cBinitiql.AutoSize = true;
            this.cBinitiql.Location = new System.Drawing.Point(17, 3);
            this.cBinitiql.Name = "cBinitiql";
            this.cBinitiql.Size = new System.Drawing.Size(70, 17);
            this.cBinitiql.TabIndex = 32;
            this.cBinitiql.Text = "AUTRES";
            this.cBinitiql.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(18, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 16);
            this.label29.TabIndex = 31;
            this.label29.Text = "FOURNISSEUR";
            // 
            // comboCompteFournisseur
            // 
            this.comboCompteFournisseur.FormattingEnabled = true;
            this.comboCompteFournisseur.Location = new System.Drawing.Point(126, 21);
            this.comboCompteFournisseur.Name = "comboCompteFournisseur";
            this.comboCompteFournisseur.Size = new System.Drawing.Size(73, 21);
            this.comboCompteFournisseur.TabIndex = 30;
            // 
            // comboFournisseur
            // 
            this.comboFournisseur.FormattingEnabled = true;
            this.comboFournisseur.Location = new System.Drawing.Point(205, 20);
            this.comboFournisseur.Name = "comboFournisseur";
            this.comboFournisseur.Size = new System.Drawing.Size(244, 21);
            this.comboFournisseur.TabIndex = 29;
            // 
            // comboCodeArticleStockDes
            // 
            this.comboCodeArticleStockDes.FormattingEnabled = true;
            this.comboCodeArticleStockDes.Location = new System.Drawing.Point(17, 111);
            this.comboCodeArticleStockDes.Name = "comboCodeArticleStockDes";
            this.comboCodeArticleStockDes.Size = new System.Drawing.Size(60, 21);
            this.comboCodeArticleStockDes.TabIndex = 12;
            this.comboCodeArticleStockDes.Visible = false;
            // 
            // comboCodeArticleStock
            // 
            this.comboCodeArticleStock.FormattingEnabled = true;
            this.comboCodeArticleStock.Location = new System.Drawing.Point(26, 118);
            this.comboCodeArticleStock.Name = "comboCodeArticleStock";
            this.comboCodeArticleStock.Size = new System.Drawing.Size(38, 21);
            this.comboCodeArticleStock.TabIndex = 11;
            this.comboCodeArticleStock.Visible = false;
            // 
            // comboSCatStokDes
            // 
            this.comboSCatStokDes.FormattingEnabled = true;
            this.comboSCatStokDes.Location = new System.Drawing.Point(17, 118);
            this.comboSCatStokDes.Name = "comboSCatStokDes";
            this.comboSCatStokDes.Size = new System.Drawing.Size(32, 21);
            this.comboSCatStokDes.TabIndex = 10;
            this.comboSCatStokDes.Visible = false;
            // 
            // comboStockDes
            // 
            this.comboStockDes.FormattingEnabled = true;
            this.comboStockDes.Location = new System.Drawing.Point(207, 53);
            this.comboStockDes.Name = "comboStockDes";
            this.comboStockDes.Size = new System.Drawing.Size(242, 21);
            this.comboStockDes.TabIndex = 8;
            // 
            // comboCompteStock
            // 
            this.comboCompteStock.FormattingEnabled = true;
            this.comboCompteStock.Location = new System.Drawing.Point(126, 53);
            this.comboCompteStock.Name = "comboCompteStock";
            this.comboCompteStock.Size = new System.Drawing.Size(75, 21);
            this.comboCompteStock.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "ARTICLE";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "TYPE";
            this.label9.Visible = false;
            // 
            // comboTypeStock
            // 
            this.comboTypeStock.FormattingEnabled = true;
            this.comboTypeStock.Location = new System.Drawing.Point(26, 103);
            this.comboTypeStock.Name = "comboTypeStock";
            this.comboTypeStock.Size = new System.Drawing.Size(58, 21);
            this.comboTypeStock.TabIndex = 9;
            this.comboTypeStock.Visible = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(87, 384);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(133, 53);
            this.button18.TabIndex = 37;
            this.button18.Text = "NOUVEAU";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Khaki;
            this.panel16.Controls.Add(this.label42);
            this.panel16.Controls.Add(this.tQteApro);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Controls.Add(this.tSommeFact);
            this.panel16.Location = new System.Drawing.Point(8, 308);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(459, 50);
            this.panel16.TabIndex = 36;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(317, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(29, 13);
            this.label42.TabIndex = 47;
            this.label42.Text = "QTE";
            // 
            // tQteApro
            // 
            this.tQteApro.Location = new System.Drawing.Point(317, 27);
            this.tQteApro.Name = "tQteApro";
            this.tQteApro.Size = new System.Drawing.Size(139, 20);
            this.tQteApro.TabIndex = 46;
            this.tQteApro.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(85, 10);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(42, 13);
            this.label45.TabIndex = 45;
            this.label45.Text = "TOTAL";
            // 
            // tSommeFact
            // 
            this.tSommeFact.Location = new System.Drawing.Point(88, 27);
            this.tSommeFact.Name = "tSommeFact";
            this.tSommeFact.Size = new System.Drawing.Size(197, 20);
            this.tSommeFact.TabIndex = 44;
            this.tSommeFact.Text = "0";
            // 
            // CbSereferer
            // 
            this.CbSereferer.AutoSize = true;
            this.CbSereferer.Location = new System.Drawing.Point(111, 443);
            this.CbSereferer.Name = "CbSereferer";
            this.CbSereferer.Size = new System.Drawing.Size(86, 17);
            this.CbSereferer.TabIndex = 35;
            this.CbSereferer.Text = "SE REFERE";
            this.CbSereferer.UseVisualStyleBackColor = true;
            this.CbSereferer.Visible = false;
            // 
            // tVariariotion
            // 
            this.tVariariotion.Location = new System.Drawing.Point(328, 285);
            this.tVariariotion.Name = "tVariariotion";
            this.tVariariotion.ReadOnly = true;
            this.tVariariotion.Size = new System.Drawing.Size(131, 20);
            this.tVariariotion.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(235, 286);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 16);
            this.label28.TabIndex = 33;
            this.label28.Text = "VARIATION";
            // 
            // bValiderAchat
            // 
            this.bValiderAchat.BackColor = System.Drawing.Color.White;
            this.bValiderAchat.Enabled = false;
            this.bValiderAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bValiderAchat.Image = ((System.Drawing.Image)(resources.GetObject("bValiderAchat.Image")));
            this.bValiderAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bValiderAchat.Location = new System.Drawing.Point(226, 384);
            this.bValiderAchat.Name = "bValiderAchat";
            this.bValiderAchat.Size = new System.Drawing.Size(139, 51);
            this.bValiderAchat.TabIndex = 32;
            this.bValiderAchat.Text = "VALIDER";
            this.bValiderAchat.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Controls.Add(this.tAgros);
            this.panel5.Controls.Add(this.cBenGros);
            this.panel5.Controls.Add(this.CBcdf);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.tQteEntree);
            this.panel5.Controls.Add(this.tQtePu);
            this.panel5.Controls.Add(this.tTotalStock);
            this.panel5.Location = new System.Drawing.Point(299, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 25);
            this.panel5.TabIndex = 31;
            this.panel5.Visible = false;
            // 
            // tAgros
            // 
            this.tAgros.Location = new System.Drawing.Point(311, 13);
            this.tAgros.Name = "tAgros";
            this.tAgros.Size = new System.Drawing.Size(88, 20);
            this.tAgros.TabIndex = 26;
            // 
            // cBenGros
            // 
            this.cBenGros.AutoSize = true;
            this.cBenGros.Location = new System.Drawing.Point(233, 15);
            this.cBenGros.Name = "cBenGros";
            this.cBenGros.Size = new System.Drawing.Size(75, 17);
            this.cBenGros.TabIndex = 25;
            this.cBenGros.Text = "EN GROS";
            this.cBenGros.UseVisualStyleBackColor = true;
            // 
            // CBcdf
            // 
            this.CBcdf.AutoSize = true;
            this.CBcdf.Location = new System.Drawing.Point(311, 39);
            this.CBcdf.Name = "CBcdf";
            this.CBcdf.Size = new System.Drawing.Size(66, 17);
            this.CBcdf.TabIndex = 24;
            this.CBcdf.Text = "PAR PU";
            this.CBcdf.UseVisualStyleBackColor = true;
            this.CBcdf.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "TOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "QTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "PU";
            // 
            // tQteEntree
            // 
            this.tQteEntree.Location = new System.Drawing.Point(103, 13);
            this.tQteEntree.Name = "tQteEntree";
            this.tQteEntree.Size = new System.Drawing.Size(106, 20);
            this.tQteEntree.TabIndex = 13;
            // 
            // tQtePu
            // 
            this.tQtePu.Location = new System.Drawing.Point(103, 39);
            this.tQtePu.Name = "tQtePu";
            this.tQtePu.Size = new System.Drawing.Size(202, 20);
            this.tQtePu.TabIndex = 15;
            // 
            // tTotalStock
            // 
            this.tTotalStock.Location = new System.Drawing.Point(106, 65);
            this.tTotalStock.Name = "tTotalStock";
            this.tTotalStock.Size = new System.Drawing.Size(199, 20);
            this.tTotalStock.TabIndex = 14;
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // FormStockExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormStockExt";
            this.Text = "FormStockExt";
            this.Load += new System.EventHandler(this.FormStockExt_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pCommande.ResumeLayout(false);
            this.pCommande.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rBStockageAutreAchat;
        private System.Windows.Forms.RadioButton rBStockageOffre;
        private System.Windows.Forms.RadioButton rBStockageAchat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox typeOP;
        private System.Windows.Forms.TextBox tLibelle;
        private System.Windows.Forms.Panel pCommande;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cBinitiql;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboCompteFournisseur;
        private System.Windows.Forms.ComboBox comboFournisseur;
        private System.Windows.Forms.ComboBox comboCodeArticleStockDes;
        private System.Windows.Forms.ComboBox comboCodeArticleStock;
        private System.Windows.Forms.ComboBox comboSCatStokDes;
        private System.Windows.Forms.ComboBox comboStockDes;
        private System.Windows.Forms.ComboBox comboCompteStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboTypeStock;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tQteApro;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tSommeFact;
        private System.Windows.Forms.CheckBox CbSereferer;
        private System.Windows.Forms.TextBox tVariariotion;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button bValiderAchat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tAgros;
        private System.Windows.Forms.CheckBox cBenGros;
        private System.Windows.Forms.CheckBox CBcdf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tQteEntree;
        private System.Windows.Forms.TextBox tQtePu;
        private System.Windows.Forms.TextBox tTotalStock;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
    }
}