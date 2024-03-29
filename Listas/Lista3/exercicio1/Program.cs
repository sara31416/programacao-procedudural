using System;

class Program
{
    public static void Main(string[] args)
    {
        const int QUANTIDADE_DE_HABITANTE = 20;
        double somatorioSalario = 0;
        int somatorioQuantidadeDeFilhos = 0;
        double maiorSalario = 0;
        int quantidadeDeFilhos = 0;

        for (int contador = 1; contador <= QUANTIDADE_DE_HABITANTE; contador++)
        {
            Console.WriteLine("Digite o seu salario");
            double salario = double.Parse(Console.ReadLine());
            somatorioSalario += salario;

            Console.WriteLine("Digite a quantidade de filhos que você tem");
            quantidadeDeFilhos = int.Parse(Console.ReadLine());
            somatorioQuantidadeDeFilhos += quantidadeDeFilhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }

        int mediaDeFilhos = somatorioQuantidadeDeFilhos / QUANTIDADE_DE_HABITANTE;

        double mediaSalarial = somatorioSalario / QUANTIDADE_DE_HABITANTE;


        Console.WriteLine("Media salarial = " + Math.Round(mediaSalarial, 2) + " Reais");
        Console.WriteLine("maior salario = " + maiorSalario + " Reais");
        Console.WriteLine("Media do numero de filhos por habitante = " + mediaDeFilhos);


    }
}