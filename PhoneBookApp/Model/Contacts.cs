using PhoneBookApp.Interface;
using System;


namespace PhoneBookApp.Models
{
    internal class Contacts : IContacts
    {
        
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string City { get; set; } = null!;


    }
}
