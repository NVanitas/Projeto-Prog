using System;

internal class Program
{
    static int PesquisaBinaria(int[] lista, int item)
    {
        int baixo = 0;
        int alto = lista.Length - 1;
        int chute, meio;

        while (baixo <= alto)
        {
            meio = (baixo + alto) / 2;
            chute = lista[meio];

            if (chute == item)
            {
                return meio;
            }
            if (chute > item)
            {
                alto = meio - 1;
            }
            else
            {
                baixo = meio + 1;
            }
        }

        // Se o item não for encontrado, retornamos -1 (ou outro valor que faça sentido no contexto)
        return -1;
    }

    static void Main(string[] args)
    {
        // Exemplo de uso
        int[] minhaLista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int itemParaProcurar = 5;

        int resultado = PesquisaBinaria(minhaLista, itemParaProcurar);

        if (resultado != -1)
        {
            Console.WriteLine($"O item {itemParaProcurar} foi encontrado na posição {resultado}.");
        }
        else
        {
            Console.WriteLine($"O item {itemParaProcurar} não foi encontrado na lista.");
        }
    }
}
