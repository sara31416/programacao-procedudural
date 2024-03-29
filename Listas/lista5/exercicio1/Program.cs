using System;

class Program
{
  public static void Main(string[] args)
  {
    int contadorDecrescente = 200;

    for (int contadorCrescente = 0; contadorCrescente <= 100 && contadorDecrescente >= 0; contadorCrescente++)
    {
      if (contadorCrescente % 2 == 0)
      {
        Console.WriteLine($"{contadorCrescente} - {contadorDecrescente}");
        contadorDecrescente -= 4;
      }
    }
  }
}