using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompundStrategySetPricing : IStrategySetSellingPrice
    {
        protected List<IStrategySetSellingPrice> _strategySetSellingPrice;

        public CompundStrategySetPricing()
        {
            _strategySetSellingPrice = new List<IStrategySetSellingPrice>();

            // All compound objects maintain a list of the strategies they contain.
            AddStrategy(new StrategySetPricingPercentageDiscount());
            AddStrategy(new StrategySetPricingAbsoluteDiscountAboveThreshold());
        }

        public void AddStrategy(IStrategySetSellingPrice sellingPriceStrategy)
        {
            _strategySetSellingPrice.Add(sellingPriceStrategy);
        }

        public virtual float GetTotal(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
