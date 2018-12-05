using System;

namespace foreignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string countryName = name.ToLower();
            if (countryName == "england" || countryName == "usa")
            {
                Console.WriteLine("English");
            } else if (countryName == "spain" || countryName == "argentina" || countryName == "mexico")
            {
                Console.WriteLine("Spanish");
            } else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
