namespace Decorator
{
    internal class Car : ICar
    {
        private readonly string brand = "CarBrand";
        private readonly double prize = 25000;

        public string GetDescription()
        {
            return brand;
        }
        public double GetPrize()
        {
            return prize;
        }
    }
}
