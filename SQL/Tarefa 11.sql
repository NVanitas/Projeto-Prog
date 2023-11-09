--Criar as tabelas e Relacionamentos.
CREATE TABLE Aluno(
RM int,
Nome varchar(300),
Curso int,
Serie int ,
Periodo varchar(300),
CONSTRAINT P8K_COD FOREIGN KEY(Curso) references Curso(Codcurso),
CONSTRAINT P1K_COD PRIMARY KEY(RM));

Select * From Aluno;

Drop Table Aluno;

CREATE TABLE Notas
(RM int,
Disciplina int,
Nota1 Numeric(10,2), 
Nota2 Numeric(10,2),
CONSTRAINT P5K_COD FOREIGN KEY(RM) references Aluno(RM),
CONSTRAINT P6K_COD FOREIGN KEY(Disciplina) references Disciplina(CodDisc),
CONSTRAINT P3K_COD PRIMARY KEY(RM));

Select * From Notas;

Drop Table Notas;

CREATE TABLE Curso
(Codcurso int,
Nome varchar(200),
CONSTRAINT P4K_COD PRIMARY KEY(Codcurso),
);

Select * From Curso;

Drop Table Curso;

CREATE TABLE Disciplina
(CodDisc int,
Nome varchar(200),
CONSTRAINT P7K_COD PRIMARY KEY(CodDisc),
);

Select * From Disciplina;

Drop Table Disciplina;

--Inserir 5 registrosem cada tabela.
INSERT INTO Aluno (RM, Nome, Curso, Serie, Periodo) 
VALUES (1, 'João', 101, 1, 'Manhã'),
(2, 'Maria', 102, 2, 'Tarde'),
(3, 'Pedro', 101, 1, 'Noite'),
(4, 'Ana', 103, 3, 'Manhã'),
(5, 'Lucas', 102, 2, 'Noite');

INSERT INTO Notas (RM, Disciplina, Nota1, Nota2) VALUES 
(1, 101, null, 7.5),
(2, 102, null, 9.0),
(3, 101, 9.5, 8.0),
(4, 103, 5.0, 7.5),
(5, 102, 9.0, 8.5);

INSERT INTO Curso (Codcurso, Nome) VALUES 
(101, 'Informatica'),
(102, 'Engenharia Civil'),
(103, 'Administração'),
(104, 'Plastico'),
(105, 'Medicina');

INSERT INTO Disciplina (CodDisc, Nome) VALUES 
(101, 'LPII'),
(102, 'Banco de Dados'),
(103, 'Direito Constitucional'),
(104, 'Cálculo Diferencial e Integral'),
(105, 'Anatomia Humana');

--Selecionar nome, período e série de todos os alunos do curso de Informática

select Aluno.*, Curso.*
From aluno left outer join curso
on Aluno.Curso = Curso.Codcurso where 
Curso.Nome IN ('Ciência da Computação');

--Selecionar Nome do aluno, curso, nome da disciplina, nota1 e nota2, de todos os alunos.
select Aluno.*, Notas.*
From aluno left outer join Notas 
on Aluno.RM= Notas.RM;

--Selecionar todas as notas do aluno  (Seu nome);
select Aluno.*, Notas.*
From aluno left outer join Notas 
on Aluno.RM= Notas.RM where 
Aluno.Nome IN ('LUCAS');

--Quantas notas (nota1) inferior a 6,0, em Banco de Dados,  temosno Cadastro de Atividade 11Considerar  o Banco Escola: Notas? 
select Aluno.*, Notas.*
From aluno left outer join Notas 
on Aluno.RM= Notas.RM where 
Notas.nota1 < 6;

--Qual a média de Notas (Nota2) na disciplina LPII? 
SELECT AVG (Notas.Nota2) AS 'Media Alunos'
From Notas inner join  aluno
on Aluno.RM= Notas.RM 
inner join Disciplina 
on Notas.Disciplina = Disciplina.CodDisc 
where Disciplina.Nome in ('Banco de Dados');

--Quantos alunos temos no curso de Informática? 
SELECT COUNT (Aluno.Curso) AS 'QTDE Alunos'
FROM aluno inner join Curso
on Aluno.Curso = Curso.Codcurso where 
Curso.nome in ('Informatica');

--Quantos alunos temos no curso de Plástico?
SELECT COUNT (Aluno.Curso) AS 'QTDE Alunos'
FROM aluno inner join Curso
on Aluno.Curso = Curso.Codcurso where 
Curso.nome in ('Plastico');

--Selecionar todos os alunos que não possuem Nota1.
select Aluno.*, Notas.*
From aluno left outer join Notas 
on Aluno.RM= Notas.RM where 
Notas.nota1 is null;

--Selecionar todos os alunos que não possuem Nota1.
select Aluno.*, Notas.*
From aluno left outer join Notas 
on Aluno.RM= Notas.RM where 
Notas.nota2 is null;

--Selecionar todos os alunos que não possuem Nota1 emMatemática.
select Aluno.*, Notas.*,Disciplina.*
From aluno inner join Notas 
on Aluno.RM= Notas.RM inner join Disciplina 
on Notas.Disciplina = Disciplina.CodDisc 
where Disciplina.Nome in ('Banco de Dados') and  Notas.Nota1 is null ;








