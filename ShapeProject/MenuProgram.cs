using System;

namespace ShapeProject
{
    public class MenuProgram
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetUserChoice();
                DoTask(choice);
                running = IsContinue();
            }
        }

        protected virtual void PrintMenu()
        {
            // don't know what to print!!!
        }

        protected virtual void DoTask(int choice)
        {
            // don't know what to do!!!
        }
        protected int GetUserChoice()
        {
            Console.WriteLine("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }
        protected bool IsContinue()
        {
            Console.WriteLine("Continue? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }

}