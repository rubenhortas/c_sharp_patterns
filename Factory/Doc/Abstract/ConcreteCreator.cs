namespace Factory.Abstract
{
    class ConcreteCreator : Creator
    {
        public override Product RunFactoryMethod()
        {
            // You can not instantiate abstract classes.
            return new ConcreteProduct(); 
        }
    }
}
