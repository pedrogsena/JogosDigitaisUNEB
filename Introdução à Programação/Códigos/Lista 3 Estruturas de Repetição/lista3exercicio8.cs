using System;

using System;

namespace Lista3Exercicio8 {

  class Program {

    static void Main(){

      // Variáveis
      string nome, codigo;
      char sexo;
      int idade, total=0, totalServicos=0, totalHomens=0, totalMulheres=0, percentualServicos;

      // Entrada e Processamento

      Console.WriteLine("Informe nome, idade, sexo e código:");
      Console.Write("Nome: ");
      nome = Console.ReadLine();

      while(nome != "fim") {
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Sexo: ");
        sexo = char.Parse(Console.ReadLine());
        Console.Write("Código: ");
        codigo = Console.ReadLine();

        total++;
        if (sexo == 'M') totalHomens++;
        else if (sexo == 'F') totalMulheres++;
        if (codigo == "020") totalServicos++;
        
        Console.WriteLine("Consumidor Registrado. Próximo consumidor...\n");
        Console.WriteLine("Informe nome, idade, sexo e código:");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
      }

      // Saída
      if (total>0) {
        percentualServicos = 100 * totalServicos / total;
        Console.WriteLine("Percentual dos consumidores que buscaram Serviços: {0}%.", percentualServicos);
        if (totalHomens > totalMulheres) Console.WriteLine("A maioria dos consumidores foram homens.");
        else Console.WriteLine("A maioria dos consumidores foram mulheres.");
      }
      
    }

  }

}