using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosporReferencia
{
    internal class Program
    {
        //Com Referencia

        public static void AlterarRef(ref int numero)
        {
            numero = numero + 500;
        }

        public static void AlterarOut(int numero)
        {
            numero = 0;
            numero = numero + 50;
        }

        public static void Main(string[] args)
        {
            int x = 5;
            AlterarRef(ref x);
            Console.WriteLine(x);

            int y = 8;
            AlterarOut(y);
            Console.WriteLine(y);
        }
        /*
         * Sem referencia o resultado sera 5 e 8!
        public static void AlterarRef(int numero)
        {
            numero = numero + 500;
        }

        public static void AleterarOut(int numero)
        {
            numero = numero + 50;
        }
        public static void Main(string[] args)
        {
            int x = 5;
            AlterarRef(x);
            Console.WriteLine(x);

            int y = 8;
            AleterarOut(y);
            Console.WriteLine(y);
        }
        */
    }
}
