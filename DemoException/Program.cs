using System;
using System.Collections.Generic;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // try
            // {
            //     // enter number a
            //     Console.Write("Enter number a: ");
            //     int a = int.Parse(Console.ReadLine());
            //     // enter number b
            //     Console.Write("Enter number b: ");
            //     int b = int.Parse(Console.ReadLine());
            //     int c = a / b;
            //     Console.WriteLine("{0} / {1} = {2}", a, b, c);
            // }
            // catch (DivideByZeroException ex)
            // {
            //     //Console.WriteLine("Divide by zero exception");
            //     Console.WriteLine(ex.Message);
            // }
            // catch (FormatException ex)
            // {
            //     //Console.WriteLine("Cannot convert to number");
            //     Console.WriteLine(ex.Message);
            // }
            
            // System.Console.WriteLine("Press any key to exit");
            // System.Console.ReadKey();
            // try
            // {
            //     List<int> numbers = new List<int>();
            //     int n = EnterNumber("Enter number n: ");
            //     int sum = 0;
            //     for (int i = 0; i < n; i++)
            //     {
            //         int a = EnterNumber("Enter number " +  i + ": ");
            //         numbers.Add(a);
            //         sum += a;
            //     }
            //     int k = EnterNumber("Enter position k: ");
            //     double percent = numbers[k] * 100 / sum;
            //     Console.WriteLine("{0}%", percent);
            // }
            // catch (IndexOutOfRangeException)
            // {
            //     Console.WriteLine("Index out of range");
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Divide by zero exception");
            // }
            try
            {
                Student s = new Student();
                Console.Write("Enter name: ");
                s.Name = Console.ReadLine();
                Console.Write("Enter age: ");
                s.Age = EnterNumber("Enter age: ");
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Age);
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int EnterNumber(string message)
        {
            Console.Write(message);
            bool valid = false;
            int n = 0;
            while (!valid)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Please try again.");
                    Console.Write(message);
                }
            }
            return n;
        }
    }
    
}
