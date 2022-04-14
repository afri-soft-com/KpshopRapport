namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormAjoutDetailEB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutDetailEB));
            this.comboLibDes = new System.Windows.Forms.ComboBox();
            this.comboLib = new System.Windows.Forms.ComboBox();
            this.bValide = new System.Windows.Forms.Button();
            this.tQte = new System.Windows.Forms.TextBox();
            this.tPu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboArticleDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboArticle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tRefEb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboLibDes
            // 
            this.comboLibDes.FormattingEnabled = true;
            this.comboLibDes.Location = new System.Drawing.Point(102, 66);
            this.comboLibDes.Name = "comboLibDes";
            this.comboLibDes.Size = new System.Drawing.Size(270, 21);
            this.comboLibDes.TabIndex = 0;
            this.comboLibDes.SelectedIndexChanged += new System.EventHandler(this.comboLibDes_SelectedIndexChanged);
            // 
            // comboLib
            // 
            this.comboLib.FormattingEnabled = true;
            this.comboLib.Location = new System.Drawing.Point(398, 66);
            this.comboLib.Name = "comboLib";
            this.comboLib.Size = new System.Drawing.Size(99, 21);
            this.comboLib.TabIndex = 1;
            this.comboLib.SelectedIndexChanged += new System.EventHandler(this.comboLib_SelectedIndexChanged);
            // 
            // bValide
            // 
            this.bValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValide.Image = ((System.Drawing.Image)(resources.GetObject("bValide.Image")));
            this.bValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bValide.Location = new System.Drawing.Point(102, 186);
            this.bValide.Name = "bValide";
            this.bValide.Size = new System.Drawing.Size(165, 39);
            this.bValide.TabIndex = 21;
            this.bValide.Text = "AJOUTER";
            this.bValide.UseVisualStyleBackColor = true;
            this.bValide.Click += new System.EventHandler(this.bValide_Click);
            // 
            // tQte
            // 
            this.tQte.Location = new System.Drawing.Point(102, 127);
            this.tQte.Name = "tQte";
            this.tQte.Size = new System.Drawing.Size(165, 20);
            this.tQte.TabIndex = 20;
            // 
            // tPu
            // 
            this.tPu.Location = new System.Drawing.Point(102, 160);
            this.tPu.Name = "tPu";
            this.tPu.Size = new System.Drawing.Size(165, 20);
            this.tPu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "QTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "PU";
            // 
            // comboArticleDes
            // 
            this.comboArticleDes.FormattingEnabled = true;
            this.comboArticleDes.Location = new System.Drawing.Point(102, 100);
            this.comboArticleDes.Name = "comboArticleDes";
            this.comboArticleDes.Size = new System.Drawing.Size(270, 21);
            this.comboArticleDes.TabIndex = 16;
            this.comboArticleDes.SelectedIndexChanged += new System.EventHandler(this.comboArticleDes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ARTICLE";
            // 
            // comboArticle
            // 
            this.comboArticle.FormattingEnabled = true;
            this.comboArticle.Location = new System.Drawing.Point(398, 95);
            this.comboArticle.Name = "comboArticle";
            this.comboArticle.Size = new System.Drawing.Size(99, 21);
            this.comboArticle.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "EVOLUTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ref EB";
            // 
            // tRefEb
            // 
            this.tRefEb.Location = new System.Drawing.Point(102, 35);
            this.tRefEb.Name = "tRefEb";
            this.tRefEb.ReadOnly = true;
            this.tRefEb.Size = new System.Drawing.Size(165, 20);
            this.tRefEb.TabIndex = 24;
            this.tRefEb.TextChanged += new System.EventHandler(this.tRefEb_TextChanged);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(273, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormAjoutDetailEB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tRefEb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bValide);
            this.Controls.Add(this.tQte);
            this.Controls.Add(this.tPu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboArticleDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboArticle);
            this.Controls.Add(this.comboLib);
            this.Controls.Add(this.comboLibDes);
            this.Name = "FormAjoutDetailEB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjoutDetailEB";
            this.Load += new System.EventHandler(this.FormAjoutDetailEB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboLibDes;
        private System.Windows.Forms.ComboBox comboLib;
        private System.Windows.Forms.Button bValide;
        private System.Windows.Forms.TextBox tQte;
        private System.Windows.Forms.TextBox tPu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboArticleDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRefEb;
        private System.Windows.Forms.Button button2;
    }
}