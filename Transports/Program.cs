// See https://aka.ms/new-console-template for more information
using Transports.Entities;

Console.WriteLine("Hello, World!");
Car car = new Car("", null);
Console.WriteLine(car.GetBrand());
Console.WriteLine(car.GetModel());
car.MaxFuelCapacity = 10;
car.CurrentFuelCapacity= 10;
try
{
    car.Wheels = 0;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

car.Refuel();