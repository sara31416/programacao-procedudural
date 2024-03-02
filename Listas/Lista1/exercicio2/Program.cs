using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Digite a base do triangulo: ");
    double baseDoTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do triangulo: ");
    double alturaDoTriangulo = double.Parse(Console.ReadLine());

    double areaDoTriangulo =  (baseDoTriangulo * alturaDoTriangulo)/2;

    bool ehMaiorQue20 = areaDoTriangulo > 20;

    Console.WriteLine("A área do triangulo é maior que 20? " + ehMaiorQue20);
    
  }
}