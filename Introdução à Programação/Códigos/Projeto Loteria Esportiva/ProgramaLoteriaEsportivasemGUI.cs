using System;
using System.IO;
using System.Text;

namespace LoteriaEsportivasemGUI
{

    class Program
    {

        // Módulos aqui!

        private static readonly Random aleat = new Random();

        static string enderecoResultado = "ResultadoLoteriaEsportiva.txt";
        static string enderecoParametro = "ParametroLoteriaEsportiva.txt";

        static void GerarResultado(int[,] resultado, ref bool aleatorio)
        {
            // gera resultado aleatório, ou lê resultado de arquivo de entrada
            if(File.Exists(enderecoResultado)){
                if(!aleatorio){
                    LerResultadoDeArquivo(resultado, enderecoResultado);
                 } else {
                    EscreverResultadoAleatorio(resultado, ref aleatorio, enderecoResultado, enderecoParametro);
                }
            } else {
                EscreverResultadoAleatorio(resultado, ref aleatorio, enderecoResultado, enderecoParametro);
            }
        }

        static bool ChecaParametro(string enderecoParametro)
        {
            // checa se parâmetro "aleatorio" existe e seu valor
            // se não existe, cria um como verdadeiro
            bool aleatorio;
            string stringAleatorio;
            if(File.Exists(enderecoParametro)){
                stringAleatorio = File.ReadAllText(enderecoParametro);
                if(stringAleatorio == "T") aleatorio=true;
                else aleatorio=false;
            } else {
                aleatorio=true;
                File.WriteAllText(enderecoParametro, "T");
            }
            return aleatorio;
        }

        static void EscreverResultadoAleatorio(int[,] resultado, ref bool aleatorio, string enderecoResultado, string enderecoParametro)
        {
            // escreve resultado gerado aleatoriamente
            // e faz parâmetro "aleatorio" ser falso
            GerarResultadoAleatorio(resultado);
            File.WriteAllLines(enderecoResultado, MontarString(resultado));
            aleatorio=false;
            File.WriteAllText(enderecoParametro, "F");
        }

        static string[] MontarString(int[,] resultado)
        {
            // monta string para escrita de resultado
            int i,j;
            string[] textoResultado = new string[13];
            for(i=0; i<13; i++){
                textoResultado[i]="";
                for(j=0; j<3; j++){
                    if(resultado[i,j] == 1) textoResultado[i]+='X';
                    else textoResultado[i]+='O';
                }
            }
            return textoResultado;
        }

        static void LerResultadoDeArquivo(int[,] resultado, string enderecoResultado)
        {
            // lê resultado de arquivo
            int i,j;
            string[] textoResultado = File.ReadAllLines(enderecoResultado);
            for(i=0; i<13; i++){
                for(j=0; j<3; j++){
                    if(textoResultado[i][j] == 'X') resultado[i,j] = 1;
                    else resultado[i,j] = 0;
                }
            }
        }

        static void GerarResultadoAleatorio(int[,] resultado)
        {
            // gera resultado aleatório
            int i,j,res;
            for(i=0; i<13; i++){
                res=aleat.Next(0,3);
                for(j=0; j<3; j++){
                    if(j==res) resultado[i,j] = 1;
                    else resultado[i,j] = 0;
                }
            }
        }

        static void BoasVindas()
        {
            // informa ao usuário sobre como apostar
            Console.Clear();
            Console.WriteLine("Bem-vindo ao programa da Loteria Esportiva!");
            Console.WriteLine("Ao registrar sua aposta num jogo, marque 'X' para os resultados que você");
            Console.WriteLine(" deseja apostar, e 'O' para os resultados que você prefere deixar em branco.");
            Console.WriteLine("Por exemplo, a aposta \"OXO\" significa que você apostou somente num empate.");
            Console.WriteLine("Vamos fazer uma aposta? Boa sorte!");
        }

        static void LerAposta(int[,] aposta)
        {
            // lê aposta informada pelo usuário e registra na matriz
            string linha;
            int i, j;
            char resposta;
            bool apostaConfirmada=false;
            do {
                Console.WriteLine("Iniciando nova aposta...");
                for(i=0; i<13; i++){
                    do {
                        Console.Write("Sua aposta para o {0}º jogo: ", i+1);
                        linha = Console.ReadLine();
                    } while(!ValidarEntrada(linha));
                    for(j=0; j<3; j++){
                        if(linha[j] == 'X') aposta[i,j] = 1;
                        else aposta[i,j] = 0;
                    }
                
                }
                MostrarAposta(aposta);
                do {
                    Console.Write("Confirmar aposta? (S/N) ");
                    resposta = char.Parse(Console.ReadLine());
                } while((resposta != 'S') && (resposta != 'N'));
                if(resposta == 'S'){
                    apostaConfirmada=true;
                    Console.WriteLine("Aposta confirmada! Boa sorte!");
                }
                Console.Clear();
            } while(!apostaConfirmada);
        }

        static bool ValidarEntrada(string linha)
        {
            // valida aposta de jogo individual informada pelo usuário
            bool valido=true;
            int j, contaO=0;
            if(linha.Length != 3) valido=false;
            else {
                for(j=0; j<3; j++){
                    if((linha[j] != 'X') && (linha[j] != 'O')){
                        valido=false;
                        break;
                    } else {
                        if(linha[j] == 'O') contaO++;
                    }
                }
                if(contaO == 3) valido=false;
            }
            if(!valido) Console.WriteLine("Erro! Aposta inválida!");
            return valido;
        }

        static void MostrarAposta(int[,] aposta)
        {
            // monta e mostra a aposta para o usuário poder decidir se confirma ou não
            int i,j;
            string numJogo;
            char marcacao;
            Console.Clear();
            Console.WriteLine("Esta é a sua aposta:");
            for(i=0; i<13; i++){
                numJogo = Convert.ToString(i+1);
                if(numJogo.Length < 2) numJogo = "0" + numJogo;
                Console.Write("| Jogo {0} |", numJogo);
                for(j=0; j<3; j++){
                    if(aposta[i,j] == 1) marcacao = 'X';
                    else marcacao = 'O';
                    Console.Write("  {0}  |", marcacao);
                }
                Console.Write("\n");
            }
        }

        static int ConferirAcertos(int[,] aposta, int[,] resultado)
        {
            // compara matrizes de aposta e de resultado, retorna a quantidade de acertos
            int i, j, acertos=0;
            for(i=0; i<13; i++){
                for(j=0; j<3; j++){
                    if((aposta[i,j] == resultado[i,j]) && (resultado[i,j] == 1)){
                        acertos++;
                        break;
                    }
                }
            }
            return acertos;
        }

        static void ImprimirAcertos(int acertos)
        {
            // imprime o número de acertos da aposta
            Console.Clear();
            Console.WriteLine("Resultado da sua aposta na Loteria Esportiva:");
            if(acertos > 0){
                if(acertos == 13) Console.Write("Parabéns! ");
                Console.WriteLine("Você fez {0} pontos!", acertos);
            } else Console.WriteLine("Que pena! Você não marcou nenhum ponto. Mais sorte da próxima vez!");
            Console.WriteLine("A Loteria Esportiva deseja-lhe um ótimo dia!");
        }

        static void Main()
        {
            
            // Variáveis
            
            int[,] Aposta = new int[13,3];
            int[,] Resultado = new int[13,3];
            int Acertos;
            bool aleatorio;

            // Inicialização
                        
            aleatorio = ChecaParametro(enderecoParametro);
            GerarResultado(Resultado, ref aleatorio);
            BoasVindas();

            // Entrada
            
            LerAposta(Aposta);

            // Processamento
            
            Acertos = ConferirAcertos(Aposta, Resultado);

            // Saída
            
            ImprimirAcertos(Acertos);

        }

    }

}
