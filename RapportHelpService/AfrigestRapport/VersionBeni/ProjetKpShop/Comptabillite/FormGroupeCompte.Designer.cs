namespace GoldenStarApplication.Comptabillite
{
    partial class FormGroupeCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupeCompte));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGgroupe = new System.Windows.Forms.DataGridView();
            this.GroupeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboCadreDes = new System.Windows.Forms.ComboBox();
            this.comboCadre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGgroupe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "GROUPE COMPTE SELON OHADA";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(25, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 51);
            this.panel2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "NOUVEAU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(463, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "APERCU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(304, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGgroupe);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 381);
            this.panel1.TabIndex = 12;
            // 
            // dGgroupe
            // 
            this.dGgroupe.AllowUserToAddRows = false;
            this.dGgroupe.AllowUserToDeleteRows = false;
            this.dGgroupe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGgroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGgroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupeCompte,
            this.DesignationGroupe,
            this.Nombre,
            this.Solde});
            this.dGgroupe.Location = new System.Drawing.Point(79, 14);
            this.dGgroupe.Name = "dGgroupe";
            this.dGgroupe.ReadOnly = true;
            this.dGgroupe.Size = new System.Drawing.Size(548, 345);
            this.dGgroupe.TabIndex = 0;
            this.dGgroupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGgroupe_CellContentClick);
            // 
            // GroupeCompte
            // 
            this.GroupeCompte.DataPropertyName = "GroupeCompte";
            this.GroupeCompte.HeaderText = "No ";
            this.GroupeCompte.Name = "GroupeCompte";
            this.GroupeCompte.ReadOnly = true;
            // 
            // DesignationGroupe
            // 
            this.DesignationGroupe.DataPropertyName = "DesignationGroupe";
            this.DesignationGroupe.HeaderText = "GROUPE";
            this.DesignationGroupe.Name = "DesignationGroupe";
            this.DesignationGroupe.ReadOnly = true;
            this.DesignationGroupe.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Solde
            // 
            this.Solde.DataPropertyName = "Solde";
            this.Solde.HeaderText = "SOLDE";
            this.Solde.Name = "Solde";
            this.Solde.ReadOnly = true;
            // 
            // comboCadreDes
            // 
            this.comboCadreDes.FormattingEnabled = true;
            this.comboCadreDes.Location = new System.Drawing.Point(339, 70);
            this.comboCadreDes.Name = "comboCadreDes";
            this.comboCadreDes.Size = new System.Drawing.Size(313, 21);
            this.comboCadreDes.TabIndex = 18;
            // 
            // comboCadre
            // 
            this.comboCadre.FormattingEnabled = true;
            this.comboCadre.Location = new System.Drawing.Point(212, 70);
            this.comboCadre.Name = "comboCadre";
            this.comboCadre.Size = new System.Drawing.Size(121, 21);
            this.comboCadre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "CADRE";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(158, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 37);
            this.button4.TabIndex = 20;
            this.button4.Text = "MODIFEIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormGroupeCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(747, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCadreDes);
            this.Controls.Add(this.comboCadre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGroupeCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroupeCompte";
            this.Load += new System.EventHandler(this.FormGroupeCompte_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGgroupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGgroupe;
        private System.Windows.Forms.ComboBox comboCadreDes;
        private System.Windows.Forms.ComboBox comboCadre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupeCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}