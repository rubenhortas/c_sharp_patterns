namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                s1.SayHelloWorld();
            }
        }
    }
}
