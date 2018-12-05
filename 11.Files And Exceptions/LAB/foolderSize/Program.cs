using System;
using System.IO;

namespace foolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allFiles = Directory.GetFiles(@"C:\Users\Toshiba\Desktop\Files\testFolder");

            double sum = 0;

            foreach (var file in allFiles)
            {
                FileInfo info = new FileInfo(file);
                sum += info.Length;     
            }

            double result = sum / 1024 / 1024;

            File.WriteAllText(@"..\..\..\output.txt", result.ToString());
        }
    }
}
