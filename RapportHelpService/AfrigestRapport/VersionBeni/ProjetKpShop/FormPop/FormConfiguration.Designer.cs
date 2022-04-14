namespace GoldenStarApplication.FormPop
{
    partial class FormConfiguration
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
            this.tNomServeur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNomServeur
            // 
            this.tNomServeur.Location = new System.Drawing.Point(77, 40);
            this.tNomServeur.Name = "tNomServeur";
            this.tNomServeur.Size = new System.Drawing.Size(299, 20);
            this.tNomServeur.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENRIGISTRER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVEUR";
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tNomServeur);
            this.Name = "FormConfiguration";
            this.Text = "FormConfiguration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNomServeur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}