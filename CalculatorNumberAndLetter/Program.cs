using System;

namespace CalculatorNumberAndLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentation();
        }

        private static void Presentation()
        {
            Console.WriteLine("Dasturga hush kelibsiz");
            string selection;
            do
            {
                Console.Write("matn kiriting: ");
                string text = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Services.DigitsOnly(text);
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Davom etishni xohlasangiz (xa)ni bosing: ");
                selection = Console.ReadLine().ToLower();
            } while (selection == "xa");
        }
    }
}
