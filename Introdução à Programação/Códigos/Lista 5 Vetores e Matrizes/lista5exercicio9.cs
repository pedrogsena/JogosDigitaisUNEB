using System;

namespace Lista5Exercicio9{

  class Program{

    static void Main(){

      // Variáveis

      int[] vetor1 = new int[10];
      int[] vetor2 = new int[10];
      int[] intercalado = new int[20];
      int[] uniao = new int[20];
      int i, j, k, temporario=0, contador, tamanho1=0, tamanho2=0, tamanho_smol, tamanhoBIG;
      bool repetido, negativo, continua;

      // Entrada

      continua = true;
      Console.WriteLine("Insira os valores do primeiro vetor:");
      for(i=0; (i<10) && (continua); i++){
        negativo = true;
        repetido = false;
        while(negativo || repetido){
          Console.Write("vetor1[{0}]: ", i);
          temporario = int.Parse(Console.ReadLine());
          if(temporario > 0){
            negativo = false;
            if(tamanho1 > 0){
              contador=0;
              for(j=0;j<tamanho1;j++){
                if(vetor1[j] != temporario) contador++;
              }
              if (contador == tamanho1) repetido = false;
              else repetido = true;
            }
          }
          if(negativo || repetido){
            if(negativo) Console.WriteLine("Erro! Valor negativo.");
            else if(repetido) Console.WriteLine("Erro! Valor repetido.");
          }
        }
        if(temporario == 999){
          continua = false;
          break;
        } else {
          vetor1[i] = temporario;
          tamanho1++;
        }
      }

      continua = true;
      Console.WriteLine("Insira os valores do segundo vetor:");
      for(i=0; (i<10) && (continua); i++){
        negativo = true;
        repetido = false;
        while(negativo || repetido){
          Console.Write("vetor2[{0}]: ", i);
          temporario = int.Parse(Console.ReadLine());
          if(temporario > 0){
            negativo = false;
            if(tamanho2 > 0){
              contador=0;
              for(j=0;j<tamanho2;j++){
                if(vetor2[j] != temporario) contador++;
              }
              if (contador == tamanho2) repetido = false;
              else repetido = true;
            }
          }
          if(negativo || repetido){
            if(negativo) Console.WriteLine("Erro! Valor negativo.");
            else if(repetido) Console.WriteLine("Erro! Valor repetido.");
          }
        }
        if(temporario == 999){
          continua = false;
          break;
        } else {
          vetor2[i] = temporario;
          tamanho2++;
        }
      }

      // Processamento

      tamanho_smol = 0;
      for (i=0; i < tamanho1; i++){
        for (j=0; j < tamanho2; j++){
          if(vetor1[i] == vetor2[j]){
            intercalado[tamanho_smol] = vetor1[i];
            tamanho_smol++;
            break;
          }
        }
      }

      if(tamanho_smol > 0){
        for (i=0; i < tamanho1; i++){
          uniao[i] = vetor1[i];
        }
        tamanhoBIG = tamanho1;
        for (j=0; j < tamanho2; j++){
          contador=0;
          for (i=0; i < tamanho_smol; i++){
            if (vetor2[j] != intercalado[i]) contador++;
            else break;
          }
          if (contador == tamanho_smol){
            uniao[tamanhoBIG] = vetor2[j];
            tamanhoBIG++;
          }
        }
      } else {
        tamanhoBIG = tamanho1 + tamanho2;
        for(k=0; k < tamanhoBIG; k++){
          if (k < tamanho1) uniao[k] = vetor1[k];
          else uniao[k] = vetor2[k-tamanho1];
        }
      }

      // Saída

      if(tamanho_smol == 0) Console.WriteLine("Não existe interseção.");
      else{
        Console.WriteLine("Intercalação:");
        for(k=0;k<tamanho_smol;k++){
          Console.Write(intercalado[k]);
          if(k<(tamanho_smol-1)) Console.Write(", ");
        }
        Console.Write("\n");
      }

      if(tamanhoBIG == 0) Console.WriteLine("Não existe união.");
      else {
        Console.WriteLine("União:");
        for(k=0;k<tamanhoBIG;k++){
          Console.Write(uniao[k]);
          if(k<(tamanhoBIG-1)) Console.Write(", ");
        }
        Console.Write("\n");
      }

    }

  }

}