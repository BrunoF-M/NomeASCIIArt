using System;
using Figgle;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine("+-=-=AsCIIArt=-=-+");
            Console.WriteLine();
            Console.ResetColor();

            string nome;

            Console.Write(" Digite uma qualquer coisa: ");
            nome = Console.ReadLine();

            string texto = FiggleFonts.Starwars.Render(nome);

            Console.ForegroundColor=ConsoleColor.DarkGreen;                        
            Console.WriteLine($" {texto}");
            Console.ResetColor();

            Console.Write("enter to finish...");
            Console.ReadKey();
        }
    }
}