using System;

namespace Strategy
{
    class Program
    {
        private const int TotalSale = 100;

        static void Main()
        {
            ApplyPercentageDiscount();

            Console.WriteLine();

            ApplyAbsoluteDiscountOverThreshold();
        }

        private static void ApplyPercentageDiscount()
        {
            Console.WriteLine("Strategy Set Pricing Percentage Discount");
            Console.WriteLine($"{Constants.DiscountRate}% discount");

            IStrategySetSalePrice strategySetPricingPercentageDiscount = new StrategySetPricingPercentageDiscount();
            Sale sale = new(TotalSale, strategySetPricingPercentageDiscount);

            sale.GetTotal();
        }

        private static void ApplyAbsoluteDiscountOverThreshold()
        {
            Console.WriteLine("Strategy Set Pricing Absolute Discount Over Threshold");
            Console.WriteLine($"{Constants.Discount}€ discount (minimum sale of {Constants.SpendingThreshold}€)");

            IStrategySetSalePrice strategySetPricingAbsoluteDiscountOverThreshold = new StrategySetPricingAbsoluteDiscountOverThreshold();
            Sale sale = new(TotalSale, strategySetPricingAbsoluteDiscountOverThreshold);

            sale.GetTotal();
        }
    }
}
