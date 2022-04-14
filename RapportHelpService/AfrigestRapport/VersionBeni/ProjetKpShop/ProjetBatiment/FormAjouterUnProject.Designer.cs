namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormAjouterUnProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterUnProject));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tLibeleProject = new System.Windows.Forms.TextBox();
            this.tcodeProject = new System.Windows.Forms.TextBox();
            this.tChefDuProject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tDateFIN = new System.Windows.Forms.DateTimePicker();
            this.tDateDebut = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tLIEU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIBELLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE DEBUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATE FIN";
            // 
            // tLibeleProject
            // 
            this.tLibeleProject.Location = new System.Drawing.Point(120, 79);
            this.tLibeleProject.Name = "tLibeleProject";
            this.tLibeleProject.Size = new System.Drawing.Size(229, 20);
            this.tLibeleProject.TabIndex = 5;
            // 
            // tcodeProject
            // 
            this.tcodeProject.Location = new System.Drawing.Point(120, 53);
            this.tcodeProject.Name = "tcodeProject";
            this.tcodeProject.Size = new System.Drawing.Size(229, 20);
            this.tcodeProject.TabIndex = 7;
            // 
            // tChefDuProject
            // 
            this.tChefDuProject.Location = new System.Drawing.Point(120, 105);
            this.tChefDuProject.Name = "tChefDuProject";
            this.tChefDuProject.Size = new System.Drawing.Size(229, 20);
            this.tChefDuProject.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CHEF ";
            // 
            // tDateFIN
            // 
            this.tDateFIN.Location = new System.Drawing.Point(120, 185);
            this.tDateFIN.Name = "tDateFIN";
            this.tDateFIN.Size = new System.Drawing.Size(229, 20);
            this.tDateFIN.TabIndex = 10;
            // 
            // tDateDebut
            // 
            this.tDateDebut.Location = new System.Drawing.Point(120, 159);
            this.tDateDebut.Name = "tDateDebut";
            this.tDateDebut.Size = new System.Drawing.Size(229, 20);
            this.tDateDebut.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(120, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "VALIDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "LIEU";
            // 
            // tLIEU
            // 
            this.tLIEU.Location = new System.Drawing.Point(120, 133);
            this.tLIEU.Name = "tLIEU";
            this.tLIEU.Size = new System.Drawing.Size(229, 20);
            this.tLIEU.TabIndex = 14;
            // 
            // FormAjouterUnProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 290);
            this.Controls.Add(this.tLIEU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tDateDebut);
            this.Controls.Add(this.tDateFIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tChefDuProject);
            this.Controls.Add(this.tcodeProject);
            this.Controls.Add(this.tLibeleProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterUnProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjouterUnProject";
            this.Load += new System.EventHandler(this.FormAjouterUnProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tLibeleProject;
        private System.Windows.Forms.TextBox tcodeProject;
        private System.Windows.Forms.TextBox tChefDuProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tDateFIN;
        private System.Windows.Forms.DateTimePicker tDateDebut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tLIEU;
    }
}