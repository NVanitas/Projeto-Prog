using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_Variaveis
{
    internal class Program
    {
        public static void Despedida(params string[] alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
            }
        }
        static void Main(string[] args)
        {
            Despedida("Joao", "Nicolas", "Antonio");
        }
    }
}
