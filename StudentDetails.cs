using System;

namespace MyApp
{
    class StudentDetails
    {
        public static void run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Department: ");
            string department = Console.ReadLine();
            Console.Write("Enter college name: ");
            string college = Console.ReadLine();
            Console.WriteLine("Student Details");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"College: {college}");
        }
    }
}