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

namespace RentalService.Admins_menu
{
    public partial class RemoveUserForm : Form
    {
        Panel Desktop;
        public RemoveUserForm(Panel desktop)
        {
            InitializeComponent();
            Desktop = desktop;
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            Desktop.BringToFront();
            this.Close();
        }

        private void bt_deleteUser_Click(object sender, EventArgs e)
        {
            bool valide = false;
            if (!File.Exists(Form1.users_path + txtbox_userLogin.Text))
            {
                MsgBox msgBox = new MsgBox("Deleting user error", "User not found");
                msgBox.ShowDialog();
            }
            else if (txtbox_userLogin.Text != "LastUserID")
                valide = true;
            if(valide)
            {
                List<string> emails = new List<string>();
                using (var reader = new StreamReader("emails/emails"))
                {
                    while (!reader.EndOfStream)
                        emails.Add(reader.ReadLine());
                }
                Users.User user_for_delete = new Users.User();
                user_for_delete.Deserialize(Form1.users_path + user_for_delete.Login);
                emails.Remove(user_for_delete.Email);
                using (var writer = new StreamWriter("emails/emails"))
                {
                    foreach (var email in emails)
                    {
                        writer.WriteLine(email.ToString());
                    }
                }
                File.Delete(Form1.users_path + user_for_delete.Login);
                MsgBox msgBox = new MsgBox("Deleting user", "User deleted successfully");
                msgBox.ShowDialog();
                Desktop.BringToFront();
                this.Close();
            }
        }
    }
}
