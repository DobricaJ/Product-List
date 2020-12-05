Firsts steps:

1. Create database ProductList on Microsoft SQL Server.

2. In ProductList create table Products using this script:

Create Table Products(
Id Int Identity(1,1) Primary Key,
ProductId Varchar(10),
Name Varchar(100) Not Null,
Description Varchar(200),
Category Varchar(100),
Manufacturer Varchar(100),
Supplier Varchar(100),
Price Decimal Not Null,
)


3. In file appsettings.json set your server connection

  "ConnectionStrings": {
    "JsonDatabase": "StorageFiles\\",
    "ServerDatabase": "Server=*****;Database=ProductList;Trusted_Connection=True;"
  }
