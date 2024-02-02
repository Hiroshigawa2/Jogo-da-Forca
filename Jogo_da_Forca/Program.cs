using System;
using System.IO;
using Partida;

namespace Jogo_da_Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partidaforca partida = new Partidaforca();
            try
            {
                while (!partida.terminada)
                {
                    Console.Clear();

                    partida.escolherPalavra();
                    partida.jogando();

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro do Arquivo não encontrado");
                Console.WriteLine(e.Message);
            }
        }
    }
}