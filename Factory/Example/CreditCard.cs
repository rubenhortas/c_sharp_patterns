using System;

namespace Factory.Example
{
    // The 'Product' Abstract Class.
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Card details:");
            Console.WriteLine($"\tCard yype:\t{CardType}");
            Console.WriteLine($"\tCredit limit:\t{CreditLimit}");
            Console.WriteLine($"\tAnnual charge:\t{AnnualCharge}");
        }
    }
}
