namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormAjoutEtatDeBesoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutEtatDeBesoin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tCodePROJECT = new System.Windows.Forms.TextBox();
            this.tDesignationEb = new System.Windows.Forms.TextBox();
            this.tDateRequise = new System.Windows.Forms.DateTimePicker();
            this.tDateEb = new System.Windows.Forms.DateTimePicker();
            this.tDemandeur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tRefEB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODE PROJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE REQUISE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LIBELLE";
            // 
            // tCodePROJECT
            // 
            this.tCodePROJECT.Location = new System.Drawing.Point(117, 35);
            this.tCodePROJECT.Name = "tCodePROJECT";
            this.tCodePROJECT.ReadOnly = true;
            this.tCodePROJECT.Size = new System.Drawing.Size(260, 20);
            this.tCodePROJECT.TabIndex = 4;
            // 
            // tDesignationEb
            // 
            this.tDesignationEb.Location = new System.Drawing.Point(117, 84);
            this.tDesignationEb.Name = "tDesignationEb";
            this.tDesignationEb.Size = new System.Drawing.Size(260, 20);
            this.tDesignationEb.TabIndex = 5;
            // 
            // tDateRequise
            // 
            this.tDateRequise.Location = new System.Drawing.Point(117, 136);
            this.tDateRequise.Name = "tDateRequise";
            this.tDateRequise.Size = new System.Drawing.Size(260, 20);
            this.tDateRequise.TabIndex = 6;
            // 
            // tDateEb
            // 
            this.tDateEb.Location = new System.Drawing.Point(117, 110);
            this.tDateEb.Name = "tDateEb";
            this.tDateEb.Size = new System.Drawing.Size(260, 20);
            this.tDateEb.TabIndex = 7;
            // 
            // tDemandeur
            // 
            this.tDemandeur.Location = new System.Drawing.Point(117, 173);
            this.tDemandeur.Name = "tDemandeur";
            this.tDemandeur.Size = new System.Drawing.Size(260, 20);
            this.tDemandeur.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DEMANDEUR";
            // 
            // tRefEB
            // 
            this.tRefEB.Location = new System.Drawing.Point(117, 61);
            this.tRefEB.Name = "tRefEB";
            this.tRefEB.Size = new System.Drawing.Size(260, 20);
            this.tRefEB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ref EB";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(135, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "VALIDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAjoutEtatDeBesoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tRefEB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tDemandeur);
            this.Controls.Add(this.tDateEb);
            this.Controls.Add(this.tDateRequise);
            this.Controls.Add(this.tDesignationEb);
            this.Controls.Add(this.tCodePROJECT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjoutEtatDeBesoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjoutEtatDeBesoin";
            this.Load += new System.EventHandler(this.FormAjoutEtatDeBesoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCodePROJECT;
        private System.Windows.Forms.TextBox tDesignationEb;
        private System.Windows.Forms.DateTimePicker tDateRequise;
        private System.Windows.Forms.DateTimePicker tDateEb;
        private System.Windows.Forms.TextBox tDemandeur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRefEB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}