using System;

namespace Lista2Exercicio6{

    class Program{

        static void Main(){

            // Variáveis
            int idade;

            // Entrada
            Console.Write("Informe a idade do(a) nadador(a): ");
            idade = int.Parse(Console.ReadLine());

            // Processamento
            
            // Saída
            if (idade >= 18) {
              Console.WriteLine("Categoria sênior.");
            } else if (idade >= 14) {
              Console.WriteLine("Categoria juvenil B.");
            } else if (idade >= 11) {
              Console.WriteLine("Categoria juvenil A.");
            } else if (idade >= 8) {
              Console.WriteLine("Categoria infantil B.");
            } else {
              Console.WriteLine("Nenhuma das categorias atendidads.");
            }

        }

    }

}