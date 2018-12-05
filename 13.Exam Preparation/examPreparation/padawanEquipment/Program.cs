using System;

namespace padawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivanChoMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int sabreCount = Convert.ToInt32(Math.Ceiling(studentsCount * 1.1));
            int robesCount = studentsCount;
            int beltCount = studentsCount - studentsCount / 6;

            double totalMoney = sabreCount * lightSaberPrice + robesCount * robePrice + beltCount * beltsPrice;

            if (totalMoney <= ivanChoMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - ivanChoMoney:f2}lv more.");
            }
        }
    }
}