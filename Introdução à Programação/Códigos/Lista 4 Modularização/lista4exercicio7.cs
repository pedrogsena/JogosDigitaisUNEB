using System;

namespace Lista4Exercicio7{

  class Program{
    
    static bool ChecaPrimo(int numero){
      bool resposta=true;
      int divisor;
      if(numero < 0) numero = (-1)*numero;
      if((numero == 0) || (numero == 1)) resposta=false;
      else if(numero == 2) resposta=true;
      else if(numero%2 == 0) resposta=false;
      else{
        for(divisor=3; divisor<numero; divisor+=2){
          if(numero%divisor == 0){
            resposta=false;
            break;
          }
        }
      }
      return resposta;
    }

    static void Main(){

      // Variáveis
      int numero, i, contador;
      bool Nprimeiros=false;
      bool ateN=false;
      bool primeiroPrimo;

      // Entrada
      Console.Write("Informe número:");
      numero = int.Parse(Console.ReadLine());
      if(numero < 0) numero=(-1)*numero;
      Console.WriteLine("Você prefere que eu imprima os {0} primeiros números primos? (S/N)", numero);
      Nprimeiros = 'S' == char.Parse(Console.ReadLine());
      if(!Nprimeiros){
        Console.WriteLine("Ou você prefere que eu imprima os números primos até {0}? (S/N)", numero);
        ateN = 'S' == char.Parse(Console.ReadLine());
      }

      // Processamento e Saída
      if((!Nprimeiros) && (!ateN)) Console.WriteLine("Nenhuma opção escolhida. Programa encerrando...");
      else{
        if(Nprimeiros){
          Console.WriteLine("{0} primeiros números primos:", numero);
          contador=0;
          i=0;
          do{
            if(ChecaPrimo(i)){
              Console.Write("{0}", i);
              if(contador<numero) Console.Write(", ");
              contador++;
            }
            i++;
          } while(contador<=numero);
          Console.Write("\n");
        }
        else {
          Console.WriteLine("Os números primos até {0}:", numero);
          primeiroPrimo=true;
          for(i=0; i<=numero; i++){
            if(ChecaPrimo(i)){
              if(primeiroPrimo){
                Console.Write("{0}", i);
                primeiroPrimo=false;
              } else Console.Write(", {0}", i);
            }
          }
          Console.Write("\n");
        }
      }

    }

  }

}