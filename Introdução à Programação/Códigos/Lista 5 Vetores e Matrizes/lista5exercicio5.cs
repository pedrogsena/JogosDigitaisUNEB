using System;

namespace Lista5Exercicio5{

  class Program{

    static void Main(){

      // Variáveis
      int[] vetor = new int[10];
      int numero, i, posicao=-1;
      bool achou=false;

      // Entrada
      Console.WriteLine("Informe vetor de 10 casas:");
      for(i=0;i<10;i++){
        Console.Write("Vetor[{0}]= ", i);
        vetor[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Informe número a localizar no vetor:");
      numero = int.Parse(Console.ReadLine());

      // Processamento
      i=0;
      while(!achou && (i < 10)){
        if(vetor[i] == numero){
          posicao = i;
          achou = true;
        } else i++;
      }

      // Saída
      if(posicao == -1){
        Console.WriteLine("Número {0} não encontrado no vetor.", numero);
      } else {
        Console.WriteLine("Número {0} encontrado na posição {1}.", numero, posicao);
      }

    }

  }

}