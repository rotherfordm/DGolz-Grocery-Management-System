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
    public partial class FrmTransactionHistory : Form
    {
        public FrmTransactionHistory()
        {
            InitializeComponent();
        }


        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        private void LoadSales()
        {
            con.Open();
            cmd = new SqlCommand(@"Select  
                    sum(NProduct.Price * TStockSold) AS TotalSales 
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
                    Where NProduct.ProductID = TotalStockFromSupplier.ProductID", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblTotalsales.Text = rdr[0].ToString();
            }
            con.Close();
        }

        private void LoadCheckouts()
        {
            con.Open();
            cmd = new SqlCommand(@"(( SELECT CheckoutID, TransDateTime, SUM(Price * StockSold)  AS TotalSales
            From
            (SELECT CheckoutID, TransDateTime,ProductID,StockSold FROM BuyingTransaction 
            where CheckoutID = CheckoutID 
            group by CheckoutID, BuyingTransID, TransDateTime, ProductID, StockSold	) AS NTrans
            inner join
            (SELECT ProductID,Price FROM Products group by ProductID,Price )AS NProduct
            on NProduct.ProductID = NTrans.ProductID
            where NProduct.ProductID = NTrans.ProductID and NTrans.CheckoutID = NTrans.CheckoutID
            group by   CheckoutID, TransDateTime 
            ))", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCheckoutHistory.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString());
            }
            con.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain back = new FrmMain();
            back.Show();
            this.Visible = false;
        }

        private void FrmTransactionHistory_Load(object sender, EventArgs e)
        {
            LoadSales();
            LoadCheckouts();
        }

      
        private void dataCheckoutHistory_SelectionChanged(object sender, EventArgs e)
        {
         


            if (dataCheckoutHistory.SelectedRows.Count != 0)
            {
                if (dataProductsTransacted.Rows.Count != 0)
                {
                    dataProductsTransacted.Rows.Clear();
                }
                con.Open();

                cmd = new SqlCommand(@" 
                (
                Select NProduct.ProductID   ,  NProduct.ProductName,NProduct.Price, TStockSold,
                NProduct.Price *  TotalStocksSold.TStockSold AS TotalSales
                from 
                (Select Products.ProductID, Supplier.CompanyName ,Supplier.SupplierID,Supplier.SupplierID AS TSupplier From SupplyTrans inner join Products
                 on Products.ProductID = SupplyTrans.ProductID  
                inner join Supplier on Supplier.SupplierID = SupplyTrans.SupplierID
               group by Products.ProductID, Supplier.CompanyName,Supplier.SupplierID,Supplier.SupplierID) AS NSupplier

                  inner join
                (Select ProductID, ProductName ,ProductCode, Price ,ItemDesc,Price As TProduct From Products group by ProductID, 
                  ProductName , ProductCode, Price,ItemDesc,Price) As NProduct


                 Inner join 
                (Select ProductID, CheckoutID , sum(StockSold) AS TStockSold from BuyingTransaction group by CheckoutID,ProductID) AS TotalStocksSold

                inner join  
                (Select ProductID, sum(StocksSupplied) AS TStockSup from SupplyTrans  group by ProductID) AS TotalStockFromSupplier

                on TotalStocksSold.ProductID = TotalStocksSold.ProductID on NProduct.ProductID =TotalStocksSold.ProductID   
                on NSupplier.ProductID = NProduct.ProductID  
                Where NProduct.ProductID = TotalStockFromSupplier.ProductID AND CheckoutID = '"+dataCheckoutHistory.SelectedRows[0].Cells[0].Value+"' ) ", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataProductsTransacted.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());

                }
                con.Close();

            }
        }
    }
}
