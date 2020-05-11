using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Transport
{
    [Serializable]
    public abstract class Car : ITransport
    {
        public string Brand { get;  set; }

        public string Model { get;  set; }

        public string LicensePlate { get;  set; }

        public string Type { get;  set; }
    }
}
