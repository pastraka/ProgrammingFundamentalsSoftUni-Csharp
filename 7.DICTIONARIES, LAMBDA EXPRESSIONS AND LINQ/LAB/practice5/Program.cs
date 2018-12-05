using System;
using System.Linq;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' '};
            string sentence = Console.ReadLine().ToLower();
            string[] word = sentence.Split(separators);

            string[] result = word.Where(w => w != "").Where(x => x.Length < 5).OrderBy(w => w).Distinct().ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
