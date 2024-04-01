using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] nomes = new string[10];
        for (int contador = 0; contador < nomes.Length; contador++)
        {
            Console.WriteLine("Digite um nome");
            nomes[contador] = Console.ReadLine();

        }

        for (int contador = nomes.Length - 1; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(nomes[contador]);
            }
        }
    }
}