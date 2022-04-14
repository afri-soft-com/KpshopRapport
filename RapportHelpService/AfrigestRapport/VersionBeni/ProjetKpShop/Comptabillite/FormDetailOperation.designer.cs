namespace GoldenStarApplication.Comptabillite
{
    partial class FormDetailOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailOperation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tTotalDebit = new System.Windows.Forms.TextBox();
            this.tTotalCredit = new System.Windows.Forms.TextBox();
            this.dGMouvementdeCmpte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldeDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEnreSupIdentite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGMouvementdeCmpte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bEnreSupIdentite);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tTotalDebit);
            this.panel1.Controls.Add(this.tTotalCredit);
            this.panel1.Controls.Add(this.dGMouvementdeCmpte);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 249);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL";
            // 
            // tTotalDebit
            // 
            this.tTotalDebit.Location = new System.Drawing.Point(456, 209);
            this.tTotalDebit.Name = "tTotalDebit";
            this.tTotalDebit.Size = new System.Drawing.Size(100, 20);
            this.tTotalDebit.TabIndex = 3;
            // 
            // tTotalCredit
            // 
            this.tTotalCredit.Location = new System.Drawing.Point(562, 209);
            this.tTotalCredit.Name = "tTotalCredit";
            this.tTotalCredit.Size = new System.Drawing.Size(100, 20);
            this.tTotalCredit.TabIndex = 2;
            // 
            // dGMouvementdeCmpte
            // 
            this.dGMouvementdeCmpte.AllowUserToAddRows = false;
            this.dGMouvementdeCmpte.AllowUserToDeleteRows = false;
            this.dGMouvementdeCmpte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGMouvementdeCmpte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Debit,
            this.Credit,
            this.Column4,
            this.SoldeDg});
            this.dGMouvementdeCmpte.Location = new System.Drawing.Point(14, 36);
            this.dGMouvementdeCmpte.Name = "dGMouvementdeCmpte";
            this.dGMouvementdeCmpte.ReadOnly = true;
            this.dGMouvementdeCmpte.Size = new System.Drawing.Size(657, 167);
            this.dGMouvementdeCmpte.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NumOperation";
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NumCompte";
            this.Column5.HeaderText = "Compte";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Qte";
            this.Column7.HeaderText = "Qte";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DateOperation";
            this.Column8.HeaderText = "Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DesignationCompte";
            this.Column2.HeaderText = "Libellé";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Details";
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Debit
            // 
            this.Debit.DataPropertyName = "Debit";
            this.Debit.HeaderText = "Débit(Entree)";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "Crédit (Sortie)";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DesignationCompte";
            this.Column4.HeaderText = "DesignationCompte";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // SoldeDg
            // 
            this.SoldeDg.DataPropertyName = "Solde";
            this.SoldeDg.HeaderText = "Solde";
            this.SoldeDg.Name = "SoldeDg";
            this.SoldeDg.ReadOnly = true;
            this.SoldeDg.Visible = false;
            // 
            // bEnreSupIdentite
            // 
            this.bEnreSupIdentite.BackColor = System.Drawing.Color.White;
            this.bEnreSupIdentite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnreSupIdentite.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnreSupIdentite.Image = ((System.Drawing.Image)(resources.GetObject("bEnreSupIdentite.Image")));
            this.bEnreSupIdentite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEnreSupIdentite.Location = new System.Drawing.Point(14, 207);
            this.bEnreSupIdentite.Name = "bEnreSupIdentite";
            this.bEnreSupIdentite.Size = new System.Drawing.Size(173, 39);
            this.bEnreSupIdentite.TabIndex = 26;
            this.bEnreSupIdentite.Text = "SUPPRIMMER";
            this.bEnreSupIdentite.UseVisualStyleBackColor = false;
            this.bEnreSupIdentite.Click += new System.EventHandler(this.bEnreSupIdentite_Click);
            // 
            // FormDetailOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 278);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailOperation";
            this.Load += new System.EventHandler(this.FormDetailOperation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGMouvementdeCmpte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tTotalDebit;
        private System.Windows.Forms.TextBox tTotalCredit;
        private System.Windows.Forms.DataGridView dGMouvementdeCmpte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldeDg;
        private System.Windows.Forms.Button bEnreSupIdentite;
    }
}