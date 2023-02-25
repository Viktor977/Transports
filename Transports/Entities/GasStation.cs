using Transports.Interfaces;

namespace Transports.Entities
{
    public static class GasStation
    {   
        public static void Refuel(List<IMoveable> transports)
        {   
            if (transports == null) throw new ArgumentNullException();
            foreach (IMoveable moveable in transports)
            {
                moveable.Refuel();
            }
        }
    }
}
