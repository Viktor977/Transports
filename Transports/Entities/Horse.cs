using Transports.Interfaces;

namespace Transports.Entities
{
    public class Horse : IMoveable
    {
        private string _nickname;  
        
        public FuelType Fuel = FuelType.Feed;
        
        public Horse(string name)
        {
            _nickname = name;         
        }
        public  void Refuel()
        {
            Console.WriteLine("There is no food!");
        }
        public  void Move()
        {
            Console.WriteLine($"Riding horse {_nickname}...");
        }      
    }
}
