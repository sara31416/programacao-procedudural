    using System;

    class program
    {
        static void Main(string[] args)
        {
            const int TAMANHO_MATRIZ = 4;
            int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
            PrencherMatriz(matriz);
            TemBalista(matriz);

        }
        static void PrencherMatriz(int[,] matriz)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite os numeros que deseja inserir no tabuleiro");
                    int numerosRecebido = Convert.ToInt32(Console.ReadLine());
                    matriz[i, j] = numerosRecebido;
                }
            }
        }

        static void TemBalista(int[,] matriz)
        {
            bool balista = false;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                if(matriz[i, j] == 0)
                {
                    balista = true;
                }
                }
            }
            if(balista == true)
            {
                Console.WriteLine("Fique atento! existe balistas no tabuleiro");
            }
            else if(balista == false)
            {
            Console.WriteLine("Não ha balistas no tabuleiro");   
            }
        }
    }