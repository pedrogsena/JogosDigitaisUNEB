using System;

namespace Lista5Exercicio4{

  class Program{

    static void Main(){

      // Variáveis
      int[] VET1 = new int[10];
      int[] VET2 = new int[10];
      int[] VET3 = new int[20];
      int i, j, k, temporario;

      // Entrada
      Console.WriteLine("Aviso: você vai inserir valores de dois vetores de 10 casas cada.\nPara cada vetor, os valores devem estar em ordem crescente.\nO resultado será um terceiro vetor, de 20 casas, que resultará\n da intercalação dos dois primeiros vetores.");
      Console.WriteLine("Insira os valores do primeiro vetor:");
      for(i=0;i<10;i++){
        Console.Write("VET1[{0}]: ", i);
        temporario = int.Parse(Console.ReadLine());
        if(i == 0) VET1[i] = temporario;
        else{
          while (temporario < VET1[i-1]){
            Console.WriteLine("Erro! Valor menor que o anterior.");
            Console.Write("VET1[{0}]: ", i);
            temporario = int.Parse(Console.ReadLine());
          }
          VET1[i] = temporario;
        }
      }
      Console.WriteLine("Insira os valores do segundo vetor:");
      for(j=0;j<10;j++){
        Console.Write("VET2[{0}]: ", j);
        temporario = int.Parse(Console.ReadLine());
        if(j == 0) VET2[j] = temporario;
        else{
          while (temporario < VET2[j-1]){
            Console.WriteLine("Erro! Valor menor que o anterior.");
            Console.Write("VET2[{0}]: ", j);
            temporario = int.Parse(Console.ReadLine());
          }
          VET2[j] = temporario;
        }
      }
      
      // Processamento
      i=0;
      j=0;
      for (k=0;k<20;k++){
        if (i < 10 && j < 10){
          if(VET1[i] < VET2[j]){
            VET3[k] = VET1[i];
            i++;
          } else {
            VET3[k] = VET2[j];
            j++;
          }
        } else {
          if (i == 10){
            VET3[k] = VET2[j];
            j++;
          } else if (j == 10){
            VET3[k] = VET1[i];
            i++;
          }
        }
      }

      // Saída
      Console.WriteLine("Vetor intercalado:");
      for(k=0;k<20;k++){
        Console.Write(VET3[k]);
        if(k<19) Console.Write(", ");
      }
      Console.Write("\n");

    }

  }

}