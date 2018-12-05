using System;
using System.Collections.Generic;
using System.Linq;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            //създаваме речник и лист понеже за всяка страна има повече от един член

            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                //проверка на първият случай 

                if (command.Contains("|"))
                {
                    string[] info = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    //използваме трим понеже имаме случай със първо и второ име на един герой

                    string name = info[1].Trim();
                    string side = info[0].Trim();

                    //пълним речника и листа 

                    if (forces.Values.Any(x => x.Contains(name)) == false)
                    {
                        if (forces.ContainsKey(side) == false)
                        {
                            forces.Add(side, new List<string>() { name });
                        }
                        else
                        {
                            forces[side].Add(name);
                        }
                    }
                }
                // втори случай

                else
                {
                    string[] info = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = info[0].Trim();
                    string side = info[1].Trim();

                    //създаваме другата страна към която ще добавяме

                    if (forces.ContainsKey(side) == false)
                    {
                        forces.Add(side, new List<string>());
                    }

                    if (forces.Values.Any(x => x.Contains(name)))
                    {
                        //проверяваме дали се съдържа ако не го добавяме 

                        foreach (var pair in forces)
                        {
                            if (pair.Value.Contains(name))
                            {
                                // ако се съдържа го премахваме
                                forces[pair.Key].Remove(name);
                            }
                        }
                    }
                    //присъединяваме го към новото място 

                    forces[side].Add(name);
                    Console.WriteLine($"{name} joins the {side} side!");
                }

                command = Console.ReadLine();
            }
            // сортиране и изписване 
            
            // !!! ПРИ ВЛОЖЕНИ РЕЧНИЦИ ЗДЪЛЖИТЕЛНО ФЛОЖЕН ЦИКЪЛ ПРИ ИЗПИСВАНЕ !!!

            foreach (var pair in forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");

                    foreach (var member in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
