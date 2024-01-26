using System;
using System.IO;

namespace Partida
{
    internal class Partidaforca
    {
        public String palavras { get; set; }
        public FileInfo palavrasDoJogo { get; set; }
        public string[] listaDePalavras { get; set; }
        public bool terminada { get; set; }

        public Partidaforca()
        {
            this.palavras = @"D:\Documentos\Estudos\C#\Projetos\Jogo_da_Forca\Palavras.txt";
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

        public string escolherPalavra()
        {
            listaDePalavras = File.ReadAllLines(palavrasDoJogo.FullName);
            Random rand = new Random();
            int rand_num = rand.Next(0, this.listaDePalavras.Length);
            string palavraEscolhida = this.listaDePalavras[rand_num];
            return palavraEscolhida;
        }

        public void letrasDaPalavra()
        {
            string palavra = escolherPalavra();
            char[] letrasPalavra = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                letrasPalavra[i] = palavra[i];
            }
        }

        public void letrasOcultas()
        {
            string palavra = escolherPalavra();
            char[] letrasPalavra = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                letrasPalavra[i] = palavra[i];
            }
        }


    }
}