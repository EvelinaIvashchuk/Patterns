using System;

namespace BehavioralPatterns.Command
{
    public class Receiver
    {
        public void Action1()
        {
            Console.WriteLine("Receiver: Executing Action1");
        }

        public void Action2()
        {
            Console.WriteLine("Receiver: Executing Action2");
        }
    }
}