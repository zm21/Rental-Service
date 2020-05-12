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
    public partial class ChangePasswordForm : Form
    {
        Users.User user;
        Panel Desktop;
        public ChangePasswordForm(Users.User user, Panel panel)
        {
            InitializeComponent();
            this.user = user;
            Desktop = panel;
        }

        private void bt_chngPasswd_Click(object sender, EventArgs e)
        {
            bool pass_valide = false;
            bool new_pass_valide = false;
            if (txtbox_oldPasswd.Text == user.Passwd)
                pass_valide = true;
            else
            { 
                MsgBox msgBox = new MsgBox("Bad passwords", "The old password was entered incorrectly.");
                msgBox.ShowDialog();
            }
            if (txtBox_newPasswd.Text.Length >= 5 && txtBox_newPasswd.Text == txtBox_confirmNewPasswd.Text)
                new_pass_valide = true;
            else
            {
                MsgBox msgBox = new MsgBox("Bad passwords", "Password must be at least 5 characters long. The passwords entered must match.");
                msgBox.ShowDialog();
            }
            if(new_pass_valide && pass_valide)
            {
                user.ChangePasswd(txtBox_newPasswd.Text);
                user.Serialize();
                MsgBox msgBox = new MsgBox("Changing password", "Password changed successfully");
                msgBox.ShowDialog();
                Desktop.BringToFront();
                this.Close();
            }
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            Desktop.BringToFront();
            this.Close();
        }
    }
}
