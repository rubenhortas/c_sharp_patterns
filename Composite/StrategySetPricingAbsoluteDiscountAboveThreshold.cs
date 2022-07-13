namespace Composite
{
    public class StrategySetPricingAbsoluteDiscountAboveThreshold : IStrategySetSellingPrice
    {
        public StrategySetPricingAbsoluteDiscountAboveThreshold()
        {
        }

        public float GetTotal(Sale sale)
        {
            float saleTotal = sale.Total;

            if (saleTotal >= Constants.DiscountThreshold)
            {
                return saleTotal - Constants.Discount;
            }
            else
            {
                return saleTotal;
            }
        }
    }
}
