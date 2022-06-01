using System;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int adminID = -1;
            string adminPass = "abc";
            AdminProgram admin = new AdminProgram();
            while(true)
            {
                // ask user for ID and password
                Console.Write("Enter your ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter your password: ");
                string pass = Console.ReadLine();
                // if ID is adminID and password is adminPass 
                if (id == adminID && pass == adminPass)
                    admin.Run();
                else
                {
                    // search for account
                    Account acc = admin.SearchAccount(id, pass);
                    if (acc == null)
                        Console.WriteLine("Invalid ID or password!");
                    else
                    {
                        // create NormalAccProgram object
                        NormalAccProgram normal = new NormalAccProgram(acc);
                        // run NormalAccProgram
                        normal.Run();
                    }
                }
            }
        }
    }
}
