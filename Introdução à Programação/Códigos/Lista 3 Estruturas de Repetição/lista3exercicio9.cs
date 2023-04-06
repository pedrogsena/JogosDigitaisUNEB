using System;

namespace Lista3Exercicio9 {

  class Program {

    static void Main(){

      // Variáveis
      char tipo, sexo, tipoMaisVendido;
      int totalHomensRomance=0, totalFiccao=0, totalRomance=0, totalAventura=0;
      int totalCompradores=0, totalMaisVendido, percentualHomensRomance=0;
      int totalHomens=0;

      // Entrada e Processamento

      Console.WriteLine("Informe tipo do livro comprado e sexo do comprador:");
      Console.Write("Tipo: ");
      tipo = char.Parse(Console.ReadLine());

      while(tipo != '0') {
        Console.Write("Sexo: ");
        sexo = char.Parse(Console.ReadLine());

        totalCompradores++;
        if (sexo == 'M') totalHomens++;
        switch (tipo) {
          case '1':
            totalFiccao++;
            break;
          case '2':
            totalRomance++;
            if(sexo == 'M') totalHomensRomance++;
            break;
          case '3':
            totalAventura++;
            break;
          default:
            break;
        }

        Console.WriteLine("Comprador Registrado. Próximo...\n");
        Console.WriteLine("Informe tipo do livro comprado e sexo do comprador:");
        Console.Write("Tipo: ");
        tipo = char.Parse(Console.ReadLine());
      }

      if (totalCompradores > 0) {
        totalMaisVendido = totalFiccao;
        tipoMaisVendido = '1';
        if (totalRomance > totalMaisVendido) {
          totalMaisVendido = totalRomance;
          tipoMaisVendido = '2';
        }
        if (totalAventura > totalMaisVendido) {
          totalMaisVendido = totalAventura;
          tipoMaisVendido = '3';
        }
        if (totalHomens > 0) percentualHomensRomance = 100 * totalHomensRomance / totalHomens;
      } else tipoMaisVendido = '0';

      // Saída
      switch (tipoMaisVendido) {
        case '1':
          Console.WriteLine("O tipo de livro mais vendido foi Ficção.");
          break;
        case '2':
          Console.WriteLine("O tipo de livro mais vendido foi Romance.");
          break;
        case '3':
          Console.WriteLine("O tipo de livro mais vendido foi Aventura.");
          break;
        default:
          Console.WriteLine("O tipo de livro mais vendido foi Outros.");
          break;
      }

      if (totalHomens > 0) {
        Console.WriteLine("O percentual de homens que lêem livros de romance é de {0}%.", percentualHomensRomance);
      }

    }

  }

}