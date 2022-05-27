using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ShowInfo();
            System.Console.WriteLine("------------------------");
            s = new Student("John Lennon", 20, "MIT");
            s.ShowInfo();

            Person p = new Person("John Lennon", 20);
            p.ShowInfo();
        }
    }
}
