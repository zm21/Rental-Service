using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.Users
{
    [Serializable]
    public class Admin : User
    {
        public Admin(string login, string email, string passwd) : base(login, email, passwd)
        {
        }
        public Admin() { }
    }
}
