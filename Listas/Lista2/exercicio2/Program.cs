using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Para saber a nota média do aluno siga os passos a seguir:");

    Console.WriteLine("Digite a 1º nota do aluno:");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 2º nota do aluno:");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 3º nota do aluno:");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 4º nota do aluno:");
    double nota4 = double.Parse(Console.ReadLine());

    double nota = (nota1 + nota2 + nota3 + nota4) / 4;

    Console.WriteLine("A nota média do aluno eh: " + nota);

    if (nota >= 5.0)
    {
      Console.WriteLine("Aluno aprovado");
    }
    else if (nota < 5.0 && nota >= 3.0)
    {
      Console.WriteLine("Aluno de recuperacao");
    }
    else
    {
      Console.WriteLine("Aluno reprovado");
    }
  }
}