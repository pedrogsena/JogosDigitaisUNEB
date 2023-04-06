using System;

namespace Lista3Exercicio4 {

  class Program {

    static void Main(){

      // Variáveis
      int primeiro, numero;

      // Entrada
      Console.Write("Informe número: ");
      primeiro = int.Parse(Console.ReadLine());

      // Processamento
      do {
        Console.Write("Informe número: ");
        numero = int.Parse(Console.ReadLine());
      } while (numero != primeiro);

      // Saída
      Console.WriteLine("Número igual ao primeiro informado. Encerrando aplicação...");

    }

  }

}