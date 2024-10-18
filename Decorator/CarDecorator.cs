namespace Decorator
{
    // When you use decorator, you create an abstract class that defines the set of operations you need to support.
    // Then you create a subclass that inherits from that abstract class, accepts an instance of the class in its constructor, and provides a body for each of those methods.
    // You can subclass it and override any or all of the methods to add additional behavior.

    // We create objects of a class that wraps another class and pass them around.
    // The class that wraps should have the same interface as the class it is wrapping so that clients don’t know that they are working with a wrapper.
    internal abstract class CarDecorator(ICar car) : ICar
    {
        private readonly ICar car = car;

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }

        public virtual double GetPrize()
        {
            return car.GetPrize();
        }
    }
}
