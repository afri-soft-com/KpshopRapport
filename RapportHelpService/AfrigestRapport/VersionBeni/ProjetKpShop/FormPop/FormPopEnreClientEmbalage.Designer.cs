namespace GoldenStarApplication.FormPop
{
    partial class FormPopEnreClientEmbalage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.comboBMatricule = new System.Windows.Forms.ComboBox();
            this.tBDesignationClientEmb = new System.Windows.Forms.TextBox();
            this.tBCodeClienAmblage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoNomMatricule = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEnre = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bWchargmentCombo = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.cBModification = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESIGNATIONS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODE";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(102, 14);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(224, 23);
            this.comboBoxCategorie.TabIndex = 4;
            this.comboBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorie_SelectedIndexChanged);
            this.comboBoxCategorie.Click += new System.EventHandler(this.comboBoxCategorie_Click);
            // 
            // comboBMatricule
            // 
            this.comboBMatricule.FormattingEnabled = true;
            this.comboBMatricule.Location = new System.Drawing.Point(106, 97);
            this.comboBMatricule.Name = "comboBMatricule";
            this.comboBMatricule.Size = new System.Drawing.Size(75, 23);
            this.comboBMatricule.TabIndex = 5;
            this.comboBMatricule.SelectedIndexChanged += new System.EventHandler(this.comboBMatricule_SelectedIndexChanged);
            // 
            // tBDesignationClientEmb
            // 
            this.tBDesignationClientEmb.Location = new System.Drawing.Point(106, 167);
            this.tBDesignationClientEmb.Name = "tBDesignationClientEmb";
            this.tBDesignationClientEmb.Size = new System.Drawing.Size(235, 20);
            this.tBDesignationClientEmb.TabIndex = 6;
            // 
            // tBCodeClienAmblage
            // 
            this.tBCodeClienAmblage.Location = new System.Drawing.Point(102, 71);
            this.tBCodeClienAmblage.Name = "tBCodeClienAmblage";
            this.tBCodeClienAmblage.Size = new System.Drawing.Size(224, 20);
            this.tBCodeClienAmblage.TabIndex = 7;
            this.tBCodeClienAmblage.TextChanged += new System.EventHandler(this.tBCodeClienAmblage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "CATEGORIE";
            // 
            // comboBoNomMatricule
            // 
            this.comboBoNomMatricule.FormattingEnabled = true;
            this.comboBoNomMatricule.Location = new System.Drawing.Point(106, 126);
            this.comboBoNomMatricule.Name = "comboBoNomMatricule";
            this.comboBoNomMatricule.Size = new System.Drawing.Size(235, 23);
            this.comboBoNomMatricule.TabIndex = 10;
            this.comboBoNomMatricule.SelectedIndexChanged += new System.EventHandler(this.comboBoNomMatricule_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoNomMatricule);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBCodeClienAmblage);
            this.panel1.Controls.Add(this.tBDesignationClientEmb);
            this.panel1.Controls.Add(this.comboBMatricule);
            this.panel1.Controls.Add(this.comboBoxCategorie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 203);
            this.panel1.TabIndex = 11;
            // 
            // btEnre
            // 
            this.btEnre.BackColor = System.Drawing.Color.White;
            this.btEnre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnre.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnre.Location = new System.Drawing.Point(46, 266);
            this.btEnre.Name = "btEnre";
            this.btEnre.Size = new System.Drawing.Size(106, 33);
            this.btEnre.TabIndex = 12;
            this.btEnre.Text = "ENREGISTTRER";
            this.btEnre.UseVisualStyleBackColor = false;
            this.btEnre.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(172, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "NOUVEAU";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(289, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bWchargmentCombo
            // 
            this.bWchargmentCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWchargmentCombo_DoWork);
            this.bWchargmentCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWchargmentCombo_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "COMPLETER LES IINFO";
            // 
            // cBModification
            // 
            this.cBModification.AutoSize = true;
            this.cBModification.Location = new System.Drawing.Point(309, 3);
            this.cBModification.Name = "cBModification";
            this.cBModification.Size = new System.Drawing.Size(103, 17);
            this.cBModification.TabIndex = 16;
            this.cBModification.Text = "MODIFICATION";
            this.cBModification.UseVisualStyleBackColor = true;
            // 
            // FormPopEnreClientEmbalage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 332);
            this.Controls.Add(this.cBModification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btEnre);
            this.Controls.Add(this.panel1);
            this.Name = "FormPopEnreClientEmbalage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopEnreClientEmbalage";
            this.Load += new System.EventHandler(this.FormPopEnreClientEmbalage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.ComboBox comboBMatricule;
        private System.Windows.Forms.TextBox tBDesignationClientEmb;
        private System.Windows.Forms.TextBox tBCodeClienAmblage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoNomMatricule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEnre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker bWchargmentCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBModification;
    }
}