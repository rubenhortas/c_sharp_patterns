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
            CompoundStrategySetBestPriceForTheCustomer compoundStrategySetBestPriceForTheCustomer = new CompoundStrategySetBestPriceForTheCustomer();
            sale = new Sale(saleTotal, compoundStrategySetBestPriceForTheCustomer);
            sale.GetTotal();

            Console.WriteLine();

            Console.WriteLine("Lo mejor para la tienda");
            CompoundStrategySetBestPriceForTheStore compoundStrategySetBestPriceForTheStore = new CompoundStrategySetBestPriceForTheStore();
            sale = new Sale(saleTotal, compoundStrategySetBestPriceForTheStore);
            sale.GetTotal();
        }
    }
}
