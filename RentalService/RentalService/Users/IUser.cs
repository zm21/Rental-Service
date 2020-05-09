using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.Users
{
    interface IUser
    {
        string Login { get; }
        string Passwd { get; }
        decimal Balance { get; }
    }
}
