

 
 --Load Inventory
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






--Load Transaction History

Select NProduct.ProductID   ,  NProduct.ProductName, CheckoutID,NProduct.Price, TStockSold,
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



	--Load Supplier
	
	SELECT SupplyTrans.SupplierID, Supplier.CompanyName , SupplyTrans.ProductID, ProductName 
	FROM SupplyTrans
	inner join Products on  SupplyTrans.ProductID = Products.ProductID
	inner join Supplier on SupplyTrans.SupplierID =  Supplier.SupplierID
	group by SupplyTrans.SupplierID, Supplier.CompanyName, SupplyTrans.ProductID, Products.ProductName	
             Where NProduct.ProductID = TotalStockFromSupplier.ProductID AND CheckoutID = CheckoutID




