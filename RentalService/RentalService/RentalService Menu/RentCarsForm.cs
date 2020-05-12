using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalService.Users;
using RentCar.Transport;
namespace RentalService
{
    public partial class RentCarsForm : Form
    {
        private List<RentalCar> cars;
        public RentCarsForm(List<RentalCar> rentalCars, User user)
        {
            InitializeComponent();
            cars = rentalCars;
            foreach (var car in cars)
            {
                AddCarToDataGrid(car);
            }
            if (user is Admin)
                bt_rent.Text = "Remove";
        }

        private bool isAllFiltersUnchecked()
        {
            foreach (var item in this.Controls)
            {
                if(item is Guna.UI.WinForms.GunaCheckBox)
                {
                    if(((Guna.UI.WinForms.GunaCheckBox)item).Checked)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void bt_find_Click(object sender, EventArgs e)
        {
            if(isAllFiltersUnchecked())
            {
                DataGrid_cars.Rows.Clear();
                foreach (var car in cars)
                {
                    AddCarToDataGrid(car);
                }
            }
            else
            {
                DataGrid_cars.Rows.Clear();
                foreach (var car in cars)
                {
                    if(chb_available.Checked && car.Available)
                        AddCarToDataGrid(car);

                    if (chb_sportCoupe.Checked && car.Type==chb_sportCoupe.Text)
                        AddCarToDataGrid(car);

                    if (chb_suv.Checked && car.Type == chb_suv.Text)
                        AddCarToDataGrid(car);

                    if (chb_stationWagon.Checked && car.Type == chb_stationWagon.Text)
                        AddCarToDataGrid(car);

                    if (chb_minivan.Checked && car.Type == chb_minivan.Text)
                        AddCarToDataGrid(car);

                    if (chb_electricCar.Checked && car.Type == chb_electricCar.Text)
                        AddCarToDataGrid(car);

                    if (chb_cabriolet.Checked && car.Type == chb_cabriolet.Text)
                        AddCarToDataGrid(car);

                    if (chb_sedan.Checked && car.Type == chb_sedan.Text)
                        AddCarToDataGrid(car);
                }
            }
        }

        private void AddCarToDataGrid(RentalCar car)
        {
            DataGrid_cars.Rows.Add(car.Available, car.AvailableFrom, car.PricePerDay, car.Brand, car.Model, car.LicensePlate, car.Type);
        }
        private void bt_rent_Click(object sender, EventArgs e)
        {

        }

        private void RentCarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
