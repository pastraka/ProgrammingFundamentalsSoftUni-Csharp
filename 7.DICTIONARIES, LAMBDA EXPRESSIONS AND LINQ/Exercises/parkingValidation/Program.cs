using System;
using System.Collections.Generic;

namespace parkingValidation
{
    class Program
    {
        public static bool LicenseValidation { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> userBook = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string registerCommand = command[0];
                string userName = command[1];

                if (registerCommand == "register")
                {
                    string licensePlateNum = command[2];
                    if (userBook.ContainsKey(userName) == false)
                    {
                        if (LicenseValidations(licensePlateNum) == false)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlateNum}");
                        }
                        else if (userBook.ContainsKey(licensePlateNum))
                        {
                            Console.WriteLine($"ERROR: license plate {licensePlateNum} is busy");
                        }
                        else
                        {
                            userBook.Add(userName, licensePlateNum);
                            Console.WriteLine($"{userName} registered {licensePlateNum} successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userBook[userName]}");
                    }
                }
                else if (registerCommand == "unregister")
                {
                    if (userBook.ContainsKey(userName) == false)
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        userBook.Remove(userName);
                        Console.WriteLine($"user {userName} unregistered successfully");
                    }
                }
            }
            foreach (var pair in userBook)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }


        static bool LicenseValidations(string licensePlateNum)
        {
            string validation = licensePlateNum.Substring(0, 2) + licensePlateNum.Substring(6, 2);
            bool firstValidation = false;

            foreach (var symbol in validation)
            {
                if (symbol >= 'A' && symbol <= 'Z')
                {
                    firstValidation = true;
                }
                else
                {
                    firstValidation = false;
                    break;
                }
            }
            string midNums = licensePlateNum.Substring(2, 4);
            bool midValidation = false;

            foreach (var number in midNums)
            {
                if (number >= '1' && number <= '9')
                {
                    midValidation = true;
                }
                else
                {
                    midValidation = false;
                    break;
                }
            }
            if (midValidation && firstValidation == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
