using System;

namespace censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string replace = new string('*', word.Length);
            string text = Console.ReadLine().Replace(word, replace);

            Console.WriteLine(text);
        }
    }
}
