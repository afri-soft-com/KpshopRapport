namespace GoldenStarApplication.FormPopVente
{
    partial class FormQte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQte));
            this.tQte = new System.Windows.Forms.TextBox();
            this.tPrixVente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lARTICLE = new System.Windows.Forms.Label();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bvalide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tQte
            // 
            this.tQte.Location = new System.Drawing.Point(152, 63);
            this.tQte.Multiline = true;
            this.tQte.Name = "tQte";
            this.tQte.Size = new System.Drawing.Size(152, 42);
            this.tQte.TabIndex = 0;
            this.tQte.Text = "1";
            this.tQte.TextChanged += new System.EventHandler(this.tQte_TextChanged);
            // 
            // tPrixVente
            // 
            this.tPrixVente.Location = new System.Drawing.Point(119, 15);
            this.tPrixVente.Name = "tPrixVente";
            this.tPrixVente.Size = new System.Drawing.Size(175, 20);
            this.tPrixVente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "QTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRIX DE  VENTE";
            // 
            // lARTICLE
            // 
            this.lARTICLE.AutoSize = true;
            this.lARTICLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lARTICLE.Location = new System.Drawing.Point(12, 9);
            this.lARTICLE.Name = "lARTICLE";
            this.lARTICLE.Size = new System.Drawing.Size(71, 16);
            this.lARTICLE.TabIndex = 4;
            this.lARTICLE.Text = "ARTICLE";
            // 
            // tTotal
            // 
            this.tTotal.Location = new System.Drawing.Point(119, 41);
            this.tTotal.Name = "tTotal";
            this.tTotal.Size = new System.Drawing.Size(175, 20);
            this.tTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tPrixVente);
            this.panel1.Location = new System.Drawing.Point(32, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 75);
            this.panel1.TabIndex = 7;
            // 
            // Bvalide
            // 
            this.Bvalide.BackColor = System.Drawing.Color.White;
            this.Bvalide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bvalide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvalide.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalide.Image = ((System.Drawing.Image)(resources.GetObject("Bvalide.Image")));
            this.Bvalide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bvalide.Location = new System.Drawing.Point(141, 193);
            this.Bvalide.Name = "Bvalide";
            this.Bvalide.Size = new System.Drawing.Size(163, 48);
            this.Bvalide.TabIndex = 51;
            this.Bvalide.Text = "VALIDE";
            this.Bvalide.UseVisualStyleBackColor = false;
            this.Bvalide.Click += new System.EventHandler(this.Bvalide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "++";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormQte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bvalide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lARTICLE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tQte);
            this.Name = "FormQte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIX DE VENTE";
            this.Load += new System.EventHandler(this.FormQte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tQte;
        private System.Windows.Forms.TextBox tPrixVente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lARTICLE;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bvalide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}