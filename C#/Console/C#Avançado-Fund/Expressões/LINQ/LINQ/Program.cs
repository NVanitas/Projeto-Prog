using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class lINQ
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 4, 5, 7, 8, 9, 10, 11, 12 };

            var operacao = numeros.Where(x => x % 2 == 0);//par

            var operacao2 = numeros.Where(x => x % 2 == 1);//impar

            Console.WriteLine(" Pares ");

            foreach (int x in operacao )
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine(" Imapares    ");
            foreach (int x in operacao2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
