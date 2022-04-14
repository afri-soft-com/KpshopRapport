namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormLibeleDuProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibeleDuProjet));
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGlibeleProject = new System.Windows.Forms.DataGridView();
            this.lProject = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CodeLibele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationLibeleProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGlibeleProject)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dGlibeleProject);
            this.panel4.Location = new System.Drawing.Point(37, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 278);
            this.panel4.TabIndex = 5;
            // 
            // dGlibeleProject
            // 
            this.dGlibeleProject.AllowUserToAddRows = false;
            this.dGlibeleProject.BackgroundColor = System.Drawing.Color.Linen;
            this.dGlibeleProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGlibeleProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeLibele,
            this.DesignationLibeleProject,
            this.Column8,
            this.Column2});
            this.dGlibeleProject.Location = new System.Drawing.Point(16, 16);
            this.dGlibeleProject.Name = "dGlibeleProject";
            this.dGlibeleProject.Size = new System.Drawing.Size(542, 244);
            this.dGlibeleProject.TabIndex = 2;
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Location = new System.Drawing.Point(289, 43);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(49, 13);
            this.lProject.TabIndex = 6;
            this.lProject.Text = "PROJET";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 38);
            this.button3.TabIndex = 9;
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
            this.button1.Location = new System.Drawing.Point(186, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "MODIFEIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(390, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = " LES DETAILLS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(33, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 69);
            this.panel1.TabIndex = 12;
            // 
            // CodeLibele
            // 
            this.CodeLibele.DataPropertyName = "CodeLibele";
            this.CodeLibele.HeaderText = "Ref";
            this.CodeLibele.Name = "CodeLibele";
            // 
            // DesignationLibeleProject
            // 
            this.DesignationLibeleProject.DataPropertyName = "DesignationLibeleProject";
            this.DesignationLibeleProject.HeaderText = "LIBELLE";
            this.DesignationLibeleProject.Name = "DesignationLibeleProject";
            this.DesignationLibeleProject.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TOTAL";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodeProject";
            this.Column2.HeaderText = "code";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // FormLibeleDuProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lProject);
            this.Controls.Add(this.panel4);
            this.Name = "FormLibeleDuProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLibeleDuProjet";
            this.Load += new System.EventHandler(this.FormLibeleDuProjet_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGlibeleProject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGlibeleProject;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeLibele;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationLibeleProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}