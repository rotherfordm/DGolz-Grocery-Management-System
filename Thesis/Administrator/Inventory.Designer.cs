namespace Thesis
{
    partial class FrmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
            this.btnBack = new System.Windows.Forms.Button();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSupplies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.ComboSupplierName = new System.Windows.Forms.ComboBox();
            this.dataAddSuppliesToProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIDsup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNamesup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddSuppliesToProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Thesis.Properties.Resources.Back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductCode,
            this.ProductName,
            this.Price,
            this.ItemDescription,
            this.SupplierID2,
            this.Supplier,
            this.CurrentSupplies});
            this.dataProduct.Location = new System.Drawing.Point(455, 145);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProduct.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduct.Size = new System.Drawing.Size(963, 535);
            this.dataProduct.TabIndex = 18;
            this.dataProduct.SelectionChanged += new System.EventHandler(this.dataProductMgt_SelectionChanged);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
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
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // SupplierID2
            // 
            this.SupplierID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID2.HeaderText = "Supplier ID";
            this.SupplierID2.Name = "SupplierID2";
            this.SupplierID2.ReadOnly = true;
            this.SupplierID2.Visible = false;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // CurrentSupplies
            // 
            this.CurrentSupplies.HeaderText = "CurrentSupplies";
            this.CurrentSupplies.Name = "CurrentSupplies";
            this.CurrentSupplies.ReadOnly = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackgroundImage = global::Thesis.Properties.Resources.ADD;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(251, 614);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(90, 40);
            this.btnUpdateProduct.TabIndex = 20;
            this.btnUpdateProduct.Text = "UPDATE";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(1424, 720);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(10, 20);
            this.txtProductID.TabIndex = 21;
            this.txtProductID.Visible = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(224, 279);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(126, 20);
            this.txtProductName.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(224, 325);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(126, 20);
            this.txtPrice.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(1331, 727);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Product ID";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Price";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(91, 470);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(304, 138);
            this.txtItemDescription.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Item Description";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(1293, 720);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(10, 20);
            this.txtSupplierID.TabIndex = 50;
            this.txtSupplierID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(1200, 727);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Supplier ID";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Management of Product and their Prices and Suppliers";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Thesis.Properties.Resources.ADD;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(181, 677);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(224, 228);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(126, 20);
            this.txtProductCode.TabIndex = 57;
            // 
            // ComboSupplierName
            // 
            this.ComboSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSupplierName.FormattingEnabled = true;
            this.ComboSupplierName.Location = new System.Drawing.Point(224, 187);
            this.ComboSupplierName.Name = "ComboSupplierName";
            this.ComboSupplierName.Size = new System.Drawing.Size(126, 21);
            this.ComboSupplierName.TabIndex = 60;
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
            this.ProductCode2});
            this.dataAddSuppliesToProducts.Enabled = false;
            this.dataAddSuppliesToProducts.Location = new System.Drawing.Point(1100, 727);
            this.dataAddSuppliesToProducts.Name = "dataAddSuppliesToProducts";
            this.dataAddSuppliesToProducts.ReadOnly = true;
            this.dataAddSuppliesToProducts.Size = new System.Drawing.Size(10, 10);
            this.dataAddSuppliesToProducts.TabIndex = 61;
            this.dataAddSuppliesToProducts.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // 
            // ProductNamesup
            // 
            this.ProductNamesup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNamesup.HeaderText = "Product Name";
            this.ProductNamesup.Name = "ProductNamesup";
            this.ProductNamesup.ReadOnly = true;
            // 
            // ProductCode2
            // 
            this.ProductCode2.HeaderText = "Product Code";
            this.ProductCode2.Name = "ProductCode2";
            this.ProductCode2.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Thesis.Properties.Resources.ADD;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(106, 614);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dataSupplier
            // 
            this.dataSupplier.AllowUserToAddRows = false;
            this.dataSupplier.AllowUserToDeleteRows = false;
            this.dataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.CompanyName});
            this.dataSupplier.Enabled = false;
            this.dataSupplier.Location = new System.Drawing.Point(1148, 727);
            this.dataSupplier.Name = "dataSupplier";
            this.dataSupplier.ReadOnly = true;
            this.dataSupplier.Size = new System.Drawing.Size(10, 10);
            this.dataSupplier.TabIndex = 62;
            this.dataSupplier.Visible = false;
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(455, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 20);
            this.txtSearch.TabIndex = 64;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Thesis.Properties.Resources.ADD;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(850, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 24);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Thesis.Properties.Resources.OKay;
            this.ClientSize = new System.Drawing.Size(1468, 762);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ComboSupplierName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.dataSupplier);
            this.Controls.Add(this.dataAddSuppliesToProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtSupplierID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddSuppliesToProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.ComboBox ComboSupplierName;
        private System.Windows.Forms.DataGridView dataAddSuppliesToProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDsup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNamesup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode2;
        private System.Windows.Forms.DataGridView dataSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSupplies;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}