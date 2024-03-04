using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Digite o nome da criança:");
    string nomeDaCriança = Console.ReadLine();

    if (nomeDaCriança == "Filomena")
    {
      Console.WriteLine(" Rotina de Filomena\n 1. Escola das 07h as 12h\n 2.Almoço das 12h as 13h\n 3.Futbol das 14h as 16h\n 4.Dever de casa das 16h as 18h");
       }
    else if (nomeDaCriança == "Joselito")
   {
       Console.WriteLine("Rotina do Joselito\n 1. Escola das 07h as 12:30\n 2. Almoço das 13h as 14h\n 3. Natação das 14h as 16h\n 4. Reforço escolar das 16h as 19h");
   }
    else
    {
      Console.WriteLine("Nome invalido!");
    }
  }
}