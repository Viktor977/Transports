using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.Interfaces;

namespace Transports.Entities
{
    public class Moto : Transport, IMoveable
    {
        public Moto(string brand,string model):base(brand, model) { }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
