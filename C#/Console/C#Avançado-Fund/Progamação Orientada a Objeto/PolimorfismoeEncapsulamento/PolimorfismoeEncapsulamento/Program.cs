using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoeEncapsulamento
{
    internal class Mensagem
    {
        private string Texto;

        public void Exibir()
        {
            Console.WriteLine(this.Texto);
        }

        public String getTexto()
        {
            return this.Texto;
        }

        public void setTexto(String txt)
        {
            this.Texto = txt;
        }
        static void Main(string[] args)
        {
            Mensagem txt1, txt2;

            txt1 = new Mensagem();
            txt1.setTexto("Curso Avançado de C#");
            txt1.Exibir();

            txt2 = new Mensagem();
            txt2.setTexto("Texto 2");
            txt2.Exibir();
        }
    }
}
