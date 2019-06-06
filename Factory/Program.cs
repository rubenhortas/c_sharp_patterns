using System;
using Factory.Abstract;
using Factory.Example;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern");
            Console.WriteLine("The factory design pattern in C# is used to replace class constructors, abstracting the process of object generation so that the type of the object instantiated can be determined at run-time");
            Console.WriteLine();

            // Abstract implementation
            Console.WriteLine("Abstract implementation");

            Creator creator = new ConcreteCreator(); // You can not instantiate abstract classes
            Product product = creator.factoryMethod();
            product.Operation();

            Console.WriteLine();

            // Example implementation
            Console.WriteLine("Example implementation (credit cards)");

            CardFactory cardFactory;
            CreditCard creditCard;

            cardFactory = new MoneyBackFactory(50000, 0);
            creditCard = cardFactory.GetCreditCard();
            creditCard.PrintDetails();

            cardFactory = new TitaniumFactory(100000, 500);
            creditCard = cardFactory.GetCreditCard();
            creditCard.PrintDetails();

            cardFactory = new PlatinumFactory(500000, 1000);
            creditCard = cardFactory.GetCreditCard();
            creditCard.PrintDetails();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
