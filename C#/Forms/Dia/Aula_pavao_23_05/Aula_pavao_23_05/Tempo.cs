using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_pavao_23_05
{
    class Tempo
    {
        //variaveis e atributos
        private int mes,dia,hora, minuto, segundo;

        //propriedades

        //metodo construtor
        public Tempo()
        {
            mes = 0;
            dia = 0;
            hora = 0;
            minuto = 0;
            segundo = 0;

        }
        public Tempo(int xmes,int xdia,int xhora, int xminuto, int xsegundo)
        {
            mes = xmes;
            dia = xdia;
            hora = xhora;
            minuto = xminuto;
            segundo = xsegundo;

        }

        public string ImprimirTempo()
        {
            string xtempo,smes,sdia,shora, sminuto, ssegundo;

            smes = DoisDigitos(mes);
            sdia = DoisDigitos(dia);
            shora = DoisDigitos(hora);
            sminuto = DoisDigitos(minuto);
            ssegundo = DoisDigitos(segundo);

            xtempo = smes + "." + sdia + "." + shora + ":" + sminuto + ":" + ssegundo;

            return xtempo;
        }

        private string DoisDigitos(int num)
        {
            string snum = num.ToString();
            if(num<10)
            {
                snum = "0" + num;
            }
            return snum;
        }

        public void AdcDia(int xdia)
        {
            int soma, res, resto;

            soma = dia + xdia;
            res = soma / 30;
            resto = soma % 30;

            dia = resto;
            mes = mes + res;
        }
        public void AdcHora(int xhora)
        {
            int soma, res, resto;

            soma = hora + xhora;
            res = soma / 24;
            resto = soma % 24;

            hora = resto;
            AdcDia(res);
        }

        public void AdcMin(int xmin)
        {
            int soma, res, resto;

            soma = minuto + xmin;
            res = soma / 60;
            resto = soma % 60;

            minuto = resto;
            AdcHora(res);
        }

         public void AdcSeg(int xseg)
        {
            int soma, res, resto;

            soma = segundo + xseg;
            res = soma / 60;
            resto = soma % 60;

            segundo = resto;
            AdcMin(res);
        }
    }
}
