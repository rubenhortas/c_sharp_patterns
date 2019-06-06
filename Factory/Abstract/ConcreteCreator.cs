namespace Factory.Abstract
{
    class ConcreteCreator : Creator
    {
        public override Product factoryMethod()
        {
            return new ConcreteProduct(); // You can not instantiate abstract classes
        }
    }
}
