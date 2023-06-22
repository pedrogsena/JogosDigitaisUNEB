using System;

namespace ppjlab02
{
    public abstract class Heroi
	{
		protected string Nome;
		protected float PtsVida;

		public Heroi (String nome, float ptsVida)
		{
			this.Nome = nome;
			this.PtsVida = ptsVida;
		}

		public abstract void LancarMagia ();
		public abstract void AtacarComArma ();

		public virtual void ReduzirVida() 
		{
			this.PtsVida--;
		}

		public virtual void AumentarVida() 
		{
			this.PtsVida++;
		}

		public String GetNome() 
		{
			return this.Nome;
		}

		public float GetPtsVida() 
		{
			return this.PtsVida;
		}
	}


    public class HeroiAlianca:Heroi
	{
		public HeroiAlianca (String nome, int ptsVida) : base (nome, ptsVida)
		{

		}

		public override void LancarMagia ()
		{
			Console.WriteLine ("Força Rutilante!!!");
		}

		public override void AtacarComArma() 
		{
			Console.WriteLine ("Golpe de espada!!!");
		}

		public override void AumentarVida ()
		{
			base.AumentarVida ();
			this.PtsVida += 0.2f;
		}
	}


	public class HeroiHorda:Heroi
	{
		public HeroiHorda (String nome, int ptsVida) : base(nome,ptsVida)
		{

		}
	
		public override void LancarMagia ()
		{
			Console.WriteLine ("Caminho de chamas!!!");
		}

		public override void AtacarComArma() {
			Console.WriteLine ("Golpe de machado!!!");
		}

		public override void ReduzirVida ()
		{
			this.PtsVida-=0.8f;
		}
	
	}


	public class UoU
	{
		public static void Main ()
		{
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.Gray;

			//**************** Heroi da Alianca ********************************  

			Console.ForegroundColor = ConsoleColor.Yellow;

			Heroi a = new HeroiAlianca ("Zadur", 100);
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + a.GetNome () + "...");
			a.ReduzirVida ();
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + a.GetNome () + "...");
			a.AumentarVida ();
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			//**************** Heroi da Horda ********************************  

			Console.ForegroundColor = ConsoleColor.Red;

			Heroi o = new HeroiHorda ("Zodar", 100);
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + o.GetNome () + "...");
			o.ReduzirVida ();
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + o.GetNome () + "...");
			o.AumentarVida ();
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.ForegroundColor = ConsoleColor.Gray;

           //**************** Demonstrando Polimorfismo *********************

			a.AtacarComArma ();
			o.AtacarComArma ();

			a.LancarMagia ();
			o.LancarMagia ();

		}
	}
}

