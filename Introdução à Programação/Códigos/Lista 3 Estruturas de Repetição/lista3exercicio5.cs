using System;

namespace Lista3Exercicio5 {

  class Program {

    static void Main(){

      // Variáveis
      int numero, numeroPares=0, numeroImpares=0;

      // Entrada
      Console.Write("Informe número: ");
      numero = int.Parse(Console.ReadLine());
      
      // Processamento
      while (numero != -1) {
        if (numero%2 == 0) numeroPares++;
        else numeroImpares++;
        Console.Write("Informe número: ");
        numero = int.Parse(Console.ReadLine());
      }

      // Saída
      Console.WriteLine("Quantidade de pares no conjunto: {0}.", numeroPares);
      Console.WriteLine("Quantidade de ímpares no conjunto: {0}", numeroImpares);

    }

  }

}