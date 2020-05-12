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

namespace RentalService
{
    public partial class AddCarForm : Form
    {
        private List<RentalCar> cars;
        Panel Desktop;
        public AddCarForm(Panel panel, List<RentalCar> cars)
        {
            InitializeComponent();
            Desktop = panel;
            this.cars = cars;
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            Desktop.BringToFront();
            this.Close();
        }

        private void bt_addcar_Click(object sender, EventArgs e)
        {
            bool brand_valide = false, model_valide = false, license_plate_valide = false, amount_valide = false;

            if (txtbox_carBrand.Text.Length > 2)
            {
                brand_valide = true;
                for (int i = 0; i < txtbox_carBrand.Text.Length; i++)
                {
                    if(char.IsDigit(txtbox_carBrand.Text[i]))
                    {
                        brand_valide = false;
                        break;
                    }
                }
            }
            if(!brand_valide)
            {
                MsgBox msgBox = new MsgBox("Error adding car", "Entered the wrong car brand. The car brand must be longer than 2 letters and not contain other characters!");
                msgBox.ShowDialog();
            }

            if (txtbox_carBrand.Text.Length > 2)
            {
                model_valide = true;
            }
            else
            {
                MsgBox msgBox = new MsgBox("Error adding car", "Entered the wrong car model. The car model must be longer than 2 characters!");
                msgBox.ShowDialog();
            }

            var num_reg = new Regex(@"^[A-Z]{2}\d{4}[A-Z]{2}$");
            if(num_reg.IsMatch(txtbox_licensePlate.Text))
            {
                license_plate_valide = true;
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].LicensePlate == txtbox_licensePlate.Text)
                    {
                        license_plate_valide = false;
                        break;
                    }
                }
                if(!license_plate_valide)
                {
                    MsgBox msgBox = new MsgBox("Error adding car", "A car with such a license plate is already there!");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Error adding car", "The license plate of the car is incorrect");
                msgBox.ShowDialog();
            }
            if(brand_valide && model_valide && license_plate_valide)
            {
                cars.Add(new RentalCar()
                {
                    Available = true, AvailableFrom = DateTime.Now, Brand = txtbox_carBrand.Text, LicensePlate = txtbox_licensePlate.Text, Model = txtbox_model.Text,
                    RentedID = 0, Type = comboBox_carType.SelectedItem.ToString(), PricePerDay = (int)numeric_pricePerDay.Value });
                RentalSerivce.SerializeCars(cars);
                MsgBox msgBox = new MsgBox("Adding car", "Car added successfully");
                msgBox.ShowDialog();
                Desktop.BringToFront();
                this.Close();
            }
        }
    }
}
