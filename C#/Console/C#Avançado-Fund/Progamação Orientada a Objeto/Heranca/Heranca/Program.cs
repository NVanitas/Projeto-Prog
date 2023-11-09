using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Professor
    {
        //abstração: consiste em esconder os detalhes de algo, no caso, os detalhes desnecessários.
        protected readonly float Salariomaximo;
        float salarioatual;

        public Professor(float salariomaximo)
        {
            Salariomaximo = salariomaximo;
        }
        protected float ModificarSalario(float Modf)
        {
            float novosalario = salarioatual + Modf;

            if (novosalario < 0)
            {
                salarioatual = 0;
            }
            else if (novosalario > Salariomaximo)
            {
                salarioatual = Salariomaximo;
            }
            else
            {
                salarioatual = novosalario;
            }

            return salarioatual;
        }

        public float AumentaSalario()
        {
            return ModificarSalario(+500);
        }

        public float DiminuirSalario()
        {
            return ModificarSalario(-500);
        }

        //Herança: A super classe professor passa os atributos para prof 
        public class Prof : Professor
        {
            public Prof() : base(1400)
            {

            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Professor 1:  ");
            Prof prof1 = new Prof();
            Console.WriteLine(prof1.AumentaSalario());
            Console.WriteLine(prof1.AumentaSalario());


        }
    }
}
