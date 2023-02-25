using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.Entities
{
    public abstract class Transport
    {
        private string _model;
        private string _brand;
        private double _maxFuelCapacity;
        private int _wheels;
        public double MaxFuelCapacity {
            get => _maxFuelCapacity;
            
            set
            {
                if(value < 0)_maxFuelCapacity = 0;
                _maxFuelCapacity = value;
            }
        }
        public FuelType Fuel { get; set; }
        public double CurrentFuelCapacity { get; set; }
        public double FuelConsumption { get; set;}
        public int Wheels
        {
            get => _wheels;
           
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "Whells cannot be equal to 0 or less than 0");
                }
                _wheels = value;
            }
        }
        
        public Transport(string brand, string model)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                _brand = "BrandLess";
                _model = "Noname";
            }
            else
            {
                _brand = brand;
                _model = model;
            }
        }

        public virtual void Refuel()
        {
            if(CurrentFuelCapacity==MaxFuelCapacity)
            {
                Console.WriteLine("The tank is already full");
            }
            else
            {
                double fuelToAdd = MaxFuelCapacity - CurrentFuelCapacity;
                Console.WriteLine($"Adding {fuelToAdd} liters of {Fuel} fuel to car :{_brand} {_model}");
                CurrentFuelCapacity = MaxFuelCapacity;
            }
        }
        public virtual string GetModel() => _model;
        public virtual string GetBrand() => _brand;

    }
}
