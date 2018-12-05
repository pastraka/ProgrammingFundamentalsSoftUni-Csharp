using System;

namespace differentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isLong = long.TryParse(input, out long longResulut);
            if (isLong == false)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{input} can fit in:");

                bool isSbyte = sbyte.TryParse(input, out sbyte sByteResulut);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }

                bool isByte = byte.TryParse(input, out byte btyeResulut);
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }

                bool isShort = short.TryParse(input, out short shortResulut);
                if (isShort)
                {
                    Console.WriteLine("* short");
                }

                bool isUshort = ushort.TryParse(input, out ushort ushortResulut);
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }

                bool isInt = int.TryParse(input, out int intResulut);
                if (isInt)
                {
                    Console.WriteLine("* int");
                }

                bool isUint = uint.TryParse(input, out uint uintResulut);
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }
        }
    }
}
