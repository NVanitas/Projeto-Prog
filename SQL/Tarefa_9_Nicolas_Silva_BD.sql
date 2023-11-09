--Criar as tabelas x Relacionamentos:
--Clientes
Create table Clientes(
Codcli  int,
Nome   varchar(300),
Endereço varchar(400),
Cidade  varchar(300),
Fone     char(9),
idade      int,
CONSTRAINT KFA_COD PRIMARY KEY(Codcli));

Select * from Clientes;

Drop table Clientes;

--Pedidos
Create table Pedidos(
NumPed int,
Cliente int,
Data_Entrega datetime,
Transporte int,
CONSTRAINT PKB_COD PRIMARY KEY(NumPed),
CONSTRAINT KFy_COD FOREIGN KEY(Cliente) references Clientes(Codcli),
CONSTRAINT KFz_COD FOREIGN KEY(Transporte) references Transportadora(Codigo));

Select * from Pedidos;

Drop table Pedidos;

--Transportadora
Create table Transportadora(
Codigo int,
Nome varchar(20),
CONSTRAINT PKC_COD PRIMARY KEY(Codigo));

Select * from Transportadora;

Drop table Transportadora;

--Inserir 5 registros

INSERT INTO Clientes (Codcli, Nome, Endereço, Cidade, Fone, Idade)
VALUES 
('001', 'Pedro','Rodovia Raposo Tavares Vila Gomes Cardim','Santo André','111111111','53'),
('002', 'Lula','Rua das Fiandeiras Parque Imperial','Mauá','22222222','76'),
('003', 'Bolsonaro', 'Rua Maria Luísa do Val Vila Gomes Cardim','SBC','33333333','32'),
('004','Sergio', 'Rua Paracatu Vila Olímpia','SCS','44444444','26'),
('005','Bluezão','Rua Serra de Bragança Vila Joana','Franca','55555555','62');

--Inserir 5 registros 

INSERT INTO Transportadora (Codigo,Nome)
VALUES 
('001','Epic Records'),
('002','DGC'),
('003','Harvest'),
('004','ABC'),
('005','Parlophone');

INSERT INTO Pedidos (NumPed, Cliente, Data_Entrega, Transporte)
VALUES 
('633', '001','20230503','001'),
('797', '002','20230206','002'),
('990', '003', '20231002','003'),
('972','004', '20231102','004'),
('232','005','20230722','005');

--Selecionar todos os pedidos da transportadora ABC. 

Select * From Pedidos WHERE Transporte IN ('004');

--Quantos pedidos existem para o cliente 2

Select COUNT (*) AS 'QTDE PD CL 2' From Pedidos WHERE Cliente IN ('002');

--Qual o número do Pedido mais recente? 

SELECT MAX (Data_Entrega) AS 'Pedido mais recente' FROM Pedidos;

--Temos quantos pedidos para a Transportadora ABC? 

Select COUNT (*) AS 'QTDE PD TRANSPORTADORA' From Pedidos WHERE Transporte IN ('004');

--Quantos Clientes residem em Mauá? 

Select COUNT (*) AS 'QTDE Cliente cidade' From Clientes WHERE Cidade IN ('Maua');

--Selecionar Número do Pedido, Data_Entrega e Nome do Cliente. 

Select Pedidos.NumPed,Pedidos.Data_Entrega,Clientes.Nome
FROM Pedidos INNER JOIN Transportadora on Pedidos.Transporte = Transportadora.Codigo
INNER JOIN CLIENTES ON PEDIDOS.CLIENTE = CLIENTES.CODCLI;

--Selecionar Número do Pedido, Nome do Cliente e nome da Transportadora. 

Select Pedidos.NumPed,Clientes.Nome,Transportadora.Nome
FROM Pedidos INNER JOIN Transportadora on Pedidos.Transporte = Transportadora.Codigo
INNER JOIN CLIENTES ON PEDIDOS.CLIENTE = CLIENTES.CODCLI;

--Selecionar todos os clientes da cidade de Santo André, Mauá e SBC.

Select * From Clientes WHERE Cidade IN ('Mauá','Santo André','SBC');

--Quantos clientes temos acima da média de idade?

SELECT AVG (Idade) AS 'Media idade' FROM Clientes;

--Media = 49

Select COUNT (*) AS 'Idade acima da media' From Clientes WHERE Idade > 49;

--Quantos pedidos temos na data mais recente?

SELECT MAX (Data_Entrega) AS 'Pedido mais recente' FROM Pedidos;

--2023-11-02 data mais recente 

Select COUNT (*) AS 'Quantas Pedidos Recentes' From Pedidos WHERE Data_Entrega > 2023-11-02;

--Selecionar os clientes com idade abaixo da média

select COUNT (*) as 'pedidos com data recente' from pedidos  
where data_entrega = (select max(data_entrega) from pedidos);