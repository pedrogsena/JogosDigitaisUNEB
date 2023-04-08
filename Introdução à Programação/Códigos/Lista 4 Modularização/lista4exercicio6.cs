using System;
using System.Threading;

namespace Lista4Exercicio6
{

  class Program
  {

    // Módulos aqui!

    public struct Tempo
    {
      public int hora, minuto, segundo;
      public Tempo(int hora, int minuto, int segundo)
      {
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
      }
    }

    static void Relogio()
    {
      Tempo meuTempo = new Tempo();
      InicializarRelogio(ref meuTempo);
      while(true)
      {
        ContarHora(ref meuTempo, ContarMinuto(ref meuTempo, ContarSegundo(ref meuTempo)));
        MostrarRelogio(meuTempo);
      }
    }

    static void InicializarRelogio(ref Tempo meuTempo)
    { // Erro aqui. Aonde???
      DateTime agora = DateTime.Now;
      // meuTempo = Tempo(agora.Hour, agora.Minute, agora.Second);
      meuTempo.hora = agora.Hour;
      meuTempo.minuto = agora.Minute;
      meuTempo.segundo = agora.Second;
    }

    static bool ContarSegundo(ref Tempo meuTempo)
    {
      bool passouMinuto=false;
      Thread.Sleep(1000);
      meuTempo.segundo++;
      if(meuTempo.segundo == 60)
      {
        meuTempo.segundo = 0;
        passouMinuto = true;
      }
      return passouMinuto;
    }

    static bool ContarMinuto(ref Tempo meuTempo, bool passouMinuto)
    {
      bool passouHora=false;
      if(passouMinuto)
      {
        meuTempo.minuto++;
        if(meuTempo.minuto == 60)
        {
          meuTempo.minuto = 0;
          passouHora = true;
        }
      }
      return passouHora;
    }

    static void ContarHora(ref Tempo meuTempo, bool passouHora)
    {
      if(passouHora)
      {
        meuTempo.hora++;
        if(meuTempo.hora == 24) meuTempo.hora = 0;
      }
    }

    static void MostrarRelogio(Tempo meuTempo)
    {
      // Para que os dados numéricos tenham dois dígitos
      string stringHora = meuTempo.hora.ToString();
      if (stringHora.Length < 2) stringHora = "0" + stringHora;
      string stringMinuto = meuTempo.minuto.ToString();
      if (stringMinuto.Length < 2) stringMinuto = "0" + stringMinuto;
      string stringSegundo = meuTempo.segundo.ToString();
      if (stringSegundo.Length < 2) stringSegundo = "0" + stringSegundo;
        
      // Para montar o mostrador do relógio
      Console.Clear(); // Não funciona no colab, mas funciona no console.
      Console.WriteLine("Relógio");
      Console.WriteLine("{0}:{1}:{2}", stringHora, stringMinuto, stringSegundo);
    }

    static void Main()
    {

      // Variáveis

      // Entrada

      // Processamento

      Relogio();

      // Saída

    }

  }

}