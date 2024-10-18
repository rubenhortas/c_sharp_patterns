namespace Decorator
{
    internal class LuxuryPackage(ICar car): CarDecorator(car)
    {
        public override string GetDescription()
        {
            return $"{base.GetDescription()} Luxury";
        }

        public override double GetPrize()
        {
            return base.GetPrize() + 250000;
        }
    }
}
