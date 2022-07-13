namespace Listener
{
    class Program
    {
        static void Main()
        {
            Listener listener = new Listener();
            Subject subject = new(listener);
        }
    }
}
