namespace GoldenStarApplication.FormPopVente
{
    partial class FormPaiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiment));
            this.panel16 = new System.Windows.Forms.Panel();
            this.lMotant = new System.Windows.Forms.Label();
            this.ltaux = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tmotantFC = new System.Windows.Forms.TextBox();
            this.CBcdf = new System.Windows.Forms.CheckBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.tNumOP = new System.Windows.Forms.TextBox();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.DgJournal = new System.Windows.Forms.DataGridView();
            this.NumOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBAutre = new System.Windows.Forms.RadioButton();
            this.RbRavitaillement = new System.Windows.Forms.RadioButton();
            this.RbDepense = new System.Windows.Forms.RadioButton();
            this.typeOP = new System.Windows.Forms.TextBox();
            this.panel16.SuspendLayout();
            this.pCredit.SuspendLayout();
            this.paneDebut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgJournal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.lMotant);
            this.panel16.Controls.Add(this.ltaux);
            this.panel16.Controls.Add(this.label18);
            this.panel16.Controls.Add(this.tmotantFC);
            this.panel16.Controls.Add(this.CBcdf);
            this.panel16.Controls.Add(this.button4);
            this.panel16.Controls.Add(this.CbSereferer);
            this.panel16.Controls.Add(this.tmotant);
            this.panel16.Location = new System.Drawing.Point(12, 259);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(512, 111);
            this.panel16.TabIndex = 36;
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
            // ltaux
            // 
            this.ltaux.AutoSize = true;
            this.ltaux.Location = new System.Drawing.Point(61, 43);
            this.ltaux.Name = "ltaux";
            this.ltaux.Size = new System.Drawing.Size(36, 13);
            this.ltaux.TabIndex = 27;
            this.ltaux.Text = "TAUX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "TAUX";
            // 
            // tmotantFC
            // 
            this.tmotantFC.Location = new System.Drawing.Point(4, 20);
            this.tmotantFC.Name = "tmotantFC";
            this.tmotantFC.ReadOnly = true;
            this.tmotantFC.Size = new System.Drawing.Size(120, 20);
            this.tmotantFC.TabIndex = 22;
            // 
            // CBcdf
            // 
            this.CBcdf.AutoSize = true;
            this.CBcdf.Location = new System.Drawing.Point(16, 3);
            this.CBcdf.Name = "CBcdf";
            this.CBcdf.Size = new System.Drawing.Size(49, 17);
            this.CBcdf.TabIndex = 23;
            this.CBcdf.Text = "USD";
            this.CBcdf.UseVisualStyleBackColor = true;
            this.CBcdf.CheckedChanged += new System.EventHandler(this.CBcdf_CheckedChanged);
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
            this.tLibelle.Location = new System.Drawing.Point(94, 68);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(430, 37);
            this.tLibelle.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 31;
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
            this.pCredit.Location = new System.Drawing.Point(272, 148);
            this.pCredit.Name = "pCredit";
            this.pCredit.Size = new System.Drawing.Size(252, 95);
            this.pCredit.TabIndex = 33;
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
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // comboCredit
            // 
            this.comboCredit.DropDownHeight = 100;
            this.comboCredit.FormattingEnabled = true;
            this.comboCredit.IntegralHeight = false;
            this.comboCredit.Location = new System.Drawing.Point(2, 36);
            this.comboCredit.Name = "comboCredit";
            this.comboCredit.Size = new System.Drawing.Size(155, 21);
            this.comboCredit.TabIndex = 0;
            // 
            // comboCrediDES
            // 
            this.comboCrediDES.DropDownHeight = 100;
            this.comboCrediDES.FormattingEnabled = true;
            this.comboCrediDES.IntegralHeight = false;
            this.comboCrediDES.Location = new System.Drawing.Point(1, 62);
            this.comboCrediDES.Name = "comboCrediDES";
            this.comboCrediDES.Size = new System.Drawing.Size(230, 21);
            this.comboCrediDES.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "CREDIT (Sortie)";
            // 
            // paneDebut
            // 
            this.paneDebut.BackColor = System.Drawing.Color.Transparent;
            this.paneDebut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDebut.Controls.Add(this.button19);
            this.paneDebut.Controls.Add(this.comboDebit);
            this.paneDebut.Controls.Add(this.comboDebitDes);
            this.paneDebut.Controls.Add(this.label15);
            this.paneDebut.Location = new System.Drawing.Point(17, 148);
            this.paneDebut.Name = "paneDebut";
            this.paneDebut.Size = new System.Drawing.Size(252, 95);
            this.paneDebut.TabIndex = 32;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(166, 10);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 49);
            this.button19.TabIndex = 36;
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
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
            this.comboDebit.SelectedIndexChanged += new System.EventHandler(this.comboDebit_SelectedIndexChanged);
            // 
            // comboDebitDes
            // 
            this.comboDebitDes.DropDownHeight = 100;
            this.comboDebitDes.FormattingEnabled = true;
            this.comboDebitDes.IntegralHeight = false;
            this.comboDebitDes.Location = new System.Drawing.Point(-1, 62);
            this.comboDebitDes.Name = "comboDebitDes";
            this.comboDebitDes.Size = new System.Drawing.Size(248, 21);
            this.comboDebitDes.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "DEBIT (Entrée)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "PAR";
            // 
            // tNumOP
            // 
            this.tNumOP.Location = new System.Drawing.Point(314, 0);
            this.tNumOP.Name = "tNumOP";
            this.tNumOP.Size = new System.Drawing.Size(145, 20);
            this.tNumOP.TabIndex = 37;
            // 
            // tDate1
            // 
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(116, -3);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(165, 20);
            this.tDate1.TabIndex = 38;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.DgJournal);
            this.panel1.Location = new System.Drawing.Point(8, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 199);
            this.panel1.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(306, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 39);
            this.button3.TabIndex = 40;
            this.button3.Text = "SUPPRIMMER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBAutre);
            this.panel2.Controls.Add(this.RbRavitaillement);
            this.panel2.Controls.Add(this.RbDepense);
            this.panel2.Location = new System.Drawing.Point(17, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 28);
            this.panel2.TabIndex = 52;
            // 
            // rBAutre
            // 
            this.rBAutre.AutoSize = true;
            this.rBAutre.Location = new System.Drawing.Point(323, 5);
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
            this.RbRavitaillement.Location = new System.Drawing.Point(159, 5);
            this.RbRavitaillement.Name = "RbRavitaillement";
            this.RbRavitaillement.Size = new System.Drawing.Size(128, 17);
            this.RbRavitaillement.TabIndex = 1;
            this.RbRavitaillement.TabStop = true;
            this.RbRavitaillement.Text = "Ravitaillemnt ( Entrée)";
            this.RbRavitaillement.UseVisualStyleBackColor = true;
            this.RbRavitaillement.CheckedChanged += new System.EventHandler(this.RbRavitaillement_CheckedChanged);
            // 
            // RbDepense
            // 
            this.RbDepense.AutoSize = true;
            this.RbDepense.Location = new System.Drawing.Point(23, 5);
            this.RbDepense.Name = "RbDepense";
            this.RbDepense.Size = new System.Drawing.Size(105, 17);
            this.RbDepense.TabIndex = 0;
            this.RbDepense.TabStop = true;
            this.RbDepense.Text = "Dépense ( sortie)";
            this.RbDepense.UseVisualStyleBackColor = true;
            this.RbDepense.CheckedChanged += new System.EventHandler(this.RbDepense_CheckedChanged);
            // 
            // typeOP
            // 
            this.typeOP.Location = new System.Drawing.Point(94, 111);
            this.typeOP.Name = "typeOP";
            this.typeOP.Size = new System.Drawing.Size(430, 20);
            this.typeOP.TabIndex = 53;
            // 
            // FormPaiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(534, 587);
            this.Controls.Add(this.typeOP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tDate1);
            this.Controls.Add(this.tNumOP);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.tLibelle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pCredit);
            this.Controls.Add(this.paneDebut);
            this.Controls.Add(this.label12);
            this.Name = "FormPaiment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPaiment";
            this.Load += new System.EventHandler(this.FormPaiment_Load);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pCredit.ResumeLayout(false);
            this.pCredit.PerformLayout();
            this.paneDebut.ResumeLayout(false);
            this.paneDebut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgJournal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lMotant;
        private System.Windows.Forms.Label ltaux;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tmotantFC;
        private System.Windows.Forms.CheckBox CBcdf;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tNumOP;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.DataGridView DgJournal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBAutre;
        private System.Windows.Forms.RadioButton RbRavitaillement;
        private System.Windows.Forms.RadioButton RbDepense;
        private System.Windows.Forms.TextBox typeOP;
    }
}