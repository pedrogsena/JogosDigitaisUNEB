using System;
using System.IO;

namespace Lista4Exercicio11{

  class Program{

    static readonly string entrada_notas = "L4E11_entrada_notas.txt";

    static void LerNotas(double[] notas, int tamanho){
      string[] stringNotas = new string[tamanho];
      int i;
      stringNotas = File.ReadAllLines(entrada_notas);
      for(i=0; i < tamanho; i++){
        notas[i] = Convert.ToDouble(stringNotas[i]);
      }
    }

    static double CalcularMedia(double[] notas, int tamanho){
      int i;
      double media=0;
      for(i=0; i < tamanho; i++){
        media+=notas[i];
      }
      media = media / Convert.ToDouble(tamanho);
      return media;
    }

    static void ImprimirNotas(double[] notas, int tamanho, double media){ // média e mais alta
      int i;
      double maior=0;
      for(i=0; i < tamanho; i++){
        if(notas[i] > maior) maior = notas[i];
      }
      Console.WriteLine("Média da turma: {0}.", media);
      Console.WriteLine("Nota mais alta: {0}.", maior);
    }

    static void Main(){

      // Variáveis

      double[] notas = new double[10];
      double media;

      // Entrada

      LerNotas(notas, 10);

      // Processamento

      media = CalcularMedia(notas, 10);

      // Saída

      ImprimirNotas(notas, 10, media);

    }

  }

}