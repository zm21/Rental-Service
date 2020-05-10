using RentalService.Users;
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
    public partial class RentalSerivce : Form
    {
        private Form ActiveForm;
        private User user;
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
            HideSubMenu();
        }

        private void sbtR_myRcars_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
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
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
