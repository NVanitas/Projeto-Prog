using System;

namespace BuscaSequencial
{
    internal class BuscaSequencial
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 3, 2, 1, 6, 4, 5, 9, 8, 7, 10 };
            int valor = 0; // Initialize valor to zero

            bool continuar = true;

            while (continuar)
            {
                int menu;
                Console.WriteLine("Menu");
                Console.WriteLine("1- Verificar se o valor foi encontrado no vetor");
                Console.WriteLine("2- Encontrar o valor com o índice");
                Console.WriteLine("3- Sair do programa");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        valor = LerValor();

                        bool encontrado = false;
                        for (int i = 0; i < vetor.Length; i++)
                        {
                            if (vetor[i] == valor)
                            {
                                Console.WriteLine("Valor encontrado");
                                Console.WriteLine("Ele está na posição " + i + " do Vetor!");
                                encontrado = true;
                                break; // Exit the loop when the value is found
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Valor não encontrado no vetor.");
                        }


                        break;
                    case 2:
                        Console.Clear();
                        valor = LerValor();

                        if (valor >= 1 && valor <= 10)
                        {
                            int index = Array.IndexOf(vetor, valor);
                            if (index >= 0)
                            {
                                Console.WriteLine("No índice " + index + " o valor encontrado é: " + valor);
                            }
                            else
                            {
                                Console.WriteLine("Valor não encontrado no vetor.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido. Digite um valor de 1 a 10.");
                        }
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public static int LerValor()
        {
            Console.WriteLine("Digite um valor de 1 a 10: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
