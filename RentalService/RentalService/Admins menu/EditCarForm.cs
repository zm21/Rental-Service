using RentCar.Transport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalService.Admins_menu
{
    public partial class EditCarForm : Form
    {
        RentalCar rentalCar;
        List<RentalCar> cars;
        Guna.UI.WinForms.GunaDataGridView DataGrid_cars;
        Panel pnCarsMenu;
        public EditCarForm(RentalCar car_to_edit, List<RentalCar> cars, Guna.UI.WinForms.GunaDataGridView DataGrid_cars, Panel cars_menu)
        {
            InitializeComponent();
            rentalCar = car_to_edit;
            txtbox_carBrand.Text = rentalCar.Brand;
            txtbox_model.Text = rentalCar.Model;
            txtbox_licensePlate.Text = rentalCar.LicensePlate;
            int index = comboBox_carType.FindString(rentalCar.Type);
            comboBox_carType.SelectedIndex = index;
            numeric_pricePerDay.Value = rentalCar.PricePerDay;
            this.cars = cars;
            this.DataGrid_cars =  DataGrid_cars;
            this.pnCarsMenu = cars_menu;
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            pnCarsMenu.BringToFront();
            this.Close();
        }

        private void bt_saveСhanges_Click(object sender, EventArgs e)
        {
            bool brand_valide = false, model_valide = false, license_plate_valide = false, amount_valide = false;

            if (txtbox_carBrand.Text.Length > 2)
            {
                brand_valide = true;
                for (int i = 0; i < txtbox_carBrand.Text.Length; i++)
                {
                    if (char.IsDigit(txtbox_carBrand.Text[i]))
                    {
                        brand_valide = false;
                        break;
                    }
                }
            }
            if (!brand_valide)
            {
                MsgBox msgBox = new MsgBox("Error editing car", "Entered the wrong car brand. The car brand must be longer than 2 letters and not contain other characters!");
                msgBox.ShowDialog();
            }

            if (txtbox_carBrand.Text.Length > 2)
            {
                model_valide = true;
            }
            else
            {
                MsgBox msgBox = new MsgBox("Error editing car", "Entered the wrong car model. The car model must be longer than 2 characters!");
                msgBox.ShowDialog();
            }

            var num_reg = new Regex(@"^[A-Z]{2}\d{4}[A-Z]{2}$");
            if (num_reg.IsMatch(txtbox_licensePlate.Text))
            {
                license_plate_valide = true;
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].LicensePlate == txtbox_licensePlate.Text && cars[i].LicensePlate != rentalCar.LicensePlate)
                    {
                        license_plate_valide = false;
                        break;
                    }
                }
                if (!license_plate_valide)
                {
                    MsgBox msgBox = new MsgBox("Error editing car", "A car with such a license plate is already there!");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Error editing car", "The license plate of the car is incorrect");
                msgBox.ShowDialog();
            }
            if (brand_valide && model_valide && license_plate_valide)
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

                rentalCar.Brand = txtbox_carBrand.Text;
                rentalCar.LicensePlate = txtbox_licensePlate.Text;
                rentalCar.Model = txtbox_model.Text;
                rentalCar.Type = comboBox_carType.SelectedItem.ToString();
                rentalCar.PricePerDay = (int)numeric_pricePerDay.Value;

                cars.RemoveAt(index);
                cars.Insert(index, rentalCar);
                RentalSerivce.SerializeCars(cars);

                DataGrid_cars.Rows.Clear();
                foreach (var car in cars)
                {
                    DataGrid_cars.Rows.Add(car.Available, car.AvailableFrom, car.PricePerDay, car.Brand, car.Model, car.LicensePlate, car.Type);
                }

                MsgBox msgBox = new MsgBox("Editing car", "The car is successfully changed");
                msgBox.ShowDialog();
                pnCarsMenu.BringToFront();
                this.Close();
            }
        }
    }
}
