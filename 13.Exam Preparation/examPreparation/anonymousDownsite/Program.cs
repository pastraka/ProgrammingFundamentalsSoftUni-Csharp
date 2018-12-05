using System;
using System.Linq;
using System.Numerics;

namespace anonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int websitesDown = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLost = 0;

            for (int i = 0; i < websitesDown; i++)
            {
                string[] siteData = Console.ReadLine().Split().ToArray();
                string siteName = siteData[0];
                long siteVisits = long.Parse(siteData[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(siteData[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;

                totalLost += siteLoss;

                Console.WriteLine(siteName);
            }
            BigInteger secutityToken = BigInteger.Pow(securityKey, websitesDown);
            Console.WriteLine($"Total Loss: {totalLost:f20}");
            Console.WriteLine($"Security Token: {secutityToken}");
        }
    }
}
