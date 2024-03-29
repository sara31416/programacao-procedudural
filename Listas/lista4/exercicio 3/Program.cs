using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                Tabuleiro.Adicionar(0, coluna, "S");
                Tabuleiro.Adicionar(7, coluna, "S");
                Tabuleiro.Adicionar(linha, 0, "S");
                Tabuleiro.Adicionar(linha, 7, "S");
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}