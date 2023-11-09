using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        class Calculadora
        {
            public static double Max(double x, double y)
            {
                if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }    
            }

            public static double Soma(double x, double y)
            {
                return x + y;

            }

        }
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation operacao = Calculadora.Soma;
            Console.WriteLine(operacao(a,b));
        }
    }
}
