using System;

namespace Lista2Exercicio9{

    class Program{

        static void Main(){

            // Variáveis
            int montante, sobrou, notas100, notas50, notas10, notas5, notas1;

            // Entrada
            Console.WriteLine("Informe o montante total.");
            Console.Write("R$ ");
            montante = int.Parse(Console.ReadLine());
            
            // Processamento
            sobrou = montante;
            notas100 = sobrou / 100;
            sobrou = sobrou % 100;
            notas50 = sobrou / 50;
            sobrou = sobrou % 50;
            notas10 = sobrou / 10;
            sobrou = sobrou % 10;
            notas5 = sobrou / 5;
            notas1 = sobrou % 5;

            // Saída
            // Console.WriteLine("Você vai precisar de:\n{0} notas de R$ 100,00;\n{1} notas de R$ 50,00;\n{2} notas de R$ 10,00;\n{3} notas de R$ 5,00;\ne {4} notas de R$ 1,00.", notas100, notas50, notas10, notas5, notas1);
            Console.WriteLine("Você vai precisar de:");
            if (notas100>0) {
              Console.WriteLine("{0} notas de R$ 100,00", notas100);
            }
            if (notas50>0) {
              Console.WriteLine("{0} notas de R$ 50,00", notas50);
            }
            if (notas10>0) {
              Console.WriteLine("{0} notas de R$ 10,00", notas10);
            }
            if (notas5>0) {
              Console.WriteLine("{0} notas de R$ 5,00", notas5);
            }
            if (notas1>0) {
              Console.WriteLine("{0} notas de R$ 1,00", notas1);
            }

        }

    }

}