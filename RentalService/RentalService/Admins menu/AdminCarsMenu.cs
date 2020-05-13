using RentalService.Admins_menu;
using RentCar.Transport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalService
{
    public partial class AdminCarsMenu : Form
    {
        private List<RentalCar> cars;
        public AdminCarsMenu(List<RentalCar> cars)
        {
            InitializeComponent();
            this.cars = cars;
            foreach (var car in cars)
            {
                AddCarToDataGrid(car);
            }
        }
        private bool isAllFiltersUnchecked()
        {
            foreach (var item in pnCarsMenu.Controls)
            {
                if (item is Guna.UI.WinForms.GunaCheckBox)
                {
                    if (((Guna.UI.WinForms.GunaCheckBox)item).Checked)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void AddCarToDataGrid(RentalCar car)
        {
            DataGrid_cars.Rows.Add(car.Available, car.AvailableFrom, car.PricePerDay, car.Brand, car.Model, car.LicensePlate, car.Type);
        }
        private void bt_find_Click(object sender, EventArgs e)
        {
            if (isAllFiltersUnchecked())
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
                List<RentalCar> filtredCars = new List<RentalCar>();
                foreach (var car in cars)
                {
                    if (chb_available.Checked && car.Available && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_sportCoupe.Checked && car.Type == chb_sportCoupe.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_suv.Checked && car.Type == chb_suv.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_stationWagon.Checked && car.Type == chb_stationWagon.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_minivan.Checked && car.Type == chb_minivan.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_electricCar.Checked && car.Type == chb_electricCar.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_cabriolet.Checked && car.Type == chb_cabriolet.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);

                    if (chb_sedan.Checked && car.Type == chb_sedan.Text && !filtredCars.Contains(car))
                        filtredCars.Add(car);
                }
                foreach (var car in filtredCars)
                {
                    AddCarToDataGrid(car);
                }
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (DataGrid_cars.Rows.Count > 0)
            {
                RentalCar rentalCar = new RentalCar()
                {
                    Available = (bool)(DataGrid_cars.SelectedRows[0]).Cells[0].Value,
                    AvailableFrom = (DateTime)(DataGrid_cars.SelectedRows[0]).Cells[1].Value,
                    PricePerDay = (int)(DataGrid_cars.SelectedRows[0]).Cells[2].Value,
                    Brand = (string)(DataGrid_cars.SelectedRows[0]).Cells[3].Value,
                    Model = (string)(DataGrid_cars.SelectedRows[0]).Cells[4].Value,
                    LicensePlate = (string)(DataGrid_cars.SelectedRows[0]).Cells[5].Value,
                    Type = (string)(DataGrid_cars.SelectedRows[0]).Cells[6].Value,
                };
                if (rentalCar.Available)
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].LicensePlate == rentalCar.LicensePlate)
                        {
                            cars.RemoveAt(i);
                            break;
                        }
                    }
                    RentalSerivce.SerializeCars(cars);
                    DataGrid_cars.Rows.Clear();
                    foreach (var car in cars)
                    {
                        AddCarToDataGrid(car);
                    }
                    MsgBox msgBox = new MsgBox("Removing car", "The car is successfully removed");
                    msgBox.ShowDialog();
                }
                else
                {
                    MsgBox msgBox = new MsgBox("Removing error", "The selected car is not available");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Removing error", "You have not chosen the car you want to remove");
                msgBox.ShowDialog();
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (DataGrid_cars.Rows.Count > 0)
            {
                RentalCar rentalCar = new RentalCar()
                {
                    Available = (bool)(DataGrid_cars.SelectedRows[0]).Cells[0].Value,
                    AvailableFrom = (DateTime)(DataGrid_cars.SelectedRows[0]).Cells[1].Value,
                    PricePerDay = (int)(DataGrid_cars.SelectedRows[0]).Cells[2].Value,
                    Brand = (string)(DataGrid_cars.SelectedRows[0]).Cells[3].Value,
                    Model = (string)(DataGrid_cars.SelectedRows[0]).Cells[4].Value,
                    LicensePlate = (string)(DataGrid_cars.SelectedRows[0]).Cells[5].Value,
                    Type = (string)(DataGrid_cars.SelectedRows[0]).Cells[6].Value,
                };
                if (rentalCar.Available)
                {
                    int index = 0;
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].LicensePlate == rentalCar.LicensePlate)
                        {
                            index = i;
                            break;
                        }
                    }
                    RentalCar editing_car = cars[index];

                    EditCarForm editCarForm = new EditCarForm(editing_car, cars, DataGrid_cars, pnCarsMenu);
                    editCarForm.TopLevel = false;
                    editCarForm.Dock = DockStyle.Fill;
                    pnChildForm.Controls.Add(editCarForm);
                    editCarForm.BringToFront();
                    pnChildForm.BringToFront();

                    editCarForm.Show();
                }
                else
                {
                    MsgBox msgBox = new MsgBox("Editing error", "The selected car is not available");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Editing error", "You have not chosen the car you want to rent");
                msgBox.ShowDialog();
            }
        }
    }
}