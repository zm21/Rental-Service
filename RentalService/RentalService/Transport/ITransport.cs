using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Transport
{
    public enum TransportType
    {
        sports_coupe=1, 
        suv, 
        sedan,
        station_wagon,
        minivan,
        electric_car,
        cabriolet
    }
    interface ITransport
    {
        string Brand { get; }
        string Model { get; }
        string LicensePlate { get; }
        string Type { get; }
    }
}
