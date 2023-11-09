using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;

            Console.Write("Digite um Numero:");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}:",num);
            for (i = 10; i>= 0;i--)
            {
                Console.WriteLine(num + "x" + i + "=" + i * num);
            }

            Console.Read();
        }
    }
}
