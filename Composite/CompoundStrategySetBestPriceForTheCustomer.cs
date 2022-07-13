using System;

namespace Composite
{
    public class CompoundStrategySetBestPriceForTheCustomer : CompundStrategySetPricing
    {
        public override float GetTotal(Sale sale)
        {
            float minPrice = sale.Total;
            float salePrice;

            foreach (IStrategySetSellingPrice strategySetSellingPrice in _strategySetSellingPrice)
            {
                salePrice = strategySetSellingPrice.GetTotal(sale);
                minPrice = Math.Min(salePrice, minPrice);
            }

            return minPrice;
        }
    }
}
