using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev_Class_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];
            int maiorIdade = 0;
            int menorIdade = int.MaxValue;
            Pessoa pessoaMaiorIdade = null;
            Pessoa pessoaMenorIdade = null;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite sua Idade:");
                int idade = int.Parse(Console.ReadLine());

                pessoas[i] = new Pessoa(nome, idade);
                Console.WriteLine();

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                    pessoaMaiorIdade = pessoas[i];
                }

                if (idade < menorIdade)
                {
                    menorIdade = idade;
                    pessoaMenorIdade = pessoas[i];
                }
                Console.Clear();
            }
        
            Console.WriteLine("Dados Pessoais");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.GetNome());
                Console.WriteLine("Idade: " + pessoa.GetIdade());
                Console.WriteLine();
            }

            Console.WriteLine("Pessoa com a maior idade: " + pessoaMaiorIdade.GetNome());
            Console.WriteLine("Maior idade é: " + maiorIdade);
            Console.WriteLine();
            Console.WriteLine("Pessoa com a menor idade: " + pessoaMenorIdade.GetNome());
            Console.WriteLine("Menor idade é: " + menorIdade);
        }
    }

    public class Pessoa
    {
        private string Nome;
        private int Idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Pessoa() { }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }
    }
}