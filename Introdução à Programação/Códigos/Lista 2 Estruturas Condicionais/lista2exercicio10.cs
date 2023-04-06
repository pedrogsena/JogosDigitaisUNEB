using System;

namespace Lista2Exercicio10{

    class Program{

        static void Main(){

            // Variáveis
            double comprimentoPista, velocidadeCarro1, velocidadeCarro2, tempoCarro1, tempoCarro2;

            // Entrada
            Console.Write("Tamanho da pista, em metros: ");
            comprimentoPista = double.Parse(Console.ReadLine());
            Console.Write("Tempo, em segundos, do primeiro carro: ");
            tempoCarro1 = double.Parse(Console.ReadLine());
            Console.Write("Tempo, em segundos, do segundo carro: ");
            tempoCarro2 = double.Parse(Console.ReadLine());
            
            // Processamento – assume-se que os tempos informados serão sempre diferentes, levando a velocidades diferentes
            velocidadeCarro1 = comprimentoPista / tempoCarro1;
            velocidadeCarro2 = comprimentoPista / tempoCarro2;

            // Saída
            if (velocidadeCarro1 > velocidadeCarro2) {
              Console.WriteLine("O primeiro carro foi o mais rápido, com velocidade de {0} m/s.", velocidadeCarro1);
            } else {
              Console.WriteLine("O segundo carro foi o mais rápido, com velocidade de {0} m/s.", velocidadeCarro2);
            }

        }

    }

}