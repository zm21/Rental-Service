using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using RentCar.Transport;

namespace RentalService
{
    public partial class RentalSerivce : Form
    {
        public void LoadCarsFromFile()
        {
            cars = new List<RentalCar>();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(path_to_cars))
            {
                cars = (List<RentalCar>)binaryFormatter.Deserialize(fStream);
            }
        }
        public void SaveCarsToFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fStream = File.Create(path_to_cars))
            {
                binaryFormatter.Serialize(fStream, cars);
            }
        }
    }
}
