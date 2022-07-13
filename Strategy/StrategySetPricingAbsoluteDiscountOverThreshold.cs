namespace Strategy
{
    public class StrategySetPricingAbsoluteDiscountOverThreshold : IStrategySetSalePrice
    {
        public StrategySetPricingAbsoluteDiscountOverThreshold()
        {
        }

        public float GetTotal(Sale sale)
        {
            float totalBeforeDiscount = sale.Total;

            if (totalBeforeDiscount >= Constants.SpendingThreshold)
            {
                return totalBeforeDiscount - Constants.Discount;
            }
            else
            {
                return totalBeforeDiscount;
            }
        }
    }
}
