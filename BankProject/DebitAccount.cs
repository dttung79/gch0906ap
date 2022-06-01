using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class DebitAccount : Account
    {
        public double Threshold 
        { 
            get; set;
        }

        // default constructor
        public DebitAccount() : base()
        {
            Threshold = 100;
        }
        // parameterized constructor
        public DebitAccount(string name, string password, double balance, 
                                            double threshold) : base(name, password, balance)
        {
            Threshold = threshold;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Threshold: {0}", Threshold);
        }

        public override void Withdraw(double amount)
        {
            if (amount > balance + Threshold)
                Console.WriteLine("Not enough money!");
            else if (amount <= 0)
                Console.WriteLine("Invalid amount!");
            else
            {
                balance -= amount;
                Console.WriteLine("Withdraw success! New balance: {0}", balance);
            }
        }
    }
}