using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin logout = new FrmLogin();
            logout.Show();
            this.Visible = false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FrmInventory Inventory = new FrmInventory();
            Inventory.Show();
            this.Visible = false;
            
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FrmTransactionHistory Trans = new FrmTransactionHistory();
            Trans.Show();
            this.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            this.Visible = false;
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Visible = false;
            main.Show();
        }

        private void btnSupplyTransaction_Click(object sender, EventArgs e)
        {
            FrmSupplyTransaction strans = new FrmSupplyTransaction();
            this.Visible = false;
            strans.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            this.Visible = false;
            sup.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            FrmCashier cashier = new FrmCashier();
            this.Visible = false;
            cashier.Show(); 
        }
    }
}
