
--Calcular soma de 2 num

Create function soma (@v1 float, @v2 float) returns float as begin

	declare @soma float;
	set @soma = @v1 + @v2;
	return @soma;
end
go

--teste da função
select dbo.soma(4,7);

--Monte uma função para calcular a area de um trapezio
go
Create function Trapezio (@bme float, @bma float,@h float) returns float as begin
	declare @area float;
	set @area = (@bma+@bme)*@h/2;
	return @area;
end
go
--Ou uma linha
go
Create function Trapezio1 (@bme float, @bma float,@h float) returns float as begin
	return (@bma+@bme)*@h/2;
end
go
--teste da função
select dbo.Trapezio(4,1,5);

--Calcular media  da fatec
go
Create function Media(@p1 float ,@p2 float, @t float) returns float as begin
	return @p1*0.35 + @p2*0.35 + @t*0.3;
end
go

--teste da função
select dbo.Media(4,7,10);

--Criando tabela
Create Table Notas
(
	cod int identity(1,1),
	nome nvarchar(30),
	p1 float,
	p2 float,
	t float
)
;
insert into Notas(nome,p1,p2,t) values ('Macaco',8,7,9);
insert into Notas(nome,p1,p2,t) values ('Ma',1,0,0);
insert into Notas(nome,p1,p2,t) values ('Maco',2,2,2);
insert into Notas(nome,p1,p2,t) values ('Maca',1,5,3);
insert into Notas(nome,p1,p2,t) values ('Macco',3,4,9);
Select * From Notas;

select*,dbo.Media(p1,p2,t) as 'Media' from notas;

go
Create function resultadofatec (@media float) returns varchar(20) as 
begin
	declare @resul varchar(20);
	if(@media >= 6)
		set @resul = 'Aprovado';
		else if(@media <6 and @media>=3)
		set @resul = 'P3';
		else
		set @resul = 'Reprovado';
		return @resul;
end 
go

select dbo.resultadofatec(10);
select dbo.resultadofatec(5);
select dbo.resultadofatec(2);

--Selecionando duas funções!
Select*,dbo.Media(p1,p2,t) As 'Media', dbo.resultadofatec(dbo.Media(p1,p2,t)) as 'Resultado' from Notas;

go
Create Function JuroComposto ( @valor float,@juros float, @meses int)returns float as
begin
	declare @resultado float,@i int;
	set @i=1;
	while(@i <=@meses)
	begin
		set @valor = @valor * (1+@juros/100);
		set @i = @i+1;
	end
	set @resultado= @valor;
	return @resultado;
end
go

Select dbo.JuroComposto(1000,2,5) As 'Preço com Juros';
Select dbo.JuroComposto(1000,2,12) As 'Preço com Juros';

Create Table Emprestimos
(
	nome	nvarchar(30),
	valor	float,
	tempo	int,
	juros	float
)
insert into Emprestimos values ('Bruna',2000,30,1);
insert into Emprestimos values ('Renata',100000,36,4);
insert into Emprestimos values ('Glaucio',7000,30,2.5);
insert into Emprestimos values ('Helen',5000,12,0.5);
insert into Emprestimos values ('Vanessa',30000,12,0.5);
insert into Emprestimos values ('Ednilson',10000,12,8.5);

select *,dbo.JuroComposto(valor,juros,tempo) as 'Montante' from Emprestimos;