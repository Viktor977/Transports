namespace Transports.Entities
{
    public class Car : Transport
    {
        public Car(string brand, string model) : base(brand, model) { }
      
        public override void Refuel()
        {
            if (CurrentFuelCapacity == MaxFuelCapacity)
            {
                Console.WriteLine("The tank is already full");
            }
            else
            {
                double fuelToAdd = MaxFuelCapacity - CurrentFuelCapacity;
                Console.WriteLine($"Adding {fuelToAdd} liters of {Fuel} fuel to car :{GetBrand()} {GetModel()}");
                CurrentFuelCapacity = MaxFuelCapacity;
            }
        }     
    }
}
