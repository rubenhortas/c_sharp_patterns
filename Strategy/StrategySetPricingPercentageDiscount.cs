namespace Strategy
{
    public class StrategySetPricingPercentageDiscount : IStrategySetPricingSelling
    {
        public StrategySetPricingPercentageDiscount()
        {
        }

        public float GetTotal(Sale sale)
        {
            float totalBeforeDiscount = sale.Total;

            return (totalBeforeDiscount - (totalBeforeDiscount * (Constants.DiscountRate / 100)));
        }
    }
}
