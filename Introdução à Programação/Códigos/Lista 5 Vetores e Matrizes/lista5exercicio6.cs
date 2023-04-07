using System;

namespace Lista5Exercicio6{

  class Program{

    static void Main(){

      // Variáveis
      int[] vetor = new int[10];
      int[] repetido = new int[10];
      int i, j, tamanho, temporario;
      bool achou;

      // Entrada
      Console.WriteLine("Informe uma sequência de dez números inteiros e positivos.");
      for(i=0;i<10;i++){
        Console.Write("Termo {0}: ", i+1);
        temporario = int.Parse(Console.ReadLine());
        while(temporario <= 0){
          Console.WriteLine("Erro! O número informado não é positivo. Informe outro número.");
          Console.Write("Termo {0}: ", i+1);
          temporario = int.Parse(Console.ReadLine());
        }
        vetor[i] = temporario;
      }

      // Processamento
      i=0;
      tamanho=0;
      while(i<10){
        if(tamanho == 0){
          repetido[tamanho] = vetor[i];
          i++;
          tamanho++;
        }
        else{
          achou=false;
          for(j=0; (j<tamanho)&&(!achou); j++){
            if(repetido[j] == vetor[i]) achou=true;
          }
          if(!achou){
            repetido[tamanho] = vetor[i];
            tamanho++;
          }
          i++;
        }
      }

      // Saída
      Console.WriteLine("Sequência original:");
      for(i=0; i<10; i++){
        Console.Write(vetor[i]);
        if(i < 9) Console.Write(", ");
      }
      Console.Write("\n");
      Console.WriteLine("Sequência sem repetições:");
      for(j=0; j<tamanho; j++){
        Console.Write(repetido[j]);
        if(j < (tamanho-1)) Console.Write(", ");
      }
      Console.Write("\n");

    }

  }

}