create table est_cliente
(
	CPF	varchar(14),
	Nome varchar(40),

	Nascto datetime,

	constraint pk_cpf primary key(CPF)
)
;

create table est_veiculo
(
	Modelo int,
	Ano int,

	Placa	varchar(8),
	Cliente_cpf	varchar(14),
	Cor	varchar(20),

	constraint fk_cpf foreign key (Cliente_cpf) references est_cliente (CPF),
	constraint fk_mod foreign key (Modelo) references est_modelo (CodMod),
	constraint pk_placa primary key(Placa)
)
;

create table est_modelo
(
	CodMod	int,

	Descr	varchar(40),

	constraint pk_mod primary key(CodMod)
)
;
create table est_patio
(
	Num	int,
	Capacidade int,

	Ender	varchar(40),

	constraint pk_Num primary key(Num)
)
;
create table est_estacionamento
(
	Codigo	int,
	Patio_Num	int,

	Placa_Veic	varchar(8),
	Hora_Entr	varchar(10),
	Hora_Saida	varchar(10),

	Data_Entr	datetime,
	Data_Saida	datetime,

	constraint fk_num foreign key (Patio_Num) references est_patio (Num),
	constraint fk_placa foreign key (Placa_Veic) references est_veiculo (Placa),
	constraint pk_codigo primary key(Codigo)
)
;

insert into est_cliente values
(
'465852645','Felipe','20050912'
)
,
(
'454652695','João','19990606'
)
,
(
'548963284','Matheus','20010405'
)
,
(
'148569875','Smith','19990303'
)
,
(
'125747894','Kevin','19960909'
)
;

insert into est_veiculo values
(
11,2001,'POV-1314','465852645','Azul'
)
,
(
12,2002,'IVO-9976','454652695','Dourado'
)
,
(
13,1999,'SEP-9862','548963284','Verde'
)
,
(
14,1997,'JEX-1010','148569875','Amarelo'
)
,
(
15,2020,'JJJ-2020','125747894','Vermelho'
)
;

insert into est_modelo values
(
11,'Palio'
)
,
(
12,'Gol'
)
,
(
13,'Fusca'
)
,
(
14,'Ferrari'
)
,
(
15,'Ford KA'
);

insert into est_patio values
(
6,34,'Rua 25 de Março'
)
,
(
7,13,'Rua Quata 67'
)
,
(
8,15,'Rua Atílio Zacharias'
)
,
(
9,29,'Rua Paricatuba'
)
,
(
10,35,'Rua Girassol'
)
;

insert into est_estacionamento values
(
1,6,'POV-1314','16h','17h','20230425','20230426'
)
,
(
2,7,'IVO-9976','16h08min','19h46min','20230421','20230422'
)
,
(
3,8,'SEP-9862','15h19min','21h59min','20230422','20230421'
)
,
(
4,9,'JEX-1010','19h08min','23h54min','20230423','20230421'
)
,
(
5,10,'JJJ-2020','10h','17h14min','20230424','20230421'
)
;

--Exiba a placa e o nome do dono
select est_veiculo.Placa,est_cliente.Nome
from est_veiculo inner join est_cliente
on est_veiculo.Cliente_cpf = est_cliente.CPF;

--Exiba o CPF eo nome do cliente que possui o veículo de placa JJJ-2020
select est_veiculo.Cliente_cpf,est_cliente.Nome
from est_veiculo inner join est_cliente
on est_veiculo.Cliente_cpf = est_cliente.CPF
where est_veiculo.Placa = 'JJJ-2020';

--Exiba a placa e a cor do veículo que possui o código de estacionamento 1
select est_veiculo.Cor,est_estacionamento.Placa_Veic
from est_veiculo inner join est_estacionamento
on est_veiculo.Placa = est_estacionamento.Placa_Veic
where est_estacionamento.Codigo = 1;

--Exiba a placa e o ano do veículo que possui o código de estacionamento 1
select est_veiculo.Ano,est_estacionamento.Placa_Veic
from est_veiculo inner join est_estacionamento
on est_veiculo.Placa = est_estacionamento.Placa_Veic
where est_estacionamento.Codigo = 1;

--Exiba a placa,o ano do veículo e a descrição de seu modelo, se ele possuir ano a partir de 2000
select est_veiculo.Ano,est_estacionamento.Placa_Veic,est_veiculo.Modelo
from est_veiculo inner join est_estacionamento
on est_veiculo.Placa = est_estacionamento.Placa_Veic
where est_veiculo.Ano>= 2000;

--Exiba o endereço,a data de entrada e de saída dos estacionamentos do veículo de placa “JEX-1010”
select est_estacionamento.Placa_Veic,est_estacionamento.Data_Entr,est_estacionamento.Data_Saida,est_patio.Ender
from est_patio inner join est_estacionamento
on est_estacionamento.Patio_Num = est_patio.Num
where est_estacionamento.Placa_Veic = 'JEX-1010';

--Exiba a quantidade de vezes os veículos de cor verde estacionaram
select count(est_estacionamento.Placa_Veic) as 'Quantidade de cor verde'
from est_veiculo inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_veiculo.Cor = 'Verde';

--Liste todos os clientes que possuem carro de modelo 12
select est_cliente.Nome,est_veiculo.Modelo
from est_cliente inner join est_veiculo
on est_veiculo.Cliente_cpf = est_cliente.CPF
inner join est_modelo on est_veiculo.Modelo = est_modelo.CodMod
where est_veiculo.Modelo = 12;

-- Liste as placas, os horários de entrada e saída dos veículos de cor verde
select est_estacionamento.Placa_Veic,est_estacionamento.Hora_Entr,est_estacionamento.Hora_Saida
from est_veiculo inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_veiculo.Cor = 'Verde';

--Liste todos os estacionamentos do veículo de placa “JJJ-2020”
select est_estacionamento.Placa_Veic
from est_veiculo inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_veiculo.Placa = 'JJJ-2020';

--Exiba o nome do cliente que possui o veículo cujo código do estacionamento é 2
select est_cliente.Nome,est_estacionamento.Codigo
from est_cliente inner join est_veiculo
on est_cliente.CPF = est_veiculo.Cliente_cpf
inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_estacionamento.Codigo = 2;

-- Exiba o CPF do cliente que possui o veículo cujo código do estacionamento é 3
select est_cliente.CPF,est_estacionamento.Codigo
from est_cliente inner join est_veiculo
on est_cliente.CPF = est_veiculo.Cliente_cpf
inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_estacionamento.Codigo = 3;

-- Exiba a descrição do modelo do veículo cujo código do estacionamento é 2
select est_modelo.Descr,est_estacionamento.Codigo
from est_modelo inner join est_veiculo
on est_modelo.CodMod = est_veiculo.Modelo
inner join est_estacionamento
on est_estacionamento.Placa_Veic = est_veiculo.Placa
where est_estacionamento.Codigo = 2;

-- Exiba a placa, o nome dos donos e a descrição dos modelos de todos os veículos
select est_modelo.Descr,est_cliente.Nome,est_veiculo.Placa
from est_modelo inner join est_veiculo
on est_modelo.CodMod = est_veiculo.Modelo
inner join est_cliente
on est_cliente.CPF = est_veiculo.Cliente_cpf;