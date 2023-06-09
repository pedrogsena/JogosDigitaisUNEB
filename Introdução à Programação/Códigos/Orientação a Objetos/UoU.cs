/******************************************************************************

UNEB - Jogos Digitais - 2023.1 - Int. Prog.
Pedro Gabriel Sena Cardoso

*******************************************************************************/

using System;
namespace UoU
{
    public abstract class Heroi
    {
        private string nome;
        protected int pontosVida;
        
        public Heroi(string nome, int PVs)
        {
            this.nome = nome;
            this.pontosVida = PVs;
        }
        
        ~Heroi()
        {
            
        }
        
        public string getNome()
        {
            return nome;
        }
        
        public int getPontosVida()
        {
            return pontosVida;
        }
        
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public void setPontosVida(int PVs)
        {
            this.pontosVida = PVs;
        }
        
        public abstract void LancarMagia();

        public abstract void AtacarComArma();

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

        public override void LancarMagia()
        {
            Console.WriteLine("Pela Luz Sagrada!");
        }

        public override void AtacarComArma()
        {
            Console.WriteLine("Pela Aliança!");
        }
    }
    
    public class HeroiHorda:Heroi
    {
        public HeroiHorda(string nome, int PVs):base(nome, PVs)
        {
            
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

        public override void LancarMagia()
        {
            Console.WriteLine("Pelos Elementos!");
        }

        public override void AtacarComArma()
        {
            Console.WriteLine("Pela Horda!");
        }

    }
    
    class Programa
    {
        static void Main()
        {
//            Heroi PJ_Pedro = new Heroi ("Zymmax", 100);
//            HeroiAlianca PJ_Pedro_Stormwind = new HeroiAlianca("Zadur", 100);
//            HeroiHorda PJ_Pedro_Orgrimmar = new HeroiHorda("Zodar", 100);
            Heroi ali = new HeroiAlianca("Zadur", 100);
            Heroi hor = new HeroiHorda("Zodar", 100);
//            int dano=40, cura=20;
        
            Console.WriteLine("Boas vindas a Uordi of Uorcrefiti!\n");
//            Console.WriteLine("Sua personagem chama-se {0} e tem {1} pontos de vida.", PJ_Pedro.getNome(), PJ_Pedro.getPontosVida());
//            PJ_Pedro.ReduzirPontosVida(dano);
//            Console.WriteLine("{0} foi atacada! Ela sofreu {1} pontos de dano e agora está com {2} pontos de vida.", PJ_Pedro.getNome(), dano, PJ_Pedro.getPontosVida());
//            PJ_Pedro.AumentarPontosVida(cura);
//            Console.WriteLine("{0} foi curada! Ela foi restaurada em {1} pontos de vida, e agora está com {2} pontos de vida.", PJ_Pedro.getNome(), cura, PJ_Pedro.getPontosVida());
//            Console.Write("\n");
//            Console.WriteLine("Pela Luz Sagrada! Sua personagem da Aliança chama-se {0} e tem {1} pontos de vida.", PJ_Pedro_Stormwind.getNome(), PJ_Pedro_Stormwind.getPontosVida());
//            Console.Write("\n");
//            Console.WriteLine("Lok'tar Ogar! Sua personagem da Horda chama-se {0} e tem {1} pontos de vida.", PJ_Pedro_Orgrimmar.getNome(), PJ_Pedro_Orgrimmar.getPontosVida());
//            PJ_Pedro_Orgrimmar.ReduzirPontosVida(dano);
//            Console.WriteLine("{0} foi atacada! Ela sofreu {1} pontos de dano e agora está com {2} pontos de vida.", PJ_Pedro_Orgrimmar.getNome(), dano, PJ_Pedro_Orgrimmar.getPontosVida());
//            Console.WriteLine("(Por ser da Horda, {0} é mais dura na queda e perde menos pontos de vida que o dano sofrido.)", PJ_Pedro_Orgrimmar.getNome());
//            PJ_Pedro_Orgrimmar.AumentarPontosVida(cura);
//            Console.WriteLine("{0} foi curada! Ela foi restaurada em {1} pontos de vida, e agora está com {2} pontos de vida.", PJ_Pedro_Orgrimmar.getNome(), cura, PJ_Pedro_Orgrimmar.getPontosVida());

            Console.WriteLine("Pela Luz Sagrada! Sua personagem da Aliança chama-se {0} e tem {1} pontos de vida.", ali.getNome(), ali.getPontosVida());
            Console.Write("\n");
            Console.WriteLine("Lok'tar Ogar! Sua personagem da Horda chama-se {0} e tem {1} pontos de vida.", hor.getNome(), hor.getPontosVida());
            Console.Write("\n");
            ali.LancarMagia();
            Console.WriteLine("{0} lançou uma magia!", ali.getNome());
            Console.Write("\n");
            hor.AtacarComArma();
            Console.WriteLine("{0} atacou com sua arma!", hor.getNome());
            
        }
    }
}