/*******************************************************************************
                         UNEB - Jogos Digitais - 2023.1
                            Introdução à Programação
                           Pedro Gabriel Sena Cardoso
                                Projeto Matrizes
                        Leia o README para mais detalhes
*******************************************************************************/

using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoMatrizes
{

    class Program
    {

        private static readonly Random aleat = new Random();
        
        static string enderecoMatrizTranspor = "entradaMatrizTranspor.txt";
        
        // Estruturas vão aqui
        
        struct Flags
        {
            public bool argumentoValido, arquivoEntradaExiste, tamanhoMatrizCoincide, moduloPronto, matrizQuadrada;
            public Flags(bool argumentoValido, bool arquivoEntradaExiste, bool tamanhoMatrizCoincide, bool moduloPronto, bool matrizQuadrada)
            {
                this.argumentoValido = argumentoValido;
                this.arquivoEntradaExiste = arquivoEntradaExiste;
                this.tamanhoMatrizCoincide = tamanhoMatrizCoincide;
                this.moduloPronto = moduloPronto;
                this.matrizQuadrada = matrizQuadrada;
            }
        }

        // Módulos vão aqui
        
        static void Aleatoria(int[,] matriz, int numlin, int numcol)
        {
            int i,j;
            for(i=0; i<numlin; ++i)
                for(j=0; j<numcol; ++j)
                    matriz[i,j] = aleat.Next(Int16.MinValue, Int16.MaxValue);
        }
        
        static void Identidade(int[,] matriz, int dimensao)
        {
            int i,j;
            for(i=0; i<dimensao; ++i)
                for(j=0; j<dimensao; ++j)
                {
                    if (i==j) matriz[i,j] = 1;
                    else matriz[i,j] = 0;
                }
        }
        
        static void Diagonal(int[,] matriz, int numlin, int numcol)
        {
            int i,j;
            for(i=0; i<numlin; ++i)
                for(j=0; j<numcol; ++j)
                {
                    if(i==j) matriz[i,j] = aleat.Next(Int16.MinValue, Int16.MaxValue);
                    else matriz[i,j] = 0;
                }
        }
        
        static void Toeplitz(int[,] matriz, int numlin, int numcol)
        {
            int i,j;
            // Primeiros elementos: (numlin + numcol - 1) valores únicos, aleatórios
            for (j=numcol-1; j>=0; --j) matriz[0,j] = aleat.Next(Int16.MinValue, Int16.MaxValue);
            for (i=1; i<numlin; ++i) matriz[i,0] = aleat.Next(Int16.MinValue, Int16.MaxValue);
            // Demais elementos: repetidos nas diagonais
            for (i=1; i<numlin; ++i)
                for(j=1; j<numcol; ++j)
                    matriz[i,j] = matriz[i-1,j-1];
        }
        
        static void Ortogonal(int[,] matriz, int dimensao){}
        
        static void TriangularInferior(int[,] matriz, int dimensao)
        {
            int i, j;
            for(i=0; i<dimensao; ++i)
                for(j=0; j<dimensao; ++j){
                    if(i<j) matriz[i,j] = 0;
                    else matriz[i,j] = aleat.Next(Int16.MinValue, Int16.MaxValue);
                }
        }
        
        static void TriangularSuperior(int[,] matriz, int dimensao)
        {
            int i, j;
            for(i=0; i<dimensao; ++i)
                for(j=0; j<dimensao; ++j){
                    if(i>j) matriz[i,j] = 0;
                    else matriz[i,j] = aleat.Next(Int16.MinValue, Int16.MaxValue);
                }
        }
        
        static void Transposta(int[,] matrizEntrada, int[,] matrizSaida, int numlin, int numcol)
        {
            int i,j;
            for(i=0; i<numlin; ++i)
                for (j=0; j<numcol; ++j)
                    matrizSaida[j,i] = matrizEntrada[i,j];
        }
        
        static void Main(string[] args)
        {

            // Variáveis: nos argumentos
            int numeroLinhas, numeroColunas;
            int i, j;
            string moduloChamado;
            Flags minhasFlags = new Flags(true, true, true, true, true);

            // Entrada
            Console.Clear();
            Console.WriteLine("Bem-vindo ao programa para gerar e manipular matrizes.");
            if (args.Length == 0) Console.WriteLine("Nenhum argumento informado. Encerrando...");
            else if (args.Length == 1) Console.WriteLine("Sem argumentos suficientes. Encerrando...");

            // Processamento

            else
            {
                moduloChamado = args[0];
                numeroLinhas = Convert.ToInt32(args[1]);
                if (args.Length >= 3)
                {
                    numeroColunas = Convert.ToInt32(args[2]);
                    if(numeroColunas != numeroLinhas) minhasFlags.matrizQuadrada = false;
                }
                else numeroColunas = numeroLinhas;
                if((numeroLinhas<=0) || (numeroColunas<=0)) minhasFlags.argumentoValido = false;

                if(minhasFlags.argumentoValido){
                    int[,] matrizRecipiente = new int[numeroLinhas,numeroColunas];
                    int[,] matrizSaida = new int [numeroColunas, numeroLinhas];
                    if(moduloChamado == "trans")
                    {
                        if(File.Exists(enderecoMatrizTranspor)){
                            string matrizTranspor = File.ReadAllText(enderecoMatrizTranspor);
                            i = 0;
                            foreach (var linha in matrizTranspor.Split('\n'))
                            {
                                j = 0;
                                foreach (var coluna in linha.Split(' '))
                                {
                                    matrizRecipiente[i,j] = int.Parse(coluna);
                                    ++j;
                                    if(j>numeroColunas) minhasFlags.tamanhoMatrizCoincide = false;
                                }
                                if(j<numeroColunas) minhasFlags.tamanhoMatrizCoincide = false;
                                ++i;
                                if(i>numeroLinhas) minhasFlags.tamanhoMatrizCoincide = false;
                            }
                            if(i<numeroLinhas) minhasFlags.tamanhoMatrizCoincide = false;
                        }
                        else minhasFlags.arquivoEntradaExiste = false;
                    }
                    else
                    {
                        for (i=0; i<numeroLinhas; ++i)
                            for (j=0; j<numeroColunas; ++j)
                                matrizRecipiente[i,j] = 0;
                    }
                
                    switch(moduloChamado)
                    {
                        case "aleat":
                            Aleatoria(matrizRecipiente, numeroLinhas, numeroColunas);
                            break;
                        case "id":
                            if(minhasFlags.matrizQuadrada) Identidade(matrizRecipiente, numeroLinhas);
                            break;
                        case "diag":
                            Diagonal(matrizRecipiente, numeroLinhas, numeroColunas);
                            break;
                        case "toep":
                            Toeplitz(matrizRecipiente, numeroLinhas, numeroColunas);
                            break;
                        case "orto":
                            minhasFlags.moduloPronto = false;
//                            if(minhasFlags.matrizQuadrada) Ortogonal(matrizRecipiente, numeroLinhas);
                            break;
                        case "trinf":
                            if(minhasFlags.matrizQuadrada) TriangularInferior(matrizRecipiente, numeroLinhas);
                            break;
                        case "trsup":
                            if(minhasFlags.matrizQuadrada) TriangularSuperior(matrizRecipiente, numeroLinhas);
                            break;
                        case "trans":
                            if(minhasFlags.arquivoEntradaExiste && minhasFlags.tamanhoMatrizCoincide)
                                Transposta(matrizRecipiente, matrizSaida, numeroLinhas, numeroColunas);
                            break;
                        default:
                            minhasFlags.argumentoValido = false;
                            break;
                    }

                    // Saída
                
                    if(!minhasFlags.arquivoEntradaExiste) Console.WriteLine("Sem arquivo de entrada. Encerrando...");
                    else if(!minhasFlags.tamanhoMatrizCoincide) Console.WriteLine("Tamanho da matriz no arquivo de entrada difere dos argumentos informados. Encerrando...");
                    else if(!minhasFlags.moduloPronto) Console.WriteLine("Desculpe, mas infelizmente o módulo ainda não está pronto. Encerrando...");
                    else if(((moduloChamado == "id") || (moduloChamado == "orto") || (moduloChamado == "trinf") || (moduloChamado == "trsup")) && (!minhasFlags.matrizQuadrada)) Console.WriteLine("Para o módulo escolhido, é preciso que a matriz seja quadrada. Encerrando...");
                    else
                    {
                        switch(moduloChamado)
                        {
                            case "aleat":
                                Console.WriteLine("Matriz Aleatória {0} x {1}:", numeroLinhas, numeroColunas);
                                break;
                            case "id":
                                Console.WriteLine("Matriz Identidade de Ordem {0}:", numeroLinhas);
                                break;
                            case "diag":
                                Console.WriteLine("Matriz Diagonal {0} x {1}:", numeroLinhas, numeroColunas);
                                break;
                            case "toep":
                                Console.WriteLine("Matriz de Toeplitz {0} x {1}:", numeroLinhas, numeroColunas);
                                break;
                            case "orto":
                                Console.WriteLine("Matriz Ortogonal de Ordem {0}:", numeroLinhas);
                                break;
                            case "trinf":
                                Console.WriteLine("Matriz Triangular Inferior de Ordem {0}:", numeroLinhas);
                                break;
                            case "trsup":
                                Console.WriteLine("Matriz Triangular Superior de Ordem {0}:", numeroLinhas);
                                break;
                            case "trans":
                                Console.WriteLine("Matriz Transposta {1} x {0}:", numeroLinhas, numeroColunas);
                                break;
                            default:
                                break;
                        }
                
                        if(moduloChamado == "trans")
                        {
                            for(i=0; i<numeroColunas; ++i){
                                for(j=0; j<numeroLinhas; ++j)
                                    Console.Write("{0}\t", matrizSaida[i,j]);
                                Console.Write("\n");
                            }
                        }
                        
                        else
                        {
                            for (i=0; i<numeroLinhas; ++i){
                                for (j=0; j<numeroColunas; ++j)
                                    Console.Write("{0}\t", matrizRecipiente[i,j]);
                                Console.Write("\n");
                            }
                        }
                    }
                }
                else Console.WriteLine("Argumento inválido. Encerrando...");

            }

        }

    }

}