using System;

namespace Lista5Exercicio11{

  class Program{

    static void Main(){

      // Variáveis

      int[,] matriz = new int[4,4];
      int i, j, somaDiag=0;

      // Entrada e Processamento

      Console.WriteLine("Informe os elementos da matriz.");
      for(i=0; i < 4; i++){
        for(j=0; j < 4; j++){
          Console.Write("M({0},{1})= ", i+1, j+1);
          matriz[i,j] = int.Parse(Console.ReadLine());
          if (i == j) somaDiag+=matriz[i,j];
        }
      }

      // Saída
      Console.WriteLine("A soma dos elementos da diagonal principal da matriz informada é igual a {0}.", somaDiag);

    }

  }

}