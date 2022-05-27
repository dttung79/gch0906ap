using System;

namespace BankProject
{
    public class NormalAccProgram
    {
        private Account acc;
        public NormalAccProgram(Account acc)
        {
            this.acc = acc;
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                // print menu (withdraw, deposit, show info, exit)
                PrintMenu();
                // get user choice
                int choice = GetUserChoice();
                // call method according to user choice
                DoTask(choice);
                // ask user to continue or not
                running = IsContinue();
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Show info");
            Console.WriteLine("4. Exit");
        }
        private int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        private bool IsContinue()
        {
            Console.Write("Do you want to continue? (y/n): ");
            string choice = Console.ReadLine();
            return choice == "y";
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: WithDraw(); break;
                case 2: Deposit(); break;
                case 3: acc.ShowInfo(); break;
                case 4: Exit(); break;
            }
        }
        private void WithDraw()
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Withdraw(amount);
        }
        private void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        private void Exit()
        {
            Console.WriteLine("Have a good day!");
        }

    }
}