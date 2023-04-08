using System;
using System.IO;

namespace Lista4Exercicio9{

  class Program{

    static readonly string entrada_nome = "L4E9_entrada_nome.txt";
    static readonly string entrada_sexo = "L4E9_entrada_sexo.txt";
    static readonly string entrada_altura = "L4E9_entrada_altura.txt"; // em m
    static readonly string entrada_peso = "L4E9_entrada_peso.txt"; // em kg

    static void ModuloL4E9(string[] listaNomes, char[] listaSexos, double[] listaAlturas, double[] listaPesos, int tamanho){
      int i, qteHomens=0, qteMulheres=0;
      string nomeHomemMaiorAltura="", nomeMulherMaiorPeso="";
      double mediaAlturaHomens=0, mediaPesoMulheres=0, maiorAlturaHomens=0, maiorPesoMulheres=0;

      for(i=0; i < tamanho; i++){
        if(listaSexos[i] == 'M'){
          qteHomens++;
          mediaAlturaHomens+=listaAlturas[i];
          if(listaAlturas[i] > maiorAlturaHomens){
            maiorAlturaHomens = listaAlturas[i];
            nomeHomemMaiorAltura = listaNomes[i];
          }
        } else if(listaSexos[i] == 'F'){
          qteMulheres++;
          mediaPesoMulheres+=listaPesos[i];
          if(listaPesos[i] > maiorPesoMulheres){
            maiorPesoMulheres = listaPesos[i];
            nomeMulherMaiorPeso = listaNomes[i];
          }
        }
      }
      mediaAlturaHomens = mediaAlturaHomens / Convert.ToDouble(qteHomens);
      mediaPesoMulheres = mediaPesoMulheres / Convert.ToDouble(qteMulheres);

      Console.WriteLine("Média de altura entre os homens: {0} m.", Math.Round(mediaAlturaHomens,2));
      Console.WriteLine("Média de peso entre as mulheres: {0} kg.", Math.Round(mediaPesoMulheres,1));
      Console.WriteLine("Homem com maior altura: {0}.", nomeHomemMaiorAltura);
      Console.WriteLine("Mulher com maior peso: {0}.", nomeMulherMaiorPeso);
    }

    static void Main(){

      // Variáveis
      int i, tamanhoGrupo=10;
      string[] nomesGrupo = new string[10];
      char[] sexosGrupo = new char[10];
      double[] alturasGrupo = new double[10];
      double[] pesosGrupo = new double[10];
      string[] stringSexosGrupo = new string[10];
      string[] stringAlturasGrupo = new string[10];
      string[] stringPesosGrupo = new string[10];

      // Entrada
      
      nomesGrupo = File.ReadAllLines(entrada_nome);
      stringSexosGrupo = File.ReadAllLines(entrada_sexo);
      stringAlturasGrupo = File.ReadAllLines(entrada_altura);
      stringPesosGrupo = File.ReadAllLines(entrada_peso);

      for(i=0; i < tamanhoGrupo; i++){
        sexosGrupo[i] = char.Parse(stringSexosGrupo[i]);
        alturasGrupo[i] = double.Parse(stringAlturasGrupo[i]);
        pesosGrupo[i] = double.Parse(stringPesosGrupo[i]);
      }

      // Processamento e Saída
      
      ModuloL4E9(nomesGrupo, sexosGrupo, alturasGrupo, pesosGrupo, tamanhoGrupo);

    }

  }

}