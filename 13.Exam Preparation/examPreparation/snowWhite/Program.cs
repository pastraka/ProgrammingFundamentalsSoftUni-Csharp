using System;
using System.Collections.Generic;
using System.Linq;

namespace snowWhite
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Dwarf> dwarves = new List<Dwarf>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = line.Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string color = tokens[1];
                int physics = int.Parse(tokens[2]);

                if (dwarves.Where(m => m.Name == name).Count().Equals(0))
                {
                    dwarves.Add(new Dwarf(name, color, physics));
                }
                else if (dwarves.Where(m => m.Name == name && m.Color == color).Count() > 0)
                {
                    int currentDwarfPhysics = dwarves
                        .FirstOrDefault(m => m.Name == name && m.Color == color)
                        .Physics;
                    if (physics > currentDwarfPhysics)
                    {
                        dwarves
                        .FirstOrDefault(m => m.Name == name && m.Color == color)
                        .Physics = physics;
                    }
                }
                else
                {
                    dwarves.Add(new Dwarf(name, color, physics));
                }
            }

            foreach (var dwarf in dwarves.OrderByDescending(m => m.Physics).ThenByDescending(n => dwarves.Where(j => j.Color == n.Color).Count()))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    internal class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
    }
}
