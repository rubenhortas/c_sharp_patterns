using System;

namespace Composite
{
    public class CompoundStrategySetBestPriceForTheStore : CompundStrategySetPricing
    {
        public override float GetTotal(Sale venta)
        {
            float maxPrice = 0;
            float salePrice;

            foreach (IStrategySetSellingPrice strategySetSellingPrice in _strategySetSellingPrice)
            {
                salePrice = strategySetSellingPrice.GetTotal(venta);
                maxPrice = Math.Max(salePrice, maxPrice);
            }

            return maxPrice;
        }
    }
}
