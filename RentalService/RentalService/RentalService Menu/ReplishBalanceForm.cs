using RentalService.Users;
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
    public partial class ReplishBalanceForm : Form
    {
        Panel Desktop;
        User user;
        Label lb_balance;
        public ReplishBalanceForm(Panel desktop, User user, Label balance)
        {
            InitializeComponent();
            Desktop = desktop;
            this.user = user;
            lb_balance = balance;   
        }

        private void bt_chngEmail_Click(object sender, EventArgs e)
        {
            bool card_num_valide = false, card_date_valid = false, cvv_cvc_valide = false;
            var card_reg = new Regex(@"(^\d{16}$)|(^\d{4} \d{4} \d{4} \d{4}$)");
            if (card_reg.IsMatch(txtbox_cardNumber.Text))
                card_num_valide = true;
            else
            {
                MsgBox msgBox = new MsgBox("Payment error", "Invalid card number entered. Enter the number in the format \"1234567898765432\" or \"1234 5678 9876 5432\"");
                msgBox.ShowDialog();
            }

            if (txtbox_cardMM.Text.Length == 2 && txtbox_cardYY.Text.Length == 2)
            {
                bool date_valide = true;
                for (int i = 0; i < txtbox_cardMM.Text.Length; i++)
                {
                    if (!char.IsDigit(txtbox_cardMM.Text[i]))
                    {
                        date_valide = false;
                        break;
                    }
                }
                for (int i = 0; i < txtbox_cardYY.Text.Length; i++)
                {
                    if (!char.IsDigit(txtbox_cardYY.Text[i]))
                    {
                        date_valide = false;
                        break;
                    }
                }
                if (date_valide)
                {
                    int MM = int.Parse(txtbox_cardMM.Text);
                    int YY = int.Parse(txtbox_cardYY.Text);
                    if (MM > 0 && MM <= 12)
                    {
                        if (YY > 20)
                        {
                            card_date_valid = true;
                        }
                        else
                        {
                            MsgBox msgBox = new MsgBox("Payment error", "Invalid card expiration date. The year must be at least 21");
                            msgBox.ShowDialog();
                        }
                    }
                    else
                    {
                        MsgBox msgBox = new MsgBox("Payment error", "Invalid card expiration date. Specify a month from 1 to 12. For example \"05\"");
                        msgBox.ShowDialog();
                    }
                }
                else
                {
                    MsgBox msgBox = new MsgBox("Payment error", "Invalid card expiration date");
                    msgBox.ShowDialog();
                }
            }
            else
            {
                MsgBox msgBox = new MsgBox("Payment error", "Invalid card expiration date");
                msgBox.ShowDialog();
            }

            if (txtbox_cardCVV2_CVC2.Text.Length==3)
            {
                cvv_cvc_valide = true;
                for (int i = 0; i < txtbox_cardCVV2_CVC2.Text.Length; i++)
                {
                    if (!char.IsDigit(txtbox_cardCVV2_CVC2.Text[i]))
                    {
                        cvv_cvc_valide = false;
                        break;
                    }
                }
            }
            if(!cvv_cvc_valide)
            {
                MsgBox msgBox = new MsgBox("Payment error", "Invalid card CVV2/CVC2");
                msgBox.ShowDialog();
            }

            if(card_num_valide && card_date_valid && cvv_cvc_valide)
            {
                user.ReplishBalance(numeric_ammount.Value);
                lb_balance.Text = user.Balance.ToString();
                user.Serialize();
                MsgBox msgBox = new MsgBox("Replenishment of the balance", "The balance is successfully replenished");
                msgBox.ShowDialog();
                Desktop.BringToFront();
                this.Close();
            }
        }

        private void txtbox_carBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number!=' ')
            {
                e.Handled = true;
            }
            if (txtbox_cardNumber.Text.Length > 0 && e.KeyChar == (char)Keys.Back)
            {
                txtbox_cardNumber.Text = txtbox_cardNumber.Text.Remove(txtbox_cardNumber.Text.Length - 1);
            }
        }

        private void txtbox_cardMM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (txtbox_cardMM.Text.Length > 0 && e.KeyChar == (char)Keys.Back)
            {
                txtbox_cardMM.Text = txtbox_cardMM.Text.Remove(txtbox_cardMM.Text.Length - 1);
            }
        }

        private void txtbox_cardYY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if(txtbox_cardYY.Text.Length>0&& e.KeyChar == (char)Keys.Back)
            {
                txtbox_cardYY.Text = txtbox_cardYY.Text.Remove(txtbox_cardYY.Text.Length - 1);
            }
        }

        private void txtbox_cardCVV2_CVC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (txtbox_cardCVV2_CVC2.Text.Length > 0 && e.KeyChar == (char)Keys.Back)
            {
                txtbox_cardCVV2_CVC2.Text = txtbox_cardCVV2_CVC2.Text.Remove(txtbox_cardCVV2_CVC2.Text.Length - 1);
            }
        }

        private void bt_cacneclChanges_Click(object sender, EventArgs e)
        {
            Desktop.BringToFront();
            this.Close();
        }
    }
}
