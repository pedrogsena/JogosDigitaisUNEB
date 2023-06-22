using System;

namespace UoU_Luana_PedroSena
{
    public abstract class Heroi
    {
        protected string Nome;
        protected double PtsVida;
        protected int UTHeroi; /*Parte 1, Item 2*/
        protected Magia magia; /*Parte 1, Item 7*/
        protected Arma ArmaHeroi; /*Parte 2, Item 12*/

        public Heroi(string nome, double ptsVida)
        {
            this.Nome = nome;
            this.PtsVida = ptsVida;
            this.UTHeroi = 7; /*Parte 1, Item 3*/
        }

        public virtual void LancarMagia(Heroi alvo) /*Parte 1, Item 9*/
        {
            if (this.UTHeroi >= this.magia.GetCustoUT())
            {
                this.magia.Lancar();
                alvo.ReduzirVida(this.magia.GetDano());
                ReduzirUT(this.magia.GetCustoUT());
                Console.WriteLine("Você conjurou {0} em {1}! Dano de {2} pontos!", this.magia.GetNome(), alvo.GetNome(), this.magia.GetDano());
                Console.WriteLine("{0} está com {1} pontos de vida!", alvo.GetNome(), alvo.GetPtsVida());
            }
            else Console.WriteLine("Você tentou conjurar {0}, mas falhou!", this.magia.GetNome());
        }
        public virtual void AtacarComArma(Heroi alvo) /*Parte 2, Item 14*/
        {
            if (this.UTHeroi >= this.ArmaHeroi.GetCustoUT())
            {
                this.ArmaHeroi.Atacar();
                alvo.ReduzirVida(this.ArmaHeroi.GetDano());
                ReduzirUT(this.ArmaHeroi.GetCustoUT());
                Console.WriteLine("Você deu um golpe de {0} em {1}! Dano de {2} pontos!", this.ArmaHeroi.GetNome(), alvo.GetNome(), this.ArmaHeroi.GetDano());
                Console.WriteLine("{0} está com {1} pontos de vida!", alvo.GetNome(), alvo.GetPtsVida());
            }
            else Console.WriteLine("Você tentou atacar com {0}, mas falhou!", this.ArmaHeroi.GetNome());
        }

        public virtual void ReduzirVida()
        {
            this.PtsVida--;
        }

        /*Parte 1, Item 1*/
        public virtual void ReduzirVida(double dano)
        {
            this.PtsVida -= dano;
        }

        public virtual void AumentarVida()
        {
            this.PtsVida++;
        }

        /*Parte 1, Item 4*/
        public virtual void AumentarUT(int valor)
        {
            this.UTHeroi += valor;
        }

        public virtual void ReduzirUT(int valor)
        {
            this.UTHeroi -= valor;
        }

        public String GetNome()
        {
            return this.Nome;
        }

        public double GetPtsVida()
        {
            return this.PtsVida;
        }

        public int GetUTHeroi()
        {
            return this.UTHeroi;
        }
    }
        
    public class Magia /*Parte 1, Item 5*/
    {
        protected string nome;
        protected int CustoUT;
        protected double dano;

        public Magia(string nome, int CustoUT, double dano)
        {
            this.nome = nome;
            this.CustoUT = CustoUT;
            this.dano = dano;
        }
                
        public double Lancar() /*Parte 1, Item 6*/
        {
            return this.dano;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public int GetCustoUT()
        {
            return this.CustoUT;
        }

        public double GetDano()
        {
            return this.dano;
        }

    }
        
    public class Arma /*Parte 2, Item 10*/
    {
        protected string nome;
        protected int CustoUT;
        protected double dano;

        public Arma(string nome, int CustoUT, double dano)
        {
            this.nome = nome;
            this.CustoUT = CustoUT;
            this.dano = dano;
        }

        /*Parte 2, Item 12*/
        public double Atacar()
        {
            return this.dano;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public int GetCustoUT()
        {
            return this.CustoUT;
        }

        public double GetDano()
        {
            return this.dano;
        }

    }

    public class HeroiAlianca : Heroi
    {
        public HeroiAlianca(String nome, int PtsVida) : base(nome, PtsVida)
        {
            this.magia = new Magia("Força Rutilante", 4, 20.0); /*Parte 1, Item 8*/
            this.ArmaHeroi = new Arma("Espada", 2, 10.0); /*Parte 2, Item 13*/
        }

        public override void LancarMagia(Heroi alvo)
        {
            base.LancarMagia(alvo);
            Console.WriteLine("{0}!", this.magia.GetNome());
        }

        public override void AtacarComArma(Heroi alvo)
        {
            base.AtacarComArma(alvo);
            Console.WriteLine("Espadada!");
        }

        public override void AumentarVida()
        {
            base.AumentarVida();
            this.PtsVida += 0.2;
        }
    }


    public class HeroiHorda : Heroi
    {
        public HeroiHorda(String nome, int PtsVida) : base(nome, PtsVida)
        {
            this.magia = new Magia("Caminho de Chamas", 6, 30); /*Parte 1, Item 8*/
            this.ArmaHeroi = new Arma("Machado", 4, 20.0); /*Parte 2, Item 13*/
        }

        public override void LancarMagia(Heroi alvo)
        {
            base.LancarMagia(alvo);
            Console.WriteLine("{0}!", this.magia.GetNome());
        }

        public override void AtacarComArma(Heroi alvo)
        {
            base.AtacarComArma(alvo);
            Console.WriteLine("Machadada!");
        }

        public override void ReduzirVida()
        {
            this.PtsVida -= 0.8;
        }

    }


    public class UoU
    {
        private static readonly short STARTING = 0;
        private static readonly short RUNNING = 1;
        private static readonly short GAMEOVER = 2;
        private static readonly short VIDA = 80;

        private short Status;

        public UoU()
        {
            this.Status = UoU.STARTING;
        }

        public void Print()
        {
            Console.WriteLine(this.Status);
        }

        public static void Main()
        {
            UoU game = new UoU();

            //game.Print();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            /*Parte 3 Item 15*/            
            Heroi alianca = new HeroiAlianca("Anduin Wrynn", UoU.VIDA);            
            Heroi horda = new HeroiHorda("Sylvanas Windrunner", UoU.VIDA);

            game.Status = UoU.RUNNING;
            Console.WriteLine("E começa o embate entre {0} da Aliança e {1} da Horda!\n", alianca.GetNome(), horda.GetNome());             

            /*Parte 3 Item 16*/
            while (game.Status == UoU.RUNNING)
            {

                String ataque = String.Empty;
                //Ataque Alianca
                Console.WriteLine("{0}, é a sua vez!", alianca.GetNome());
                alianca.AumentarUT(3); /*subitem a*/
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Você tem {0} Unidades de Tempo (UTs).", alianca.GetUTHeroi()); /*subitem b*/
                Console.WriteLine("A Aliança está atacando!");
                Console.WriteLine("Digite M para Magia e A para Arma."); /*subitem c*/
                ataque = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (ataque.Equals("M"))
                    alianca.LancarMagia(horda); /*subitem d*/
                else if (ataque.Equals("A"))
                    alianca.AtacarComArma(horda); /*subitem d*/
                else Console.WriteLine("Comando desconhecido. Você perdeu a sua vez!");
                Console.WriteLine("{0} está com {1} pontos de vida.\n", horda.GetNome(), horda.GetPtsVida()); /* subitem e*/

                if (horda.GetPtsVida() <= 0)
                {
                    game.Status = UoU.GAMEOVER;
                    Console.WriteLine("{0} venceu com {1} pontos de vida restando!", alianca.GetNome(), alianca.GetPtsVida()); /*subitem f*/
                    Console.WriteLine("GAME OVER");
                    break;
                }

                //Ataque Horda
                Console.WriteLine("{0}, é a sua vez!", horda.GetNome());
                horda.AumentarUT(3); /*subitem a*/
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Você tem {0} Unidades de Tempo (UTs).", horda.GetUTHeroi()); /*subitem b*/
                Console.WriteLine("A Horda está atacando!");
                Console.WriteLine("Digite M para Magia e A para Arma."); /*subitem c*/
                ataque = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (ataque.Equals("M"))
                    horda.LancarMagia(alianca); /*subitem d*/
                else if (ataque.Equals("A"))
                    horda.AtacarComArma(alianca); /*subitem d*/
                else Console.WriteLine("Comando desconhecido. Você perdeu a sua vez!");
                Console.WriteLine("{0} está com {1} pontos de vida.\n", alianca.GetNome(), alianca.GetPtsVida()); /* subitem e*/

                if (alianca.GetPtsVida() <= 0)
                {
                    game.Status = UoU.GAMEOVER;
                    Console.WriteLine("{0} venceu com {1} pontos de vida restando!", horda.GetNome(), horda.GetPtsVida()); /*subitem f*/
                    Console.WriteLine("GAME OVER");
                    break;
                }
             
            } Console.ResetColor();
        }
    }
}