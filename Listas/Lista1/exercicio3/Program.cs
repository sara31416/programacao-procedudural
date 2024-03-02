using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.WriteLine ("Digite a quantidade de moedas de um centavo que você possui: ");

    int centavos = int.Parse(Console.ReadLine());

    int reais = centavos / 100;
    int centavos_remanescentes = centavos % 100;

    Console.WriteLine("o total em dinheiro é " + reais + " real(is) eh " + centavos_remanescentes + " centavo(s) ");

   
  }
}