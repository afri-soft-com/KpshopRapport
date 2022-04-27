namespace GoldenStarApplication.Comptabillite
{
    partial class FormGrandLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrandLivre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGcOMPTE = new System.Windows.Forms.DataGridView();
            this.NumCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCompteDes = new System.Windows.Forms.ComboBox();
            this.comboCompte = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGcOMPTE)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGcOMPTE);
            this.panel1.Location = new System.Drawing.Point(18, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 104);
            this.panel1.TabIndex = 20;
            // 
            // dGcOMPTE
            // 
            this.dGcOMPTE.AllowUserToAddRows = false;
            this.dGcOMPTE.AllowUserToDeleteRows = false;
            this.dGcOMPTE.BackgroundColor = System.Drawing.Color.White;
            this.dGcOMPTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGcOMPTE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCompte,
            this.DesignationCompte,
            this.Nombre,
            this.Solde});
            this.dGcOMPTE.Location = new System.Drawing.Point(3, 19);
            this.dGcOMPTE.Name = "dGcOMPTE";
            this.dGcOMPTE.ReadOnly = true;
            this.dGcOMPTE.Size = new System.Drawing.Size(546, 68);
            this.dGcOMPTE.TabIndex = 0;
            this.dGcOMPTE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGcOMPTE_CellContentClick);
            // 
            // NumCompte
            // 
            this.NumCompte.DataPropertyName = "NumCompte";
            this.NumCompte.HeaderText = "No ";
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.ReadOnly = true;
            // 
            // DesignationCompte
            // 
            this.DesignationCompte.DataPropertyName = "DesignationCompte";
            this.DesignationCompte.HeaderText = "DESIGNATION";
            this.DesignationCompte.Name = "DesignationCompte";
            this.DesignationCompte.ReadOnly = true;
            this.DesignationCompte.Width = 300;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Visible = false;
            // 
            // Solde
            // 
            this.Solde.DataPropertyName = "Solde";
            this.Solde.HeaderText = "SOLDE";
            this.Solde.Name = "Solde";
            this.Solde.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "COMPTE";
            // 
            // comboCompteDes
            // 
            this.comboCompteDes.FormattingEnabled = true;
            this.comboCompteDes.Location = new System.Drawing.Point(200, 12);
            this.comboCompteDes.Name = "comboCompteDes";
            this.comboCompteDes.Size = new System.Drawing.Size(294, 21);
            this.comboCompteDes.TabIndex = 24;
            this.comboCompteDes.SelectedIndexChanged += new System.EventHandler(this.comboCompteDes_SelectedIndexChanged);
            // 
            // comboCompte
            // 
            this.comboCompte.FormattingEnabled = true;
            this.comboCompte.Location = new System.Drawing.Point(73, 12);
            this.comboCompte.Name = "comboCompte";
            this.comboCompte.Size = new System.Drawing.Size(121, 21);
            this.comboCompte.TabIndex = 23;
            this.comboCompte.SelectedIndexChanged += new System.EventHandler(this.comboCompte_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tDateR1);
            this.panel2.Controls.Add(this.tdateR2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Location = new System.Drawing.Point(41, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 94);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(23, 2);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(135, 23);
            this.tDateR1.TabIndex = 35;
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(164, 2);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(131, 23);
            this.tdateR2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(21, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(300, 29);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(152, 37);
            this.button13.TabIndex = 32;
            this.button13.Text = "APERCU  LE RELEVER DETAILLE";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.Location = new System.Drawing.Point(506, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(59, 37);
            this.button21.TabIndex = 39;
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.comboCompteDes);
            this.panel3.Controls.Add(this.comboCompte);
            this.panel3.Location = new System.Drawing.Point(14, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 48);
            this.panel3.TabIndex = 40;
            // 
            // FormGrandLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(702, 332);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrandLivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGrandLivre";
            this.Load += new System.EventHandler(this.FormGrandLivre_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGcOMPTE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGcOMPTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCompteDes;
        private System.Windows.Forms.ComboBox comboCompte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.Button button2;
    }
}