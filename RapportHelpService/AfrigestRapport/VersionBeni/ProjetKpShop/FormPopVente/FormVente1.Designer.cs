namespace GoldenStarApplication.FormPopVente
{
    partial class FormVente1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboDepotDes = new System.Windows.Forms.ComboBox();
            this.comboDepot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboDepotDes);
            this.panel1.Controls.Add(this.comboDepot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(42, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 310);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "VENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "LIVRE DE CAISSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "STOCK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "LES MOUVMENTS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "PAIEMENT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboDepotDes
            // 
            this.comboDepotDes.FormattingEnabled = true;
            this.comboDepotDes.Location = new System.Drawing.Point(197, 21);
            this.comboDepotDes.Name = "comboDepotDes";
            this.comboDepotDes.Size = new System.Drawing.Size(213, 21);
            this.comboDepotDes.TabIndex = 13;
            // 
            // comboDepot
            // 
            this.comboDepot.FormattingEnabled = true;
            this.comboDepot.Location = new System.Drawing.Point(128, 21);
            this.comboDepot.Name = "comboDepot";
            this.comboDepot.Size = new System.Drawing.Size(63, 21);
            this.comboDepot.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "POINT DE VENTE";
            // 
            // FormVente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 376);
            this.Controls.Add(this.panel1);
            this.Name = "FormVente1";
            this.Text = "FormVente1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboDepotDes;
        private System.Windows.Forms.ComboBox comboDepot;
        private System.Windows.Forms.Label label1;
    }
}