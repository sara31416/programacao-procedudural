using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
       int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

       for(int linhas = 0; linhas < TAMANHO_MATRIZ; linhas++)
       {
        for(int colunas = 0; colunas < TAMANHO_MATRIZ; colunas++)
        {
            Console.WriteLine("Digite os numeros");
            matriz[linhas,colunas] = int.Parse(Console.ReadLine());

            if(linhas + colunas == 2)
            {
        matriz[linhas,colunas] = matriz[linhas,colunas] * 2;
            }
        }
       }

       for(int linhas = 0; linhas < TAMANHO_MATRIZ; linhas++)
       {
        for(int colunas = 0; colunas < TAMANHO_MATRIZ; colunas++)
        {
            Console.Write(matriz[linhas,colunas] + " |");
        }
        Console.WriteLine();
       }
    }
}