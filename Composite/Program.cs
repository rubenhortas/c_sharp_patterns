using System;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            Sale sale;
            int saleTotal = 100;

            Console.WriteLine("The best for the customer");
            CompoundStrategySetBestPriceForTheCustomer compoundStrategySetBestPriceForTheCustomer = new();
            sale = new Sale(saleTotal, compoundStrategySetBestPriceForTheCustomer);
            sale.GetTotal();

            Console.WriteLine();

            Console.WriteLine("The best for the store");
            CompoundStrategySetBestPriceForTheStore compoundStrategySetBestPriceForTheStore = new();
            sale = new Sale(saleTotal, compoundStrategySetBestPriceForTheStore);
            sale.GetTotal();
        }
    }
}
