using Transports.Entities;

List<Transport> transports = Seed();
GasStation owg=new GasStation(); ;
foreach (var transport in transports)
{
    if (transport == null)
    {
        Console.WriteLine("no transport");
        return;
    }
    owg.Refuel(transport);
    
}


static List<Transport> Seed()
{
    var transports = new List<Transport>();

    Car car = new Car("BMW", "M240i");
    car.Wheels = 4;
    car.Fuel = FuelType.Gasoline;
    car.FuelConsumption = 8.0;
    car.MaxFuelCapacity = 52.0;


    Horse horse = new Horse("Rosinante", "");

    transports.Add(car);
    transports.Add(horse);
    return transports;
}