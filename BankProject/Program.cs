using System;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account john = new Account("John", "123", 1000);
            NormalAccProgram program = new NormalAccProgram(john);
            program.Run();
        }
    }
}
