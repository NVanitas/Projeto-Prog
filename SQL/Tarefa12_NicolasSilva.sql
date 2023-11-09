--Criar as tabelas e Relacionamentos.
--1 
CREATE TABLE Serviços
(Cod_serv int,
Descrição varchar(30),
Preço numeric(10,2),
CONSTRAINT P8K_COD PRIMARY KEY(Cod_serv),
);

Select * From Serviços;

Drop Table Serviços;

--4
CREATE TABLE Animais(
Codigo int,
Raça int,
Nome varchar(20),
Idade int,
Cor char(20),
Porte char(20),
Dono int,
Tipo varchar(20),
CONSTRAINT P1K_COD FOREIGN KEY(Raça) references Racas(Cod_raca),
CONSTRAINT P2K_COD FOREIGN KEY(Dono) references Donos(Cod_dono),
CONSTRAINT P3K_COD PRIMARY KEY(Codigo));

Select * From Animais;

Drop Table Animais;
--3
CREATE TABLE Donos
(Cod_dono int,
Nome varchar(40),
Fone char(10),
Endereço varchar(40),
Cidade varchar(20), 
Bairro varchar(40),
CONSTRAINT P4K_COD PRIMARY KEY(Cod_dono));

Select * From Donos;

Drop Table Donos;
--2
CREATE TABLE Racas
(Cod_raca int,
Descrição varchar(200),
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
Horário char(4),
CONSTRAINT P9K_COD FOREIGN KEY(Cod_agd) references Agendamento(Cod_agd),
CONSTRAINT P10K_COD FOREIGN KEY(Cod_serv) references Serviços(Cod_serv),
CONSTRAINT P11K_COD PRIMARY KEY(Cod_serv),
);

Select * From Itens_agendados;

Drop Table Itens_agendados;
 --Inserir 10 registro sem cada tabela
INSERT INTO Animais (Codigo, Raça, Nome, Idade, Cor, Porte, Dono, Tipo) VALUES
 (1, 1, 'Fido', 1, 'Marrom', 'Pequeno', 1, 'Cachorro'),
 (2, 2, 'Nina', 2, 'Branco', 'Médio', 2, 'Cachorro'),
 (3, 3, 'Tico', 3, 'Preto', 'Pequeno', 3, 'Gato'),
 (4, 4, 'Luna', 4, 'Cinza', 'Grande', 4, 'Cachorro'),
 (5, 5, 'Félix', 5, 'Amarelo', 'Médio', 5, 'Gato'),
 (6, 6, 'Buddy', 6, 'Marrom', 'Pequeno', 6, 'Cachorro'),
 (7, 7, 'Mimi', 7, 'Branco', 'Pequeno', 7, 'Gato'),
 (8, 8, 'Max', 8, 'Preto', 'Grande', 8, 'Cachorro'),
 (9, 9, 'Lola', 9, 'Cinza', 'Médio', 9, 'Cachorro'),
 (10, 10, 'Simba', 10, 'Amarelo', 'Grande', 10, 'Gato');

INSERT INTO Donos (Cod_dono, Nome, Fone, Endereço, Cidade, Bairro) VALUES
 (1, 'João da Silva', '1111111111', 'Rua das Flores, 123', 'São Paulo', 'Centro'),
 (2, 'Maria Oliveira', '2222222222', 'Av. dos Bandeirantes, 456', 'Rio de Janeiro', 'Copacabana'),
 (3, 'Carlos Santos', '3333333333', 'Rua dos Lírios, 789', 'Belo Horizonte', 'Savassi'),
 (4, 'Ana Souza', '4444444444', 'Av. Paulista, 567', 'São Paulo', 'Jardins'),
 (5, 'José Silva', '5555555555', 'Rua das Margaridas, 890', 'Brasília', 'Asa Sul'),
 (6, 'Paula Costa', '6666666666', 'Rua da Praia, 123', 'Florianópolis', 'Centro'),
 (7, 'Pedro Nunes', '7777777777', 'Av. Nove de Julho, 234', 'São Paulo', 'Jardim Paulista'),
 (8, 'Mariana Ferreira', '8888888888', 'Rua das Acácias, 567', 'Porto Alegre', 'Moinhos de Vento'),
 (9, 'Lucas Santos', '9999999999', 'Av. Brasil, 901', 'São Paulo', 'Vila Mariana'),
 (10, 'Gabriela Oliveira', '1010101010', 'Rua das Orquídeas, 102', 'Salvador', 'Barra');

 INSERT INTO Racas (Cod_raca, Descrição) VALUES
  (1, 'Poodle'),
  (2, 'Golden Retriever'),
  (3, 'Bulldog'),
  (4, 'Siamês'),
  (5, 'Persa'),
  (6, 'Pastor Alemão'),
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

INSERT INTO Serviços (Cod_serv, Descrição, Preço) VALUES
 (1, 'Banho e Tosa', 50.00),
 (2, 'Consulta veterinária', 120.00),
 (3, 'Vacinação', 80.00),
 (4, 'Cirurgia', 500.00),
 (5, 'Exames laboratoriais', 150.00),
 (6, 'Hospedagem', 40.00),
 (7, 'Adestramento', 80.00),
 (8, 'Corte de unhas', 20.00),
 (9, 'Limpeza de ouvidos', 30.00),
 (10, 'Atendimento domiciliar', 200.00);

INSERT INTO Itens_agendados (Cod_agd, Cod_serv, Horário) VALUES
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

--Selecionar o código do animal, o código da raça, descrição da raça, porte eo nome do dono
select Animais.Codigo, Racas.Cod_raca, Racas.Descrição, Animais.Porte, Donos.Nome
From Animais inner join  Racas
on Racas.Cod_raca = Animais.Raça
 inner join  Donos 
on Donos.Cod_Dono = Animais.Dono;

--Listar os registros e campos de todos os animais da raça Golden Retrievier;
select Animais.*,Racas.*
from Animais join Racas
on Racas.Cod_raca = Animais.Raça
where Descrição in ('Golden Retriever');

--Qual a idade do animal mais velho?
SELECT Max (Idade) AS 'Mais Velho'
from Animais;

--Listar todos os registros e campos dos serviços com preço entre 20 e 50 reais;
select Serviços.*,Itens_agendados.*,Agendamento.*
from Serviços join Itens_agendados
on Serviços.Cod_serv = Itens_agendados.Cod_serv 
join  Agendamento 
on Itens_agendados.Cod_agd = Agendamento.Cod_agd
where Preço > 20 and Preço < 50;

--Listar código do agendamento, data e nome do animal;
select Agendamento.*, Animais.Nome, Animais.Codigo
from Agendamento join Animais
on Agendamento.Animal =Animais.Codigo;

--Quantos itens tem o agendamento 01?

SELECT COUNT (*) AS 'QTDE Agendamento'
FROM Agendamento
where Cod_agd = 1;

--Listar código do agendamento, descrição do serviço e horário, de todos os serviços agendados.
select Serviços.Descrição,Itens_agendados.Horário,Agendamento.Cod_agd
from Serviços join Itens_agendados
on Serviços.Cod_serv = Itens_agendados.Cod_serv 
join  Agendamento 
on Itens_agendados.Cod_agd = Agendamento.Cod_agd;

--Listar o nome do animal, nome do dono, de todos os animais do tipo canino.
select Animais.Nome, Animais.Tipo, Donos.Nome
from Animais join Donos
on Animais.Dono = Donos.Cod_dono
where Tipo in ('Cachorro');

--Listar o nome do animal,Tipo, Porte e data Agendamento, independentemente se tenham ou não agendamentos.
select Animais.Nome,Animais.Tipo,Animais.Porte,Agendamento.Datta
from Animais join Agendamento 
on Animais.Codigo = Agendamento.Cod_agd;

--Listar todos os agendamentos da data igual à mais recente.

SELECT * FROM Agendamento WHERE Datta = (SELECT MAX(Datta) FROM Agendamento);
