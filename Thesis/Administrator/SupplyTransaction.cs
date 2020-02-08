using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thesis
{
    public partial class FrmSupplyTransaction : Form
    {
        public FrmSupplyTransaction()
        {
            InitializeComponent();
        }

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain back = new FrmMain();
            back.Show();
            this.Visible = false;
        }

        private void ClearTextbox()
        {
            DisableUpdateButton();
            txtItemDescription.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtSupplier.Clear();
            txtSupplierID.Clear();
            txtSupplyTansactionID.Clear();

        }

        #region Bool variables
        bool booltabAddSuppliesToProduct = true;
        bool booltabNewSuppliesToProduct = false;
        #endregion

        #region Disable Update Button Functions

        private void DisableUpdateButton()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void EnableUpdateButton()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }
        #endregion

        #region Load Functions

        private void FrmSupplyTransaction_Load(object sender, EventArgs e)
        {
            DisableUpdateButton();
            LoadTransactionHistory();
            LoadAddSuppliesToProduct();
        }


        private void LoadAddSuppliesToProduct()
        {
            con.Open();
            cmd = new SqlCommand(@"	SELECT SupplyTrans.SupplierID, Supplier.CompanyName , SupplyTrans.ProductID, ProductName ,ItemDesc,ProductCode
	        FROM SupplyTrans
	        inner join Products on  SupplyTrans.ProductID = Products.ProductID
	        inner join Supplier on SupplyTrans.SupplierID =  Supplier.SupplierID
        	group by SupplyTrans.SupplierID, Supplier.CompanyName, SupplyTrans.ProductID, Products.ProductName, Products.ItemDesc,ProductCode	", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataAddSuppliesToProducts.Rows.Add(rdr[0].ToString(), rdr[1].ToString(),
                    rdr[2].ToString(), rdr[3].ToString(),rdr[4].ToString(),rdr[5].ToString());
            }
            con.Close();
        }

        private void LoadTransactionHistory()
        {

            con.Open();
            cmd = new SqlCommand(@"
            Select SupplyTransID, Supplier.SupplierID ,Products.ProductID, ProductName, CompanyName,StocksSupplied
            From SupplyTrans
           Inner join Products on   Products.ProductID = SupplyTrans.ProductID
           Inner join Supplier on  Supplier.SupplierID = SupplyTrans.SupplierID	 where StocksSupplied  !=  0  ", con);
            rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                dataHistory.Rows.Add(rdr[0].ToString(), rdr[1].ToString()
                    , rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
            }
            con.Close();
        }

        #endregion

        #region Add Buttons

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Are you sure you want to add this?", "Confirmation", MessageBoxButtons.YesNo);
            if (txtProductID.Text != "" && txtSupplierID.Text != "" && booltabAddSuppliesToProduct == true &&
                booltabNewSuppliesToProduct == false && DialogResult == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand(@"insert into SupplyTrans
                         (StocksSupplied,ProductID,SupplierID)
                         values 
                         ('" + txtQuantity.Text + "','" + txtProductID.Text + "','" + txtSupplierID.Text + "')", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(@"
		                 INSERT INTO BuyingTransaction
		                (ProductID,StockSold)
		    	        Values
			            ('" + txtProductID.Text + "','0')", con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Congrats, Added!", "Congrats");

            }

            else if (DialogResult == DialogResult.No)
            {
                MessageBox.Show("Adding Cancelled", "Cancelled");
            }

            else
            {
                MessageBox.Show("Invalid Input", "Warning");
            }

            #region Refresh functions

            DisableUpdateButton();
            ClearTextbox();
            dataAddSuppliesToProducts.Rows.Clear();

            LoadAddSuppliesToProduct();
            LoadTransactionHistory();
            #endregion
        }

        #endregion

        #region Selection Changed
        private void dataAddSuppliesToProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataAddSuppliesToProducts.SelectedRows.Count != 0)
            {
                txtSupplierID.Text = dataAddSuppliesToProducts.SelectedRows[0].Cells[0].Value.ToString();
                txtSupplier.Text = dataAddSuppliesToProducts.SelectedRows[0].Cells[1].Value.ToString();
                txtProductID.Text = dataAddSuppliesToProducts.SelectedRows[0].Cells[2].Value.ToString();
                txtProductName.Text = dataAddSuppliesToProducts.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataHistory.SelectedRows.Count != 0)
            {
                txtSupplyTansactionID.Text = dataHistory.SelectedRows[0].Cells[0].Value.ToString();
                txtSupplierID.Text = dataHistory.SelectedRows[0].Cells[1].Value.ToString();
                txtProductID.Text = dataHistory.SelectedRows[0].Cells[2].Value.ToString();
                txtProductName.Text = dataHistory.SelectedRows[0].Cells[3].Value.ToString();
                txtSupplier.Text = dataHistory.SelectedRows[0].Cells[4].Value.ToString();
                txtQuantity.Text = dataHistory.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
        #endregion

        #region Update Functions
        private void btnUpdate_Click_1(object sender, EventArgs e)//not yet done
        {
            DialogResult DialogResult = MessageBox.Show("Are YouSure you want to update this?", "Confirmation", MessageBoxButtons.YesNo);
            if (txtProductID.Text != "" && txtProductName.Text != "" && txtQuantity.Text != "" &&
                      txtSupplier.Text != "" && txtSupplyTansactionID.Text != "")
            {
                if (dataHistory.SelectedRows.Count != 0 && DialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand(@"update SupplyTrans set StocksSupplied = '"+txtQuantity.Text+"' where ProductID = '"+txtProductID.Text
                        +"' and SupplierID = '"+txtSupplierID.Text+ "' and SupplyTransID = '"+txtSupplyTansactionID.Text+"' ", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Update Sucessful", "Success");
                }

                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Update Cancelled", "Cancelled");
                }

            }
            else
            {
                MessageBox.Show("Invalid Input", "Invalid");
            }

            #region Refresh functions

            DisableUpdateButton();
            ClearTextbox();
            dataHistory.Rows.Clear();

            LoadAddSuppliesToProduct();
            LoadTransactionHistory();
            #endregion
        }




        #endregion

        #region SelectedIndexChanged Functions

        private void tabSupplyTrans_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (tabSupplyTrans.SelectedTab == tabSupplyTrans.TabPages["tabpageAddSupplies"])
            {
                ClearTextbox();
                DisableUpdateButton();
                booltabAddSuppliesToProduct = true;
                booltabNewSuppliesToProduct = false;
            }

            else if (tabSupplyTrans.SelectedTab == tabSupplyTrans.TabPages["tabSupplyTransHistory"])
            {
                ClearTextbox();
                EnableUpdateButton();
                booltabAddSuppliesToProduct = false;
                booltabNewSuppliesToProduct = false;
            }

        }

        #endregion




    }

}