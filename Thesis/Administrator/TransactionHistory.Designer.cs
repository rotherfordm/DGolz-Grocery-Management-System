namespace Thesis
{
    partial class FrmTransactionHistory
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
            this.dataCheckoutHistory = new System.Windows.Forms.DataGridView();
            this.CheckoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataProductsTransacted = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalsales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckoutHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsTransacted)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCheckoutHistory
            // 
            this.dataCheckoutHistory.AllowUserToAddRows = false;
            this.dataCheckoutHistory.AllowUserToDeleteRows = false;
            this.dataCheckoutHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCheckoutHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckoutID,
            this.TransactionDate,
            this.TotalPrice});
            this.dataCheckoutHistory.Location = new System.Drawing.Point(29, 148);
            this.dataCheckoutHistory.Name = "dataCheckoutHistory";
            this.dataCheckoutHistory.ReadOnly = true;
            this.dataCheckoutHistory.Size = new System.Drawing.Size(348, 289);
            this.dataCheckoutHistory.TabIndex = 0;
            this.dataCheckoutHistory.SelectionChanged += new System.EventHandler(this.dataCheckoutHistory_SelectionChanged);
            // 
            // CheckoutID
            // 
            this.CheckoutID.HeaderText = "Checkout ID";
            this.CheckoutID.Name = "CheckoutID";
            this.CheckoutID.ReadOnly = true;
            this.CheckoutID.Visible = false;
            // 
            // TransactionDate
            // 
            this.TransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionDate.HeaderText = "Transaction Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Thesis.Properties.Resources.Back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 28);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataProductsTransacted
            // 
            this.dataProductsTransacted.AllowUserToAddRows = false;
            this.dataProductsTransacted.AllowUserToDeleteRows = false;
            this.dataProductsTransacted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductsTransacted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.TotalPrice2});
            this.dataProductsTransacted.Location = new System.Drawing.Point(405, 150);
            this.dataProductsTransacted.Name = "dataProductsTransacted";
            this.dataProductsTransacted.ReadOnly = true;
            this.dataProductsTransacted.Size = new System.Drawing.Size(574, 287);
            this.dataProductsTransacted.TabIndex = 15;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice2
            // 
            this.TotalPrice2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice2.HeaderText = "TotalPrice";
            this.TotalPrice2.Name = "TotalPrice2";
            this.TotalPrice2.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Products Transacted";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "List of Transaction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Sales: ";
            // 
            // lblTotalsales
            // 
            this.lblTotalsales.AutoSize = true;
            this.lblTotalsales.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalsales.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalsales.Location = new System.Drawing.Point(833, 11);
            this.lblTotalsales.Name = "lblTotalsales";
            this.lblTotalsales.Size = new System.Drawing.Size(53, 26);
            this.lblTotalsales.TabIndex = 20;
            this.lblTotalsales.Text = "Sales";
            // 
            // FrmTransactionHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Thesis.Properties.Resources.OKay;
            this.ClientSize = new System.Drawing.Size(1020, 470);
            this.Controls.Add(this.lblTotalsales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataProductsTransacted);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataCheckoutHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FrmTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckoutHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsTransacted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCheckoutHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataProductsTransacted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalsales;
    }
}