﻿using RentalService.Users;
using RentCar.Transport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RentalService
{
    public partial class RentalSerivce : Form
    {
        private Form ActiveForm;
        private User user;
        private List<RentalCar> cars;
        public static string path_to_cars = "cars.xml";
        public RentalSerivce(User user)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.user = user;
            lb_login.Text = user.Login;
            lb_Balance.Text = user.Balance.ToString();
            DateTime cur_date = DateTime.Now;
            lb_time.Text = cur_date.ToLongTimeString();
            lb_strdate.Text = cur_date.ToLongDateString();
            cars = DeserializeCars();
            UpdateCarsStatus(cars);
        }
        private void HideSubMenu()
        {
            if (pnSubAccountSettings.Visible)
                pnSubAccountSettings.Visible = false;
            if (pnSubRentMenu.Visible)
                pnSubRentMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void bt_Rent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubRentMenu);
        }

        private void bt_accSettings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubAccountSettings);
        }

        private void sbtR_Cars_Click(object sender, EventArgs e)
        {
            UpdateCarsStatus(cars);
            OpenChildForm(new RentCarsForm(cars, user, RentCarsForm.TableMode.AllCars, lb_Balance));
            HideSubMenu();
        }

        private void sbtR_myRcars_Click(object sender, EventArgs e)
        {
            UpdateCarsStatus(cars);
            OpenChildForm(new RentCarsForm(cars, user, RentCarsForm.TableMode.MyRentedCars, lb_Balance));
            HideSubMenu();
        }

        private void sbtAC_changePasswd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePasswordForm(user, pnDesktop));
            HideSubMenu();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeEmailForm(user, pnDesktop));
            HideSubMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cur_date = DateTime.Now;
            lb_time.Text = cur_date.ToLongTimeString();
            lb_strdate.Text = cur_date.ToLongDateString();
        }
        private void OpenChildForm(Form childForm)
        {
            if(ActiveForm!=null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            pnChildForm.BringToFront();
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            pnDesktop.BringToFront();
            HideSubMenu();
        }
        public static List<RentalCar> DeserializeCars()
        {
            List<RentalCar> rentalCars = new List<RentalCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RentalCar>));
            using (Stream fStream = File.OpenRead(path_to_cars))
            {
                rentalCars = (List<RentalCar>)xmlSerializer.Deserialize(fStream);
            }
            return rentalCars;
        }
        public static void SerializeCars(List<RentalCar> rentalCars)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RentalCar>));
            using (Stream fStream = File.Create(path_to_cars))
            {
                xmlSerializer.Serialize(fStream, rentalCars);
            }
        }

        private void bt_replishBalance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReplishBalanceForm(pnDesktop, user, lb_Balance));
            HideSubMenu();
        }
        public static void UpdateCarsStatus(List<RentalCar> rentalCars)
        {
            for (int i = 0; i < rentalCars.Count; i++)
            {
                if (!rentalCars[i].Available)
                {
                    if (rentalCars[i].AvailableFrom <= DateTime.Now)
                    {
                        rentalCars[i].AvailableFrom = DateTime.Now;
                        rentalCars[i].Available = true;
                        rentalCars[i].RentedID = 0;
                    }
                }
            }
            SerializeCars(rentalCars);
        }
    }
}
