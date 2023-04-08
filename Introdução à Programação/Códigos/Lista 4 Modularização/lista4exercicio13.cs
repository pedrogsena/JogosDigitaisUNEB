using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Lista4Exercicio13{

  class Program{

    static readonly string mat045 = "MAT045_Matriculas.txt";
    static readonly string mat037 = "MAT037_Matriculas.txt";

    // Módulos aqui!

    static void ModuloL4E13(ArrayList matriculas1, ArrayList matriculas2, ArrayList matriculas3){
      LerMatriculas(matriculas1, matriculas2);
      ObterMatriculasEmComum(matriculas1, matriculas2, matriculas3);
      ImprimirMatriculasEmComum(matriculas3);
    }

    static void LerMatriculas(ArrayList matriculas1, ArrayList matriculas2){
      string[] matriculasTemp1 = File.ReadAllLines(mat045);
      foreach(string matricula in matriculasTemp1){
        if(matricula != "999") matriculas1.Add(matricula);
      }
      string[] matriculasTemp2 = File.ReadAllLines(mat037);
      foreach(string matricula in matriculasTemp2){
        if(matricula != "999") matriculas2.Add(matricula);
      }
    }

    static void ObterMatriculasEmComum(ArrayList matriculas1, ArrayList matriculas2, ArrayList matriculas3){
      foreach(string matricula in matriculas1){
        if(matriculas2.Contains(matricula)) matriculas3.Add(matricula);
      }
    }

    static void ImprimirMatriculasEmComum(ArrayList matriculas3){
      Console.WriteLine("Alunos matriculados nas duas disciplinas:");
      foreach(string matricula in matriculas3) Console.WriteLine("{0}", matricula);
    }

    static void Main(){

      // Variáveis

      ArrayList matriculasMAT045 = new ArrayList();
      ArrayList matriculasMAT037 = new ArrayList();
      ArrayList matriculasEmComum = new ArrayList();

      ModuloL4E13(matriculasMAT045, matriculasMAT037, matriculasEmComum);

    }

  }

}