using System;

namespace Lista3Exercicio2 {

  class Program {

    static void Main(){

      // Variáveis
      int N, i, soma, diferenca, produto;

      // Entrada
      Console.Write("N=");
      N = int.Parse(Console.ReadLine());

      // Processamento e Saída
      Console.WriteLine("Tabuada do {0}:", N);
      for (i=0; i<=10; i++){
        soma = N+i;
        diferenca = N-i;
        produto = N*i;
        Console.WriteLine("{0} + {1} = {2} | {0} - {1} = {3} | {0} * {1} = {4}", N, i, soma, diferenca, produto);
      }

    }

  }

}