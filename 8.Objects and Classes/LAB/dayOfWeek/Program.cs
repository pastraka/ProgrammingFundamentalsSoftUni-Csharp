using System;
using System.Globalization;

namespace dayOfWeek
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfYear);
        }
    }
}
