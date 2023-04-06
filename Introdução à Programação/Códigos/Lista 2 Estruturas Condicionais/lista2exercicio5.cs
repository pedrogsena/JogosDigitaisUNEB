using System;

namespace Lista2Exercicio5{

    class Program{

        static void Main(){

            // Variáveis
            double valorreais, valorconvertido;
            double cambiodolar=4.00, cambiolibra=6.15, cambioeuro=4.72;
            int tipomoeda;

            // Entrada
            Console.WriteLine("Informe um valor em reais\ne qual opção de moeda para conversão.\n1: Dólar\n2: Libra\n3: Euro");
            Console.Write("R$ ");
            valorreais = double.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            tipomoeda = int.Parse(Console.ReadLine());

            // Processamento e Saída
            switch (tipomoeda) {
              case 1:
                valorconvertido = valorreais / cambiodolar;
                Console.WriteLine("Convertido para US$ {0}.", Math.Round(valorconvertido,2));
                break;
              case 2:
                valorconvertido = valorreais / cambiolibra;
                Console.WriteLine("Convertido para £ {0}.", Math.Round(valorconvertido,2));
                break;
              case 3:
                valorconvertido = valorreais / cambioeuro;
                Console.WriteLine("Convertido para € {0}.", Math.Round(valorconvertido,2));
                break;
              default:
                Console.WriteLine("Erro: código de tipo de moeda inválido.");
                break; // Em C#, é preciso usar break mesmo no default case.
            }
            
        }

    }

}