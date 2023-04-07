using System;

namespace Lista5Exercicio1{

  class Program{

    static void Main(){

      // Variáveis
      int[] vetor = new int[8];
      int i, produto=1;

      // Entrada e Processamento
      Console.WriteLine("Insira os elementos do vetor de 8 casas:");
      for(i=0;i<8;i++){
        vetor[i] = int.Parse(Console.ReadLine());
        produto*=vetor[i];
      }

      // Saída
      Console.WriteLine("Produto dos elementos do vetor: {0}.", produto);

    }

  }

}