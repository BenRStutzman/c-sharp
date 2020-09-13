using System;
using System.Linq;

namespace BasicClasses
{
    class Forest
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int trees;
        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        }
        public int age;
        public string biome;
        public string Biome
        {
            get { return biome; }
            set
            {
                string[] options = { "Tropical", "Temperate", "Boreal" };
                if (options.Contains(value))
                {
                    Console.WriteLine("It's valid.");
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

    }

}
