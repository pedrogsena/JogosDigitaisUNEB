using System;

namespace Lista3Exercicio1 {

  class Program {

    static void Main(){

      // Variáveis
      int a, b, i, somaImpares=0;

      // Entrada
      Console.WriteLine("Informe início e fim do intervalo.");
      Console.Write("Início: ");
      a = int.Parse(Console.ReadLine());
      Console.Write("Fim: ");
      b = int.Parse(Console.ReadLine());

      // Processamento
      i=a+1;
      while (i<b) {
        if(i%2!=0) somaImpares+=i;
        i++;
      }

      // Saída
      Console.WriteLine("A soma dos números ímpares dentro do intervalo ({0},{1}) é igual a {2}.", a, b, somaImpares);

    }

  }

}