CREATE DATABASE DGOLZMART;

USE DGOLZMART;


create table BuyingTransaction
(
BuyingTransID int identity (1001,1) primary key,
CheckoutID int,
StockSold numeric,
TransDateTime datetime,
ProductID int
)

create table Employee
(
EmployeeID int identity(1001,1) primary key,
FirstName varchar(50),
MiddleInitial varchar(50),
LastName varchar(50),
ContactNumber varchar(50),
Email varchar(50),
Address varchar(50),
UserName varchar(50),
Password varchar(50),
IsAdmin varchar(50)
)

create table Products
(
ProductID int identity(1001,1) primary key,
ProductName varchar(50),
ProductCode varchar(50),
ItemDesc varchar(50),
Price numeric
)


create table Supplier
(
SupplierID int identity(1001,1) primary key,
CompanyName varchar(50),
ContactNumber varchar(50),
SupplierAddress varchar(50),
Email varchar(50)
)


create table SupplyTrans
(
SupplyTransID int identity(1001,1) primary key,
ProductID int,
SupplierID int,
StocksSupplied numeric
)

select * from BuyingTransaction
select * from Employee
select * from Products
select * from Supplier
select * from SupplyTrans

insert into Employee
(UserName,Password,IsAdmin)
values
('admin', 'admin',1)
