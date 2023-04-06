using System;

namespace Lista1Exercicio3{

  class Program{

    static void Main(){

      // Variáveis
      double larguraparede, alturaparede, taxatinta=0.3, tintalata=2.0, parcial;
      int latasdetinta;
      
      // Entrada
      Console.Write("Largura (m): ");
      larguraparede = double.Parse(Console.ReadLine());
      Console.Write("Altura (m): ");
      alturaparede = double.Parse(Console.ReadLine());
      
      // Processamento
      parcial = (larguraparede*alturaparede*taxatinta)/tintalata;
      latasdetinta = (int) Math.Ceiling(parcial);
      
      // Saída
      Console.WriteLine("Quantidade de latas de tinta: {0}.", latasdetinta);

    }

  }

}