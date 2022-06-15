using System;

namespace DemoAdapter
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual void Pay(string month)
        {
            Console.WriteLine("{0} is paid ${1} for month {2}", Name, Salary, month);
        }
    }

    public class Saler : Employee
    {
        public int Bonus { get; set; }
        public Saler (string name, int age, int salary, int bonus) : base(name, age, salary)
        {
            Bonus = bonus;
        }
        public override void Pay(string month)
        {
            Console.Write("Enter number of contracts: ");
            int contracts = int.Parse(Console.ReadLine());
            Salary += Bonus * contracts;
            base.Pay(month);
        }
    }

    public class MaidEmployee : Employee
    {
        private Maid emp;
        public MaidEmployee(string name, int age, int rate) : base(name, age, 0)
        {
            emp = new Maid(name, age, rate);
        }
        public override void Pay(string month)
        {
            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());
            Salary = emp.GetSalary(days);
            base.Pay(month);
        }
    }
}