using System;

namespace Lista4Exercicio4{

  class Program{

    // Função Fatorial Versão Iterativa

    static ulong FatorialIterativo(int numero){
      ulong myNumero = Convert.ToUInt64(numero);
      if (myNumero > 1){
        ulong fat = myNumero;
        while (myNumero > 2){
          myNumero--;
          fat*=myNumero;
        }
        return fat;
      } else return 1;
    }

    // Função Fatorial Versão Recursiva

    static ulong FatorialRecursivo(int numero){
      ulong myNumero = Convert.ToUInt64(numero);
      if (myNumero >1){
        return myNumero*FatorialRecursivo(numero-1);
      } else return 1;
    }

    static void Main(){

      // Variáveis
      int numero;
      ulong fat;
      bool usaVersaoRecursiva=true;

      // Entrada

      // Processamento

      // Saída

      for(numero=1; numero<=15; numero++){
        if(usaVersaoRecursiva){
          fat = FatorialRecursivo(numero);
        } else {
          fat = FatorialIterativo(numero);
        }
        Console.WriteLine("{0}! = {1}", numero, fat);
      }

    }

  }

}