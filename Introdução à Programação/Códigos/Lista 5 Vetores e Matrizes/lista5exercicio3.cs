using System;
using System.IO;

namespace Lista5Exercicio3{

  class Program{

    static readonly string entrada = "L5E3_entrada.txt";

    static void Main(){

      // Variáveis
      string[] stringSalarios = new string[50];
      int[] salarios = new int[50];
      int media=0, qtosAcimaMedia=0, i;

      // Entrada
      stringSalarios = File.ReadAllLines(entrada);

      // Processamento
      for(i=0;i<50;i++){
        salarios [i] = int.Parse(stringSalarios[i]);
        media+=salarios[i];
      }
      media = media / 50;
      Console.WriteLine("Média: {0}.", media);
      for(i=0;i<50;i++){
        if(salarios[i] > media) qtosAcimaMedia++;
      }

      // Saída
      Console.WriteLine("{0} funcionários ganham acima da média.", qtosAcimaMedia);

    }

  }

}