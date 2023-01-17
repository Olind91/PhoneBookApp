﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Interface
{
    internal interface IContacts
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string City { get; set; }


    }
}