using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.Entities
{
    public class GasStation
    {
       
        public void Refuel(Transport transport)
        {
            if (transport is Horse)
            {
                Console.WriteLine("There is no food!");
                return;
            }
            else
            {
                transport.Refuel();
            }

           
        }
    }
}
