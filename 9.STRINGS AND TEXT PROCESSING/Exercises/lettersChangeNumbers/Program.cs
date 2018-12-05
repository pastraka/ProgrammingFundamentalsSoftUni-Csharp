using System;

namespace lettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];
                string numberAsString = word.Substring(1, word.Length - 2);
                int number = int.Parse(numberAsString);

                double sum = 0;
                if (char.IsUpper(first))
                {
                    sum += number / (first - 64.0);
                }
                else
                {
                    sum += number * (first - 96.0);
                }

                if (char.IsUpper(last))
                {
                    sum -= (last - 64.0);
                }
                else
                {
                    sum += (last - 96.0);
                }
                totalSum += sum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
