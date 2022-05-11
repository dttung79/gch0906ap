using System;

namespace helloworld 
{
    public class Player
    {
        // declare attributes
        private string name;
        private int age;
        private string position;

        public string GetName()
        {
            return name;
        }


        // Get, Set methods
        public void SetName(string name)
        {
            if (name == "" || name.Length > 100)
            {
                Console.WriteLine("Invalid name");
                return;
            }
            this.name = name;
        }

        // Property for attribute age
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 100)
                {
                    Console.WriteLine("Invalid age");
                    return;
                }
                age = value;
            }
        }

        // declare constructor (special method)

        // default constructor
        public Player()
        {
            name = "John Doe";
            age = 20;
            position = "Midfielder";
        }
        // parameterized constructor
        public Player(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        // declare methods
        // show player info
        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player name: {0}", this.name);
            Console.WriteLine("Player age: {0}", this.age);
            Console.WriteLine("Player position: {0}", this.position);
        }

        public int ExtraSalary(int minutes)
        {
            if (minutes <= 1000) return 0;
            if (minutes <= 2000) return 500000;
            if (minutes <= 3000) return 1000000;
            return 1500000;
        }
    }
}