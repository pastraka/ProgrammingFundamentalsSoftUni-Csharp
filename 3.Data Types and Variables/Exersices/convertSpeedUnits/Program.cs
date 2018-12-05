using System;

namespace convertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 miles = 1609
            float distanceMeter = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int totalTime = (hours * 60 + minutes) * 60 + seconds;
            float meterPerSeconds = distanceMeter / totalTime;
            float distanceKm = distanceMeter / 1000;
            float totalTimeHours = totalTime / 3600.0f;
            float kmPerHour = distanceKm / totalTimeHours;
            float distanceMiles = distanceMeter / 1609;
            float milesPerHour = distanceMiles / totalTimeHours;

            Console.WriteLine(meterPerSeconds);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
