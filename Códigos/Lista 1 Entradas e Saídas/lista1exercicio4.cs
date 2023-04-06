using System;

namespace Lista1Exercicio4{

  class Program{

    static void Main(){

      // Variáveis
      int cronometrohoras, cronometrominutos, cronometrosegundos, tempototal;

      // Entrada
      Console.WriteLine("Informe o tempo do cronômetro.");
      Console.Write("Horas:");
      cronometrohoras = int.Parse(Console.ReadLine());
      Console.Write("Minutos:");
      cronometrominutos = int.Parse(Console.ReadLine());
      Console.Write("Segundos:");
      cronometrosegundos = int.Parse(Console.ReadLine());

      // Processamento
      tempototal = cronometrosegundos + 60*(cronometrominutos + 60*cronometrohoras);

      // Saída
      Console.WriteLine("Tempo total em segundos: {0}s.", tempototal);

    }

  }

}