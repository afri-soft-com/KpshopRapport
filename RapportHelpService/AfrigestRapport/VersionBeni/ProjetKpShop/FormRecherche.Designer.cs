namespace GoldenStarApplication
{
    partial class FormRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecherche));
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.tAchercher = new System.Windows.Forms.TextBox();
            this.dgAchercher = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAchercher)).BeginInit();
            this.SuspendLayout();
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // tAchercher
            // 
            this.tAchercher.Location = new System.Drawing.Point(17, 47);
            this.tAchercher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tAchercher.Multiline = true;
            this.tAchercher.Name = "tAchercher";
            this.tAchercher.Size = new System.Drawing.Size(578, 46);
            this.tAchercher.TabIndex = 0;
            this.tAchercher.TextChanged += new System.EventHandler(this.tAchercher_TextChanged);
            // 
            // dgAchercher
            // 
            this.dgAchercher.AllowUserToAddRows = false;
            this.dgAchercher.AllowUserToDeleteRows = false;
            this.dgAchercher.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgAchercher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAchercher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Column1,
            this.Column10,
            this.Column6,
            this.Column9,
            this.Column8,
            this.Column11});
            this.dgAchercher.Location = new System.Drawing.Point(12, 99);
            this.dgAchercher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgAchercher.Name = "dgAchercher";
            this.dgAchercher.ReadOnly = true;
            this.dgAchercher.Size = new System.Drawing.Size(895, 375);
            this.dgAchercher.TabIndex = 1;
            this.dgAchercher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAchercher_CellDoubleClick);
            // 
            // Matricule
            // 
            this.Matricule.DataPropertyName = "Matricule";
            this.Matricule.HeaderText = "CODE";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Noms";
            this.Column1.HeaderText = "NOMS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Localite";
            this.Column10.HeaderText = "LOCALITE";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Telephone1";
            this.Column6.HeaderText = "TELEPHONE 1";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NoCarte";
            this.Column9.HeaderText = "TELEPHONE 2";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Adresse";
            this.Column8.HeaderText = "ADRESSE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Email";
            this.Column11.HeaderText = "Email";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(611, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "RECHERRCHER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(629, 491);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = " OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(13, 541);
            this.lMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(78, 15);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "TAPER UN MOT";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(389, 491);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "ANNULER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "TAPER UN MOT A CHERCHER";
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(958, 565);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAchercher);
            this.Controls.Add(this.tAchercher);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAchercher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.TextBox tAchercher;
        private System.Windows.Forms.DataGridView dgAchercher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}