using System;

namespace Lista3Exercicio3 {

  class Program {

    static void Main(){

      // Variáveis
      int numero, menor=int.MaxValue; // 2147483647
      bool flag=false;

      // Entrada e Processamento – assume-se que os números serão positivos
      Console.WriteLine("Informe os números do conjunto.");
      do {
        numero = int.Parse(Console.ReadLine());
        if (numero == 0) break;
        else {
           if (numero < menor) menor = numero;
           flag=true;
        }
      } while (numero != 0);

      // Saída
      if (flag) Console.WriteLine("Menor valor do conjunto: {0}", menor);

    }

  }

}