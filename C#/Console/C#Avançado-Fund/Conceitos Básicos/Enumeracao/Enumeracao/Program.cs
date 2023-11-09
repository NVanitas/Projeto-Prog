using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao
{
    internal class Program
    {
        class Enum
        {
            public enum Genero { Filme, Serie, Documentario };

            public class Filme
            {
                public string Nome;
                public Genero TipoVideo;
            }
            static void Main(string[] args)
            {
                int cod0 = (int)Genero.Filme;
                int cod1 = (int)Genero.Serie;
                int cod2 = (int)Genero.Documentario;
                Console.WriteLine(cod0);
                Console.WriteLine(cod1);
                Console.WriteLine(cod2);
                //se for 0 = Filme,se for 2 = Serie e 3 = Documentario
            }
        }
    }
}
