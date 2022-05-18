using System;
using System.Collections.Generic;

namespace ProjectManagement
{
    public class Project
    {
        private string name;
        private double budget;
        private List<Member> members;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Project()
        {
            name = "Project X";
            budget = 1000;
            members = new List<Member>();
        }

        public Project(string name, double budget)
        {
            Name = name;
            Budget = budget;
            members = new List<Member>();
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        // Remove a member from project
        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }
        // Get number of members in project
        public int NumberOfMembers()
        {
            return members.Count;
        }

        public void Show()
        {
            Console.WriteLine("Project name: {0}", Name);
            Console.WriteLine("Budget: ${0}", Budget);
            Console.WriteLine("Members:");
            foreach (Member member in members)
            {
                member.Show();
            }
        }
    }
}