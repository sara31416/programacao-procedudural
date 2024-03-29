using System;

class Program

{
    public static void Main(string[] args)
    {
        const int NUMERO_MAXIMO_DE_TENTATIVAS = 3;

        const string NOME_DE_USUARIO_CORRETO = "admin";
        const string SENHA_CORRETA = "123senha";

        int contadorDeTentativas = 1;

        do
        {
            Console.WriteLine("Digite seu nome de usuario");
            string nomeDeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            if (nomeDeUsuario == NOME_DE_USUARIO_CORRETO && senha == SENHA_CORRETA)
            {
                Console.WriteLine("Login realizado com sucesso");
                break;
            }
            contadorDeTentativas++;
        }
        while (contadorDeTentativas <= NUMERO_MAXIMO_DE_TENTATIVAS);

        if (contadorDeTentativas > NUMERO_MAXIMO_DE_TENTATIVAS)
        {
            Console.WriteLine("Sua conta foi bloqueada");
        }
    }
}
