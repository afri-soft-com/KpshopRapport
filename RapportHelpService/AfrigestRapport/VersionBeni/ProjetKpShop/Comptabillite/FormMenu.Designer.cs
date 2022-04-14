namespace GoldenStarApplication.Comptabillite
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.bCreeUnCompte = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCreeUnCompte
            // 
            this.bCreeUnCompte.BackColor = System.Drawing.Color.Snow;
            this.bCreeUnCompte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCreeUnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreeUnCompte.Image = ((System.Drawing.Image)(resources.GetObject("bCreeUnCompte.Image")));
            this.bCreeUnCompte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCreeUnCompte.Location = new System.Drawing.Point(35, 41);
            this.bCreeUnCompte.Name = "bCreeUnCompte";
            this.bCreeUnCompte.Size = new System.Drawing.Size(320, 42);
            this.bCreeUnCompte.TabIndex = 0;
            this.bCreeUnCompte.Text = "OPERATIONS  COMPTABLES";
            this.bCreeUnCompte.UseVisualStyleBackColor = false;
            this.bCreeUnCompte.Click += new System.EventHandler(this.bCreeUnCompte_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(35, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "GRAND LIVRE OU EXTRAIT DE COMPTE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(35, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "CREATION DES COMPTES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "JOURNAL DES OPERATIONS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bCreeUnCompte);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreeUnCompte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}