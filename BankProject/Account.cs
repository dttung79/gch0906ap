using System;

namespace BankProject
{
    public class Account
    {
        protected static int count = 0;
        protected int id;
        public int ID { get { return id; } }
        
        protected double balance;
        public double Balance { get { return balance; } }
        
        public string Name { get; set; }
        public string Password { get; set; }

        public Account(string name, string password, double balance)
        {
            id = count++;
            Name = name;            // property = parameter
            Password = password;    // property = parameter
            this.balance = balance; // attribute = parameter
        }
        public void ShowInfo()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Balance: {0}", balance);
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
                Console.WriteLine("Not enough money!");
            else if (amount <= 0)
                Console.WriteLine("Invalid amount!");
            else 
            {
                balance -= amount;
                Console.WriteLine("Withdraw success! New balance: {0}", balance);
            }
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
                Console.WriteLine("Invalid amount!");
            else
            {
                balance += amount;
                Console.WriteLine("Deposit success! New balance: {0}", balance);
            }
        }
    }
}