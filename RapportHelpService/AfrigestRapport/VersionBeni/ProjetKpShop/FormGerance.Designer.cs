namespace GoldenStarApplication
{
    partial class FormGerance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tdateAlancer = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tDaActurer = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tFraisdeTransEmbllage = new System.Windows.Forms.TextBox();
            this.tFraisdeTransProduit = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tTaux = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TauxDeTransport = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 26);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 259);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tdateAlancer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LANCER LA DATE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "LANCER ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tdateAlancer
            // 
            this.tdateAlancer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateAlancer.Location = new System.Drawing.Point(166, 79);
            this.tdateAlancer.Name = "tdateAlancer";
            this.tdateAlancer.Size = new System.Drawing.Size(226, 23);
            this.tdateAlancer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATE A LANCER";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tDaActurer);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLUTURER";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "CLUTURER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tDaActurer
            // 
            this.tDaActurer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDaActurer.Location = new System.Drawing.Point(193, 50);
            this.tDaActurer.Name = "tDaActurer";
            this.tDaActurer.Size = new System.Drawing.Size(226, 23);
            this.tDaActurer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATE A CLUTURER";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tFraisdeTransEmbllage);
            this.tabPage3.Controls.Add(this.tFraisdeTransProduit);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.tTaux);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.TauxDeTransport);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TAUX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "FRAIS DE TRANS EMBALLAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "FRAIS DE TRANS PRODUIT";
            // 
            // tFraisdeTransEmbllage
            // 
            this.tFraisdeTransEmbllage.Location = new System.Drawing.Point(220, 121);
            this.tFraisdeTransEmbllage.Name = "tFraisdeTransEmbllage";
            this.tFraisdeTransEmbllage.Size = new System.Drawing.Size(206, 23);
            this.tFraisdeTransEmbllage.TabIndex = 11;
            // 
            // tFraisdeTransProduit
            // 
            this.tFraisdeTransProduit.Location = new System.Drawing.Point(220, 95);
            this.tFraisdeTransProduit.Name = "tFraisdeTransProduit";
            this.tFraisdeTransProduit.Size = new System.Drawing.Size(206, 23);
            this.tFraisdeTransProduit.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "LANCER LE TAUX";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tTaux
            // 
            this.tTaux.Location = new System.Drawing.Point(220, 37);
            this.tTaux.Name = "tTaux";
            this.tTaux.Size = new System.Drawing.Size(206, 23);
            this.tTaux.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "TAUX FC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TAUX DE TRANSP";
            // 
            // TauxDeTransport
            // 
            this.TauxDeTransport.Location = new System.Drawing.Point(220, 66);
            this.TauxDeTransport.Name = "TauxDeTransport";
            this.TauxDeTransport.Size = new System.Drawing.Size(206, 23);
            this.TauxDeTransport.TabIndex = 4;
            // 
            // FormGerance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 285);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormGerance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerance";
            this.Load += new System.EventHandler(this.FormGerance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tdateAlancer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker tDaActurer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tTaux;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TauxDeTransport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tFraisdeTransEmbllage;
        private System.Windows.Forms.TextBox tFraisdeTransProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}