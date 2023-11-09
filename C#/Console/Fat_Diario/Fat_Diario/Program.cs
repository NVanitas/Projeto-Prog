using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_Diario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Suponha que você já tenha carregado o vetor com os valores de faturamento.
            double[] faturamentoDiario = { 100.0, 200.0, 150.0, 0.0, 300.0, 250.0, 400.0, 0.0, 350.0, 200.0, 300.0, 250.0, 200.0, 0.0, 400.0, 300.0, 250.0, 200.0, 350.0, 300.0, 150.0, 200.0, 0.0, 250.0, 200.0, 300.0, 400.0, 0.0, 350.0, 300.0, 250.0, 200.0, 150.0, 200.0, 0.0, 400.0, 350.0, 300.0, 250.0, 200.0, 0.0, 200.0, 300.0, 400.0, 350.0, 250.0, 200.0, 0.0 };

            double menorFaturamento = double.MaxValue;
            double maiorFaturamento = double.MinValue;
            double somaFaturamento = 0;
            int diasComFaturamento = 0;

            foreach (double faturamento in faturamentoDiario)
            {
                if (faturamento > 0)
                {
                    if (faturamento < menorFaturamento)
                    {
                        menorFaturamento = faturamento;
                    }
                    if (faturamento > maiorFaturamento)
                    {
                        maiorFaturamento = faturamento;
                    }
                    somaFaturamento += faturamento;
                    diasComFaturamento++;
                }
            }

            double mediaAnual = somaFaturamento / diasComFaturamento;

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média anual: {diasComFaturamento}");
        }
    }
}
