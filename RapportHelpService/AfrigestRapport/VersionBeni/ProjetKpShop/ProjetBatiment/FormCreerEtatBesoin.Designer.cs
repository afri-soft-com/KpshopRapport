namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormCreerEtatBesoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreerEtatBesoin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbClotures = new System.Windows.Forms.RadioButton();
            this.rbEncours = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGProjet = new System.Windows.Forms.DataGridView();
            this.CodeEtatdeBesoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationEtatDeBesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lProject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tdateEB = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProjet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(41, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 113);
            this.panel3.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(16, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 35);
            this.button5.TabIndex = 17;
            this.button5.Text = "MODIFEIR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(309, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "VALIDER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(163, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "MODIFEIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(162, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "NOUVEAU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.rbClotures);
            this.panel2.Controls.Add(this.rbEncours);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(163, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 48);
            this.panel2.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(294, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VALIDER";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbClotures
            // 
            this.rbClotures.AutoSize = true;
            this.rbClotures.Location = new System.Drawing.Point(172, 12);
            this.rbClotures.Name = "rbClotures";
            this.rbClotures.Size = new System.Drawing.Size(91, 17);
            this.rbClotures.TabIndex = 1;
            this.rbClotures.TabStop = true;
            this.rbClotures.Text = "CLOTURES";
            this.rbClotures.UseVisualStyleBackColor = true;
            this.rbClotures.CheckedChanged += new System.EventHandler(this.rbClotures_CheckedChanged);
            // 
            // rbEncours
            // 
            this.rbEncours.AutoSize = true;
            this.rbEncours.Location = new System.Drawing.Point(41, 12);
            this.rbEncours.Name = "rbEncours";
            this.rbEncours.Size = new System.Drawing.Size(85, 17);
            this.rbEncours.TabIndex = 0;
            this.rbEncours.TabStop = true;
            this.rbEncours.Text = "ENCOURS";
            this.rbEncours.UseVisualStyleBackColor = true;
            this.rbEncours.CheckedChanged += new System.EventHandler(this.rbEncours_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGProjet);
            this.panel1.Location = new System.Drawing.Point(41, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 213);
            this.panel1.TabIndex = 8;
            // 
            // DGProjet
            // 
            this.DGProjet.AllowUserToAddRows = false;
            this.DGProjet.BackgroundColor = System.Drawing.Color.Linen;
            this.DGProjet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProjet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeEtatdeBesoin,
            this.DesignationEtatDeBesion,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ETAT,
            this.CodeProject});
            this.DGProjet.Location = new System.Drawing.Point(3, 3);
            this.DGProjet.Name = "DGProjet";
            this.DGProjet.Size = new System.Drawing.Size(648, 199);
            this.DGProjet.TabIndex = 2;
            this.DGProjet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProjet_CellContentClick);
            // 
            // CodeEtatdeBesoin
            // 
            this.CodeEtatdeBesoin.DataPropertyName = "CodeEtatdeBesoin";
            this.CodeEtatdeBesoin.HeaderText = "CODE";
            this.CodeEtatdeBesoin.Name = "CodeEtatdeBesoin";
            this.CodeEtatdeBesoin.Width = 50;
            // 
            // DesignationEtatDeBesion
            // 
            this.DesignationEtatDeBesion.DataPropertyName = "DesignationEtatDeBesion";
            this.DesignationEtatDeBesion.HeaderText = "LIBELLE";
            this.DesignationEtatDeBesion.Name = "DesignationEtatDeBesion";
            this.DesignationEtatDeBesion.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateEmision";
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateRequise";
            this.Column4.HeaderText = "REQUIS";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Lieu";
            this.Column5.HeaderText = "LIEU";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Demandeur";
            this.Column6.HeaderText = "RESPONSABLE";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // ETAT
            // 
            this.ETAT.DataPropertyName = "etat";
            this.ETAT.HeaderText = "ETAT";
            this.ETAT.Name = "ETAT";
            this.ETAT.Visible = false;
            // 
            // CodeProject
            // 
            this.CodeProject.DataPropertyName = "CodeProject";
            this.CodeProject.HeaderText = "CodeProject";
            this.CodeProject.Name = "CodeProject";
            this.CodeProject.Visible = false;
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProject.Location = new System.Drawing.Point(201, 26);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(39, 13);
            this.lProject.TabIndex = 11;
            this.lProject.Text = "projet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ETAT DE BESOIN";
            // 
            // tdateEB
            // 
            this.tdateEB.Location = new System.Drawing.Point(525, 12);
            this.tdateEB.Name = "tdateEB";
            this.tdateEB.Size = new System.Drawing.Size(200, 20);
            this.tdateEB.TabIndex = 13;
            // 
            // FormCreerEtatBesoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 506);
            this.Controls.Add(this.tdateEB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lProject);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreerEtatBesoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreerEtatBesoin";
            this.Load += new System.EventHandler(this.FormCreerEtatBesoin_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGProjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbClotures;
        private System.Windows.Forms.RadioButton rbEncours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGProjet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeEtatdeBesoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationEtatDeBesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProject;
        private System.Windows.Forms.DateTimePicker tdateEB;
    }
}