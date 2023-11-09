using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Static
    {
        class Statico
        {
            public static int somar(int x, int y)
            {
                return x + y;
            }

            public static int multiplicar(int x, int y)
            {
                return x * y;
            }

            static void Main(string[] args)
            {
                var result = Statico.somar(3, 3);
                Console.WriteLine("A soma é igual a: {0}", result);

                Console.WriteLine(Statico.multiplicar(3, 4));
            }
            /*
             *Caso não tenha static é necessário a criação de outra instância
             public static int somar(int x, int y)
            {
                return x + y;
            }

            public int multiplicar(int x, int y)
            {
                return x * y;
            }

            static void Main(string[] args)
            {
                var result = Statico.somar(3, 3);
                Console.WriteLine("A soma é igual a: {0}", result);

                Statico calc = new Statico();
                Console.WriteLine(calc.multiplicar(3, 4));
             */
        }
    }
}
