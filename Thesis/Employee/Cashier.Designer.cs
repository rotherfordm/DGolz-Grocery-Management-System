namespace Thesis
{
    partial class FrmCashier
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
            this.btnSubtotal = new System.Windows.Forms.Button();
            this.btnCashier_Checkout = new System.Windows.Forms.Button();
            this.dataProductList = new System.Windows.Forms.DataGridView();
            this.ProductID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.ProductID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCashier_Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCheckoutID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubtotal
            // 
            this.btnSubtotal.Location = new System.Drawing.Point(958, 324);
            this.btnSubtotal.Name = "btnSubtotal";
            this.btnSubtotal.Size = new System.Drawing.Size(75, 41);
            this.btnSubtotal.TabIndex = 0;
            this.btnSubtotal.Text = "Subtotal";
            this.btnSubtotal.UseVisualStyleBackColor = true;
            this.btnSubtotal.Click += new System.EventHandler(this.btnSubtotal_Click);
            // 
            // btnCashier_Checkout
            // 
            this.btnCashier_Checkout.Location = new System.Drawing.Point(958, 410);
            this.btnCashier_Checkout.Name = "btnCashier_Checkout";
            this.btnCashier_Checkout.Size = new System.Drawing.Size(75, 41);
            this.btnCashier_Checkout.TabIndex = 1;
            this.btnCashier_Checkout.Text = "Checkout";
            this.btnCashier_Checkout.UseVisualStyleBackColor = true;
            this.btnCashier_Checkout.Click += new System.EventHandler(this.btnCashier_Checkout_Click);
            // 
            // dataProductList
            // 
            this.dataProductList.AllowUserToAddRows = false;
            this.dataProductList.AllowUserToDeleteRows = false;
            this.dataProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID1,
            this.ProductCode,
            this.ProductName1,
            this.ItemDescription,
            this.Price});
            this.dataProductList.Location = new System.Drawing.Point(30, 150);
            this.dataProductList.Name = "dataProductList";
            this.dataProductList.ReadOnly = true;
            this.dataProductList.Size = new System.Drawing.Size(426, 515);
            this.dataProductList.TabIndex = 2;
            this.dataProductList.SelectionChanged += new System.EventHandler(this.dataProductList_SelectionChanged);
            // 
            // ProductID1
            // 
            this.ProductID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID1.HeaderText = "Product ID";
            this.ProductID1.Name = "ProductID1";
            this.ProductID1.ReadOnly = true;
            this.ProductID1.Visible = false;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName1
            // 
            this.ProductName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName1.HeaderText = "Product Name";
            this.ProductName1.Name = "ProductName1";
            this.ProductName1.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(48, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(591, 165);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(90, 20);
            this.txtProductID.TabIndex = 5;
            this.txtProductID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(527, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product ID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(527, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            this.label3.Visible = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(609, 250);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(112, 20);
            this.txtProduct.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(609, 286);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 20);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Visible = false;
            // 
            // dataCart
            // 
            this.dataCart.AllowUserToAddRows = false;
            this.dataCart.AllowUserToDeleteRows = false;
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID2,
            this.ProductCode2,
            this.ProductName2,
            this.Price2,
            this.Quantity});
            this.dataCart.Location = new System.Drawing.Point(471, 374);
            this.dataCart.Name = "dataCart";
            this.dataCart.ReadOnly = true;
            this.dataCart.Size = new System.Drawing.Size(443, 291);
            this.dataCart.TabIndex = 13;
            this.dataCart.SelectionChanged += new System.EventHandler(this.dataCart_SelectionChanged);
            // 
            // ProductID2
            // 
            this.ProductID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID2.HeaderText = "Product ID";
            this.ProductID2.Name = "ProductID2";
            this.ProductID2.ReadOnly = true;
            this.ProductID2.Visible = false;
            // 
            // ProductCode2
            // 
            this.ProductCode2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode2.HeaderText = "Product Code";
            this.ProductCode2.Name = "ProductCode2";
            this.ProductCode2.ReadOnly = true;
            // 
            // ProductName2
            // 
            this.ProductName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName2.HeaderText = "Product Name";
            this.ProductName2.Name = "ProductName2";
            this.ProductName2.ReadOnly = true;
            // 
            // Price2
            // 
            this.Price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price2.HeaderText = "Price";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(958, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(958, 298);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Thesis.Properties.Resources.Back1;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 33);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnCashier_Logout_Click);
            // 
            // btnCashier_Remove
            // 
            this.btnCashier_Remove.Location = new System.Drawing.Point(789, 312);
            this.btnCashier_Remove.Name = "btnCashier_Remove";
            this.btnCashier_Remove.Size = new System.Drawing.Size(75, 23);
            this.btnCashier_Remove.TabIndex = 20;
            this.btnCashier_Remove.Text = "Remove";
            this.btnCashier_Remove.UseVisualStyleBackColor = true;
            this.btnCashier_Remove.Click += new System.EventHandler(this.btnCashier_Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(789, 272);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 22;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Location = new System.Drawing.Point(609, 218);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(112, 20);
            this.txtProductCode.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(527, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Code";
            // 
            // dateTransaction
            // 
            this.dateTransaction.Enabled = false;
            this.dateTransaction.Location = new System.Drawing.Point(521, 128);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(200, 20);
            this.dateTransaction.TabIndex = 25;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(609, 315);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(112, 20);
            this.txtQuantity.TabIndex = 27;
            this.txtQuantity.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(527, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quantity";
            this.label7.Visible = false;
            // 
            // txtCheckoutID
            // 
            this.txtCheckoutID.Enabled = false;
            this.txtCheckoutID.Location = new System.Drawing.Point(777, 165);
            this.txtCheckoutID.Name = "txtCheckoutID";
            this.txtCheckoutID.Size = new System.Drawing.Size(100, 20);
            this.txtCheckoutID.TabIndex = 28;
            this.txtCheckoutID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(789, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Checkout ID";
            this.label8.Visible = false;
            // 
            // FrmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.OKay;
            this.ClientSize = new System.Drawing.Size(1095, 706);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCheckoutID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTransaction);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.btnCashier_Remove);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataCart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataProductList);
            this.Controls.Add(this.btnCashier_Checkout);
            this.Controls.Add(this.btnSubtotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.FrmCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubtotal;
        private System.Windows.Forms.Button btnCashier_Checkout;
        private System.Windows.Forms.DataGridView dataProductList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCashier_Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTransaction;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCheckoutID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}