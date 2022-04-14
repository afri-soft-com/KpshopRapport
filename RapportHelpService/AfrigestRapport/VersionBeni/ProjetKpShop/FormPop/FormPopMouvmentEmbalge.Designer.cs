namespace GoldenStarApplication.FormPop
{
    partial class FormPopMouvmentEmbalge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopMouvmentEmbalge));
            this.tCodeDepot = new System.Windows.Forms.TextBox();
            this.lAfichage = new System.Windows.Forms.Label();
            this.tNumOp2 = new System.Windows.Forms.TextBox();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.Bvalide = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.dgFacturation = new System.Windows.Forms.DataGridView();
            this.CodeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.tQteTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).BeginInit();
            this.SuspendLayout();
            // 
            // tCodeDepot
            // 
            this.tCodeDepot.Location = new System.Drawing.Point(399, 40);
            this.tCodeDepot.Name = "tCodeDepot";
            this.tCodeDepot.Size = new System.Drawing.Size(114, 20);
            this.tCodeDepot.TabIndex = 49;
            // 
            // lAfichage
            // 
            this.lAfichage.AutoSize = true;
            this.lAfichage.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAfichage.Location = new System.Drawing.Point(41, 63);
            this.lAfichage.Name = "lAfichage";
            this.lAfichage.Size = new System.Drawing.Size(282, 23);
            this.lAfichage.TabIndex = 48;
            this.lAfichage.Text = "LES MOUVEMENT EMBALLAGE";
            // 
            // tNumOp2
            // 
            this.tNumOp2.Location = new System.Drawing.Point(399, 14);
            this.tNumOp2.Name = "tNumOp2";
            this.tNumOp2.Size = new System.Drawing.Size(114, 20);
            this.tNumOp2.TabIndex = 47;
            // 
            // tDate1
            // 
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(399, 66);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(114, 20);
            this.tDate1.TabIndex = 46;
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(290, 481);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 45;
            this.Bvalide.Text = "VALIDE";
            this.Bvalide.UseVisualStyleBackColor = false;
            this.Bvalide.Click += new System.EventHandler(this.Bvalide_Click);
            // 
            // Bannuler
            // 
            this.Bannuler.BackColor = System.Drawing.Color.White;
            this.Bannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bannuler.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bannuler.Image = ((System.Drawing.Image)(resources.GetObject("Bannuler.Image")));
            this.Bannuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bannuler.Location = new System.Drawing.Point(96, 481);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(167, 48);
            this.Bannuler.TabIndex = 44;
            this.Bannuler.Text = "ANNULER";
            this.Bannuler.UseVisualStyleBackColor = false;
            // 
            // dgFacturation
            // 
            this.dgFacturation.AllowUserToAddRows = false;
            this.dgFacturation.AllowUserToDeleteRows = false;
            this.dgFacturation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgFacturation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeChambre,
            this.Column36,
            this.Column37,
            this.CQte,
            this.CPu});
            this.dgFacturation.Location = new System.Drawing.Point(29, 106);
            this.dgFacturation.Name = "dgFacturation";
            this.dgFacturation.Size = new System.Drawing.Size(552, 330);
            this.dgFacturation.TabIndex = 43;
            // 
            // CodeChambre
            // 
            this.CodeChambre.DataPropertyName = "CodeArticle";
            this.CodeChambre.HeaderText = "Ref";
            this.CodeChambre.Name = "CodeChambre";
            this.CodeChambre.Width = 60;
            // 
            // Column36
            // 
            this.Column36.DataPropertyName = "Compte";
            this.Column36.HeaderText = "COMPTE";
            this.Column36.Name = "Column36";
            // 
            // Column37
            // 
            this.Column37.DataPropertyName = "DesegnationArticle";
            this.Column37.HeaderText = "DESIGNATION";
            this.Column37.Name = "Column37";
            this.Column37.Width = 200;
            // 
            // CQte
            // 
            this.CQte.DataPropertyName = "Qte";
            this.CQte.HeaderText = "QTE";
            this.CQte.Name = "CQte";
            this.CQte.Width = 50;
            // 
            // CPu
            // 
            this.CPu.DataPropertyName = "PrixVente";
            this.CPu.HeaderText = "VALEUR ";
            this.CPu.Name = "CPu";
            this.CPu.ReadOnly = true;
            this.CPu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // tQteTotal
            // 
            this.tQteTotal.Location = new System.Drawing.Point(435, 441);
            this.tQteTotal.Name = "tQteTotal";
            this.tQteTotal.ReadOnly = true;
            this.tQteTotal.Size = new System.Drawing.Size(146, 20);
            this.tQteTotal.TabIndex = 50;
            this.tQteTotal.Click += new System.EventHandler(this.textBox1_Click);
            this.tQteTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormPopMouvmentEmbalge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 576);
            this.Controls.Add(this.tQteTotal);
            this.Controls.Add(this.tCodeDepot);
            this.Controls.Add(this.lAfichage);
            this.Controls.Add(this.tNumOp2);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.dgFacturation);
            this.Name = "FormPopMouvmentEmbalge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopMouvmentEmbalge";
            this.Load += new System.EventHandler(this.FormPopMouvmentEmbalge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCodeDepot;
        private System.Windows.Forms.Label lAfichage;
        private System.Windows.Forms.TextBox tNumOp2;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.DataGridView dgFacturation;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPu;
        private System.Windows.Forms.TextBox tQteTotal;
    }
}