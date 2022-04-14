namespace GoldenStarApplication.FormPop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboCateGorie = new System.Windows.Forms.ComboBox();
            this.tPourcentage = new System.Windows.Forms.TextBox();
            this.Bvalide = new System.Windows.Forms.Button();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIE";
            // 
            // comboCateGorie
            // 
            this.comboCateGorie.FormattingEnabled = true;
            this.comboCateGorie.Location = new System.Drawing.Point(29, 60);
            this.comboCateGorie.Name = "comboCateGorie";
            this.comboCateGorie.Size = new System.Drawing.Size(313, 21);
            this.comboCateGorie.TabIndex = 48;
            // 
            // tPourcentage
            // 
            this.tPourcentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPourcentage.Location = new System.Drawing.Point(28, 103);
            this.tPourcentage.Name = "tPourcentage";
            this.tPourcentage.Size = new System.Drawing.Size(164, 20);
            this.tPourcentage.TabIndex = 49;
            this.tPourcentage.Text = "0.06";
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(29, 126);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 50;
            this.Bvalide.Text = "VALIDE";
            this.Bvalide.UseVisualStyleBackColor = false;
            this.Bvalide.Click += new System.EventHandler(this.Bvalide_Click);
            // 
            // tDate1
            // 
            this.tDate1.Enabled = false;
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(155, 12);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(165, 20);
            this.tDate1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "TAUX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.tPourcentage);
            this.Controls.Add(this.comboCateGorie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCateGorie;
        private System.Windows.Forms.TextBox tPourcentage;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Label label2;
    }
}