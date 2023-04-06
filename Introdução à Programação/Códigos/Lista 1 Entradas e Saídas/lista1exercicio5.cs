using System;

namespace Lista1Exercicio5{

  class Program{

    static void Main(){

      // Variáveis
      double larguratijolo, alturatijolo, largurasala, alturasala, larguraporta, alturaporta, largurajanela, alturajanela, areatotal;
      int qtetijolos;

      // Entrada
      Console.Write("Largura do tijolo: ");
      larguratijolo = double.Parse(Console.ReadLine());
      Console.Write("Altura do tijolo: ");
      alturatijolo = double.Parse(Console.ReadLine());
      Console.Write("Largura da parede: ");
      largurasala = double.Parse(Console.ReadLine());
      Console.Write("Altura da parede: ");
      alturasala = double.Parse(Console.ReadLine());
      Console.Write("Largura da porta: ");
      larguraporta = double.Parse(Console.ReadLine());
      Console.Write("Altura da porta: ");
      alturaporta = double.Parse(Console.ReadLine());
      Console.Write("Largura da janela: ");
      largurajanela = double.Parse(Console.ReadLine());
      Console.Write("Altura da janela: ");
      alturajanela = double.Parse(Console.ReadLine());

      // Processamento
      areatotal = 4*largurasala*alturasala-(larguraporta*alturaporta+largurajanela*alturajanela);
      qtetijolos = (int) Math.Ceiling(areatotal/(larguratijolo*alturatijolo));

      // Saída
      Console.WriteLine("Serão precisos {0} tijolos.", qtetijolos);

    }

  }
  
}