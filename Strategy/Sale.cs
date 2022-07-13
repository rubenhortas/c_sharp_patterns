using System;

namespace Strategy
{
    public class Sale
    {
        private IStrategySetSalePrice _strategySetSalePrice;

        public float Total { get; private set; }

        public DateTime Date { get; private set; }

        public Sale(float saleTotal, IStrategySetSalePrice strategySetPricingSelling)
        {
            Date = DateTime.Today;
            Total = saleTotal;
            _strategySetSalePrice = strategySetPricingSelling;

            Console.WriteLine($"{saleTotal}€ sale");
        }

        public void GetTotal()
        {
            float totalAfterDiscount = _strategySetSalePrice.GetTotal(this);
            
            Console.WriteLine($"Total price after discount: {totalAfterDiscount:0.00}€");
        }
    }
}
