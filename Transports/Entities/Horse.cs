using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.Interfaces;

namespace Transports.Entities
{
    public class Horse : IMoveable
    {
        string _nickname;
        public Horse(string name) => _nickname = name;

        public void Move()
        {
            Console.WriteLine("Riding horse...");
        }
    }
}
