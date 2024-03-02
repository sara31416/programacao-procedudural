using System;

class Program
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Para obter a nota média do aluno siga o passo a passo abaixo:");
    Console.WriteLine(" Digite a 1º nota: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 2º nota: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 3º nota: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 4º nota: ");
    double nota4 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4)/4;

    Console.WriteLine("A media do aluno eh: " + media);

  }
}