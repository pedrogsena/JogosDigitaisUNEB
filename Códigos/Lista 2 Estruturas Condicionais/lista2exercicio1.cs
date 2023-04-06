using System;

namespace Lista2Exercicio1{

    class Program{

        static void Main(){

            // Variáveis
            int numero, partemaior, partemenor, soma;

            // Entrada
            Console.WriteLine("Informe um número de 4 dígitos.");
            numero = int.Parse(Console.ReadLine());

            // Processamento
            partemaior = numero / 100;
            partemenor = numero % 100;
            soma = partemaior + partemenor;

            // Saída
            if (soma*soma == numero) {
              Console.WriteLine("O número informado segue a propriedade!");
            } else {
              Console.WriteLine("O número informado não segue a propriedade.");
            }
            
        }

    }

}