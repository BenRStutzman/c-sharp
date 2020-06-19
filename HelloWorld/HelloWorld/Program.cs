using System;
using System.Xml;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {name} on {date:d} at {date:t}!");
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                output += name;
                Console.WriteLine(output);
            }
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
