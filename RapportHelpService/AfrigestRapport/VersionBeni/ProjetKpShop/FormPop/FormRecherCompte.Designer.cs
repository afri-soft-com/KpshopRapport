namespace GoldenStarApplication.FormPop
{
    partial class FormRecherCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecherCompte));
            this.tAchercher = new System.Windows.Forms.TextBox();
            this.dgAchercher = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.lMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAchercher)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tAchercher
            // 
            this.tAchercher.Location = new System.Drawing.Point(23, 25);
            this.tAchercher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tAchercher.Multiline = true;
            this.tAchercher.Name = "tAchercher";
            this.tAchercher.Size = new System.Drawing.Size(340, 38);
            this.tAchercher.TabIndex = 1;
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
            this.Column1});
            this.dgAchercher.Location = new System.Drawing.Point(11, 16);
            this.dgAchercher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgAchercher.Name = "dgAchercher";
            this.dgAchercher.ReadOnly = true;
            this.dgAchercher.Size = new System.Drawing.Size(430, 258);
            this.dgAchercher.TabIndex = 2;
            this.dgAchercher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAchercher_CellContentClick);
            this.dgAchercher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAchercher_CellDoubleClick);
            this.dgAchercher.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAchercher_CellMouseDoubleClick);
            // 
            // Matricule
            // 
            this.Matricule.DataPropertyName = "NumCompte";
            this.Matricule.HeaderText = "COMPTE";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DesignationCompte";
            this.Column1.HeaderText = "NOMS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgAchercher);
            this.panel1.Location = new System.Drawing.Point(23, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 288);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(395, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(142, 365);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "ANNULER";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(257, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = " OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(163, 9);
            this.lMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(89, 13);
            this.lMessage.TabIndex = 8;
            this.lMessage.Text = "TAPER UN MOT";
            // 
            // FormRecherCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 414);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tAchercher);
            this.Name = "FormRecherCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecherCompte";
            this.Load += new System.EventHandler(this.FormRecherCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAchercher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tAchercher;
        private System.Windows.Forms.DataGridView dgAchercher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}