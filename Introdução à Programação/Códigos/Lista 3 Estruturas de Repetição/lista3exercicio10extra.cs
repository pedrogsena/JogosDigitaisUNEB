using System;
using System.Threading;

namespace Lista3Exercicio10 {

  class Program {

    static void Main(){

      // Variáveis
      int hora, minuto, segundo, contador=0;
      string stringHora, stringMinuto, stringSegundo;
      bool flag=true;
      DateTime agora=DateTime.Now; /* Struct que pega a hora do sistema APENAS para inicializar o nosso relógio. */

      // Entrada

      // Inicializando nosso relógio
      hora = agora.Hour;
      minuto = agora.Minute;
      segundo = agora.Second;

      // Processamento e Saída
      while (flag) {

        // Para que os dados numéricos tenham dois dígitos
        stringHora = hora.ToString();
        if (stringHora.Length < 2) stringHora = "0" + stringHora;
        stringMinuto = minuto.ToString();
        if (stringMinuto.Length < 2) stringMinuto = "0" + stringMinuto;
        stringSegundo = segundo.ToString();
        if (stringSegundo.Length < 2) stringSegundo = "0" + stringSegundo;
        
        // Para montar o mostrador do relógio
        Console.Clear(); // Não funciona no colab, mas funciona no console.
        Console.WriteLine("Relógio");
        Console.WriteLine("{0}:{1}:{2}", stringHora, stringMinuto, stringSegundo);
        
        Thread.Sleep(1000); // Pára o programa por 1000 milissegundos.
        contador++;
        if (contador > 200) flag = false; // Pro programa parar.
        
        // Para atualizar o horário
        segundo++;
        if (segundo == 60) {
          segundo = 0;
          minuto++;
          if (minuto == 60) {
            minuto = 0;
            hora++;
            if (hora == 24) hora = 0;
          }
        }
      }

    }

  }

}