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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        #region  Sql Connection Initialization

        //starts connection to sql server
        SqlConnection con = new SqlConnection
        (@"server =HEATZ\SQLEXPRESS; Initial Catalog =DGOLZMART2; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader rdr;

        #endregion
        
        private void ClearTextbox()
        {
            txtSupplierID.Clear();
            txtItemDescription.Clear();
            txtPrice.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductCode.Clear();
            ComboSupplierName.Items.Clear();
            ComboSupplierName.Enabled = true;
            DisableUpdateButton();
            
        }

        #region Disable Update Button Functions

        private void DisableUpdateButton()
        {
            btnAdd.Enabled = true;
            btnUpdateProduct.Enabled = false;
        }

        private void EnableUpdateButton()
        {
            btnUpdateProduct.Enabled = true;
            btnAdd.Enabled = false;
        }

        #endregion

        #region Load Functions

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            DisableUpdateButton();
            LoadInventory();
            LoadSupplier();
            LoadAddSuppliesToProduct();
        }

        private void LoadAddSuppliesToProduct()
        {
            con.Open();
            cmd = new SqlCommand(@"	SELECT SupplyTrans.SupplierID, Supplier.CompanyName , SupplyTrans.ProductID, ProductName,ProductCode
	        FROM SupplyTrans
	        inner join Products on  SupplyTrans.ProductID = Products.ProductID
	        inner join Supplier on SupplyTrans.SupplierID =  Supplier.SupplierID
        	group by SupplyTrans.SupplierID, Supplier.CompanyName, SupplyTrans.ProductID, Products.ProductName,ProductCode	", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataAddSuppliesToProducts.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),rdr[4].ToString());
            }
            con.Close();
        }

        private void LoadSupplier()
        {

            con.Open();
            cmd = new SqlCommand(@"select SupplierID, CompanyName from Supplier", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataSupplier.Rows.Add(rdr[0].ToString(), rdr[1].ToString());
                ComboSupplierName.Items.Add(rdr[1].ToString());
            }



            con.Close();
        }


        public void LoadInventory()
        {
            con.Open();
            cmd = new SqlCommand(@"
            (
                (
                    Select NProduct.ProductID   , NProduct.ProductCode,  NProduct.ProductName,
                    NProduct.Price,NProduct.ItemDesc,NSupplier.SupplierID,NSupplier.CompanyName ,TStockSup - TStockSold AS CurrentStocks 
                    from 
                    (Select Products.ProductID, Supplier.CompanyName ,Supplier.SupplierID,Supplier.SupplierID AS TSupplier From SupplyTrans 
                    inner join Products on Products.ProductID = SupplyTrans.ProductID  
                    inner join Supplier on Supplier.SupplierID = SupplyTrans.SupplierID
                    group by Products.ProductID, Supplier.CompanyName,Supplier.SupplierID,Supplier.SupplierID) AS NSupplier
                    inner join
                    (Select ProductID, ProductName ,ProductCode, Price ,ItemDesc,Price As TProduct From Products group by ProductID, 
                    ProductName , ProductCode, Price,ItemDesc,Price) As NProduct
                    Inner join 
                    (Select ProductID, sum(StockSold) AS TStockSold from BuyingTransaction group by ProductID) AS TotalStocksSold
                    inner join  
                    (Select ProductID, sum(StocksSupplied) AS TStockSup from SupplyTrans  group by ProductID) AS TotalStockFromSupplier
                    on TotalStocksSold.ProductID = TotalStocksSold.ProductID on NProduct.ProductID =TotalStocksSold.ProductID  on NSupplier.ProductID = NProduct.ProductID
                    Where NProduct.ProductID = TotalStockFromSupplier.ProductID
                )
            )", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataProduct.Rows.Add(
                    rdr[0].ToString(), rdr[1].ToString(), 
                    rdr[2].ToString(), rdr[3].ToString(),
                    rdr[4].ToString(), rdr[5].ToString(),
                    rdr[6].ToString(), rdr[7].ToString());
            }

            con.Close();
        }
        #endregion

        #region Button Functions

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmMain back = new FrmMain();
            back.Show();
            this.Visible = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtPrice.Text != "" && txtProductCode.Text != "" 
                && txtItemDescription.Text != "" && ComboSupplierName.Text != "")
            {

                DialogResult DialogResult = MessageBox.Show("Are you sure you want to add this?", "Confirmation", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    String SSupplierID = "";
                    int SProductID = 0;

                    //retrieve supplier id and product id by their names
                    if (ComboSupplierName.Text != "" && txtProductName.ToString() != "")
                    {
               
                        con.Open();
                        cmd = new SqlCommand(@"Select SupplierID from Supplier where CompanyName = '" + ComboSupplierName.ToString() + "' ", con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            SSupplierID = rdr[0].ToString();
                        }
                        con.Close();

                        con.Open();
                        cmd = new SqlCommand(@"Select ProductID from Products where ProductName = '" + txtProductName.ToString() + "' ", con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            SProductID = Convert.ToInt32(rdr[0].ToString());
                        }
                        con.Close();
                    }

                    bool exist = false;//product id // 

                    for (int i = 0; i < dataAddSuppliesToProducts.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataAddSuppliesToProducts.Columns.Count; j++)
                        {
                            if (dataAddSuppliesToProducts.Rows[i].Cells[j].Value != null &&
                                SSupplierID == dataAddSuppliesToProducts.Rows[i].Cells[j].Value.ToString()
                                &&
                                SProductID == Convert.ToInt32(dataAddSuppliesToProducts.Rows[i].Cells[j].Value.ToString())
                                &&
                                txtProductName.Text == dataAddSuppliesToProducts.Rows[i].Cells[3].Value.ToString()
                                ||
                                txtProductCode.Text == dataAddSuppliesToProducts.Rows[i].Cells[4].Value.ToString())
                            {
                                exist = true;
                            }
                        }
                    }

                    if (exist == false)
                    {
                        //insert new product id
                        con.Open();
                        cmd = new SqlCommand(@"insert into Products
                         (ProductName,Price,ItemDesc,ProductCode)
                         Values
                       ('" + txtProductName.Text + "','" + txtPrice.Text + "','" + txtItemDescription.Text + "','"
                        + txtProductCode.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //retrieve new productid
                        con.Open();
                        int ProductID = 0;
                        cmd = new SqlCommand(@"select ProductID FROM Products where ProductName = '"+ txtProductName.Text + "' AND Price = '"
                            + txtPrice.Text + "' AND ItemDesc = '" + txtItemDescription.Text + "' AND ProductCode = '"+txtProductCode.Text+"' ", con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            ProductID = Convert.ToInt32(rdr[0].ToString());
                        }
                        con.Close();

                        //retrieve supplierid from premade suppliers
                        con.Open();
                        string SupplierID = "";
                        cmd = new SqlCommand(@"Select SupplierID FROM Supplier where CompanyName = '"+ComboSupplierName.Text.ToString()+"' ", con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            SupplierID = rdr[0].ToString();
                        }
                        con.Close();

                        //insert product id and supplier id into supply trans with 0 stock supplied to prevent null value calculation
                        con.Open();
                        cmd = new SqlCommand(@"insert into SupplyTrans
                         (StocksSupplied,ProductID,SupplierID)
                        values 
                         ('0','" + ProductID + "','" + SupplierID + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //insert new product id with 0 stockstold to prevent null value calculation
                        con.Open();
                        cmd = new SqlCommand(@"
		                INSERT INTO BuyingTransaction
		                (ProductID,StockSold)
		               	Values
			            ('" + ProductID + "','0')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Congrats, Added!", "Congrats");
                    }

                    else if (exist == true)
                    {
                        MessageBox.Show("Product already assigned, Go to Add Supplies to Product Tab", "Error");
                    }                     
                }

                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Adding Cancelled", "Cancelled");
                }                                
            }

            else
            {
                MessageBox.Show("Invalid Input", "Warning");
            }
            dataProduct.Rows.Clear();
            dataAddSuppliesToProducts.Rows.Clear();
            dataSupplier.Rows.Clear();
            ClearTextbox();
            LoadInventory();
            LoadAddSuppliesToProduct();
            LoadSupplier();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            DisableUpdateButton();
            dataSupplier.Rows.Clear();
            LoadSupplier();
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                DialogResult DialogResult = MessageBox.Show("Are you sure you want to update this?","Confirmation", MessageBoxButtons.YesNo);
                if (dataProduct.SelectedRows.Count != 0 && DialogResult == DialogResult.Yes)
                {

                    con.Open();
                    cmd = new SqlCommand(@" update Products set 
                                Price = '" + txtPrice.Text
                        + "', ItemDesc = '" + txtItemDescription.Text
                        + "' , ProductName = '" + txtProductName.Text
                        + "', ProductCode = '" + txtProductCode.Text
                        + "' where ProductID = '" + txtProductID.Text + "' ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    con.Open();
                    cmd = new SqlCommand(@" ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Update Sucessful", "Success");

                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Update Cancelled","Cancelled");
                }
            }

            else
            {
                MessageBox.Show("Invalid Input", "Invalid");
            }
            dataProduct.Rows.Clear();
            dataAddSuppliesToProducts.Rows.Clear();
            dataSupplier.Rows.Clear();
            ClearTextbox();
            LoadInventory();
            LoadAddSuppliesToProduct();
            LoadSupplier();
        }

        #endregion

        #region Selection Changed

        private void dataProductMgt_SelectionChanged(object sender, EventArgs e)
        {

            if (dataProduct.SelectedRows.Count != 0)
            {
                EnableUpdateButton();
                ComboSupplierName.Enabled = false;
                txtProductID.Text =
                     dataProduct.SelectedRows[0].Cells[0].Value.ToString();
                txtProductCode.Text =
                    dataProduct.SelectedRows[0].Cells[1].Value.ToString();
                txtProductName.Text =
                    dataProduct.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text =
                    dataProduct.SelectedRows[0].Cells[3].Value.ToString();
                txtItemDescription.Text =
                      dataProduct.SelectedRows[0].Cells[4].Value.ToString();
                txtSupplierID.Text =
                      dataProduct.SelectedRows[0].Cells[5].Value.ToString();
                ComboSupplierName.Text =
                    dataProduct.SelectedRows[0].Cells[6].Value.ToString();
            }
        }







        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataProduct.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"
            (
                (
                    Select NProduct.ProductID   , NProduct.ProductCode,  NProduct.ProductName,
                    NProduct.Price,NProduct.ItemDesc,NSupplier.SupplierID,NSupplier.CompanyName ,TStockSup - TStockSold AS CurrentStocks 
                    from 
                    (Select Products.ProductID, Supplier.CompanyName ,Supplier.SupplierID,Supplier.SupplierID AS TSupplier From SupplyTrans 
                    inner join Products on Products.ProductID = SupplyTrans.ProductID  
                    inner join Supplier on Supplier.SupplierID = SupplyTrans.SupplierID
                    group by Products.ProductID, Supplier.CompanyName,Supplier.SupplierID,Supplier.SupplierID) AS NSupplier
                    inner join
                    (Select ProductID, ProductName ,ProductCode, Price ,ItemDesc,Price As TProduct From Products group by ProductID, 
                    ProductName , ProductCode, Price,ItemDesc,Price) As NProduct
                    Inner join 
                    (Select ProductID, sum(StockSold) AS TStockSold from BuyingTransaction group by ProductID) AS TotalStocksSold
                    inner join  
                    (Select ProductID, sum(StocksSupplied) AS TStockSup from SupplyTrans  group by ProductID) AS TotalStockFromSupplier
                    on TotalStocksSold.ProductID = TotalStocksSold.ProductID on NProduct.ProductID =TotalStocksSold.ProductID  on NSupplier.ProductID = NProduct.ProductID
                    Where NProduct.ProductID = TotalStockFromSupplier.ProductID and NProduct.ProductName like '%" + txtSearch.Text+ "%')  )", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataProduct.Rows.Add(
                    rdr[0].ToString(), rdr[1].ToString(),
                    rdr[2].ToString(), rdr[3].ToString(),
                    rdr[4].ToString(), rdr[5].ToString(),
                    rdr[6].ToString(), rdr[7].ToString());
            }

            con.Close();
        }
    }
}
