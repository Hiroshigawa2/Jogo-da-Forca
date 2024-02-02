using Jogo_da_Forca;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Partida
{
    internal class Partidaforca
    {
        public String palavras { get; set; }
        public FileInfo palavrasDoJogo { get; set; }
        public string[] listaDePalavras { get; set; }
        public char[] letrasPalavra { get; set; }
        public char[] letrasOcultas { get; set; }
        public HashSet<char> letrasTentadas { get; set; }

        public bool terminada { get; set; }
        public string palavraEscolhida { get; set; }


        public Partidaforca()
        {
            this.palavras = @"D:\Documentos\Estudos\Projetos\Jogo_da_Forca\Palavras.txt";
            palavrasDoJogo = new FileInfo(this.palavras);
            this.terminada = false;
        }

        public void imprimirPalavras()
        {
            listaDePalavras = File.ReadAllLines(palavrasDoJogo.FullName);
            foreach (var item in listaDePalavras)
            {
                Console.WriteLine(item);
            }
        }

        public void escolherPalavra()
        {
            listaDePalavras = File.ReadAllLines(palavrasDoJogo.FullName);
            Random rand = new Random();
            int rand_num = rand.Next(0, this.listaDePalavras.Length);
            palavraEscolhida = this.listaDePalavras[rand_num];
        }

        public void jogando()
        {

            letrasPalavra = new char[palavraEscolhida.Length];
            letrasOcultas = new char[palavraEscolhida.Length];
            letrasTentadas = new HashSet<char>();


            int cont = 0;

            for (int i = 0; i < palavraEscolhida.Length; i++)
            {
                letrasPalavra[i] = palavraEscolhida[i];
                letrasOcultas[i] = '-';
            }

            while (terminada == false)
            {
                Console.Clear();


                Tela tela = new Tela();
                Console.WriteLine(tela.Inicio());


                Console.WriteLine("Letras já usadas: ");

                foreach (char letra in letrasTentadas)
                {
                    Console.Write(letra + " ");
                }



                Console.WriteLine();
                Console.WriteLine("Você errou " + cont + " vezes, falta " + (5 - cont) + " tentativas");
                


                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    Console.Write(letrasOcultas[i] + "  ");
                }
                Console.WriteLine();

                Console.Write("Digite uma letra: ");
                char palpite = char.Parse(Console.ReadLine());

                letrasTentadas.Add(palpite);


                bool check = false;


                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    if (palpite == letrasPalavra[i])
                    {
                        for (int j = 0; j < palavraEscolhida.Length; j++)
                        {
                            letrasOcultas[i] = palpite;
                            if (letrasOcultas[i] == palpite)
                            {
                                check = true;
                            }
                        }
                    }
                }

                if (check == false)
                {
                    cont = cont + 1;
                }

                Console.WriteLine();
                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    Console.Write(letrasOcultas[i] + "  ");
                }

                Console.WriteLine();
                Console.WriteLine("Você errou " + cont + " vezes, falta " + (5 - cont) + " tentativas");

                

                Console.WriteLine();
                Console.Write("Gostaria de tentar adivinhar (s/n)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Qual a palavra? ");
                    string tentativa = Console.ReadLine();
                    if (resp == 's' || resp == 'S')
                    {
                        Console.WriteLine();
                        Console.Write("ACERTOU ");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("ERROU!");
                        Console.Write("A palavra era: " + palavraEscolhida);
                    }
                }

                if (cont >= 5)
                {
                    Console.WriteLine();
                    Console.Write("PERDEU!");
                    Console.Write("A palavra era: " + palavraEscolhida);
                    Console.WriteLine();
                }

            }
        }
        
    }
}