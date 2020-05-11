using RentalService.Users;
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
    public partial class AdminForm : Form
    {
        private Admin admin;
        private List<RentalCar> cars;
        private Form ActiveForm;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            lb_login.Text = admin.Login;
            HideSubMenu();
            cars = new List<RentalCar>(); // potom syda load
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
        private void HideSubMenu()
        {
            if (pnSubAccountSettings.Visible)
                pnSubAccountSettings.Visible = false;
            if (pnSubRentMenu.Visible)
                pnSubRentMenu.Visible = false;
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            pnDesktop.BringToFront();
            HideSubMenu();
        }

        private void sbtR_Cars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RentCarsForm(cars, admin));
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
            if (ActiveForm != null)
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

        private void bt_Rent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubRentMenu);
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

        private void sbtR_addCar_Click(object sender, EventArgs e)
        {

        }
    }
}
