namespace GoldenStarApplication.Stock
{
    partial class FormOperationStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperationStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgStock = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tDateR1 = new System.Windows.Forms.DateTimePicker();
            this.tdateR2 = new System.Windows.Forms.DateTimePicker();
            this.NumOperationDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(78, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgStock);
            this.panel2.Location = new System.Drawing.Point(33, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 345);
            this.panel2.TabIndex = 1;
            // 
            // DgStock
            // 
            this.DgStock.AllowUserToAddRows = false;
            this.DgStock.AllowUserToDeleteRows = false;
            this.DgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOperationDG,
            this.LL,
            this.Column3});
            this.DgStock.Location = new System.Drawing.Point(12, 18);
            this.DgStock.Name = "DgStock";
            this.DgStock.ReadOnly = true;
            this.DgStock.Size = new System.Drawing.Size(648, 301);
            this.DgStock.TabIndex = 0;
            this.DgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgStock_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(45, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tDateR1
            // 
            this.tDateR1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDateR1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDateR1.Location = new System.Drawing.Point(208, 29);
            this.tDateR1.Name = "tDateR1";
            this.tDateR1.Size = new System.Drawing.Size(130, 23);
            this.tDateR1.TabIndex = 34;
            // 
            // tdateR2
            // 
            this.tdateR2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdateR2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tdateR2.Location = new System.Drawing.Point(382, 29);
            this.tdateR2.Name = "tdateR2";
            this.tdateR2.Size = new System.Drawing.Size(132, 23);
            this.tdateR2.TabIndex = 33;
            // 
            // NumOperationDG
            // 
            this.NumOperationDG.DataPropertyName = "NumOperation";
            this.NumOperationDG.HeaderText = "Ref";
            this.NumOperationDG.Name = "NumOperationDG";
            this.NumOperationDG.ReadOnly = true;
            // 
            // LL
            // 
            this.LL.DataPropertyName = "Libelle";
            this.LL.HeaderText = "LIBELLE";
            this.LL.Name = "LL";
            this.LL.ReadOnly = true;
            this.LL.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateOp";
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormOperationStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 578);
            this.Controls.Add(this.tDateR1);
            this.Controls.Add(this.tdateR2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOperationStock";
            this.Text = "FormOperationStock";
            this.Load += new System.EventHandler(this.FormOperationStock_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker tDateR1;
        private System.Windows.Forms.DateTimePicker tdateR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOperationDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}