namespace GoldenStarApplication.Comptabillite
{
    partial class FormDetailMvtCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailMvtCompte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tSI = new System.Windows.Forms.TextBox();
            this.tTotalDebit = new System.Windows.Forms.TextBox();
            this.tTotalCredit = new System.Windows.Forms.TextBox();
            this.tSolde = new System.Windows.Forms.TextBox();
            this.dGMouvementdeCmpte = new System.Windows.Forms.DataGridView();
            this.NumOperationDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldeDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGMouvementdeCmpte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tSI);
            this.panel1.Controls.Add(this.tTotalDebit);
            this.panel1.Controls.Add(this.tTotalCredit);
            this.panel1.Controls.Add(this.tSolde);
            this.panel1.Controls.Add(this.dGMouvementdeCmpte);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 378);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solde initial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher le Relevé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "SOLDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL";
            // 
            // tSI
            // 
            this.tSI.Location = new System.Drawing.Point(648, 10);
            this.tSI.Name = "tSI";
            this.tSI.Size = new System.Drawing.Size(112, 20);
            this.tSI.TabIndex = 4;
            // 
            // tTotalDebit
            // 
            this.tTotalDebit.Location = new System.Drawing.Point(551, 324);
            this.tTotalDebit.Name = "tTotalDebit";
            this.tTotalDebit.Size = new System.Drawing.Size(100, 20);
            this.tTotalDebit.TabIndex = 3;
            // 
            // tTotalCredit
            // 
            this.tTotalCredit.Location = new System.Drawing.Point(657, 324);
            this.tTotalCredit.Name = "tTotalCredit";
            this.tTotalCredit.Size = new System.Drawing.Size(100, 20);
            this.tTotalCredit.TabIndex = 2;
            // 
            // tSolde
            // 
            this.tSolde.Location = new System.Drawing.Point(657, 350);
            this.tSolde.Name = "tSolde";
            this.tSolde.Size = new System.Drawing.Size(100, 20);
            this.tSolde.TabIndex = 1;
            // 
            // dGMouvementdeCmpte
            // 
            this.dGMouvementdeCmpte.AllowUserToAddRows = false;
            this.dGMouvementdeCmpte.AllowUserToDeleteRows = false;
            this.dGMouvementdeCmpte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGMouvementdeCmpte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOperationDG,
            this.Column7,
            this.Column8,
            this.LibelleDg,
            this.Column3,
            this.Debit,
            this.Credit,
            this.Column4,
            this.Column5,
            this.SoldeDg});
            this.dGMouvementdeCmpte.Location = new System.Drawing.Point(14, 36);
            this.dGMouvementdeCmpte.Name = "dGMouvementdeCmpte";
            this.dGMouvementdeCmpte.ReadOnly = true;
            this.dGMouvementdeCmpte.Size = new System.Drawing.Size(746, 282);
            this.dGMouvementdeCmpte.TabIndex = 0;
            this.dGMouvementdeCmpte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGMouvementdeCmpte_CellContentClick);
            // 
            // NumOperationDG
            // 
            this.NumOperationDG.DataPropertyName = "NumOperation";
            this.NumOperationDG.HeaderText = "No";
            this.NumOperationDG.Name = "NumOperationDG";
            this.NumOperationDG.ReadOnly = true;
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
            // 
            // LibelleDg
            // 
            this.LibelleDg.DataPropertyName = "Libelle";
            this.LibelleDg.HeaderText = "Libellé";
            this.LibelleDg.Name = "LibelleDg";
            this.LibelleDg.ReadOnly = true;
            this.LibelleDg.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Details";
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // Column5
            // 
            this.Column5.DataPropertyName = "NumCompte";
            this.Column5.HeaderText = "NumCompte";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // SoldeDg
            // 
            this.SoldeDg.DataPropertyName = "Solde";
            this.SoldeDg.HeaderText = "Solde";
            this.SoldeDg.Name = "SoldeDg";
            this.SoldeDg.ReadOnly = true;
            this.SoldeDg.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(161, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "DETAIL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDetailMvtCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 442);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailMvtCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailMvtCompte";
            this.Load += new System.EventHandler(this.FormDetailMvtCompte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGMouvementdeCmpte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGMouvementdeCmpte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSI;
        private System.Windows.Forms.TextBox tTotalDebit;
        private System.Windows.Forms.TextBox tTotalCredit;
        private System.Windows.Forms.TextBox tSolde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOperationDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldeDg;
        private System.Windows.Forms.Button button3;
    }
}