    using System;

    class program
    {
        static void Main(string[] args)
        {
            ClassificarNadador();
        }
        static void ClassificarNadador()
        {
            Console.WriteLine("Digite sua idade para saber a sua classificação:");
            int recebeIdade = Convert.ToInt32(Console.ReadLine());
            if(recebeIdade < 12)
            {
                Console.WriteLine("Infantil");
            }
            else if(recebeIdade >= 12 && recebeIdade <= 14)
            {
                Console.WriteLine("Juvenil A");
            }
            else if(recebeIdade == 15 && recebeIdade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
            }
    }