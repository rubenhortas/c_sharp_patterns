using Decorator;

// Decorator allows you to build up complex behaviors by composing objects at runtime
ICar car = new Car(); // We can get rid of ICar interface and use var
Console.WriteLine($"{car.GetDescription()} - {car.GetPrize()} coins");

// The really neat thing is that we can nest the subclasses
ICar sportCar = new SportPackage(new Car());
Console.WriteLine($"{sportCar.GetDescription()} - {sportCar.GetPrize()} coins");

ICar luxuryCar = new LuxuryPackage(new Car());
Console.WriteLine($"{luxuryCar.GetDescription()} - {luxuryCar.GetPrize()}  coins");

ICar luxurySportCar = new LuxuryPackage(new SportPackage(new Car()));
Console.WriteLine($"{luxurySportCar.GetDescription()} - {luxurySportCar.GetPrize()} coins");
