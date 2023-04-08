using System;

namespace Lista4Exercicio5{

  class Program{

    /* Versão iterativa; a versão recursiva fica como exercício ao leitor. */
    
    static long Potencia(int baseNum, int expoente){
      long myBase = Convert.ToInt64(baseNum);
      long resposta=1;
      bool inverte=(expoente < 0);
      if(expoente != 0){
        if (inverte) expoente = (-1)*expoente;
        while(expoente > 0){
          resposta*=myBase;
          expoente--;
        }
        if(inverte) resposta = 1/resposta;
      }
      return resposta;
    }

    static void Main(){

      // Variáveis
      int baseNum, expoente;
      long pot;

      // Entrada

      // Processamento

      // Saída
      for(baseNum=2; baseNum <= 20; baseNum++){
        for(expoente=1; expoente <= 10; expoente++){
          pot=Potencia(baseNum, expoente);
          Console.WriteLine("{0}^{1} = {2}", baseNum, expoente, pot);
        }
      }

    }

  }

}