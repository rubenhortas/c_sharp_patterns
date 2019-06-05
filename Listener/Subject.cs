using System;

namespace Listener
{
    public class Subject
    {
        private IListener listener;

        public Subject(IListener listener)
        {
            this.listener = listener;

            Console.WriteLine("I'm the subject");
            Console.WriteLine("I have a listener");
            Console.WriteLine("I'll notify my listener");
            Console.WriteLine();

            listener.Notify("Very important notification!");
        }
    }
}
