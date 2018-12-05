using System;
using System.Numerics;

namespace snowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBallsCount = int.Parse(Console.ReadLine());
            int totalSnow = 0;
            int totalTime = 0;
            int totalQuality = 0;
            BigInteger snowBallValue = 0;//-1; също може да се позва като най ниска стойност

            for (int i = 0; i < snowBallsCount; i++)
            {

                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger currentBall = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);

                if (currentBall > snowBallValue)
                {
                    snowBallValue = currentBall;
                    totalSnow = snowBallSnow;
                    totalTime = snowBallTime;
                    totalQuality = snowBallQuality;
                }
            }

            Console.WriteLine($"{totalSnow} : {totalTime} = {snowBallValue} ({totalQuality})");
        }
    }
}
