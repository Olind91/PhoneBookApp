using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Interfaces;

namespace WpfApp1.Models;




    internal class Contacts : IContacts
    {
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string City { get; set; } = null!;

    public string DisplayName => $"{FirstName} {LastName}";
}

