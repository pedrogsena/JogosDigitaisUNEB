using System;

namespace Lista5Exercicio2{

  class Program{

    static void Main(){

      // Variáveis
      int[] vetorA = new int[8];
      int[] vetorB = new int[8];
      int[] vetorC = new int[8];
      int i;

      // Entrada
      Console.WriteLine("Informe vetor A:");
      for(i=0;i<8;i++){
        vetorA[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Informe vetor B:");
      for(i=0;i<8;i++){
        vetorB[i] = int.Parse(Console.ReadLine());
      }

      // Processamento
      for(i=0;i<8;i++){
        vetorC[i] = vetorA[i] + vetorB[i];
      }

      // Saída
      Console.WriteLine("Vetor C:");
      for(i=0;i<8;i++){
        Console.Write(vetorC[i]);
        if(i<7) Console.Write(", ");
      }
      Console.Write("\n");

    }

  }

}