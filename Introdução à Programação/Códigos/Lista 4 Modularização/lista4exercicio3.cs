using System;

namespace Lista4Exercicio3{

  class Program{

    static bool ChecaData(int dia, int mes, int ano){
      bool dataValida = true;
      if(ano == 0) dataValida = false;
      else {
        if((mes < 1) || (mes > 12)) dataValida = false;
        else {
          if(dia < 1) dataValida = false;
          else {
            bool mes31 = (mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12);
            if(mes31){
              if(dia > 31) dataValida = false;
            } else {
              bool mes30 = (mes == 4) || (mes == 6) || (mes == 9) || (mes == 11);
              if(mes30){
                if(dia > 30) dataValida = false;
              } else { // É fevereiro...
                bool anoBissexto = (ano%4 == 0) && ((ano%100 != 0) || (ano%400 == 0));
                if(anoBissexto){
                  if(dia > 29) dataValida = false;
                } else {
                  if(dia > 28) dataValida = false;
                }
              }
            }
          }
        }
      }
      return dataValida;
    }

    static void Main(){

      // Variáveis
      int dia, mes, ano;
      bool dataOK;

      // Entrada
      Console.WriteLine("Informe uma data a seguir.");
      Console.Write("Dia: ");
      dia = int.Parse(Console.ReadLine());
      Console.Write("Mês: ");
      mes = int.Parse(Console.ReadLine());
      Console.Write("Ano: ");
      ano = int.Parse(Console.ReadLine());

      // Processamento
      dataOK = ChecaData(dia, mes, ano);

      // Saída
      if(!dataOK) Console.WriteLine("Data informada inválida.");
      else{
        Console.Write("A data informada, de {0}/{1}/", dia, mes);
        if(ano < 0) Console.Write("{0} a.C.", (-1)*ano);
        else Console.Write("{0} A.D.", ano);
        Console.Write(", é válida.\n");
      }

    }

  }

}