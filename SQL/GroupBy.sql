--Group By

Select Count(*) From Products Group By CategoryID;

Select CategoryID,Count(*) From Products Group By CategoryID;

/*Right Way*/

Select CategoryName,Count(*) as 'Quantidade' From Products Inner Join Categories On Products.CategoryID = Categories.CategoryID Group By CategoryName;

Select CategoryName,AVG(UnitPrice) As 'Média' From Categories Inner Join Products On Products.CategoryID = Categories.CategoryID Group By CategoryName;

Select CategoryName,Avg(UnitPrice) As 'Média' From Categories Inner Join Products On Categories.CategoryID = Products.CategoryID Where Categories.CategoryID = 4  Group By CategoryName;

Select CategoryName,Avg(UnitPrice) As 'Média' From Categories Inner Join Products On Products.CategoryID = Categories.CategoryID Group By CategoryName Having Avg(UnitPrice) >= 30;

Select Country,Sum(Quantity*UnitPrice) As 'Soma' From Orders Inner Join [Order Details] On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID Group By Country;

Select Country,Sum(Quantity*UnitPrice) As 'Soma' From Orders Inner Join [Order Details] On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID Where OrderDate Between '01/01/2023' And '31/12/2023' Group By Country;

Select Country,Sum(Quantity*UnitPrice) As 'Valor Gasto Por Clientes' From Orders Inner Join [Order Details] On Orders.OrderID = [Order Details].OrderID Inner Join Customers On Orders.CustomerID = Customers.CustomerID Where OrderDate Between '01/01/2023' And '31/12/2023' Group By Country Having Sum(Quantity*UnitPrice) >= 10000;