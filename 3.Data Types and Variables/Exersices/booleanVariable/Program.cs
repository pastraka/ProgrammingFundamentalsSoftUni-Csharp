using System;

namespace booleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            Convert.ToBoolean(value);

            if(value == "True")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
