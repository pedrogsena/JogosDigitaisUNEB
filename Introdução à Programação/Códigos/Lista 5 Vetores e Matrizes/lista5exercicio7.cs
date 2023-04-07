using System;

namespace Lista5Exercicio7{

  class Program{

    static void Main(){

      // Variáveis
      int[,] M = new int[3,5];
      int i,j,X,i_X=-1,j_X=-1;
      bool achou=false;

      // Entrada
      Console.WriteLine("Informe os elementos da matriz M(3,5):");
      for(i=0; i<3; i++){
        for(j=0; j<5; j++){
          Console.Write("M({0},{1})= ", i+1, j+1);
          M[i,j] = int.Parse(Console.ReadLine());
        }
      }
      Console.WriteLine("Informe número a ser encontrado na matriz.");
      Console.Write("X= ");
      X = int.Parse(Console.ReadLine());

      // Processamento
      i=0;
      while(!achou && i<3){
        j=0;
        while(!achou && j<5){
          if(M[i,j] == X){
            achou = true;
            i_X = i+1;
            j_X = j+1;
          } else j++;
        }
        i++;
      }

      // Saída
      if(achou) Console.WriteLine("X={0} encontrado na posição ({1},{2}).", X, i_X, j_X);
      else Console.WriteLine("Elemento não encontrado.");

    }

  }

}