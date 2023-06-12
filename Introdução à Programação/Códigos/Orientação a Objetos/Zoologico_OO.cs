/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;
namespace HelloWorld
{
    
    public abstract class Animal
    {
        
        protected string nome;
        
        public Animal(string novonome)
        {
            this.nome = novonome;
        }
        
        ~Animal()
        {
            
        }
        
        public string getNome()
        {
            return this.nome;
        }
        
        public void setNome(string novonome)
        {
            this.nome = novonome;
        }

        public abstract void Acordar();
        public abstract void Comer();
        public abstract void Dormir();
        public abstract void Soar();
        
    }
    
    public class Mamifero:Animal
    {
        
        public Mamifero(string novonome):base(novonome)
        {
            
        }
        
        public override void Acordar()
        {
            Console.WriteLine("{0} acordou!", this.getNome());
        }

        public override void Comer()
        {
            Console.WriteLine("{0} está comendo.", this.getNome());
        }

        public override void Dormir()
        {
            Console.WriteLine("{0} foi dormir.", this.getNome());
        }
        
        public override void Soar()
        {
            Console.WriteLine("O mamífero faz o seu som característico.");
        }

        public void Mamar()
        {
            Console.WriteLine("{0} está mamando.", this.getNome());
        }
        
    }
    
    public class Ave:Animal
    {
        
        public Ave(string novonome):base(novonome)
        {
            
        }
        
        public override void Acordar()
        {
            Console.WriteLine("{0} acordou!", this.getNome());
        }

        public override void Comer()
        {
            Console.WriteLine("{0} está comendo.", this.getNome());
        }

        public override void Dormir()
        {
            Console.WriteLine("{0} foi dormir.", this.getNome());
        }
        
        public override void Soar()
        {
            Console.WriteLine("A ave faz o seu som característico.");
        }

        public void BotarOvo()
        {
            Console.WriteLine("{0} botou um ovo!", this.getNome());
        }
        
        public void Voar()
        {
            Console.WriteLine("{0} está voando.", this.getNome());
        }

    }

    public class Galinha:Ave
    {
        
        public Galinha(string novonome):base(novonome)
        {
            
        }
        
        public override void Soar()
        {
            Console.WriteLine("{0} faz CÓ-CÓ-RI-CÓ!", this.getNome());
        }

    }

    public class Cachorro:Mamifero
    {
        
        public Cachorro(string novonome):base(novonome)
        {
            
        }
        
        public override void Soar()
        {
            Console.WriteLine("{0} faz WOOF!", this.getNome());
        }

    }

    public class Porco:Mamifero
    {
        
        public Porco(string novonome):base(novonome)
        {
            
        }
        
        public override void Soar()
        {
            Console.WriteLine("{0} faz OINC!", this.getNome());
        }

    }

    public class Morcego:Mamifero
    {
        
        public Morcego(string novonome):base(novonome)
        {
            
        }
        
        public override void Soar()
        {
            Console.WriteLine("{0} faz SKREEE!", this.getNome());
        }

        public void Voar()
        {
            Console.WriteLine("{0} está voando.", this.getNome());
        }
        
    }
    
    public class Baleia:Mamifero
    {
        
        public Baleia(string novonome):base(novonome)
        {
            
        }

        public override void Soar()
        {
            Console.WriteLine("{0} faz UUUOOO!", this.getNome());
        }

        public void Nadar()
        {
            Console.WriteLine("{0} está nadando.", this.getNome());
        }
        
    }
    
    public class Programa
    {
        
        static void Main() {
            
            Baleia azul = new Baleia("Azul");
            Morcego wayne = new Morcego("Bruce");
            Cachorro cerbero = new Cachorro("Cérbero");
            Porco rosso = new Porco("Marco");
            Galinha merilu = new Galinha("Merilú");
            
            azul.Acordar();
            azul.Mamar();
            azul.Comer();
            azul.Nadar();
            azul.Soar();
            azul.Dormir();

            Console.Write("\n");

            wayne.Acordar();
            wayne.Mamar();
            wayne.Comer();
            wayne.Voar();
            wayne.Soar();
            wayne.Dormir();
            
            Console.Write("\n");

            cerbero.Acordar();
            cerbero.Mamar();
            cerbero.Comer();
            cerbero.Soar();
            cerbero.Dormir();
            
            Console.Write("\n");

            rosso.Acordar();
            rosso.Mamar();
            rosso.Comer();
            rosso.Soar();
            rosso.Dormir();
            
            Console.Write("\n");

            merilu.Acordar();
            merilu.Comer();
            merilu.BotarOvo();
            merilu.Voar();
            merilu.Soar();
            merilu.Dormir();
            
        }
        
    }

}