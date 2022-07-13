namespace Composite
{
    public class StrategySetPricingPercentageDiscount : IStrategySetSellingPrice
    {        
        public StrategySetPricingPercentageDiscount()
        {
        }

        public float GetTotal(Sale sale)
        {
            float saleTotal = sale.Total;
            
            return (saleTotal - (saleTotal * (Constants.DiscountRate / 100)));
        }
    }
}
