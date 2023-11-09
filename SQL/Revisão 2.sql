Select * From Products;
Select * from  Orders;
Select * From Categories;

/*Funções de Agregação
COUNT - Quantidade
SUM - Somar
AVG - Média
MAX - Valor Maximo
MIN - Valor Minimo
*/

--Count
Select COUNT(*) From Products;

-- Qual a quantidade de tipos de bebidas na tabela de produtos:
Select COUNT(*) From Products Where CategoryID = 1;

--Qual a quantidade de clientes da Alemanhã
Select COUNT(*) From Customers Where Country = 'Germany';

--Qual a quantidade de pedidos do cliente de codigo ANTON
Select COUNT(*) From Customers Where CustomerID = 'ANTON';

--Qual a quantidade de produtos do fornecedor de codigo 3
Select COUNT(*) From Products Where SupplierID = 3;

--Qual a quantidade de pedidos do atendidos pelo funcionário de codigo 4
Select COUNT(*) From Orders Where EmployeeID = 4;

--Qual a quantidade de pedidos do cliente de codigo HANAR no ano de 2048
Select COUNT(*) From Orders Where CustomerID = 'HANAR' And OrderDate >= '01/01/2048' And OrderDate <= '31/12/2048';

--Ou Year
Select COUNT(*) From Orders Where CustomerID = 'HANAR' And Year(OrderDate) = 2048; 


--Ou Between
Select COUNT(*) From Orders Where CustomerID = 'HANAR' And OrderDate Between '01/01/2048' And '31/12/2048';

--Mostrar os clientes da Argentina,Brazil e Venezuela
Select * From Customers Where Country = 'Argentina' Or Country= 'Brazil' Or Country = 'Venezuela';

--Ou In
Select * From Customers Where Country in ('Argentina','Brazil','Venezuela');

--Sum

--Somar a coluna preço unitario da tabela de produtos
Select SUM(unitprice) From Products;

--Somar a quantidade de peças do estoque
Select SUM(UnitsInStock) From Products;

--Qual a soma do valor do meu estoque
Select SUM(UnitPrice*UnitsInStock) From Products;

--Qual o valor do estoque de bebidas
Select SUM(UnitPrice*UnitsInStock) From Products Where CategoryID = 1;

--Qual o valor do estoque de Grãos e cereais
Select SUM(UnitPrice*UnitsInStock) From Products Where CategoryID = 5;

--Qaul a somatoria das vendas da empresa northwind
Select SUM(unitprice*quantity) From [Order Details];

--Avg

--Mostrar a media dos preços dos produtos no estoque
Select AVG(unitprice) From Products;

--Preço medio dos grãos e cereais
Select AVG(unitprice) From Products Where CategoryID = 1;

--Max

--Qual o maior preço
Select MAX(unitprice) From Products

--Qual o produto que tem o maior preço
Select * From Products Where UnitPrice = (Select MAX (unitprice) From Products);

--Qual o Produto com a maior quantidade em Estoque
Select * From Products Where UnitsInStock = (Select MAX (UnitsInStock) From Products);

--Min

--Qual o menor preço
Select MIN(unitprice) From Products

--Qual o produto que tem o menor preço
Select * From Products Where UnitPrice = (Select MIN (unitprice) From Products);

--Qual o Produto com a menor quantidade em Estoque
Select * From Products Where UnitsInStock = (Select MIN (UnitsInStock) From Products);

--Inner Join
Select * From Products INNER JOIN Categories On Products.CategoryID = Categories.CategoryID;

--Ou Apelido
Select * From Products P INNER JOIN Categories C On P.CategoryID = C.CategoryID;