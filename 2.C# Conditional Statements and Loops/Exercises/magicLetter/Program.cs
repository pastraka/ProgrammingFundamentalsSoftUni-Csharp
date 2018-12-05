using System;

namespace magicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char line1 = char.Parse(Console.ReadLine());
            char line2 = char.Parse(Console.ReadLine());
            char magic = char.Parse(Console.ReadLine());

            for (char i = line1; i <= line2; i++)
            {
                for (char j = line1; j <= line2; j++)
                {
                    for (char k = line1; k <= line2; k++)
                    {
                        if (i == magic || j == magic || k == magic)
                        {

                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
     
                    }
                }
            }
        }
    }
}
