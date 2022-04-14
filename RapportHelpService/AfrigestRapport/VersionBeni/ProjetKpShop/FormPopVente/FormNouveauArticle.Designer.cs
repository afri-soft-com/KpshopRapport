namespace GoldenStarApplication.FormPopVente
{
    partial class FormNouveauArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNouveauArticle));
            this.button1 = new System.Windows.Forms.Button();
            this.tPu = new System.Windows.Forms.TextBox();
            this.tDesArticle = new System.Windows.Forms.TextBox();
            this.tCodeRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCategorieDes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tCritique = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bmodifier = new System.Windows.Forms.Button();
            this.tPuniVente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgArticle = new System.Windows.Forms.DataGridView();
            this.CodeArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesegnationArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorieArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lMessage = new System.Windows.Forms.Label();
            this.tAchercher = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(103, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "VALIDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPu
            // 
            this.tPu.Location = new System.Drawing.Point(127, 124);
            this.tPu.Name = "tPu";
            this.tPu.Size = new System.Drawing.Size(240, 20);
            this.tPu.TabIndex = 21;
            // 
            // tDesArticle
            // 
            this.tDesArticle.Location = new System.Drawing.Point(127, 71);
            this.tDesArticle.Name = "tDesArticle";
            this.tDesArticle.Size = new System.Drawing.Size(240, 20);
            this.tDesArticle.TabIndex = 20;
            // 
            // tCodeRef
            // 
            this.tCodeRef.Location = new System.Drawing.Point(127, 18);
            this.tCodeRef.Name = "tCodeRef";
            this.tCodeRef.Size = new System.Drawing.Size(91, 20);
            this.tCodeRef.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "PRIX DE VENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "DESIGNATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CODE";
            // 
            // comboCategorie
            // 
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Location = new System.Drawing.Point(377, 44);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(76, 21);
            this.comboCategorie.TabIndex = 23;
            this.comboCategorie.SelectedIndexChanged += new System.EventHandler(this.comboCategorie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "CATEGORIE";
            // 
            // comboCategorieDes
            // 
            this.comboCategorieDes.FormattingEnabled = true;
            this.comboCategorieDes.Location = new System.Drawing.Point(127, 44);
            this.comboCategorieDes.Name = "comboCategorieDes";
            this.comboCategorieDes.Size = new System.Drawing.Size(240, 21);
            this.comboCategorieDes.TabIndex = 25;
            this.comboCategorieDes.SelectedIndexChanged += new System.EventHandler(this.comboCategorieDes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tCritique);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Bmodifier);
            this.panel1.Controls.Add(this.tPuniVente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboCategorieDes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboCategorie);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tPu);
            this.panel1.Controls.Add(this.tDesArticle);
            this.panel1.Controls.Add(this.tCodeRef);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 223);
            this.panel1.TabIndex = 26;
            // 
            // tCritique
            // 
            this.tCritique.Location = new System.Drawing.Point(444, 93);
            this.tCritique.Name = "tCritique";
            this.tCritique.Size = new System.Drawing.Size(105, 20);
            this.tCritique.TabIndex = 32;
            this.tCritique.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "CRITIQUE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "M";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bmodifier
            // 
            this.Bmodifier.BackColor = System.Drawing.Color.Transparent;
            this.Bmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmodifier.Image = ((System.Drawing.Image)(resources.GetObject("Bmodifier.Image")));
            this.Bmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bmodifier.Location = new System.Drawing.Point(268, 172);
            this.Bmodifier.Name = "Bmodifier";
            this.Bmodifier.Size = new System.Drawing.Size(161, 39);
            this.Bmodifier.TabIndex = 28;
            this.Bmodifier.Text = "MODIFEIR";
            this.Bmodifier.UseVisualStyleBackColor = false;
            this.Bmodifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // tPuniVente
            // 
            this.tPuniVente.Location = new System.Drawing.Point(127, 100);
            this.tPuniVente.Name = "tPuniVente";
            this.tPuniVente.Size = new System.Drawing.Size(240, 20);
            this.tPuniVente.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "PRIX ACHAT";
            // 
            // dgArticle
            // 
            this.dgArticle.AllowUserToAddRows = false;
            this.dgArticle.AllowUserToDeleteRows = false;
            this.dgArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeArticle,
            this.DesegnationArticle,
            this.PrixAchat,
            this.PrixVente,
            this.CategorieArticle});
            this.dgArticle.Location = new System.Drawing.Point(11, 36);
            this.dgArticle.Name = "dgArticle";
            this.dgArticle.ReadOnly = true;
            this.dgArticle.Size = new System.Drawing.Size(581, 270);
            this.dgArticle.TabIndex = 27;
            this.dgArticle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgArticle_RowHeaderMouseClick);
            // 
            // CodeArticle
            // 
            this.CodeArticle.DataPropertyName = "CodeArticle";
            this.CodeArticle.HeaderText = "CODE";
            this.CodeArticle.Name = "CodeArticle";
            this.CodeArticle.ReadOnly = true;
            // 
            // DesegnationArticle
            // 
            this.DesegnationArticle.DataPropertyName = "DesegnationArticle";
            this.DesegnationArticle.HeaderText = "DESIGNATION";
            this.DesegnationArticle.Name = "DesegnationArticle";
            this.DesegnationArticle.ReadOnly = true;
            this.DesegnationArticle.Width = 200;
            // 
            // PrixAchat
            // 
            this.PrixAchat.DataPropertyName = "PrixAchat";
            this.PrixAchat.HeaderText = "PUR";
            this.PrixAchat.Name = "PrixAchat";
            this.PrixAchat.ReadOnly = true;
            // 
            // PrixVente
            // 
            this.PrixVente.DataPropertyName = "PrixVente";
            this.PrixVente.HeaderText = "PRIX VENTE";
            this.PrixVente.Name = "PrixVente";
            this.PrixVente.ReadOnly = true;
            // 
            // CategorieArticle
            // 
            this.CategorieArticle.DataPropertyName = "CategorieArticle";
            this.CategorieArticle.HeaderText = "CoDEcATE";
            this.CategorieArticle.Name = "CategorieArticle";
            this.CategorieArticle.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lMessage);
            this.panel2.Controls.Add(this.tAchercher);
            this.panel2.Controls.Add(this.dgArticle);
            this.panel2.Location = new System.Drawing.Point(1, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 317);
            this.panel2.TabIndex = 28;
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(28, 13);
            this.lMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(89, 13);
            this.lMessage.TabIndex = 46;
            this.lMessage.Text = "TAPER UN MOT";
            // 
            // tAchercher
            // 
            this.tAchercher.Location = new System.Drawing.Point(122, 6);
            this.tAchercher.Name = "tAchercher";
            this.tAchercher.Size = new System.Drawing.Size(362, 20);
            this.tAchercher.TabIndex = 45;
            this.tAchercher.TextChanged += new System.EventHandler(this.tAchercher_TextChanged);
            // 
            // FormNouveauArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(603, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNouveauArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNouveauArticle";
            this.Load += new System.EventHandler(this.FormNouveauArticle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tPu;
        private System.Windows.Forms.TextBox tDesArticle;
        private System.Windows.Forms.TextBox tCodeRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCategorieDes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tPuniVente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgArticle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bmodifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesegnationArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorieArticle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tCritique;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.TextBox tAchercher;
    }
}