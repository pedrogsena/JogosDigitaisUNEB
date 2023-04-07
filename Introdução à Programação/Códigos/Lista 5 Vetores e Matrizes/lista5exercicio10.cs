using System;

namespace Lista5Exercicio10{

  class Program{

    static void Main(){

      // Variáveis

      int[,] Z = new int[3,4];
      int i, j, maior, menor, temporario;
      int linhaMaior=0, colunaMaior=0, linhaMenor=0, colunaMenor=0;

      // Entrada

      Console.WriteLine("Informe os elementos da matriz Z(3,4):");
      for(i=0; i<3; i++){
        for(j=0; j<4; j++){
          do {
            Console.Write("Z({0},{1})= ", i+1, j+1);
            temporario = int.Parse(Console.ReadLine());
            if (temporario <= 0) Console.WriteLine("Erro! Valor negativo.");
          } while (temporario <=0);
          Z[i,j] = temporario;
        }
      }

      // Processamento

      maior = Z[0,0];
      menor = Z[0,0];

      for(i=0; i<3; i++){
        for(j=0; j<4; j++){
          if(Z[i,j] > maior){
            maior = Z[i,j];
            linhaMaior = i+1;
            colunaMaior = j+1;
          } else if (Z[i,j] < menor){
            menor = Z[i,j];
            linhaMenor = i+1;
            colunaMenor = j+1;
          }
        }
      }

      // Saída

      Console.WriteLine("O maior elemento da matriz é Z({0},{1}) = {2}.", linhaMaior, colunaMaior, maior);
      Console.WriteLine("O menor elemento da matriz é Z({0},{1}) = {2}.", linhaMenor, colunaMenor, menor);

    }

  }

}