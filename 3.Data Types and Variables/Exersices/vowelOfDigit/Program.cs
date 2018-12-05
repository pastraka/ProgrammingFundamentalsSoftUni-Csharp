using System;

namespace vowelOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' || input == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
