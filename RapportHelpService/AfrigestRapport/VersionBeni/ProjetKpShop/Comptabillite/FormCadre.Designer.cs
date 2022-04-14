namespace GoldenStarApplication.Comptabillite
{
    partial class FormCadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadre));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGcadre = new System.Windows.Forms.DataGridView();
            this.Cadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationCadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.comboClasseDES = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGcadre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "LES CADRES DE COMPTE SELON OHADA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(23, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 51);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(287, 3);
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
            this.button2.Location = new System.Drawing.Point(130, 3);
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
            this.panel1.Controls.Add(this.dGcadre);
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 360);
            this.panel1.TabIndex = 12;
            // 
            // dGcadre
            // 
            this.dGcadre.AllowUserToAddRows = false;
            this.dGcadre.AllowUserToDeleteRows = false;
            this.dGcadre.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGcadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGcadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cadre,
            this.DesignationCadre,
            this.Nombre,
            this.Column4});
            this.dGcadre.Location = new System.Drawing.Point(19, 12);
            this.dGcadre.Name = "dGcadre";
            this.dGcadre.ReadOnly = true;
            this.dGcadre.Size = new System.Drawing.Size(548, 324);
            this.dGcadre.TabIndex = 0;
            this.dGcadre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGcadre_CellContentClick);
            // 
            // Cadre
            // 
            this.Cadre.DataPropertyName = "Cadre";
            this.Cadre.HeaderText = "No ";
            this.Cadre.Name = "Cadre";
            this.Cadre.ReadOnly = true;
            // 
            // DesignationCadre
            // 
            this.DesignationCadre.DataPropertyName = "DesignationCadre";
            this.DesignationCadre.HeaderText = "CADRE";
            this.DesignationCadre.Name = "DesignationCadre";
            this.DesignationCadre.ReadOnly = true;
            this.DesignationCadre.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SOLDE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // comboClasse
            // 
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Location = new System.Drawing.Point(3, 52);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(121, 21);
            this.comboClasse.TabIndex = 15;
            this.comboClasse.SelectedIndexChanged += new System.EventHandler(this.comboClasse_SelectedIndexChanged);
            // 
            // comboClasseDES
            // 
            this.comboClasseDES.FormattingEnabled = true;
            this.comboClasseDES.Location = new System.Drawing.Point(130, 52);
            this.comboClasseDES.Name = "comboClasseDES";
            this.comboClasseDES.Size = new System.Drawing.Size(461, 21);
            this.comboClasseDES.TabIndex = 16;
            // 
            // FormCadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(626, 526);
            this.Controls.Add(this.comboClasseDES);
            this.Controls.Add(this.comboClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadre";
            this.Load += new System.EventHandler(this.FormCadre_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGcadre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGcadre;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.ComboBox comboClasseDES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationCadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}