using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RentalService.Users;

namespace RentalService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        private void bt_goto_SignUp_Click(object sender, EventArgs e)
        {
            pnLogin.BringToFront();
            pnLogin.Hide();
        }

        private void bt_goto_Login_Click(object sender, EventArgs e)
        {
            pnLogin.BringToFront();
            pnLogin.Show();
        }

        private void regBt_signUp_Click(object sender, EventArgs e)
        {
            bool log_valide = false;
            bool email_valide = false;
            bool pass_valide = false;

            #region check login
            if (regTxtBox_login.Text.Length >= 3 && regTxtBox_login.Text.Length <= 10)
            {
                log_valide = true;
                for (int i = 0; i < regTxtBox_login.Text.Length; i++)
                {
                    if (!char.IsLetterOrDigit(regTxtBox_login.Text[i]))
                    {
                        log_valide = false;
                        break;
                    }
                }
            }
            if (!log_valide)
            {
                MsgBox msgBox = new MsgBox("Bad login", "Login length should be between 3 and 10 characters. No special characters.");
                msgBox.ShowDialog();
            }
            if (log_valide && File.Exists("users/" + regTxtBox_login.Text))
            {
                log_valide = false;
                MsgBox msgBox = new MsgBox("Bad login", "Such a user already exists!");
                msgBox.ShowDialog();
            }
            #endregion

            #region check email
            List<string> emails = new List<string>();
            using (var reader = new StreamReader("emails/emails"))
            {
                while (!reader.EndOfStream)
                    emails.Add(reader.ReadLine());
            }
            var email_reg = new Regex(@"^[a-z,A-Z,0-9](\.?[a-z,A-Z,0-9]){5,}@[a-z]{2,}\.(com|net|ua|ru)$");
            if (email_reg.IsMatch(regTxtBox_email.Text))
                email_valide = true;
            if (!email_valide)
            {
                MsgBox msgBox = new MsgBox("Bad email", "Invalid email specified.");
                msgBox.ShowDialog();
            }
            if (email_valide && emails.Contains(regTxtBox_email.Text))
            {
                email_valide = false;
                MsgBox msgBox = new MsgBox("Bad email", "A user with this email already exists!");
                msgBox.ShowDialog();
            }
            #endregion

            #region check passwd
            if (regTxtBox_passwd.Text.Length >= 5 && regTxtBox_passwd.Text == regTxtBox_confirmPasswd.Text)
                pass_valide=true;
            if (!pass_valide)
            {
                MsgBox msgBox = new MsgBox("Bad passwords", "Password must be at least 5 characters long. The passwords entered must match.");
                msgBox.ShowDialog();
            }
            #endregion

            if(log_valide && email_valide && pass_valide)
            {
                using (var writer = new StreamWriter("emails/emails", true))
                    writer.WriteLine(regTxtBox_email.Text);
                User user = new User(regTxtBox_login.Text, regTxtBox_email.Text, regTxtBox_confirmPasswd.Text);
                user.Serialize();
                RentalSerivce rentalSerivce = new RentalSerivce();
                this.Hide();
                if (rentalSerivce.ShowDialog() == DialogResult.Retry)
                    this.Show();
                else
                    this.Close();
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (!File.Exists("users/" + logTxtBox_login.Text))
            {
                MsgBox msgBox = new MsgBox("Authorization error", "No user with this login was found!");
                msgBox.ShowDialog();
            }
            else
            {
                User user = new User();
                user.Deserialize("users/" + logTxtBox_login.Text);
                if(user.Passwd==logTxtBox_passwd.Text)
                {
                    RentalSerivce rentalSerivce = new RentalSerivce();
                    this.Hide();
                    if (rentalSerivce.ShowDialog() == DialogResult.Retry)
                        this.Show();
                    else
                        this.Close();
                }
                else
                {
                    MsgBox msgBox = new MsgBox("Authorization error", "Wrong password!");
                    msgBox.ShowDialog();
                }
            }
        }
    }
}
