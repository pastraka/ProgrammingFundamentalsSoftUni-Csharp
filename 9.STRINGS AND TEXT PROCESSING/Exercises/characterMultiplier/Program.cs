using System;

namespace characterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string line1 = input[0];
            string line2 = input[1];

            int minLength = Math.Min(line1.Length, line2.Length);
            int maxLenght = Math.Max(line1.Length, line2.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += MultiplyChars(line1[i], line2[i]);
            }

            if (line1.Length != line2.Length)
            {
                string longerString = line1.Length > line2.Length ? longerString = line1 : longerString = line2;

                for (int i = minLength; i < maxLenght; i++)
                {
                    sum += longerString[i];
                }
            }
            Console.WriteLine(sum);
        }

        static int MultiplyChars(char str1, char str2)
        {
            int multiply = str1 * str2;

            return multiply;
        }
    }
}
