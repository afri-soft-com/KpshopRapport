namespace GoldenStarApplication.Comptabillite
{
    partial class FormCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompte));
            this.comboGroupeDes = new System.Windows.Forms.ComboBox();
            this.comboGroupe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGcOMPTE = new System.Windows.Forms.DataGridView();
            this.NumCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGcOMPTE)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGroupeDes
            // 
            this.comboGroupeDes.FormattingEnabled = true;
            this.comboGroupeDes.Location = new System.Drawing.Point(222, 45);
            this.comboGroupeDes.Name = "comboGroupeDes";
            this.comboGroupeDes.Size = new System.Drawing.Size(394, 21);
            this.comboGroupeDes.TabIndex = 18;
            // 
            // comboGroupe
            // 
            this.comboGroupe.FormattingEnabled = true;
            this.comboGroupe.Location = new System.Drawing.Point(95, 45);
            this.comboGroupe.Name = "comboGroupe";
            this.comboGroupe.Size = new System.Drawing.Size(121, 21);
            this.comboGroupe.TabIndex = 17;
            this.comboGroupe.SelectedIndexChanged += new System.EventHandler(this.comboGroupe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = " LES COMPPTES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(37, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 51);
            this.panel2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "NOUVEAU";
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
            this.button2.Location = new System.Drawing.Point(296, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGcOMPTE);
            this.panel1.Location = new System.Drawing.Point(37, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 381);
            this.panel1.TabIndex = 19;
            // 
            // dGcOMPTE
            // 
            this.dGcOMPTE.AllowUserToAddRows = false;
            this.dGcOMPTE.AllowUserToDeleteRows = false;
            this.dGcOMPTE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGcOMPTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGcOMPTE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCompte,
            this.DesignationCompte,
            this.Nombre,
            this.Solde});
            this.dGcOMPTE.Location = new System.Drawing.Point(19, 19);
            this.dGcOMPTE.Name = "dGcOMPTE";
            this.dGcOMPTE.ReadOnly = true;
            this.dGcOMPTE.Size = new System.Drawing.Size(548, 345);
            this.dGcOMPTE.TabIndex = 0;
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
            this.DesignationCompte.Width = 200;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "GROUPE";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(150, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "MODIFEIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(434, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(156, 38);
            this.button15.TabIndex = 32;
            this.button15.Text = "PLANS COMPTABLE";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // FormCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(662, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboGroupeDes);
            this.Controls.Add(this.comboGroupe);
            this.Name = "FormCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompte";
            this.Load += new System.EventHandler(this.FormCompte_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGcOMPTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGroupeDes;
        private System.Windows.Forms.ComboBox comboGroupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGcOMPTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button15;
    }
}