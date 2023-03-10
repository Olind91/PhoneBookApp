using PhoneBookApp.Interface;
using System;


namespace PhoneBookApp.Models
{
    internal class Contacts : IContacts
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string City { get; set; } = null!;

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
