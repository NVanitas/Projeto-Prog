create trigger VenderItem on [order details] after insert as
begin
	declare @codproduto int,@quantidade int;

	select @codproduto = ProductID from inserted;
	select @quantidade = quantity from inserted;

	update products set UnitsInStock = UnitsInStock - @quantidade where productid = @codproduto;
end

select*from [Order Details] where OrderID=10248;

select*from Products where ProductID=1;

insert into [Order Details] (OrderID,ProductID,UnitPrice,Quantity,Discount) values(10248,1,25,9,0);

go
------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------


create trigger DevolveItem on [order details] after delete as
begin
	declare @codproduto int,@quantidade int;

	select @codproduto = ProductID from deleted;
	select @quantidade = quantity from deleted;

	update products set UnitsInStock = UnitsInStock + @quantidade where productid = @codproduto;
end

go

select*from [Order Details] where OrderID=10248;

select*from Products where ProductID=1;

delete from [Order Details] where OrderID = 10248 and ProductID= 1;