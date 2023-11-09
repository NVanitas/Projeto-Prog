using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_M4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel
            double peso, altura, imc;
            string resposta = "s";

            while (resposta == "s")
            {
                //\n da espaço de uma linha ou writeline
                Console.WriteLine("Calcular  IMC!");

                Console.Write("Digite o Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                imc = peso / (altura * altura);

                Console.WriteLine("O IMC é {0}", imc);


                Console.WriteLine("Para o Peso de {0} e a altura de {1} o imc é {2}", peso, altura, imc);

                Console.Write("\n\n");

                if(imc <= 18.5)
                {
                    Console.Write("Abaixo do Peso");
                }
                else if(imc > 18.5 && imc <= 24.5 )
                {
                    Console.Write("Peso Ideal");

                }
                else if(imc > 24.5 && imc <= 30)
                {
                    Console.Write("Pouco Acima do Peso");
                }
                else
                {
                    Console.Write("Acima do Peso");
                }

                Console.WriteLine("\n\n");

                Console.Write("Deseja Continuar?: ");
                resposta = Console.ReadLine();

                Console.Clear();

                if (resposta != "s")
                {
                    Console.Write("Finalizando...");
                }


            }//fim do while
                Console.Read();
            
        }
    }
}
