namespace GoldenStarApplication.Comptabillite
{
    partial class FormClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClasse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGClasse = new System.Windows.Forms.DataGridView();
            this.NumClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGClasse)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGClasse);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 381);
            this.panel1.TabIndex = 0;
            // 
            // dGClasse
            // 
            this.dGClasse.AllowUserToAddRows = false;
            this.dGClasse.AllowUserToDeleteRows = false;
            this.dGClasse.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumClasse,
            this.DesignationClasse,
            this.NombreCadre,
            this.Column4});
            this.dGClasse.Location = new System.Drawing.Point(19, 19);
            this.dGClasse.Name = "dGClasse";
            this.dGClasse.ReadOnly = true;
            this.dGClasse.Size = new System.Drawing.Size(548, 345);
            this.dGClasse.TabIndex = 0;
            // 
            // NumClasse
            // 
            this.NumClasse.DataPropertyName = "NumClasse";
            this.NumClasse.HeaderText = "No ";
            this.NumClasse.Name = "NumClasse";
            this.NumClasse.ReadOnly = true;
            // 
            // DesignationClasse
            // 
            this.DesignationClasse.DataPropertyName = "DesignationClasse";
            this.DesignationClasse.HeaderText = "CLASSE";
            this.DesignationClasse.Name = "DesignationClasse";
            this.DesignationClasse.ReadOnly = true;
            this.DesignationClasse.Width = 300;
            // 
            // NombreCadre
            // 
            this.NombreCadre.DataPropertyName = "NombreCadre";
            this.NombreCadre.HeaderText = "NOMBRE";
            this.NombreCadre.Name = "NombreCadre";
            this.NombreCadre.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SOLDE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(104, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(20, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 51);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(274, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "APERCU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "LES CLASSES SELON OHADA";
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(619, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClasse";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGClasse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGClasse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}