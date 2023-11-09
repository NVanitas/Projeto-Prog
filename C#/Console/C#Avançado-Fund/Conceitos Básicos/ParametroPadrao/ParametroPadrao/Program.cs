using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametroPadrao
{
    internal class Program
    {
        public static double Multiplicar(double x = 3.4, double y = 3) 
        { 
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicar());
        }

    }
}
