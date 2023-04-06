using System;

namespace Lista2Exercicio2{

    class Program{

        static void Main(){

            // Variáveis
            int numero1, numero2;

            // Entrada
            Console.WriteLine("Informe dois números:");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            // Processamento
            
            // Saída
            Console.WriteLine("Em ordem ascendente:");
            if (numero1 < numero2 ) {
              Console.WriteLine("{0}, {1}", numero1, numero2);
            } else {
              Console.WriteLine("{0}, {1}", numero2, numero1);
            }
        
        }

    }

}