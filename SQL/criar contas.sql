

create table Contas(
	CodConta		int,
	DataAbertura	datetime,
	Agencia			int,
	Saldo			money,
      cliente	nvarchar(20)
)
---------------------------------------------------------
insert into contas (Codconta,dataAbertura,Agencia,Saldo,cliente) 
				values (100,'01/01/2015',303,0,'ana')
insert into contas (Codconta,dataAbertura,Agencia,Saldo,cliente) 
				values (200,'01/02/2015',305,0,'eva')
insert into contas (Codconta,dataAbertura,Agencia,Saldo,cliente) 
				values (300,'01/03/2015',305,0,'rui')
insert into contas (Codconta,dataAbertura,Agencia,Saldo,cliente) 
				values (400,'01/05/2015',303,0,'bob')

-----------------------------------------------
create table Depositos(
	CodConta		int,
	DataDeposito	datetime,
	valor			money
)

---------------------------------------------------
create table Saques(
	CodConta		int,
	Datasaque	    datetime,
	valor			money
)


----------------------------------------------------------------------
go
create trigger Saque on Saques after insert as
begin
	declare @codconta int,@valor money;
	select @codconta = codconta from inserted;
	select @valor = valor from inserted;

	update Contas set saldo = saldo - @valor where codconta = @codconta;
end
go
------------------------------------------------------------------------------------
go
create trigger Deposito on Depositos after insert as
begin
	declare @codconta int,@valor money;
	select @codconta = codconta from inserted;
	select @valor = valor from inserted;

	update Contas set saldo = saldo + @valor where codconta = @codconta;
end
go
--------------------------------------------------------------------------------

select * from Contas

select * from Depositos

select * from Saques

insert into depositos (codconta, datadeposito, valor) values (300,'08/11/23',10)
insert into depositos (codconta, datadeposito, valor) values (400,'08/11/23',15)
insert into depositos (codconta, datadeposito, valor) values (200,'08/11/23',9.99)
insert into depositos (codconta, datadeposito, valor) values (300,'08/11/23',5000)
insert into depositos (codconta, datadeposito, valor) values (100,'08/11/23',17000)
insert into depositos (codconta, datadeposito, valor) values (100,'08/11/23',29000)

insert into Saques (codconta, Datasaque, valor) values (300,'08/11/23',10)
insert into Saques (codconta, Datasaque, valor) values (400,'08/11/23',15)
insert into Saques (codconta, Datasaque, valor) values (200,'08/11/23',10)
insert into Saques (codconta, Datasaque, valor) values (300,'08/11/23',5000)
insert into Saques (codconta, Datasaque, valor) values (100,'08/11/23',17000)
insert into Saques (codconta, Datasaque, valor) values (100,'08/11/23',29000)