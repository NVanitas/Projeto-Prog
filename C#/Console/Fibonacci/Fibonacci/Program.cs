using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n; // O número que queremos verificar na sequência de Fibonacci
            Console.Write("Informe um número para verificar na sequência de Fibonacci: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<int> fibonaccis = new List<int>();
            fibonaccis.Add(0);
            fibonaccis.Add(1);

            // Calcular a sequência de Fibonacci até que o último número seja menor ou igual a 'n'
            while (fibonaccis[fibonaccis.Count - 1] <= n)
            {
                int proxnum = fibonaccis[fibonaccis.Count - 1] + fibonaccis[fibonaccis.Count - 2];
                fibonaccis.Add(proxnum);
            }

            // Verificar se o número está na sequência
            bool numencontrado = false;
            foreach (int num in fibonaccis)
            {
                if (num == n)
                {
                    numencontrado = true;
                    break;
                }
            }

            if (numencontrado)
            {
                Console.WriteLine($"{n} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{n} NÃO pertence à sequência de Fibonacci.");
            }
        }
    }
}
