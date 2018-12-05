using System;

namespace softUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeEF1 = int.Parse(Console.ReadLine());
            int employeeEF2 = int.Parse(Console.ReadLine());
            int employeeEF3 = int.Parse(Console.ReadLine());
            int strudentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = employeeEF1 + employeeEF2 + employeeEF3;
            int hours = 0;

            while (strudentsCount > 0)
            {
                strudentsCount -= studentsPerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
