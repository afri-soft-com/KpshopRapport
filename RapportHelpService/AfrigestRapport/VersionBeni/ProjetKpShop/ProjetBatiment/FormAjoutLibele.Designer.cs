namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormAjoutLibele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutLibele));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLibelleProjet = new System.Windows.Forms.TextBox();
            this.tCodeProject = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tLigneCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODE PROJET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIBELLE";
            // 
            // tLibelleProjet
            // 
            this.tLibelleProjet.Location = new System.Drawing.Point(112, 86);
            this.tLibelleProjet.Name = "tLibelleProjet";
            this.tLibelleProjet.Size = new System.Drawing.Size(242, 20);
            this.tLibelleProjet.TabIndex = 2;
            // 
            // tCodeProject
            // 
            this.tCodeProject.Location = new System.Drawing.Point(112, 50);
            this.tCodeProject.Name = "tCodeProject";
            this.tCodeProject.ReadOnly = true;
            this.tCodeProject.Size = new System.Drawing.Size(242, 20);
            this.tCodeProject.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(141, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "VALIDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tLigneCode
            // 
            this.tLigneCode.Location = new System.Drawing.Point(219, 12);
            this.tLigneCode.Name = "tLigneCode";
            this.tLigneCode.Size = new System.Drawing.Size(135, 20);
            this.tLigneCode.TabIndex = 14;
            // 
            // FormAjoutLibele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 183);
            this.Controls.Add(this.tLigneCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tCodeProject);
            this.Controls.Add(this.tLibelleProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjoutLibele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjoutLibele";
            this.Load += new System.EventHandler(this.FormAjoutLibele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLibelleProjet;
        private System.Windows.Forms.TextBox tCodeProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tLigneCode;
    }
}