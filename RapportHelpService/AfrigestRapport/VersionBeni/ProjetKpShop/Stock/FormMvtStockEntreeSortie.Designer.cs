namespace GoldenStarApplication.Stock
{
    partial class FormMvtStockEntreeSortie
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
            this.DGmvtEntreeSortie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tQteEntree = new System.Windows.Forms.TextBox();
            this.tQteSortie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tValeurAchat = new System.Windows.Forms.TextBox();
            this.tValeurVente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteEntree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGmvtEntreeSortie)).BeginInit();
            this.SuspendLayout();
            // 
            // DGmvtEntreeSortie
            // 
            this.DGmvtEntreeSortie.AllowUserToAddRows = false;
            this.DGmvtEntreeSortie.AllowUserToDeleteRows = false;
            this.DGmvtEntreeSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGmvtEntreeSortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column2,
            this.QteEntree,
            this.QteSortie,
            this.Column5,
            this.Column6,
            this.Vente,
            this.Valeur});
            this.DGmvtEntreeSortie.Location = new System.Drawing.Point(45, 75);
            this.DGmvtEntreeSortie.Name = "DGmvtEntreeSortie";
            this.DGmvtEntreeSortie.ReadOnly = true;
            this.DGmvtEntreeSortie.Size = new System.Drawing.Size(931, 325);
            this.DGmvtEntreeSortie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qte Entree";
            // 
            // tQteEntree
            // 
            this.tQteEntree.Location = new System.Drawing.Point(398, 419);
            this.tQteEntree.Name = "tQteEntree";
            this.tQteEntree.Size = new System.Drawing.Size(100, 20);
            this.tQteEntree.TabIndex = 7;
            // 
            // tQteSortie
            // 
            this.tQteSortie.Location = new System.Drawing.Point(522, 419);
            this.tQteSortie.Name = "tQteSortie";
            this.tQteSortie.Size = new System.Drawing.Size(100, 20);
            this.tQteSortie.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qte Sortie";
            // 
            // tValeurAchat
            // 
            this.tValeurAchat.Location = new System.Drawing.Point(731, 419);
            this.tValeurAchat.Name = "tValeurAchat";
            this.tValeurAchat.Size = new System.Drawing.Size(100, 20);
            this.tValeurAchat.TabIndex = 11;
            // 
            // tValeurVente
            // 
            this.tValeurVente.Location = new System.Drawing.Point(855, 419);
            this.tValeurVente.Name = "tValeurVente";
            this.tValeurVente.Size = new System.Drawing.Size(100, 20);
            this.tValeurVente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valeur Achat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DETAIL  ARTICLE";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeArticle";
            this.Column1.HeaderText = "Ref";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateOp";
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Enstock";
            this.Column4.HeaderText = "ENSTOCK";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RefComptabilite";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "CodeDepot";
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DesegnationArticle";
            this.Column2.HeaderText = "ARTICLE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // QteEntree
            // 
            this.QteEntree.DataPropertyName = "QteEntree";
            this.QteEntree.HeaderText = "Qte Entree";
            this.QteEntree.Name = "QteEntree";
            this.QteEntree.ReadOnly = true;
            // 
            // QteSortie
            // 
            this.QteSortie.DataPropertyName = "QteSortie";
            this.QteSortie.HeaderText = "Qte Sortie";
            this.QteSortie.Name = "QteSortie";
            this.QteSortie.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PVentUN";
            this.Column5.HeaderText = "PUVent";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PR";
            this.Column6.HeaderText = "PA";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Vente
            // 
            this.Vente.DataPropertyName = "Vente";
            this.Vente.HeaderText = "PVente";
            this.Vente.Name = "Vente";
            this.Vente.ReadOnly = true;
            // 
            // Valeur
            // 
            this.Valeur.DataPropertyName = "Valeur";
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.Name = "Valeur";
            this.Valeur.ReadOnly = true;
            // 
            // FormMvtStockEntreeSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tValeurAchat);
            this.Controls.Add(this.tValeurVente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tQteEntree);
            this.Controls.Add(this.tQteSortie);
            this.Controls.Add(this.DGmvtEntreeSortie);
            this.Name = "FormMvtStockEntreeSortie";
            this.Text = "FormMvtStockEntreeSortie";
            this.Load += new System.EventHandler(this.FormMvtStockEntreeSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGmvtEntreeSortie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGmvtEntreeSortie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tQteEntree;
        private System.Windows.Forms.TextBox tQteSortie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tValeurAchat;
        private System.Windows.Forms.TextBox tValeurVente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteEntree;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
    }
}