using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_05_classe
{
    class Geometria
    {
        public int Quadrado(int lado)
        {
            int area;
            area = lado * lado;

            return area;
        }

        public int Retangulo(int bas, int alt)
        {
            return bas * alt;
        }
        public double Cilindro(double raio, double alt)
        {
            double volume;

            volume = Math.PI * Math.Pow(raio,2) * alt;
            return volume;
        }
        public int Paralelepipedo(int bas, int alt,int comp)
        {
            return bas*alt*comp;
        }

        public int Divisao(int n1, int n2)
        {
            return Math.Max(n1, n2) / Math.Min(n1, n2); 
        }

        public int Fatorial(int num)
        {
            int fat=1, i;

            for(i=1 ;i<=num; i++)
            {
                fat = fat*i;
            }
            return fat;
        }
        public int PA(int inicial,int prog,int termo)
        {
            int i,respa=0;

            for(i=1; i<=termo;i++)
            {
                inicial = inicial + prog;
                respa = inicial;
            }
            return respa;
        }
        public double PG(int inicial, int prog, int termo)
        {
            double respa;
           
            respa = inicial * Math.Pow(prog, termo - 1);

            return respa;
        }

    }

}
