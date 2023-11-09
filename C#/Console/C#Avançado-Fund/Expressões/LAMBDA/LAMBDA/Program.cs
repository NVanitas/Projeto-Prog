using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action apresentaConsole = () =>
            {
                Console.WriteLine("Funções e Métodos");
            };

            apresentaConsole();

            Func<int> sorteio = () =>
            {
                Random random = new Random();
                return random.Next(1, 101);

            };

            Console.WriteLine(sorteio());


        }
    }
}
