using System;

namespace Lista1Exercicio1{

    class Program{

        static void Main(){
            
            // Variáveis
            string nome1, nome2, nome3;
            double preco1, preco2, preco3, precomedio;

            // Entrada
            Console.Write("Nome do 1º posto: ");
            nome1 = Console.ReadLine();
            Console.Write("Preço no 1º Posto: R$ ");
            preco1 = double.Parse(Console.ReadLine());
            Console.Write("Nome do 2º posto: ");
            nome2 = Console.ReadLine();
            Console.Write("Preço no 2º Posto: R$ ");
            preco2 = double.Parse(Console.ReadLine());
            Console.Write("Nome do 3º posto: ");
            nome3 = Console.ReadLine();
            Console.Write("Preço no 3º Posto: R$ ");
            preco3 = double.Parse(Console.ReadLine());

            // Processamento
            precomedio = (preco1 + preco2 + preco3)/3;

            // Saída
            Console.WriteLine("Preço médio: R$ {0}", precomedio);

        }

    }

}