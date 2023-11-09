--Criar as tabelas e Relacionamentos.
--1 
CREATE TABLE Servi�os
(Cod_serv int,
Descri��o varchar(30),
Pre�o numeric(10,2),
CONSTRAINT P8K_COD PRIMARY KEY(Cod_serv),
);

Select * From Servi�os;

Drop Table Servi�os;

--4
CREATE TABLE Animais(
Codigo int,
Ra�a int,
Nome varchar(20),
Idade int,
Cor char(20),
Porte char(20),
Dono int,
Tipo varchar(20),
CONSTRAINT P1K_COD FOREIGN KEY(Ra�a) references Racas(Cod_raca),
CONSTRAINT P2K_COD FOREIGN KEY(Dono) references Donos(Cod_dono),
CONSTRAINT P3K_COD PRIMARY KEY(Codigo));

Select * From Animais;

Drop Table Animais;
--3
CREATE TABLE Donos
(Cod_dono int,
Nome varchar(40),
Fone char(10),
Endere�o varchar(40),
Cidade varchar(20), 
Bairro varchar(40),
CONSTRAINT P4K_COD PRIMARY KEY(Cod_dono));

Select * From Donos;

Drop Table Donos;
--2
CREATE TABLE Racas
(Cod_raca int,
Descri��o varchar(200),
CONSTRAINT P5K_COD PRIMARY KEY(Cod_raca),
);

Select * From Racas;

Drop Table Racas;
--5
CREATE TABLE Agendamento
(Cod_agd int,
Datta datetime,
Animal int,
CONSTRAINT P6K_COD FOREIGN KEY(Animal) references Animais(Codigo),
CONSTRAINT P7K_COD PRIMARY KEY(Cod_agd),
);

Select * From Agendamento;

Drop Table Agendamento;

--6
CREATE TABLE Itens_agendados
(Cod_agd int, 
Cod_serv int,
Hor�rio char(4),
CONSTRAINT P9K_COD FOREIGN KEY(Cod_agd) references Agendamento(Cod_agd),
CONSTRAINT P10K_COD FOREIGN KEY(Cod_serv) references Servi�os(Cod_serv),
CONSTRAINT P11K_COD PRIMARY KEY(Cod_serv),
);

Select * From Itens_agendados;

Drop Table Itens_agendados;
 --Inserir 10 registro sem cada tabela
INSERT INTO Animais (Codigo, Ra�a, Nome, Idade, Cor, Porte, Dono, Tipo) VALUES
 (1, 1, 'Fido', 1, 'Marrom', 'Pequeno', 1, 'Cachorro'),
 (2, 2, 'Nina', 2, 'Branco', 'M�dio', 2, 'Cachorro'),
 (3, 3, 'Tico', 3, 'Preto', 'Pequeno', 3, 'Gato'),
 (4, 4, 'Luna', 4, 'Cinza', 'Grande', 4, 'Cachorro'),
 (5, 5, 'F�lix', 5, 'Amarelo', 'M�dio', 5, 'Gato'),
 (6, 6, 'Buddy', 6, 'Marrom', 'Pequeno', 6, 'Cachorro'),
 (7, 7, 'Mimi', 7, 'Branco', 'Pequeno', 7, 'Gato'),
 (8, 8, 'Max', 8, 'Preto', 'Grande', 8, 'Cachorro'),
 (9, 9, 'Lola', 9, 'Cinza', 'M�dio', 9, 'Cachorro'),
 (10, 10, 'Simba', 10, 'Amarelo', 'Grande', 10, 'Gato');

INSERT INTO Donos (Cod_dono, Nome, Fone, Endere�o, Cidade, Bairro) VALUES
 (1, 'Jo�o da Silva', '1111111111', 'Rua das Flores, 123', 'S�o Paulo', 'Centro'),
 (2, 'Maria Oliveira', '2222222222', 'Av. dos Bandeirantes, 456', 'Rio de Janeiro', 'Copacabana'),
 (3, 'Carlos Santos', '3333333333', 'Rua dos L�rios, 789', 'Belo Horizonte', 'Savassi'),
 (4, 'Ana Souza', '4444444444', 'Av. Paulista, 567', 'S�o Paulo', 'Jardins'),
 (5, 'Jos� Silva', '5555555555', 'Rua das Margaridas, 890', 'Bras�lia', 'Asa Sul'),
 (6, 'Paula Costa', '6666666666', 'Rua da Praia, 123', 'Florian�polis', 'Centro'),
 (7, 'Pedro Nunes', '7777777777', 'Av. Nove de Julho, 234', 'S�o Paulo', 'Jardim Paulista'),
 (8, 'Mariana Ferreira', '8888888888', 'Rua das Ac�cias, 567', 'Porto Alegre', 'Moinhos de Vento'),
 (9, 'Lucas Santos', '9999999999', 'Av. Brasil, 901', 'S�o Paulo', 'Vila Mariana'),
 (10, 'Gabriela Oliveira', '1010101010', 'Rua das Orqu�deas, 102', 'Salvador', 'Barra');

 INSERT INTO Racas (Cod_raca, Descri��o) VALUES
  (1, 'Poodle'),
  (2, 'Golden Retriever'),
  (3, 'Bulldog'),
  (4, 'Siam�s'),
  (5, 'Persa'),
  (6, 'Pastor Alem�o'),
  (7, 'Rottweiler'),
  (8, 'Schnauzer'),
  (9, 'Doberman'),
  (10, 'Boxer');

INSERT INTO Agendamento (Cod_agd, Datta, Animal) VALUES
  (1, '20230515', 1),
  (2, '20230516', 2),
  (3, '20230518', 3),
  (4, '20230520', 4),
  (5, '20230521', 5),
  (6, '20230522', 6),
  (7, '20230523', 7),
  (8, '20230524', 8),
  (9, '20230525', 9),
  (10, '20230526', 10);

INSERT INTO Servi�os (Cod_serv, Descri��o, Pre�o) VALUES
 (1, 'Banho e Tosa', 50.00),
 (2, 'Consulta veterin�ria', 120.00),
 (3, 'Vacina��o', 80.00),
 (4, 'Cirurgia', 500.00),
 (5, 'Exames laboratoriais', 150.00),
 (6, 'Hospedagem', 40.00),
 (7, 'Adestramento', 80.00),
 (8, 'Corte de unhas', 20.00),
 (9, 'Limpeza de ouvidos', 30.00),
 (10, 'Atendimento domiciliar', 200.00);

INSERT INTO Itens_agendados (Cod_agd, Cod_serv, Hor�rio) VALUES
  (1, 1, '1000'),
  (2, 2, '1100'),
  (3, 3, '1430'),
  (4, 4, '1530'),
  (5, 5, '1115'),
  (6, 6, '1600'),
  (7, 7, '0900'),
  (8, 8, '1545'),
  (9, 9, '1230'),
  (10, 10, '1015');

--Selecionar o c�digo do animal, o c�digo da ra�a, descri��o da ra�a, porte eo nome do dono
select Animais.Codigo, Racas.Cod_raca, Racas.Descri��o, Animais.Porte, Donos.Nome
From Animais inner join  Racas
on Racas.Cod_raca = Animais.Ra�a
 inner join  Donos 
on Donos.Cod_Dono = Animais.Dono;

--Listar os registros e campos de todos os animais da ra�a Golden Retrievier;
select Animais.*,Racas.*
from Animais join Racas
on Racas.Cod_raca = Animais.Ra�a
where Descri��o in ('Golden Retriever');

--Qual a idade do animal mais velho?
SELECT Max (Idade) AS 'Mais Velho'
from Animais;

--Listar todos os registros e campos dos servi�os com pre�o entre 20 e 50 reais;
select Servi�os.*,Itens_agendados.*,Agendamento.*
from Servi�os join Itens_agendados
on Servi�os.Cod_serv = Itens_agendados.Cod_serv 
join  Agendamento 
on Itens_agendados.Cod_agd = Agendamento.Cod_agd
where Pre�o > 20 and Pre�o < 50;

--Listar c�digo do agendamento, data e nome do animal;
select Agendamento.*, Animais.Nome, Animais.Codigo
from Agendamento join Animais
on Agendamento.Animal =Animais.Codigo;

--Quantos itens tem o agendamento 01?

SELECT COUNT (*) AS 'QTDE Agendamento'
FROM Agendamento
where Cod_agd = 1;

--Listar c�digo do agendamento, descri��o do servi�o e hor�rio, de todos os servi�os agendados.
select Servi�os.Descri��o,Itens_agendados.Hor�rio,Agendamento.Cod_agd
from Servi�os join Itens_agendados
on Servi�os.Cod_serv = Itens_agendados.Cod_serv 
join  Agendamento 
on Itens_agendados.Cod_agd = Agendamento.Cod_agd;

--Listar o nome do animal, nome do dono, de todos os animais do tipo canino.
select Animais.Nome, Animais.Tipo, Donos.Nome
from Animais join Donos
on Animais.Dono = Donos.Cod_dono
where Tipo in ('Cachorro');

--Listar o nome do animal,Tipo, Porte e data Agendamento, independentemente se tenham ou n�o agendamentos.
select Animais.Nome,Animais.Tipo,Animais.Porte,Agendamento.Datta
from Animais join Agendamento 
on Animais.Codigo = Agendamento.Cod_agd;

--Listar todos os agendamentos da data igual � mais recente.

SELECT * FROM Agendamento WHERE Datta = (SELECT MAX(Datta) FROM Agendamento);
