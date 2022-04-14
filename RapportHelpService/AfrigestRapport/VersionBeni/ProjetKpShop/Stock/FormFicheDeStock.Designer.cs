namespace GoldenStarApplication.Stock
{
    partial class FormFicheDeStock
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tStock = new System.Windows.Forms.TextBox();
            this.tSI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tQteEntree = new System.Windows.Forms.TextBox();
            this.tQteSortie = new System.Windows.Forms.TextBox();
            this.DGmvtEntreeSortie = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteEntree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleARTICLE = new System.Windows.Forms.Label();
            this.ldepot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGmvtEntreeSortie)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "DETAIL  ARTICLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stock";
            // 
            // tStock
            // 
            this.tStock.Location = new System.Drawing.Point(424, 506);
            this.tStock.Name = "tStock";
            this.tStock.Size = new System.Drawing.Size(100, 20);
            this.tStock.TabIndex = 21;
            // 
            // tSI
            // 
            this.tSI.Location = new System.Drawing.Point(526, 98);
            this.tSI.Name = "tSI";
            this.tSI.Size = new System.Drawing.Size(121, 20);
            this.tSI.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Qte Sortie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Qte Entree";
            // 
            // tQteEntree
            // 
            this.tQteEntree.Location = new System.Drawing.Point(361, 471);
            this.tQteEntree.Name = "tQteEntree";
            this.tQteEntree.Size = new System.Drawing.Size(100, 20);
            this.tQteEntree.TabIndex = 17;
            // 
            // tQteSortie
            // 
            this.tQteSortie.Location = new System.Drawing.Point(485, 471);
            this.tQteSortie.Name = "tQteSortie";
            this.tQteSortie.Size = new System.Drawing.Size(100, 20);
            this.tQteSortie.TabIndex = 16;
            // 
            // DGmvtEntreeSortie
            // 
            this.DGmvtEntreeSortie.AllowUserToAddRows = false;
            this.DGmvtEntreeSortie.AllowUserToDeleteRows = false;
            this.DGmvtEntreeSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGmvtEntreeSortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DateOp,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column2,
            this.QteEntree,
            this.QteSortie,
            this.Column5,
            this.Column6,
            this.Enstock,
            this.Vente,
            this.Valeur});
            this.DGmvtEntreeSortie.Location = new System.Drawing.Point(8, 127);
            this.DGmvtEntreeSortie.Name = "DGmvtEntreeSortie";
            this.DGmvtEntreeSortie.ReadOnly = true;
            this.DGmvtEntreeSortie.Size = new System.Drawing.Size(926, 325);
            this.DGmvtEntreeSortie.TabIndex = 15;
            this.DGmvtEntreeSortie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGmvtEntreeSortie_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stock Initial";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodeArticle";
            this.Column1.HeaderText = "Ref";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DateOp
            // 
            this.DateOp.DataPropertyName = "DateOp";
            this.DateOp.HeaderText = "Date";
            this.DateOp.Name = "DateOp";
            this.DateOp.ReadOnly = true;
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
            this.Column10.DataPropertyName = "NumOperation";
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
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PR";
            this.Column6.HeaderText = "PA";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Enstock
            // 
            this.Enstock.DataPropertyName = "Enstock";
            this.Enstock.HeaderText = "EnStock";
            this.Enstock.Name = "Enstock";
            this.Enstock.ReadOnly = true;
            this.Enstock.Visible = false;
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
            // LibelleARTICLE
            // 
            this.LibelleARTICLE.AutoSize = true;
            this.LibelleARTICLE.Location = new System.Drawing.Point(84, 77);
            this.LibelleARTICLE.Name = "LibelleARTICLE";
            this.LibelleARTICLE.Size = new System.Drawing.Size(52, 13);
            this.LibelleARTICLE.TabIndex = 26;
            this.LibelleARTICLE.Text = "ARTICLE";
            // 
            // ldepot
            // 
            this.ldepot.AutoSize = true;
            this.ldepot.Location = new System.Drawing.Point(84, 52);
            this.ldepot.Name = "ldepot";
            this.ldepot.Size = new System.Drawing.Size(36, 13);
            this.ldepot.TabIndex = 27;
            this.ldepot.Text = "Depot";
            // 
            // FormFicheDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 583);
            this.Controls.Add(this.ldepot);
            this.Controls.Add(this.LibelleARTICLE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tStock);
            this.Controls.Add(this.tSI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tQteEntree);
            this.Controls.Add(this.tQteSortie);
            this.Controls.Add(this.DGmvtEntreeSortie);
            this.Name = "FormFicheDeStock";
            this.Text = "FormFicheDeStock";
            this.Load += new System.EventHandler(this.FormFicheDeStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGmvtEntreeSortie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tStock;
        private System.Windows.Forms.TextBox tSI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tQteEntree;
        private System.Windows.Forms.TextBox tQteSortie;
        private System.Windows.Forms.DataGridView DGmvtEntreeSortie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteEntree;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.Label LibelleARTICLE;
        private System.Windows.Forms.Label ldepot;
    }
}