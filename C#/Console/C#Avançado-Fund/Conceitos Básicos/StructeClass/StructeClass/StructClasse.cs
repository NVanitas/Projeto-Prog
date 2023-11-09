using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructeClass
{
    internal class StructClasse
    {
        public struct PontoS
        {
            public int x; 
            public int y;
        }

        public class PontoC
        {
            public int x,y;
        }
        public static void Main(string[] args)
        {
            PontoS ponto = new PontoS { x = 5, y = 3 };
            PontoS ponto2 = ponto;//Copiar atravez do valor;
            ponto.x = 3;

            Console.WriteLine("Ponto: {0}", ponto.x);
            Console.WriteLine("Ponto 2: {0}", ponto2.x);

            PontoC ponto3 = new PontoC{ x = 6, y = 9 };
            PontoC ponto4 = ponto3;
            ponto3.x = 3;

            Console.WriteLine("Ponto 3 = {0}, Ponto 4 = {1}", ponto3.x, ponto4.x);

        }
    }
}
