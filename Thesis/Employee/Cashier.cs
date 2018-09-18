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
    public partial class FrmCashier : Form
    {
        public FrmCashier()
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

        #region Load Functions

        private void GenerateCheckoutID()
        {
            string ID;
            int CheckoutID = 1;

            con.Open();

            cmd = new SqlCommand(@"SELECT MAX(CheckoutID) From BuyingTransaction", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
               ID = rdr[0].ToString();
                if (ID == "")
                {
                    ID = "1000";
                }
                else
                {
                    CheckoutID = 1 + Int32.Parse(ID);
                }
            }
        
            txtCheckoutID.Text = CheckoutID.ToString();

            con.Close();
    
        }

        private void FrmCashier_Load(object sender, EventArgs e)
        {
            LoadProducts();
            GenerateCheckoutID();
        }

        private void LoadProducts()
        {
            con.Open();

            cmd = new SqlCommand(@"SELECT ProductID , ProductCode ,ProductName,ItemDesc, Price
                                    FROM Products", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataProductList.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(),rdr[4].ToString());
            }

            con.Close();
        }

        #endregion

        #region Button Functions 

        private void btnCashier_Logout_Click(object sender, EventArgs e)
        {
            FrmLogin logout = new FrmLogin();
            logout.Show();
            this.Visible = false;
        } 

        private void Add_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "" && txtProductCode.Text != ""
            && txtProduct.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                bool exist = false;

                for (int i = 0; i < dataCart.Rows.Count; i++)
                {
                    for (int j = 0; j < dataCart.Columns.Count; j++)
                    {
                        if (dataCart.Rows[i].Cells[j].Value != null && txtProductID.Text == dataCart.Rows[i].Cells[j].Value.ToString())
                        {
                            exist = true;
                            int quantity = 1;
                            string squantity;

                            squantity = dataCart.Rows[i].Cells[4].Value.ToString();
                            quantity += Int32.Parse(squantity);
                            squantity = quantity.ToString();

                            dataCart.Rows[i].Cells[4].Value = quantity;
                           
                            break;
                        }
                    }  
                }
                
                if (exist == false)
                {
                    dataCart.Rows.Add(txtProductID.Text, txtProductCode.Text, txtProduct.Text, txtPrice.Text, txtQuantity.Text);
                   
                }

            }
        }

        private void btnCashier_Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataCart.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataCart.Rows.Remove(row);
            }
        }

        private void btnCashier_Checkout_Click(object sender, EventArgs e)
        {

                if (dataCart.RowCount.ToString() != "")
                {
                    con.Open();

                    for (int x = 0; x < dataCart.Rows.Count; x++)
                    {
                        cmd = new SqlCommand(@"insert into BuyingTransaction
                        (ProductID,StockSold,TransDateTime,CheckoutID)
                        Values
                        ('"+ dataCart.Rows[x].Cells[0].Value.ToString()+"','"
                        + dataCart.Rows[x].Cells[4].Value.ToString()+"','"
                        + dateTransaction.Value.ToString()+"','"
                        +txtCheckoutID.Text+"')", con);

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                    MessageBox.Show("Transaction Sucessful", "Success");
                }
            

        }

        private void btnSubtotal_Click(object sender, EventArgs e)
        {
            if (dataCart.RowCount.ToString() != "")
            {
                #region variable declaration
                int price = 0;
                string sprice;
                string SQuantity;
                int Quantity;

                int subtotalprice;
                int totalprice = 0;
                #endregion

                for (int x = 0; x < dataCart.Rows.Count; x++)
                {
                    SQuantity = dataCart.Rows[x].Cells[4].Value.ToString();
                    Quantity = Int32.Parse(SQuantity);
                    sprice = dataCart.Rows[x].Cells[3].Value.ToString();
                    price = Int32.Parse(sprice);
                    
                    subtotalprice = price * Quantity;

                    totalprice += subtotalprice;
                }
                txtSubtotal.Text = totalprice.ToString();
            }

            if (dataCart.RowCount == 0)
            {
                MessageBox.Show("Input Error", "Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataProductList.Rows.Clear();
            con.Open();

            cmd = new SqlCommand(@"select  ProductID , ProductCode ,ProductName,ItemDesc, Price from Products where ProductName like '%" + txtSearch.Text
                +"%' or ProductCode like '%"+txtSearch.Text+"%' or ItemDesc like '%"+txtSearch.Text+"%' or Price like '%"+txtSearch.Text+"%'", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataProductList.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }

            con.Close();
        }


        #endregion

        #region Selection Changed

        private void dataProductList_SelectionChanged(object sender, EventArgs e)
        {

            if (dataProductList.SelectedRows.Count != 0)
            {
                txtProductID.Text =
                     dataProductList.SelectedRows[0].Cells[0].Value.ToString();
                txtProductCode.Text =
                    dataProductList.SelectedRows[0].Cells[1].Value.ToString();
                txtProduct.Text =
                     dataProductList.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text =
                    dataProductList.SelectedRows[0].Cells[4].Value.ToString();
                txtQuantity.Text = 1.ToString();

            }
        }


        private void dataCart_SelectionChanged(object sender, EventArgs e)
        {

            
            if (dataCart.SelectedRows.Count != 0)
            {
                txtProductID.Text =
                    dataCart.SelectedRows[0].Cells[0].Value.ToString();
                txtProductCode.Text =
                    dataCart.SelectedRows[0].Cells[1].Value.ToString();
                txtProduct.Text =
                     dataCart.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text =
                    dataCart.SelectedRows[0].Cells[3].Value.ToString();
                txtQuantity.Text = 1.ToString();
            }
        }


        #endregion


    }
}
