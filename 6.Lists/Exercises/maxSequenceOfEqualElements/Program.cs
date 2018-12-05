using System;
using System.Collections.Generic;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int maxNumber = 0;
            //int maxCounter = 0;

            //foreach (int num1 in nums)
            //{
            //    int counter = 0;

            //    foreach (int num2 in nums)
            //    {
            //        if (num1 == num2)
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter > maxCounter)
            //    {
            //        maxCounter = counter;
            //        maxNumber = num1;
            //    }
            //}
            //for (int i = 0; i < maxCounter; i++)
            //{
            //    Console.Write($"{maxNumber} ");
            //}
            //Console.WriteLine();
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxNumber = nums[0];
            int maxCounter = 1;
            int counter = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxNumber = nums[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumber} ");
            }
        }
    }
}
