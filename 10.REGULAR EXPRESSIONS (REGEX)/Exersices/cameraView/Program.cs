using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace cameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\|<(?<picture>\w+)");

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipElemenst = input[0];
            int takeElements = input[1];

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            string[] allResults = new string[matches.Count];
            int index = 0;

            foreach (Match match in matches)
            {
                string currentMatch = match.Groups["picture"].Value;

                char[] result = currentMatch
                    .Skip(skipElemenst)
                    .Take(takeElements)
                    .ToArray();

                string currentResult = string.Join("", result);
                allResults[index++] = currentResult;
            }
            Console.WriteLine(string.Join(", ", allResults));
        }
    }
}
