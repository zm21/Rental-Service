using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalService
{
    public partial class ChangeEmailForm : Form
    {
        Users.User user;
        Panel Desktop;
        public ChangeEmailForm(Users.User user, Panel panel)
        {
            InitializeComponent();
            this.user = user;
            Desktop = panel;
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            Desktop.BringToFront();
            this.Close();
        }

        private void bt_chngEmail_Click(object sender, EventArgs e)
        {
            bool email_valide = false;
            if (txtbox_Passwd.Text == user.Passwd)
            {
                List<string> emails = new List<string>();
                using (var reader = new StreamReader("emails/emails"))
                {
                    while (!reader.EndOfStream)
                        emails.Add(reader.ReadLine());
                }
                var email_reg = new Regex(@"^[a-z,A-Z,0-9](\.?[a-z,A-Z,0-9]){5,}@[a-z]{2,}\.(com|net|ua|ru)$");
                if (email_reg.IsMatch(txtBox_newEmail.Text))
                    email_valide = true;
                else
                {
                    MsgBox msgBox = new MsgBox("Bad email", "Invalid email specified.");
                    msgBox.ShowDialog();
                }
                if (email_valide && emails.Contains(txtBox_newEmail.Text))
                {
                    email_valide = false;
                    MsgBox msgBox = new MsgBox("Bad email", "A user with this email already exists!");
                    msgBox.ShowDialog();
                }
                if(email_valide)
                {
                    emails.Remove(user.Email);
                    user.ChangeEmail(txtBox_newEmail.Text);
                    user.Serialize();
                    emails.Add(txtBox_newEmail.Text);
                    using (var writer = new StreamWriter("emails/emails"))
                    {
                        foreach (var email in emails)
                        {
                            writer.WriteLine(email.ToString());
                        }
                    }
                    MsgBox msgBox = new MsgBox("Changing email", "Email changed successfully");
                    msgBox.ShowDialog();
                    Desktop.BringToFront();
                    this.Close();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Bad passwords", "The password was entered incorrectly.");
                msgBox.ShowDialog();
            }
        }
    }
}
