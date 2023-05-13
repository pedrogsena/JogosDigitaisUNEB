using System;

namespace Lista1Exercicio2{

    class Program{

        static void Main(){

            // Variáveis
            string nome;
            int idade, dias;
            
            // Entrada
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            
            // Processamento
            dias = idade*365+idade/4+183;
            
            // Saída
            Console.WriteLine("{0}, você tem aproximadamente {1} dias de vida!", nome, dias);

        }

    }

}