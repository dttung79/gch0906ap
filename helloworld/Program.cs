using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            // create player object
            Player degea = new Player("De Gea", 30, "Goalkeeper");
            degea.ShowPlayerInfo();

            Player maguire = new Player("MaGuire", 32, "Defender");
            maguire.ShowPlayerInfo();

            maguire.SetName("Harry Maguire");
            maguire.Age = 9;
            // maguire.name = "";
            maguire.ShowPlayerInfo();

            // C1: print to console extra salary
            Console.WriteLine("Extra salary: {0}", maguire.ExtraSalary(3000));
            // store into a local variable
            int extraSal = maguire.ExtraSalary(3000);
            Console.WriteLine("Extra salary: {0}", extraSal);

            // error: Console.WriteLine(maguire.ShowPlayerInfo());
            maguire.ExtraSalary(3000);

            int baseSalary = 5000000;
            int salary     = baseSalary + maguire.ExtraSalary(3000);

            Player noName = new Player();
            noName.ShowPlayerInfo();

            Player p2 = new Player();
            p2.ShowPlayerInfo();
        }
    }
}
