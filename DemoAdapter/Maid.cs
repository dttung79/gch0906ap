using System;

namespace DemoAdapter
{
    public class Maid
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rate { get; set; }
        public Maid(string name, int age, int rate)
        {
            Name = name;
            Age = age;
            Rate = rate;
        }
        public int GetSalary(int days)
        {
            return Rate * days;
        }
    }
}