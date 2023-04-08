using System;

namespace Lista4Exercicio2{

  class Program{

    static void TROCA(ref int primeiro, ref int segundo){
      int terceiro = primeiro;
      primeiro = segundo;
      segundo = terceiro;
    }

    static void OrdenaPares(int[] vetor, int tamanho){
      int i, contador;
      do {
        contador=0;
        for(i=0; i < (tamanho-1); i++){
          if(vetor[i]>vetor[i+1]){
            TROCA(ref vetor[i], ref vetor[i+1]);
            contador++;
          }
        }
      } while(contador > 0);
    }

    static void LerVetor(int[] vetor, int tamanho){
      int i;
      Console.WriteLine("Insira valores da sequência:");
      for(i=0; i < tamanho; i++){
        Console.Write("{0}º termo: ", i+1);
        vetor[i] = int.Parse(Console.ReadLine());
      }
    }

    static void ImprimirVetor(int[] vetor, int tamanho){
      int i;
      Console.WriteLine("Sequência ordenada:");
      for(i=0; i < tamanho; i++){
        Console.Write("{0}", vetor[i]);
        if(i < (tamanho-1)) Console.Write(", ");
      }
      Console.Write("\n");
    }

    static void Main(){

      // Variáveis
      int[] meuVetor = new int[4];

      // Entrada
      LerVetor(meuVetor, 4);

      // Processamento
      OrdenaPares(meuVetor, 4);

      // Saída
      ImprimirVetor(meuVetor, 4);

    }

  }

}