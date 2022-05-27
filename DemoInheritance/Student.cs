using System;

namespace DemoInheritance
{
    public class Student : Person
    {
        private string school;
        public Student() : base("Nguyen Van An", 25)
        {
            school = "No school";
            Console.WriteLine("Default Student constructor is called");
        }
        public Student(string name, int age, string school)
        {
            this.school = school;
            Console.WriteLine("Parameterized Student constructor is called");
        }

        public void ShowInfo()
        {
            base.ShowInfo();  // use base keyword to refer to base class
            Console.WriteLine("School: {0}", school);
        }
        
    }
}