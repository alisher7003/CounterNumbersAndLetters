using System;

namespace CalculatorNumberAndLetter
{
    internal class Services
    {
        public static int GetDigitsCounter(string str)
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

        public static int GetLettersCounter(string str)
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

        public static int GetOtherCharactersCounter(string str)
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