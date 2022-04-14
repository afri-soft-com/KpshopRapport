namespace GoldenStarApplication
{
    partial class FormUtilisateur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tDesignationUt = new System.Windows.Forms.TextBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.bSupUser = new System.Windows.Forms.Button();
            this.bEnreUser = new System.Windows.Forms.Button();
            this.tNomUSER = new System.Windows.Forms.TextBox();
            this.tFonction = new System.Windows.Forms.TextBox();
            this.tMotDepasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGutilisateur = new System.Windows.Forms.DataGridView();
            this.IdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGutilisateur)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tDate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tDesignationUt);
            this.panel1.Controls.Add(this.comboService);
            this.panel1.Controls.Add(this.bSupUser);
            this.panel1.Controls.Add(this.bEnreUser);
            this.panel1.Controls.Add(this.tNomUSER);
            this.panel1.Controls.Add(this.tFonction);
            this.panel1.Controls.Add(this.tMotDepasse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(62, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 224);
            this.panel1.TabIndex = 0;
            // 
            // tDate
            // 
            this.tDate.Enabled = false;
            this.tDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate.Location = new System.Drawing.Point(160, 3);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(105, 23);
            this.tDate.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(294, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "ANNULER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "DESIGNATION";
            // 
            // tDesignationUt
            // 
            this.tDesignationUt.Location = new System.Drawing.Point(123, 58);
            this.tDesignationUt.Name = "tDesignationUt";
            this.tDesignationUt.Size = new System.Drawing.Size(308, 23);
            this.tDesignationUt.TabIndex = 11;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Items.AddRange(new object[] {
            "ADMIN",
            "STOCK",
            "COMPTABILITE",
            "EMBALLAGE",
            "CAISSE"});
            this.comboService.Location = new System.Drawing.Point(123, 150);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(308, 24);
            this.comboService.TabIndex = 10;
            // 
            // bSupUser
            // 
            this.bSupUser.BackColor = System.Drawing.Color.White;
            this.bSupUser.Enabled = false;
            this.bSupUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSupUser.Location = new System.Drawing.Point(151, 178);
            this.bSupUser.Name = "bSupUser";
            this.bSupUser.Size = new System.Drawing.Size(137, 39);
            this.bSupUser.TabIndex = 9;
            this.bSupUser.Text = "SUPPRIMMER";
            this.bSupUser.UseVisualStyleBackColor = false;
            // 
            // bEnreUser
            // 
            this.bEnreUser.BackColor = System.Drawing.Color.White;
            this.bEnreUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnreUser.Location = new System.Drawing.Point(12, 178);
            this.bEnreUser.Name = "bEnreUser";
            this.bEnreUser.Size = new System.Drawing.Size(133, 39);
            this.bEnreUser.TabIndex = 8;
            this.bEnreUser.Text = "ENREGISTRER";
            this.bEnreUser.UseVisualStyleBackColor = false;
            this.bEnreUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNomUSER
            // 
            this.tNomUSER.Location = new System.Drawing.Point(123, 29);
            this.tNomUSER.Name = "tNomUSER";
            this.tNomUSER.Size = new System.Drawing.Size(308, 23);
            this.tNomUSER.TabIndex = 7;
            this.tNomUSER.TextChanged += new System.EventHandler(this.tNomUSER_TextChanged);
            // 
            // tFonction
            // 
            this.tFonction.Location = new System.Drawing.Point(123, 121);
            this.tFonction.Name = "tFonction";
            this.tFonction.Size = new System.Drawing.Size(308, 23);
            this.tFonction.TabIndex = 5;
            // 
            // tMotDepasse
            // 
            this.tMotDepasse.Location = new System.Drawing.Point(123, 92);
            this.tMotDepasse.Name = "tMotDepasse";
            this.tMotDepasse.PasswordChar = 'x';
            this.tMotDepasse.Size = new System.Drawing.Size(308, 23);
            this.tMotDepasse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEVICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FOCTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOT DE PASSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 599);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NOUVEAU";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGutilisateur);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(31, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 292);
            this.panel2.TabIndex = 1;
            // 
            // dGutilisateur
            // 
            this.dGutilisateur.AllowUserToAddRows = false;
            this.dGutilisateur.AllowUserToDeleteRows = false;
            this.dGutilisateur.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dGutilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGutilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUtilisateur,
            this.NomUtilisateur,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGutilisateur.Location = new System.Drawing.Point(20, 17);
            this.dGutilisateur.Name = "dGutilisateur";
            this.dGutilisateur.ReadOnly = true;
            this.dGutilisateur.Size = new System.Drawing.Size(519, 250);
            this.dGutilisateur.TabIndex = 0;
            this.dGutilisateur.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // IdUtilisateur
            // 
            this.IdUtilisateur.DataPropertyName = "IdUtilisateur";
            this.IdUtilisateur.HeaderText = "No";
            this.IdUtilisateur.Name = "IdUtilisateur";
            this.IdUtilisateur.ReadOnly = true;
            this.IdUtilisateur.Width = 50;
            // 
            // NomUtilisateur
            // 
            this.NomUtilisateur.DataPropertyName = "NomUtilisateur";
            this.NomUtilisateur.HeaderText = "UTILISATEUR";
            this.NomUtilisateur.Name = "NomUtilisateur";
            this.NomUtilisateur.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DesignationUt";
            this.Column1.HeaderText = "NOMS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FonctionUt";
            this.Column2.HeaderText = "FOCTION";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ServiceAffe";
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "SERVICE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UTILISATEUR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(154, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "AFFECTER AU DEPARTEMENT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(622, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtilisateur";
            this.Load += new System.EventHandler(this.FormUtilisateur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGutilisateur)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSupUser;
        private System.Windows.Forms.Button bEnreUser;
        private System.Windows.Forms.TextBox tNomUSER;
        private System.Windows.Forms.TextBox tFonction;
        private System.Windows.Forms.TextBox tMotDepasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGutilisateur;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tDesignationUt;
        private System.Windows.Forms.DateTimePicker tDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}