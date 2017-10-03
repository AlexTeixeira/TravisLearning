using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class Converter : IConverter
    {
        int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numerals = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        IParser parser = new Parser();

       
        public string Convert(string s)
        {
            var number = parser.ParseString(s);

            if (number == 0)
            {
                return "N";
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                // If the number being converted is less than the test value, append
                // the corresponding numeral or numeral pair to the resultant string
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            return result.ToString();
        }
    }
}
