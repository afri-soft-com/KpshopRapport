namespace GoldenStarApplication.FormPop
{
    partial class FormPasserLecriture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasserLecriture));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lmessage = new System.Windows.Forms.Label();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOp = new System.Windows.Forms.CheckBox();
            this.comboOp = new System.Windows.Forms.ComboBox();
            this.bReleveCpt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tRetenueProduit = new System.Windows.Forms.TextBox();
            this.tCommentaire = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tDiff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tRistourne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tValeurAchat = new System.Windows.Forms.TextBox();
            this.tQteVendue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmontantEmb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tmotant = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tNumOP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboMatriculeClients = new System.Windows.Forms.ComboBox();
            this.LIBELLE = new System.Windows.Forms.Label();
            this.tLibelle = new System.Windows.Forms.TextBox();
            this.comboNomsCilents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboEmballage = new System.Windows.Forms.ComboBox();
            this.comboCredit = new System.Windows.Forms.ComboBox();
            this.comboCrediDES = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tSolde = new System.Windows.Forms.TextBox();
            this.comboDebit = new System.Windows.Forms.ComboBox();
            this.comboDebitDes = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bWchargmentClient = new System.ComponentModel.BackgroundWorker();
            this.bWoperationDivers = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lmessage);
            this.panel1.Controls.Add(this.tDate1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 23);
            this.panel1.TabIndex = 0;
            // 
            // lmessage
            // 
            this.lmessage.AutoSize = true;
            this.lmessage.Location = new System.Drawing.Point(3, 7);
            this.lmessage.Name = "lmessage";
            this.lmessage.Size = new System.Drawing.Size(59, 13);
            this.lmessage.TabIndex = 2;
            this.lmessage.Text = "MESSAGE";
            // 
            // tDate1
            // 
            this.tDate1.Enabled = false;
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(484, 0);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(96, 20);
            this.tDate1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 614);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.cbOp);
            this.tabPage1.Controls.Add(this.comboOp);
            this.tabPage1.Controls.Add(this.bReleveCpt);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.tdateR2);
            this.tabPage1.Controls.Add(this.tDateR1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tNumOP);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       OPERATION      ";
            // 
            // cbOp
            // 
            this.cbOp.AutoSize = true;
            this.cbOp.Location = new System.Drawing.Point(529, 526);
            this.cbOp.Name = "cbOp";
            this.cbOp.Size = new System.Drawing.Size(80, 17);
            this.cbOp.TabIndex = 62;
            this.cbOp.Text = "checkBox1";
            this.cbOp.UseVisualStyleBackColor = true;
            // 
            // comboOp
            // 
            this.comboOp.DropDownHeight = 100;
            this.comboOp.FormattingEnabled = true;
            this.comboOp.IntegralHeight = false;
            this.comboOp.Location = new System.Drawing.Point(364, 557);
            this.comboOp.Name = "comboOp";
            this.comboOp.Size = new System.Drawing.Size(163, 21);
            this.comboOp.TabIndex = 61;
            // 
            // bReleveCpt
            // 
            this.bReleveCpt.BackColor = System.Drawing.Color.White;
            this.bReleveCpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReleveCpt.Image = ((System.Drawing.Image)(resources.GetObject("bReleveCpt.Image")));
            this.bReleveCpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReleveCpt.Location = new System.Drawing.Point(371, 510);
            this.bReleveCpt.Name = "bReleveCpt";
            this.bReleveCpt.Size = new System.Drawing.Size(159, 46);
            this.bReleveCpt.TabIndex = 55;
            this.bReleveCpt.Text = "APERCU  RECU";
            this.bReleveCpt.UseVisualStyleBackColor = false;
            this.bReleveCpt.Click += new System.EventHandler(this.bReleveCpt_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tRetenueProduit);
            this.panel3.Controls.Add(this.tCommentaire);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tDiff);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tRistourne);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tValeurAchat);
            this.panel3.Controls.Add(this.tQteVendue);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tmontantEmb);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.tmotant);
            this.panel3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(45, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 176);
            this.panel3.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "RET CRDT PRODUITS";
            // 
            // tRetenueProduit
            // 
            this.tRetenueProduit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRetenueProduit.Location = new System.Drawing.Point(346, 69);
            this.tRetenueProduit.Name = "tRetenueProduit";
            this.tRetenueProduit.Size = new System.Drawing.Size(123, 22);
            this.tRetenueProduit.TabIndex = 60;
            this.tRetenueProduit.Text = "0";
            this.tRetenueProduit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tCommentaire
            // 
            this.tCommentaire.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCommentaire.Location = new System.Drawing.Point(251, 141);
            this.tCommentaire.Name = "tCommentaire";
            this.tCommentaire.Size = new System.Drawing.Size(230, 22);
            this.tCommentaire.TabIndex = 59;
            this.tCommentaire.TextChanged += new System.EventHandler(this.tCommentaire_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Diff A Justifier";
            // 
            // tDiff
            // 
            this.tDiff.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDiff.Location = new System.Drawing.Point(332, 113);
            this.tDiff.Name = "tDiff";
            this.tDiff.Size = new System.Drawing.Size(138, 22);
            this.tDiff.TabIndex = 57;
            this.tDiff.TextChanged += new System.EventHandler(this.tDiff_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "RET EMB";
            // 
            // tRistourne
            // 
            this.tRistourne.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRistourne.Location = new System.Drawing.Point(91, 75);
            this.tRistourne.Name = "tRistourne";
            this.tRistourne.Size = new System.Drawing.Size(104, 22);
            this.tRistourne.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "RISTOURNE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "VALEUR";
            // 
            // tValeurAchat
            // 
            this.tValeurAchat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tValeurAchat.Location = new System.Drawing.Point(91, 47);
            this.tValeurAchat.Name = "tValeurAchat";
            this.tValeurAchat.Size = new System.Drawing.Size(104, 22);
            this.tValeurAchat.TabIndex = 52;
            // 
            // tQteVendue
            // 
            this.tQteVendue.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tQteVendue.Location = new System.Drawing.Point(91, 17);
            this.tQteVendue.Name = "tQteVendue";
            this.tQteVendue.Size = new System.Drawing.Size(104, 22);
            this.tQteVendue.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "QTE";
            // 
            // tmontantEmb
            // 
            this.tmontantEmb.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmontantEmb.Location = new System.Drawing.Point(346, 41);
            this.tmontantEmb.Name = "tmontantEmb";
            this.tmontantEmb.Size = new System.Drawing.Size(123, 22);
            this.tmontantEmb.TabIndex = 45;
            this.tmontantEmb.Text = "0";
            this.tmontantEmb.TextChanged += new System.EventHandler(this.tmontantEmb_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(215, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "ACHAT PRODUIT";
            // 
            // tmotant
            // 
            this.tmotant.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmotant.Location = new System.Drawing.Point(346, 13);
            this.tmotant.Name = "tmotant";
            this.tmotant.Size = new System.Drawing.Size(123, 22);
            this.tmotant.TabIndex = 37;
            this.tmotant.TextChanged += new System.EventHandler(this.tmotant_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(131, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "DU";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(304, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "AU";
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(331, 154);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(102, 23);
            this.tdateR2.TabIndex = 47;
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(177, 154);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(104, 23);
            this.tDateR1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(219, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 44;
            this.button1.Text = "FERMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNumOP
            // 
            this.tNumOP.Location = new System.Drawing.Point(411, 0);
            this.tNumOP.Name = "tNumOP";
            this.tNumOP.Size = new System.Drawing.Size(126, 20);
            this.tNumOP.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboMatriculeClients);
            this.panel2.Controls.Add(this.LIBELLE);
            this.panel2.Controls.Add(this.tLibelle);
            this.panel2.Controls.Add(this.comboNomsCilents);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(34, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 109);
            this.panel2.TabIndex = 40;
            // 
            // comboMatriculeClients
            // 
            this.comboMatriculeClients.DropDownHeight = 150;
            this.comboMatriculeClients.FormattingEnabled = true;
            this.comboMatriculeClients.IntegralHeight = false;
            this.comboMatriculeClients.Location = new System.Drawing.Point(81, 11);
            this.comboMatriculeClients.Name = "comboMatriculeClients";
            this.comboMatriculeClients.Size = new System.Drawing.Size(127, 21);
            this.comboMatriculeClients.TabIndex = 34;
            this.comboMatriculeClients.SelectedIndexChanged += new System.EventHandler(this.comboMatriculeClients_SelectedIndexChanged);
            // 
            // LIBELLE
            // 
            this.LIBELLE.AutoSize = true;
            this.LIBELLE.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIBELLE.Location = new System.Drawing.Point(13, 67);
            this.LIBELLE.Name = "LIBELLE";
            this.LIBELLE.Size = new System.Drawing.Size(57, 15);
            this.LIBELLE.TabIndex = 42;
            this.LIBELLE.Text = "LIBELLE";
            // 
            // tLibelle
            // 
            this.tLibelle.Location = new System.Drawing.Point(81, 64);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(399, 36);
            this.tLibelle.TabIndex = 43;
            // 
            // comboNomsCilents
            // 
            this.comboNomsCilents.DropDownHeight = 150;
            this.comboNomsCilents.FormattingEnabled = true;
            this.comboNomsCilents.IntegralHeight = false;
            this.comboNomsCilents.Location = new System.Drawing.Point(214, 11);
            this.comboNomsCilents.Name = "comboNomsCilents";
            this.comboNomsCilents.Size = new System.Drawing.Size(266, 21);
            this.comboNomsCilents.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(45, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 46);
            this.button4.TabIndex = 39;
            this.button4.Text = "VALIDER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.comboEmballage);
            this.panel10.Controls.Add(this.comboCredit);
            this.panel10.Controls.Add(this.comboCrediDES);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Location = new System.Drawing.Point(287, 183);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 129);
            this.panel10.TabIndex = 36;
            // 
            // comboEmballage
            // 
            this.comboEmballage.DropDownHeight = 100;
            this.comboEmballage.FormattingEnabled = true;
            this.comboEmballage.IntegralHeight = false;
            this.comboEmballage.Location = new System.Drawing.Point(3, 97);
            this.comboEmballage.Name = "comboEmballage";
            this.comboEmballage.Size = new System.Drawing.Size(231, 21);
            this.comboEmballage.TabIndex = 60;
            // 
            // comboCredit
            // 
            this.comboCredit.DropDownHeight = 100;
            this.comboCredit.FormattingEnabled = true;
            this.comboCredit.IntegralHeight = false;
            this.comboCredit.Location = new System.Drawing.Point(3, 41);
            this.comboCredit.Name = "comboCredit";
            this.comboCredit.Size = new System.Drawing.Size(230, 21);
            this.comboCredit.TabIndex = 0;
            // 
            // comboCrediDES
            // 
            this.comboCrediDES.DropDownHeight = 100;
            this.comboCrediDES.FormattingEnabled = true;
            this.comboCrediDES.IntegralHeight = false;
            this.comboCrediDES.Location = new System.Drawing.Point(3, 70);
            this.comboCrediDES.Name = "comboCrediDES";
            this.comboCrediDES.Size = new System.Drawing.Size(230, 21);
            this.comboCrediDES.TabIndex = 1;
            this.comboCrediDES.SelectedIndexChanged += new System.EventHandler(this.comboCrediDES_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 27);
            this.label14.TabIndex = 1;
            this.label14.Text = "CREDIT";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.tSolde);
            this.panel9.Controls.Add(this.comboDebit);
            this.panel9.Controls.Add(this.comboDebitDes);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Location = new System.Drawing.Point(45, 183);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(236, 129);
            this.panel9.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "SOLDE";
            // 
            // tSolde
            // 
            this.tSolde.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSolde.Location = new System.Drawing.Point(141, 97);
            this.tSolde.Name = "tSolde";
            this.tSolde.Size = new System.Drawing.Size(91, 22);
            this.tSolde.TabIndex = 46;
            this.tSolde.TextChanged += new System.EventHandler(this.tSolde_TextChanged);
            // 
            // comboDebit
            // 
            this.comboDebit.DropDownHeight = 100;
            this.comboDebit.FormattingEnabled = true;
            this.comboDebit.IntegralHeight = false;
            this.comboDebit.Location = new System.Drawing.Point(-2, 43);
            this.comboDebit.Name = "comboDebit";
            this.comboDebit.Size = new System.Drawing.Size(234, 21);
            this.comboDebit.TabIndex = 0;
            this.comboDebit.SelectedIndexChanged += new System.EventHandler(this.comboDebit_SelectedIndexChanged);
            this.comboDebit.Click += new System.EventHandler(this.comboDebit_Click);
            // 
            // comboDebitDes
            // 
            this.comboDebitDes.DropDownHeight = 100;
            this.comboDebitDes.FormattingEnabled = true;
            this.comboDebitDes.IntegralHeight = false;
            this.comboDebitDes.Location = new System.Drawing.Point(-2, 70);
            this.comboDebitDes.Name = "comboDebitDes";
            this.comboDebitDes.Size = new System.Drawing.Size(236, 21);
            this.comboDebitDes.TabIndex = 1;
            this.comboDebitDes.SelectedIndexChanged += new System.EventHandler(this.comboDebitDes_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "DEBIT";
            // 
            // bWchargmentClient
            // 
            this.bWchargmentClient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWchargmentClient_DoWork);
            this.bWchargmentClient.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWchargmentClient_RunWorkerCompleted);
            // 
            // bWoperationDivers
            // 
            this.bWoperationDivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWoperationDivers_DoWork);
            this.bWoperationDivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWoperationDivers_RunWorkerCompleted);
            // 
            // FormPasserLecriture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(622, 637);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPasserLecriture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPasserLecriture";
            this.Load += new System.EventHandler(this.FormPasserLecriture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNomsCilents;
        private System.Windows.Forms.ComboBox comboMatriculeClients;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboCredit;
        private System.Windows.Forms.ComboBox comboCrediDES;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboDebit;
        private System.Windows.Forms.ComboBox comboDebitDes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tmotant;
        private System.ComponentModel.BackgroundWorker bWchargmentClient;
        private System.ComponentModel.BackgroundWorker bWoperationDivers;
        private System.Windows.Forms.TextBox tNumOP;
        private System.Windows.Forms.TextBox tLibelle;
        private System.Windows.Forms.Label LIBELLE;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lmessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tmontantEmb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRistourne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tValeurAchat;
        private System.Windows.Forms.TextBox tQteVendue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tSolde;
        private System.Windows.Forms.TextBox tCommentaire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tDiff;
        private System.Windows.Forms.ComboBox comboEmballage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tRetenueProduit;
        private System.Windows.Forms.Button bReleveCpt;
        private System.Windows.Forms.ComboBox comboOp;
        private System.Windows.Forms.CheckBox cbOp;
    }
}