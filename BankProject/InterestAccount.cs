using System;

namespace BankProject
{
    public class InterestAccount : Account
    {
        public double Interest { get; set; }
        // default constructor
        public InterestAccount()
        {
            Interest = 0.05;
        }
        // parameterized constructor
        public InterestAccount(string name, string password, double balance,
                                double interest) : base(name, password, balance)
        {
            Interest = interest;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Interest: {0}", Interest);
        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Console.WriteLine("Interest: {0}", Interest * balance);
        }
    }
}