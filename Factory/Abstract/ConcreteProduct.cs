using System;

namespace Factory.Abstract
{
    // This is a class which implements the Product interface.
    class ConcreteProduct : Product
    {
        public override void DoOperation()
        {
            Console.WriteLine("Product operation done!");
        }
    }
}
