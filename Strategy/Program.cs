using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            Sale sale;
            int totalSale = 100;

            Console.WriteLine("Strategy Set Pricing Percentage Discount");
            Console.WriteLine($"{Constants.DiscountRate}% discount");

            IStrategySetPricingSelling strategySetPricingPercentageDiscount = new StrategySetPricingPercentageDiscount();

            sale = new Sale(totalSale, strategySetPricingPercentageDiscount);
            sale.GetTotal();

            Console.WriteLine();

            Console.WriteLine("Strategy Set Pricing Absolute Discount Over Threshold");
            Console.WriteLine($"{Constants.Discount}€ discount (minimum sale of {Constants.SpendingThreshold}€)");

            IStrategySetPricingSelling strategySetPricingAbsoluteDiscountOverThreshold = new StrategySetPricingAbsoluteDiscountOverThreshold();

            sale = new Sale(totalSale, strategySetPricingAbsoluteDiscountOverThreshold);
            sale.GetTotal();
        }
    }
}
