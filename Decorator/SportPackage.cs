namespace Decorator
{
    internal class SportPackage(ICar car): CarDecorator(car)
    {
        public override string GetDescription()
        {
            return $"{base.GetDescription()} Sport";
        }

        public override double GetPrize()
        {
            return base.GetPrize() + 10000;
        }
    }
}
