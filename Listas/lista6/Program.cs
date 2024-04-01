using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] nomes = new string[10];

        for (int posicao = 0; posicao <= 9; posicao++)
        {
            Console.WriteLine("Digite um nome");
            nomes[posicao] = Console.ReadLine();
        }

        Console.WriteLine("Digite o nome que deseja consultar");
        string outroNome = Console.ReadLine();

        string resultado = "não achei";
        for (int contador = 0; contador <= 9; contador++)
        {
            if (nomes[contador] == outroNome)
            {
                Console.WriteLine("Achei");

            }
        }
        Console.WriteLine(resultado);
    }

}