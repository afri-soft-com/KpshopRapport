namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjet));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbEncours = new System.Windows.Forms.RadioButton();
            this.rbClotures = new System.Windows.Forms.RadioButton();
            this.DGProjet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CodeProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProjet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "         PROJECT           ";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.rbEncours.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // DGProjet
            // 
            this.DGProjet.AllowUserToAddRows = false;
            this.DGProjet.BackgroundColor = System.Drawing.Color.Linen;
            this.DGProjet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProjet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProject,
            this.DesignationProject,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ETAT});
            this.DGProjet.Location = new System.Drawing.Point(16, 16);
            this.DGProjet.Name = "DGProjet";
            this.DGProjet.Size = new System.Drawing.Size(648, 278);
            this.DGProjet.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGProjet);
            this.panel1.Location = new System.Drawing.Point(62, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 313);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbClotures);
            this.panel2.Controls.Add(this.rbEncours);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(225, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 44);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(62, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 113);
            this.panel3.TabIndex = 7;
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(324, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(162, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "MODIFEIR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(471, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "BUGJET";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CodeProject
            // 
            this.CodeProject.DataPropertyName = "CodeProject";
            this.CodeProject.HeaderText = "CODE";
            this.CodeProject.Name = "CodeProject";
            this.CodeProject.Width = 50;
            // 
            // DesignationProject
            // 
            this.DesignationProject.DataPropertyName = "DesignationProject";
            this.DesignationProject.HeaderText = "PROJECT";
            this.DesignationProject.Name = "DesignationProject";
            this.DesignationProject.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateDebut";
            this.Column3.HeaderText = "DEBUT";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateFin";
            this.Column4.HeaderText = "FIN";
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
            this.Column6.DataPropertyName = "ChefDuProjet";
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
            this.button5.Tag = "EB";
            this.button5.Text = "EB";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(471, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 35);
            this.button6.TabIndex = 18;
            this.button6.Text = "SUIVIE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(163, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 35);
            this.button7.TabIndex = 19;
            this.button7.Tag = "EB";
            this.button7.Text = "CAISSE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProjet";
            this.Load += new System.EventHandler(this.FormProjet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGProjet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbClotures;
        private System.Windows.Forms.RadioButton rbEncours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGProjet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}