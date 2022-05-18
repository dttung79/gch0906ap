using System;

namespace ProjectManagement
{
    public class Member
    {
        private string name;
        private int years;
        private string role;
        public static string[] roles = { "Developer", "Test Engineer", "Designer", "Team Leader" };

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        public string Role
        {
            get { return role; }
            set 
            { 
                bool found = false;
                for (int i = 0; i < roles.Length; i++)
                {
                    if (value == roles[i])
                    {
                        role = value;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Invalid role. Role will be set to 'Developer'.");
                    role = "Developer";
                }
            }
        }
        // default constructor
        public Member()
        {
            name = "John Doe";
            years = 1;
            role = "Developer";
        }
        // parameterized constructor
        public Member(string name, int years, string role)
        {
            Name = name;
            Years = years;
            Role = role;
        }

        public void Show()
        {
            Console.WriteLine("Member name: {0}", Name);
            Console.WriteLine("Experience: {0} years", Years);
            Console.WriteLine("Project role: {0}", Role);
        }
    }
}