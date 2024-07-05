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
            Print("Dasturga hush kelibsiz");
            Console.Write("matn kiriting: ");
            string text = Console.ReadLine();

            Print("Calculating!!!");
            Print($"Matndagi raqamlar soni: {Services.DigitsOnly(text)}");
            Print($"Matndagi harflar soni:  {Services.LettersOnly(text)}");
            Print($"Boshqa belgilar soni:   {Services.OtherCharacters(text)}");
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
