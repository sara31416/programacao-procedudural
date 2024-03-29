using System;

class Program
{
  public static void Main(string[] args)
  {
    int numero;
    do
    {
      Console.WriteLine("Digite um número entre 1 e 9");
      numero = int.Parse(Console.ReadLine());
      if (numero < 1 || numero > 9)
      {
        Console.WriteLine("Altura invalida");

      }
      else
      {
        break;
      }
    }
    while (true);

    for (int linha = 1; linha <= numero; linha++)
    {
      for (int coluna = 1; coluna <= linha; coluna++)
      {
        Console.Write(coluna);
      }

      Console.WriteLine();

    }
  }
}