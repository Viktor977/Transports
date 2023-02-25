using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.Interfaces;

namespace Transports.Entities
{
    public class Moto : Transport
    {
        public Moto(string brand,string model):base(brand, model) { }
        public override void Refuel()
        {
            if (CurrentFuelCapacity == MaxFuelCapacity)
            {
                Console.WriteLine("The tank is already full");
            }
            else
            {
                double fuelToAdd = MaxFuelCapacity - CurrentFuelCapacity;
                Console.WriteLine($"Adding {fuelToAdd} liters of {Fuel} fuel to moto :{GetBrand()} {GetModel()}");
                CurrentFuelCapacity = MaxFuelCapacity;
            }
        }
    }
}
