using System;
using System.IO;

namespace Lista5Exercicio8{

  class Program{

    static readonly string entrada = "L5E8_entrada.txt";

    static void Main(){

      // Variáveis
      string[] stringVotos = new string[100];
      int[] votos = new int[100];
      int[] qteVotos = new int[10];
      int[] maisVotados = new int[10];
      int i, j, tamanho, maiorVotacao=0, numeroCandidatoMaisVotado=0;
      bool segundoturno=false;

      // Entrada
      stringVotos = File.ReadAllLines(entrada);

      // Processamento
      for(i=0; i<10; i++){
        qteVotos[i] = 0;
        maisVotados[i] = 0;
      }
      for(i=0; i<100; i++){
        votos[i] = int.Parse(stringVotos[i]);
        qteVotos[votos[i]-1]++;
      }
      for(i=0; i<10; i++){
        if(qteVotos[i] > maiorVotacao){
          maiorVotacao = qteVotos[i];
          numeroCandidatoMaisVotado = i+1;
        }
      }
      tamanho=1;
      maisVotados[tamanho-1] = numeroCandidatoMaisVotado;
      for(i=0; i<10; i++){
        if((qteVotos[i] == maiorVotacao) && (i != (numeroCandidatoMaisVotado-1))){
          segundoturno = true;
          tamanho++;
          maisVotados[tamanho-1] = i+1;
        }
      }

      // Saída
      Console.WriteLine("Resultado do pleito!");
      for(i=0; i<10; i++){
        Console.WriteLine("Candidato {0} recebeu {1} voto(s).", i+1, qteVotos[i]);
      }
      if(!segundoturno) Console.WriteLine("Candidato {0} foi o mais votado!", numeroCandidatoMaisVotado);
      else{
        Console.Write("Houve empate e haverá segundo turno entre os candidatos ");
        for(j=0; j<tamanho; j++){
          Console.Write("{0}", maisVotados[j]);
          if(tamanho == 2){
            if(j == 0) Console.Write(" e ");
            else Console.Write(".\n");
          } else {
            if(j < (tamanho-2)) Console.Write(", ");
            else if (j == (tamanho-2)) Console.Write(" e ");
            else Console.Write(".\n");
          }
        }
      }

    }

  }

}