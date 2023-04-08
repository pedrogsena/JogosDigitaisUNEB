using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lista4Exercicio10{

  class Program{

    static void MaiorValorPosicao(List<int> valores){
      int i=0, maior=-2147483648, posicao=-1;
      foreach(int numero in valores){
        if(numero > maior){
          maior = numero;
          posicao = i;
        }
        i++;
      }
      Console.WriteLine("O maior valor é {0} e sua posição é {1}º.", maior, posicao+1);
    }

    static void Main(){

      // Variáveis
      int numero;
      List<int> listaNumeros = new List<int>();

      // Entrada

      do{
        Console.Write("Informe valor: ");
        numero = int.Parse(Console.ReadLine());
        if(numero != 0){
          listaNumeros.Add(numero);
        }
      } while(numero != 0);

      // Processamento

      MaiorValorPosicao(listaNumeros);

      // Saída

    }

  }

}