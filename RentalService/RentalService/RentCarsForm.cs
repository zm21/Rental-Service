using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Transport;
namespace RentalService
{
    public partial class RentCarsForm : Form
    {
        private List<RentalCar> cars;
        public RentCarsForm(List<RentalCar> rentalCars)
        {
            InitializeComponent();
            cars = rentalCars;
            foreach (var item in cars)
            {
                DataGrid_cars.Rows.Add(item.Available, item.Available, item.PricePerDay, item.Brand, item.Model, item.LicensePlate, item.Type);
            }
        }

        private void bt_find_Click(object sender, EventArgs e)
        {

        }
    }
}
