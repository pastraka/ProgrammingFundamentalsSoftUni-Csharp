using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shcedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] line = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                if (command == "course start")
                {
                    break;
                }
                else if (command == "Add")
                {
                    if (shcedule.Contains(line[1]) == false)
                    {
                        shcedule.Add(line[1]);
                    }
                }
                else if (command == "Insert")
                {
                    string title = line[1];
                    int index = int.Parse(line[2]);
                    if (shcedule.Contains(title) == false)
                    {
                        shcedule.Insert(index, title);
                    }
                }
                else if (command == "Remove")
                {
                    if (shcedule.Contains(line[1]))
                    {
                        shcedule.Remove(line[1]);
                        shcedule.Remove($"{line[1]}-Exercise");
                    }
                }
                else if (command == "Swap")
                {
                    string title1 = line[1];
                    string title2 = line[2];

                    int index1 = shcedule.IndexOf(title1);
                    int index2 = shcedule.IndexOf(title2);

                    if (index1 != - 1 && index2 != - 1)
                    {
                        shcedule[index1] = title2;
                        shcedule[index2] = title1;

                        if (index1 + 1 < shcedule.Count && shcedule[index1 + 1] == $"{title1}-Exercise")
                        {
                            shcedule.RemoveAt(index1 + 1);
                            index1 = shcedule.IndexOf(title1);
                            shcedule.Insert(index1 + 1, $"{title1}-Exercise");
                        }
                        if (index2 + 1 < shcedule.Count && shcedule[index2 + 1] == $"{title2}-Exercise")
                        {
                            shcedule.RemoveAt(index2 + 1);
                            index2 = shcedule.IndexOf(title2);
                            shcedule.Insert(index2 + 1, $"{title2}-Exercise");
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    int index = shcedule.IndexOf(line[1]);
                    if (shcedule.Contains(line[1]) && !shcedule.Contains($"{line[1]}-Exercise"))
                    {
                        shcedule.Insert(index + 1, $"{line[1]}-Exercise");
                    }
                    else if (shcedule.Contains(line[1]) == false)
                    {
                        shcedule.Add(line[1]);
                        shcedule.Add($"{line[1]}-Exercise");
                    }
                }
            }
            for (int i = 0; i < shcedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{shcedule[i]}");
            }
        } 
    }
}
