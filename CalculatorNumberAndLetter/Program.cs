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
            Print("Dasturga xush kelibsiz");
            Console.Write("matn kiriting: ");
            string text = Console.ReadLine();

            Print("Hisoblash jarayonida...");
            Print($"Matndagi raqamlar soni: {Services.GetDigitsCounter(text)} ta");
            Print($"Matndagi harflar soni:  {Services.GetLettersCounter(text)} ta");
            Print($"Boshqa belgilar soni:   {Services.GetOtherCharactersCounter(text)} ta");
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}