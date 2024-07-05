using System;

namespace CalculatorNumberAndLetter
{
    internal class Services
    {
        public static int DigitsOnly(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int LettersOnly(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int OtherCharacters(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
