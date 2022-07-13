namespace Strategy
{
    public class StrategySetPricingAbsoluteDiscountOverThreshold : IStrategySetPricingSelling
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
