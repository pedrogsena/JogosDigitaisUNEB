/*******************************************************************************

Código: JogoDaVelha.cs

Propósito: simular um torneio de jogo da velha, entre um jogador real e um
 jogador virtual, que faz suas jogadas de forma aleatória.

Data da última modificação: 26/08/2023

Autores:
 - Pablo Andrade (pablo.sas22@gmail.com)
 - Pedro Sena (peufisbach@gmail.com)

Para compilar:
 mcs JogoDaVelha.cs -out:objeto

Para executar:
 mono objeto

*******************************************************************************/

using System;
using System.IO;

namespace JogoDaVelha {
  
  public class Torneio {
      
    public int scoreFinalJogador1;
    public int scoreFinalJogador2;
    
    public Torneio(int scoreFinalJogador1, int scoreFinalJogador2) {
      this.scoreFinalJogador1 = scoreFinalJogador1;
      this.scoreFinalJogador2 = scoreFinalJogador2;
    }
    
	public int getScoreFinalJogador1(){
	  return this.scoreFinalJogador1;
	}

	public int getScoreFinalJogador2(){
	  return this.scoreFinalJogador2;
	}

	public void setScoreFinalJogador1(int score){
	  this.scoreFinalJogador1 = score;
	}

	public void setScoreFinalJogador2(int score){
	  this.scoreFinalJogador2 = score;
	}

  }

  public class Partida {
      
    public int[] posicaoJogadaX {get; set;}
    public int[] posicaoJogadaO {get; set;}
    
    public Partida(){
        int[] vetor = {0, 0, 0, 0, 0};
        this.posicaoJogadaX = vetor;
        this.posicaoJogadaO = vetor;
    }
    
  }

  public class Jogador {
      
    public string nome;
    public bool ehVirtual;
    
    public Jogador(string nome, bool ehVirtual) {
      this.nome = nome;
      this.ehVirtual = ehVirtual;
    }
    
	public string getNome(){
	  return this.nome;
	}

	public bool getVirtual(){
	  return this.ehVirtual;
	}

	public void setNome(string nome){
	  this.nome = nome;
	}

	public void setVirtual(bool ehVirtual){
	  this.ehVirtual = ehVirtual;
	}

  }

  public class Sistema {
	  
	private static readonly Random aleat = new Random();

    public static void Main() {
      
      int linha, coluna, tamanho, indice, indice1, indice2, numeroPartidas, turno_X, turno_O, i, j;
	  char simbolo, simbolo1, simbolo2, resposta;
	  string nome1, nome2, arquivoEntrada;
	  bool continuarTorneio, continuarPartida, vezJogador1, vitoria;
	  
	  // preparar lista de nomes
      arquivoEntrada = "NomesJogadores.txt";
      string[] ListaJogadores = File.ReadAllLines(arquivoEntrada);
	  tamanho = ListaJogadores.Length;
      
	  // exibir lista de nomes
	  Console.Clear();
      Console.WriteLine("Boas vindas ao Jogo da Velha!");
	  Console.WriteLine("Lista dos jogadores disponíveis:");
	  indice=1;
	  foreach(string nome in ListaJogadores){
		  Console.WriteLine(indice + ". " + nome);
		  indice++;
	  }
	  
	  // orientar jogador a escolher nome e símbolo
	  indice1 = 0;
	  indice2 = 0;
	  simbolo1 = ' ';
	  simbolo2 = ' ';
	  do{
		Console.Write("Informe o número do nome do jogador 1 (você): ");
		indice1 = int.Parse(Console.ReadLine());
	  }while(indice1<1 || indice1>tamanho);
	  nome1 = ListaJogadores[indice1-1];
	  do{
		Console.Write("Informe o seu símbolo (X ou O): ");
		simbolo1 = char.Parse(Console.ReadLine());
	  }while(simbolo1!='X' && simbolo1!='O');
	  if(simbolo1 == 'X') simbolo2 = 'O';
	  else simbolo2 = 'X';
	  do{
	    Console.Write("Informe o número do nome do jogador 2 (CPU): ");
	    indice2 = int.Parse(Console.ReadLine());
	  }while(indice2<1 || indice2>tamanho);
	  nome2 = ListaJogadores[indice2-1];
	  
	  // começar torneio, registrar jogadores
	  Torneio torneio = new Torneio(0,0);
	  Jogador jogador1 = new Jogador(nome1, false);
	  Jogador jogador2 = new Jogador(nome2, true);
	  
	  // laço do torneio
	  continuarTorneio = true;
	  numeroPartidas = 0;
	  while(continuarTorneio){
		  
		  // laço da partida
		  numeroPartidas++;
		  Console.Clear();
		  Console.WriteLine("Partida #{0}!", numeroPartidas);
		  continuarPartida = true;
		  vezJogador1 = true;
		  turno_X=0;
		  turno_O=0;
		  
		  // matriz da partida
		  char[,] matrizPartida = new char[3, 3];
		  for(i=0; i<3; i++)
			for(j=0; j<3; j++)
			  matrizPartida[i, j] = ' ';
		  
		  while(continuarPartida){
			  
			  Partida partida = new Partida();
			  
			  // se vez do jogador 1, perguntar onde marcar
			  if(vezJogador1){
				  Console.WriteLine("Informe onde deseja marcar sua jogada.");
				  do{
				      Console.Write("Informe linha: ");
				      linha = int.Parse(Console.ReadLine());
				  }while(linha<1 || linha>3);
				  do{
					  Console.Write("Informe coluna: ");
				      coluna = int.Parse(Console.ReadLine());
				  }while(coluna<1 || coluna>3);
				  matrizPartida[linha-1, coluna-1] = simbolo1;
				  if(simbolo1 == 'X'){
					  partida.posicaoJogadaX[turno_X] = coluna + 3*(linha-1);
					  turno_X++;
				  }
				  else{
					  partida.posicaoJogadaO[turno_O] = coluna + 3*(linha-1);
					  turno_O++;
				  }
			  }
			  
			  // se vez do jogador 2, marcar aleatoriamente
			  else{
				  do{
				    linha = aleat.Next(1,4);
				    coluna = aleat.Next(1,4);
				  }while(matrizPartida[linha-1, coluna-1] != ' ');
				  matrizPartida[linha-1, coluna-1] = simbolo2;
				  if(simbolo2 == 'X'){
					  partida.posicaoJogadaX[turno_X] = coluna + 3*(linha-1);
					  turno_X++;
				  }
				  else{
					  partida.posicaoJogadaO[turno_O] = coluna + 3*(linha-1);
					  turno_O++;
				  }
			  }
			  
			  // display da partida
			  if(vezJogador1) Console.WriteLine("Jogada de {0}:", jogador1.nome);
			  else Console.WriteLine("Jogada de {0}:", jogador2.nome);
			  for(i=0; i<3; i++){
				  for(j=0; j<3; j++){
					  Console.Write(" {0} ", matrizPartida[i, j]);
					  if(j<2) Console.Write("|");
				  }
				  if(i<2) Console.WriteLine("\n-----------");
				  else Console.Write("\n");
			  }
			  
			  // checar se algum jogador venceu
			  continuarPartida = (turno_X + turno_O < 9);
			  vitoria = false;
			  if(vezJogador1) simbolo = simbolo1;
			  else simbolo = simbolo2;
			  if((matrizPartida[0, 0] == simbolo)&&(matrizPartida[0, 1] == simbolo)&&(matrizPartida[0, 2] == simbolo)) vitoria = true;
			  else if((matrizPartida[1, 0] == simbolo)&&(matrizPartida[1, 1] == simbolo)&&(matrizPartida[1, 2] == simbolo)) vitoria = true;
			  else if((matrizPartida[2, 0] == simbolo)&&(matrizPartida[2, 1] == simbolo)&&(matrizPartida[2, 2] == simbolo)) vitoria = true;
			  else if((matrizPartida[0, 0] == simbolo)&&(matrizPartida[1, 0] == simbolo)&&(matrizPartida[2, 0] == simbolo)) vitoria = true;
			  else if((matrizPartida[0, 1] == simbolo)&&(matrizPartida[1, 1] == simbolo)&&(matrizPartida[2, 1] == simbolo)) vitoria = true;
			  else if((matrizPartida[0, 2] == simbolo)&&(matrizPartida[1, 2] == simbolo)&&(matrizPartida[2, 2] == simbolo)) vitoria = true;
			  else if((matrizPartida[0, 0] == simbolo)&&(matrizPartida[1, 1] == simbolo)&&(matrizPartida[2, 2] == simbolo)) vitoria = true;
			  else if((matrizPartida[0, 2] == simbolo)&&(matrizPartida[1, 1] == simbolo)&&(matrizPartida[2, 0] == simbolo)) vitoria = true;
			  continuarPartida = continuarPartida && !vitoria;
			  if(continuarPartida) vezJogador1 = !vezJogador1;
			  else if(vitoria){
				  if(vezJogador1){
					  Console.WriteLine("Vitória de {0}!", jogador1.nome);
					  torneio.scoreFinalJogador1++;
				  }
				  else{
					  Console.WriteLine("Vitória de {0}!", jogador2.nome);
					  torneio.scoreFinalJogador2++;
				  }
				  break;
			  }
			  else Console.WriteLine("Empatou!");
		  }
		  
		  // condição de parada do torneio
		  do{
		    Console.Write("Deseja continuar? (S/N): ");
			resposta = char.Parse(Console.ReadLine());
		    if(resposta == 'N') continuarTorneio = false;
		  }while(resposta!='S' && resposta!='N');
	  }
	  
	  if(torneio.scoreFinalJogador1 > torneio.scoreFinalJogador2) Console.WriteLine("{0} venceu o torneio!", jogador1.nome);
	  else if(torneio.scoreFinalJogador1 < torneio.scoreFinalJogador2) Console.WriteLine("{0} venceu o torneio!", jogador2.nome);
	  else Console.WriteLine("O torneio terminou em empate!");
	  
    }
  }
}