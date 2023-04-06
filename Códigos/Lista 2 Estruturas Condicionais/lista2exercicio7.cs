using System;

namespace Lista2Exercicio7{

    class Program{

        static void Main(){

            // Variáveis
            int Opcao, Num1, Num2, Num3;

            // Entrada
            Console.WriteLine("Informe Opção, Número 1, Número 2, Número 3.");
            Opcao = int.Parse(Console.ReadLine());
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());
            Num3 = int.Parse(Console.ReadLine());

            // Processamento
            
            // Saída
            switch (Opcao) {
              case 1:
                Console.WriteLine("Número 1: {0}.", Num1);
                break;
              case 2:
                Console.WriteLine("Número 2: {0}.", Num2);
                break;
              case 3:
                Console.WriteLine("Número 3: {0}.", Num3);
                break;
              default:
                Console.WriteLine("Opção inválida!");
                break;                
            }

        }

    }

}