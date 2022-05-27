using System;

namespace DemoInheritance
{
    public class Person
    {
        private string name;
        protected int age;

        // default constructor
        public Person()
        {
            name = "John Doe";
            age = 0;
            Console.WriteLine("Default constructor is called");
        }
        // parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameterized constructor is called");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
        }


    }
}