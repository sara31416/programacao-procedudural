using System;

class Program
{
    public static void Main (string[] args)
    {
        const int   TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];
        int somatorio = 0;

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                Console.WriteLine("Digite o numero que deseja inserir na matriz");
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
        
        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if(linha == coluna)
                {
                    somatorio += matriz[linha,coluna];
                }
            }
        }

        Console.WriteLine("A soma dos valores da diagonal principal eh: " + somatorio);
    }
}