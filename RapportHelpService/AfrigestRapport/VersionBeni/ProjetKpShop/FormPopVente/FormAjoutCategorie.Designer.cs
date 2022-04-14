namespace GoldenStarApplication.FormPopVente
{
    partial class FormAjoutCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutCategorie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tDesCtegorie = new System.Windows.Forms.TextBox();
            this.tCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BvALIDER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // tDesCtegorie
            // 
            this.tDesCtegorie.Location = new System.Drawing.Point(117, 44);
            this.tDesCtegorie.Name = "tDesCtegorie";
            this.tDesCtegorie.Size = new System.Drawing.Size(187, 20);
            this.tDesCtegorie.TabIndex = 2;
            // 
            // tCode
            // 
            this.tCode.Location = new System.Drawing.Point(117, 18);
            this.tCode.Name = "tCode";
            this.tCode.ReadOnly = true;
            this.tCode.Size = new System.Drawing.Size(68, 20);
            this.tCode.TabIndex = 3;
            this.tCode.Text = "AUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORIE";
            // 
            // BvALIDER
            // 
            this.BvALIDER.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BvALIDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BvALIDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BvALIDER.Image = ((System.Drawing.Image)(resources.GetObject("BvALIDER.Image")));
            this.BvALIDER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BvALIDER.Location = new System.Drawing.Point(117, 93);
            this.BvALIDER.Name = "BvALIDER";
            this.BvALIDER.Size = new System.Drawing.Size(159, 39);
            this.BvALIDER.TabIndex = 23;
            this.BvALIDER.Text = "VALIDER";
            this.BvALIDER.UseVisualStyleBackColor = true;
            this.BvALIDER.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAjoutCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.Controls.Add(this.BvALIDER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tCode);
            this.Controls.Add(this.tDesCtegorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjoutCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjoutCategorie";
            this.Load += new System.EventHandler(this.FormAjoutCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDesCtegorie;
        private System.Windows.Forms.TextBox tCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BvALIDER;
    }
}