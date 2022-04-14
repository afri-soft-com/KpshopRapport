namespace GoldenStarApplication.FormPop
{
    partial class FormPopPassageDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopPassageDate));
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.cbVerificationUsd = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlibele = new System.Windows.Forms.Label();
            this.rBSynthese = new System.Windows.Forms.CheckBox();
            this.cbTouteLabalance = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "DU";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(184, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "AU";
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(211, 36);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(102, 23);
            this.tdateR2.TabIndex = 28;
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(57, 36);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(104, 23);
            this.tDateR1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(57, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 46);
            this.button4.TabIndex = 40;
            this.button4.Text = "VALIDER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbVerificationUsd
            // 
            this.cbVerificationUsd.AutoSize = true;
            this.cbVerificationUsd.Location = new System.Drawing.Point(79, 13);
            this.cbVerificationUsd.Name = "cbVerificationUsd";
            this.cbVerificationUsd.Size = new System.Drawing.Size(67, 17);
            this.cbVerificationUsd.TabIndex = 44;
            this.cbVerificationUsd.Text = "EN USD";
            this.cbVerificationUsd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbVerificationUsd);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.tdateR2);
            this.panel1.Controls.Add(this.tDateR1);
            this.panel1.Location = new System.Drawing.Point(56, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 163);
            this.panel1.TabIndex = 45;
            // 
            // tlibele
            // 
            this.tlibele.AutoSize = true;
            this.tlibele.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlibele.Location = new System.Drawing.Point(52, 25);
            this.tlibele.Name = "tlibele";
            this.tlibele.Size = new System.Drawing.Size(87, 20);
            this.tlibele.TabIndex = 46;
            this.tlibele.Text = "JOURNAL";
            // 
            // rBSynthese
            // 
            this.rBSynthese.AutoSize = true;
            this.rBSynthese.Location = new System.Drawing.Point(281, 48);
            this.rBSynthese.Name = "rBSynthese";
            this.rBSynthese.Size = new System.Drawing.Size(102, 17);
            this.rBSynthese.TabIndex = 45;
            this.rBSynthese.Text = "EN SYNTHESE";
            this.rBSynthese.UseVisualStyleBackColor = true;
            this.rBSynthese.Visible = false;
            // 
            // cbTouteLabalance
            // 
            this.cbTouteLabalance.AutoSize = true;
            this.cbTouteLabalance.Location = new System.Drawing.Point(281, 71);
            this.cbTouteLabalance.Name = "cbTouteLabalance";
            this.cbTouteLabalance.Size = new System.Drawing.Size(124, 17);
            this.cbTouteLabalance.TabIndex = 47;
            this.cbTouteLabalance.Text = "TOUS LA BALANCE";
            this.cbTouteLabalance.UseVisualStyleBackColor = true;
            this.cbTouteLabalance.Visible = false;
            // 
            // FormPopPassageDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(505, 278);
            this.Controls.Add(this.cbTouteLabalance);
            this.Controls.Add(this.rBSynthese);
            this.Controls.Add(this.tlibele);
            this.Controls.Add(this.panel1);
            this.Name = "FormPopPassageDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopPassageDate";
            this.Load += new System.EventHandler(this.FormPopPassageDate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbVerificationUsd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tlibele;
        private System.Windows.Forms.CheckBox rBSynthese;
        private System.Windows.Forms.CheckBox cbTouteLabalance;
    }
}