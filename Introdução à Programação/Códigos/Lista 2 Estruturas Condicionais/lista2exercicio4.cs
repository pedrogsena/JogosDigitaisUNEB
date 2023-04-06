using System;

namespace Lista2Exercicio4{

    class Program{

        static void Main(){

            // Variáveis
            int numero1, numero2, numero3, maiornumero;

            // Entrada
            Console.WriteLine("Informe três numeros inteiros.");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            // Processamento
            maiornumero = numero1;
            if (numero2 > maiornumero) {
              maiornumero = numero2;
            }
            if (numero3 > maiornumero) {
              maiornumero = numero3;
            }

            // Saída
            Console.WriteLine("O maior dentre os três números é {0}.", maiornumero);

        }

    }

}