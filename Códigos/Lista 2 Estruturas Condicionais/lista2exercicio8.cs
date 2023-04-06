using System;

namespace Lista2Exercicio8{

    class Program{

        static void Main(){

            // Variáveis
            int notas1, notas5, notas10, notas50, notas100, total;

            // Entrada
            Console.WriteLine("Informe quantas notas de cada tipo você tem.");
            Console.Write("De R$ 1: ");
            notas1 = int.Parse(Console.ReadLine());
            Console.Write("De R$ 5: ");
            notas5 = int.Parse(Console.ReadLine());
            Console.Write("De R$ 10: ");
            notas10 = int.Parse(Console.ReadLine());
            Console.Write("De R$ 50: ");
            notas50 = int.Parse(Console.ReadLine());
            Console.Write("De R$ 100: ");
            notas100 = int.Parse(Console.ReadLine());
            
            // Processamento
            total = notas1 + 5*notas5 + 10*notas10 + 50*notas50 + 100*notas100;

            // Saída
            Console.WriteLine("Dinheiro total: R$ {0},00.", total);

        }

    }

}