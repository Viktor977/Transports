using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.Interfaces;

namespace Transports.Entities
{
    public class Car : Transport, IMoveable
    {
        public Car(string brand, string model) : base(brand, model)
        {
        }
       
        public void Move()
        {
            if (CurrentFuelCapacity == 0)
            {
                Console.WriteLine("Not enough fuel");
            }
           
            CurrentFuelCapacity -= FuelConsumption;
            Console.WriteLine($"Fuel:{Fuel} used {CurrentFuelCapacity}");
        }
        public override string GetModel()
        {
            return "this car is " + base.GetModel();
        }
    }
}
