using System;

namespace Listener
{
    public class Subject
    {
        private IListener _listener;

        public Subject(IListener listener)
        {
            _listener = listener;

            Console.WriteLine("I'm the subject");
            Console.WriteLine("I have a listener");
            Console.WriteLine("I'll notify my listener");
            Console.WriteLine();

            _listener.Notify("Very important notification!");
        }
    }
}
