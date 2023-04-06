using System;

namespace Lista3Exercicio7 {

  class Program {

    static void Main(){

      // Variáveis
      int primeiro=1, segundo=1, terceiro, numero, contador;

      // Entrada
      Console.WriteLine("Quantos termos da sequência de Fibonacci você vai querer?");
      numero = int.Parse(Console.ReadLine());

      // Processamento e Saída
      if (numero > 0) {
        Console.Write("Sequência de Fibonacci: ");
        if (numero == 1) {
          Console.WriteLine("{0}", primeiro);
        } else {
          Console.Write("{0}, {1}", primeiro, segundo);
          if (numero > 2) {
            contador = 2;
            do {
              terceiro = primeiro + segundo;
              Console.Write(", {0}", terceiro);
              primeiro = segundo;
              segundo = terceiro;
              contador++;
            } while (contador < numero);
          }
          Console.Write("\n");
        }
      }

    }

  }

}