namespace GoldenStarApplication.Stock
{
    partial class FormStockDepot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockDepot));
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgStock = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.CodeDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgStock);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 256);
            this.panel2.TabIndex = 2;
            // 
            // DgStock
            // 
            this.DgStock.AllowUserToAddRows = false;
            this.DgStock.AllowUserToDeleteRows = false;
            this.DgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeDepot,
            this.Column2,
            this.Column3});
            this.DgStock.Location = new System.Drawing.Point(12, 18);
            this.DgStock.Name = "DgStock";
            this.DgStock.ReadOnly = true;
            this.DgStock.Size = new System.Drawing.Size(649, 197);
            this.DgStock.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "DETAIL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CodeDepot
            // 
            this.CodeDepot.DataPropertyName = "CodeDepot";
            this.CodeDepot.HeaderText = "Ref";
            this.CodeDepot.Name = "CodeDepot";
            this.CodeDepot.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DesignationDepot";
            this.Column2.HeaderText = "DEPOT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateOp";
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormStockDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Name = "FormStockDepot";
            this.Text = "FormStockDepot";
            this.Load += new System.EventHandler(this.FormStockDepot_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}