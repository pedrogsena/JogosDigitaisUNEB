using System;

namespace Lista2Exercicio3{

    class Program{

        static void Main(){

            // Variáveis
            int numero;

            // Entrada
            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            // Processamento
            
            // Saída
            if (numero%2 == 0) {
              Console.WriteLine("{0} é par.", numero);
            } else {
              Console.WriteLine("{0} é ímpar.", numero);
            }
        
        }

    }

}