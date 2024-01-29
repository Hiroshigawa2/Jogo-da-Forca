using System;
using System.IO;
using Partida;

namespace Jogo_da_Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            try
            {
                Tela tela = new Tela();
                Console.WriteLine(tela.Inicio());

                Partidaforca partida = new Partidaforca();

                while (!partida.terminada)
                {
                    partida.Jogando();
                    partida.terminada = true;
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
