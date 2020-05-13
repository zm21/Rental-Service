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
        public enum TableMode
        {
            AllCars, MyRentedCars
        }
        private TableMode RetCarsMode;
        private List<RentalCar> cars;
        private User user;
        private Label LB_balance;
        public RentCarsForm(List<RentalCar> rentalCars, User user, TableMode tableMode, Label balance)
        {
            InitializeComponent();
            RetCarsMode = tableMode;
            this.user = user;
            cars = rentalCars;
            LB_balance = balance;
            if (RetCarsMode==TableMode.MyRentedCars)
            {
                List<RentalCar> myrentedCars = new List<RentalCar>();
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].RentedID==user.ID)
                        myrentedCars.Add(cars[i]);
                }
                cars = myrentedCars;
                if(cars.Count==0)
                {
                    MsgBox msgBox = new MsgBox("Your rented car list is empty", "You have not rented any car yet");
                    msgBox.ShowDialog();
                }
                lb_numOfDayRent.Visible = false;
                numeric_daysCount.Visible = false;
                bt_rent.Visible = false;
            }
            foreach (var car in cars)
            {
                AddCarToDataGrid(car);
            }
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
            if(DataGrid_cars.SelectedRows[0]!=null)
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
                    if (user.Balance >= numeric_daysCount.Value * rentalCar.PricePerDay)
                    {
                        int index = 0;
                        for (int i = 0; i < cars.Count; i++)
                        {
                            if(cars[i].LicensePlate == rentalCar.LicensePlate)
                            {
                                index = i;
                                break;
                            }
                        }
                        cars.RemoveAt(index);
                        rentalCar.AvailableFrom = DateTime.Now;
                        rentalCar.AvailableFrom = rentalCar.AvailableFrom.AddDays((int)numeric_daysCount.Value);
                        rentalCar.Available = false;
                        rentalCar.RentedID = user.ID;
                        user.Pay(rentalCar.PricePerDay * numeric_daysCount.Value);
                        LB_balance.Text = user.Balance.ToString();
                        cars.Insert(index, rentalCar);
                        RentalSerivce.SerializeCars(cars);
                        user.Serialize();
                        DataGrid_cars.Rows.Clear();
                        foreach (var car in cars)
                        {
                            AddCarToDataGrid(car);
                        }
                    }
                    else
                    {
                        MsgBox msgBox = new MsgBox("Rental error", "There are not enough funds on your balance for this rent");
                        msgBox.ShowDialog();
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox("Rental error", "The selected car is not available");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Rental error", "You have not chosen the car you want to rent");
                msgBox.ShowDialog();
            }
        }

        private void RentCarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
