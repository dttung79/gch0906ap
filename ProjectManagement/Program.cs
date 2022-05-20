using System;
using System.Collections.Generic;
namespace ProjectManagement
{
    class Program
    {
        internal static void Main(string[] args)
        {
            // Ask how many projects will be created
            Console.WriteLine("How many projects will be created?");
            int nProjects = int.Parse(Console.ReadLine());
            List<Project> projects = new List<Project>();
            for (int i = 0; i < nProjects; i++)
            {
                Project p = CreateNewProject();
                projects.Add(p);
            }
            foreach (Project p in projects)
            {
                p.Show();
                System.Console.WriteLine("------------------------");
            }
        }

        private static Project CreateNewProject()
        {
            //      Ask for project name, budget
            Console.WriteLine("Enter project name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter project budget:");
            double budget = Double.Parse(Console.ReadLine());
            Project p = new Project(name, budget);
            //     Ask for number of members
            Console.WriteLine("How many members in this project?");
            int nMembers = int.Parse(Console.ReadLine());
            for (int i = 0; i < nMembers; i++)
            {
                Member m = CreateNewMember();
                p.AddMember(m);
            }
            return p;
        }

        private static Member CreateNewMember()
        {
            //      Ask for member name, experience, role
            Console.WriteLine("Enter member name:");        string name     = Console.ReadLine();
            Console.WriteLine("Enter member experience:");  int experience  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter member role:");        string role     = Console.ReadLine();
            
            Member m = new Member(name, experience, role);
            return m;
        }
    }
}
