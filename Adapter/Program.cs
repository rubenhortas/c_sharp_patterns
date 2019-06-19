using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineTester engineTester;
            engineTester = new EngineTester(new CommonEngine());
            Console.WriteLine();

            engineTester = new EngineTester(new EconomicEngine());
            Console.WriteLine();

            engineTester = new EngineTester(new ElectricEngineAdapter());

            Console.ReadLine();
        }
    }
}
