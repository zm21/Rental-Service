using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace RentalService.Users
{
    [Serializable]
    class User : IUser
    {
        public int ID { get; set; }
        public string Login { get; private set; }
        public string Email { get; set; }
        public string Passwd { get; private set; }
        public decimal Balance { get; private set; }
        public User(string login, string email, string passwd)
        {
            Login = login;
            Email = email;
            Passwd = passwd;
            Balance = 0;
            using (var reader = new StreamReader("users/LastUserID"))
                ID = int.Parse(reader.ReadLine());
            using (var writer = new StreamWriter("users/LastUserID"))
                writer.Write(ID + 1);
        }
        public User() { }
        public void SaveToFile()
        {
            using (var writer = new StreamWriter("users/" + Login))
            {
                writer.WriteLine(ID);
                writer.WriteLine(Login);
                writer.WriteLine(Email);
                writer.WriteLine(Passwd);
                writer.WriteLine(Balance);
            }
        }
        public void LoadFromFile(string path)
        {
            using (var reader = new StreamReader(path))
            {
                ID = int.Parse(reader.ReadLine());
                Login = reader.ReadLine();
                Email  = reader.ReadLine();
                Passwd  = reader.ReadLine();
                Balance = decimal.Parse(reader.ReadLine());
            }
        }
        public void ShowBalance() { Console.WriteLine($"Your balance: {Balance} UAH"); }
        public void ReplishBalance(decimal balance) { Balance += balance; }
        public void ChangePasswd(string new_passwd) { Passwd = new_passwd; }
        public void ChangeEmail(string new_email) { Email=new_email; }
        public void Pay(decimal ammount) { Balance -= ammount; }
    }
}
