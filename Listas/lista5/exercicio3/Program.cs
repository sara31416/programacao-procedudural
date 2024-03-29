using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura do retangulo");
        int valorAltura = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base do retangulo");
        int valorBase = int.Parse(Console.ReadLine());

        for (int linha = 1; linha <= valorAltura; linha++)
        {
            for (int coluna = 1; coluna <= valorBase; coluna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
