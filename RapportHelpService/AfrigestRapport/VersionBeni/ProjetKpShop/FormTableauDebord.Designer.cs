namespace GoldenStarApplication
{
    partial class FormTableauDebord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableauDebord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEnUsd = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 42);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 247);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.cbEnUsd);
            this.tabPage1.Controls.Add(this.button34);
            this.tabPage1.Controls.Add(this.button33);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "      ANNALYSE DE VENTE       ";
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.White;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button34.Location = new System.Drawing.Point(78, 135);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(335, 37);
            this.button34.TabIndex = 46;
            this.button34.Text = "ANALYSE DE VENTE";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.White;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33.Location = new System.Drawing.Point(78, 178);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(335, 37);
            this.button33.TabIndex = 45;
            this.button33.Text = "  STOCK";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Visible = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(554, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 39);
            this.panel3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VOLUME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "QTE";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.tDateR1);
            this.panel2.Controls.Add(this.tdateR2);
            this.panel2.Location = new System.Drawing.Point(33, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 54);
            this.panel2.TabIndex = 39;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(179, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 13);
            this.label30.TabIndex = 38;
            this.label30.Text = "AU ";
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(23, 16);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(130, 23);
            this.tDateR1.TabIndex = 37;
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(243, 16);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(132, 23);
            this.tdateR2.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CAISSE ET VERSEMENT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(80, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 148);
            this.panel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SORTIE";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(87, 47);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(87, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ENTREE";
            // 
            // cbEnUsd
            // 
            this.cbEnUsd.AutoSize = true;
            this.cbEnUsd.Location = new System.Drawing.Point(44, 25);
            this.cbEnUsd.Name = "cbEnUsd";
            this.cbEnUsd.Size = new System.Drawing.Size(67, 17);
            this.cbEnUsd.TabIndex = 47;
            this.cbEnUsd.Text = "EN USD";
            this.cbEnUsd.UseVisualStyleBackColor = true;
            // 
            // FormTableauDebord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 289);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTableauDebord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTableauDebord";
            this.Load += new System.EventHandler(this.FormTableauDebord_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.CheckBox cbEnUsd;
    }
}