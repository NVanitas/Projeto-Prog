using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataeSealed
{
    internal class Program
    {
        public abstract class Telefone
        {
            public abstract string Tipo();
        }

        public class Xiaomi : Telefone
        {
            public override string Tipo()
            {
                return "Note 8 pro";
            }
        }



        /*é utilizada quando desejamos que seja proibido haver herança
         sealed class Escola
        {

        }
         */
        static void Main(string[] args)
        {
            Xiaomi xiaomi = new Xiaomi();

            Console.WriteLine(xiaomi.Tipo());
        }
    }
}
