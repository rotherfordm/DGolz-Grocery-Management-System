namespace Thesis
{
    partial class FrmSupplyTransaction
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplyTansactionID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabSupplyTrans = new System.Windows.Forms.TabControl();
            this.tabpageAddSupplies = new System.Windows.Forms.TabPage();
            this.dataAddSuppliesToProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIDsup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNamesup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupplyTransHistory = new System.Windows.Forms.TabPage();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.SupplyTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupplyTrans.SuspendLayout();
            this.tabpageAddSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddSuppliesToProducts)).BeginInit();
            this.tabSupplyTransHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Thesis.Properties.Resources.Back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(870, 554);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(991, 554);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Product ID";
            this.label1.Visible = false;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Location = new System.Drawing.Point(995, 260);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtSupplier.TabIndex = 35;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(995, 285);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 34;
            // 
            // txtSupplyTansactionID
            // 
            this.txtSupplyTansactionID.Enabled = false;
            this.txtSupplyTansactionID.Location = new System.Drawing.Point(986, 123);
            this.txtSupplyTansactionID.Name = "txtSupplyTansactionID";
            this.txtSupplyTansactionID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplyTansactionID.TabIndex = 33;
            this.txtSupplyTansactionID.Visible = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(986, 148);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 32;
            this.txtProductID.Visible = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(995, 236);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(857, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Supply Transaction ID";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(857, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Supplier ID";
            this.label6.Visible = false;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(986, 174);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 44;
            this.txtSupplierID.Visible = false;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Enabled = false;
            this.txtItemDescription.Location = new System.Drawing.Point(870, 342);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(226, 120);
            this.txtItemDescription.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Item Description";
            // 
            // tabSupplyTrans
            // 
            this.tabSupplyTrans.Controls.Add(this.tabpageAddSupplies);
            this.tabSupplyTrans.Controls.Add(this.tabSupplyTransHistory);
            this.tabSupplyTrans.Location = new System.Drawing.Point(12, 77);
            this.tabSupplyTrans.Name = "tabSupplyTrans";
            this.tabSupplyTrans.SelectedIndex = 0;
            this.tabSupplyTrans.Size = new System.Drawing.Size(829, 619);
            this.tabSupplyTrans.TabIndex = 1;
            this.tabSupplyTrans.SelectedIndexChanged += new System.EventHandler(this.tabSupplyTrans_SelectedIndexChanged);
            // 
            // tabpageAddSupplies
            // 
            this.tabpageAddSupplies.Controls.Add(this.dataAddSuppliesToProducts);
            this.tabpageAddSupplies.Location = new System.Drawing.Point(4, 22);
            this.tabpageAddSupplies.Name = "tabpageAddSupplies";
            this.tabpageAddSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAddSupplies.Size = new System.Drawing.Size(821, 593);
            this.tabpageAddSupplies.TabIndex = 2;
            this.tabpageAddSupplies.Text = "Add Supplies to Products";
            this.tabpageAddSupplies.UseVisualStyleBackColor = true;
            // 
            // dataAddSuppliesToProducts
            // 
            this.dataAddSuppliesToProducts.AllowUserToAddRows = false;
            this.dataAddSuppliesToProducts.AllowUserToDeleteRows = false;
            this.dataAddSuppliesToProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddSuppliesToProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ProductIDsup,
            this.ProductNamesup,
            this.ProductDesc,
            this.ProductCode});
            this.dataAddSuppliesToProducts.Location = new System.Drawing.Point(27, 49);
            this.dataAddSuppliesToProducts.Name = "dataAddSuppliesToProducts";
            this.dataAddSuppliesToProducts.ReadOnly = true;
            this.dataAddSuppliesToProducts.Size = new System.Drawing.Size(753, 503);
            this.dataAddSuppliesToProducts.TabIndex = 49;
            this.dataAddSuppliesToProducts.SelectionChanged += new System.EventHandler(this.dataAddSuppliesToProducts_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ProductIDsup
            // 
            this.ProductIDsup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductIDsup.HeaderText = "Product ID";
            this.ProductIDsup.Name = "ProductIDsup";
            this.ProductIDsup.ReadOnly = true;
            this.ProductIDsup.Visible = false;
            // 
            // ProductNamesup
            // 
            this.ProductNamesup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNamesup.HeaderText = "Product Name";
            this.ProductNamesup.Name = "ProductNamesup";
            this.ProductNamesup.ReadOnly = true;
            // 
            // ProductDesc
            // 
            this.ProductDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductDesc.HeaderText = "Product Description";
            this.ProductDesc.Name = "ProductDesc";
            this.ProductDesc.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // tabSupplyTransHistory
            // 
            this.tabSupplyTransHistory.Controls.Add(this.dataHistory);
            this.tabSupplyTransHistory.Location = new System.Drawing.Point(4, 22);
            this.tabSupplyTransHistory.Name = "tabSupplyTransHistory";
            this.tabSupplyTransHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplyTransHistory.Size = new System.Drawing.Size(821, 593);
            this.tabSupplyTransHistory.TabIndex = 1;
            this.tabSupplyTransHistory.Text = "Supply Transaction History";
            this.tabSupplyTransHistory.UseVisualStyleBackColor = true;
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyTransactionID,
            this.SupplierID2,
            this.ProductID,
            this.ProductName,
            this.Supplier,
            this.Quantity});
            this.dataHistory.Location = new System.Drawing.Point(26, 51);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.Size = new System.Drawing.Size(749, 512);
            this.dataHistory.TabIndex = 46;
            this.dataHistory.SelectionChanged += new System.EventHandler(this.dataHistory_SelectionChanged);
            // 
            // SupplyTransactionID
            // 
            this.SupplyTransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplyTransactionID.HeaderText = "Supply Transaction ID";
            this.SupplyTransactionID.Name = "SupplyTransactionID";
            this.SupplyTransactionID.ReadOnly = true;
            this.SupplyTransactionID.Visible = false;
            // 
            // SupplierID2
            // 
            this.SupplierID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID2.HeaderText = "Supplier ID";
            this.SupplierID2.Name = "SupplierID2";
            this.SupplierID2.ReadOnly = true;
            this.SupplierID2.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // FrmSupplyTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.OKay;
            this.ClientSize = new System.Drawing.Size(1133, 708);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabSupplyTrans);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtSupplyTansactionID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplyTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyTransaction";
            this.Load += new System.EventHandler(this.FrmSupplyTransaction_Load);
            this.tabSupplyTrans.ResumeLayout(false);
            this.tabpageAddSupplies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAddSuppliesToProducts)).EndInit();
            this.tabSupplyTransHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSupplyTansactionID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabSupplyTrans;
        private System.Windows.Forms.TabPage tabSupplyTransHistory;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.TabPage tabpageAddSupplies;
        private System.Windows.Forms.DataGridView dataAddSuppliesToProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDsup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNamesup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}