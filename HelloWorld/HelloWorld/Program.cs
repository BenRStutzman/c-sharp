﻿using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.Name = "Congo";
            f.Trees = 0;
            f.age = 0;
            f.Biome = "Neptune";
            Console.WriteLine(f.Biome);

            Console.WriteLine(f.Name);
        }
    }
}
