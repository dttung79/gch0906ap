using System;

namespace DemoException
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set 
            { 
                if (value != "") name = value;
                else throw new ArgumentException("Name cannot be empty");
            }
        }
        public int Age
        {
            get { return age; }
            set 
            { 
                if (value > 18) age = value;
                else throw new ArgumentException("Age must be greater than 0");
            }
        }
    }
}