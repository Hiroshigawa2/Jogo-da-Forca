using System;
using System.Text;

namespace Jogo_da_Forca
{
    internal class Tela
    {
        public string Inicio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" _____");
            sb.AppendLine("|  ___|");
            sb.AppendLine("| |___    _     _ __   __   _____");
            sb.AppendLine("|  ___| / _ \\  | '__| / _| |  _  |");
            sb.AppendLine("| |    | (_) | | |   | |_  | |_| |");
            sb.AppendLine("|_|     \\___/  |_|    \\__| |_| |_|");
            sb.AppendLine("                          Por Leandro Alves!");
            sb.AppendLine("");
            sb.AppendLine("Para este jogo, foi utilizado varias palavras com no maximo cinco letras, boa sorte!");

            return sb.ToString();
        }




    }
}
