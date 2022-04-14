namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormLigneBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLigneBudget));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lProject = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGlibeleProject = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGlibeleProject)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(306, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "MODIFEIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(128, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "NOUVEAU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProject.Location = new System.Drawing.Point(269, 23);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(55, 13);
            this.lProject.TabIndex = 12;
            this.lProject.Text = "PROJET";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dGlibeleProject);
            this.panel4.Location = new System.Drawing.Point(27, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 278);
            this.panel4.TabIndex = 11;
            // 
            // dGlibeleProject
            // 
            this.dGlibeleProject.AllowUserToAddRows = false;
            this.dGlibeleProject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGlibeleProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGlibeleProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.Idligne,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1});
            this.dGlibeleProject.Location = new System.Drawing.Point(16, 16);
            this.dGlibeleProject.Name = "dGlibeleProject";
            this.dGlibeleProject.Size = new System.Drawing.Size(542, 244);
            this.dGlibeleProject.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DesignationLibeleProject";
            this.Column7.HeaderText = "LIBELLE";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodeLibele";
            this.Column2.HeaderText = "code";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Idligne
            // 
            this.Idligne.DataPropertyName = "Idligne";
            this.Idligne.HeaderText = "LIGNE";
            this.Idligne.Name = "Idligne";
            this.Idligne.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DesegnationArticle";
            this.Column3.HeaderText = "ARTICLE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Qte";
            this.Column4.HeaderText = "QTE";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PU";
            this.Column5.HeaderText = "PU";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Total";
            this.Column6.HeaderText = "TOTAL";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeArticle";
            this.Column1.HeaderText = "CodeArticle";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // FormLigneBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lProject);
            this.Controls.Add(this.panel4);
            this.Name = "FormLigneBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLigneBudget";
            this.Load += new System.EventHandler(this.FormLigneBudget_Load_1);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGlibeleProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGlibeleProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}