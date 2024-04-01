using System;
class Program
{
    static void Main(string[] args)
    {
        int numeroExecutar = 0;
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        System.Console.WriteLine("[1]-Imprimir todos os elementos da matriz");
        System.Console.WriteLine("[2]-Somar todos os elementos e exibir o resultado");
        System.Console.WriteLine("[3]-Somar todos os elementos da terceira linha (linha de índice 2) e exibir o resultado");
        System.Console.WriteLine("[4]-Somar os elementos da diagonal principal");
        System.Console.WriteLine("[5]-Somar todos os elementos de índice par da segunda linha");
        int executarTarefa = Convert.ToInt32(Console.ReadLine());

        int soma = 0;
        if (executarTarefa == 1)
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("| {0} ", matriz[i, j]);
                }
                Console.Write("|\n");
            }

        }
        else if (executarTarefa == 2)
        {

            soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            System.Console.WriteLine("Soma: {0}", soma);

        }
        else if (executarTarefa == 3)
        {
            soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            System.Console.WriteLine("Soma da terceira linha: {0}", soma);
        }
        else if (executarTarefa == 4)
        {
            soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            System.Console.WriteLine("Soma da diagonal principal: {0}", soma);

        }
        else if (executarTarefa == 5)
        {

            soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 2)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            System.Console.WriteLine("Soma da segunda linha: {0}", soma);

        }
    }
}