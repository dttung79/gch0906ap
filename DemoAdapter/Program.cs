using System;
using System.Collections.Generic;

namespace DemoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John", 30, 1000);
            Employee paul = new Saler("Paul", 25, 300, 20);
            Employee mary = new MaidEmployee("Mary", 20, 10);

            List<Employee> employees = new List<Employee>();
            employees.Add(john);
            employees.Add(paul);
            employees.Add(mary);

            foreach (Employee emp in employees)
            {
                emp.Pay("January");
            }
        }
    }
}
