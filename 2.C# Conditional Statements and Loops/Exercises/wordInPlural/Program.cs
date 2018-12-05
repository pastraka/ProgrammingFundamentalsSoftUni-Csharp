using System;

namespace wordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                Console.WriteLine("{0}", noun + "ies");
            }//ch, s, sh, x, z
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") 
                || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") ||
                noun.EndsWith("z"))
            {
                Console.WriteLine("{0}", noun + "es");
            } else
            {
                Console.WriteLine("{0}", noun + "s");
            }
        }
    }
}
