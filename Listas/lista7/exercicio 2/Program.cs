    using System;
    using System.Collections.Specialized;
    using System.Diagnostics.Contracts;
    using System.Reflection.Metadata;
    using System.Security.Cryptography;

    class Program
    { 
        static int EncontraMaiorNumero(int[] vetor)
        { 
            int maiorElemento = int.MinValue;
            for(int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] > maiorElemento)
                {
                maiorElemento = vetor[i];  
                } 
            }
            return maiorElemento;
        }
        public static void Main(string[] args)
        {
            int[] vetor = new int [3];
            int resultado = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
            Console.WriteLine("Digite um número");
            vetor[i] = int.Parse(Console.ReadLine());
            resultado = EncontraMaiorNumero(vetor);
            }
            Console.WriteLine("O maior número eh: " + resultado);
        }   
    }