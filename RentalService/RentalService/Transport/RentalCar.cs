using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Transport
{
    [Serializable]
    public class RentalCar:Car
    {
        public bool Available { get; set; }
        public DateTime AvailableFrom { get; set; }
        public int RentedID { get; set; }
        public int PricePerDay { get; set; }
    }
}
