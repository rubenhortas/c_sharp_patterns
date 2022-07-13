using System;

namespace Listener
{
    public class Listener : IListener
    {
        public void Notify(string notification)
        {
            Console.WriteLine($"I have a notification: {notification}");
        }
    }
}