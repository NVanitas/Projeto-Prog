using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percent_Distri
{
    class Distribuidora
    {
        private double spFaturamento;
        private double rjFaturamento;
        private double mgFaturamento;
        private double esFaturamento;
        private double outrosFaturamento;

        public double SpFaturamento
        {
            get { return spFaturamento; }
            set { spFaturamento = value; }
        }

        public double RjFaturamento
        {
            get { return rjFaturamento; }
            set { rjFaturamento = value; }
        }

        public double MgFaturamento
        {
            get { return mgFaturamento; }
            set { mgFaturamento = value; }
        }

        public double EsFaturamento
        {
            get { return esFaturamento; }
            set { esFaturamento = value; }
        }

        public double OutrosFaturamento
        {
            get { return outrosFaturamento; }
            set { outrosFaturamento = value; }
        }

        public double ValorTotalMensal
        {
            get
            {
                return spFaturamento + rjFaturamento + mgFaturamento + esFaturamento + outrosFaturamento;
            }
        }

        public double PercentualSP
        {
            get { return (spFaturamento / ValorTotalMensal) * 100; }
        }

        public double PercentualRJ
        {
            get { return (rjFaturamento / ValorTotalMensal) * 100; }
        }

        public double PercentualMG
        {
            get { return (mgFaturamento / ValorTotalMensal) * 100; }
        }

        public double PercentualES
        {
            get { return (esFaturamento / ValorTotalMensal) * 100; }
        }

        public double PercentualOutros
        {
            get { return (outrosFaturamento / ValorTotalMensal) * 100; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Distribuidora distribuidora = new Distribuidora();

            distribuidora.SpFaturamento = 67836.43;
            distribuidora.RjFaturamento = 36678.66;
            distribuidora.MgFaturamento = 29229.88;
            distribuidora.EsFaturamento = 27165.48;
            distribuidora.OutrosFaturamento = 19849.53;

            Console.WriteLine($"Valor total mensal: {distribuidora.ValorTotalMensal:C}");
            Console.WriteLine($"Percentual de SP: {distribuidora.PercentualSP:F2}%");
            Console.WriteLine($"Percentual de RJ: {distribuidora.PercentualRJ:F2}%");
            Console.WriteLine($"Percentual de MG: {distribuidora.PercentualMG:F2}%");
            Console.WriteLine($"Percentual de ES: {distribuidora.PercentualES:F2}%");
            Console.WriteLine($"Percentual de Outros: {distribuidora.PercentualOutros:F2}%");
        }
    }
}