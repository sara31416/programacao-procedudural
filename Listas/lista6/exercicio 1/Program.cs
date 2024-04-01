using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    public static void Main(string[] args)
    {
        const int QUANTIDADE_NOMES = 10;
        string[] nomes = new string[QUANTIDADE_NOMES];

        for (int contador = 0; contador <= 9; contador++)
        {
            Console.WriteLine("Digite um nome");
            nomes[contador] = Console.ReadLine();
        }

        Console.WriteLine("Digite o nome que deseja procurar");
        string nomeParaBuscar = Console.ReadLine();

        bool nomeProcurado = false;
        for (int contador = 0; contador < 9; contador++)
        {
            if (nomes[contador] == nomeParaBuscar)
            {
                nomeProcurado = true;
            }
        }
        if (nomeProcurado)
            {
                Console.WriteLine("ACHEI");
            }
            
        if(nomeProcurado == false)
                {
                   Console.WriteLine("NÃO ACHEI"); 
                }
    }
}