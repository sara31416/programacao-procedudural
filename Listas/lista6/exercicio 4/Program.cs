using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 10;
        int[] numeros = new int[TAMANHO_MATRIZ];
        int numerosDigitados = 0;

        for (int contador = 0; contador < numeros.Length; contador++)
        {
            do
            {
                Console.WriteLine("Digite um numero");
                numerosDigitados = int.Parse(Console.ReadLine());
                numeros[contador] = numerosDigitados;

            }
            while (numerosDigitados < 10 || numerosDigitados > 50);
        }

        for(int contador = 0; contador < numeros.Length; contador++)
        {
            Console.WriteLine(numeros[contador]);
        }

    }
}