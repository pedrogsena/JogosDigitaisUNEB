using System;

namespace Lista4Exercicio1{

  class Program{

    // Módulo Raízes Equação Segundo Grau

    static int equacao2Grau(double A, double B, double C, ref double x1, ref double x2){
      int STATUS;
      double delta = B*B - 4*A*C;
      if(delta < 0){
        x1 = 0;
        x2 = 0;
        STATUS = 0;
      }
      else if (delta == 0){
        x1 = (-1)*B / (2*A);
        x2 = 0;
        STATUS = 1;
      }
      else{
        x1 = (-1)*B + Math.Sqrt(delta);
        x1 = x1 / (2*A);
        x2 = (-1)*B - Math.Sqrt(delta);
        x2 = x2 / (2*A);
        STATUS = 2;
      }
      return STATUS;
    }

    static void Main(){

      // Variáveis
      double A, B, C, x1=0, x2=0;
      int qteRaizes;

      // Entrada
      Console.WriteLine("Insira os coeficientes da equação Ax²+Bx+C=0:");
      Console.Write("A= ");
      A = double.Parse(Console.ReadLine());
      Console.Write("B= ");
      B = double.Parse(Console.ReadLine());
      Console.Write("C= ");
      C = double.Parse(Console.ReadLine());

      // Processamento
      qteRaizes = equacao2Grau(A, B, C, ref x1, ref x2);

      // Saída
      if(qteRaizes == 0) Console.WriteLine("A equação não possui raízes reais.");
      else if(qteRaizes == 1) Console.WriteLine("A equação possui uma raiz real dupla, igual a {0}.", x1);
      else Console.WriteLine("A equação possui duas raízes reais, iguais a {0} e {1}.", x1, x2);

    }

  }

}