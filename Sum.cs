using System;

namespace MyApp
{
    class Sum
    {
        public static void run()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");
        }
    }
}