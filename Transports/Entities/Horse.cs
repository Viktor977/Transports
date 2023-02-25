using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.Interfaces;

namespace Transports.Entities
{
    public class Horse :Transport
    {
        private string _nickname;
        private string _breed;
        public new FuelType Fuel = FuelType.Feed;
        
        public Horse(string name,string brand):base(name, brand)
        {
            _nickname = name;
            _breed = brand;
        }
        public override void Refuel()
        {
            Console.WriteLine("There is no food!");
        }
        public override void Move()
        {
            Console.WriteLine("Riding horse...");
        }
    }
}
