namespace GoldenStarApplication.Comptabillite
{
    partial class FormCreerGroupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreerGroupe));
            this.label11 = new System.Windows.Forms.Label();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.comboNumClasse = new System.Windows.Forms.ComboBox();
            this.tGroupeCompte = new System.Windows.Forms.TextBox();
            this.tGroupeAmodifer = new System.Windows.Forms.TextBox();
            this.B2supprimmerGroupe = new System.Windows.Forms.Button();
            this.B2enre = new System.Windows.Forms.Button();
            this.tDesignqtion = new System.Windows.Forms.TextBox();
            this.comboDesignatioCadre = new System.Windows.Forms.ComboBox();
            this.comboCadre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "CHOISIR LE CADRE";
            // 
            // comboClasse
            // 
            this.comboClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Location = new System.Drawing.Point(230, 14);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(217, 21);
            this.comboClasse.TabIndex = 25;
            // 
            // comboNumClasse
            // 
            this.comboNumClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumClasse.FormattingEnabled = true;
            this.comboNumClasse.Location = new System.Drawing.Point(136, 14);
            this.comboNumClasse.Name = "comboNumClasse";
            this.comboNumClasse.Size = new System.Drawing.Size(82, 21);
            this.comboNumClasse.TabIndex = 24;
            // 
            // tGroupeCompte
            // 
            this.tGroupeCompte.Location = new System.Drawing.Point(136, 70);
            this.tGroupeCompte.Name = "tGroupeCompte";
            this.tGroupeCompte.ReadOnly = true;
            this.tGroupeCompte.Size = new System.Drawing.Size(82, 20);
            this.tGroupeCompte.TabIndex = 23;
            // 
            // tGroupeAmodifer
            // 
            this.tGroupeAmodifer.Location = new System.Drawing.Point(230, 70);
            this.tGroupeAmodifer.MaxLength = 2;
            this.tGroupeAmodifer.Name = "tGroupeAmodifer";
            this.tGroupeAmodifer.Size = new System.Drawing.Size(217, 20);
            this.tGroupeAmodifer.TabIndex = 22;
            this.tGroupeAmodifer.TextChanged += new System.EventHandler(this.tGroupeAmodifer_TextChanged);
            // 
            // B2supprimmerGroupe
            // 
            this.B2supprimmerGroupe.BackColor = System.Drawing.Color.White;
            this.B2supprimmerGroupe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B2supprimmerGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2supprimmerGroupe.Image = ((System.Drawing.Image)(resources.GetObject("B2supprimmerGroupe.Image")));
            this.B2supprimmerGroupe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B2supprimmerGroupe.Location = new System.Drawing.Point(310, 119);
            this.B2supprimmerGroupe.Name = "B2supprimmerGroupe";
            this.B2supprimmerGroupe.Size = new System.Drawing.Size(137, 39);
            this.B2supprimmerGroupe.TabIndex = 21;
            this.B2supprimmerGroupe.Text = "SUPPRIMMER";
            this.B2supprimmerGroupe.UseVisualStyleBackColor = false;
            this.B2supprimmerGroupe.Click += new System.EventHandler(this.B2supprimmerGroupe_Click);
            // 
            // B2enre
            // 
            this.B2enre.BackColor = System.Drawing.Color.White;
            this.B2enre.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B2enre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2enre.Image = ((System.Drawing.Image)(resources.GetObject("B2enre.Image")));
            this.B2enre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B2enre.Location = new System.Drawing.Point(136, 119);
            this.B2enre.Name = "B2enre";
            this.B2enre.Size = new System.Drawing.Size(168, 39);
            this.B2enre.TabIndex = 20;
            this.B2enre.Text = "ENREGISTRER";
            this.B2enre.UseVisualStyleBackColor = false;
            this.B2enre.Click += new System.EventHandler(this.B2enre_Click);
            // 
            // tDesignqtion
            // 
            this.tDesignqtion.Location = new System.Drawing.Point(136, 93);
            this.tDesignqtion.Name = "tDesignqtion";
            this.tDesignqtion.Size = new System.Drawing.Size(311, 20);
            this.tDesignqtion.TabIndex = 19;
            // 
            // comboDesignatioCadre
            // 
            this.comboDesignatioCadre.FormattingEnabled = true;
            this.comboDesignatioCadre.Location = new System.Drawing.Point(230, 42);
            this.comboDesignatioCadre.Name = "comboDesignatioCadre";
            this.comboDesignatioCadre.Size = new System.Drawing.Size(217, 21);
            this.comboDesignatioCadre.TabIndex = 18;
            // 
            // comboCadre
            // 
            this.comboCadre.FormattingEnabled = true;
            this.comboCadre.Location = new System.Drawing.Point(136, 42);
            this.comboCadre.Name = "comboCadre";
            this.comboCadre.Size = new System.Drawing.Size(82, 21);
            this.comboCadre.TabIndex = 17;
            this.comboCadre.SelectedIndexChanged += new System.EventHandler(this.comboCadre_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "DESIGNATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "CHOISIR LA CLASSE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboClasse);
            this.panel1.Controls.Add(this.comboNumClasse);
            this.panel1.Controls.Add(this.tGroupeCompte);
            this.panel1.Controls.Add(this.tGroupeAmodifer);
            this.panel1.Controls.Add(this.B2supprimmerGroupe);
            this.panel1.Controls.Add(this.B2enre);
            this.panel1.Controls.Add(this.tDesignqtion);
            this.panel1.Controls.Add(this.comboDesignatioCadre);
            this.panel1.Controls.Add(this.comboCadre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 183);
            this.panel1.TabIndex = 27;
            // 
            // FormCreerGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(494, 208);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreerGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreerGroupe";
            this.Load += new System.EventHandler(this.FormCreerGroupe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.ComboBox comboNumClasse;
        private System.Windows.Forms.TextBox tGroupeCompte;
        private System.Windows.Forms.TextBox tGroupeAmodifer;
        private System.Windows.Forms.Button B2supprimmerGroupe;
        private System.Windows.Forms.Button B2enre;
        private System.Windows.Forms.TextBox tDesignqtion;
        private System.Windows.Forms.ComboBox comboDesignatioCadre;
        private System.Windows.Forms.ComboBox comboCadre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}