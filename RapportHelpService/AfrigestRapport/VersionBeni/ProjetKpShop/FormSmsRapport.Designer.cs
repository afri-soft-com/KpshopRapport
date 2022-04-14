namespace GoldenStarApplication
{
    partial class FormSmsRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSmsRapport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tDate1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.tSmsEnvoye = new System.Windows.Forms.TextBox();
            this.tSmsNonEnvoy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lnombre = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboCateGorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ProgressBarSms = new System.Windows.Forms.ProgressBar();
            this.bWenvoyerSMS = new System.ComponentModel.BackgroundWorker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lnombreIND = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tMessageIndividuel = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboNomsCilents = new System.Windows.Forms.ComboBox();
            this.comboMatriculeClients = new System.Windows.Forms.ComboBox();
            this.bRecherche = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.tDate1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 28);
            this.panel1.TabIndex = 0;
            // 
            // tDate1
            // 
            this.tDate1.Enabled = false;
            this.tDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate1.Location = new System.Drawing.Point(173, 4);
            this.tDate1.Name = "tDate1";
            this.tDate1.Size = new System.Drawing.Size(165, 20);
            this.tDate1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     SMS       ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(75, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 23);
            this.progressBar1.Step = 40;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.tdateR2);
            this.panel2.Controls.Add(this.tDateR1);
            this.panel2.Controls.Add(this.tSmsEnvoye);
            this.panel2.Controls.Add(this.tSmsNonEnvoy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(34, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 426);
            this.panel2.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(130, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 37);
            this.button6.TabIndex = 37;
            this.button6.Text = "ANNULER LES SMS NON ENVOYE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(130, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 37);
            this.button4.TabIndex = 36;
            this.button4.Text = "LES SANS NUMERO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(130, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "APERCU SMS ENVOYE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(130, 233);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(235, 37);
            this.button11.TabIndex = 34;
            this.button11.Text = "APERCU  SMS  NON ENVOYE";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(130, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "ENVOYER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(130, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 38);
            this.button7.TabIndex = 25;
            this.button7.Text = "ACCTUALISER";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(263, 73);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(102, 23);
            this.tdateR2.TabIndex = 23;
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(130, 73);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(104, 23);
            this.tDateR1.TabIndex = 24;
            // 
            // tSmsEnvoye
            // 
            this.tSmsEnvoye.Location = new System.Drawing.Point(207, 148);
            this.tSmsEnvoye.Name = "tSmsEnvoye";
            this.tSmsEnvoye.Size = new System.Drawing.Size(158, 20);
            this.tSmsEnvoye.TabIndex = 3;
            // 
            // tSmsNonEnvoy
            // 
            this.tSmsNonEnvoy.Location = new System.Drawing.Point(207, 122);
            this.tSmsNonEnvoy.Name = "tSmsNonEnvoy";
            this.tSmsNonEnvoy.Size = new System.Drawing.Size(158, 20);
            this.tSmsNonEnvoy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMS ENVOYES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMS NON ENVOYES";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.ProgressBarSms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMS COLLCECTIF";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Lnombre);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.comboCateGorie);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tMessage);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(32, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 265);
            this.panel3.TabIndex = 52;
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(288, 4);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(44, 13);
            this.Lnombre.TabIndex = 51;
            this.Lnombre.Text = "Nombre";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(119, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 38);
            this.button5.TabIndex = 50;
            this.button5.Text = "ENVOYER LES RESTOURNE AU CLIENTS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboCateGorie
            // 
            this.comboCateGorie.FormattingEnabled = true;
            this.comboCateGorie.Location = new System.Drawing.Point(119, 148);
            this.comboCateGorie.Name = "comboCateGorie";
            this.comboCateGorie.Size = new System.Drawing.Size(303, 21);
            this.comboCateGorie.TabIndex = 47;
            this.comboCateGorie.SelectedIndexChanged += new System.EventHandler(this.comboCateGorie_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "MESSAGES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "CATEGORIE";
            // 
            // tMessage
            // 
            this.tMessage.Location = new System.Drawing.Point(43, 19);
            this.tMessage.MaxLength = 320;
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(379, 123);
            this.tMessage.TabIndex = 28;
            this.tMessage.TextChanged += new System.EventHandler(this.tMessage_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(119, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "ENVOYER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProgressBarSms
            // 
            this.ProgressBarSms.Location = new System.Drawing.Point(56, 15);
            this.ProgressBarSms.Name = "ProgressBarSms";
            this.ProgressBarSms.Size = new System.Drawing.Size(416, 23);
            this.ProgressBarSms.TabIndex = 49;
            // 
            // bWenvoyerSMS
            // 
            this.bWenvoyerSMS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bWenvoyerSMS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWenvoyerSMS_RunWorkerCompleted);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Khaki;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(503, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SMS INDIVIDUEL";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboNomsCilents);
            this.panel4.Controls.Add(this.comboMatriculeClients);
            this.panel4.Controls.Add(this.bRecherche);
            this.panel4.Controls.Add(this.lnombreIND);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tMessageIndividuel);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Location = new System.Drawing.Point(35, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 308);
            this.panel4.TabIndex = 53;
            // 
            // lnombreIND
            // 
            this.lnombreIND.AutoSize = true;
            this.lnombreIND.Location = new System.Drawing.Point(288, 4);
            this.lnombreIND.Name = "lnombreIND";
            this.lnombreIND.Size = new System.Drawing.Size(44, 13);
            this.lnombreIND.TabIndex = 51;
            this.lnombreIND.Text = "Nombre";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(119, 250);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(303, 38);
            this.button8.TabIndex = 50;
            this.button8.Text = "ENVOYER LES RESTOURNE AU CLIENTS";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "MESSAGES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "CLIENT";
            // 
            // tMessageIndividuel
            // 
            this.tMessageIndividuel.Location = new System.Drawing.Point(43, 19);
            this.tMessageIndividuel.MaxLength = 320;
            this.tMessageIndividuel.Multiline = true;
            this.tMessageIndividuel.Name = "tMessageIndividuel";
            this.tMessageIndividuel.Size = new System.Drawing.Size(379, 99);
            this.tMessageIndividuel.TabIndex = 28;
            this.tMessageIndividuel.TextChanged += new System.EventHandler(this.tMessageIndividuel_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(119, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(303, 38);
            this.button9.TabIndex = 27;
            this.button9.Text = "ENVOYER";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboNomsCilents
            // 
            this.comboNomsCilents.DropDownHeight = 150;
            this.comboNomsCilents.FormattingEnabled = true;
            this.comboNomsCilents.IntegralHeight = false;
            this.comboNomsCilents.Location = new System.Drawing.Point(157, 148);
            this.comboNomsCilents.Name = "comboNomsCilents";
            this.comboNomsCilents.Size = new System.Drawing.Size(213, 21);
            this.comboNomsCilents.TabIndex = 53;
            // 
            // comboMatriculeClients
            // 
            this.comboMatriculeClients.DropDownHeight = 150;
            this.comboMatriculeClients.FormattingEnabled = true;
            this.comboMatriculeClients.IntegralHeight = false;
            this.comboMatriculeClients.Location = new System.Drawing.Point(53, 148);
            this.comboMatriculeClients.Name = "comboMatriculeClients";
            this.comboMatriculeClients.Size = new System.Drawing.Size(98, 21);
            this.comboMatriculeClients.TabIndex = 52;
            // 
            // bRecherche
            // 
            this.bRecherche.BackColor = System.Drawing.Color.White;
            this.bRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecherche.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRecherche.Image = ((System.Drawing.Image)(resources.GetObject("bRecherche.Image")));
            this.bRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRecherche.Location = new System.Drawing.Point(376, 137);
            this.bRecherche.Name = "bRecherche";
            this.bRecherche.Size = new System.Drawing.Size(65, 35);
            this.bRecherche.TabIndex = 54;
            this.bRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRecherche.UseVisualStyleBackColor = false;
            this.bRecherche.Click += new System.EventHandler(this.bRecherche_Click);
            // 
            // FormSmsRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSmsRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSmsRapport";
            this.Load += new System.EventHandler(this.FormSmsRapport_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tSmsEnvoye;
        private System.Windows.Forms.TextBox tSmsNonEnvoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.ComponentModel.BackgroundWorker bWenvoyerSMS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCateGorie;
        private System.Windows.Forms.ProgressBar ProgressBarSms;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker tDate1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lnombreIND;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tMessageIndividuel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboNomsCilents;
        private System.Windows.Forms.ComboBox comboMatriculeClients;
        private System.Windows.Forms.Button bRecherche;
    }
}