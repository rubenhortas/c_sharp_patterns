using System;

namespace Listener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Listener Pattern");
            Console.WriteLine();

            Listener listener = new Listener();
            Subject subject = new Subject(listener);

            Console.ReadKey();
        }
    }
}
