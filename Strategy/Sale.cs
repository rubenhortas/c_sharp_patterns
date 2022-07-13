using System;

namespace Strategy
{
    public class Sale
    {
        private IStrategySetPricingSelling strategySetPricingSelling;

        public float Total { get; private set; }

        public DateTime Date { get; set; }

        public Sale(float totalVenta, IStrategySetPricingSelling strategySetPricingSelling)
        {
            Date = DateTime.Today;
            Total = totalVenta;
            this.strategySetPricingSelling = strategySetPricingSelling;

            Console.WriteLine($"{totalVenta}€ sale");
        }

        public void GetTotal()
        {
            float totalDespuesDescuento = strategySetPricingSelling.GetTotal(this);
            
            Console.WriteLine($"Total price after discount: {totalDespuesDescuento:0.00}€");
        }
    }
}
