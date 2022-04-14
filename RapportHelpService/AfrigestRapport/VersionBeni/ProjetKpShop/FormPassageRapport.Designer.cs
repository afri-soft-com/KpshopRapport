namespace GoldenStarApplication
{
    partial class FormPassageRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPassageRapport));
            this.panelBalance = new System.Windows.Forms.Panel();
            this.cbBalanceMvt = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRecherche = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCompte2Des = new System.Windows.Forms.ComboBox();
            this.comboCompte2 = new System.Windows.Forms.ComboBox();
            this.comboDesignatioGroupe = new System.Windows.Forms.ComboBox();
            this.comboCadre = new System.Windows.Forms.ComboBox();
            this.rbReleveBalance = new System.Windows.Forms.RadioButton();
            this.rbSousGroupe = new System.Windows.Forms.RadioButton();
            this.cbEnUsd = new System.Windows.Forms.CheckBox();
            this.rBSynthese = new System.Windows.Forms.RadioButton();
            this.rbPaGroupe = new System.Windows.Forms.RadioButton();
            this.rbTous = new System.Windows.Forms.RadioButton();
            this.button15 = new System.Windows.Forms.Button();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.bWchargment = new System.ComponentModel.BackgroundWorker();
            this.PanelChargeEtDepenses = new System.Windows.Forms.Panel();
            this.cbDepenseProfiMvt = new System.Windows.Forms.CheckBox();
            this.cbUsdResultat = new System.Windows.Forms.CheckBox();
            this.rbSyntheseResultq = new System.Windows.Forms.RadioButton();
            this.rbTousCharge = new System.Windows.Forms.RadioButton();
            this.panelTierse = new System.Windows.Forms.Panel();
            this.rbMouvmentTierce = new System.Windows.Forms.CheckBox();
            this.cbTiers = new System.Windows.Forms.CheckBox();
            this.rbSyntheseTerce = new System.Windows.Forms.RadioButton();
            this.rbTousTierce = new System.Windows.Forms.RadioButton();
            this.panelStock = new System.Windows.Forms.Panel();
            this.RbVnteEtVersment = new System.Windows.Forms.RadioButton();
            this.rbInventaire = new System.Windows.Forms.RadioButton();
            this.RbVenteGenSynthese = new System.Windows.Forms.RadioButton();
            this.RbVenteParSrd = new System.Windows.Forms.RadioButton();
            this.RbVenteGen = new System.Windows.Forms.RadioButton();
            this.comboCodeDepot2 = new System.Windows.Forms.ComboBox();
            this.rbBonGratuits = new System.Windows.Forms.RadioButton();
            this.rbParSrd = new System.Windows.Forms.RadioButton();
            this.rbTousleStocks = new System.Windows.Forms.RadioButton();
            this.pEmballage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSansSoldeNul = new System.Windows.Forms.CheckBox();
            this.comboBoxCategorie2 = new System.Windows.Forms.ComboBox();
            this.rbEmbLesStockAU = new System.Windows.Forms.RadioButton();
            this.rbEmbSomParCat = new System.Windows.Forms.RadioButton();
            this.rbEmbSomGL = new System.Windows.Forms.RadioButton();
            this.paneLRelever = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGroupe1 = new System.Windows.Forms.ComboBox();
            this.comboCadre1 = new System.Windows.Forms.ComboBox();
            this.comboCompte1 = new System.Windows.Forms.ComboBox();
            this.comboCompte1Des = new System.Windows.Forms.ComboBox();
            this.comboGroupe1Des = new System.Windows.Forms.ComboBox();
            this.comboCadreDes = new System.Windows.Forms.ComboBox();
            this.CbCdfCaisse = new System.Windows.Forms.CheckBox();
            this.panelBalance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelChargeEtDepenses.SuspendLayout();
            this.panelTierse.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.pEmballage.SuspendLayout();
            this.paneLRelever.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBalance
            // 
            this.panelBalance.BackColor = System.Drawing.Color.Khaki;
            this.panelBalance.Controls.Add(this.cbBalanceMvt);
            this.panelBalance.Controls.Add(this.panel1);
            this.panelBalance.Controls.Add(this.rbReleveBalance);
            this.panelBalance.Controls.Add(this.rbSousGroupe);
            this.panelBalance.Controls.Add(this.cbEnUsd);
            this.panelBalance.Controls.Add(this.rBSynthese);
            this.panelBalance.Controls.Add(this.rbPaGroupe);
            this.panelBalance.Controls.Add(this.rbTous);
            this.panelBalance.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBalance.Location = new System.Drawing.Point(148, 20);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(675, 136);
            this.panelBalance.TabIndex = 0;
            this.panelBalance.Visible = false;
            this.panelBalance.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbBalanceMvt
            // 
            this.cbBalanceMvt.AutoSize = true;
            this.cbBalanceMvt.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBalanceMvt.Location = new System.Drawing.Point(17, 26);
            this.cbBalanceMvt.Name = "cbBalanceMvt";
            this.cbBalanceMvt.Size = new System.Drawing.Size(179, 19);
            this.cbBalanceMvt.TabIndex = 11;
            this.cbBalanceMvt.Text = "UNIQUEMENT LES MOUVEMENTS";
            this.cbBalanceMvt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bRecherche);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboCompte2Des);
            this.panel1.Controls.Add(this.comboCompte2);
            this.panel1.Controls.Add(this.comboDesignatioGroupe);
            this.panel1.Controls.Add(this.comboCadre);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(237, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 97);
            this.panel1.TabIndex = 10;
            // 
            // bRecherche
            // 
            this.bRecherche.BackColor = System.Drawing.Color.White;
            this.bRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecherche.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRecherche.Image = ((System.Drawing.Image)(resources.GetObject("bRecherche.Image")));
            this.bRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRecherche.Location = new System.Drawing.Point(368, 59);
            this.bRecherche.Name = "bRecherche";
            this.bRecherche.Size = new System.Drawing.Size(49, 28);
            this.bRecherche.TabIndex = 39;
            this.bRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRecherche.UseVisualStyleBackColor = false;
            this.bRecherche.Click += new System.EventHandler(this.button21_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "COMPTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "GROUPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "CADRE";
            // 
            // comboCompte2Des
            // 
            this.comboCompte2Des.FormattingEnabled = true;
            this.comboCompte2Des.Location = new System.Drawing.Point(149, 62);
            this.comboCompte2Des.Name = "comboCompte2Des";
            this.comboCompte2Des.Size = new System.Drawing.Size(213, 24);
            this.comboCompte2Des.TabIndex = 9;
            this.comboCompte2Des.Visible = false;
            // 
            // comboCompte2
            // 
            this.comboCompte2.FormattingEnabled = true;
            this.comboCompte2.Location = new System.Drawing.Point(86, 62);
            this.comboCompte2.Name = "comboCompte2";
            this.comboCompte2.Size = new System.Drawing.Size(57, 24);
            this.comboCompte2.TabIndex = 8;
            this.comboCompte2.Visible = false;
            // 
            // comboDesignatioGroupe
            // 
            this.comboDesignatioGroupe.FormattingEnabled = true;
            this.comboDesignatioGroupe.Location = new System.Drawing.Point(86, 33);
            this.comboDesignatioGroupe.Name = "comboDesignatioGroupe";
            this.comboDesignatioGroupe.Size = new System.Drawing.Size(323, 24);
            this.comboDesignatioGroupe.TabIndex = 5;
            this.comboDesignatioGroupe.SelectedIndexChanged += new System.EventHandler(this.comboDesignatioGroupe_SelectedIndexChanged);
            // 
            // comboCadre
            // 
            this.comboCadre.FormattingEnabled = true;
            this.comboCadre.Location = new System.Drawing.Point(86, 4);
            this.comboCadre.Name = "comboCadre";
            this.comboCadre.Size = new System.Drawing.Size(323, 24);
            this.comboCadre.TabIndex = 2;
            this.comboCadre.SelectedIndexChanged += new System.EventHandler(this.comboCadre_SelectedIndexChanged);
            // 
            // rbReleveBalance
            // 
            this.rbReleveBalance.AutoSize = true;
            this.rbReleveBalance.Location = new System.Drawing.Point(509, 11);
            this.rbReleveBalance.Name = "rbReleveBalance";
            this.rbReleveBalance.Size = new System.Drawing.Size(154, 20);
            this.rbReleveBalance.TabIndex = 7;
            this.rbReleveBalance.TabStop = true;
            this.rbReleveBalance.Text = "RELEVE DETAILLE";
            this.rbReleveBalance.UseVisualStyleBackColor = true;
            this.rbReleveBalance.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSousGroupe
            // 
            this.rbSousGroupe.AutoSize = true;
            this.rbSousGroupe.Location = new System.Drawing.Point(365, 11);
            this.rbSousGroupe.Name = "rbSousGroupe";
            this.rbSousGroupe.Size = new System.Drawing.Size(153, 20);
            this.rbSousGroupe.TabIndex = 6;
            this.rbSousGroupe.TabStop = true;
            this.rbSousGroupe.Text = "POUR UN GROUPE";
            this.rbSousGroupe.UseVisualStyleBackColor = true;
            this.rbSousGroupe.CheckedChanged += new System.EventHandler(this.rbSousGroupe_CheckedChanged);
            // 
            // cbEnUsd
            // 
            this.cbEnUsd.AutoSize = true;
            this.cbEnUsd.Location = new System.Drawing.Point(17, 3);
            this.cbEnUsd.Name = "cbEnUsd";
            this.cbEnUsd.Size = new System.Drawing.Size(80, 20);
            this.cbEnUsd.TabIndex = 4;
            this.cbEnUsd.Text = "EN USD";
            this.cbEnUsd.UseVisualStyleBackColor = true;
            // 
            // rBSynthese
            // 
            this.rBSynthese.AutoSize = true;
            this.rBSynthese.Location = new System.Drawing.Point(101, 57);
            this.rBSynthese.Name = "rBSynthese";
            this.rBSynthese.Size = new System.Drawing.Size(101, 20);
            this.rBSynthese.TabIndex = 3;
            this.rBSynthese.TabStop = true;
            this.rBSynthese.Text = "SYNTHESE";
            this.rBSynthese.UseVisualStyleBackColor = true;
            this.rBSynthese.CheckedChanged += new System.EventHandler(this.rBSynthese_CheckedChanged);
            // 
            // rbPaGroupe
            // 
            this.rbPaGroupe.AutoSize = true;
            this.rbPaGroupe.Location = new System.Drawing.Point(229, 11);
            this.rbPaGroupe.Name = "rbPaGroupe";
            this.rbPaGroupe.Size = new System.Drawing.Size(144, 20);
            this.rbPaGroupe.TabIndex = 1;
            this.rbPaGroupe.TabStop = true;
            this.rbPaGroupe.Text = "POUR UN CADRE";
            this.rbPaGroupe.UseVisualStyleBackColor = true;
            this.rbPaGroupe.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbTous
            // 
            this.rbTous.AutoSize = true;
            this.rbTous.Location = new System.Drawing.Point(17, 57);
            this.rbTous.Name = "rbTous";
            this.rbTous.Size = new System.Drawing.Size(64, 20);
            this.rbTous.TabIndex = 0;
            this.rbTous.TabStop = true;
            this.rbTous.Text = "TOUS";
            this.rbTous.UseVisualStyleBackColor = true;
            this.rbTous.CheckedChanged += new System.EventHandler(this.rbTous_CheckedChanged);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(187, 218);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(470, 37);
            this.button15.TabIndex = 23;
            this.button15.Text = "APERCU ";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(278, 189);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(135, 23);
            this.tDateR1.TabIndex = 25;
            this.tDateR1.ValueChanged += new System.EventHandler(this.tDateR1_ValueChanged);
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(419, 189);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(131, 23);
            this.tdateR2.TabIndex = 24;
            this.tdateR2.ValueChanged += new System.EventHandler(this.tdateR2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "APERCU BALANCE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bWchargment
            // 
            this.bWchargment.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWchargment_DoWork);
            this.bWchargment.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWchargment_RunWorkerCompleted);
            // 
            // PanelChargeEtDepenses
            // 
            this.PanelChargeEtDepenses.BackColor = System.Drawing.Color.Khaki;
            this.PanelChargeEtDepenses.Controls.Add(this.cbDepenseProfiMvt);
            this.PanelChargeEtDepenses.Controls.Add(this.cbUsdResultat);
            this.PanelChargeEtDepenses.Controls.Add(this.rbSyntheseResultq);
            this.PanelChargeEtDepenses.Controls.Add(this.rbTousCharge);
            this.PanelChargeEtDepenses.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelChargeEtDepenses.Location = new System.Drawing.Point(44, 39);
            this.PanelChargeEtDepenses.Name = "PanelChargeEtDepenses";
            this.PanelChargeEtDepenses.Size = new System.Drawing.Size(736, 98);
            this.PanelChargeEtDepenses.TabIndex = 27;
            this.PanelChargeEtDepenses.Visible = false;
            // 
            // cbDepenseProfiMvt
            // 
            this.cbDepenseProfiMvt.AutoSize = true;
            this.cbDepenseProfiMvt.Location = new System.Drawing.Point(331, 27);
            this.cbDepenseProfiMvt.Name = "cbDepenseProfiMvt";
            this.cbDepenseProfiMvt.Size = new System.Drawing.Size(333, 20);
            this.cbDepenseProfiMvt.TabIndex = 5;
            this.cbDepenseProfiMvt.Text = " UNIQUEMENT MOUVEMENT DE LA PERIODE";
            this.cbDepenseProfiMvt.UseVisualStyleBackColor = true;
            // 
            // cbUsdResultat
            // 
            this.cbUsdResultat.AutoSize = true;
            this.cbUsdResultat.Location = new System.Drawing.Point(232, 26);
            this.cbUsdResultat.Name = "cbUsdResultat";
            this.cbUsdResultat.Size = new System.Drawing.Size(80, 20);
            this.cbUsdResultat.TabIndex = 4;
            this.cbUsdResultat.Text = "EN USD";
            this.cbUsdResultat.UseVisualStyleBackColor = true;
            // 
            // rbSyntheseResultq
            // 
            this.rbSyntheseResultq.AutoSize = true;
            this.rbSyntheseResultq.Location = new System.Drawing.Point(283, 67);
            this.rbSyntheseResultq.Name = "rbSyntheseResultq";
            this.rbSyntheseResultq.Size = new System.Drawing.Size(101, 20);
            this.rbSyntheseResultq.TabIndex = 3;
            this.rbSyntheseResultq.TabStop = true;
            this.rbSyntheseResultq.Text = "SYNTHESE";
            this.rbSyntheseResultq.UseVisualStyleBackColor = true;
            // 
            // rbTousCharge
            // 
            this.rbTousCharge.AutoSize = true;
            this.rbTousCharge.Location = new System.Drawing.Point(187, 64);
            this.rbTousCharge.Name = "rbTousCharge";
            this.rbTousCharge.Size = new System.Drawing.Size(64, 20);
            this.rbTousCharge.TabIndex = 0;
            this.rbTousCharge.TabStop = true;
            this.rbTousCharge.Text = "TOUS";
            this.rbTousCharge.UseVisualStyleBackColor = true;
            // 
            // panelTierse
            // 
            this.panelTierse.BackColor = System.Drawing.Color.Khaki;
            this.panelTierse.Controls.Add(this.rbMouvmentTierce);
            this.panelTierse.Controls.Add(this.cbTiers);
            this.panelTierse.Controls.Add(this.rbSyntheseTerce);
            this.panelTierse.Controls.Add(this.rbTousTierce);
            this.panelTierse.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTierse.Location = new System.Drawing.Point(67, 12);
            this.panelTierse.Name = "panelTierse";
            this.panelTierse.Size = new System.Drawing.Size(699, 161);
            this.panelTierse.TabIndex = 28;
            this.panelTierse.Visible = false;
            // 
            // rbMouvmentTierce
            // 
            this.rbMouvmentTierce.AutoSize = true;
            this.rbMouvmentTierce.Location = new System.Drawing.Point(252, 20);
            this.rbMouvmentTierce.Name = "rbMouvmentTierce";
            this.rbMouvmentTierce.Size = new System.Drawing.Size(359, 20);
            this.rbMouvmentTierce.TabIndex = 6;
            this.rbMouvmentTierce.Text = "UNIQUEMENTS LES MOUVEMNT DE LA PERIODE";
            this.rbMouvmentTierce.UseVisualStyleBackColor = true;
            // 
            // cbTiers
            // 
            this.cbTiers.AutoSize = true;
            this.cbTiers.Location = new System.Drawing.Point(150, 19);
            this.cbTiers.Name = "cbTiers";
            this.cbTiers.Size = new System.Drawing.Size(80, 20);
            this.cbTiers.TabIndex = 4;
            this.cbTiers.Text = "EN USD";
            this.cbTiers.UseVisualStyleBackColor = true;
            // 
            // rbSyntheseTerce
            // 
            this.rbSyntheseTerce.AutoSize = true;
            this.rbSyntheseTerce.Location = new System.Drawing.Point(176, 55);
            this.rbSyntheseTerce.Name = "rbSyntheseTerce";
            this.rbSyntheseTerce.Size = new System.Drawing.Size(101, 20);
            this.rbSyntheseTerce.TabIndex = 3;
            this.rbSyntheseTerce.TabStop = true;
            this.rbSyntheseTerce.Text = "SYNTHESE";
            this.rbSyntheseTerce.UseVisualStyleBackColor = true;
            // 
            // rbTousTierce
            // 
            this.rbTousTierce.AutoSize = true;
            this.rbTousTierce.Location = new System.Drawing.Point(93, 55);
            this.rbTousTierce.Name = "rbTousTierce";
            this.rbTousTierce.Size = new System.Drawing.Size(64, 20);
            this.rbTousTierce.TabIndex = 0;
            this.rbTousTierce.TabStop = true;
            this.rbTousTierce.Text = "TOUS";
            this.rbTousTierce.UseVisualStyleBackColor = true;
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.Khaki;
            this.panelStock.Controls.Add(this.RbVnteEtVersment);
            this.panelStock.Controls.Add(this.rbInventaire);
            this.panelStock.Controls.Add(this.RbVenteGenSynthese);
            this.panelStock.Controls.Add(this.RbVenteParSrd);
            this.panelStock.Controls.Add(this.RbVenteGen);
            this.panelStock.Controls.Add(this.comboCodeDepot2);
            this.panelStock.Controls.Add(this.rbBonGratuits);
            this.panelStock.Controls.Add(this.rbParSrd);
            this.panelStock.Controls.Add(this.rbTousleStocks);
            this.panelStock.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStock.Location = new System.Drawing.Point(22, 12);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(665, 156);
            this.panelStock.TabIndex = 29;
            this.panelStock.Visible = false;
            // 
            // RbVnteEtVersment
            // 
            this.RbVnteEtVersment.AutoSize = true;
            this.RbVnteEtVersment.Location = new System.Drawing.Point(354, 63);
            this.RbVnteEtVersment.Name = "RbVnteEtVersment";
            this.RbVnteEtVersment.Size = new System.Drawing.Size(187, 20);
            this.RbVnteEtVersment.TabIndex = 25;
            this.RbVnteEtVersment.TabStop = true;
            this.RbVnteEtVersment.Text = "VENTES ET VERSMENT";
            this.RbVnteEtVersment.UseVisualStyleBackColor = true;
            // 
            // rbInventaire
            // 
            this.rbInventaire.AutoSize = true;
            this.rbInventaire.Location = new System.Drawing.Point(8, 31);
            this.rbInventaire.Name = "rbInventaire";
            this.rbInventaire.Size = new System.Drawing.Size(113, 20);
            this.rbInventaire.TabIndex = 24;
            this.rbInventaire.TabStop = true;
            this.rbInventaire.Text = "INVENTAIRE";
            this.rbInventaire.UseVisualStyleBackColor = true;
            // 
            // RbVenteGenSynthese
            // 
            this.RbVenteGenSynthese.AutoSize = true;
            this.RbVenteGenSynthese.Location = new System.Drawing.Point(8, 85);
            this.RbVenteGenSynthese.Name = "RbVenteGenSynthese";
            this.RbVenteGenSynthese.Size = new System.Drawing.Size(244, 20);
            this.RbVenteGenSynthese.TabIndex = 23;
            this.RbVenteGenSynthese.TabStop = true;
            this.RbVenteGenSynthese.Text = "SITUATION VENTES SYNTHESE";
            this.RbVenteGenSynthese.UseVisualStyleBackColor = true;
            // 
            // RbVenteParSrd
            // 
            this.RbVenteParSrd.AutoSize = true;
            this.RbVenteParSrd.Location = new System.Drawing.Point(354, 38);
            this.RbVenteParSrd.Name = "RbVenteParSrd";
            this.RbVenteParSrd.Size = new System.Drawing.Size(227, 20);
            this.RbVenteParSrd.TabIndex = 22;
            this.RbVenteParSrd.TabStop = true;
            this.RbVenteParSrd.Text = "VENTES PAR DEPOT OU SRD";
            this.RbVenteParSrd.UseVisualStyleBackColor = true;
            this.RbVenteParSrd.CheckedChanged += new System.EventHandler(this.RbVenteParSrd_CheckedChanged);
            // 
            // RbVenteGen
            // 
            this.RbVenteGen.AutoSize = true;
            this.RbVenteGen.Location = new System.Drawing.Point(8, 60);
            this.RbVenteGen.Name = "RbVenteGen";
            this.RbVenteGen.Size = new System.Drawing.Size(227, 20);
            this.RbVenteGen.TabIndex = 21;
            this.RbVenteGen.TabStop = true;
            this.RbVenteGen.Text = "SITUATION VENTES  EN GEN";
            this.RbVenteGen.UseVisualStyleBackColor = true;
            // 
            // comboCodeDepot2
            // 
            this.comboCodeDepot2.Enabled = false;
            this.comboCodeDepot2.FormattingEnabled = true;
            this.comboCodeDepot2.Location = new System.Drawing.Point(352, 101);
            this.comboCodeDepot2.Name = "comboCodeDepot2";
            this.comboCodeDepot2.Size = new System.Drawing.Size(207, 24);
            this.comboCodeDepot2.TabIndex = 20;
            // 
            // rbBonGratuits
            // 
            this.rbBonGratuits.AutoSize = true;
            this.rbBonGratuits.Location = new System.Drawing.Point(8, 114);
            this.rbBonGratuits.Name = "rbBonGratuits";
            this.rbBonGratuits.Size = new System.Drawing.Size(143, 20);
            this.rbBonGratuits.TabIndex = 4;
            this.rbBonGratuits.TabStop = true;
            this.rbBonGratuits.Text = "SITUATION BON ";
            this.rbBonGratuits.UseVisualStyleBackColor = true;
            // 
            // rbParSrd
            // 
            this.rbParSrd.AutoSize = true;
            this.rbParSrd.Location = new System.Drawing.Point(352, 13);
            this.rbParSrd.Name = "rbParSrd";
            this.rbParSrd.Size = new System.Drawing.Size(219, 20);
            this.rbParSrd.TabIndex = 3;
            this.rbParSrd.TabStop = true;
            this.rbParSrd.Text = "STOCK PAR DEPOT OU SRD";
            this.rbParSrd.UseVisualStyleBackColor = true;
            this.rbParSrd.CheckedChanged += new System.EventHandler(this.rbParSrd_CheckedChanged);
            // 
            // rbTousleStocks
            // 
            this.rbTousleStocks.AutoSize = true;
            this.rbTousleStocks.Location = new System.Drawing.Point(8, 9);
            this.rbTousleStocks.Name = "rbTousleStocks";
            this.rbTousleStocks.Size = new System.Drawing.Size(214, 20);
            this.rbTousleStocks.TabIndex = 0;
            this.rbTousleStocks.TabStop = true;
            this.rbTousleStocks.Text = "SITUATION STOCK EN GEN";
            this.rbTousleStocks.UseVisualStyleBackColor = true;
            // 
            // pEmballage
            // 
            this.pEmballage.BackColor = System.Drawing.Color.Khaki;
            this.pEmballage.Controls.Add(this.label1);
            this.pEmballage.Controls.Add(this.cbSansSoldeNul);
            this.pEmballage.Controls.Add(this.comboBoxCategorie2);
            this.pEmballage.Controls.Add(this.rbEmbLesStockAU);
            this.pEmballage.Controls.Add(this.rbEmbSomParCat);
            this.pEmballage.Controls.Add(this.rbEmbSomGL);
            this.pEmballage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEmballage.Location = new System.Drawing.Point(111, 26);
            this.pEmballage.Name = "pEmballage";
            this.pEmballage.Size = new System.Drawing.Size(672, 124);
            this.pEmballage.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "CATEGORIE";
            // 
            // cbSansSoldeNul
            // 
            this.cbSansSoldeNul.AutoSize = true;
            this.cbSansSoldeNul.Location = new System.Drawing.Point(297, 66);
            this.cbSansSoldeNul.Name = "cbSansSoldeNul";
            this.cbSansSoldeNul.Size = new System.Drawing.Size(157, 20);
            this.cbSansSoldeNul.TabIndex = 10;
            this.cbSansSoldeNul.Text = "SANS SOLDE NULL";
            this.cbSansSoldeNul.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategorie2
            // 
            this.comboBoxCategorie2.FormattingEnabled = true;
            this.comboBoxCategorie2.Location = new System.Drawing.Point(299, 38);
            this.comboBoxCategorie2.Name = "comboBoxCategorie2";
            this.comboBoxCategorie2.Size = new System.Drawing.Size(233, 24);
            this.comboBoxCategorie2.TabIndex = 9;
            // 
            // rbEmbLesStockAU
            // 
            this.rbEmbLesStockAU.AutoSize = true;
            this.rbEmbLesStockAU.Location = new System.Drawing.Point(52, 61);
            this.rbEmbLesStockAU.Name = "rbEmbLesStockAU";
            this.rbEmbLesStockAU.Size = new System.Drawing.Size(231, 20);
            this.rbEmbLesStockAU.TabIndex = 2;
            this.rbEmbLesStockAU.TabStop = true;
            this.rbEmbLesStockAU.Text = "LES STOCK PAR CATEGORIE ";
            this.rbEmbLesStockAU.UseVisualStyleBackColor = true;
            // 
            // rbEmbSomParCat
            // 
            this.rbEmbSomParCat.AutoSize = true;
            this.rbEmbSomParCat.Location = new System.Drawing.Point(52, 38);
            this.rbEmbSomParCat.Name = "rbEmbSomParCat";
            this.rbEmbSomParCat.Size = new System.Drawing.Size(227, 20);
            this.rbEmbSomParCat.TabIndex = 1;
            this.rbEmbSomParCat.TabStop = true;
            this.rbEmbSomParCat.Text = "SOMMAIRE PAR CATEGORIE ";
            this.rbEmbSomParCat.UseVisualStyleBackColor = true;
            // 
            // rbEmbSomGL
            // 
            this.rbEmbSomGL.AutoSize = true;
            this.rbEmbSomGL.Location = new System.Drawing.Point(52, 15);
            this.rbEmbSomGL.Name = "rbEmbSomGL";
            this.rbEmbSomGL.Size = new System.Drawing.Size(162, 20);
            this.rbEmbSomGL.TabIndex = 0;
            this.rbEmbSomGL.TabStop = true;
            this.rbEmbSomGL.Text = "SOMMAIRE GLOBAL";
            this.rbEmbSomGL.UseVisualStyleBackColor = true;
            // 
            // paneLRelever
            // 
            this.paneLRelever.BackColor = System.Drawing.Color.Khaki;
            this.paneLRelever.Controls.Add(this.label4);
            this.paneLRelever.Controls.Add(this.label3);
            this.paneLRelever.Controls.Add(this.label2);
            this.paneLRelever.Controls.Add(this.comboGroupe1);
            this.paneLRelever.Controls.Add(this.comboCadre1);
            this.paneLRelever.Controls.Add(this.comboCompte1);
            this.paneLRelever.Controls.Add(this.comboCompte1Des);
            this.paneLRelever.Controls.Add(this.comboGroupe1Des);
            this.paneLRelever.Controls.Add(this.comboCadreDes);
            this.paneLRelever.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneLRelever.Location = new System.Drawing.Point(215, 290);
            this.paneLRelever.Name = "paneLRelever";
            this.paneLRelever.Size = new System.Drawing.Size(534, 101);
            this.paneLRelever.TabIndex = 31;
            this.paneLRelever.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "COMPTE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CADRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "GROUPE";
            // 
            // comboGroupe1
            // 
            this.comboGroupe1.FormattingEnabled = true;
            this.comboGroupe1.Location = new System.Drawing.Point(126, 41);
            this.comboGroupe1.Name = "comboGroupe1";
            this.comboGroupe1.Size = new System.Drawing.Size(72, 24);
            this.comboGroupe1.TabIndex = 9;
            this.comboGroupe1.SelectedIndexChanged += new System.EventHandler(this.comboGroupe1_SelectedIndexChanged);
            // 
            // comboCadre1
            // 
            this.comboCadre1.FormattingEnabled = true;
            this.comboCadre1.Location = new System.Drawing.Point(126, 12);
            this.comboCadre1.Name = "comboCadre1";
            this.comboCadre1.Size = new System.Drawing.Size(72, 24);
            this.comboCadre1.TabIndex = 8;
            this.comboCadre1.SelectedIndexChanged += new System.EventHandler(this.comboCadre1_SelectedIndexChanged);
            // 
            // comboCompte1
            // 
            this.comboCompte1.FormattingEnabled = true;
            this.comboCompte1.Location = new System.Drawing.Point(126, 70);
            this.comboCompte1.Name = "comboCompte1";
            this.comboCompte1.Size = new System.Drawing.Size(72, 24);
            this.comboCompte1.TabIndex = 7;
            // 
            // comboCompte1Des
            // 
            this.comboCompte1Des.FormattingEnabled = true;
            this.comboCompte1Des.Location = new System.Drawing.Point(204, 70);
            this.comboCompte1Des.Name = "comboCompte1Des";
            this.comboCompte1Des.Size = new System.Drawing.Size(238, 24);
            this.comboCompte1Des.TabIndex = 6;
            // 
            // comboGroupe1Des
            // 
            this.comboGroupe1Des.FormattingEnabled = true;
            this.comboGroupe1Des.Location = new System.Drawing.Point(204, 41);
            this.comboGroupe1Des.Name = "comboGroupe1Des";
            this.comboGroupe1Des.Size = new System.Drawing.Size(238, 24);
            this.comboGroupe1Des.TabIndex = 5;
            // 
            // comboCadreDes
            // 
            this.comboCadreDes.FormattingEnabled = true;
            this.comboCadreDes.Location = new System.Drawing.Point(204, 12);
            this.comboCadreDes.Name = "comboCadreDes";
            this.comboCadreDes.Size = new System.Drawing.Size(238, 24);
            this.comboCadreDes.TabIndex = 2;
            // 
            // CbCdfCaisse
            // 
            this.CbCdfCaisse.AutoSize = true;
            this.CbCdfCaisse.Location = new System.Drawing.Point(191, 189);
            this.CbCdfCaisse.Name = "CbCdfCaisse";
            this.CbCdfCaisse.Size = new System.Drawing.Size(47, 17);
            this.CbCdfCaisse.TabIndex = 32;
            this.CbCdfCaisse.Text = "CDF";
            this.CbCdfCaisse.UseVisualStyleBackColor = true;
            this.CbCdfCaisse.Visible = false;
            // 
            // FormPassageRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(822, 260);
            this.Controls.Add(this.panelBalance);
            this.Controls.Add(this.CbCdfCaisse);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.PanelChargeEtDepenses);
            this.Controls.Add(this.paneLRelever);
            this.Controls.Add(this.pEmballage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tDateR1);
            this.Controls.Add(this.tdateR2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.panelTierse);
            this.Name = "FormPassageRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V";
            this.Load += new System.EventHandler(this.FormPassageRapport_Load);
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelChargeEtDepenses.ResumeLayout(false);
            this.PanelChargeEtDepenses.PerformLayout();
            this.panelTierse.ResumeLayout(false);
            this.panelTierse.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.pEmballage.ResumeLayout(false);
            this.pEmballage.PerformLayout();
            this.paneLRelever.ResumeLayout(false);
            this.paneLRelever.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.RadioButton rbPaGroupe;
        private System.Windows.Forms.RadioButton rbTous;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboCadre;
        private System.ComponentModel.BackgroundWorker bWchargment;
        private System.Windows.Forms.RadioButton rBSynthese;
        private System.Windows.Forms.CheckBox cbEnUsd;
        private System.Windows.Forms.RadioButton rbSousGroupe;
        private System.Windows.Forms.ComboBox comboDesignatioGroupe;
        private System.Windows.Forms.Panel PanelChargeEtDepenses;
        private System.Windows.Forms.CheckBox cbUsdResultat;
        private System.Windows.Forms.RadioButton rbSyntheseResultq;
        private System.Windows.Forms.RadioButton rbTousCharge;
        private System.Windows.Forms.Panel panelTierse;
        private System.Windows.Forms.CheckBox cbTiers;
        private System.Windows.Forms.RadioButton rbSyntheseTerce;
        private System.Windows.Forms.RadioButton rbTousTierce;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.RadioButton rbBonGratuits;
        private System.Windows.Forms.RadioButton rbParSrd;
        private System.Windows.Forms.RadioButton rbTousleStocks;
        private System.Windows.Forms.ComboBox comboCodeDepot2;
        private System.Windows.Forms.Panel pEmballage;
        private System.Windows.Forms.RadioButton rbEmbSomParCat;
        private System.Windows.Forms.RadioButton rbEmbSomGL;
        private System.Windows.Forms.RadioButton rbEmbLesStockAU;
        private System.Windows.Forms.ComboBox comboBoxCategorie2;
        private System.Windows.Forms.CheckBox cbSansSoldeNul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbVenteGenSynthese;
        private System.Windows.Forms.RadioButton RbVenteParSrd;
        private System.Windows.Forms.RadioButton RbVenteGen;
        private System.Windows.Forms.Panel paneLRelever;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGroupe1;
        private System.Windows.Forms.ComboBox comboCadre1;
        private System.Windows.Forms.ComboBox comboCompte1;
        private System.Windows.Forms.ComboBox comboCompte1Des;
        private System.Windows.Forms.ComboBox comboGroupe1Des;
        private System.Windows.Forms.ComboBox comboCadreDes;
        private System.Windows.Forms.ComboBox comboCompte2Des;
        private System.Windows.Forms.ComboBox comboCompte2;
        private System.Windows.Forms.RadioButton rbReleveBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRecherche;
        private System.Windows.Forms.CheckBox rbMouvmentTierce;
        private System.Windows.Forms.CheckBox cbBalanceMvt;
        private System.Windows.Forms.CheckBox cbDepenseProfiMvt;
        private System.Windows.Forms.RadioButton rbInventaire;
        private System.Windows.Forms.CheckBox CbCdfCaisse;
        private System.Windows.Forms.RadioButton RbVnteEtVersment;
    }
}