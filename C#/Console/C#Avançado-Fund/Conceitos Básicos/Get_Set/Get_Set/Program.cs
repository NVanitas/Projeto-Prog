using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Get_Set
{

    internal class Program
    {
        public class Carro
        {
            private string Marca;
            private string Nome;
            private double Potencia;


            public Carro(string marca, string nome, double potencia)
            {
                Marca = marca;
                Nome = nome;
                Potencia = potencia;
            }

            public Carro()
            {

            }

            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetNome()
            {
                return Nome;
            }

            public void SetNome(string nome)
            {
                Nome = nome;
            }

            public double GetPotencia()
            {
                return Potencia;
            }
            
            public void SetPotencia(Double potencia)
            {
                Potencia = potencia;
            }

            class construtor
            {
                static void Main(string[] args)
                {
                    var carro1 = new Carro();

                    carro1.Nome = "Ka";
                    carro1.Marca = "Ford";
                    carro1.Potencia = 1.6;

                    Console.WriteLine($"{carro1.Nome} {carro1.Marca} {carro1.Potencia}");
                }
            }
           
        }

    }
}
