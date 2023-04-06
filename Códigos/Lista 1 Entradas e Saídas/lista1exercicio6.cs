using System;

namespace Lista1Exercicio6{

  class Program{

    static void Main(){

      // Variáveis (data2_ >= data1_)
      int data1dia,data1mes,data1ano,data2dia,data2mes,data2ano;
      int difdias, difmeses, difanos;

      // Entrada
      Console.Write("Informe dia da primeira data:");
      data1dia = int.Parse(Console.ReadLine());
      Console.Write("Informe mês da primeira data:");
      data1mes = int.Parse(Console.ReadLine());
      Console.Write("Informe ano da primeira data:");
      data1ano = int.Parse(Console.ReadLine());
      Console.Write("Informe dia da segunda data:");
      data2dia = int.Parse(Console.ReadLine());
      Console.Write("Informe mês da segunda data:");
      data2mes = int.Parse(Console.ReadLine());
      Console.Write("Informe ano da segunda data:");
      data2ano = int.Parse(Console.ReadLine());

      // Processamento
      difdias = data2dia - data1dia;
      difmeses = data2mes - data1mes;
      difanos = data2ano - data1ano;
      
      // Saída
      Console.WriteLine("Diferença de dias: {0}", difdias);
      Console.WriteLine("Diferença de meses: {0}", difmeses);
      Console.WriteLine("Diferença de anos: {0}", difanos);

    }

  }

}