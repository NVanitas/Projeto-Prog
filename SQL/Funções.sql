/*
Funções De Sistema

Matemática

Retorna o Numero Sem o Sinal
*/
Select Abs(5);
Select Abs(-5);
Select Abs(+5);
/*
Retorna O Sinal
-1 = Negativo e 1 = Positivo
*/
Select Sign(5);
Select Sign(-5);
Select Sign(0);

/*
Trigonometria
*/
Select Asin(0.5);
Select Acos(0.5);
Select Atan(0.5);
Select Degrees(77);
Select Radians(4411);

/*
Retorna o Valor
*/
Select Pi();

Select(3.14 * square(5) * 20);
Select(Pi() * square(5) * 20);

--Calcular o Valore de um Tanque Cilindrico Cheio de Gas com 5m de r e 20m h,com o Preço da Gasolina em 5.4
Select (Pi() *Square(5) * 20 * 1000 * 5.4);

/*
Raiz Quadrada
*/
Select Sqrt(400);
Select Sqrt(121);
Select Sqrt(25);

/*
Quadrado 
*/
Select Square(8);
Select Square(3);
Select Square(4);
/*
Retorna um N Elevado a outro
*/
Select Power(2,10);
Select Power(3,4);
Select Power(5,3);

Select ProductName,UnitPrice,Power(UnitPrice,2) As 'Preço ao Quadrado' From Products;

/*
Retorna um Valor Aleatorio
*/
Select Rand();
Select Rand()*6+1;
/*
Floor Arredonda para Baixo
*/
Select Floor(Rand()*6+1);
Select Floor(Pi());
/*
Ceiling Arredonda para Cima
*/
Select Ceiling(Rand()*6+1);
Select Ceiling(Pi());

/*
Round Arredonda para o mais prox
*/
Select Round(Pi(),4);
Select Round(3.645,2);

Select ProductName, UnitPrice, UnitPrice *1.0367 As 'Aumenta 3.67%', Round(UnitPrice *1.0367,2) As 'Aumenta 3.67% Arredondado' From Products;

--Funções de String

--Retorna quantidade de caracteres
Select Len('Nicolas Santos');

--Retorna o código do caracter na tabela ascii
Select Ascii('a');
Select Ascii('A');
Select Ascii('3');

--Retorna o caracter da tabela ascii de um numero
Select Char(97);
Select Char(65);
Select Char(51);

--Remove espaços em branco da esquerda
Select Ltrim(' Nicolas ')+'Santos';

--Remove espaços em brando da direita
Select Rtrim(' Nicolas ')+'Santos';

Select Ltrim(Rtrim(' Nicolas '))+'Santos';

--Transforma texto em minuscula 
Select Lower('Nicolas da Silva Santos');

--Transforma texto em maiuscula 
Select Upper('Nicolas da Silva Santos');

--Acrescenta espaço
Select 'Nicolas'+Space(15)+'Santos';

--Replica o texto a quantidade de vezes
Select Replicate('Nicolas',8);

Select 'Nicolas é Lind'+Replicate('o',30);

--Recorta da esquerda a quant de caracteres indicadas
Select Left('Computador',3);

--Recorta da direita a quant de caracteres indicadas
Select Right('Computador',3);

Select Right(Left('Computador',3),3)

--Recorta uma frase determinado
--O ponto inicial do corte e a quant a ser cortada de um texto
Select SubString('Computador',6,4);
Select SubString('Vulcanologia',4,4);

--Substitui um texto por outro
Select Replace('Banana','n','t');
Select Replace('O Gabriel é bonito','bonito','lind')+Replicate('o',30);

--Retorna o grau de diferença entre as palavras
Select Difference('Abacate','Abacate');
Select Difference('Abacate','Abaca');
Select Difference('Abacate','Abacaxi');
Select Difference('Abacate','Astolfo');

--Inverte o texto
Select Reverse('Nicolas Santos');
Select Reverse('ATCUBANOS');

--Funçao de Data e Hora

--Retorna a data e hora do sistema
Select GetDate();
Select SysDateTime();
Select SysDateTimeOffSet();

Select SysUtcDateTime();

Select Day(GetDate());
Select Month(GetDate());
Select Year(GetDate());
Select Month('10/04/2004');

/*
Intervalos:

dd dia
mm mês
yy ano
hh hora
mm minuto
ss segundo 
mi milisegundos
ns nanosegundos
ww numero da semana
dw dia da semana
dy dia do ano
qq trimestre
*/

Select DatePart(dd,GetDate());
Select DatePart(ww,GetDate());
Select DatePart(qq,GetDate());
Select 365-DatePart(dy,GetDate());

Select DateName(dw,GetDate());
Select DateName(mm,GetDate());

Select DateName(dw,'10/04/2004');

--Intervalo,Quantidade,Data
Select DateAdd(dd,40,GetDate());
Select DateAdd(dd,80,GetDate());
Select DateAdd(dd,120,GetDate());

Select DateAdd(mm,9,GetDate());

Select DateAdd(yy,5,GetDate());

Select DateAdd(ss,1000000,GetDate());

Select DateDiff(s,'10/04/2004',GetDate());

--Altera o padrão de data  do sistema para dia mes e ano
Set DateFormat DMY;

Select DateDiff(dd,GetDate(),'01/12/2023');

Select OrderId,CustomerId,OrderDate,ShippedDate,DateDiff(dd,OrderDate,ShippedDate) As 'Tempo De Entrega' From Orders Order By [Tempo De Entrega] Desc;

--Calcular o Prazo da entrega em dias
Select OrderId,CustomerId,OrderDate,RequiredDate,DateDiff(dd,OrderDate,RequiredDate) As 'Prazo De Entrega' From Orders Order By [Prazo De Entrega] Desc;

-------------------------------------------------------------------------------------
Select OrderId,CustomerId,ShippedDate,RequiredDate,DateDiff(dd,ShippedDate,RequiredDate) As 'Entregas' From Orders Order By [Entregas] Desc;

Select OrderId,CustomerId,ShippedDate,RequiredDate,DateDiff(dd,ShippedDate,RequiredDate) As 'Diferenca' From Orders Where DateDiff(dd,RequiredDate,ShippedDate)>=1 Order By [Diferenca] Desc;