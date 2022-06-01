using System;
using System.Collections.Generic;

namespace BankProject
{
    public class AdminProgram
    {
        private List<Account> accounts;
        public AdminProgram()
        {
            accounts = new List<Account>();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                // print menu (add account, list accounts)
                PrintMenu();
                // ask user for choice
                int choice = GetUserChoice();
                // do task corresponding to choice
                DoTask(choice);
                // ask user if they want to continue
                running = IsContinue();
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("1. Add account");
            Console.WriteLine("2. List accounts");
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
                case 1: AddAccount(); break;
                case 2: ListAccounts(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
        private void AddAccount()
        {
            Console.Write("Choose type of account: ");
            Console.WriteLine("1. Debit");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Interest");
            int choice = int.Parse(Console.ReadLine());
            Account acc = CreateAccount(choice);
            accounts.Add(acc);
        }
        private Account CreateAccount(int choice)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter account password: ");
            string password = Console.ReadLine();
            Console.Write("Enter account balance: ");
            double balance = double.Parse(Console.ReadLine());
            
            if (choice == 2)
                return new Account(name, password, balance);
            
            if (choice == 3)
            {
                Console.Write("Enter account interest: ");
                double interest = double.Parse(Console.ReadLine());
                return new InterestAccount(name, password, balance, interest);
            }
            // debit
            Console.Write("Enter threhold: ");
            double threhold = double.Parse(Console.ReadLine());
            return new DebitAccount(name, password, balance, threhold);            
        }
        private void ListAccounts()
        {
            foreach (Account acc in accounts)
            {
                Console.WriteLine("---------Acc ID {0}---------", acc.ID);
                acc.ShowInfo();
            }
        }

        public Account SearchAccount(int id, string password)
        {
            foreach (Account acc in accounts)
            {
                if (acc.ID == id && acc.Password == password)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}