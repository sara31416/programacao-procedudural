using System;

class Program
{
  public static void Main(string[] args)
  {
    int somatorio = 0;
    int numeroRecebido = 0;

    do
    {
      Console.WriteLine("Digite um numero");
      numeroRecebido = int.Parse(Console.ReadLine());
      if (numeroRecebido % 2 == 1)
      {
        somatorio = somatorio + numeroRecebido;
      }
    } while (numeroRecebido >= 0);

    Console.WriteLine($"O somatorio de impares eh: {somatorio}");
  }
}