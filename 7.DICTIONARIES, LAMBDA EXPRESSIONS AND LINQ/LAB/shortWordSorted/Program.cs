using System;
using System.Linq;

namespace shortWordSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);

            string[] result = words.Where(w => w != "").Where(x => x.Length < 5).OrderBy(w => w).Distinct().ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
