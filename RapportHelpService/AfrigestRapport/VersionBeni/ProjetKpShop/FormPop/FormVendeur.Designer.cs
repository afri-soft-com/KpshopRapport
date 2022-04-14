namespace GoldenStarApplication.FormPop
{
    partial class FormVendeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendeur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tDesNoms = new System.Windows.Forms.TextBox();
            this.tCodeVendeur = new System.Windows.Forms.TextBox();
            this.tRefVendeur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEnreSous = new System.Windows.Forms.Button();
            this.tCompteClientDes = new System.Windows.Forms.TextBox();
            this.tCompteClient = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCompteClients = new System.Windows.Forms.DataGridView();
            this.idVendeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeVendeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompteClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMPTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CODE";
            // 
            // tDesNoms
            // 
            this.tDesNoms.Location = new System.Drawing.Point(103, 111);
            this.tDesNoms.Name = "tDesNoms";
            this.tDesNoms.Size = new System.Drawing.Size(210, 20);
            this.tDesNoms.TabIndex = 4;
            this.tDesNoms.TextChanged += new System.EventHandler(this.tDesNoms_TextChanged);
            // 
            // tCodeVendeur
            // 
            this.tCodeVendeur.Location = new System.Drawing.Point(103, 81);
            this.tCodeVendeur.Name = "tCodeVendeur";
            this.tCodeVendeur.Size = new System.Drawing.Size(210, 20);
            this.tCodeVendeur.TabIndex = 5;
            this.tCodeVendeur.TextChanged += new System.EventHandler(this.tCodeVendeur_TextChanged);
            // 
            // tRefVendeur
            // 
            this.tRefVendeur.Location = new System.Drawing.Point(103, 52);
            this.tRefVendeur.Name = "tRefVendeur";
            this.tRefVendeur.Size = new System.Drawing.Size(210, 20);
            this.tRefVendeur.TabIndex = 6;
            this.tRefVendeur.TextChanged += new System.EventHandler(this.tRefVendeur_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tCompteClient);
            this.panel1.Controls.Add(this.tCompteClientDes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(370, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 78);
            this.panel1.TabIndex = 12;
            // 
            // bEnreSous
            // 
            this.bEnreSous.BackColor = System.Drawing.Color.White;
            this.bEnreSous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnreSous.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnreSous.Image = ((System.Drawing.Image)(resources.GetObject("bEnreSous.Image")));
            this.bEnreSous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEnreSous.Location = new System.Drawing.Point(103, 137);
            this.bEnreSous.Name = "bEnreSous";
            this.bEnreSous.Size = new System.Drawing.Size(210, 39);
            this.bEnreSous.TabIndex = 13;
            this.bEnreSous.Text = "ENREGISTRER";
            this.bEnreSous.UseVisualStyleBackColor = false;
            this.bEnreSous.Click += new System.EventHandler(this.bEnreSous_Click);
            // 
            // tCompteClientDes
            // 
            this.tCompteClientDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteClientDes.Location = new System.Drawing.Point(10, 51);
            this.tCompteClientDes.Name = "tCompteClientDes";
            this.tCompteClientDes.Size = new System.Drawing.Size(168, 20);
            this.tCompteClientDes.TabIndex = 17;
            // 
            // tCompteClient
            // 
            this.tCompteClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCompteClient.Location = new System.Drawing.Point(10, 26);
            this.tCompteClient.Name = "tCompteClient";
            this.tCompteClient.Size = new System.Drawing.Size(168, 20);
            this.tCompteClient.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgCompteClients);
            this.panel2.Location = new System.Drawing.Point(28, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 237);
            this.panel2.TabIndex = 14;
            // 
            // dgCompteClients
            // 
            this.dgCompteClients.AllowUserToAddRows = false;
            this.dgCompteClients.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgCompteClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompteClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendeu,
            this.CodeVendeu,
            this.Column2,
            this.Column3});
            this.dgCompteClients.Location = new System.Drawing.Point(14, 19);
            this.dgCompteClients.Name = "dgCompteClients";
            this.dgCompteClients.Size = new System.Drawing.Size(479, 200);
            this.dgCompteClients.TabIndex = 13;
            this.dgCompteClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompteClients_CellContentClick);
            this.dgCompteClients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCompteClients_RowHeaderMouseClick);
            // 
            // idVendeu
            // 
            this.idVendeu.DataPropertyName = "idVendeu";
            this.idVendeu.HeaderText = "Ref";
            this.idVendeu.Name = "idVendeu";
            this.idVendeu.Width = 20;
            // 
            // CodeVendeu
            // 
            this.CodeVendeu.DataPropertyName = "CodeVendeu";
            this.CodeVendeu.HeaderText = "MATRICULE";
            this.CodeVendeu.Name = "CodeVendeu";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Noms";
            this.Column2.HeaderText = "NOMS";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Compte";
            this.Column3.HeaderText = "COMPTE";
            this.Column3.Name = "Column3";
            // 
            // FormVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bEnreSous);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tRefVendeur);
            this.Controls.Add(this.tCodeVendeur);
            this.Controls.Add(this.tDesNoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVendeur";
            this.Text = "FormVendeur";
            this.Load += new System.EventHandler(this.FormVendeur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompteClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tDesNoms;
        private System.Windows.Forms.TextBox tCodeVendeur;
        private System.Windows.Forms.TextBox tRefVendeur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bEnreSous;
        private System.Windows.Forms.TextBox tCompteClientDes;
        private System.Windows.Forms.TextBox tCompteClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgCompteClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeVendeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}