using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5atv
{
    internal class Altura
       
    {
        public double Calcular(double velocidade,double tempo)
        {
            double h, gravidade = 9.8;
            h = velocidade*tempo*((gravidade*(tempo*tempo))/2);

            return h;
        }
        public double Newton(double massa,double vini, double vfinal,double temp)
        {
            double forca;
            forca = massa * ((vfinal - vini) / temp);

            return forca;
        }

        public double Coroa(double D,double d)
        {
            double s;

            s = Math.PI / 4 * ((D * D) - (d * d));

            return s;
        }

        public double Calota(double R,double h)
        {
            double v;

            v = Math.Pow(Math.PI * h, 2) * (R - h / 3);


            return v;
        }
    }
}
