using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace extractSentencesBuKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();

            string pattern = $@"\b{keyWord}\b";

            Regex regex = new Regex(pattern);

            string[] text = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

            foreach (string word in text)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
