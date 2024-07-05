using System;

namespace CalculatorNumberAndLetter
{
    internal class Services
    {
        public static void DigitsOnly(string str)
        {
            int numberOfDigits = 0;
            int numberOfLetters = 0;
            int numberOfCharacters = 0;

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    numberOfDigits++;
                }
                else if (char.IsLetter(c))
                {
                    numberOfLetters++;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    numberOfCharacters++;
                }
            }
            Console.WriteLine($"\nCalculating!!!");
            Console.WriteLine($"Matndagi raqamlar soni: {numberOfDigits}");
            Console.WriteLine($"Matndagi harflar soni:  {numberOfLetters}");
            Console.WriteLine($"Boshqa belgilar soni:   {numberOfCharacters}\n");
        }
    }
}
