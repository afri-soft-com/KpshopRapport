namespace GoldenStarApplication.Stock
{
    partial class FormOparationVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOparationVente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCodeDepot = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.bValide = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.bNouveau = new System.Windows.Forms.Button();
            this.Bcompleter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tValeure = new System.Windows.Forms.TextBox();
            this.tVenteValeur = new System.Windows.Forms.TextBox();
            this.dataFacturation = new System.Windows.Forms.DataGridView();
            this.NumRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tBene = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tLibelle = new System.Windows.Forms.TextBox();
            this.comboCompte = new System.Windows.Forms.ComboBox();
            this.comboCompteDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAutres = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rBcash = new System.Windows.Forms.RadioButton();
            this.tNumOp2 = new System.Windows.Forms.TextBox();
            this.tDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturation)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.comboCodeDepot);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Bcompleter);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 517);
            this.panel1.TabIndex = 0;
            // 
            // comboCodeDepot
            // 
            this.comboCodeDepot.FormattingEnabled = true;
            this.comboCodeDepot.Location = new System.Drawing.Point(28, 164);
            this.comboCodeDepot.Name = "comboCodeDepot";
            this.comboCodeDepot.Size = new System.Drawing.Size(73, 21);
            this.comboCodeDepot.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.bValide);
            this.panel5.Controls.Add(this.Bannuler);
            this.panel5.Controls.Add(this.bNouveau);
            this.panel5.Location = new System.Drawing.Point(23, 450);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 55);
            this.panel5.TabIndex = 7;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(130, 9);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(128, 38);
            this.button17.TabIndex = 47;
            this.button17.Text = "FACTURE";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // bValide
            // 
            this.bValide.BackColor = System.Drawing.Color.White;
            this.bValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValide.Image = ((System.Drawing.Image)(resources.GetObject("bValide.Image")));
            this.bValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bValide.Location = new System.Drawing.Point(3, 8);
            this.bValide.Name = "bValide";
            this.bValide.Size = new System.Drawing.Size(121, 38);
            this.bValide.TabIndex = 5;
            this.bValide.Text = "VALIDER";
            this.bValide.UseVisualStyleBackColor = false;
            this.bValide.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bannuler
            // 
            this.Bannuler.BackColor = System.Drawing.Color.White;
            this.Bannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bannuler.Image = ((System.Drawing.Image)(resources.GetObject("Bannuler.Image")));
            this.Bannuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bannuler.Location = new System.Drawing.Point(392, 9);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(114, 38);
            this.Bannuler.TabIndex = 6;
            this.Bannuler.Text = "ANNULER";
            this.Bannuler.UseVisualStyleBackColor = false;
            this.Bannuler.Click += new System.EventHandler(this.button4_Click);
            // 
            // bNouveau
            // 
            this.bNouveau.BackColor = System.Drawing.Color.White;
            this.bNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNouveau.Image = ((System.Drawing.Image)(resources.GetObject("bNouveau.Image")));
            this.bNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNouveau.Location = new System.Drawing.Point(264, 9);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(122, 38);
            this.bNouveau.TabIndex = 4;
            this.bNouveau.Text = "NOUVEAU";
            this.bNouveau.UseVisualStyleBackColor = false;
            this.bNouveau.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bcompleter
            // 
            this.Bcompleter.BackColor = System.Drawing.Color.White;
            this.Bcompleter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcompleter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcompleter.Image = ((System.Drawing.Image)(resources.GetObject("Bcompleter.Image")));
            this.Bcompleter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcompleter.Location = new System.Drawing.Point(172, 164);
            this.Bcompleter.Name = "Bcompleter";
            this.Bcompleter.Size = new System.Drawing.Size(190, 44);
            this.Bcompleter.TabIndex = 3;
            this.Bcompleter.Text = "COPLETER LES ARTICLE";
            this.Bcompleter.UseVisualStyleBackColor = false;
            this.Bcompleter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tValeure);
            this.panel4.Controls.Add(this.tVenteValeur);
            this.panel4.Controls.Add(this.dataFacturation);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(28, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 230);
            this.panel4.TabIndex = 2;
            // 
            // tValeure
            // 
            this.tValeure.Location = new System.Drawing.Point(273, 201);
            this.tValeure.Name = "tValeure";
            this.tValeure.Size = new System.Drawing.Size(100, 20);
            this.tValeure.TabIndex = 3;
            // 
            // tVenteValeur
            // 
            this.tVenteValeur.Location = new System.Drawing.Point(378, 201);
            this.tVenteValeur.Name = "tVenteValeur";
            this.tVenteValeur.Size = new System.Drawing.Size(100, 20);
            this.tVenteValeur.TabIndex = 2;
            // 
            // dataFacturation
            // 
            this.dataFacturation.AllowUserToAddRows = false;
            this.dataFacturation.AllowUserToDeleteRows = false;
            this.dataFacturation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataFacturation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumRef,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataFacturation.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataFacturation.Location = new System.Drawing.Point(8, 18);
            this.dataFacturation.Name = "dataFacturation";
            this.dataFacturation.ReadOnly = true;
            this.dataFacturation.Size = new System.Drawing.Size(470, 177);
            this.dataFacturation.TabIndex = 1;
            // 
            // NumRef
            // 
            this.NumRef.DataPropertyName = "NumRef";
            this.NumRef.HeaderText = "Ref";
            this.NumRef.Name = "NumRef";
            this.NumRef.ReadOnly = true;
            this.NumRef.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DesegnationArticle";
            this.Column2.HeaderText = "ARTICLE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Qte";
            this.Column8.HeaderText = "QTE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PVentUN";
            this.Column3.HeaderText = "PU";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Vente";
            this.Column4.HeaderText = "TOTAL";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CodeArticle";
            this.Column5.HeaderText = "CODEARTICLE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Valeur";
            this.Column6.HeaderText = "AUTRE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "AUTRE";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "FACTURE";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tBene);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tLibelle);
            this.panel3.Controls.Add(this.comboCompte);
            this.panel3.Controls.Add(this.comboCompteDes);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(28, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 101);
            this.panel3.TabIndex = 1;
            // 
            // tBene
            // 
            this.tBene.Location = new System.Drawing.Point(103, 39);
            this.tBene.Name = "tBene";
            this.tBene.Size = new System.Drawing.Size(420, 20);
            this.tBene.TabIndex = 6;
            this.tBene.TextChanged += new System.EventHandler(this.tBene_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LIBELLE";
            // 
            // tLibelle
            // 
            this.tLibelle.Location = new System.Drawing.Point(103, 65);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(416, 31);
            this.tLibelle.TabIndex = 3;
            this.tLibelle.TextChanged += new System.EventHandler(this.tLibelle_TextChanged);
            // 
            // comboCompte
            // 
            this.comboCompte.FormattingEnabled = true;
            this.comboCompte.Location = new System.Drawing.Point(103, 12);
            this.comboCompte.Name = "comboCompte";
            this.comboCompte.Size = new System.Drawing.Size(85, 21);
            this.comboCompte.TabIndex = 2;
            // 
            // comboCompteDes
            // 
            this.comboCompteDes.FormattingEnabled = true;
            this.comboCompteDes.Location = new System.Drawing.Point(194, 13);
            this.comboCompteDes.Name = "comboCompteDes";
            this.comboCompteDes.Size = new System.Drawing.Size(329, 21);
            this.comboCompteDes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbAutres);
            this.panel2.Controls.Add(this.rbCredit);
            this.panel2.Controls.Add(this.rBcash);
            this.panel2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 52);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rbAutres
            // 
            this.rbAutres.AutoSize = true;
            this.rbAutres.Location = new System.Drawing.Point(315, 15);
            this.rbAutres.Name = "rbAutres";
            this.rbAutres.Size = new System.Drawing.Size(83, 20);
            this.rbAutres.TabIndex = 2;
            this.rbAutres.TabStop = true;
            this.rbAutres.Text = "AUTRES";
            this.rbAutres.UseVisualStyleBackColor = true;
            this.rbAutres.CheckedChanged += new System.EventHandler(this.rbAutres_CheckedChanged);
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(188, 15);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(75, 20);
            this.rbCredit.TabIndex = 1;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "ACHAT";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // rBcash
            // 
            this.rBcash.AutoSize = true;
            this.rBcash.Location = new System.Drawing.Point(14, 15);
            this.rBcash.Name = "rBcash";
            this.rBcash.Size = new System.Drawing.Size(149, 20);
            this.rBcash.TabIndex = 0;
            this.rBcash.TabStop = true;
            this.rBcash.Text = "RAVITAILLEMENT";
            this.rBcash.UseVisualStyleBackColor = true;
            this.rBcash.CheckedChanged += new System.EventHandler(this.rBcash_CheckedChanged);
            // 
            // tNumOp2
            // 
            this.tNumOp2.Location = new System.Drawing.Point(365, 0);
            this.tNumOp2.Name = "tNumOp2";
            this.tNumOp2.Size = new System.Drawing.Size(120, 20);
            this.tNumOp2.TabIndex = 34;
            // 
            // tDate
            // 
            this.tDate.Location = new System.Drawing.Point(76, 0);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(200, 20);
            this.tDate.TabIndex = 35;
            // 
            // FormOparationVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(618, 550);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.tNumOp2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOparationVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOparationVente";
            this.Load += new System.EventHandler(this.FormOparationVente_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataFacturation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboCompte;
        private System.Windows.Forms.ComboBox comboCompteDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAutres;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rBcash;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bValide;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.Button bNouveau;
        private System.Windows.Forms.Button Bcompleter;
        private System.Windows.Forms.TextBox tLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNumOp2;
        private System.Windows.Forms.DateTimePicker tDate;
        private System.Windows.Forms.TextBox tValeure;
        private System.Windows.Forms.TextBox tVenteValeur;
        private System.Windows.Forms.TextBox tBene;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox comboCodeDepot;
    }
}