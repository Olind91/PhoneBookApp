using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Interfaces
{
    internal interface IContacts
    {
        string FirstName { get; set; }

        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string City { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
