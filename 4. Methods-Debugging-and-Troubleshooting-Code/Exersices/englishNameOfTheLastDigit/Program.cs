using System;

namespace englishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string lastDigitName = GetLastDigitName(num);
            Console.WriteLine(lastDigitName);
        }

        static string GetLastDigitName(long num)
        {
            num = Math.Abs(num);
            long digit = num % 10;
            string lastDigitName = "";

            switch (digit)
            {
                case 0: lastDigitName = "zero";
                    break;
                case 1:
                    lastDigitName = "one";
                    break;
                case 2:
                    lastDigitName = "two";
                    break;
                case 3:
                    lastDigitName = "three";
                    break;
                case 4:
                    lastDigitName = "four";
                    break;
                case 5:
                    lastDigitName = "five";
                    break;
                case 6:
                    lastDigitName = "six";
                    break;
                case 7:
                    lastDigitName = "seven";
                    break;
                case 8:
                    lastDigitName = "eight";
                    break;
                case 9:
                    lastDigitName = "nine";
                    break;
            }
            return lastDigitName;
        }
    }
}
