namespace GoldenStarApplication.FormPop
{
    partial class FormPopStockChargment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopStockChargment));
            this.lAfichage = new System.Windows.Forms.Label();
            this.tNumOp2 = new System.Windows.Forms.TextBox();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.Bvalide = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.dgFacturation = new System.Windows.Forms.DataGridView();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.tCodeDepot = new System.Windows.Forms.TextBox();
            this.tAchercher = new System.Windows.Forms.TextBox();
            this.BwChargementRechere = new System.ComponentModel.BackgroundWorker();
            this.lMessage = new System.Windows.Forms.Label();
            this.CodeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunitaireVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).BeginInit();
            this.SuspendLayout();
            // 
            // lAfichage
            // 
            this.lAfichage.AutoSize = true;
            this.lAfichage.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAfichage.Location = new System.Drawing.Point(12, 9);
            this.lAfichage.Name = "lAfichage";
            this.lAfichage.Size = new System.Drawing.Size(258, 23);
            this.lAfichage.TabIndex = 41;
            this.lAfichage.Text = "COMPLETER LA FACTURE";
            // 
            // tNumOp2
            // 
            this.tNumOp2.Location = new System.Drawing.Point(333, 32);
            this.tNumOp2.Name = "tNumOp2";
            this.tNumOp2.Size = new System.Drawing.Size(114, 20);
            this.tNumOp2.TabIndex = 40;
            // 
            // tDate1
            // 
            this.tDate1.Enabled = false;
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(333, 55);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(114, 20);
            this.tDate1.TabIndex = 39;
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(246, 435);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 38;
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
            this.Bannuler.Location = new System.Drawing.Point(73, 435);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(167, 48);
            this.Bannuler.TabIndex = 37;
            this.Bannuler.Text = "ANNULER";
            this.Bannuler.UseVisualStyleBackColor = false;
            this.Bannuler.Click += new System.EventHandler(this.Bannuler_Click);
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
            this.DesignationChambre,
            this.CQte,
            this.PunitaireVente,
            this.CPu});
            this.dgFacturation.Location = new System.Drawing.Point(20, 81);
            this.dgFacturation.Name = "dgFacturation";
            this.dgFacturation.Size = new System.Drawing.Size(538, 348);
            this.dgFacturation.TabIndex = 36;
            this.dgFacturation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturation_CellContentClick);
            this.dgFacturation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgFacturation_RowHeaderMouseDoubleClick);
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // tCodeDepot
            // 
            this.tCodeDepot.Location = new System.Drawing.Point(333, 9);
            this.tCodeDepot.Name = "tCodeDepot";
            this.tCodeDepot.Size = new System.Drawing.Size(114, 20);
            this.tCodeDepot.TabIndex = 42;
            // 
            // tAchercher
            // 
            this.tAchercher.Location = new System.Drawing.Point(20, 53);
            this.tAchercher.Name = "tAchercher";
            this.tAchercher.Size = new System.Drawing.Size(250, 20);
            this.tAchercher.TabIndex = 43;
            this.tAchercher.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BwChargementRechere
            // 
            this.BwChargementRechere.WorkerReportsProgress = true;
            this.BwChargementRechere.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwChargementRechere_DoWork);
            this.BwChargementRechere.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwChargementRechere_RunWorkerCompleted);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(17, 32);
            this.lMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(89, 13);
            this.lMessage.TabIndex = 44;
            this.lMessage.Text = "TAPER UN MOT";
            // 
            // CodeChambre
            // 
            this.CodeChambre.DataPropertyName = "CodeChambre";
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
            // DesignationChambre
            // 
            this.DesignationChambre.DataPropertyName = "DesignationChambre";
            this.DesignationChambre.HeaderText = "DESIGNATION";
            this.DesignationChambre.Name = "DesignationChambre";
            this.DesignationChambre.Width = 150;
            // 
            // CQte
            // 
            this.CQte.DataPropertyName = "Qte";
            this.CQte.HeaderText = "QTE";
            this.CQte.Name = "CQte";
            this.CQte.Width = 50;
            // 
            // PunitaireVente
            // 
            this.PunitaireVente.DataPropertyName = "PrixVente";
            this.PunitaireVente.HeaderText = "PVU";
            this.PunitaireVente.Name = "PunitaireVente";
            this.PunitaireVente.ReadOnly = true;
            this.PunitaireVente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PunitaireVente.Width = 50;
            // 
            // CPu
            // 
            this.CPu.DataPropertyName = "PrixAchat";
            this.CPu.HeaderText = "CMP";
            this.CPu.Name = "CPu";
            this.CPu.ReadOnly = true;
            this.CPu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPu.Width = 80;
            // 
            // FormPopStockChargment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(570, 515);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.tAchercher);
            this.Controls.Add(this.tCodeDepot);
            this.Controls.Add(this.lAfichage);
            this.Controls.Add(this.tNumOp2);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.dgFacturation);
            this.Name = "FormPopStockChargment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopFormStockChargment";
            this.Load += new System.EventHandler(this.FormPopStockChargment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAfichage;
        private System.Windows.Forms.TextBox tNumOp2;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.DataGridView dgFacturation;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.TextBox tCodeDepot;
        private System.Windows.Forms.TextBox tAchercher;
        private System.ComponentModel.BackgroundWorker BwChargementRechere;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunitaireVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPu;
    }
}