Select * From Products Inner Join Categories On Products.CategoryID =  Categories.CategoryID;

Select * From Products P Inner Join Categories C On P.CategoryID =  C.CategoryID;

--products -- suppliers
Select * From Products Inner Join Suppliers On Products.SupplierID = Suppliers.SupplierID;

Select ProductName,UnitPrice From Products Inner Join Suppliers On Products.SupplierID = Suppliers.SupplierID;

--orders -- customers
Select * From Customers Inner Join Orders On Orders.CustomerID = Customers.CustomerID;

--orders -- employees
Select * From Orders Inner Join Employees On Orders.EmployeeID = Employees.EmployeeID;

-- [order details] -- products
Select * From Products Inner Join [Order Details] On Products.ProductID = [Order Details].ProductID ;

-- [order details] -- orders
Select * From  [Order Details] Inner Join Orders On Orders.OrderID = [Order Details].OrderID ;

-- customers -- orders -- employees
Select * From Customers Inner Join Orders On Orders.CustomerID = Customers.CustomerID Inner Join Employees On Orders.EmployeeID = Employees.EmployeeID;

-- products -- suppliers -- categories
Select * From Products Inner Join Suppliers On Products.SupplierID = Suppliers.SupplierID Inner Join Categories On Products.SupplierID = Suppliers.SupplierID ;  

-- [Orders details] -- orders -- customers
Select * From  [Order Details] Inner Join Orders On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID;

--valor do meu estoque
Select Sum (Unitprice*UnitsInStock) From Products;

--valor das vendas da empresa
Select Sum (Unitprice*Quantity) From [Order Details];

Select Sum (Unitprice*Quantity) From [Order Details] [Orders Details] Inner Join Orders On Orders.OrderID = [Orders Details].OrderID where Year(OrderDate) =2022;

--products [Order details] Orders Customers
Select * From  Products Inner Join [Order Details] On Products.ProductID = [Order Details].ProductID Inner Join Orders On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID;

--inner join total
Select * From  Suppliers Inner Join Products On Suppliers.SupplierID = Products.SupplierID Inner Join [Order Details] On Products.ProductID = [Order Details].ProductID Inner Join Orders On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID Inner Join Employees On Employees.EmployeeID = Orders.EmployeeID Inner Join Categories On Categories.CategoryID = Products.CategoryID;