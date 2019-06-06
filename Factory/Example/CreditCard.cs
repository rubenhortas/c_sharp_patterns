using System;

namespace Factory.Example
{
    /// <summary>
    /// The 'Product' Abstract Class  
    /// </summary>
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Card details:");
            Console.WriteLine("\tCard Type:\t{0}", CardType);
            Console.WriteLine("\tCredit Limit:\t{0}", CreditLimit);
            Console.WriteLine("\tAnnual Charge:\t{0}", AnnualCharge);
        }
    }
}
