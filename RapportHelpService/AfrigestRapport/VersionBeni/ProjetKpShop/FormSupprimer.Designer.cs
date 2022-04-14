namespace GoldenStarApplication
{
    partial class FormSupprimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupprimer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUtilsateur = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.tDate2 = new System.Windows.Forms.DateTimePicker();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bEnreSupIdentite = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tLibelle = new System.Windows.Forms.TextBox();
            this.comboOperation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCompte = new System.Windows.Forms.DataGridView();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.DgClientPro = new System.Windows.Forms.DataGridView();
            this.dgchambre = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tdate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgClientPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgchambre)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 578);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboUtilsateur);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tdate);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     SUPRESSION                  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Par";
            // 
            // comboUtilsateur
            // 
            this.comboUtilsateur.FormattingEnabled = true;
            this.comboUtilsateur.Location = new System.Drawing.Point(646, 15);
            this.comboUtilsateur.Name = "comboUtilsateur";
            this.comboUtilsateur.Size = new System.Drawing.Size(163, 23);
            this.comboUtilsateur.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.tDate2);
            this.panel1.Controls.Add(this.tDate1);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(784, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 100);
            this.panel1.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(15, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 39);
            this.button7.TabIndex = 19;
            this.button7.Text = "APERCU DU RAPPOR SUPPIMER";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tDate2
            // 
            this.tDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tDate2.Location = new System.Drawing.Point(134, 12);
            this.tDate2.Name = "tDate2";
            this.tDate2.Size = new System.Drawing.Size(120, 20);
            this.tDate2.TabIndex = 3;
            // 
            // tDate1
            // 
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tDate1.Location = new System.Drawing.Point(15, 13);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(113, 20);
            this.tDate1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.bEnreSupIdentite);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tLibelle);
            this.panel3.Controls.Add(this.comboOperation);
            this.panel3.Location = new System.Drawing.Point(21, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 107);
            this.panel3.TabIndex = 13;
            // 
            // bEnreSupIdentite
            // 
            this.bEnreSupIdentite.BackColor = System.Drawing.Color.White;
            this.bEnreSupIdentite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnreSupIdentite.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnreSupIdentite.Image = ((System.Drawing.Image)(resources.GetObject("bEnreSupIdentite.Image")));
            this.bEnreSupIdentite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEnreSupIdentite.Location = new System.Drawing.Point(523, 3);
            this.bEnreSupIdentite.Name = "bEnreSupIdentite";
            this.bEnreSupIdentite.Size = new System.Drawing.Size(173, 39);
            this.bEnreSupIdentite.TabIndex = 25;
            this.bEnreSupIdentite.Text = "SUPPRIMMER";
            this.bEnreSupIdentite.UseVisualStyleBackColor = false;
            this.bEnreSupIdentite.Click += new System.EventHandler(this.bEnreSupIdentite_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 53);
            this.label7.TabIndex = 12;
            this.label7.Text = "LIBELLE DE L\'OPERATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "CHOISIR L\'OPERATION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tLibelle
            // 
            this.tLibelle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tLibelle.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLibelle.ForeColor = System.Drawing.SystemColors.Info;
            this.tLibelle.Location = new System.Drawing.Point(126, 42);
            this.tLibelle.Multiline = true;
            this.tLibelle.Name = "tLibelle";
            this.tLibelle.Size = new System.Drawing.Size(570, 53);
            this.tLibelle.TabIndex = 6;
            // 
            // comboOperation
            // 
            this.comboOperation.FormattingEnabled = true;
            this.comboOperation.Location = new System.Drawing.Point(169, 10);
            this.comboOperation.Name = "comboOperation";
            this.comboOperation.Size = new System.Drawing.Size(322, 23);
            this.comboOperation.TabIndex = 2;
            this.comboOperation.SelectedIndexChanged += new System.EventHandler(this.comboOperation_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgCompte);
            this.panel2.Controls.Add(this.dgStock);
            this.panel2.Controls.Add(this.DgClientPro);
            this.panel2.Controls.Add(this.dgchambre);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(30, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 353);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "AUTRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "MOUVEMENT EMBALLAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "LES STOKS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "COMPTABILITE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgCompte
            // 
            this.dgCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompte.Location = new System.Drawing.Point(12, 30);
            this.dgCompte.Name = "dgCompte";
            this.dgCompte.Size = new System.Drawing.Size(435, 161);
            this.dgCompte.TabIndex = 3;
            this.dgCompte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompte_CellContentClick);
            // 
            // dgStock
            // 
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Location = new System.Drawing.Point(453, 28);
            this.dgStock.Name = "dgStock";
            this.dgStock.Size = new System.Drawing.Size(521, 168);
            this.dgStock.TabIndex = 4;
            this.dgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DgClientPro
            // 
            this.DgClientPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgClientPro.Location = new System.Drawing.Point(471, 217);
            this.DgClientPro.Name = "DgClientPro";
            this.DgClientPro.Size = new System.Drawing.Size(537, 119);
            this.DgClientPro.TabIndex = 7;
            // 
            // dgchambre
            // 
            this.dgchambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgchambre.Location = new System.Drawing.Point(24, 218);
            this.dgchambre.Name = "dgchambre";
            this.dgchambre.Size = new System.Drawing.Size(423, 118);
            this.dgchambre.TabIndex = 5;
            this.dgchambre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgchambre_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "ACTUALISER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tdate
            // 
            this.tdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdate.Location = new System.Drawing.Point(285, 13);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(193, 20);
            this.tdate.TabIndex = 1;
            this.tdate.ValueChanged += new System.EventHandler(this.tdate_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RECHERCHER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSupprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupprimer";
            this.Load += new System.EventHandler(this.FormSupprimer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgClientPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgchambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgCompte;
        private System.Windows.Forms.ComboBox comboOperation;
        private System.Windows.Forms.DateTimePicker tdate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgchambre;
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.TextBox tLibelle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DgClientPro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bEnreSupIdentite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tDate2;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboUtilsateur;
    }
}