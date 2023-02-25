namespace Transports.Entities
{
    public class Airplane : Transport
    {
        public Airplane(string brand,string model):base(brand,model) { }

        public override void Refuel()
        {
            if (CurrentFuelCapacity == MaxFuelCapacity)
            {
                Console.WriteLine("The tank is already full");
            }
            else
            {
                double fuelToAdd = MaxFuelCapacity - CurrentFuelCapacity;
                Console.WriteLine($"Adding {fuelToAdd} liters of {Fuel} fuel to plane :{GetBrand()} {GetModel()}");
                CurrentFuelCapacity = MaxFuelCapacity;
            }
        }
    }
}
