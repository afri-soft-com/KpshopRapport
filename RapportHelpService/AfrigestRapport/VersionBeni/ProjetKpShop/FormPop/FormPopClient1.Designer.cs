namespace GoldenStarApplication.FormPop
{
    partial class FormPopClient1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopClient1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgCompteClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDernierMat = new System.Windows.Forms.TextBox();
            this.lGROUPE = new System.Windows.Forms.Label();
            this.bSupprimmer = new System.Windows.Forms.Button();
            this.bEnreSous = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tCrediEmballageDES = new System.Windows.Forms.TextBox();
            this.tCrediEmballage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tPourcentage = new System.Windows.Forms.TextBox();
            this.tCompteClientDes = new System.Windows.Forms.TextBox();
            this.tCompteRestourneDes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tCompteRestourne = new System.Windows.Forms.TextBox();
            this.tCompteClient = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboCateGorie = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tLocalite = new System.Windows.Forms.TextBox();
            this.tMatriculeAmodifier = new System.Windows.Forms.TextBox();
            this.cbAmodifier = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tsiteweb = new System.Windows.Forms.TextBox();
            this.tEamail = new System.Windows.Forms.TextBox();
            this.tadresse2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tMatricule = new System.Windows.Forms.TextBox();
            this.tadresse1 = new System.Windows.Forms.TextBox();
            this.ttele2 = new System.Windows.Forms.TextBox();
            this.ttele1 = new System.Windows.Forms.TextBox();
            this.tNoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompteClients)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.tDernierMat);
            this.tabPage1.Controls.Add(this.lGROUPE);
            this.tabPage1.Controls.Add(this.bSupprimmer);
            this.tabPage1.Controls.Add(this.bEnreSous);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    NOUVEAU CLIENTS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(323, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "ANNULER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgCompteClients);
            this.panel3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(24, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 128);
            this.panel3.TabIndex = 14;
            // 
            // dgCompteClients
            // 
            this.dgCompteClients.AllowUserToAddRows = false;
            this.dgCompteClients.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgCompteClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompteClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgCompteClients.Location = new System.Drawing.Point(22, 3);
            this.dgCompteClients.Name = "dgCompteClients";
            this.dgCompteClients.Size = new System.Drawing.Size(693, 122);
            this.dgCompteClients.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Matricule";
            this.Column1.HeaderText = "MATRICULE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Noms";
            this.Column2.HeaderText = "NOMS";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NumCompte";
            this.Column3.HeaderText = "COMPTE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DesignationCompte";
            this.Column4.HeaderText = "DESIGNATION";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PourcentPv";
            this.Column5.HeaderText = "TAUX";
            this.Column5.Name = "Column5";
            // 
            // tDernierMat
            // 
            this.tDernierMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDernierMat.Location = new System.Drawing.Point(630, 3);
            this.tDernierMat.Name = "tDernierMat";
            this.tDernierMat.Size = new System.Drawing.Size(123, 20);
            this.tDernierMat.TabIndex = 13;
            // 
            // lGROUPE
            // 
            this.lGROUPE.AutoSize = true;
            this.lGROUPE.Location = new System.Drawing.Point(21, 3);
            this.lGROUPE.Name = "lGROUPE";
            this.lGROUPE.Size = new System.Drawing.Size(10, 14);
            this.lGROUPE.TabIndex = 11;
            this.lGROUPE.Text = "l";
            // 
            // bSupprimmer
            // 
            this.bSupprimmer.BackColor = System.Drawing.Color.White;
            this.bSupprimmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSupprimmer.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimmer.Image = ((System.Drawing.Image)(resources.GetObject("bSupprimmer.Image")));
            this.bSupprimmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSupprimmer.Location = new System.Drawing.Point(520, 310);
            this.bSupprimmer.Name = "bSupprimmer";
            this.bSupprimmer.Size = new System.Drawing.Size(206, 39);
            this.bSupprimmer.TabIndex = 10;
            this.bSupprimmer.Text = "SUPPRIMMER";
            this.bSupprimmer.UseVisualStyleBackColor = false;
            // 
            // bEnreSous
            // 
            this.bEnreSous.BackColor = System.Drawing.Color.White;
            this.bEnreSous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnreSous.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnreSous.Image = ((System.Drawing.Image)(resources.GetObject("bEnreSous.Image")));
            this.bEnreSous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEnreSous.Location = new System.Drawing.Point(146, 310);
            this.bEnreSous.Name = "bEnreSous";
            this.bEnreSous.Size = new System.Drawing.Size(171, 39);
            this.bEnreSous.TabIndex = 9;
            this.bEnreSous.Text = "ENREGISTRER";
            this.bEnreSous.UseVisualStyleBackColor = false;
            this.bEnreSous.Click += new System.EventHandler(this.bEnreSous_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tCrediEmballageDES);
            this.panel2.Controls.Add(this.tCrediEmballage);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tPourcentage);
            this.panel2.Controls.Add(this.tCompteClientDes);
            this.panel2.Controls.Add(this.tCompteRestourneDes);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tCompteRestourne);
            this.panel2.Controls.Add(this.tCompteClient);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(448, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 251);
            this.panel2.TabIndex = 1;
            // 
            // tCrediEmballageDES
            // 
            this.tCrediEmballageDES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCrediEmballageDES.Location = new System.Drawing.Point(98, 84);
            this.tCrediEmballageDES.Name = "tCrediEmballageDES";
            this.tCrediEmballageDES.Size = new System.Drawing.Size(190, 20);
            this.tCrediEmballageDES.TabIndex = 21;
            this.tCrediEmballageDES.TextChanged += new System.EventHandler(this.tCrediEmballageDES_TextChanged);
            // 
            // tCrediEmballage
            // 
            this.tCrediEmballage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCrediEmballage.Location = new System.Drawing.Point(98, 64);
            this.tCrediEmballage.Name = "tCrediEmballage";
            this.tCrediEmballage.Size = new System.Drawing.Size(190, 20);
            this.tCrediEmballage.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(13, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "CREDIT EMB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(46, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "TAUX";
            // 
            // tPourcentage
            // 
            this.tPourcentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPourcentage.Location = new System.Drawing.Point(113, 194);
            this.tPourcentage.Name = "tPourcentage";
            this.tPourcentage.Size = new System.Drawing.Size(164, 20);
            this.tPourcentage.TabIndex = 17;
            // 
            // tCompteClientDes
            // 
            this.tCompteClientDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteClientDes.Location = new System.Drawing.Point(98, 28);
            this.tCompteClientDes.Name = "tCompteClientDes";
            this.tCompteClientDes.Size = new System.Drawing.Size(190, 20);
            this.tCompteClientDes.TabIndex = 16;
            // 
            // tCompteRestourneDes
            // 
            this.tCompteRestourneDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteRestourneDes.Location = new System.Drawing.Point(98, 147);
            this.tCompteRestourneDes.Name = "tCompteRestourneDes";
            this.tCompteRestourneDes.Size = new System.Drawing.Size(190, 20);
            this.tCompteRestourneDes.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(13, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "RESTOURNE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "COMPTE";
            // 
            // tCompteRestourne
            // 
            this.tCompteRestourne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteRestourne.Location = new System.Drawing.Point(98, 129);
            this.tCompteRestourne.Name = "tCompteRestourne";
            this.tCompteRestourne.Size = new System.Drawing.Size(190, 20);
            this.tCompteRestourne.TabIndex = 11;
            // 
            // tCompteClient
            // 
            this.tCompteClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteClient.Location = new System.Drawing.Point(98, 8);
            this.tCompteClient.Name = "tCompteClient";
            this.tCompteClient.Size = new System.Drawing.Size(190, 20);
            this.tCompteClient.TabIndex = 10;
            this.tCompteClient.TextChanged += new System.EventHandler(this.tCompteClient_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboCateGorie);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tLocalite);
            this.panel1.Controls.Add(this.tMatriculeAmodifier);
            this.panel1.Controls.Add(this.cbAmodifier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tsiteweb);
            this.panel1.Controls.Add(this.tEamail);
            this.panel1.Controls.Add(this.tadresse2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tMatricule);
            this.panel1.Controls.Add(this.tadresse1);
            this.panel1.Controls.Add(this.ttele2);
            this.panel1.Controls.Add(this.ttele1);
            this.panel1.Controls.Add(this.tNoms);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 281);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(30, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "CATEGORIE";
            // 
            // comboCateGorie
            // 
            this.comboCateGorie.FormattingEnabled = true;
            this.comboCateGorie.Location = new System.Drawing.Point(144, 73);
            this.comboCateGorie.Name = "comboCateGorie";
            this.comboCateGorie.Size = new System.Drawing.Size(258, 23);
            this.comboCateGorie.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(30, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "LOCALITE";
            // 
            // tLocalite
            // 
            this.tLocalite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLocalite.Location = new System.Drawing.Point(144, 100);
            this.tLocalite.Name = "tLocalite";
            this.tLocalite.Size = new System.Drawing.Size(258, 20);
            this.tLocalite.TabIndex = 20;
            // 
            // tMatriculeAmodifier
            // 
            this.tMatriculeAmodifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMatriculeAmodifier.Location = new System.Drawing.Point(108, 6);
            this.tMatriculeAmodifier.Name = "tMatriculeAmodifier";
            this.tMatriculeAmodifier.Size = new System.Drawing.Size(131, 20);
            this.tMatriculeAmodifier.TabIndex = 19;
            this.tMatriculeAmodifier.Visible = false;
            this.tMatriculeAmodifier.TextChanged += new System.EventHandler(this.tMatriculeAmodifier_TextChanged);
            // 
            // cbAmodifier
            // 
            this.cbAmodifier.AutoSize = true;
            this.cbAmodifier.Location = new System.Drawing.Point(7, 6);
            this.cbAmodifier.Name = "cbAmodifier";
            this.cbAmodifier.Size = new System.Drawing.Size(73, 19);
            this.cbAmodifier.TabIndex = 18;
            this.cbAmodifier.Text = "MODIFIER";
            this.cbAmodifier.UseVisualStyleBackColor = true;
            this.cbAmodifier.CheckedChanged += new System.EventHandler(this.cbAmodifier_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(38, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "SITE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(38, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "E MAIL";
            // 
            // tsiteweb
            // 
            this.tsiteweb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsiteweb.Location = new System.Drawing.Point(144, 256);
            this.tsiteweb.Name = "tsiteweb";
            this.tsiteweb.Size = new System.Drawing.Size(258, 20);
            this.tsiteweb.TabIndex = 13;
            // 
            // tEamail
            // 
            this.tEamail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tEamail.Location = new System.Drawing.Point(144, 230);
            this.tEamail.Name = "tEamail";
            this.tEamail.Size = new System.Drawing.Size(258, 20);
            this.tEamail.TabIndex = 12;
            // 
            // tadresse2
            // 
            this.tadresse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tadresse2.Location = new System.Drawing.Point(144, 204);
            this.tadresse2.Name = "tadresse2";
            this.tadresse2.Size = new System.Drawing.Size(258, 20);
            this.tadresse2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(30, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ADRESSE 1";
            // 
            // tMatricule
            // 
            this.tMatricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMatricule.Location = new System.Drawing.Point(144, 28);
            this.tMatricule.Name = "tMatricule";
            this.tMatricule.Size = new System.Drawing.Size(258, 20);
            this.tMatricule.TabIndex = 9;
            this.tMatricule.TextChanged += new System.EventHandler(this.tMatricule_TextChanged);
            // 
            // tadresse1
            // 
            this.tadresse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tadresse1.Location = new System.Drawing.Point(144, 178);
            this.tadresse1.Name = "tadresse1";
            this.tadresse1.Size = new System.Drawing.Size(258, 20);
            this.tadresse1.TabIndex = 8;
            // 
            // ttele2
            // 
            this.ttele2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttele2.Location = new System.Drawing.Point(144, 152);
            this.ttele2.Name = "ttele2";
            this.ttele2.Size = new System.Drawing.Size(258, 20);
            this.ttele2.TabIndex = 7;
            // 
            // ttele1
            // 
            this.ttele1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttele1.Location = new System.Drawing.Point(144, 126);
            this.ttele1.Name = "ttele1";
            this.ttele1.Size = new System.Drawing.Size(258, 20);
            this.ttele1.TabIndex = 6;
            // 
            // tNoms
            // 
            this.tNoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tNoms.Location = new System.Drawing.Point(144, 51);
            this.tNoms.Name = "tNoms";
            this.tNoms.Size = new System.Drawing.Size(258, 20);
            this.tNoms.TabIndex = 5;
            this.tNoms.TextChanged += new System.EventHandler(this.tNoms_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(30, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADRESSE 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEPHONE2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEPHONE1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULE";
            // 
            // FormPopClient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPopClient1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopClient1";
            this.Load += new System.EventHandler(this.FormPopClient1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompteClients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tCompteClientDes;
        private System.Windows.Forms.TextBox tCompteRestourneDes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tCompteRestourne;
        private System.Windows.Forms.TextBox tCompteClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tsiteweb;
        private System.Windows.Forms.TextBox tEamail;
        private System.Windows.Forms.TextBox tadresse2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tMatricule;
        private System.Windows.Forms.TextBox tadresse1;
        private System.Windows.Forms.TextBox ttele2;
        private System.Windows.Forms.TextBox ttele1;
        private System.Windows.Forms.TextBox tNoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tPourcentage;
        private System.Windows.Forms.Button bSupprimmer;
        private System.Windows.Forms.Button bEnreSous;
        private System.Windows.Forms.Label lGROUPE;
        private System.Windows.Forms.DataGridView dgCompteClients;
        private System.Windows.Forms.TextBox tDernierMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tMatriculeAmodifier;
        private System.Windows.Forms.CheckBox cbAmodifier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tLocalite;
        private System.Windows.Forms.TextBox tCrediEmballageDES;
        private System.Windows.Forms.TextBox tCrediEmballage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboCateGorie;
    }
}