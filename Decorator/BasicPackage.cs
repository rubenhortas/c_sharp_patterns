namespace Decorator
{
    internal class BasicPackage(ICar car) : CarDecorator(car)
    {
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Basic"; 
        }
    }
}
