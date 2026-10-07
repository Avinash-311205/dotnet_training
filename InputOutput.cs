using System;

namespace MyApp
{
    class InputOutput
    {
        public static void run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Vannakam {name}!");
        }
    }
}