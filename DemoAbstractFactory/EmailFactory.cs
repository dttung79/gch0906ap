using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAbstractFactory
{
    public abstract class EmailFactory
    {
        public abstract Header CreateHeader();
        public abstract Message CreateMessage();
        protected string EnterTitle()
        {
            Console.Write("Enter title: ");
            return Console.ReadLine();
        }
        protected void AddLines(Message msg)
        {
            string line = "";
            do
            {
                Console.Write("Enter line: ");
                line = Console.ReadLine();
                if (line != "")  msg.AddLine(line);
            } while (line != "");
        }
    }

    public class SimpleEmailFactory : EmailFactory
    {
        public override Header CreateHeader()
        {
            return new SimpleHeader(EnterTitle());
        }
        public override Message CreateMessage()
        {
            SimpleMessage msg = new SimpleMessage();
            AddLines(msg);
            return msg;
        }
    }
    public class FancyEmailFactory : EmailFactory
    {
        public override Header CreateHeader()
        {
            return new FancyHeader(EnterTitle());
        }
        public override Message CreateMessage()
        {
            FancyMessage msg = new FancyMessage();
            AddLines(msg);
            return msg;
        }
    }
}