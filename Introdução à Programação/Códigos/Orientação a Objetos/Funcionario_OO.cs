/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;

namespace ProjetoMeusFuncionarios
{ 
  
  public class Funcionario
  {
    /*Requisitos*/
    private string nome;
    private string CPF;
    private string telefone;
    private string endereco;
    private double salario;
    
    /*Construtor*/
    Funcionario(string nome, string CPF, string telefone, string endereco, double salario)
    {
        this.nome = nome;
        this.CPF = CPF;
        this.telefone = telefone;
        this.endereco = endereco;
        this.salario = salario;
    }
    
    /*Destrutor*/
    ~Funcionario()
    {
        
    }
    
    /*Métodos Get*/
    public string getNome(){return nome;}
    public string getCPF(){return CPF;}
    public string getTelefone(){return telefone;}
    public string getEndereco(){return endereco;}
    public double getSalario(){return salario;}
    
    /*Métodos Set*/
    public void setNome(string nome){this.nome = nome;}
    public void setCPF(string CPF){this.CPF = CPF;}
    public void setTelefone(string telefone){this.telefone = telefone;}
    public void setEndereco(string endereco){this.endereco = endereco;}
    public void setSalario(double salario){this.salario = salario;}
    
    /*Método ImprimirDados*/
    public void ImprimirDados()
    {
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("CPF: {0}", CPF);
        Console.WriteLine("Tel.: {0}", telefone);
        Console.WriteLine("End.: {0}", endereco);
        Console.WriteLine("Sal.: R$ {0}", Math.Round(salario,2));
    }
    
   public static void Main()
   {
      Funcionario jose_rocha = new Funcionario("José Rocha", "112.233.345-79", "(71)98776-5544", "Rua do Ourives, 77, Nazaré, Salvador", 6987.23);
      jose_rocha.ImprimirDados();

   }/*main*/

  }/*class Funcionario*/

}/*namespace*/