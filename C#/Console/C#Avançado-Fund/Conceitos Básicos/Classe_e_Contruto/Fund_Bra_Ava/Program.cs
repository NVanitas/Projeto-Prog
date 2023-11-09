using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund_Bra_Ava
{
    class Carro
    {
        public string Nome;
        public string Marca;
        public double Potencia;

        public Carro(string nome, string marca, double potencia)
        {
            Nome = nome;
            Marca = marca;
            Potencia = potencia;
        }
        
        public Carro() 
        { 

        }

    }
    class Construtor
    {
        static void Main(string[] args) 
        { 
            var carro=new Carro();

            carro.Nome = "Hilux";
            carro.Marca = "Toyota";
            carro.Potencia = 3.1;

            Console.WriteLine($"{carro.Nome}{carro.Marca}{carro.Potencia}");

            var carro2 = new Carro("Celta", "Chevrolet", 1.0);
            Console.WriteLine($"{carro2.Nome}{carro2.Marca}{carro2.Potencia}");
        }
    }
    internal class Program
    {
        /* Método 1     
         class Aluno
         {
             public string Nome;
             public int Idade;
             public int Serie;
         }

         public static void Main(string[] args)
         {
             Aluno aluno = new Aluno();
             aluno.Nome = "João";
             aluno.Idade = 13;
             aluno.Serie = 6;

             Console.WriteLine($"O aluno {aluno.Nome} tem {aluno.Idade} anos e estuda na {aluno.Serie} série!");
         }
         */

       
    }
}
