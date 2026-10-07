using System;

namespace MyApp
{
    class Greetings
    {
        public static void run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine($"Vannakam da {name}!, you are from {city}!");
        }
    }
}