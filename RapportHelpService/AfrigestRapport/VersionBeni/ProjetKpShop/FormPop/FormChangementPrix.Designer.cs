namespace GoldenStarApplication.FormPop
{
    partial class FormChangementPrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangementPrix));
            this.DGsommaireSTOCK = new System.Windows.Forms.DataGridView();
            this.tCodeDepot = new System.Windows.Forms.TextBox();
            this.lAfichage = new System.Windows.Forms.Label();
            this.tNumOp2 = new System.Windows.Forms.TextBox();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.Bvalide = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.bwcharmemntCombo = new System.ComponentModel.BackgroundWorker();
            this.CodeArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixAmodif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIXrest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixRestourne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGsommaireSTOCK)).BeginInit();
            this.SuspendLayout();
            // 
            // DGsommaireSTOCK
            // 
            this.DGsommaireSTOCK.AllowUserToAddRows = false;
            this.DGsommaireSTOCK.AllowUserToDeleteRows = false;
            this.DGsommaireSTOCK.BackgroundColor = System.Drawing.Color.Khaki;
            this.DGsommaireSTOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGsommaireSTOCK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeArticle,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn14,
            this.PrixAmodif,
            this.Column11,
            this.PRIXrest,
            this.PrixRestourne});
            this.DGsommaireSTOCK.Location = new System.Drawing.Point(12, 79);
            this.DGsommaireSTOCK.Name = "DGsommaireSTOCK";
            this.DGsommaireSTOCK.Size = new System.Drawing.Size(730, 432);
            this.DGsommaireSTOCK.TabIndex = 19;
            // 
            // tCodeDepot
            // 
            this.tCodeDepot.Location = new System.Drawing.Point(448, 27);
            this.tCodeDepot.Name = "tCodeDepot";
            this.tCodeDepot.Size = new System.Drawing.Size(114, 20);
            this.tCodeDepot.TabIndex = 46;
            // 
            // lAfichage
            // 
            this.lAfichage.AutoSize = true;
            this.lAfichage.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAfichage.Location = new System.Drawing.Point(64, 35);
            this.lAfichage.Name = "lAfichage";
            this.lAfichage.Size = new System.Drawing.Size(236, 23);
            this.lAfichage.TabIndex = 45;
            this.lAfichage.Text = "COMPLETER LA FACTURE";
            // 
            // tNumOp2
            // 
            this.tNumOp2.Location = new System.Drawing.Point(448, 1);
            this.tNumOp2.Name = "tNumOp2";
            this.tNumOp2.Size = new System.Drawing.Size(114, 20);
            this.tNumOp2.TabIndex = 44;
            // 
            // tDate1
            // 
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(448, 53);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(114, 20);
            this.tDate1.TabIndex = 43;
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(346, 517);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 48;
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
            this.Bannuler.Location = new System.Drawing.Point(151, 517);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(167, 48);
            this.Bannuler.TabIndex = 47;
            this.Bannuler.Text = "ANNULER";
            this.Bannuler.UseVisualStyleBackColor = false;
            // 
            // bwcharmemntCombo
            // 
            this.bwcharmemntCombo.WorkerReportsProgress = true;
            this.bwcharmemntCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwcharmemntCombo_DoWork);
            this.bwcharmemntCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwcharmemntCombo_RunWorkerCompleted);
            // 
            // CodeArticle
            // 
            this.CodeArticle.DataPropertyName = "CodeArticle";
            this.CodeArticle.HeaderText = "CODE";
            this.CodeArticle.Name = "CodeArticle";
            this.CodeArticle.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DesegnationArticle";
            this.dataGridViewTextBoxColumn17.HeaderText = "DESIGNATION";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CodeDepot";
            this.dataGridViewTextBoxColumn14.HeaderText = "DEPOT";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // PrixAmodif
            // 
            this.PrixAmodif.DataPropertyName = "PRIX";
            this.PrixAmodif.HeaderText = "PRIX A MODIFIER";
            this.PrixAmodif.Name = "PrixAmodif";
            this.PrixAmodif.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PrixVenteLocale";
            this.Column11.HeaderText = "PRIX";
            this.Column11.Name = "Column11";
            // 
            // PRIXrest
            // 
            this.PRIXrest.DataPropertyName = "PRIXrest";
            this.PRIXrest.HeaderText = "REST A MODIF";
            this.PRIXrest.Name = "PRIXrest";
            this.PRIXrest.Width = 120;
            // 
            // PrixRestourne
            // 
            this.PrixRestourne.DataPropertyName = "PrixRestourne";
            this.PrixRestourne.HeaderText = "RISTOURNE";
            this.PrixRestourne.Name = "PrixRestourne";
            // 
            // FormChangementPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 577);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.tCodeDepot);
            this.Controls.Add(this.lAfichage);
            this.Controls.Add(this.tNumOp2);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.DGsommaireSTOCK);
            this.Name = "FormChangementPrix";
            this.Text = "FormChangementPrix";
            this.Load += new System.EventHandler(this.FormChangementPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGsommaireSTOCK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGsommaireSTOCK;
        private System.Windows.Forms.TextBox tCodeDepot;
        private System.Windows.Forms.Label lAfichage;
        private System.Windows.Forms.TextBox tNumOp2;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.Button Bannuler;
        private System.ComponentModel.BackgroundWorker bwcharmemntCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixAmodif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIXrest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixRestourne;
    }
}