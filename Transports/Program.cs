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

foreach (var transport in transports)
{
    transport.Move();
}
foreach (var transport in transports)
{
    transport.Move();
}


static List<Transport> Seed()
{
    var transports = new List<Transport>();

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
    airplane.CurrentFuelCapacity = 5000;
    airplane.MaxFuelCapacity = 10_000;


    Horse horse = new Horse("Rosinante", "");

    transports.Add(car);
    transports.Add(moto);
    transports.Add(airplane);
    transports.Add(horse);

    return transports;
}