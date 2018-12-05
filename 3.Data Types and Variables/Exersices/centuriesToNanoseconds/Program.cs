using System;
using System.Numerics;

namespace centuriesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            long seconds = 60L * minutes;
            long milliseconds = 1000 * seconds;
            ulong microsecodns = 1000 * (ulong)milliseconds;
            BigInteger nanoseconds = (BigInteger)1000 * microsecodns;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microsecodns} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
