using System;
class Program

{
    public static void Main(string[] args)
    {
        double somatorio = 0;
        int contador = 0;

        const int VALOR_MINIMO_PARA_FRETE_GRATIS = 150;

        Console.WriteLine("Quantos produtos você comprou?");
        int quantidadeDeProdutosComprados = int.Parse(Console.ReadLine());

        while (contador != quantidadeDeProdutosComprados)
        {
            Console.WriteLine("Digite o valor do produto que você comprou");
            double valorDaCompra = double.Parse(Console.ReadLine());
            somatorio += valorDaCompra;
            contador++;
        }

        if (somatorio > VALOR_MINIMO_PARA_FRETE_GRATIS)
        {
            Console.WriteLine("Parabens! você ganhou frete gratis na sua compra no valor de " + somatorio + " reais.");
        }
        else
        {
            Console.WriteLine("A compra não possui frete gratis");
        }

    }
}