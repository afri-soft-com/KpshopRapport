namespace GoldenStarApplication
{
    partial class FormParaVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParaVente));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboVendeurDes = new System.Windows.Forms.ComboBox();
            this.bLesStock = new System.Windows.Forms.Button();
            this.BwchalrgmentCombo = new System.ComponentModel.BackgroundWorker();
            this.comboDepotDes = new System.Windows.Forms.ComboBox();
            this.comboDepot = new System.Windows.Forms.ComboBox();
            this.comboCodeDeVendeur = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pvENTE = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bComptabilte = new System.Windows.Forms.Button();
            this.bLesArticle = new System.Windows.Forms.Button();
            this.bCaisse = new System.Windows.Forms.Button();
            this.bLemouvement = new System.Windows.Forms.Button();
            this.bAproStock = new System.Windows.Forms.Button();
            this.bLivreDecisse = new System.Windows.Forms.Button();
            this.bVente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pvENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "POINT DE VENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RECEVEUR";
            // 
            // comboVendeurDes
            // 
            this.comboVendeurDes.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVendeurDes.FormattingEnabled = true;
            this.comboVendeurDes.Location = new System.Drawing.Point(219, 427);
            this.comboVendeurDes.Name = "comboVendeurDes";
            this.comboVendeurDes.Size = new System.Drawing.Size(327, 23);
            this.comboVendeurDes.TabIndex = 3;
            this.comboVendeurDes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bLesStock
            // 
            this.bLesStock.BackColor = System.Drawing.Color.White;
            this.bLesStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLesStock.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLesStock.Image = ((System.Drawing.Image)(resources.GetObject("bLesStock.Image")));
            this.bLesStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLesStock.Location = new System.Drawing.Point(310, 304);
            this.bLesStock.Name = "bLesStock";
            this.bLesStock.Size = new System.Drawing.Size(198, 56);
            this.bLesStock.TabIndex = 5;
            this.bLesStock.Text = "STOCK";
            this.bLesStock.UseVisualStyleBackColor = false;
            this.bLesStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // BwchalrgmentCombo
            // 
            this.BwchalrgmentCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.BwchalrgmentCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // comboDepotDes
            // 
            this.comboDepotDes.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepotDes.FormattingEnabled = true;
            this.comboDepotDes.Location = new System.Drawing.Point(170, 69);
            this.comboDepotDes.Name = "comboDepotDes";
            this.comboDepotDes.Size = new System.Drawing.Size(327, 23);
            this.comboDepotDes.TabIndex = 10;
            // 
            // comboDepot
            // 
            this.comboDepot.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepot.FormattingEnabled = true;
            this.comboDepot.Location = new System.Drawing.Point(101, 69);
            this.comboDepot.Name = "comboDepot";
            this.comboDepot.Size = new System.Drawing.Size(63, 23);
            this.comboDepot.TabIndex = 9;
            // 
            // comboCodeDeVendeur
            // 
            this.comboCodeDeVendeur.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCodeDeVendeur.FormattingEnabled = true;
            this.comboCodeDeVendeur.Location = new System.Drawing.Point(150, 427);
            this.comboCodeDeVendeur.Name = "comboCodeDeVendeur";
            this.comboCodeDeVendeur.Size = new System.Drawing.Size(63, 23);
            this.comboCodeDeVendeur.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(623, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 58);
            this.button2.TabIndex = 12;
            this.button2.Text = "STOCKAGE   ET RAVAITAILLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pvENTE
            // 
            this.pvENTE.Controls.Add(this.button3);
            this.pvENTE.Controls.Add(this.button1);
            this.pvENTE.Controls.Add(this.bComptabilte);
            this.pvENTE.Controls.Add(this.bLesArticle);
            this.pvENTE.Controls.Add(this.bCaisse);
            this.pvENTE.Controls.Add(this.bLemouvement);
            this.pvENTE.Controls.Add(this.bLesStock);
            this.pvENTE.Controls.Add(this.bAproStock);
            this.pvENTE.Controls.Add(this.bLivreDecisse);
            this.pvENTE.Controls.Add(this.bVente);
            this.pvENTE.Controls.Add(this.label2);
            this.pvENTE.Controls.Add(this.comboDepotDes);
            this.pvENTE.Controls.Add(this.comboDepot);
            this.pvENTE.Controls.Add(this.label1);
            this.pvENTE.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvENTE.Location = new System.Drawing.Point(49, 12);
            this.pvENTE.Name = "pvENTE";
            this.pvENTE.Size = new System.Drawing.Size(586, 489);
            this.pvENTE.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(310, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "SYNCRONISATION";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(79, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "LE RESULTAT ET BILAN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bComptabilte
            // 
            this.bComptabilte.BackColor = System.Drawing.Color.White;
            this.bComptabilte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bComptabilte.Image = ((System.Drawing.Image)(resources.GetObject("bComptabilte.Image")));
            this.bComptabilte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bComptabilte.Location = new System.Drawing.Point(78, 127);
            this.bComptabilte.Name = "bComptabilte";
            this.bComptabilte.Size = new System.Drawing.Size(207, 53);
            this.bComptabilte.TabIndex = 18;
            this.bComptabilte.Text = "COMPTABILITE";
            this.bComptabilte.UseVisualStyleBackColor = false;
            this.bComptabilte.Click += new System.EventHandler(this.button9_Click);
            // 
            // bLesArticle
            // 
            this.bLesArticle.BackColor = System.Drawing.Color.White;
            this.bLesArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLesArticle.Image = ((System.Drawing.Image)(resources.GetObject("bLesArticle.Image")));
            this.bLesArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLesArticle.Location = new System.Drawing.Point(310, 243);
            this.bLesArticle.Name = "bLesArticle";
            this.bLesArticle.Size = new System.Drawing.Size(198, 53);
            this.bLesArticle.TabIndex = 17;
            this.bLesArticle.Text = "LES  ARTICLES";
            this.bLesArticle.UseVisualStyleBackColor = false;
            this.bLesArticle.Click += new System.EventHandler(this.button8_Click);
            // 
            // bCaisse
            // 
            this.bCaisse.BackColor = System.Drawing.Color.White;
            this.bCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCaisse.Image = ((System.Drawing.Image)(resources.GetObject("bCaisse.Image")));
            this.bCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCaisse.Location = new System.Drawing.Point(78, 186);
            this.bCaisse.Name = "bCaisse";
            this.bCaisse.Size = new System.Drawing.Size(207, 53);
            this.bCaisse.TabIndex = 16;
            this.bCaisse.Text = "CAISSE";
            this.bCaisse.UseVisualStyleBackColor = false;
            this.bCaisse.Click += new System.EventHandler(this.button5_Click);
            // 
            // bLemouvement
            // 
            this.bLemouvement.BackColor = System.Drawing.Color.White;
            this.bLemouvement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLemouvement.Image = ((System.Drawing.Image)(resources.GetObject("bLemouvement.Image")));
            this.bLemouvement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLemouvement.Location = new System.Drawing.Point(78, 248);
            this.bLemouvement.Name = "bLemouvement";
            this.bLemouvement.Size = new System.Drawing.Size(206, 53);
            this.bLemouvement.TabIndex = 15;
            this.bLemouvement.Text = "LES MOUVMENTS DES COMPTE";
            this.bLemouvement.UseVisualStyleBackColor = false;
            this.bLemouvement.Click += new System.EventHandler(this.button4_Click);
            // 
            // bAproStock
            // 
            this.bAproStock.BackColor = System.Drawing.Color.White;
            this.bAproStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAproStock.Image = ((System.Drawing.Image)(resources.GetObject("bAproStock.Image")));
            this.bAproStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAproStock.Location = new System.Drawing.Point(310, 186);
            this.bAproStock.Name = "bAproStock";
            this.bAproStock.Size = new System.Drawing.Size(198, 53);
            this.bAproStock.TabIndex = 14;
            this.bAproStock.Text = "APRO STOCK";
            this.bAproStock.UseVisualStyleBackColor = false;
            this.bAproStock.Click += new System.EventHandler(this.button3_Click);
            // 
            // bLivreDecisse
            // 
            this.bLivreDecisse.BackColor = System.Drawing.Color.White;
            this.bLivreDecisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLivreDecisse.Image = ((System.Drawing.Image)(resources.GetObject("bLivreDecisse.Image")));
            this.bLivreDecisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLivreDecisse.Location = new System.Drawing.Point(78, 307);
            this.bLivreDecisse.Name = "bLivreDecisse";
            this.bLivreDecisse.Size = new System.Drawing.Size(206, 53);
            this.bLivreDecisse.TabIndex = 13;
            this.bLivreDecisse.Text = "LIVRE DE CAISSE";
            this.bLivreDecisse.UseVisualStyleBackColor = false;
            this.bLivreDecisse.Click += new System.EventHandler(this.button6_Click);
            // 
            // bVente
            // 
            this.bVente.BackColor = System.Drawing.Color.White;
            this.bVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVente.Image = ((System.Drawing.Image)(resources.GetObject("bVente.Image")));
            this.bVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVente.Location = new System.Drawing.Point(310, 127);
            this.bVente.Name = "bVente";
            this.bVente.Size = new System.Drawing.Size(198, 53);
            this.bVente.TabIndex = 12;
            this.bVente.Text = "VENTE";
            this.bVente.UseVisualStyleBackColor = false;
            this.bVente.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "CHOISIR LE POINT DE VENTE";
            // 
            // FormParaVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(749, 513);
            this.Controls.Add(this.pvENTE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboVendeurDes);
            this.Controls.Add(this.comboCodeDeVendeur);
            this.Name = "FormParaVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParaVente";
            this.Load += new System.EventHandler(this.FormParaVente_Load);
            this.pvENTE.ResumeLayout(false);
            this.pvENTE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboVendeurDes;
        private System.Windows.Forms.Button bLesStock;
        private System.ComponentModel.BackgroundWorker BwchalrgmentCombo;
        private System.Windows.Forms.ComboBox comboDepotDes;
        private System.Windows.Forms.ComboBox comboDepot;
        private System.Windows.Forms.ComboBox comboCodeDeVendeur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pvENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCaisse;
        private System.Windows.Forms.Button bLemouvement;
        private System.Windows.Forms.Button bAproStock;
        private System.Windows.Forms.Button bLivreDecisse;
        private System.Windows.Forms.Button bVente;
        private System.Windows.Forms.Button bComptabilte;
        private System.Windows.Forms.Button bLesArticle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}