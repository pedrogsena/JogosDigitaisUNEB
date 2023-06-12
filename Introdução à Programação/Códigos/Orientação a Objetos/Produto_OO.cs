/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;

namespace ProjetoProduto
{ 
  public class Produto
  {
    /*Atributos*/
    private string nome;
    private double preco;
    private int quantidade;
    
    /*Construtor*/
    Produto(string nome, double preco, int quantidade)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
    }
    
    /*Destrutor*/
    ~Produto()
    {
        
    }
    
    /*Gets and Sets*/
    public string getNome(){return nome;}
    public double getPreco(){return preco;}
    public int getQuantidade(){return quantidade;}
    public void setNome(string nome){this.nome = nome;}
    public void setPreco(double preco){this.preco = preco;}
    public void setQuantidade(int quantidade){this.quantidade = quantidade;}
    
    /*Método*/
    public double calcularValorTotal()
    {
        if(this.quantidade > 50) return Math.Round((this.preco * Convert.ToDouble(this.quantidade) * 0.75),2);
        else if(this.quantidade > 20) return Math.Round((this.preco * Convert.ToDouble(this.quantidade) * 0.8),2);
        else if(this.quantidade > 10) return Math.Round((this.preco * Convert.ToDouble(this.quantidade) * 0.9),2);
        else return Math.Round((this.preco * Convert.ToDouble(this.quantidade)),2);
    }
    
    public static void Main()
    {

      /*TODO*/
      Produto leite = new Produto("leite", 8.29, 23);
      Produto margarina = new Produto("margarina", 12.39, 18);
      Produto Nescau = new Produto("Nescau", 11.59, 7);
      Produto picanha = new Produto("picanha", 0.11999, 568);
      
      Console.WriteLine("Preços totais:");
      Console.WriteLine("Total de {0} é R$ {1}.", leite.getNome(), leite.calcularValorTotal());
      Console.WriteLine("Total de {0} é R$ {1}.", margarina.getNome(), margarina.calcularValorTotal());
      Console.WriteLine("Total de {0} é R$ {1}.", Nescau.getNome(), Nescau.calcularValorTotal());
      Console.WriteLine("Total de {0} é R$ {1}.", picanha.getNome(), picanha.calcularValorTotal());


    }/*main*/

   }/*class Produto*/

}/*namespace*/