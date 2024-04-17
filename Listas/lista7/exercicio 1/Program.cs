        using System;
        using System.Reflection.Metadata.Ecma335;
        using System.Runtime.CompilerServices;

        class program
        {
            static bool EhPar(int numero)
            {
                return (numero % 2 == 0);
            }
            public static void Main(string[] args)
            {
                Console.WriteLine("Digite um número");
                int numeroDigitado = int.Parse(Console.ReadLine());

                bool resultado = EhPar(numeroDigitado);
                if(resultado)
                {
                    Console.WriteLine("Verdadeiro");
                }
                else
                {
                    Console.WriteLine("falso");
                }
            }
        }