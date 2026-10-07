using System;

namespace MyApp
{
    class Calculator
    {
        public static void run()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
        }
    }
}