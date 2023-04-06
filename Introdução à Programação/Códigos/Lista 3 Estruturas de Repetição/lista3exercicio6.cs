using System;

namespace Lista3Exercicio6 {

  class Program {

    static void Main(){

      // Variáveis
      /* ulong: unsigned long, ou seja, inteiro positivo usando até 64 bits para armazenar;
         vai de 0 até 18,446,744,073,709,551,615, ou seja, 20 dígitos; acredite, pra fatoriais,
         você VAI precisar desse tamanho; para testar, calcule o fatorial de 20. */
      ulong numero, indice, fatorial=1;

      // Entrada
      Console.Write("Informe um número: ");
      numero = ulong.Parse(Console.ReadLine());

      // Processamento
      if (numero > 1) {
        for (indice=1; indice<=numero; indice++) {
          fatorial*=indice;
        }
      }

      // Saída
      Console.WriteLine("Fatorial do número informado: {0}! = {1}.", numero, fatorial);
      
    }

  }

}