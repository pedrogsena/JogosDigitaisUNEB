using System;

namespace Lista4Exercicio8{

  class Program{

    static double valorSerie(int numero){
      double i, n, termo, resposta=0;
      int indice;
      n = Convert.ToDouble(numero);
      for(indice=0; indice < numero; indice++){
        if(indice%2 == 0) termo=1;
        else termo=-1;
        i = Convert.ToDouble(indice);
        termo*=(i+1)/(n-i);
        resposta+=termo;
      }
      return resposta;
    }

    static void Main(){

      // Variáveis
      int numero;
      double serie;

      // Entrada
      Console.Write("Informe número: ");
      numero = int.Parse(Console.ReadLine());
      while(numero <= 0){
        Console.WriteLine("Número inválido! Precisa ser positivo.");
        Console.Write("Informe número: ");
        numero = int.Parse(Console.ReadLine());
      }

      // Processamento
      serie = valorSerie(numero);

      // Saída
      Console.WriteLine("S({0}) = {1}", numero, serie);

    }

  }

}