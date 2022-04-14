namespace GoldenStarApplication.FormPopDepartement
{
    partial class FormAffectation
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
            this.comboDepartement = new System.Windows.Forms.ComboBox();
            this.comboUt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGaffectation = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGaffectation)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDepartement
            // 
            this.comboDepartement.FormattingEnabled = true;
            this.comboDepartement.Location = new System.Drawing.Point(152, 76);
            this.comboDepartement.Name = "comboDepartement";
            this.comboDepartement.Size = new System.Drawing.Size(232, 21);
            this.comboDepartement.TabIndex = 0;
            // 
            // comboUt
            // 
            this.comboUt.FormattingEnabled = true;
            this.comboUt.Location = new System.Drawing.Point(152, 45);
            this.comboUt.Name = "comboUt";
            this.comboUt.Size = new System.Drawing.Size(232, 21);
            this.comboUt.TabIndex = 1;
            this.comboUt.SelectedIndexChanged += new System.EventHandler(this.comboUt_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(132, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "AJOUTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEPARTEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UTLISATEUR";
            // 
            // dGaffectation
            // 
            this.dGaffectation.AllowUserToAddRows = false;
            this.dGaffectation.AllowUserToDeleteRows = false;
            this.dGaffectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGaffectation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGaffectation.Location = new System.Drawing.Point(15, 158);
            this.dGaffectation.Name = "dGaffectation";
            this.dGaffectation.ReadOnly = true;
            this.dGaffectation.Size = new System.Drawing.Size(455, 150);
            this.dGaffectation.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(261, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "ANNULER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeDepartement";
            this.Column1.HeaderText = "CODE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DesignationDepartement";
            this.Column2.HeaderText = "DEPARTEMENT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InitialDep";
            this.Column3.HeaderText = "INITIAL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormAffectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dGaffectation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboUt);
            this.Controls.Add(this.comboDepartement);
            this.Name = "FormAffectation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAffectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGaffectation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDepartement;
        private System.Windows.Forms.ComboBox comboUt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGaffectation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}