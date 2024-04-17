  using System;
  using System.Reflection.Metadata;

  class Program
  {
      static void Main(string[] args)
      {
        const int TAMANHO_VAGAO = 12;
        int[] vagao = new int[TAMANHO_VAGAO]; 
        PrencherVagao(vagao);
        VerificarPesoVagao(vagao);
      }
      static void PrencherVagao(int[] vetor)
      {
        int numeroVagao = 1;
        for(int i = 0; i < vetor.Length; i++)
        {
          Console.WriteLine("Digite a quantidade de peso que há no vagão " + numeroVagao);
            int numerosRecebidos = Convert.ToInt32(Console.ReadLine());
          vetor[i] = numerosRecebidos;
          numeroVagao++;
        }
      }

      static void VerificarPesoVagao(int[] peso)
      {
        int numeroVagao = 1;
        for(int i = 0; i < peso.Length; i++)
        {
          if(peso[i] > 50)
        {
          Console.WriteLine("Vagão " + numeroVagao + "º ultrapassou o limite de peso");
        }
        numeroVagao++;
        }
      }
  }