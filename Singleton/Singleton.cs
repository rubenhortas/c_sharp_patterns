using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
