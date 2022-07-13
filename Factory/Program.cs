using System;
using Factory.Abstract;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            //RunAbstractImplementation();
            RunCreditCardsImplementation();
        }

        private static void RunAbstractImplementation()
        {
            Console.WriteLine("Abstract implementation");

            // You can not instantiate abstract classes.
            Creator creator = new ConcreteCreator();
            Product product = creator.RunFactoryMethod();

            product.DoOperation();
        }

        private static void RunCreditCardsImplementation()
        {
            Console.WriteLine("Credit Cards Implementation");

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
        }
    }
}
