//using System;
//using System.Collections.Generic;

//namespace memoryView
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string validWord = string.Empty;

//            List<string> words = new List<string>();

//            while (true)
//            {
//                string input = Console.ReadLine();

//                if (input == "Visual Studio crash")
//                {
//                    break;
//                }

//                validWord += input + " ";
//            }
//            //32656 19759 32763
//            string[] token = validWord.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//            for (int i = 0; i < token.Length - 5; i++)
//            {
//                if (token[i] == "32656" && token[i + 1] == "19759" && token[i + 2] == "32763" && token[i + 3] == "0" && token[i + 5] == "0")
//                {
//                    string word = string.Empty;
//                    int wordLenght = int.Parse(token[i + 4]);

//                    for (int j = i + 6; j <= i + 6 + wordLenght; j++)
//                    {
//                        word += (char)(int.Parse(token[j]));
//                    }
//                    words.Add(word);
//                }
//            }
//            Console.WriteLine(string.Join("\n", words));
//        }
//    }
//}

//******************//

//***WITHOUT     LIST***//

//******************//

using System;
namespace memoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            while (input != "Visual Studio crash")
            {
                text += input + " ";
                input = Console.ReadLine();
            }

            //32656 19759 32763

            string[] arr = text.Split();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "32656" && arr[i + 1] == "19759" && arr[i + 2] == "32763")
                {
                    int length = int.Parse(arr[i + 4]);
                    string word = string.Empty;

                    for (int j = 0; j < length; j++)
                    {
                        word += (char)int.Parse(arr[i + 6 + j]);
                    }
                    Console.WriteLine(word);
                    word = string.Empty;
                }
            }
        }
    }
}