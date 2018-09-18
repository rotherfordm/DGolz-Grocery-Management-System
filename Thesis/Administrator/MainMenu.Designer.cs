namespace Thesis
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSupplyTransaction = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.BackgroundImage = global::Thesis.Properties.Resources.Inventory;
            this.btnSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(138, 122);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(150, 45);
            this.btnSupplier.TabIndex = 6;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImage = global::Thesis.Properties.Resources.Inventory;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(138, 262);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(150, 45);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactionHistory.BackgroundImage = global::Thesis.Properties.Resources.Inventory1;
            this.btnTransactionHistory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.Location = new System.Drawing.Point(600, 122);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(150, 45);
            this.btnTransactionHistory.TabIndex = 4;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = global::Thesis.Properties.Resources.Logout;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.BackgroundImage = global::Thesis.Properties.Resources.Inventory;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(372, 172);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(150, 45);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSupplyTransaction
            // 
            this.btnSupplyTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplyTransaction.BackgroundImage = global::Thesis.Properties.Resources.Inventory1;
            this.btnSupplyTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSupplyTransaction.FlatAppearance.BorderSize = 0;
            this.btnSupplyTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplyTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplyTransaction.Location = new System.Drawing.Point(372, 329);
            this.btnSupplyTransaction.Name = "btnSupplyTransaction";
            this.btnSupplyTransaction.Size = new System.Drawing.Size(150, 45);
            this.btnSupplyTransaction.TabIndex = 8;
            this.btnSupplyTransaction.Text = "Supply Transaction";
            this.btnSupplyTransaction.UseVisualStyleBackColor = false;
            this.btnSupplyTransaction.Click += new System.EventHandler(this.btnSupplyTransaction_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnCashier.BackgroundImage = global::Thesis.Properties.Resources.Inventory1;
            this.btnCashier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Location = new System.Drawing.Point(600, 262);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(150, 45);
            this.btnCashier.TabIndex = 9;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Thesis.Properties.Resources.OKay;
            this.ClientSize = new System.Drawing.Size(884, 432);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnSupplyTransaction);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnSupplyTransaction;
        private System.Windows.Forms.Button btnCashier;
    }
}