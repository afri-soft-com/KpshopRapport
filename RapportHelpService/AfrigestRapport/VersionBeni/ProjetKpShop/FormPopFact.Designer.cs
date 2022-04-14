namespace GoldenStarApplication
{
    partial class FormPopFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopFact));
            this.dgFacturation = new System.Windows.Forms.DataGridView();
            this.CodeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bannuler = new System.Windows.Forms.Button();
            this.Bvalide = new System.Windows.Forms.Button();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.tNumOp2 = new System.Windows.Forms.TextBox();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).BeginInit();
            this.SuspendLayout();
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
            this.dgFacturation.Location = new System.Drawing.Point(12, 65);
            this.dgFacturation.Name = "dgFacturation";
            this.dgFacturation.Size = new System.Drawing.Size(521, 468);
            this.dgFacturation.TabIndex = 1;
            this.dgFacturation.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturation_CellEndEdit);
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
            // Column37
            // 
            this.Column37.DataPropertyName = "DesignationChambre";
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
            this.CPu.DataPropertyName = "TarifChambre";
            this.CPu.HeaderText = "PU";
            this.CPu.Name = "CPu";
            this.CPu.Width = 50;
            // 
            // Bannuler
            // 
            this.Bannuler.BackColor = System.Drawing.Color.White;
            this.Bannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bannuler.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bannuler.Image = ((System.Drawing.Image)(resources.GetObject("Bannuler.Image")));
            this.Bannuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bannuler.Location = new System.Drawing.Point(62, 540);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(167, 48);
            this.Bannuler.TabIndex = 2;
            this.Bannuler.Text = "ANNULER";
            this.Bannuler.UseVisualStyleBackColor = false;
            this.Bannuler.Click += new System.EventHandler(this.Bannuler_Click);
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(235, 540);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 3;
            this.Bvalide.Text = "VALIDE";
            this.Bvalide.UseVisualStyleBackColor = false;
            this.Bvalide.Click += new System.EventHandler(this.Bvalide_Click);
            // 
            // tDate1
            // 
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(386, 35);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(114, 20);
            this.tDate1.TabIndex = 20;
            // 
            // tNumOp2
            // 
            this.tNumOp2.Location = new System.Drawing.Point(386, 9);
            this.tNumOp2.Name = "tNumOp2";
            this.tNumOp2.Size = new System.Drawing.Size(114, 20);
            this.tNumOp2.TabIndex = 34;
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "COMPLETER LA FACTURE";
            // 
            // FormPopFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(545, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumOp2);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.dgFacturation);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPopFact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopFact";
            this.Load += new System.EventHandler(this.FormPopFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFacturation;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.TextBox tNumOp2;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPu;
        private System.Windows.Forms.Label label1;
    }
}