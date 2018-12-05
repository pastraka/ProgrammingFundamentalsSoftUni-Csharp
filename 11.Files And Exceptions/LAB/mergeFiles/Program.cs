using System;
using System.IO;

namespace mergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Directory.CreateDirectory(@"C:\Users\Toshiba\Desktop\Files\testFolder\Test");

            Directory.Move(@"C:\Users\Toshiba\Desktop\Files\testFolder\Test",
                @"C:\Users\Toshiba\Desktop\Test");

            //Directory.Delete(@"C:\Users\Toshiba\Desktop\Test");

        }
    }
}
