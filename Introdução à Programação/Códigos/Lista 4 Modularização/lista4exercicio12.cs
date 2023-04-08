using System;

namespace Lista4Exercicio12{

  class Program{

    // Módulos aqui!

    static void ModuloL4E12(int[] vetor1, int[] vetor2, int[] vetorSoma, int tamanho){
      LerVetores(vetor1, vetor2, 8);
      SomarVetor(vetor1, vetor2, vetorSoma, 8);
      ImprimirVetor(vetorSoma, 8);
    }

    static void LerVetores(int[] vetor1, int[] vetor2, int tamanho){
      int i;
      for(i=0; i < tamanho; i++){
        Console.Write("{0}º valor do 1º vetor: ", i+1);
        vetor1[i] = int.Parse(Console.ReadLine());
        Console.Write("{0}º valor do 2º vetor: ", i+1);
        vetor2[i] = int.Parse(Console.ReadLine());
      }
    }

    static void SomarVetor(int[] vetor1, int[] vetor2, int[] vetorSoma, int tamanho){
      int i;
      for(i=0; i < tamanho; i++){
        vetorSoma[i] = vetor1[i] + vetor2[i];
      }
    }

    static void ImprimirVetor(int[] vetor, int tamanho){
      int i;
      Console.Write("Vetor: ");
      for(i=0; i < tamanho; i++){
        Console.Write("{0} ", vetor[i]);
      }
    }

    static void Main(){

      // Variáveis

      int[] vetor1 = new int[8];
      int[] vetor2 = new int[8];
      int[] vetorSoma = new int[8];

      ModuloL4E12(vetor1, vetor2, vetorSoma, 8);

    }

  }

}