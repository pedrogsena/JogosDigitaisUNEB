/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;
namespace SempreEmForma {
  class Pessoa {
    
    /*Atributos, com Métodos Get e Set*/
    private string nome;
    private int peso;
    private double altura;
    
    /*Construtor*/
    Pessoa(string nome, int peso, double altura)
    {
      this.nome = nome;
      this.peso = peso;
      this.altura = altura;
    }
    
    /*Destrutor*/
    ~Pessoa()
    {
        
    }
    
    /*Get Set*/
    public string getnome(){return nome;}
    public int getpeso(){return peso;}
    public double getaltura(){return altura;}
    public void setnome(string nome){this.nome = nome;}
    public void setpeso(int peso){this.peso = peso;}
    public void setaltura(double altura){this.altura = altura;}
    
    /*Método IMC*/
    public double IMC()
    {
      return (Convert.ToDouble(peso))/(altura*altura);
    }
    
    /*Método AvaliarIMC*/
    public void AvaliarIMC()
    {
      if(IMC() < 18.5) Console.WriteLine("IMC baixo.");
      else if(IMC() >= 25) Console.WriteLine("IMC alto.");
      else Console.WriteLine("IMC normal.");
    }
    
    /*Método AumentarPeso*/
    public void AumentarPeso(int novopeso)
    {
        if(novopeso <= 0) Console.WriteLine("ERRO! Peso inválido.");
        else if(novopeso > peso){
            setpeso(novopeso);
            Console.WriteLine("Peso atualizado.");
        }
        else Console.WriteLine("ERRO! Peso informado menor que o atual.");
    }
    
    /*Método ReduzirPeso*/
    public void ReduzirPeso(int novopeso)
    {
        if(novopeso <= 0) Console.WriteLine("ERRO! Peso inválido.");
        else if(novopeso < peso){
            setpeso(novopeso);
            Console.WriteLine("Peso atualizado.");
        }
        else Console.WriteLine("ERRO! Peso informado maior que o atual.");
    }
    
    static void Main()
    {

//      Pessoa mario = new Pessoa("Mario", 62, 1.55);
//      Console.WriteLine("Nome: {0}", mario.getnome());
//      Console.WriteLine("Peso: {0} kg", mario.getpeso());
//      Console.WriteLine("Altura: {0} m", mario.getaltura());
//      Console.WriteLine("IMC: {0}", mario.IMC());

      string nome="";
      int peso=0;
      double altura=0.0;
      int novopeso=0;
      
      /*Entrada*/
      
      Console.Write("Nome: ");
      nome = Console.ReadLine();
      Console.Write("Peso (kg): ");
      peso = int.Parse(Console.ReadLine());
      Console.Write("Altura (m): ");
      altura = double.Parse(Console.ReadLine());
      
      Pessoa novapessoa = new Pessoa (nome, peso, altura);

      Console.WriteLine("Nome: {0}", novapessoa.getnome());
      Console.WriteLine("Peso: {0} kg", novapessoa.getpeso());
      Console.WriteLine("Altura: {0} m", novapessoa.getaltura());
      Console.WriteLine("IMC: {0}", novapessoa.IMC());
      novapessoa.AvaliarIMC();
      if(novapessoa.IMC()>25)
      {
          do
          {
            Console.Write("Informe novo peso (kg): ");
            novopeso = int.Parse(Console.ReadLine());
          }
          while(novopeso > novapessoa.getpeso());
          novapessoa.ReduzirPeso(novopeso);
          Console.WriteLine("Novo IMC = {0}", novapessoa.IMC());
          novapessoa.AvaliarIMC();
      }
      else if(novapessoa.IMC()<18.5)
      {
          do
          {
            Console.Write("Informe novo peso (kg): ");
            novopeso = int.Parse(Console.ReadLine());
          }
          while(novopeso < novapessoa.getpeso());
          novapessoa.AumentarPeso(novopeso);
          Console.WriteLine("Novo IMC = {0}", novapessoa.IMC());
          novapessoa.AvaliarIMC();
      }

    }
  }
}
