using Transports.Interfaces;

namespace Transports.Entities
{
    public abstract class Transport : IMoveable
    {
        private string _model;
        private string _brand;
        private double _maxFuelCapacity;
        private int _wheels;  
        public FuelType Fuel { get; set; }
        public double CurrentFuelCapacity { get; set; }
        public double FuelConsumption { get; set; }
        public double MaxFuelCapacity
        {
            get => _maxFuelCapacity;

            set
            {
                if (value < 0) _maxFuelCapacity = 0;
                _maxFuelCapacity = value;
            }
        }
      
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
        public abstract void Refuel();
        public virtual string GetModel() => _model;
        public virtual string GetBrand() => _brand;
        public virtual void Move()
        {
            if (CurrentFuelCapacity <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{_brand} {_model} Not enough fuel!!!");
                Console.ResetColor();
            }
            else
            {
                CurrentFuelCapacity -= FuelConsumption;
                Console.WriteLine($"Fuel:{Fuel} used {CurrentFuelCapacity}");
            }
        }
    }
}
