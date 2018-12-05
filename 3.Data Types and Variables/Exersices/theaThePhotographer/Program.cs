using System;

namespace theaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureNumber = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadedTime = int.Parse(Console.ReadLine());
            int filterPictures = (int)Math.Ceiling(pictureNumber * filterFactor / 100.0);
            long timeToFilter = (long)pictureNumber * filterTime;
            long timeToUpload = (long)filterPictures * uploadedTime;
            long totalTime = timeToFilter + timeToUpload;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string timeReady = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(timeReady);
        }
    }
}
