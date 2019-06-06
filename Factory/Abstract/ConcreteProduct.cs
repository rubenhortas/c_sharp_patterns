using System;

namespace Factory.Abstract
{
    /// <summary>
    /// This is a class which implements the Product interface
    /// </summary>
    class ConcreteProduct : Product
    {
        public override void Operation()
        {
            Console.WriteLine("Product operation done!");
        }
    }
}
