using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Lista6Exercicio1
{

  class Program
  {

    // Módulos aqui!

    static readonly string entrada = "BancoDadosFuncionarios.txt";

    public struct Funcionario
    {
      public string Inscricao;
      public string Nome;
      public char Classe;
      public int HorasNormais;
      public int HorasExtras;

      public Funcionario(string inscricao, string nome, char classe, int horasNormais, int horasExtras)
      {
        this.Inscricao = inscricao;
        this.Nome = nome;
        this.Classe = classe;
        this.HorasNormais = horasNormais;
        this.HorasExtras = horasExtras;
      }
    }

    public struct Salarios
    {
      public double SalarioHorasNormais;
      public double SalarioHorasExtras;
      public double SalarioBruto;
      public double DeducaoINSS;
      public double SalarioLiquido;

      public Salarios(double salarioHorasNormais, double salarioHorasExtras, double salarioBruto, double deducaoINSS, double salarioLiquido)
      {
        this.SalarioHorasNormais = salarioHorasNormais;
        this.SalarioHorasExtras = salarioHorasExtras;
        this.SalarioBruto = salarioBruto;
        this.DeducaoINSS = deducaoINSS;
        this.SalarioLiquido = salarioLiquido;
      }
    }

    static void Contracheque()
    {
      List<Funcionario> BancoDados = new List<Funcionario>();
      CarregarListaFuncionarios(ref BancoDados);
      string Identificador = LerEntrada();
      Funcionario func = new Funcionario("__________","_",'_',0,0);
      EncontrarFuncionario(BancoDados, ref func, Identificador);
      Salarios sal = new Salarios(0,0,0,0,0);
      CalcularSalarios(func, ref sal);
      MontarContracheque(func, sal);
    }

    static void CarregarListaFuncionarios(ref List<Funcionario> BancoDados)
    {
      string[] stringBancoDados = File.ReadAllLines(entrada);
      int qteFuncionarios = stringBancoDados.Length / 5;
      int indiceBD, indiceArquivo;
      indiceArquivo=0;
      for(indiceBD=0; indiceBD < qteFuncionarios; indiceBD++){
        Funcionario func = new Funcionario(stringBancoDados[indiceArquivo], stringBancoDados[indiceArquivo+1], Convert.ToChar(stringBancoDados[indiceArquivo+2]), Convert.ToInt32(stringBancoDados[indiceArquivo+3]), Convert.ToInt32(stringBancoDados[indiceArquivo+4]));
        BancoDados.Add(func);
        indiceArquivo+=5;
      }
    }

    static string LerEntrada()
    {
      Console.WriteLine("Informe nome completo ou número de inscrição do funcionário.");
      string Identificador = Console.ReadLine();
      return Identificador;
    }

    static void EncontrarFuncionario(List<Funcionario> BancoDados, ref Funcionario myfunc, string Identificador)
    {
      // Problema: e se houver mais de um funcionário com o mesmo nome completo? Espera-se que eles tenham números de inscrição diferentes.
      foreach(Funcionario funcionario in BancoDados){
        if((Identificador == funcionario.Inscricao) || (Identificador == funcionario.Nome)){
          myfunc.Inscricao = funcionario.Inscricao;
          myfunc.Nome = funcionario.Nome;
          myfunc.Classe = funcionario.Classe;
          myfunc.HorasNormais = funcionario.HorasNormais;
          myfunc.HorasExtras = funcionario.HorasExtras;
          break;
        }
      }
    }

    static void CalcularSalarios(Funcionario func, ref Salarios mysal)
    {
      double SalarioHoraReferencia = 7.5;
      double adicionalHorasExtras = 0.3;
      double percentualINSS = 0.11;
      double modificadorClasse;
      if(func.Classe == '1') modificadorClasse = 1.3;
      else modificadorClasse = 1.9;

      mysal.SalarioHorasNormais = 4 * modificadorClasse * Convert.ToDouble(func.HorasNormais) * SalarioHoraReferencia;
      mysal.SalarioHorasExtras = modificadorClasse * Convert.ToDouble(func.HorasExtras) * SalarioHoraReferencia * (1 + adicionalHorasExtras);
      mysal.SalarioBruto = mysal.SalarioHorasNormais + mysal.SalarioHorasExtras;
      mysal.DeducaoINSS = mysal.SalarioBruto * percentualINSS;
      mysal.SalarioLiquido = mysal.SalarioBruto - mysal.DeducaoINSS;
    }

    static void MontarContracheque(Funcionario func, Salarios sal)
    {
      Console.WriteLine("Número de Inscrição: {0}", func.Inscricao);
      Console.WriteLine("Nome: {0}", func.Nome);
      Console.WriteLine("Salário Horas Normais: R$ {0}", Math.Round(sal.SalarioHorasNormais,2));
      Console.WriteLine("Salário Horas Extras: R$ {0}", Math.Round(sal.SalarioHorasExtras,2));
      Console.WriteLine("Dedução INSS: R$ {0}", Math.Round(sal.DeducaoINSS,2));
      Console.WriteLine("Salário Líquido: R$ {0}", Math.Round(sal.SalarioLiquido,2));
    }

    static void Main()
    {

      // Variáveis

      // Entrada

      // Processamento

      Contracheque();

      // Saída

    }

  }

}
