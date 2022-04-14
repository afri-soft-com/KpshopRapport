namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormAJoutLigneBudgjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAJoutLigneBudgjet));
            this.comboArticle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboArticleDes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPu = new System.Windows.Forms.TextBox();
            this.tQte = new System.Windows.Forms.TextBox();
            this.bValide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tCodeProject = new System.Windows.Forms.TextBox();
            this.tligne = new System.Windows.Forms.TextBox();
            this.tIdLigne = new System.Windows.Forms.TextBox();
            this.comboCatDes = new System.Windows.Forms.ComboBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboArticle
            // 
            this.comboArticle.FormattingEnabled = true;
            this.comboArticle.Location = new System.Drawing.Point(101, 81);
            this.comboArticle.Name = "comboArticle";
            this.comboArticle.Size = new System.Drawing.Size(69, 21);
            this.comboArticle.TabIndex = 0;
            this.comboArticle.SelectedIndexChanged += new System.EventHandler(this.comboArticle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARTICLE";
            // 
            // comboArticleDes
            // 
            this.comboArticleDes.FormattingEnabled = true;
            this.comboArticleDes.Location = new System.Drawing.Point(176, 81);
            this.comboArticleDes.Name = "comboArticleDes";
            this.comboArticleDes.Size = new System.Drawing.Size(240, 21);
            this.comboArticleDes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "QTE";
            // 
            // tPu
            // 
            this.tPu.Location = new System.Drawing.Point(101, 141);
            this.tPu.Name = "tPu";
            this.tPu.Size = new System.Drawing.Size(165, 20);
            this.tPu.TabIndex = 5;
            // 
            // tQte
            // 
            this.tQte.Location = new System.Drawing.Point(101, 115);
            this.tQte.Name = "tQte";
            this.tQte.Size = new System.Drawing.Size(165, 20);
            this.tQte.TabIndex = 6;
            // 
            // bValide
            // 
            this.bValide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValide.Image = ((System.Drawing.Image)(resources.GetObject("bValide.Image")));
            this.bValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bValide.Location = new System.Drawing.Point(101, 178);
            this.bValide.Name = "bValide";
            this.bValide.Size = new System.Drawing.Size(165, 39);
            this.bValide.TabIndex = 13;
            this.bValide.Text = "VALIDER";
            this.bValide.UseVisualStyleBackColor = true;
            this.bValide.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ref";
            // 
            // tCodeProject
            // 
            this.tCodeProject.Location = new System.Drawing.Point(92, 17);
            this.tCodeProject.Name = "tCodeProject";
            this.tCodeProject.ReadOnly = true;
            this.tCodeProject.Size = new System.Drawing.Size(100, 20);
            this.tCodeProject.TabIndex = 15;
            // 
            // tligne
            // 
            this.tligne.Location = new System.Drawing.Point(198, 17);
            this.tligne.Name = "tligne";
            this.tligne.ReadOnly = true;
            this.tligne.Size = new System.Drawing.Size(117, 20);
            this.tligne.TabIndex = 16;
            // 
            // tIdLigne
            // 
            this.tIdLigne.Location = new System.Drawing.Point(321, 20);
            this.tIdLigne.Name = "tIdLigne";
            this.tIdLigne.ReadOnly = true;
            this.tIdLigne.Size = new System.Drawing.Size(95, 20);
            this.tIdLigne.TabIndex = 17;
            // 
            // comboCatDes
            // 
            this.comboCatDes.FormattingEnabled = true;
            this.comboCatDes.Location = new System.Drawing.Point(176, 54);
            this.comboCatDes.Name = "comboCatDes";
            this.comboCatDes.Size = new System.Drawing.Size(240, 21);
            this.comboCatDes.TabIndex = 18;
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(101, 54);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(69, 21);
            this.comboCat.TabIndex = 19;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "CATEGORIE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAJoutLigneBudgjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.comboCatDes);
            this.Controls.Add(this.tIdLigne);
            this.Controls.Add(this.tligne);
            this.Controls.Add(this.tCodeProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bValide);
            this.Controls.Add(this.tQte);
            this.Controls.Add(this.tPu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboArticleDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboArticle);
            this.Name = "FormAJoutLigneBudgjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAJoutLigneBudgjet";
            this.Load += new System.EventHandler(this.FormAJoutLigneBudgjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboArticleDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPu;
        private System.Windows.Forms.TextBox tQte;
        private System.Windows.Forms.Button bValide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCodeProject;
        private System.Windows.Forms.TextBox tligne;
        private System.Windows.Forms.TextBox tIdLigne;
        private System.Windows.Forms.ComboBox comboCatDes;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}