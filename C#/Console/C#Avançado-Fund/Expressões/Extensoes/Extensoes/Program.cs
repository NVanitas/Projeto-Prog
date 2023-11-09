using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensoes
{
    public static class CalculadoraExtensao
    {
        public static double Soma (this double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtracao(this double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicacao(this double n1, double n2)
        {
            return n1 * n2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            Console.WriteLine("Soma:");
            Console.WriteLine(x.Soma(7));
            Console.WriteLine(9.2.Soma(7)); ;//9.2 == 9,2
            Console.WriteLine();

            Console.WriteLine("Subtração:");
            Console.WriteLine(x.Subtracao(7));
            Console.WriteLine(9.2.Subtracao(7));
            Console.WriteLine();

            Console.WriteLine("Multiplicação:");
            Console.WriteLine(x.Multiplicacao(7));
            Console.WriteLine(9.2.Multiplicacao(7));
            Console.WriteLine();
        }
    }
}
