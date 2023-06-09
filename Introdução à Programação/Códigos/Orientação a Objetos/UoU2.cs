/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;
namespace UoU
{
    public class Magia
    {
        public string nome { get; set; }
        public int custoUT { get; set; }
        public int dano { get; set; }
        
        public Magia(string nome, int custoUT, int dano)
        {
            this.nome = nome;
            this.custoUT = custoUT;
            this.dano = dano;
        }
        
        ~Magia()
        {
            
        }
        
        public int Lancar()
        {
            return dano;
        }
    }
    
    public class Arma
    {
        public string nome { get; set; }
        public int custoUT { get; set; }
        public int dano { get; set; }
        
        public Arma(string nome, int custoUT, int dano)
        {
            this.nome = nome;
            this.custoUT = custoUT;
            this.dano = dano;
        }
        
        ~Arma()
        {
            
        }
        
        public int Atacar()
        {
            return dano;
        }
    }
    
    public abstract class Heroi
    {
        public string nome;
        public int UTHeroi;
        public int pontosVida;
        public Magia magiaHeroi;
        public Arma armaHeroi;
        
        public Heroi(string nome, int PVs)
        {
            this.nome = nome;
            this.UTHeroi = 7;
            this.pontosVida = PVs;
            this.magiaHeroi = new Magia("",0,0);
            this.armaHeroi = new Arma("",0,0);
        }
        
        ~Heroi()
        {
            
        }
        
        public string getNome()
        {
            return nome;
        }
        
        public int getUTHeroi()
        {
            return UTHeroi;
        }
        
        public int getPontosVida()
        {
            return pontosVida;
        }
        
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public void setUTHeroi(int UTHeroi)
        {
            this.UTHeroi = UTHeroi;
        }
        
        public void setPontosVida(int PVs)
        {
            this.pontosVida = PVs;
        }
        
        public virtual void LancarMagia(Heroi alvo)
        {
            if (UTHeroi>=magiaHeroi.custoUT)
            {
                magiaHeroi.Lancar();
                alvo.ReduzirPontosVida(magiaHeroi.dano);
                for(int i=0; i<magiaHeroi.custoUT; ++i) ReduzirUT();
                Console.WriteLine("Você conjurou {0} em {1}! Dano de {2} pontos! {1} está com {3} pontos de vida!", magiaHeroi.nome, alvo.nome, magiaHeroi.dano, alvo.pontosVida);
            }
            else Console.WriteLine("Você tentou conjurar {0}, mas falhou!", magiaHeroi.nome);
        }

        public virtual void AtacarComArma(Heroi alvo)
        {
            if (UTHeroi>=armaHeroi.custoUT)
            {
                armaHeroi.Atacar();
                alvo.ReduzirPontosVida(armaHeroi.dano);
                for(int i=0; i<armaHeroi.custoUT; ++i) ReduzirUT();
                Console.WriteLine("Você atacou {1} com {0}! Dano de {2} pontos! {1} está com {3} pontos de vida!", armaHeroi.nome, alvo.nome, armaHeroi.dano, alvo.pontosVida);
            }
            else Console.WriteLine("Você tentou atacar {1} com {0}, mas falhou!", armaHeroi.nome, alvo.nome);
        }
        
        public virtual void AumentarUT()
        {
            ++this.UTHeroi;
        }
        
        public virtual void ReduzirUT()
        {
            --this.UTHeroi;
        }

        public virtual void AumentarPontosVida(int acrescimo)
        {
            if(acrescimo>0)
            {
                int PVs = getPontosVida();
                setPontosVida(PVs+acrescimo);
            }
        }
        
        public virtual void ReduzirPontosVida(int reducao)
        {
            if(reducao>0)
            {
                int PVs = getPontosVida();
                setPontosVida(PVs-reducao);
            }
        }
    }
    
    public class HeroiAlianca:Heroi
    {
        public HeroiAlianca(string nome, int PVs):base(nome, PVs)
        {
            this.magiaHeroi = new Magia("Força Rutilante", 4, 20);
            this.armaHeroi = new Arma("Espada", 2, 10);
        }
        
        public new void AumentarPontosVida(int acrescimo)
        {
            if(acrescimo>0)
            {
                int PVs = getPontosVida();
                double bonus = 0.2;
                int novosPVs = Convert.ToInt32(Convert.ToDouble(PVs+acrescimo)*(1+bonus));
                setPontosVida(novosPVs);
            }
        }

        public override void LancarMagia(Heroi alvo)
        {
            base.LancarMagia(alvo);
            Console.WriteLine("Pela Luz Sagrada!");
        }

        public override void AtacarComArma(Heroi alvo)
        {
            base.AtacarComArma(alvo);
            Console.WriteLine("Pela Aliança!");
        }
    }
    
    public class HeroiHorda:Heroi
    {
        public HeroiHorda(string nome, int PVs):base(nome, PVs)
        {
            this.magiaHeroi = new Magia("Caminho de Chamas", 6, 30);
            this.armaHeroi = new Arma("Machado", 4, 20);
        }
        
        public new void ReduzirPontosVida(int reducao)
        {
            if(reducao>0)
            {
                int PVs = getPontosVida();
                double bonus = 0.2;
                int novosPVs = Convert.ToInt32(Convert.ToDouble(PVs)-Convert.ToDouble(reducao)*(1-bonus));
                setPontosVida(novosPVs);
            }
        }

        public override void LancarMagia(Heroi alvo)
        {
            base.LancarMagia(alvo);
            Console.WriteLine("Pelos Elementos!");
        }

        public override void AtacarComArma(Heroi alvo)
        {
            base.AtacarComArma(alvo);
            Console.WriteLine("Pela Horda!");
        }

    }
    
    class Programa
    {
        static void Main()
        {
            Heroi ali = new HeroiAlianca("Zadur", 80);
            Heroi hor = new HeroiHorda("Zodar", 80);
            bool continua = true;
            bool turnoAlianca = true;

            Console.WriteLine("Boas vindas a Uordi of Uorcrefiti!\n");

            do
            {
                for(int i = 0; i < 3; ++i)
                {
                    if(turnoAlianca) ali.AumentarUT();
                    else hor.AumentarUT();
                }
                
                if(turnoAlianca) Console.WriteLine("{0} tem {1} UTs!", ali.nome, ali.UTHeroi);
                else Console.WriteLine("{0} tem {1} UTs!", hor.nome, hor.UTHeroi);
                
                Console.Write("Escolha entre atacar (digite A) ou lançar magia (digite M): ");
                char comando = char.Parse(Console.ReadLine());
                
                if(turnoAlianca)
                {
                    if(comando=='A') ali.AtacarComArma(hor);
                    else if(comando=='M') ali.LancarMagia(hor);
                    else Console.WriteLine("Comando inválido, você perdeu sua vez!");
                }
                else
                {
                    if(comando=='A') hor.AtacarComArma(ali);
                    else if(comando=='M') hor.LancarMagia(ali);
                    else Console.WriteLine("Comando inválido, você perdeu sua vez!");
                }
                
                if(turnoAlianca) Console.WriteLine("{0} está com {1} pontos de vida!", hor.nome, hor.pontosVida);
                else Console.WriteLine("{0} está com {1} pontos de vida!", ali.nome, ali.pontosVida);

                continua = (ali.pontosVida>0) && (hor.pontosVida>0);
                if(continua) turnoAlianca=!turnoAlianca;
            }
            while(continua);
            
            if(turnoAlianca) Console.WriteLine("{0} venceu o duelo, com {1} pontos de vida restantes!", ali.nome, ali.pontosVida);
            else Console.WriteLine("{0} venceu o Mak'gora, com {1} pontos de vida restantes!", hor.nome, hor.pontosVida);
            Console.WriteLine("GAME OVER");

        }
    }
}