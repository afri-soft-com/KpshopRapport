namespace GoldenStarApplication.ProjetBatiment
{
    partial class FormCaisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaisse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.DgJournal = new System.Windows.Forms.DataGridView();
            this.NumOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.tNumOP = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lMotant = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CbSereferer = new System.Windows.Forms.CheckBox();
            this.tmotant = new System.Windows.Forms.TextBox();
            this.tLibelle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pCredit = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.comboCredit = new System.Windows.Forms.ComboBox();
            this.comboCrediDES = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.paneDebut = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.comboDebit = new System.Windows.Forms.ComboBox();
            this.comboDebitDes = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBAutre = new System.Windows.Forms.RadioButton();
            this.RbRavitaillement = new System.Windows.Forms.RadioButton();
            this.RbDepense = new System.Windows.Forms.RadioButton();
            this.comboEtatCodeDES = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboEtatCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pEB = new System.Windows.Forms.Panel();
            this.cBProject = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgJournal)).BeginInit();
            this.panel16.SuspendLayout();
            this.pCredit.SuspendLayout();
            this.paneDebut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pEB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.DgJournal);
            this.panel1.Location = new System.Drawing.Point(29, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 199);
            this.panel1.TabIndex = 50;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(313, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 39);
            this.button3.TabIndex = 40;
            this.button3.Text = "SUPPRIMMER";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DgJournal
            // 
            this.DgJournal.AllowUserToAddRows = false;
            this.DgJournal.AllowUserToDeleteRows = false;
            this.DgJournal.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOperation,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgJournal.Location = new System.Drawing.Point(9, 6);
            this.DgJournal.Name = "DgJournal";
            this.DgJournal.ReadOnly = true;
            this.DgJournal.Size = new System.Drawing.Size(502, 141);
            this.DgJournal.TabIndex = 39;
            // 
            // NumOperation
            // 
            this.NumOperation.DataPropertyName = "NumOperation";
            this.NumOperation.HeaderText = "No";
            this.NumOperation.Name = "NumOperation";
            this.NumOperation.ReadOnly = true;
            this.NumOperation.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Libelle";
            this.dataGridViewTextBoxColumn4.HeaderText = "LIBELLE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Entree";
            this.dataGridViewTextBoxColumn5.HeaderText = "DEBIT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sortie";
            this.Column6.HeaderText = "CREDIT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NumCompte";
            this.Column7.HeaderText = "COMPTE";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DesignationCompte";
            this.Column8.HeaderText = "DESIGNATION";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // tDate1
            // 
            this.tDate1.Enabled = false;
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(161, 2);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(165, 20);
            this.tDate1.TabIndex = 49;
            // 
            // tNumOP
            // 
            this.tNumOP.Location = new System.Drawing.Point(332, 2);
            this.tNumOP.Name = "tNumOP";
            this.tNumOP.Size = new System.Drawing.Size(145, 20);
            this.tNumOP.TabIndex = 48;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.lMotant);
            this.panel16.Controls.Add(this.button4);
            this.panel16.Controls.Add(this.CbSereferer);
            this.panel16.Controls.Add(this.tmotant);
            this.panel16.Location = new System.Drawing.Point(24, 278);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(527, 97);
            this.panel16.TabIndex = 47;
            // 
            // lMotant
            // 
            this.lMotant.AutoSize = true;
            this.lMotant.BackColor = System.Drawing.Color.Black;
            this.lMotant.ForeColor = System.Drawing.Color.White;
            this.lMotant.Location = new System.Drawing.Point(334, 20);
            this.lMotant.Name = "lMotant";
            this.lMotant.Size = new System.Drawing.Size(13, 13);
            this.lMotant.TabIndex = 28;
            this.lMotant.Text = "L";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(160, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "VALIDER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CbSereferer
            // 
            this.CbSereferer.AutoSize = true;
            this.CbSereferer.Location = new System.Drawing.Point(334, 42);
            this.CbSereferer.Name = "CbSereferer";
            this.CbSereferer.Size = new System.Drawing.Size(112, 30);
            this.CbSereferer.TabIndex = 9;
            this.CbSereferer.Text = "SE REFERE ALA \r\n DERINIERE OP";
            this.CbSereferer.UseVisualStyleBackColor = true;
            // 
            // tmotant
            // 
            this.tmotant.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmotant.Location = new System.Drawing.Point(160, 16);
            this.tmotant.Name = "tmotant";
            this.tmotant.Size = new System.Drawing.Size(168, 22);
            this.tmotant.TabIndex = 7;
            // 
            // tLibelle
            // 
            this.tLibelle.Location = new System.Drawing.Point(180, 122);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(319, 34);
            this.tLibelle.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "LIBELLE";
            // 
            // pCredit
            // 
            this.pCredit.BackColor = System.Drawing.Color.Transparent;
            this.pCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCredit.Controls.Add(this.button20);
            this.pCredit.Controls.Add(this.comboCredit);
            this.pCredit.Controls.Add(this.comboCrediDES);
            this.pCredit.Controls.Add(this.label14);
            this.pCredit.Location = new System.Drawing.Point(295, 162);
            this.pCredit.Name = "pCredit";
            this.pCredit.Size = new System.Drawing.Size(256, 99);
            this.pCredit.TabIndex = 44;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(163, 7);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(65, 52);
            this.button20.TabIndex = 37;
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // comboCredit
            // 
            this.comboCredit.DropDownHeight = 100;
            this.comboCredit.FormattingEnabled = true;
            this.comboCredit.IntegralHeight = false;
            this.comboCredit.Location = new System.Drawing.Point(2, 36);
            this.comboCredit.Name = "comboCredit";
            this.comboCredit.Size = new System.Drawing.Size(144, 21);
            this.comboCredit.TabIndex = 0;
            // 
            // comboCrediDES
            // 
            this.comboCrediDES.DropDownHeight = 100;
            this.comboCrediDES.FormattingEnabled = true;
            this.comboCrediDES.IntegralHeight = false;
            this.comboCrediDES.Location = new System.Drawing.Point(3, 64);
            this.comboCrediDES.Name = "comboCrediDES";
            this.comboCrediDES.Size = new System.Drawing.Size(230, 21);
            this.comboCrediDES.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 27);
            this.label14.TabIndex = 1;
            this.label14.Text = "CREDIT";
            // 
            // paneDebut
            // 
            this.paneDebut.BackColor = System.Drawing.Color.Transparent;
            this.paneDebut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDebut.Controls.Add(this.button19);
            this.paneDebut.Controls.Add(this.comboDebit);
            this.paneDebut.Controls.Add(this.comboDebitDes);
            this.paneDebut.Controls.Add(this.label15);
            this.paneDebut.Location = new System.Drawing.Point(24, 162);
            this.paneDebut.Name = "paneDebut";
            this.paneDebut.Size = new System.Drawing.Size(244, 99);
            this.paneDebut.TabIndex = 43;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(158, 10);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 49);
            this.button19.TabIndex = 36;
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // comboDebit
            // 
            this.comboDebit.DropDownHeight = 100;
            this.comboDebit.FormattingEnabled = true;
            this.comboDebit.IntegralHeight = false;
            this.comboDebit.Location = new System.Drawing.Point(0, 36);
            this.comboDebit.Name = "comboDebit";
            this.comboDebit.Size = new System.Drawing.Size(149, 21);
            this.comboDebit.TabIndex = 0;
            // 
            // comboDebitDes
            // 
            this.comboDebitDes.DropDownHeight = 100;
            this.comboDebitDes.FormattingEnabled = true;
            this.comboDebitDes.IntegralHeight = false;
            this.comboDebitDes.Location = new System.Drawing.Point(-1, 62);
            this.comboDebitDes.Name = "comboDebitDes";
            this.comboDebitDes.Size = new System.Drawing.Size(236, 21);
            this.comboDebitDes.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "DEBIT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBAutre);
            this.panel2.Controls.Add(this.RbRavitaillement);
            this.panel2.Controls.Add(this.RbDepense);
            this.panel2.Location = new System.Drawing.Point(35, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 36);
            this.panel2.TabIndex = 51;
            // 
            // rBAutre
            // 
            this.rBAutre.AutoSize = true;
            this.rBAutre.Location = new System.Drawing.Point(242, 12);
            this.rBAutre.Name = "rBAutre";
            this.rBAutre.Size = new System.Drawing.Size(55, 17);
            this.rBAutre.TabIndex = 2;
            this.rBAutre.TabStop = true;
            this.rBAutre.Text = "Autres";
            this.rBAutre.UseVisualStyleBackColor = true;
            this.rBAutre.CheckedChanged += new System.EventHandler(this.rBAutre_CheckedChanged);
            // 
            // RbRavitaillement
            // 
            this.RbRavitaillement.AutoSize = true;
            this.RbRavitaillement.Location = new System.Drawing.Point(139, 12);
            this.RbRavitaillement.Name = "RbRavitaillement";
            this.RbRavitaillement.Size = new System.Drawing.Size(85, 17);
            this.RbRavitaillement.TabIndex = 1;
            this.RbRavitaillement.TabStop = true;
            this.RbRavitaillement.Text = "Ravitaillemnt";
            this.RbRavitaillement.UseVisualStyleBackColor = true;
            this.RbRavitaillement.CheckedChanged += new System.EventHandler(this.RbRavitaillement_CheckedChanged);
            // 
            // RbDepense
            // 
            this.RbDepense.AutoSize = true;
            this.RbDepense.Location = new System.Drawing.Point(31, 12);
            this.RbDepense.Name = "RbDepense";
            this.RbDepense.Size = new System.Drawing.Size(68, 17);
            this.RbDepense.TabIndex = 0;
            this.RbDepense.TabStop = true;
            this.RbDepense.Text = "Dépense";
            this.RbDepense.UseVisualStyleBackColor = true;
            this.RbDepense.CheckedChanged += new System.EventHandler(this.RbDepense_CheckedChanged);
            // 
            // comboEtatCodeDES
            // 
            this.comboEtatCodeDES.FormattingEnabled = true;
            this.comboEtatCodeDES.Location = new System.Drawing.Point(215, 8);
            this.comboEtatCodeDES.Name = "comboEtatCodeDES";
            this.comboEtatCodeDES.Size = new System.Drawing.Size(207, 21);
            this.comboEtatCodeDES.TabIndex = 52;
            this.comboEtatCodeDES.SelectedIndexChanged += new System.EventHandler(this.comboEtatCodeDES_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "DETAIL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboEtatCode
            // 
            this.comboEtatCode.FormattingEnabled = true;
            this.comboEtatCode.Location = new System.Drawing.Point(123, 7);
            this.comboEtatCode.Name = "comboEtatCode";
            this.comboEtatCode.Size = new System.Drawing.Size(86, 21);
            this.comboEtatCode.TabIndex = 54;
            this.comboEtatCode.SelectedIndexChanged += new System.EventHandler(this.comboEtatCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "EB";
            // 
            // pEB
            // 
            this.pEB.Controls.Add(this.cBProject);
            this.pEB.Controls.Add(this.label1);
            this.pEB.Controls.Add(this.comboEtatCode);
            this.pEB.Controls.Add(this.button1);
            this.pEB.Controls.Add(this.comboEtatCodeDES);
            this.pEB.Location = new System.Drawing.Point(38, 73);
            this.pEB.Name = "pEB";
            this.pEB.Size = new System.Drawing.Size(525, 43);
            this.pEB.TabIndex = 56;
            // 
            // cBProject
            // 
            this.cBProject.FormattingEnabled = true;
            this.cBProject.Location = new System.Drawing.Point(32, 7);
            this.cBProject.Name = "cBProject";
            this.cBProject.Size = new System.Drawing.Size(86, 21);
            this.cBProject.TabIndex = 56;
            // 
            // FormCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 592);
            this.Controls.Add(this.pEB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.tNumOP);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.pCredit);
            this.Controls.Add(this.tLibelle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.paneDebut);
            this.Name = "FormCaisse";
            this.Text = "FormCaisse";
            this.Load += new System.EventHandler(this.FormCaisse_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgJournal)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pCredit.ResumeLayout(false);
            this.pCredit.PerformLayout();
            this.paneDebut.ResumeLayout(false);
            this.paneDebut.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pEB.ResumeLayout(false);
            this.pEB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DgJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.TextBox tNumOP;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lMotant;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox CbSereferer;
        private System.Windows.Forms.TextBox tmotant;
        private System.Windows.Forms.TextBox tLibelle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pCredit;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ComboBox comboCredit;
        private System.Windows.Forms.ComboBox comboCrediDES;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel paneDebut;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ComboBox comboDebit;
        private System.Windows.Forms.ComboBox comboDebitDes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBAutre;
        private System.Windows.Forms.RadioButton RbRavitaillement;
        private System.Windows.Forms.RadioButton RbDepense;
        private System.Windows.Forms.ComboBox comboEtatCodeDES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboEtatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pEB;
        private System.Windows.Forms.ComboBox cBProject;

    }
}