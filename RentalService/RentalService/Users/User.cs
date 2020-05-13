using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace RentalService.Users
{
    [Serializable]
    public class User : IUser
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
        public void Serialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fStream = File.Create(Form1.users_path + Login))
            {
                binaryFormatter.Serialize(fStream, this);
            }
        }
        public void Deserialize(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            User user = new User();
            using (Stream fStream = File.OpenRead(path))
            {
                user = (User)binaryFormatter.Deserialize(fStream);
            }
            this.ID = user.ID;
            this.Login = user.Login;
            this.Email = user.Email;
            this.Passwd = user.Passwd;
            this.Balance = user.Balance;
        }
        public void ShowBalance() { Console.WriteLine($"Your balance: {Balance} UAH"); }
        public void ReplishBalance(decimal balance) { Balance += balance; }
        public void ChangePasswd(string new_passwd) { Passwd = new_passwd; }
        public void ChangeEmail(string new_email) { Email=new_email; }
        public void Pay(decimal ammount) { Balance -= ammount; }
    }
}
