using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Fund_1_Brad
{
    internal class Program
    {
        public static void Main()
        {
            Soma();
        }

        public static void Soma()
        {
            bool opcao = true;

            Console.WriteLine("Digite o valor inicial");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial");
                float.TryParse(Console.ReadLine(), out float n1);

                inicial = inicial + n1;
                Console.WriteLine("A soma até o momento é: " + inicial);
                Console.WriteLine("Deseja Continuar 1 - Sim 2 - Não");
                int.TryParse(Console.ReadLine(), out int saida);

                switch (saida)
                {
                    case 1: Console.WriteLine("Saindo do Prog.");
                        break;
                    case 2: Console.WriteLine("Continua a Soma.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando para soma.");
                        break;
                }
            }

        }
        public static void LeituraNotas()
        {
            float media = 0;
            int n = 3;

            Console.WriteLine("Calculo de Média!!!");
            Console.WriteLine("Digite a Primeira nota: ");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Digite a Segunda nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Digite a Terceira nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);

            media = (nota1 + nota2 + nota3) / n;

            Console.WriteLine("A média do aluno é: "+ media);
            if(media < 5)
            {
                Console.WriteLine("Aluno Reprovou");
            }
            else if(media > 5 && media < 7)
            {
                Console.WriteLine("Pode Recuperar");
            }
            else
            {
                Console.WriteLine("Aluno Aprovado!");
            }
        }
        public static void Write()
        {
            string age, name;
            int agenum;

            Console.WriteLine("Digite o seu nome: ");
            name = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            age = Console.ReadLine();

            agenum = int.Parse(age);

            Console.WriteLine("Você se chama " + name + " e você tem " + agenum + " anos");
            
        }
        public static void For() 
        {
            int n;
            n = 0;
            for (n = 1; n <= 10; n++)
            {
                Console.WriteLine(n);
            }
        }

        public static void While() 
        { 
            var n1 = -1;
            while(n1 <= 15)
            {
                Console.WriteLine(n1);
                n1++;
            }
        }
        public static void FuncaoSwitch() 
        {
            Console.WriteLine("Qual a nota você da para o prato- 0,5 ou 10");
            int.TryParse(Console.ReadLine(), out int nota);

                  switch(nota)
                {
                 case 0:
                 Console.WriteLine("Comida muito ruim!.");
                 break;
                case 5:
                  Console.WriteLine("Comida Razoavel");
                  break;
                case 10:
                  Console.WriteLine("Comida muito Boa!");
                  break;
                default:
                  Console.WriteLine("Nota Inexistente");
                  break;
                }

        }
        
        
            public static void ifelse() 
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if(n1 < n2)
            {
                Console.WriteLine("Condição 1 é funcional!!");
                Console.WriteLine("Resultado da soma é:" + (n1 + n2));
                Console.WriteLine("Ou :{0}", n1 + n2);
            }
            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }
            else
            {
                Console.WriteLine("Condição 2 não é funcional!!");
            }
        }
        public static void OperadoresUnarios()
        {
            var x = false;
            var n1 = 6;
            var n2 = 5; 
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!x);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);

            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n1-- == ++n2); 
        }
        public static void OperadoresLogicos()
        {
            // && = E,|| = OU ,! NÃO/diferente de 
            var atividade1 = true;
            var atividade2 = false;  


            var todas = atividade1 && atividade2;

            Console.WriteLine("Fez todas as Atividades ?", todas);
            
            var umaApenas = atividade1 || atividade2;

            Console.WriteLine("Fez pelo menos uma ?" + umaApenas);

            Console.WriteLine("Não fez nenhuma ?" + !umaApenas);
        }
        public static void OperadoresRelacionais()
        {
            string n;
            int nota;

            Console.WriteLine("Digite a nota: ");
            n = Console.ReadLine();

            nota = int.Parse(n);

            if (nota >=7)
            {
                Console.WriteLine("Na média");
            }

            if (nota <=6 && nota >4)
            {
                Console.WriteLine("Recuperação");
            }

            if (nota <= 4)
            {
                Console.WriteLine("Reprovado");
            }
        }
        public static void OperadoresAri()
        {
            int x;
            double soma,sub,potencia,resto;
            x = 10;

            sub = x - 5;
            soma = x + 10;
            potencia = Math.Pow(x, 2);
            resto = x % 2;

            Console.WriteLine("Subtração de 10: " + sub);
            Console.WriteLine("Soma de 10: " + soma);
            Console.WriteLine("Potencia de 10: " + potencia);
            Console.WriteLine("Resto de 10: " + resto);
            
        }
        public static void Inferencia()
        {
            var idade = 25;
            var salario = 1285.60;

            Console.WriteLine("Idade {0},Salario {1}", idade, salario);
        }
        public static void Formatacao()
        {
            double x = 20.232;
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));
        }
        public static void Conversao()
        {
            Console.WriteLine("Digite qual numero é sua casa: ");
            string numHouse = Console.ReadLine();
            int num = int.Parse(numHouse);
            Console.WriteLine("O numero da casa é {0}", num);

            num = Convert.ToInt32(numHouse);
            Console.WriteLine("Convertido: "+num);
            /*Implicita
            int x = 4;
            double x = y;
            Console.WriteLine(y);
            */

            /*Explicita
             doubçe nota =8.6;
            int notaconvertida - (int)nota; 
            Console.WriteLine(notaconvertida);
             */
        }

        public static void Quadrado()
        {
            int x = 4;
            double y = 3.3;
     
            double area = x * y;
            Console.WriteLine("A area do quadrado é :" + area);
        }

        public static void Coment()
        {
            //Comentario de uma linha

            /*
                Comentario de varias linhas
            */
            Console.WriteLine("Sempre especificar o programa!");
        }

    }
}
