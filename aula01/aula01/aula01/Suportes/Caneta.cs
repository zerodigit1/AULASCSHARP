using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01.Suportes
{
    public class Caneta
    {
        static public void Escreve(string args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "AULA01";
            Console.WriteLine("Voce Escreveu: "+args);
        }
    }
}
