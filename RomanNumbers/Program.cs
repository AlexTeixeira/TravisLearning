using System;

namespace RomanNumbers
{
    class Program
    {
        static Converter convert = new Converter();
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var roman = convert.Convert(input);

            Console.WriteLine(roman);
            Console.ReadLine();
        }
    }
}
