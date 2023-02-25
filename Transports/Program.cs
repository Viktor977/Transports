using Transports.Entities;
using Transports.Interfaces;

List<IMoveable> transports = Seed();

GasStation.Refuel(transports);
Move(transports);
Move(transports);
Move(transports);
Move(transports);
GasStation.Refuel(transports);

 void Move(List<IMoveable> transports)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Transport moved");
    Console.ResetColor();
    foreach (var transport in transports)
    {
        transport.Move();
    }
}
static List<IMoveable> Seed()
{
    var transports = new List<IMoveable>();

    Car car = new Car("BMW", "M240i");
    car.Wheels = 4;
    car.Fuel = FuelType.Gasoline;
    car.FuelConsumption = 8.0;
    car.MaxFuelCapacity = 52.0;

    Moto moto = new Moto("Kawasaki","Ninja");
    moto.Fuel = FuelType.Gasoline;
    moto.Wheels = 2;
    moto.MaxFuelCapacity = 20;
    moto.FuelConsumption = 2;

    Airplane airplane = new Airplane("Boeing", "747");
    airplane.Wheels = 3;
    airplane.Fuel = FuelType.JetFuel;
    airplane.FuelConsumption = 5_000d;
    airplane.MaxFuelCapacity = 10_000d;


    Horse horse = new Horse("Rosinante");

    transports.Add(car);
    transports.Add(moto);
    transports.Add(airplane);
    transports.Add(horse);

    return transports;
}