using System;

namespace Composite
{
    public class Sale
    {
        private IStrategySetSellingPrice _strategySetSellingPrice;

        public float Total { get; private set; }

        public DateTime Date { get; private set; }

        public Sale(float total, IStrategySetSellingPrice strategySetSellingPrice)
        {
            Date = DateTime.Today;
            Total = total;
            _strategySetSellingPrice = strategySetSellingPrice;

            Console.WriteLine($"{total}€ sale");
        }

        public void GetTotal()
        {
            float totalAfterDiscount = _strategySetSellingPrice.GetTotal(this);
            
            Console.WriteLine($"Total price after discount: {totalAfterDiscount:0.##}");
        }
    }
}
